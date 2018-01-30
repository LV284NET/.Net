IF EXISTS (SELECT * FROM sys.objects WHERE name = 'UpdateCityRating')
BEGIN
	DROP PROCEDURE [dbo].[UpdateCityRating]
END