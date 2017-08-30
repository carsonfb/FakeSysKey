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
    public partial class errorForm : Form
    {
        public string passwordText;
        public string confirmText;

        public errorForm()
        {
            InitializeComponent();
        }

        private void errorForm_Load(object sender, EventArgs e)
        {
            mismatchLabel.Text = mismatchString();
        }

        private void mismatchLabel_Click(object sender, EventArgs e)
        {
        }

        private string mismatchString()
        {
            string errorMsg;

            errorMsg = "Password mismatch, the password '" + passwordText + "' does not match '" + breakCharacter() + "'.";

            return (errorMsg);
        }

        private string breakCharacter()
        {

            Random rnd            = new Random();
            int strLen            = confirmText.Length;
            int pos               = rnd.Next(1, strLen);
            int randChar          = rnd.Next(1, 122);
            StringBuilder tempStr = new StringBuilder(confirmText);
            tempStr[pos] = (char)randChar;

            return(tempStr.ToString());
        }
    }
}