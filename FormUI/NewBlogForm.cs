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
    public partial class NewBlogForm : Form
    {
        IDataAccess _dataAccess;

        public NewBlogForm(IDataAccess dataAccess)
        {
            InitializeComponent();
            _dataAccess = dataAccess;
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Length > 20)
            {
                MessageBox.Show("The title is too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _dataAccess.AddBlog(MainForm.CurrentUser.Id, textBoxTitle.Text, textBoxContents.Text);
            Close();
        }
    }
}
