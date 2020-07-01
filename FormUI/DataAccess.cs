using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess : IDataAccess
    {
        IHelper _helper;

        public DataAccess(IHelper helper)
        {
            _helper = helper;
        }


        public List<BlogPost> GetBlogPosts(int userId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_helper.CnnVal("BlogAppDB")))
            {
                var output = connection.Query<BlogPost>($"spBlog_GetBlogs @UserId", new { UserId = userId }).ToList();
                return output;
            }
        }

        public string GetBlogContent(BlogPost blogPost)
        {
            if (blogPost == null) return "";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_helper.CnnVal("BlogAppDB")))
            {
                var output = connection.Query<string>($"spBlog_GetBlogContentById '{blogPost.Id}'").First();
                return output;
            }
        }

        public void AddBlog(int userId, string postTitle, string postContents)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_helper.CnnVal("BlogAppDB")))
            {
                connection.Query<BlogPost>($"spBlog_AddBlog '{userId}', '{postTitle}', '{postContents}'");
            }
        }

        public bool SignIn(string username, string password, out User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_helper.CnnVal("BlogAppDB")))
            {
                var output = connection.Query<User>($"spUser_CheckForUsernameAndPassword '{username}', '{password}'");
                if (output.Count() == 1)
                {
                    user = output.First();
                    return true;
                }
                user = null;
                return false;
            }
        }

        public bool SignUp(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_helper.CnnVal("BlogAppDB")))
            {
                if (connection.Query<int>($"spUser_CheckForUsername '{username}'").First() == 1 ||
                    connection.Query<int>($"spUser_CheckForPassword '{password}'").First() == 1)
                    return false;
                connection.Query<User>($"spUser_AddUsernameAndPassword '{username}', '{password}'");
                return true;
            }
        }
    }
}
