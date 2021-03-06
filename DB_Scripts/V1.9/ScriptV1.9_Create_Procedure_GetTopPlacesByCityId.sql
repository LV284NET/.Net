﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopPlacesByCityId')
BEGIN
	DROP PROCEDURE [dbo].[GetTopPlacesByCityId]
END
GO

CREATE PROCEDURE [dbo].[GetTopPlacesByCityId] (@CityID bigint, @TopPlacesNumber int)
AS
BEGIN
	SELECT TOP (@TopPlacesNumber) [PlaceID]
      ,[CityID]
      ,[PlaceName]
      ,[PlaceDescription]
      ,[MainPlaceImage] 
	FROM [Place]
	WHERE CityID = @CityID
	ORDER BY [PlaceRating] DESC
END
