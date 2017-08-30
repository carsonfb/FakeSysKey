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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            settings.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
