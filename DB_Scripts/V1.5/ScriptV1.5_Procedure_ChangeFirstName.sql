Create procedure [dbo].[ChangeLastName] 
			(@Email nvarchar(256), 
			@LastName nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[ChangeLastName]') 
         AND type IN (N'P', N'PC')
)

begin 
	begin transaction 
	Update AspNetUsers
	Set LastName = @LastName
	Where [AspNetUsers].Email=@Email
	commit transaction 
End