﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlacesPage')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesPage]
END
GO
CREATE PROCEDURE [dbo].[GetPlacesPage] (@PageNumber int, @PageSize int, @CityID bigint)
AS
BEGIN 
	SELECT 
	[City].[CityName], 
	[Place].[PlaceID], 
	[Place].[PlaceName], 
	[Place].[PlaceDescription], 
	[Place].[MainPlaceImage],
	[Place].[PlaceRating]
	FROM [Place] inner join [City]	
	ON [Place].CityID = [City].CityID
	WHERE [Place].CityID=@CityID
  ORDER BY [Place].[PlaceID] Offset (@PageNumber-1)*@PageSize ROWS
  FETCH NEXT @PageSize ROWS Only;
END