namespace FakeSysKey
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.okSettingsButton = new System.Windows.Forms.Button();
            this.cancelSettingsButton = new System.Windows.Forms.Button();
            this.pwSystemRadio = new System.Windows.Forms.RadioButton();
            this.pwStartupRadio = new System.Windows.Forms.RadioButton();
            this.pwStartupGroup = new System.Windows.Forms.GroupBox();
            this.staticLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.confirmText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.systemGroup = new System.Windows.Forms.GroupBox();
            this.storeRadio = new System.Windows.Forms.RadioButton();
            this.localRadio = new System.Windows.Forms.RadioButton();
            this.localLabel = new System.Windows.Forms.Label();
            this.pwStartupGroup.SuspendLayout();
            this.systemGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // okSettingsButton
            // 
            this.okSettingsButton.Location = new System.Drawing.Point(79, 310);
            this.okSettingsButton.Name = "okSettingsButton";
            this.okSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.okSettingsButton.TabIndex = 0;
            this.okSettingsButton.Text = "OK";
            this.okSettingsButton.UseVisualStyleBackColor = true;
            this.okSettingsButton.Click += new System.EventHandler(this.okSettingsButton_Click);
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Location = new System.Drawing.Point(160, 310);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSettingsButton.TabIndex = 1;
            this.cancelSettingsButton.Text = "Cancel";
            this.cancelSettingsButton.UseVisualStyleBackColor = true;
            this.cancelSettingsButton.Click += new System.EventHandler(this.cancelSettingsButton_Click);
            // 
            // pwSystemRadio
            // 
            this.pwSystemRadio.AutoSize = true;
            this.pwSystemRadio.Checked = true;
            this.pwSystemRadio.Location = new System.Drawing.Point(22, 149);
            this.pwSystemRadio.Name = "pwSystemRadio";
            this.pwSystemRadio.Size = new System.Drawing.Size(161, 17);
            this.pwSystemRadio.TabIndex = 1;
            this.pwSystemRadio.TabStop = true;
            this.pwSystemRadio.Text = "System Generated Password";
            this.pwSystemRadio.UseVisualStyleBackColor = true;
            this.pwSystemRadio.CheckedChanged += new System.EventHandler(this.pwSystemRadio_CheckedChanged);
            // 
            // pwStartupRadio
            // 
            this.pwStartupRadio.AutoSize = true;
            this.pwStartupRadio.Location = new System.Drawing.Point(22, 12);
            this.pwStartupRadio.Name = "pwStartupRadio";
            this.pwStartupRadio.Size = new System.Drawing.Size(108, 17);
            this.pwStartupRadio.TabIndex = 0;
            this.pwStartupRadio.Text = "&Password Startup";
            this.pwStartupRadio.UseVisualStyleBackColor = true;
            this.pwStartupRadio.CheckedChanged += new System.EventHandler(this.pwStartupRadio_CheckedChanged);
            // 
            // pwStartupGroup
            // 
            this.pwStartupGroup.Controls.Add(this.confirmLabel);
            this.pwStartupGroup.Controls.Add(this.passwordLabel);
            this.pwStartupGroup.Controls.Add(this.confirmText);
            this.pwStartupGroup.Controls.Add(this.passwordText);
            this.pwStartupGroup.Controls.Add(this.staticLabel);
            this.pwStartupGroup.Enabled = false;
            this.pwStartupGroup.Location = new System.Drawing.Point(12, 12);
            this.pwStartupGroup.Name = "pwStartupGroup";
            this.pwStartupGroup.Size = new System.Drawing.Size(277, 119);
            this.pwStartupGroup.TabIndex = 0;
            this.pwStartupGroup.TabStop = false;
            // 
            // staticLabel
            // 
            this.staticLabel.AutoSize = true;
            this.staticLabel.Location = new System.Drawing.Point(26, 16);
            this.staticLabel.Name = "staticLabel";
            this.staticLabel.Size = new System.Drawing.Size(239, 26);
            this.staticLabel.TabIndex = 0;
            this.staticLabel.Text = "Requires a password to be entered during system\r\nstart.";
            this.staticLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(90, 56);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(175, 20);
            this.passwordText.TabIndex = 1;
            // 
            // confirmText
            // 
            this.confirmText.Location = new System.Drawing.Point(90, 82);
            this.confirmText.Name = "confirmText";
            this.confirmText.Size = new System.Drawing.Size(175, 20);
            this.confirmText.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(26, 59);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Pass&word:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(29, 85);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(45, 13);
            this.confirmLabel.TabIndex = 4;
            this.confirmLabel.Text = "&Confirm:";
            // 
            // systemGroup
            // 
            this.systemGroup.Controls.Add(this.localLabel);
            this.systemGroup.Controls.Add(this.localRadio);
            this.systemGroup.Controls.Add(this.storeRadio);
            this.systemGroup.Location = new System.Drawing.Point(12, 149);
            this.systemGroup.Name = "systemGroup";
            this.systemGroup.Size = new System.Drawing.Size(277, 154);
            this.systemGroup.TabIndex = 2;
            this.systemGroup.TabStop = false;
            // 
            // storeRadio
            // 
            this.storeRadio.AutoSize = true;
            this.storeRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.storeRadio.Checked = true;
            this.storeRadio.Location = new System.Drawing.Point(26, 23);
            this.storeRadio.Name = "storeRadio";
            this.storeRadio.Size = new System.Drawing.Size(228, 43);
            this.storeRadio.TabIndex = 0;
            this.storeRadio.TabStop = true;
            this.storeRadio.Text = "Store Startup Key on Floppy &Disk\r\nRequires a floppy disk to be inserted during\r\n" +
    "system start.";
            this.storeRadio.UseVisualStyleBackColor = true;
            // 
            // localRadio
            // 
            this.localRadio.AutoSize = true;
            this.localRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.localRadio.Location = new System.Drawing.Point(26, 72);
            this.localRadio.Name = "localRadio";
            this.localRadio.Size = new System.Drawing.Size(144, 17);
            this.localRadio.TabIndex = 1;
            this.localRadio.Text = "Store Startup Key &Locally\r\n";
            this.localRadio.UseVisualStyleBackColor = true;
            // 
            // localLabel
            // 
            this.localLabel.AutoSize = true;
            this.localLabel.Location = new System.Drawing.Point(42, 92);
            this.localLabel.Name = "localLabel";
            this.localLabel.Size = new System.Drawing.Size(216, 39);
            this.localLabel.TabIndex = 2;
            this.localLabel.Text = "Stores a key as part of the operating system,\r\nand no interaction is during syste" +
    "m\r\nstart.\r\n";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 341);
            this.Controls.Add(this.pwSystemRadio);
            this.Controls.Add(this.systemGroup);
            this.Controls.Add(this.pwStartupRadio);
            this.Controls.Add(this.pwStartupGroup);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.okSettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Statup Key";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.pwStartupGroup.ResumeLayout(false);
            this.pwStartupGroup.PerformLayout();
            this.systemGroup.ResumeLayout(false);
            this.systemGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okSettingsButton;
        private System.Windows.Forms.Button cancelSettingsButton;
        private System.Windows.Forms.RadioButton pwSystemRadio;
        private System.Windows.Forms.RadioButton pwStartupRadio;
        private System.Windows.Forms.GroupBox pwStartupGroup;
        private System.Windows.Forms.Label staticLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.GroupBox systemGroup;
        private System.Windows.Forms.RadioButton storeRadio;
        private System.Windows.Forms.RadioButton localRadio;
        private System.Windows.Forms.Label localLabel;
        private System.Windows.Forms.TextBox confirmText;
        private System.Windows.Forms.TextBox passwordText;
    }
}