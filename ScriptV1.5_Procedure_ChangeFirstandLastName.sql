Create procedure [dbo].[ChangeFirstandLastName] 
			(@Email nvarchar(256), 
			@FirstName nvarchar(256)=null,
			@LastName nvarchar(256)=null)
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[ChangeFirstandLastName]') 
         AND type IN (N'P', N'PC')
)

if(@FirstName is not null)
begin 
	begin transaction 
	Update AspNetUsers
	Set FirstName = @FirstName
	Where [AspNetUsers].Email=@Email
	commit transaction 
End

if(@LastName is not null)
begin 
	begin transaction 
	Update AspNetUsers
	Set LastName = @LastName
	Where [AspNetUsers].Email=@Email
	commit transaction 
End