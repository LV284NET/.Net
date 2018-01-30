CREATE TRIGGER [dbo].[tr_UsersPlaceRatings_After_Insert]
ON [dbo].[UsersPlaceRatings]
AFTER INSERT
AS
BEGIN
	DECLARE @PlaceID bigint

	SELECT @PlaceID = (SELECT [PlaceID] from inserted)

	EXEC [dbo].[UpdatePlaceRating] @PlaceID
END