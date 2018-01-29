IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopPlacesByCityId')
BEGIN
	DROP PROCEDURE [dbo].[GetTopPlacesByCityId]
END