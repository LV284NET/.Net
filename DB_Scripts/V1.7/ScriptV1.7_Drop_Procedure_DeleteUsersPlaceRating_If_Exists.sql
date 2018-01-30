IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DeleteUsersPlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[DeleteUsersPlaceRating]
END