﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopPlacesByCityId')
BEGIN
	DROP PROCEDURE [dbo].[GetTopPlacesByCityId]
END
GO
CREATE PROCEDURE [dbo].[GetTopPlacesByCityId] (@CityID bigint)
AS
BEGIN
	SELECT TOP 4 [PlaceID]
      ,[CityID]
      ,[PlaceName]
      ,[PlaceDescription]
      ,[MainPlaceImage] 
	FROM [Place]
	WHERE CityID = @CityID
	ORDER BY [PlaceRating] DESC
END
