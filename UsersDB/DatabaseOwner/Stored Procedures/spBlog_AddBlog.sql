CREATE PROCEDURE [dbo].[spBlog_AddBlog]
@UserId int,
@PostTitle nvarchar(20),
@PostContents ntext
AS
insert into BlogPostsTable(UserId, PostTitle, PostContents)
values(@UserId, @PostTitle, @PostContents)