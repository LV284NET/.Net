IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCityById')
BEGIN 
	DROP PROCEDURE [dbo].[GetCityById]
END
GO

CREATE PROCEDURE [dbo].[GetCityById](@CityID bigint)
AS
	select * from [City]
	where @CityID = [CityID]
GO