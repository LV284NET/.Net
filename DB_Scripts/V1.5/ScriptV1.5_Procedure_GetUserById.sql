Create procedure [dbo].[GetUserById] (@Id nvarchar(256))
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetUserById]') 
         AND type IN (N'P', N'PC')
)

begin 
	select [AspNetUsers].Email, [AspNetUsers].FirstName, [AspNetUsers].LastName 
	From AspNetUsers
	Where [AspNetUsers].Id=@Id
End