IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaceByName')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaceByName]
END