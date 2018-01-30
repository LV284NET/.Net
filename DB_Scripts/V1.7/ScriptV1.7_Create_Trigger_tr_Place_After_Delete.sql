CREATE TRIGGER [dbo].[tr_Place_After_Delete]
ON [dbo].[Place]
AFTER DELETE
AS
BEGIN
	DECLARE @CityRating decimal(18,2)
	SELECT @CityRating = (SELECT AVG([PlaceRating])
							FROM [dbo].[Place]
							WHERE [CityID] = (SELECT [CityID] from deleted)
							AND [PlaceRating] > 0)

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[City]
			SET [CityRating] = @CityRating
			WHERE [CityID] = (SELECT [CityID] from deleted)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END