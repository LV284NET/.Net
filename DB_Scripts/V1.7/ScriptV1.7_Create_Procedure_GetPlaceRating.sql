IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaceRating]
END
GO
CREATE PROCEDURE [dbo].[GetPlaceRating] 
(
	@PlaceID bigint 
) 
AS

SELECT [PlaceRating]
	FROM [dbo].[Place]
	WHERE @PlaceID = [PlaceID]	
