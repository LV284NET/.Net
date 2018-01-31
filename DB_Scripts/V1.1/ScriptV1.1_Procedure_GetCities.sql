IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCities')
BEGIN
	DROP PROCEDURE [dbo].[GetCities]
END
GO
CREATE procedure GetCities
as

set transaction isolation level read committed 

begin transaction
	select * from [City]	
commit transaction

