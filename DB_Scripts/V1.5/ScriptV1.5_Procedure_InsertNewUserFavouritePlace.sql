IF EXISTS (SELECT * FROM sys.objects WHERE name = 'InsertNewUserFavouritePlace')
BEGIN 
	DROP PROCEDURE [dbo].[InsertNewUserFavouritePlace]
END
GO

CREATE procedure [dbo].[InsertNewUserFavouritePlace] (@UserId int, @PlaceID bigint) 
as

set transaction isolation level read committed

begin try
begin transaction
	if NOT EXISTS (select UserID, PlaceID from [dbo].[Favourite] where UserID = @UserId and PlaceID = @PlaceID)
	begin
		insert into [dbo].[Favourite] (UserID, PlaceID)
		values (@UserId, @PlaceID)
		select 1;
	end
	commit transaction
end try
begin catch
	rollback transaction
	raiserror('Transaction rolled back', 16, 1)
end catch
