CREATE PROCEDURE [dbo].[spBlog_GetBlogs]
@UserId int
AS
begin
	SELECT [Id], [UserId], [PostTitle], [PostContents] 
	from BlogPostsTable
	where UserId = @UserId;
end
