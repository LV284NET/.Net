IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_Place_After_Update')
BEGIN
	DROP TRIGGER tr_Place_After_Update
END
GO
CREATE TRIGGER [dbo].[tr_Place_After_Update]
ON [dbo].[Place]
AFTER UPDATE
AS
BEGIN
	DECLARE @CityID bigint

	SELECT @CityID = (SELECT [CityID] from inserted)

	EXEC [dbo].[UpdateCityRating] @CityID
END