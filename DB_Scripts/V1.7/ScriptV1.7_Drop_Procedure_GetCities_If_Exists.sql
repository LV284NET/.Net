IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCities')
BEGIN
	DROP PROCEDURE [dbo].[GetCities]
END