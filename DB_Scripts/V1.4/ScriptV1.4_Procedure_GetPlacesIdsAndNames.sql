CREATE procedure [dbo].[GetPlacesIdsAndNames]
as
select PlaceID, CityID, PlaceName from [Place]	