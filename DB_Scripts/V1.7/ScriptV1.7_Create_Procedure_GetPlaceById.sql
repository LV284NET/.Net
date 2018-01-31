IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaceById')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaceById]
END
GO
CREATE PROCEDURE [dbo].[GetPlaceById] (@PlaceID bigint)
AS
	SELECT 
		[City].[CityName], 
		[Place].[PlaceID], 
		[Place].[PlaceName], 
		[Place].[PlaceDescription], 
		[Place].[MainPlaceImage],
		[Place].[PlaceRating]
	FROM [Place] inner join [City]	
	ON [Place].CityID = [City].CityID
	WHERE @PlaceID = [Place].PlaceID;
commit transaction