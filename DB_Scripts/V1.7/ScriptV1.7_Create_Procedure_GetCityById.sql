﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCityById')
BEGIN
	DROP PROCEDURE [dbo].[GetCityById]
END
GO
CREATE PROCEDURE [dbo].[GetCityById](@CityID bigint)
AS
	SELECT [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto]
	  ,[CityRating] 
	  FROM [dbo].[City]
	WHERE @CityID = [CityID]	
