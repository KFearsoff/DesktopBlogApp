CREATE PROCEDURE [dbo].[spUser_CheckForUsername]
	@Username nvarchar(20)
AS
SELECT COUNT(*)
from UsersTable
where Username=@Username;