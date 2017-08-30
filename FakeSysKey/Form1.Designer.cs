namespace FakeSysKey
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.disabledRadio = new System.Windows.Forms.RadioButton();
            this.enabledRadio = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(51, 163);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(72, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(130, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateButton.Location = new System.Drawing.Point(209, 163);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(72, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // disabledRadio
            // 
            this.disabledRadio.AutoSize = true;
            this.disabledRadio.Enabled = false;
            this.disabledRadio.Location = new System.Drawing.Point(79, 112);
            this.disabledRadio.Name = "disabledRadio";
            this.disabledRadio.Size = new System.Drawing.Size(119, 17);
            this.disabledRadio.TabIndex = 4;
            this.disabledRadio.Text = "Encryption &Disabled";
            this.disabledRadio.UseVisualStyleBackColor = true;
            // 
            // enabledRadio
            // 
            this.enabledRadio.AutoSize = true;
            this.enabledRadio.Checked = true;
            this.enabledRadio.Location = new System.Drawing.Point(79, 133);
            this.enabledRadio.Name = "enabledRadio";
            this.enabledRadio.Size = new System.Drawing.Size(117, 17);
            this.enabledRadio.TabIndex = 0;
            this.enabledRadio.TabStop = true;
            this.enabledRadio.Text = "Encryption &Enabled";
            this.enabledRadio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mainMessage
            // 
            this.mainMessage.Location = new System.Drawing.Point(78, 18);
            this.mainMessage.Name = "mainMessage";
            this.mainMessage.Size = new System.Drawing.Size(245, 91);
            this.mainMessage.TabIndex = 6;
            this.mainMessage.Text = "This tool will allow you to configure the Accounts Database to enable additional " +
    "encryption, further protecting the database from compromise.\r\n\r\nOnce enabled, th" +
    "is encryption cannot be\r\ndisabled.";
            this.mainMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 195);
            this.Controls.Add(this.mainMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enabledRadio);
            this.Controls.Add(this.disabledRadio);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Securing the Windows Account Database";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton disabledRadio;
        private System.Windows.Forms.RadioButton enabledRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainMessage;
    }
}

