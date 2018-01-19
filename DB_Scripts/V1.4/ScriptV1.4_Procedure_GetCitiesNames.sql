CREATE procedure [dbo].[GetCitiesNames]
as

set transaction isolation level read committed 

begin transaction
	select CityName from [City]	
commit transaction