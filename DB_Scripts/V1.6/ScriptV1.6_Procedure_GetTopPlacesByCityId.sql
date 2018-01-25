ALTER procedure [dbo].[GetTopPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction

	select top 4 [PlaceID]
      ,[CityID]
      ,[PlaceName]
      ,[PlaceDescription]
      ,[MainPlaceImage] 
	  from [Place]
	where CityID = @CityID;

commit transaction