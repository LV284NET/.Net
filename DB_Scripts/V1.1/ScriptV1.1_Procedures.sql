CREATE procedure GetCities
as

set transaction isolation level read committed 

begin transaction
	select * from [City]	
commit transaction

