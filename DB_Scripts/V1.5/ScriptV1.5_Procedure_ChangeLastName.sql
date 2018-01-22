Create procedure [dbo].[ChangeFirstName] 
			(@Id nvarchar(256), 
			@FirstName nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[ChangeFirstName]') 
         AND type IN (N'P', N'PC')
)

begin 
	begin transaction 
	Update AspNetUsers
	Set FirstName = @FirstName
	Where [AspNetUsers].Id=@Id
	commit transaction 
End