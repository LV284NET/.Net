ALTER procedure  [dbo].[GetCountCity] 
as
begin
select COUNT ([City].CityID) as Count from [City]
end;	