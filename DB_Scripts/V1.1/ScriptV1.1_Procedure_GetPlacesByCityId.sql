IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlacesByCityId')
BEGIN 
	DROP PROCEDURE [dbo].[GetPlacesByCityId]
END
GO

CREATE PROCEDURE [dbo].[GetPlacesByCityId] (@CityID bigint)
AS
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @CityID = [Place].CityID;
GO