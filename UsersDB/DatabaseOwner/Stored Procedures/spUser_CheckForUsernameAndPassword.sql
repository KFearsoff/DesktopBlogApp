CREATE PROCEDURE [dbo].[spUser_CheckForUsernameAndPassword]
	@Username nvarchar(20),
	@Password nvarchar(64)
AS
select [Id], [Username], [Password] 
from UsersTable
where Username = @Username	AND Password=@Password;
