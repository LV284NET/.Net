IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCitiesPage')
BEGIN
	DROP PROCEDURE [dbo].[GetCitiesPage]
END
GO
Create procedure [dbo].[GetCitiesPage] (@PageNumber int, @PageSize int)
as
begin 
	SELECT * FROM [Lv-284.Net_EasyTravel].[dbo].[City]
  order by [City].CityID Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;
end;