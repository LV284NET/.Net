IF EXISTS (SELECT * FROM sys.objects Where name = 'GetPlaceFilters')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaceFilters]
END
GO

CREATE PROCEDURE [dbo].[GetPlaceFilters] (@PlaceId bigint)
AS

BEGIN 

	Select [FiltersPlacesJT].FilterId 
	From FiltersPlacesJT
	Where [FiltersPlacesJT].PlaceId=@PlaceId
END