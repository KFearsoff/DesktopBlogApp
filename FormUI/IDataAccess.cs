using System.Collections.Generic;

namespace FormUI
{
    public interface IDataAccess
    {
        void AddBlog(int userId, string postTitle, string postContents);
        string GetBlogContent(BlogPost blogPost);
        List<BlogPost> GetBlogPosts(int userId);
        bool SignIn(string username, string password, out User user);
        bool SignUp(string username, string password);
    }
}