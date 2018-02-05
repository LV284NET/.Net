IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetTopPlacesByCityId')
BEGIN
	DROP PROCEDURE [dbo].[GetTopPlacesByCityId]
END
GO
create procedure [dbo].[GetTopPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction

	select top 4 * from [Place]
	where CityID = @CityID;

commit transaction