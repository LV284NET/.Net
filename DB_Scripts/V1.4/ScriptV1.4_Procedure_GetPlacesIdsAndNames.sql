IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlacesIdsAndNames')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesIdsAndNames]
END
GO
CREATE procedure [dbo].[GetPlacesIdsAndNames]
as
select PlaceID, CityID, PlaceName from [Place]	