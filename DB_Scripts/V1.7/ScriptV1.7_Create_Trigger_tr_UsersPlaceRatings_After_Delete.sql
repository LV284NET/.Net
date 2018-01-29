CREATE TRIGGER [dbo].[tr_UsersPlaceRatings_After_Delete]
ON [dbo].[UsersPlaceRatings]
AFTER DELETE
AS
BEGIN
	DECLARE @PlaceRating decimal(18,2)
	SELECT @PlaceRating = (SELECT AVG([Rating])
							FROM [dbo].[UsersPlaceRatings]
							WHERE [PlaceID] = (SELECT [PlaceID] from deleted))

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[Place]
			SET [PlaceRating] = @PlaceRating
			WHERE [PlaceID] = (SELECT [PlaceID] from deleted)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END