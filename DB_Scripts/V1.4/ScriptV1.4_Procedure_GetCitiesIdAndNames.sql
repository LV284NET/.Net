IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCitiesIdsAndNames')
BEGIN
	DROP PROCEDURE [dbo].[GetCitiesIdsAndNames]
END
GO
CREATE procedure [dbo].[GetCitiesIdsAndNames]
as
select CityID, CityName from [City]	