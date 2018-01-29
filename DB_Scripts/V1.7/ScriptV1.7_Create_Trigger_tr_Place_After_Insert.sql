CREATE TRIGGER [dbo].[tr_Place_After_Insert]
ON [dbo].[Place]
AFTER INSERT
AS
BEGIN
	DECLARE @CityRating decimal(18,2)
	SELECT @CityRating = (SELECT AVG([PlaceRating])
							FROM [dbo].[Place]
							WHERE [CityID] = (SELECT [CityID] from inserted)
							AND [PlaceRating] > 0)

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[City]
			SET [CityRating] = @CityRating
			WHERE [CityID] = (SELECT [CityID] from inserted)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END