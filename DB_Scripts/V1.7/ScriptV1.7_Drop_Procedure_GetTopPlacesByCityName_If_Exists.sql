IF EXISTS (SELECT * FROM sys.objects where name = 'GetTopPlacesByCityName')
BEGIN
	DROP PROCEDURE [dbo].[GetTopPlacesByCityName]
END