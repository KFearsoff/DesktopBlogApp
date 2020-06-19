CREATE TABLE [dbo].[BlogPostsTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[UserId] INT NOT NULL,
    [PostTitle] NVARCHAR(30) NOT NULL DEFAULT 'New post', 
    [PostContents] NTEXT NOT NULL, 
    CONSTRAINT [FK_BlogPostsTable_ToTable] FOREIGN KEY ([UserId]) REFERENCES [UsersTable]([Id])
    
)
