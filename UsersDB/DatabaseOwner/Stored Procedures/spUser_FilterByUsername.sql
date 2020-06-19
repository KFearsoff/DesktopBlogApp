CREATE PROCEDURE [dbo].[spUser_FilterByUsername]
	@Username nvarchar(20)
AS
begin
	SELECT [Id], [Username], [Password]
	from dbo.UsersTable
	where Username = @Username;
	end
