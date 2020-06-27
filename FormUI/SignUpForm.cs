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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = PasswordEncrypter.Encrypt(textBoxPassword.Text);

            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DataAccess.SignUp(username, password))
            {
                MessageBox.Show("There is already a user with those credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataAccess.SignIn(username, password, out MainForm.CurrentUser);
            Close();
        }
    }
}
