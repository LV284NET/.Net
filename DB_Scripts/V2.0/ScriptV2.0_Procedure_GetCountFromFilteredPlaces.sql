IF EXISTS (SELECT * FROM sys.objects Where name = 'GetCountFromFilteredPlaces')
BEGIN
	DROP PROCEDURE [dbo].[GetCountFromFilteredPlaces]
END
GO

CREATE procedure [dbo].[GetCountFromFilteredPlaces](@CityID bigint,@Filters varchar(max)) 
as
begin
select COUNT ([PlaceID]) as Count 
from dbo.GetFilteredPlacesFunction(@Filters,@CityId)
end