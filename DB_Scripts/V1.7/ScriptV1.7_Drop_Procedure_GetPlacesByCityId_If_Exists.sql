IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlacesByCityId')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesByCityId]
END