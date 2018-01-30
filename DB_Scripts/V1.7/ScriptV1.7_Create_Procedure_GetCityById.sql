CREATE PROCEDURE [dbo].[GetCityById](@CityID bigint)
AS
	SELECT [CityID]
      ,[CityName]
      ,[CityDescription]
      ,[CityPhoto]
	  ,[CityRating] 
	  FROM [dbo].[City]
	WHERE @CityID = [CityID]	
