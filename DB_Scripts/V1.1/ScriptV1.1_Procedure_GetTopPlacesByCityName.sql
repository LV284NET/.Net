CREATE procedure [dbo].[GetTopPlacesByCityName] (@CityName nvarchar(40))
as

set transaction isolation level read committed 

begin transaction

	select top 4 * from [Place]
	where CityID = (select [CityID] 
					from [dbo].[City]
					where [CityName] = @CityName)

commit transaction
