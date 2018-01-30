CREATE TRIGGER [dbo].[tr_Place_After_Delete]
ON [dbo].[Place]
AFTER DELETE
AS
BEGIN
	DECLARE @CityID bigint

	SELECT @CityID = (SELECT [CityID] from deleted)

	EXEC [dbo].[UpdateCityRating] @CityID
END