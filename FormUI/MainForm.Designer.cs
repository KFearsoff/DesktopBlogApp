namespace FormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelYourBlogs = new System.Windows.Forms.Label();
            this.listBoxBlogTitles = new System.Windows.Forms.ListBox();
            this.textBoxBlogContent = new System.Windows.Forms.TextBox();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(250, 32);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(320, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Welcome! Do you want to sign in or sign up?";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(268, 85);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 1;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(458, 84);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 2;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelYourBlogs
            // 
            this.labelYourBlogs.AutoSize = true;
            this.labelYourBlogs.Location = new System.Drawing.Point(316, 182);
            this.labelYourBlogs.Name = "labelYourBlogs";
            this.labelYourBlogs.Size = new System.Drawing.Size(60, 13);
            this.labelYourBlogs.TabIndex = 3;
            this.labelYourBlogs.Text = "Your blogs:";
            // 
            // listBoxBlogTitles
            // 
            this.listBoxBlogTitles.FormattingEnabled = true;
            this.listBoxBlogTitles.Location = new System.Drawing.Point(319, 208);
            this.listBoxBlogTitles.Name = "listBoxBlogTitles";
            this.listBoxBlogTitles.Size = new System.Drawing.Size(120, 95);
            this.listBoxBlogTitles.TabIndex = 4;
            this.listBoxBlogTitles.SelectedValueChanged += new System.EventHandler(this.DisplayBlogContents);
            // 
            // textBoxBlogContent
            // 
            this.textBoxBlogContent.Location = new System.Drawing.Point(319, 309);
            this.textBoxBlogContent.Multiline = true;
            this.textBoxBlogContent.Name = "textBoxBlogContent";
            this.textBoxBlogContent.Size = new System.Drawing.Size(120, 71);
            this.textBoxBlogContent.TabIndex = 5;
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Location = new System.Drawing.Point(498, 228);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(90, 23);
            this.buttonAddPost.TabIndex = 6;
            this.buttonAddPost.Text = "Add new post";
            this.buttonAddPost.UseVisualStyleBackColor = true;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.textBoxBlogContent);
            this.Controls.Add(this.listBoxBlogTitles);
            this.Controls.Add(this.labelYourBlogs);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelLogin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelYourBlogs;
        private System.Windows.Forms.ListBox listBoxBlogTitles;
        private System.Windows.Forms.TextBox textBoxBlogContent;
        private System.Windows.Forms.Button buttonAddPost;
    }
}