﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCountPlace')
BEGIN
	DROP PROCEDURE [dbo].[GetCountPlace]
END
GO

CREATE procedure [dbo].[GetCountPlace](@CityID bigint) 
as
begin
select COUNT ([Place].PlaceID) as Count from [Place]
where [Place].CityID=@CityID	
end