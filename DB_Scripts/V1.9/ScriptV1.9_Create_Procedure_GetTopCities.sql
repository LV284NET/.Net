﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopCities')
BEGIN
	DROP PROCEDURE [dbo].[GetTopCities]
END
GO

CREATE PROCEDURE [dbo].[GetTopCities](@TopCitiesNumber int)
AS
BEGIN
	SELECT TOP (@TopCitiesNumber) [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] 
	  FROM [Lv-284.Net_EasyTravel].[dbo].[City]
	  ORDER BY [CityRating] DESC
END
