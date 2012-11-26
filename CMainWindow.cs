using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; //
using System.Diagnostics; // für Stoppuhr
using Zusi_Datenausgabe; //DEBUG: v1.0.0

/* ZusiTCPDemoApp
 * This example shows basic usage of Andreas Karg's Zusi TCP interface for .Net.
 * It is published under the GNU General Public License v3.0. Base your own work on it, play around, do what you want. :-)
 * 
 * 
 * Using the interface requires three steps:
 * - Write one or more handler methods
 * - Create a ZusiTcpConn object, passing basic parameters
 * - Tell your ZusiTcpConn object what measures you want to receive
 * 
 * Everything else is explained below. */

namespace ZusiTCPDemoApp
{
    public partial class CMainWindow : Form
    {
        // We do want to have a ZusiTcpConn object, so here's the declaration
        private ZusiTcpConn MyTCPConnection;

        // Initalize a new stopwatch
        Stopwatch stopwatch = new Stopwatch();

        public CMainWindow()
        {
            InitializeComponent();

            /* When the application window is created, we create our new connection class as well.
             * ReceiveEvent<T> is a generic delegate type for you to use. See the Object Browser for details. */

            MyTCPConnection = new ZusiTcpConn(
             "Zielbremsen v0.8beta",                            // The name of this application (Shows up on the server's list)
             // ClientPriority.Low                                 // The priority with which the server should treat you
             ClientPriority.High,                            
             new ReceiveEvent<float>(HandleIncomingData),   // A delegate method for the connection class to call when it receives float data (may be null)
             null,                                          // A delegate method for the connection class to call when it receives string data (may be null)
             null                                           //DEBUG: Using v 1.0.0 of Zusi-Datenausgabe.dll
                                                            // (Using v 1.1.6 of Zusi-Datenausgabe.dll)
            );



            MyTCPConnection.RequestData(2654); // "Bremshundertstel"
            MyTCPConnection.RequestData(2561); // "Geschwindigkeit"
            MyTCPConnection.RequestData(2563); // "Druck Bremszylinder"
            MyTCPConnection.RequestData(2645); // "Strecken-Km in Metern"
            MyTCPConnection.RequestData(2599); // "LM Schleudern"      
        }

        public void Timing(String command)
        {
            if (command == "Start")
            {
                countTime.Enabled = true;
                stopwatch.Reset();
                stopwatch.Start();
            }
            else if (command == "Stop")
            {
                stopwatch.Stop();
            }
            else if (command == "Reset")
            {
                countTime.Enabled = false;
                stopwatch.Reset();
                lblTtg.Text = "--:--:--";
            }
        }

        public void ResetDebugLabels() // Resetting all the labels on the Debug panel to their initial state
        {
            lblDebugBremsen.Text = "(gebremst?)";
            lblDebugScharf.Text = "(scharf?)";
            lblDebugSchleudern.Text = "(geschleudert?)";
            lblDebugVreached.Text = "(vReached)";
        }

        public void ResetGlobals() // Resetting all global variables
        {

            lblFlag.Visible = false;
            hasMoved = false;
            pnlRight.Visible = true;
            abbruch = false;
            scharf = false;
            vMaxErreicht = false;
            gebremst = false;
 
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            ResetDebugLabels();
            ResetGlobals();

            if (btnReady.Text == "Fertig")
            {
                abbruch = false;
                pnlRight.Visible = debugging; // Wenn im Status "debugging" bleibt das Panel sichtbar
                lblStatus.Text = "Beschleunigen!"; // Anzeigen, dass das Programm fertig ist und auf das Beschleunigen des Zuges wartet
            }
            else if (btnReady.Text == "Abbruch")
            {
                ResetGlobals();
                if (btnConnect.Text == "Trennen") setStatus("Verbunden"); //wenn wir noch mit Zusi verbunden sind gehe in Status "Verbunden"
                else setStatus("Warte");

                Timing("Reset");
                lblTtg.Text = "--:--:--";

            }
            else if (btnReady.Text == "Neustart")
            {
                pnlRight.Visible = true;
                ResetGlobals();
                if (btnConnect.Text == "Trennen")
                {
                    setStatus("Verbunden"); //wenn wir noch mit Zusi verbunden sind gehe in Status "Verbunden" 
                    Timing("Reset");
                }
                else
                    setStatus("Warte");
            }
        }

        public void Connect()
        {

            String server = Convert.ToString(tbServer.Text);
            int port = Convert.ToInt16(tbPort.Text);

            {
                // If we're currently disconnected...
                if (MyTCPConnection.ConnectionState == Zusi_Datenausgabe.ConnectionState.Disconnected)
                {
                    // ... try to ... 
                    try
                    {
                        // ... establish a connection using the hostname and port number from the main window.
                        MyTCPConnection.Connect(server, port);
                        setStatus("Warte");
                    }

                    // If something goes wrong...
                    catch (ZusiTcpException ex)
                    {
                        // ... show the user what the connection object has to say.
                        MessageBox.Show(String.Format("Verbindungsfehler: {0}", ex.Message));
                        MyTCPConnection.Disconnnect();
                        setStatus("Getrennt");
                    }
                }

                // If we're currently connected or the connection fell into an error state...
                else
                {
                    // ... reset the connection by explicitly calling Disconnect();
                    MyTCPConnection.Disconnnect();
                    setStatus("Getrennt");
                }
            }
        }

        public String CalculateScore()
        {

            double meter, score1, score2;
            double scoreFinal;
            meter = Convert.ToDouble(lblMeter.Text);

            score1 = (brh / 10) * meter; // (BrH / 10 * Meter)            

            if (ttgPublic < 0) //wenn Verspätung
            {
                score2 = (brh / 10) * -ttgPublic; // (BrH / 10 * Verspätung)
            }
            else
                score2 = 0;  //kein Abzug wenn pünktlich oder zu früh

            scoreFinal = (score1 + score2);

            if (scharf == true) scoreFinal = scoreFinal * 1.33; // wenn scharf angehalten wurde

            if (scoreFinal < 0) scoreFinal = scoreFinal * -1; // Damit keine negativen Werte als Punktzahl ausgegeben werden

            scoreFinal = Convert.ToInt32(scoreFinal);

            return Convert.ToString(scoreFinal);
        }

        public bool abbruch;

        double vorgabe, entfernung;
        double streckenmeter = 0;
        bool hasMoved = false;
        double brh;
        double maxVerz = 1; //maximale Verzögerung 
        bool scharf = false; //wurde scharf angehalten?
        bool gebremst = false; // wurde nach dem Beschleunigen gebremst?
        bool verbunden = false;


        //TEST
        double vAlt = 0, vNeu = 0, deltaV; //Zur Messung der Verzögerung
        double vTemp = 0;

        //TODO: TEST: Setting a maximum reached speed vReached
        double vReached = 0;

        public double BerechneEntfernung(double streckenmeter)
        {
            vorgabe = Convert.ToDouble(tbStreckenmeter.Text); // Vorgegebener Haltepunkt
            entfernung = vorgabe - (Convert.ToDouble(streckenmeter)); // Entfernung zum Haltepunkt
            return entfernung;
        }

        //TODO: Uhrzeit verwenden
        private void HandleIncomingData(DataSet<float> dataSet)
        {
            if (dataSet.Id == MyTCPConnection["Bremshundertstel"]) // 2654
            {
                if (dataSet.Value > 0)
                {
                    setStatus("Verbunden");

                    brh = Convert.ToDouble(dataSet.Value);
                    lblBrh.Text = String.Format("{0}", brh);                    
                }

            }
            else if (dataSet.Id == MyTCPConnection["Geschwindigkeit"]) // 2561
            {
                if (verbunden)
                {
                    double geschwindigkeit = dataSet.Value;
                    double vMax = Convert.ToDouble(tbVmax.Text);

                    if (geschwindigkeit >= 1 && hasMoved == false)
                    {
                        hasMoved = true;
                        setStatus("Beschleunigen");
                    }

                    if (hasMoved == true && geschwindigkeit >= vMax)
                    {
                        // Beschleunigen abgeschlossen                    
                        setStatus("VMax");

                    }
                    if (hasMoved == true && geschwindigkeit == 0) //Lok ist zum Stillstand gekommen
                    {
                        if (vMaxErreicht == false && abbruch == false) setStatus("Abbruch-1"); //wenn vMax nicht erreicht wurde ohne Abbruch
                        else
                        {
                            maxVerz = Convert.ToDouble(tbVerz.Text);
                            if (deltaV < -maxVerz && abbruch == false) //wenn scharf angehalten wurde mit Ergebnis
                            {
                                lblFlag.Visible = true; lblFlag.Text = "scharf angehalten"; lblFlag.BackColor = Color.Orange;
                                scharf = true;
                            }

                            setStatus("Ergebnis");

                        }

                    }

                    lblV.Text = String.Format("{0:f}", dataSet.Value); //Geschwindigkeit anzeigen

                    if (vAlt > 0)
                    {
                        vNeu = dataSet.Value; //wenn vAlt bereits gespeichert wurde, speichere den neuen Wert in vNeu

                    }

                    else
                    {
                        vAlt = dataSet.Value; //ansonsten speichere den Wert für vAlt

                    }

                    

                    if (gebremst == true)
                    {
                        if (vReached == 0) // storing the maximum reached speed
                        {
                            vReached = geschwindigkeit;                                  
                        }                        
                        //DEBUG:
                        lblDebugBremsen.Text = "gebremst!";
                        lblDebugVreached.Text = vReached.ToString();
                    }

                    //TODO: Find a better way to check if acceleration has been made after reaching vReached
                    if (gebremst == true && deltaV > 0.2)
                    {
                        setStatus("Abbruch-2");
                    }
                }
            }
            else if (dataSet.Id == MyTCPConnection["Druck Bremszylinder"]) // 2563
            {

                if (verbunden)
                {
                    if (vMaxErreicht == true && dataSet.Value > 0.1) { gebremst = true; lblDebugBremsen.Text = "gebremst!"; }
                }

            }
            else if (dataSet.Id == MyTCPConnection["LM Schleudern"]) // 2599
            {
                if (verbunden)
                {
                    if (dataSet.Value > 0) setStatus("Abbruch-3");
                }

            }
            else if (dataSet.Id == MyTCPConnection["Strecken-Km"]) // 2645
            {
                if (verbunden)
                {
                    if (tbStreckenmeter.Text == "000000,00")
                        tbStreckenmeter.Text = String.Format("{0:f}", dataSet.Value); //Füllt die Textbox mit dem aktuellen Streckenmeter                              

                    if (dataSet.Value > 0)
                    {
                        streckenmeter = Convert.ToDouble(dataSet.Value);
                        lblMeter.Text = String.Format("{0:f}", BerechneEntfernung(streckenmeter));
                    }
                    else lblMeter.Text = "---";
                }

            }


        }

        public bool vMaxErreicht = false;


        public void setStatus(String statusNeu)
        {
            if (statusNeu == "Getrennt")
            {
                btnConnect.Text = "Verbinden";
                btnReady.Text = "Fertig";
                btnReady.Enabled = false;
                lblStatus.Text = "Getrennt";
                lblStatus.BackColor = Color.DarkGray;
                pnlScore.Visible = false;
            }
            else if (statusNeu == "Warte")
            {
                btnConnect.Text = "Trennen";
                lblStatus.Text = "Warte auf Zusi";
                lblStatus.BackColor = Color.LemonChiffon;
                pnlData.Visible = true;
                pnlScore.Visible = false;
                pnlRight.Visible = true;
                btnReady.Enabled = false;
                btnReady.Text = "Fertig";
            }
            else if (statusNeu == "Verbunden")
            {
                btnReady.Enabled = true;
                btnReady.Text = "Fertig";
                lblStatus.BackColor = Color.LemonChiffon;
                lblStatus.Text = "Zusi verbunden - Bereit";
                pnlScore.Visible = false;
                verbunden = true;
            }
            else if (statusNeu == "Beschleunigen" && abbruch == false && vMaxErreicht == false)
            {
                lblStatus.Text = "Beschleunigen";
                lblStatus.BackColor = Color.LightBlue;
                // TEST pnlRight.Visible = false;  // TODO: change accordingly to user settings
                pnlRight.Visible = debugging; //wenn debugging==true, dann alles sichtbar
                pnlDebug.Visible = debugging;
                pnlData.Visible = true; // TODO: change accordingly to user settings
                pnlScore.Visible = false;
                btnReady.Text = "Abbruch";

                Timing("Start"); //Starte Timer neu
            }
            else if (statusNeu == "VMax" && abbruch == false)
            {
                vMaxErreicht = true;
                lblStatus.BackColor = Color.LightGreen;
                lblStatus.Text = "Bremsen frei -vMax erreicht!";
                pnlScore.Visible = false;
            }
            else if (statusNeu == "Ergebnis" && abbruch == false)
            {
                lblStatus.BackColor = Color.LightGreen;
                lblStatus.Text = "Ergebnis";
                lblDebugScharf.Text = Convert.ToString(scharf); //DEBUG
                lblScore.Text = CalculateScore();
                lblDebugScharf.Text = Convert.ToString(scharf); //DEBUG
                pnlScore.Visible = true;
                btnReady.Text = "Neustart";

                stopwatch.Stop();


            }
            else if (statusNeu == "Abbruch-1")
            {
                lblFlag.Visible = false;
                lblStatus.Text = "Nicht bis vMax beschleunigt!";
                lblStatus.BackColor = Color.Orange;
                pnlScore.Visible = false;
                abbruch = true;
                btnReady.Text = "Neustart";
                Timing("Stop");
            }
            else if (statusNeu == "Abbruch-2")
            {
                lblFlag.Visible = false;
                lblStatus.Text = "Nach Bremsen beschleunigt!";
                lblStatus.BackColor = Color.Orange;
                pnlScore.Visible = false;
                abbruch = true;
                btnReady.Text = "Neustart";
                Timing("Stop");
            }
            else if (statusNeu == "Abbruch-3")
            {
                lblFlag.Visible = false;
                lblStatus.Text = "Geschleudert!";
                lblStatus.BackColor = Color.Orange;
                pnlScore.Visible = false;
                abbruch = true;
                btnReady.Text = "Neustart";
                Timing("Stop");
            }



        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlRight.Visible = !pnlRight.Visible;
                        
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void tbStreckenmeter_TextChanged(object sender, EventArgs e)
        {
            if (tbStreckenmeter.Text == "") tbStreckenmeter.Text = "000000,00";
            lblMeter.Text = String.Format("{0:f}", BerechneEntfernung(streckenmeter));
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            //TEST
            lblFlag.Visible = !lblFlag.Visible;
            lblFlag.BackColor = Color.Orange;
            lblFlag.Text = "TEST";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TEST
            double timerFactor = 1000 / timer1.Interval; //TEST

            vTemp = vAlt; //zwischenspeichern von vAlt
            vAlt = 0;

            deltaV = (vNeu - vTemp) / 3.6 * timerFactor; //in m/s mit Faktor

            lblValt.Text = String.Format("{0:f}", vTemp); //DEBUG
            lblVneu.Text = String.Format("{0:f}", vNeu); //DEBUG
            lblDeltav.Text = String.Format("{0:f}", deltaV); //DEBUG

        }

        private void tbVmax_TextChanged(object sender, EventArgs e)
        {
            if (tbVmax.Text == "") tbVmax.Text = "100";
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (countTime.Enabled == false)
            {
                countTime.Enabled = true;
                stopwatch.Start();
            }
            else
            {
                countTime.Enabled = false;
                stopwatch.Reset();
            }
        }

        //TEST Time to go global verfügbar machen
        int ttgPublic = 0;

        private void countTime_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = stopwatch.Elapsed;

            int hours = (int)elapsed.TotalHours;
            int minutes = (int)elapsed.TotalMinutes;
            double fsec = 60 * (elapsed.TotalMinutes - minutes); //damit nicht 00:01:61 ausgegeben wird für die Stoppuhr
            double sec = elapsed.TotalSeconds; //für den Countdown
            //double ms = 1000 * (fsec - sec);
            int ttg = (int)numTimecount.Value - (int)sec; //Countdown: Time To Go

            string tsOut = String.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, (int)fsec); //Stoppuhr-Ausgabestring
            string ttgOut; //Für den Countdown

            // Time to go global verfügbar machen
            ttgPublic = ttg;

            if (ttg >= 0)
            {
                ttgOut = String.Format("noch {0} s", ttg);
            }
            else
                ttgOut = String.Format("Verspätung {0} s", -ttg); //negativen ttg-Wert umkehren

            //TEST
            if (cbTimercontrol.Text == "Stoppuhr")
                lblTtg.Text = tsOut;
            else
                lblTtg.Text = ttgOut;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


        }

        //TEST debugging-modus speichern
        public bool debugging = false;

        private void btnDebugpanel_Click(object sender, EventArgs e)
        {
            if (debugging == true)
            {
                pnlDebug.Visible = false;
                debugging = false;
            }
            else if (debugging == false)
            {
                pnlDebug.Visible = true;
                debugging = true;
            }
        }
    }
}
