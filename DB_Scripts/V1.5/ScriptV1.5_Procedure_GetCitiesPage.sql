Create procedure [dbo].[GetCitiesPage] (@PageNumber int, @PageSize int)
as

IF EXISTS (
  SELECT * 
  FROM   sys.objects 
  WHERE  object_id = OBJECT_ID(N'[dbo].[GetCitiesPage]') 
         AND type IN (N'P', N'PC')
)


begin 
	SELECT * FROM [Lv-284.Net_EasyTravel].[dbo].[City]
  order by [City].CityID Offset (@PageNumber-1)*@PageSize Rows
  Fetch Next @PageSize Rows Only;
end;