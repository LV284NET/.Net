CREATE TRIGGER [dbo].[tr_Place_After_Insert]
ON [dbo].[Place]
AFTER INSERT
AS
BEGIN
	DECLARE @CityID bigint

	SELECT @CityID = (SELECT [CityID] from inserted)

	EXEC [dbo].[UpdateCityRating] @CityID
END