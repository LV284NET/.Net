CREATE TRIGGER [dbo].[tr_Place_After_Update]
ON [dbo].[Place]
AFTER UPDATE
AS
BEGIN
	DECLARE @CityID bigint

	SELECT @CityID = (SELECT [CityID] from inserted)

	EXEC [dbo].[UpdateCityRating] @CityID
END