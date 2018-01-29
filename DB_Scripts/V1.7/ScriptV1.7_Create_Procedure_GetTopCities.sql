CREATE PROCEDURE [dbo].[GetTopCities]
AS
BEGIN
	SELECT TOP 4 [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] 
	  FROM [Lv-284.Net_EasyTravel].[dbo].[City]
	  ORDER BY [CityRating] DESC
END
