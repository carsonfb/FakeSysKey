namespace FakeSysKey
{
    partial class errorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(errorForm));
            this.mismatchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mismatchLabel
            // 
            this.mismatchLabel.Location = new System.Drawing.Point(12, 9);
            this.mismatchLabel.Name = "mismatchLabel";
            this.mismatchLabel.Size = new System.Drawing.Size(260, 243);
            this.mismatchLabel.TabIndex = 0;
            this.mismatchLabel.Text = "placeholer";
            this.mismatchLabel.UseMnemonic = false;
            this.mismatchLabel.Click += new System.EventHandler(this.mismatchLabel_Click);
            // 
            // errorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mismatchLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "errorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.errorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mismatchLabel;
    }
}