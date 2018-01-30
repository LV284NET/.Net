CREATE TRIGGER [dbo].[tr_UsersPlaceRatings_After_Update]
ON [dbo].[UsersPlaceRatings]
AFTER UPDATE
AS
BEGIN
	DECLARE @PlaceID bigint

	SELECT @PlaceID = (SELECT [PlaceID] from inserted)

	EXEC [dbo].[UpdatePlaceRating] @PlaceID
END