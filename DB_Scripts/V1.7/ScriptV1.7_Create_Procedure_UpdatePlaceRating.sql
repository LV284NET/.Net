﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'UpdatePlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[UpdatePlaceRating]
END
GO
CREATE PROCEDURE [dbo].[UpdatePlaceRating](@PlaceID bigint)
AS
BEGIN
	DECLARE @PlaceRating decimal(18,2)
	SELECT @PlaceRating = (SELECT AVG([Rating])
							FROM [dbo].[UsersPlaceRatings]
							WHERE [PlaceID] = @PlaceID)

	IF (ISNULL(@PlaceRating, 0) = 0)
	BEGIN
		SET @PlaceRating = 0
	END

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[Place]
			SET [PlaceRating] = @PlaceRating
			WHERE [PlaceID] = @PlaceID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END