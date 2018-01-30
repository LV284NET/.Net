CREATE TRIGGER [dbo].[tr_UsersPlaceRatings_After_Delete]
ON [dbo].[UsersPlaceRatings]
AFTER DELETE
AS
BEGIN
	DECLARE @PlaceID bigint

	SELECT @PlaceID = (SELECT [PlaceID] from deleted)

	EXEC [dbo].[UpdatePlaceRating] @PlaceID
END