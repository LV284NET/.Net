IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopCities')
BEGIN
	DROP PROCEDURE [dbo].[GetTopCities]
END