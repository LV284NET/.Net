IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopPlacesByCityName')
BEGIN 
	DROP PROCEDURE [dbo].[GetTopPlacesByCityName]
END
GO

CREATE PROCEDURE [dbo].[GetTopPlacesByCityName] (@CityName nvarchar(40))
AS
	select top 4 * from [Place]
	where CityID = (select [CityID] 
					from [dbo].[City]
					where [CityName] = @CityName)
GO
