CREATE PROCEDURE [dbo].[DeleteUsersPlaceRating] 
(
	@UserID int,
	@PlaceID bigint 
) 
AS
BEGIN
	IF  EXISTS (SELECT * FROM [dbo].[UsersPlaceRatings]
					WHERE UserID = @UserID AND PlaceID = @PlaceID)
	BEGIN
	 	BEGIN TRY
			BEGIN TRANSACTION
				DELETE FROM [dbo].[UsersPlaceRatings]
				WHERE [UserID] = @UserID AND [PlaceID] = @PlaceID
			COMMIT TRANSACTION 
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
END