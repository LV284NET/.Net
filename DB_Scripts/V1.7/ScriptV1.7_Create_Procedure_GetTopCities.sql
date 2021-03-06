﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopCities')
BEGIN
	DROP PROCEDURE [dbo].[GetTopCities]
END
GO
CREATE PROCEDURE [dbo].[GetTopCities]
AS
BEGIN
	SELECT TOP 4 [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto] 
	  FROM [dbo].[City]
	  ORDER BY [CityRating] DESC
END
