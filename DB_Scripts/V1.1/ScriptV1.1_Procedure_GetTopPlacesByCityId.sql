IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopPlacesByCityId')
BEGIN 
	DROP PROCEDURE [dbo].[GetTopPlacesByCityId]
END
GO

CREATE PROCEDURE [dbo].[GetTopPlacesByCityId] (@CityID bigint)
AS
	select top 4 * from [Place]
	where CityID = @CityID;
GO