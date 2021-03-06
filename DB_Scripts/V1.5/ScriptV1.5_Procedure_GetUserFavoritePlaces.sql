﻿CREATE procedure [dbo].[GetUserFavoritePlaces] (@UserID int) 
as

IF EXISTS (
SELECT * 
FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[GetUserFavoritePlaces]')
AND type IN (N'P', N'PC'))
begin 
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	inner join [Favorite]
	on [Place].PlaceID = [Favorite].PlaceId
	where [Favorite].UserId = @UserID;
end
