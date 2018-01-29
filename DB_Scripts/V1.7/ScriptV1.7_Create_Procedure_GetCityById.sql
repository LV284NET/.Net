CREATE PROCEDURE [dbo].[GetCityById](@CityID bigint)
AS
	SELECT [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto]
	  ,[CityRating] 
	  FROM [Lv-284.Net_EasyTravel].[dbo].[City]
	WHERE @CityID = [CityID]	
