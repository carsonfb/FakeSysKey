using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeSysKey
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelSettingsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pwSystemRadio_CheckedChanged(object sender, EventArgs e)
        {
            systemGroup.Enabled    = true;
            pwStartupGroup.Enabled = false;
        }

        private void pwStartupRadio_CheckedChanged(object sender, EventArgs e)
        {
            pwStartupGroup.Enabled = true;
            systemGroup.Enabled    = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void okSettingsButton_Click(object sender, EventArgs e)
        {
            errorForm error    = new errorForm();
            error.passwordText = this.passwordText.Text;
            error.confirmText  = this.confirmText.Text;

            error.Show();
        }
    }
}
