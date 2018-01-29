IF EXISTS (SELECT * FROM sys.objects Where name = 'GetPlacesFiltered')
BEGIN
	DROP PROCEDURE [dbo].[GetPlacesFiltered]
END
GO

CREATE PROCEDURE [dbo].[GetPlacesFiltered] (@list varchar(max))
AS

BEGIN 
	Declare @listbtl Table (number int NOT NULL)
	Declare @result Table (FilterId bigint NOT NULL,
							PlaceId bigint Not Null)
	Declare @places Table (PlaceId bigint NOT NULL)
	Declare	@position int

	Insert into @listbtl (number) 
    SELECT number FROM IntListToTable(@list) 
	Select @position = 0

	If (Select count(number) from @listbtl) != 0
		begin

		Insert into @places (PlaceId)
		Select PlaceId From  FiltersPlacesJT
		Where [FilterId] = (Select number From @listbtl Order by number
			Offset @position Rows Fetch Next 1 Rows Only)

		Insert into @result (FilterId,PlaceId)
		Select FilterId, PlaceId From FiltersPlacesJT
		Where PlaceId IN (Select PlaceId From @places)
		
		Delete From @places
	    Set @position=1;
		end

	While (Select number From @listbtl Order by number
			Offset @position Rows Fetch Next 1 Rows Only) is not null
		Begin 

		Insert into @places (PlaceId)
		Select PlaceId From @result
		Where [FilterId] = (Select number From @listbtl Order by number
			Offset @position Rows Fetch Next 1 Rows Only)

		Delete From @result

		Insert into @result (FilterId,PlaceId)
		Select FilterId, PlaceId From FiltersPlacesJT
		Where PlaceId IN (Select PlaceId From @places)

		Set @position= @position + 1

		End

	select 
	[City].[CityName], 
	[Place].[PlaceID], 
	[Place].[PlaceName], 
	[Place].[PlaceDescription], 
	[Place].[MainPlaceImage],
	[Place].[PlaceRating]
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	Where [PlaceID] IN (Select PlaceId From @result)

END