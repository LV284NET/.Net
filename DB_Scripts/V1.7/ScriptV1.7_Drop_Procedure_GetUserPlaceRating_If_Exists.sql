IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetUserPlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[GetUserPlaceRating]
END