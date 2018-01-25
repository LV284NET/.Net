ALTER procedure [dbo].[GetCountPlace](@CityID bigint) 
as
begin
select COUNT ([Place].PlaceID) as Count from [Place]
where [Place].CityID=@CityID	
end