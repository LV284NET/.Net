﻿IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCountCity')
BEGIN
	DROP PROCEDURE [dbo].[GetCountCity]
END
GO

CREATE procedure  [dbo].[GetCountCity] 
as
begin
select COUNT ([City].CityID) as Count from [City]
end;	