﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'InsertNewUserFavoritePlace')
BEGIN
	DROP PROCEDURE [dbo].[InsertNewUserFavoritePlace]
END
GO
CREATE procedure [dbo].[InsertNewUserFavoritePlace] (@UserId int, @PlaceID bigint) 
as
	begin
		if NOT EXISTS (select UserID, PlaceID from [dbo].[Favorite] where UserID = @UserId and PlaceID = @PlaceID)
		begin
			insert into [dbo].[Favorite] (UserID, PlaceID)
			values (@UserId, @PlaceID)
			select 1;
		end
	end;
