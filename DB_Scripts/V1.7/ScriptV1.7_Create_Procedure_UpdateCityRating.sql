IF EXISTS (SELECT * FROM sys.objects WHERE name = 'UpdateCityRating')
BEGIN
	DROP PROCEDURE [dbo].[UpdateCityRating]
END
GO
CREATE PROCEDURE [dbo].[UpdateCityRating](@CityID bigint)
AS
BEGIN
	DECLARE @CityRating decimal(18,2)
	SELECT @CityRating = (SELECT AVG([PlaceRating])
							FROM [dbo].[Place]
							WHERE [CityID] = (@CityID)
							AND [PlaceRating] > 0)

	IF (ISNULL(@CityRating, 0) = 0)
	BEGIN
		SET @CityRating = 0
	END

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[City]
			SET [CityRating] = @CityRating
			WHERE [CityID] = @CityID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END