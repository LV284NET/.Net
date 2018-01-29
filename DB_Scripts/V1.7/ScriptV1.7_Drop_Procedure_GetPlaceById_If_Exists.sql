IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaceById')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaceById]
END