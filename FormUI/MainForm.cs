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
    public partial class MainForm : Form
    {
        public static User CurrentUser = null;
        IDataAccess _dataAccess;
        IPasswordEncrypter _passwordEncrypter;

        public MainForm(IDataAccess dataAccess, IPasswordEncrypter passwordEncrypter)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
            _passwordEncrypter = passwordEncrypter;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var form = new SignInForm(_dataAccess, _passwordEncrypter);
            form.Show();
            form.FormClosed += SignIn;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var form = new SignUpForm(_dataAccess, _passwordEncrypter);
            form.Show();
            form.FormClosed += SignIn;
        }

        private void SignIn(object sender, EventArgs e)
        {
            if (CurrentUser == null) return;
            else
            {
                listBoxBlogTitles.DataSource = _dataAccess.GetBlogPosts(CurrentUser.Id);
                listBoxBlogTitles.DisplayMember = "PostTitle";

                labelLogin.Enabled = false;
                buttonSignIn.Enabled = false;
                buttonSignUp.Enabled = false;
                buttonAddPost.Enabled = true;
            }
        }

        private void DisplayBlogContents(object sender, EventArgs e)
        {
            textBoxBlogContent.Text = _dataAccess.GetBlogContent(listBoxBlogTitles.SelectedItem as BlogPost);
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            var form = new NewBlogForm(_dataAccess);
            form.Show();
            form.FormClosed += RefreshBlogs;
        }

        private void RefreshBlogs(object sender, EventArgs e) =>
            listBoxBlogTitles.DataSource = _dataAccess.GetBlogPosts(CurrentUser.Id);
    }
}
