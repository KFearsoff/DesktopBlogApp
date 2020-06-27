CREATE PROCEDURE [dbo].[spUser_AddUsernameAndPassword]
	@Username nvarchar(20),
	@Password nvarchar(64)
AS
	Insert into UsersTable(Username, Password)
	values (@Username, @Password)
