CREATE procedure [dbo].[GetCityById](@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	select * from [City]
	where @CityID = [CityID]	
commit transaction