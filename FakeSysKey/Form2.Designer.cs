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
            this.SuspendLayout();
            // 
            // okSettingsButton
            // 
            this.okSettingsButton.Location = new System.Drawing.Point(79, 340);
            this.okSettingsButton.Name = "okSettingsButton";
            this.okSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.okSettingsButton.TabIndex = 0;
            this.okSettingsButton.Text = "OK";
            this.okSettingsButton.UseVisualStyleBackColor = true;
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Location = new System.Drawing.Point(160, 340);
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
            this.pwSystemRadio.Location = new System.Drawing.Point(27, 157);
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
            this.pwStartupRadio.Location = new System.Drawing.Point(12, 0);
            this.pwStartupRadio.Name = "pwStartupRadio";
            this.pwStartupRadio.Size = new System.Drawing.Size(108, 17);
            this.pwStartupRadio.TabIndex = 0;
            this.pwStartupRadio.Text = "&Password Startup";
            this.pwStartupRadio.UseVisualStyleBackColor = true;
            this.pwStartupRadio.CheckedChanged += new System.EventHandler(this.pwStartupRadio_CheckedChanged);
            // 
            // pwStartupGroup
            // 
            this.pwStartupGroup.Enabled = false;
            this.pwStartupGroup.Location = new System.Drawing.Point(2, 5);
            this.pwStartupGroup.Name = "pwStartupGroup";
            this.pwStartupGroup.Size = new System.Drawing.Size(322, 146);
            this.pwStartupGroup.TabIndex = 0;
            this.pwStartupGroup.TabStop = false;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 371);
            this.Controls.Add(this.pwStartupRadio);
            this.Controls.Add(this.pwStartupGroup);
            this.Controls.Add(this.pwSystemRadio);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.okSettingsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.Text = "Statup Key";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okSettingsButton;
        private System.Windows.Forms.Button cancelSettingsButton;
        private System.Windows.Forms.RadioButton pwSystemRadio;
        private System.Windows.Forms.RadioButton pwStartupRadio;
        private System.Windows.Forms.GroupBox pwStartupGroup;
    }
}