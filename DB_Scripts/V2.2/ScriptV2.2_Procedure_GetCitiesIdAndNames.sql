IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCitiesIdsAndNames')
BEGIN
	DROP PROCEDURE [dbo].[GetCitiesIdsAndNames]
END
GO
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCitiesIdAndNames')
BEGIN
	DROP PROCEDURE [dbo].[GetCitiesIdAndNames]
END
GO
CREATE procedure [dbo].[GetCitiesIdAndNames]
as
select CityID, CityName from [City]	