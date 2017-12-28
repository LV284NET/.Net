
create procedure [dbo].[GetUserFavouritePlaces] (@UserID bigint)
as
begin
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
		from [Place] inner join [City]	
			on [Place].CityID = [City].CityID
				inner join [Favourite]
					on [Place].PlaceID = [Favourite].PlaceID
						where @UserID = [Favourite].UserID;
end;
