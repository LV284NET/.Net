CREATE procedure [dbo].[DeleteUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as

IF EXISTS (
SELECT * 
FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUserFavoritePlace]')
AND type IN (N'P', N'PC'))
		begin
			delete from [dbo].[Favorite] where UserID = @UserId and PlaceID = @PlaceID
		end;

