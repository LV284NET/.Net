IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_UsersPlaceRatings_After_Delete')
BEGIN
	DROP TRIGGER tr_UsersPlaceRatings_After_Delete
END
GO
CREATE TRIGGER [dbo].[tr_UsersPlaceRatings_After_Delete]
ON [dbo].[UsersPlaceRatings]
AFTER DELETE
AS
BEGIN
	DECLARE @PlaceID bigint

	SELECT @PlaceID = (SELECT [PlaceID] from deleted)

	EXEC [dbo].[UpdatePlaceRating] @PlaceID
END