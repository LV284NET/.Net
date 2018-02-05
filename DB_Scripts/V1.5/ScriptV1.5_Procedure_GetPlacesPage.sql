IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlacesPage')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesPage]
END
GO
Create procedure [dbo].[GetPlacesPage] (@PageNumber int, @PageSize int, @CityID bigint)
as
begin 
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	Where [Place].CityID=@CityID
  order by [Place].[PlaceID] Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;
end;