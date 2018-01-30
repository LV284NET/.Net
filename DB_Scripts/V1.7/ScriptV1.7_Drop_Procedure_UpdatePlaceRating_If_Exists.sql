IF EXISTS (SELECT * FROM sys.objects WHERE name = 'UpdatePlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[UpdatePlaceRating]
END