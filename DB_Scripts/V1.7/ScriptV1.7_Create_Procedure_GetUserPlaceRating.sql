IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetUserPlaceRating')
BEGIN
	DROP PROCEDURE [dbo].[GetUserPlaceRating]
END
GO
CREATE PROCEDURE [dbo].[GetUserPlaceRating](@UserID int, @PlaceID bigint) 
AS
BEGIN
	SELECT [Rating] FROM [dbo].[UsersPlaceRatings]
	WHERE UserID = @UserID AND PlaceID = @PlaceID
END