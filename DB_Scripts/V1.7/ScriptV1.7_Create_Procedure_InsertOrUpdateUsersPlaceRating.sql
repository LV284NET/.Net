CREATE PROCEDURE [dbo].[InsertOrUpdateUsersPlaceRating] 
(
	@UderID int, --int -> bigint in the future!
	@PlaceID bigint, 
	@Rating decimal(18,2)
) 
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM [dbo].[UsersPlaceRatings]
					WHERE UserID = @UderID AND PlaceID = @PlaceID)
	BEGIN
	 	BEGIN TRY
			BEGIN TRANSACTION
				INSERT INTO [dbo].[UsersPlaceRatings] (UserID, PlaceID, Rating)
				VALUES (@UderID, @PlaceID, @Rating)
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
				WHERE UserID = @UderID AND PlaceID = @PlaceID
			COMMIT TRANSACTION 
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
END