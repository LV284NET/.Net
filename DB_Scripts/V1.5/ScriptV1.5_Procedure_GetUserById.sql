IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetUserById')
BEGIN
	DROP PROCEDURE [dbo].[GetUserById]
END
GO
Create procedure [dbo].[GetUserById] (@Id nvarchar(256))
as
begin 
	select [AspNetUsers].Email, [AspNetUsers].FirstName, [AspNetUsers].LastName 
	From AspNetUsers
	Where [AspNetUsers].Id=@Id
End