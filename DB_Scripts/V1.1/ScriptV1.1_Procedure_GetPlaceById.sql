CREATE procedure [dbo].[GetPlaceById] (@PlaceID bigint)
as

set transaction isolation level read committed 

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceID = [Place].PlaceID;
commit transaction
