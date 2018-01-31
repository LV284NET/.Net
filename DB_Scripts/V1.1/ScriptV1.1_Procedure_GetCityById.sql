IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCityById')
BEGIN
	DROP PROCEDURE [dbo].[GetCityById]
END
GO
CREATE procedure [dbo].[GetCityById](@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	select * from [City]
	where @CityID = [CityID]	
commit transaction