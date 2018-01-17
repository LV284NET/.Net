CREATE procedure [dbo].[GetPlaceByName] (@PlaceName nvarchar(40))
as
begin
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
		from [Place] inner join [City]	
			on [Place].CityID = [City].CityID
				where @PlaceName = [Place].PlaceName;
end;
