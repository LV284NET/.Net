CREATE procedure [dbo].[GetPlacesNames]
as

set transaction isolation level read committed 

begin transaction
	select PlaceName from [Place]	
commit transaction