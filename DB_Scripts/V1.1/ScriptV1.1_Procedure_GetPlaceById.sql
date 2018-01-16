IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaceById')
BEGIN 
	DROP PROCEDURE [dbo].[GetPlaceById]
END
GO

CREATE PROCEDURE [dbo].[GetPlaceById](@PlaceID  bigint)
AS
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceID = [Place].PlaceID;
GO
