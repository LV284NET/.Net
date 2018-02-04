IF EXISTS (SELECT * FROM sys.objects Where name = 'GetFilteredPlacesFunction')
BEGIN
	DROP FUNCTION [dbo].[GetFilteredPlacesFunction]
END
GO

CREATE FUNCTION [dbo].[GetFilteredPlacesFunction] (@Filters varchar(max), @CityId bigint)
   RETURNS @tbl TABLE (CityName nvarchar(40) Not Null,
					   PlaceId bigint NOT NULL,
					   PlaceName nvarchar(40) Not NUll,
					   PlaceDescription text,
					   MainPlaceImage nvarchar(max),
					   PlaceRating decimal(18,2)
					   ) AS
BEGIN
   If(@Filters is null or @Filters='') 
		begin

		Insert into @tbl (CityName,PlaceId,PlaceName,PlaceDescription,MainPlaceImage,PlaceRating)
		select 
		[City].[CityName], 
		[Place].[PlaceID], 
		[Place].[PlaceName], 
		[Place].[PlaceDescription], 
		[Place].[MainPlaceImage],
		[Place].[PlaceRating]
		from [Place] inner join [City]	
		on [Place].CityID = [City].CityID
		Where [Place].CityID=@CityId

		Return
	end

	Declare @listbtl Table (number int NOT NULL)

	Declare @places Table (PlaceId bigint NOT NULL)
	Declare	@position int

	Insert into @listbtl (number) 
    SELECT number FROM IntListToTable(@Filters) 
	Select @position = 0	

	While (Select number From @listbtl Order by number
			Offset @position Rows Fetch Next 1 Rows Only) is not null
		Begin 

			Insert into @places (PlaceId)
			Select PlaceId From FiltersPlacesJT
			Where [FilterId] = (Select number From @listbtl Order by number
				Offset @position Rows Fetch Next 1 Rows Only)

			Set @position= @position + 1

		End

	Insert into @tbl (CityName,PlaceId,PlaceName,PlaceDescription,MainPlaceImage,PlaceRating)
	select  
	[City].[CityName], 
	[Place].[PlaceID], 
	[Place].[PlaceName], 
	[Place].[PlaceDescription], 
	[Place].[MainPlaceImage],
	[Place].[PlaceRating]
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	Where [Place].CityID=@CityId AND  [PlaceID] IN (Select PlaceId From @places)
	
	Return
	
END
