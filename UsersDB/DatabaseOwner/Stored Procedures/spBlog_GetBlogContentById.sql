CREATE PROCEDURE [dbo].[spBlog_GetBlogContentById]
@Id int
as
select BlogPostsTable.PostContents
from BlogPostsTable
where Id = @Id;
