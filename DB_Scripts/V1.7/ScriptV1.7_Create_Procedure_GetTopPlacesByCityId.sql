ALTER PROCEDURE [dbo].[GetTopPlacesByCityId] (@CityID bigint)
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
