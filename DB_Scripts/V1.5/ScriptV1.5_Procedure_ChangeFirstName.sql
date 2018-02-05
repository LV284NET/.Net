IF EXISTS (SELECT * FROM sys.objects WHERE name = 'ChangeLastName')
BEGIN
	DROP PROCEDURE [dbo].[ChangeLastName]
END
GO
Create procedure [dbo].[ChangeLastName] 
			(@Id nvarchar(256), 
			@LastName nvarchar(256))
as
begin 
	begin transaction 
	Update AspNetUsers
	Set LastName = @LastName
	Where [AspNetUsers].Id=@Id
	commit transaction 
End