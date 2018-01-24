Create procedure [dbo].[GetPlacesPage] (@PageNumber int, @PageSize int, @CityID bigint)
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetPlacesPage]') 
         AND type IN (N'P', N'PC')
)


begin 
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	Where [Place].CityID=@CityID
  order by [Place].[PlaceID] Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;
end;