IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaceByName')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaceByName]
END
GO
CREATE procedure [dbo].[GetPlaceByName] (@PlaceName nvarchar(40))
as

set transaction isolation level read committed

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceName = [Place].PlaceName;
commit transaction