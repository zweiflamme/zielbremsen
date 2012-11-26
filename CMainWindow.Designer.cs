namespace ZusiTCPDemoApp
{
    partial class CMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                MyTCPConnection.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblV = new System.Windows.Forms.Label();
            this.lblTtg = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.grpVerbindung = new System.Windows.Forms.GroupBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpZug = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTimercontrol = new System.Windows.Forms.ComboBox();
            this.numTimecount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBrh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStreckenmeter = new System.Windows.Forms.TextBox();
            this.tbVmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.grpDebug = new System.Windows.Forms.GroupBox();
            this.lblDebugSchleudern = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblDebugBremsen = new System.Windows.Forms.Label();
            this.lblDebugScharf = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbVerz = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVneu = new System.Windows.Forms.Label();
            this.lblValt = new System.Windows.Forms.Label();
            this.lblDeltav = new System.Windows.Forms.Label();
            this.btnFlag = new System.Windows.Forms.Button();
            this.countTime = new System.Windows.Forms.Timer(this.components);
            this.btnDebugpanel = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblDebugVreached = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.grpVerbindung.SuspendLayout();
            this.grpZug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimecount)).BeginInit();
            this.pnlDebug.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.DarkGray;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(8, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 51);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Getrennt";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(3, 0);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(16, 13);
            this.lblV.TabIndex = 1;
            this.lblV.Text = "---";
            // 
            // lblTtg
            // 
            this.lblTtg.AutoSize = true;
            this.lblTtg.Location = new System.Drawing.Point(3, 22);
            this.lblTtg.Name = "lblTtg";
            this.lblTtg.Size = new System.Drawing.Size(31, 13);
            this.lblTtg.TabIndex = 2;
            this.lblTtg.Text = "--:--:--";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Location = new System.Drawing.Point(3, 44);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(16, 13);
            this.lblMeter.TabIndex = 3;
            this.lblMeter.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "km/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "m";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblV);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.lblTtg);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.lblMeter);
            this.pnlData.Location = new System.Drawing.Point(8, 99);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(101, 68);
            this.pnlData.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(10, 173);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(94, 26);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReady
            // 
            this.btnReady.Enabled = false;
            this.btnReady.Location = new System.Drawing.Point(8, 218);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(96, 39);
            this.btnReady.TabIndex = 8;
            this.btnReady.Text = "Fertig";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // pnlScore
            // 
            this.pnlScore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlScore.Controls.Add(this.label17);
            this.pnlScore.Controls.Add(this.label2);
            this.pnlScore.Controls.Add(this.lblScore);
            this.pnlScore.Location = new System.Drawing.Point(8, 277);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(101, 44);
            this.pnlScore.TabIndex = 9;
            this.pnlScore.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-1, -6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punkte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "9999";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.Controls.Add(this.grpVerbindung);
            this.pnlSettings.Controls.Add(this.grpZug);
            this.pnlSettings.Location = new System.Drawing.Point(3, 3);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(138, 303);
            this.pnlSettings.TabIndex = 10;
            // 
            // grpVerbindung
            // 
            this.grpVerbindung.Controls.Add(this.tbServer);
            this.grpVerbindung.Controls.Add(this.tbPort);
            this.grpVerbindung.Controls.Add(this.btnConnect);
            this.grpVerbindung.Location = new System.Drawing.Point(7, 3);
            this.grpVerbindung.Name = "grpVerbindung";
            this.grpVerbindung.Size = new System.Drawing.Size(121, 114);
            this.grpVerbindung.TabIndex = 12;
            this.grpVerbindung.TabStop = false;
            this.grpVerbindung.Text = "Verbindung";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(7, 26);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(74, 20);
            this.tbServer.TabIndex = 13;
            this.tbServer.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(7, 52);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(74, 20);
            this.tbPort.TabIndex = 12;
            this.tbPort.Text = "1435";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 78);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grpZug
            // 
            this.grpZug.Controls.Add(this.label15);
            this.grpZug.Controls.Add(this.cbTimercontrol);
            this.grpZug.Controls.Add(this.numTimecount);
            this.grpZug.Controls.Add(this.label8);
            this.grpZug.Controls.Add(this.lblBrh);
            this.grpZug.Controls.Add(this.label7);
            this.grpZug.Controls.Add(this.label5);
            this.grpZug.Controls.Add(this.label3);
            this.grpZug.Controls.Add(this.tbStreckenmeter);
            this.grpZug.Controls.Add(this.tbVmax);
            this.grpZug.Controls.Add(this.label6);
            this.grpZug.Location = new System.Drawing.Point(7, 122);
            this.grpZug.Name = "grpZug";
            this.grpZug.Size = new System.Drawing.Size(125, 180);
            this.grpZug.TabIndex = 12;
            this.grpZug.TabStop = false;
            this.grpZug.Text = "Zug";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "s";
            // 
            // cbTimercontrol
            // 
            this.cbTimercontrol.FormattingEnabled = true;
            this.cbTimercontrol.Items.AddRange(new object[] {
            "Countdown",
            "Stoppuhr"});
            this.cbTimercontrol.Location = new System.Drawing.Point(6, 129);
            this.cbTimercontrol.MaxDropDownItems = 2;
            this.cbTimercontrol.Name = "cbTimercontrol";
            this.cbTimercontrol.Size = new System.Drawing.Size(84, 21);
            this.cbTimercontrol.TabIndex = 23;
            this.cbTimercontrol.Text = "Countdown";
            // 
            // numTimecount
            // 
            this.numTimecount.Location = new System.Drawing.Point(6, 152);
            this.numTimecount.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numTimecount.Name = "numTimecount";
            this.numTimecount.Size = new System.Drawing.Size(60, 20);
            this.numTimecount.TabIndex = 14;
            this.numTimecount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimecount.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "BrH";
            // 
            // lblBrh
            // 
            this.lblBrh.AutoSize = true;
            this.lblBrh.Location = new System.Drawing.Point(37, 109);
            this.lblBrh.Name = "lblBrh";
            this.lblBrh.Size = new System.Drawing.Size(16, 13);
            this.lblBrh.TabIndex = 1;
            this.lblBrh.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Haltepunkt bei";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "km/h";
            // 
            // tbStreckenmeter
            // 
            this.tbStreckenmeter.Location = new System.Drawing.Point(7, 40);
            this.tbStreckenmeter.MaxLength = 9;
            this.tbStreckenmeter.Name = "tbStreckenmeter";
            this.tbStreckenmeter.Size = new System.Drawing.Size(60, 20);
            this.tbStreckenmeter.TabIndex = 2;
            this.tbStreckenmeter.Text = "000000,00";
            this.tbStreckenmeter.WordWrap = false;
            this.tbStreckenmeter.TextChanged += new System.EventHandler(this.tbStreckenmeter_TextChanged);
            // 
            // tbVmax
            // 
            this.tbVmax.Location = new System.Drawing.Point(7, 81);
            this.tbVmax.MaxLength = 3;
            this.tbVmax.Name = "tbVmax";
            this.tbVmax.Size = new System.Drawing.Size(60, 20);
            this.tbVmax.TabIndex = 7;
            this.tbVmax.Text = "50";
            this.tbVmax.TextChanged += new System.EventHandler(this.tbVmax_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Höchstgeschwindigkeit";
            // 
            // lblFlag
            // 
            this.lblFlag.BackColor = System.Drawing.SystemColors.Control;
            this.lblFlag.Location = new System.Drawing.Point(8, 74);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(96, 19);
            this.lblFlag.TabIndex = 11;
            this.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlag.Visible = false;
            // 
            // pnlDebug
            // 
            this.pnlDebug.Controls.Add(this.grpDebug);
            this.pnlDebug.Location = new System.Drawing.Point(170, 2);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(111, 303);
            this.pnlDebug.TabIndex = 12;
            this.pnlDebug.Visible = false;
            // 
            // grpDebug
            // 
            this.grpDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDebug.Controls.Add(this.lblDebugVreached);
            this.grpDebug.Controls.Add(this.lblDebugSchleudern);
            this.grpDebug.Controls.Add(this.label14);
            this.grpDebug.Controls.Add(this.btnTimer);
            this.grpDebug.Controls.Add(this.lblDebugBremsen);
            this.grpDebug.Controls.Add(this.lblDebugScharf);
            this.grpDebug.Controls.Add(this.label13);
            this.grpDebug.Controls.Add(this.label12);
            this.grpDebug.Controls.Add(this.tbVerz);
            this.grpDebug.Controls.Add(this.label11);
            this.grpDebug.Controls.Add(this.label10);
            this.grpDebug.Controls.Add(this.label9);
            this.grpDebug.Controls.Add(this.lblVneu);
            this.grpDebug.Controls.Add(this.lblValt);
            this.grpDebug.Controls.Add(this.lblDeltav);
            this.grpDebug.Controls.Add(this.btnFlag);
            this.grpDebug.Location = new System.Drawing.Point(3, 3);
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Size = new System.Drawing.Size(103, 299);
            this.grpDebug.TabIndex = 12;
            this.grpDebug.TabStop = false;
            this.grpDebug.Text = "Debug";
            this.grpDebug.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblDebugSchleudern
            // 
            this.lblDebugSchleudern.AutoSize = true;
            this.lblDebugSchleudern.Location = new System.Drawing.Point(7, 213);
            this.lblDebugSchleudern.Name = "lblDebugSchleudern";
            this.lblDebugSchleudern.Size = new System.Drawing.Size(65, 13);
            this.lblDebugSchleudern.TabIndex = 26;
            this.lblDebugSchleudern.Text = "(schleudern)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Uhr";
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(6, 270);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(84, 23);
            this.btnTimer.TabIndex = 24;
            this.btnTimer.Text = "Start / Stop";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // lblDebugBremsen
            // 
            this.lblDebugBremsen.AutoSize = true;
            this.lblDebugBremsen.Location = new System.Drawing.Point(6, 199);
            this.lblDebugBremsen.Name = "lblDebugBremsen";
            this.lblDebugBremsen.Size = new System.Drawing.Size(53, 13);
            this.lblDebugBremsen.TabIndex = 22;
            this.lblDebugBremsen.Text = "(bremsen)";
            // 
            // lblDebugScharf
            // 
            this.lblDebugScharf.AutoSize = true;
            this.lblDebugScharf.Location = new System.Drawing.Point(6, 184);
            this.lblDebugScharf.Name = "lblDebugScharf";
            this.lblDebugScharf.Size = new System.Drawing.Size(42, 13);
            this.lblDebugScharf.TabIndex = 21;
            this.lblDebugScharf.Text = "(scharf)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "max. Verzögerung";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "m/s²";
            // 
            // tbVerz
            // 
            this.tbVerz.Location = new System.Drawing.Point(6, 149);
            this.tbVerz.Name = "tbVerz";
            this.tbVerz.Size = new System.Drawing.Size(36, 20);
            this.tbVerz.TabIndex = 18;
            this.tbVerz.Text = "0,5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "deltaV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "vNeu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "vAlt";
            // 
            // lblVneu
            // 
            this.lblVneu.AutoSize = true;
            this.lblVneu.Location = new System.Drawing.Point(9, 77);
            this.lblVneu.Name = "lblVneu";
            this.lblVneu.Size = new System.Drawing.Size(16, 13);
            this.lblVneu.TabIndex = 14;
            this.lblVneu.Text = "---";
            // 
            // lblValt
            // 
            this.lblValt.AutoSize = true;
            this.lblValt.Location = new System.Drawing.Point(9, 58);
            this.lblValt.Name = "lblValt";
            this.lblValt.Size = new System.Drawing.Size(16, 13);
            this.lblValt.TabIndex = 13;
            this.lblValt.Text = "---";
            // 
            // lblDeltav
            // 
            this.lblDeltav.AutoSize = true;
            this.lblDeltav.Location = new System.Drawing.Point(9, 100);
            this.lblDeltav.Name = "lblDeltav";
            this.lblDeltav.Size = new System.Drawing.Size(16, 13);
            this.lblDeltav.TabIndex = 12;
            this.lblDeltav.Text = "---";
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(6, 25);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(60, 23);
            this.btnFlag.TabIndex = 11;
            this.btnFlag.Text = "flag";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // countTime
            // 
            this.countTime.Tick += new System.EventHandler(this.countTime_Tick);
            // 
            // btnDebugpanel
            // 
            this.btnDebugpanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnDebugpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugpanel.Location = new System.Drawing.Point(147, 121);
            this.btnDebugpanel.Name = "btnDebugpanel";
            this.btnDebugpanel.Size = new System.Drawing.Size(17, 81);
            this.btnDebugpanel.TabIndex = 13;
            this.btnDebugpanel.Text = "DEBUG";
            this.btnDebugpanel.UseVisualStyleBackColor = true;
            this.btnDebugpanel.Click += new System.EventHandler(this.btnDebugpanel_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.AutoSize = true;
            this.pnlRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRight.Controls.Add(this.pnlSettings);
            this.pnlRight.Controls.Add(this.btnDebugpanel);
            this.pnlRight.Controls.Add(this.pnlDebug);
            this.pnlRight.Location = new System.Drawing.Point(118, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(284, 309);
            this.pnlRight.TabIndex = 14;
            // 
            // lblDebugVreached
            // 
            this.lblDebugVreached.AutoSize = true;
            this.lblDebugVreached.Location = new System.Drawing.Point(8, 229);
            this.lblDebugVreached.Name = "lblDebugVreached";
            this.lblDebugVreached.Size = new System.Drawing.Size(63, 13);
            this.lblDebugVreached.TabIndex = 27;
            this.lblDebugVreached.Text = "(vReached)";
            // 
            // CMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(409, 329);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.lblFlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CMainWindow";
            this.Text = "Zielbremsen - v0.8beta";
            this.TopMost = true;
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.grpVerbindung.ResumeLayout(false);
            this.grpVerbindung.PerformLayout();
            this.grpZug.ResumeLayout(false);
            this.grpZug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimecount)).EndInit();
            this.pnlDebug.ResumeLayout(false);
            this.grpDebug.ResumeLayout(false);
            this.grpDebug.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblTtg;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblBrh;
        private System.Windows.Forms.TextBox tbStreckenmeter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVmax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpVerbindung;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.GroupBox grpZug;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numTimecount;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.Timer countTime;
        private System.Windows.Forms.GroupBox grpDebug;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.ComboBox cbTimercontrol;
        private System.Windows.Forms.Label lblDebugBremsen;
        private System.Windows.Forms.Label lblDebugScharf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbVerz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVneu;
        private System.Windows.Forms.Label lblValt;
        private System.Windows.Forms.Label lblDeltav;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnDebugpanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDebugSchleudern;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDebugVreached;

    }
}

