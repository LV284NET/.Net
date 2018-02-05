IF EXISTS (SELECT * FROM sys.objects WHERE name = 'InsertOrUpdateUsersPlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[InsertOrUpdateUsersPlaceRating]
END
GO
CREATE PROCEDURE [dbo].[InsertOrUpdateUsersPlaceRating] 
(
	@UserID int,
	@PlaceID bigint, 
	@Rating decimal(18,2)
) 
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM [dbo].[UsersPlaceRatings]
					WHERE UserID = @UserID AND PlaceID = @PlaceID)
	BEGIN
	 	BEGIN TRY
			BEGIN TRANSACTION
				INSERT INTO [dbo].[UsersPlaceRatings] (UserID, PlaceID, Rating)
				VALUES (@UserID, @PlaceID, @Rating)
			COMMIT TRANSACTION 
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END

	ELSE BEGIN
		BEGIN TRY
			BEGIN TRANSACTION			
				UPDATE [dbo].[UsersPlaceRatings]
				SET Rating =  @Rating
				WHERE UserID = @UserID AND PlaceID = @PlaceID
			COMMIT TRANSACTION 
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
END