CREATE PROCEDURE [dbo].[GetUserPlaceRating](@UserID int, @PlaceID bigint) 
AS
BEGIN
	SELECT [Rating] FROM [dbo].[UsersPlaceRatings]
	WHERE UserID = @UserID AND PlaceID = @PlaceID
END