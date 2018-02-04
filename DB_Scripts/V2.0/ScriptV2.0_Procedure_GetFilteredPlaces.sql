IF EXISTS (SELECT * FROM sys.objects Where name = 'GetPlacesFiltered')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesFiltered]
END
GO

CREATE PROCEDURE [dbo].[GetFilteredPlaces] (@Filters varchar(max), @CityId bigint, @PageNumber int, @PageSize int)
AS

BEGIN 
	select 
	[CityName], 
	[PlaceID], 
	[PlaceName], 
	[PlaceDescription], 
	[MainPlaceImage],
	[PlaceRating]
	from dbo.GetFilteredPlacesFunction(@Filters,@CityId)	
	order by [PlaceRating] desc Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;

END