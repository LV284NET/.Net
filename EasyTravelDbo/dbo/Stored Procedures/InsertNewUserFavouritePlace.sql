
create procedure [dbo].[InsertNewUserFavouritePlace] (@UserID bigint, @PlaceID bigint)
as
begin
	insert into [dbo].[Favourite] (UserID, PlaceID)
		values(@UserID, @PlaceID)
end;
