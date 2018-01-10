SET QUOTED_IDENTIFIER ON
GO

CREATE procedure GetCities
as

set transaction isolation level read committed 

begin transaction
	select * from [City]	
commit transaction

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure GetCityById(@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	select * from [City]
	where @CityID = [CityID]	
commit transaction

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetPlaceById] (@PlaceID bigint)
as

set transaction isolation level read committed 

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceID = [Place].PlaceID;
commit transaction

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetPlaceByName] (@PlaceName nvarchar(40))
as

set transaction isolation level read committed

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @PlaceName = [Place].PlaceName;
commit transaction

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	--select * from [Place]
	-- where CityID = @CityID;

	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	where @CityID = [Place].CityID;
commit transaction

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GetTopPlacesByCityId] (@CityID bigint)
as

set transaction isolation level read committed 

begin transaction

	select top 4 * from [Place]
	where CityID = @CityID;

commit transaction

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetTopPlacesByCityName] (@CityName nvarchar(40))
as

set transaction isolation level read committed 

begin transaction

	select top 4 * from [Place]
	where CityID = (select [CityID] 
					from [dbo].[City]
					where [CityName] = @CityName)

commit transaction

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetUserFavouritePlaces] (@UserID bigint)
as

set transaction isolation level read committed

begin transaction
	select [City].[CityName], [Place].PlaceID, [Place].PlaceName, [Place].PlaceDescription, [Place].MainPlaceImage
	from [Place] inner join [City]	
	on [Place].CityID = [City].CityID
	inner join [Favourite]
	on [Place].PlaceID = [Favourite].PlaceID
	where @UserID = [Favourite].UserID;
commit transaction