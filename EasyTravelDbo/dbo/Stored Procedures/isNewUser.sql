
create procedure [dbo].[isNewUser] (@Email nvarchar(40))
as
begin
	select [User].Email from [User]
		where @Email = [User].Email;
end;