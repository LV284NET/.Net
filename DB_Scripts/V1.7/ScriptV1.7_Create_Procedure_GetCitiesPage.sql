CREATE PROCEDURE [dbo].[GetCitiesPage] (@PageNumber int, @PageSize int)
AS

BEGIN 
	SELECT 
		[CityID],
		[CityName],
		[CityDescription],
		[CityPhoto],
		[CityRating] 
	FROM [dbo].[City]
	ORDER BY [City].CityID Offset (@PageNumber-1)*@PageSize Rows
	Fetch Next @PageSize Rows Only;
END