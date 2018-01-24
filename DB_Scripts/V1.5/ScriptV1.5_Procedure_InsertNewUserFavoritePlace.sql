CREATE procedure [dbo].[InsertNewUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as

IF EXISTS (
SELECT * 
FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserFavoritePlace]')
AND type IN (N'P', N'PC'))

	begin
		if NOT EXISTS (select UserID, PlaceID from [dbo].[Favorite] where UserID = @UserId and PlaceID = @PlaceID)
		begin
			insert into [dbo].[Favorite] (UserID, PlaceID)
			values (@UserId, @PlaceID)
			select 1;
		end
	end;
