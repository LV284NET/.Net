Create procedure [dbo].[GetUserByEmail] (@Email nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetUserByEmail]') 
         AND type IN (N'P', N'PC')
)

begin 
	select [AspNetUsers].Email, [AspNetUsers].FirstName, [AspNetUsers].LastName 
	From AspNetUsers
	Where [AspNetUsers].Email=@Email
End