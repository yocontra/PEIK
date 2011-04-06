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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageKeylogger = new System.Windows.Forms.TabPage();
            this.tabPageStealer = new System.Windows.Forms.TabPage();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMainType = new System.Windows.Forms.GroupBox();
            this.radioButtonMainKeylogger = new System.Windows.Forms.RadioButton();
            this.radioButtonMainBotnet = new System.Windows.Forms.RadioButton();
            this.radioButtonMainRAT = new System.Windows.Forms.RadioButton();
            this.groupBoxKeyloggerEmail = new System.Windows.Forms.GroupBox();
            this.groupBoxKeyloggerSend = new System.Windows.Forms.GroupBox();
            this.radioButtonKeyloggerSendEmail = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.labelKeyloggerEmailFromName = new System.Windows.Forms.Label();
            this.textBoxKeyloggerEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxKeyloggerEmailPassword = new System.Windows.Forms.TextBox();
            this.labelKeyloggerEmailPassword = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageKeylogger.SuspendLayout();
            this.groupBoxMainType.SuspendLayout();
            this.groupBoxKeyloggerEmail.SuspendLayout();
            this.groupBoxKeyloggerSend.SuspendLayout();
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
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 386);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(555, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
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
            // tabPageKeylogger
            // 
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
            // tabPageStealer
            // 
            this.tabPageStealer.Location = new System.Drawing.Point(4, 22);
            this.tabPageStealer.Name = "tabPageStealer";
            this.tabPageStealer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStealer.Size = new System.Drawing.Size(547, 336);
            this.tabPageStealer.TabIndex = 2;
            this.tabPageStealer.Text = "Stealers";
            this.tabPageStealer.UseVisualStyleBackColor = true;
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buildToolStripMenuItem.Text = "&Build";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
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
            // groupBoxKeyloggerEmail
            // 
            this.groupBoxKeyloggerEmail.Controls.Add(this.textBoxKeyloggerEmailPassword);
            this.groupBoxKeyloggerEmail.Controls.Add(this.labelKeyloggerEmailPassword);
            this.groupBoxKeyloggerEmail.Controls.Add(this.textBoxKeyloggerEmailAddress);
            this.groupBoxKeyloggerEmail.Controls.Add(this.labelKeyloggerEmailFromName);
            this.groupBoxKeyloggerEmail.Location = new System.Drawing.Point(8, 61);
            this.groupBoxKeyloggerEmail.Name = "groupBoxKeyloggerEmail";
            this.groupBoxKeyloggerEmail.Size = new System.Drawing.Size(200, 107);
            this.groupBoxKeyloggerEmail.TabIndex = 0;
            this.groupBoxKeyloggerEmail.TabStop = false;
            this.groupBoxKeyloggerEmail.Text = "Email";
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
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(62, 19);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(72, 17);
            this.radioButton.TabIndex = 1;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "Webpage";
            this.radioButton.UseVisualStyleBackColor = true;
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
            // textBoxKeyloggerEmailAddress
            // 
            this.textBoxKeyloggerEmailAddress.Location = new System.Drawing.Point(86, 17);
            this.textBoxKeyloggerEmailAddress.Name = "textBoxKeyloggerEmailAddress";
            this.textBoxKeyloggerEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeyloggerEmailAddress.TabIndex = 1;
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
            this.Text = "PEIK";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageKeylogger.ResumeLayout(false);
            this.groupBoxMainType.ResumeLayout(false);
            this.groupBoxMainType.PerformLayout();
            this.groupBoxKeyloggerEmail.ResumeLayout(false);
            this.groupBoxKeyloggerEmail.PerformLayout();
            this.groupBoxKeyloggerSend.ResumeLayout(false);
            this.groupBoxKeyloggerSend.PerformLayout();
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
    }
}

