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
