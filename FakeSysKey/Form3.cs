using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Fake Syskey
    Copyright 2022, Carson F. Ball

    This program can be used by scambaiters to replace the actual Syskey program on their VM.  Syskey is a
    program that can be used to set a security password on a computer running Windows which must be entered
    in order to use the computer.  This is different that the Windows login password.  Scammers will sometimes
    set a password and then extort money from victims with the promise of giving control of their computers
    back.  Sometimes the scammers will blame a virus or "hackers" for the lock-out.

    Fake Syskey will not actually set a password and will display the password that the scammer typed into
    the entry field.  This information can be used (assuming they use the same password on the computeres of
    multiple victims) to help others recover their computers.

    To simplest way to use the program is to rename FakeSysKey.exe to syskey.exe and place it in a folder that
    is ahead of the real Syskey program in your path.

    The most fool-proof way to use the program, however, is to replace the actual Syskey program with FakeSysKey.
    This will likely require rebooting into safe mode.

    Fake Syskey is released under the Creative commons Attribution-NonCommercial (CC BY-NC) licence.  You can
    read the plain text of the license at https://creativecommons.org/licenses/by-nc/4.0/.  You can read the
    entire "legalese" of the license at https://creativecommons.org/licenses/by-nc/4.0/legalcode.
*/

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
            /*
                This function displays an "error" message revealing the password that the user typed.  This could shed light
                on passwords that the scammer has used to lock other people's computers (to assist with recovery).

                A real error message would, obviously, not actually reveal the typed password in plain text.  Hopefully the
                scammer does not notice this and would continue to waste their time on the call.
            */
            string errorMsg;

            errorMsg = "Password mismatch, the password '" + passwordText + "' does not match '" + breakCharacter() + "'.";

            return (errorMsg);
        }

        private string breakCharacter()
        {
            /*
                This function alters one of the characters in the confirmation password string in order to make it appear
                as if the user mistyped it.  This provides an excuse to display an error message (though a real error
                message would not actually show the passwords in plain text).
            */

            Random rnd            = new Random();
            int strLen            = confirmText.Length;
            int pos               = rnd.Next(1, strLen);
            int randChar          = rnd.Next(1, 122);
            StringBuilder tempStr = new StringBuilder(confirmText);
            tempStr[pos] = (char)randChar;

            return(tempStr.ToString());
        }

        private void errorOkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}