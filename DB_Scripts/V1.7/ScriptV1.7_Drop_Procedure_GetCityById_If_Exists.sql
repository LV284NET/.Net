IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCityById')
BEGIN
	DROP PROCEDURE [dbo].[GetCityById]
END