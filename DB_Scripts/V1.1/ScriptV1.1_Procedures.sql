IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCities')
BEGIN 
	DROP PROCEDURE [dbo].[GetCities]
END
GO

CREATE PROCEDURE [dbo].[GetCities]
AS
	select * from [City]
GO

