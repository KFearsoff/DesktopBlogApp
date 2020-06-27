using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length > 20)
            {
                MessageBox.Show("The username is too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataAccess.SignIn(textBoxUsername.Text, PasswordEncrypter.Encrypt(textBoxPassword.Text), out MainForm.CurrentUser))
                Close();
            else MessageBox.Show("There is no such user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
