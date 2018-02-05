IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetUserFavoritePlaces')
BEGIN
	DROP PROCEDURE [dbo].[GetUserFavoritePlaces]
END
GO
CREATE procedure [dbo].[GetUserFavoritePlaces] (@UserID int)
as
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].MainPlaceImage, [Place].CityID
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	inner join [Favorite]
	on [Place].PlaceID = [Favorite].PlaceId
	where [Favorite].UserId = @UserID;