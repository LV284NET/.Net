create procedure [dbo].[GetUser] (@Email nvarchar(40), @Password nvarchar(40))
AS
begin
select [User].UserID, [User].Email, [User].FirstNAme, [User].LastName, [User].ProfilePhoto,[User].RoleID 
	from [User]
		where @Email = [User].Email and PWDCOMPARE(@Password, [Password]) = 1;
end;