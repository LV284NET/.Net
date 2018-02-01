IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetPlaces')
BEGIN
	DROP PROCEDURE [dbo].[GetPlaces]
END
GO
CREATE procedure [dbo].[GetPlaces]
as

set transaction isolation level read committed 

begin transaction
	select * from [Place]	
commit transaction