IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertOrUpdateUsersPlaceRating]') AND type in (N'U'))
BEGIN
	DROP PROCEDURE [dbo].[InsertOrUpdateUsersPlaceRating]
END
GO