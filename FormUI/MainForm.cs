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

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var form = new SignInForm();
            form.Show();
            form.FormClosed += SignIn;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var form = new SignUpForm();
            form.Show();
            form.FormClosed += SignIn;
        }

        private void SignIn(object sender, EventArgs e)
        {
            if (CurrentUser == null) return;
            else
            {
                listBoxBlogTitles.DataSource = DataAccess.GetBlogPosts(CurrentUser.Id);
                listBoxBlogTitles.DisplayMember = "PostTitle";
            }
        }

        private void DisplayBlogContents(object sender, EventArgs e)
        {
            textBoxBlogContent.Text = DataAccess.GetBlogContent(listBoxBlogTitles.SelectedItem as BlogPost);
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            var form = new NewBlogForm();
            form.Show();
            form.FormClosed += RefreshBlogs;
        }

        private void RefreshBlogs(object sender, EventArgs e) =>
            listBoxBlogTitles.DataSource = DataAccess.GetBlogPosts(CurrentUser.Id);
    }
}
