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
        IDataAccess _dataAccess;
        IPasswordEncrypter _passwordEncrypter;

        public SignUpForm(IDataAccess dataAccess, IPasswordEncrypter passwordEncrypter)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
            _passwordEncrypter = passwordEncrypter;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = _passwordEncrypter.Encrypt(textBoxPassword.Text);

            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_dataAccess.SignUp(username, password))
            {
                MessageBox.Show("There is already a user with those credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dataAccess.SignIn(username, password, out MainForm.CurrentUser);
            Close();
        }
    }
}
