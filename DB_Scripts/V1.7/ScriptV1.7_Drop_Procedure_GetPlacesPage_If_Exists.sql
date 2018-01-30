IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlacesPage')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesPage]
END