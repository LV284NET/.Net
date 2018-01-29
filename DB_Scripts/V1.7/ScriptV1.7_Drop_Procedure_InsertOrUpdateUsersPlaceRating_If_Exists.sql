IF EXISTS (SELECT * FROM sys.objects WHERE name = 'InsertOrUpdateUsersPlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[InsertOrUpdateUsersPlaceRating]
END
