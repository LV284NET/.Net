ALTER procedure [dbo].[GetCities]
as

set transaction isolation level read committed 

begin transaction
	SELECT [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] from [Lv-284.Net_EasyTravel].[dbo].[City]
commit transaction
