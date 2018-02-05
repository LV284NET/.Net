IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ChangeFirstName')
BEGIN
	DROP PROCEDURE [dbo].[ChangeFirstName]
END
GO
Create procedure [dbo].[ChangeFirstName] 
			(@Id nvarchar(256), 
			@FirstName nvarchar(256))
as
begin 
	begin transaction 
	Update AspNetUsers
	Set FirstName = @FirstName
	Where [AspNetUsers].Id=@Id
	commit transaction 
End