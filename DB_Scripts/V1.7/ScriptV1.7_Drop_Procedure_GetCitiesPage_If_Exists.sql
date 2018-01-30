IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCitiesPage')
BEGIN
	DROP PROCEDURE [dbo].[GetCitiesPage]
END