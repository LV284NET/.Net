IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_Place_After_Insert')
BEGIN
	DROP TRIGGER tr_Place_After_Insert
END
GO
CREATE TRIGGER [dbo].[tr_Place_After_Insert]
ON [dbo].[Place]
AFTER INSERT
AS
BEGIN
	DECLARE @CityID bigint

	SELECT @CityID = (SELECT [CityID] from inserted)

	EXEC [dbo].[UpdateCityRating] @CityID
END