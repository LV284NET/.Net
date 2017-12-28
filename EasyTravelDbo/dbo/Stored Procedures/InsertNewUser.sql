CREATE procedure [dbo].[InsertNewUser] (
				@Email nvarchar(40), 
				@Password nvarchar(40),
				@FirstName nvarchar(40),
				@LastName nvarchar(40),
				@ProfilePhoto nvarchar(MAX) = null
				)
AS
begin
if(@ProfilePhoto is null)
	begin
		insert into [dbo].[User](Email, Password, FirstName, LastName, ProfilePhoto)
			values(@Email, PWDENCRYPT(@Password), @FirstName, @LastName, null)
	end;
else
	begin
		insert into [dbo].[User](Email, Password, FirstName, LastName, ProfilePhoto)
				values(@Email, PWDENCRYPT(@Password), @FirstName, @LastName, @ProfilePhoto)
	end;
end;