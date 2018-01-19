CREATE procedure [dbo].[GetPlaces]
as

set transaction isolation level read committed 

begin transaction
	select * from [Place]	
commit transaction