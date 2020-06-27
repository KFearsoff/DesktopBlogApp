CREATE PROCEDURE [dbo].[spUser_CheckForPassword]
	@Password nvarchar(64)
As
select count(*)
from UsersTable
where Password=@Password;
