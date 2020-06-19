CREATE VIEW [dbo].[FullUserView]
	AS 
	SELECT [u].[Id] as UserId, [u].[Username], [u].[Password], [b].[Id] as BlogId, [b].[PostTitle], [b].[PostContents]
	FROM dbo.UsersTable u
	left join dbo.BlogPostsTable b on u.Id = b.UserId
