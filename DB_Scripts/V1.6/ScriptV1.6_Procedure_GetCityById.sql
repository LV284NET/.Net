ALTER procedure [dbo].[GetCityById](@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	select [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] 
	  from [Lv-284.Net_EasyTravel].[dbo].[City]
	where @CityID = [CityID]	
commit transaction