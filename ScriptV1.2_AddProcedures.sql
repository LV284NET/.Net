CREATE procedure [dbo].[GetPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	--select * from [Place]
	-- where CityID = @CityID;

	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @CityID = [Place].CityID;
commit transaction

SET QUOTED_IDENTIFIER ON
create procedure [dbo].[GetTopPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction

	select top 4 * from [Place]
	where CityID = @CityID;

commit transaction