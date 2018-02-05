IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_UsersPlaceRatings_After_Update')
BEGIN
	DROP TRIGGER tr_UsersPlaceRatings_After_Update
END
GO
CREATE TRIGGER [dbo].[tr_UsersPlaceRatings_After_Update]
ON [dbo].[UsersPlaceRatings]
AFTER UPDATE
AS
BEGIN
	DECLARE @PlaceID bigint

	SELECT @PlaceID = (SELECT [PlaceID] from inserted)

	EXEC [dbo].[UpdatePlaceRating] @PlaceID
END