﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DeleteUserFavoritePlace')
BEGIN
	DROP PROCEDURE [dbo].[DeleteUserFavoritePlace]
END
GO
CREATE procedure [dbo].[DeleteUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as
		begin
			delete from [dbo].[Favorite] where UserID = @UserId and PlaceID = @PlaceID
		end;

