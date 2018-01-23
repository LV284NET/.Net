IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DeleteUserFavoritePlace')
BEGIN 
	DROP PROCEDURE [dbo].[DeleteUserFavoritePlace]
END
GO

CREATE procedure [dbo].[DeleteUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as

set transaction isolation level read committed

begin try
begin transaction
	begin
		delete from [dbo].[Favourite] where UserID = @UserId and PlaceID = @PlaceID
	end
	commit transaction
end try
begin catch
	rollback transaction
	raiserror('Transaction rolled back', 16, 1)
end catch

