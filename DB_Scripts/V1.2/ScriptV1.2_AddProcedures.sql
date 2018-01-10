SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetCityById](@CityID bigint)
as

set transaction isolation level read committed 

begin transaction
	select * from [City]
	where @CityID = [CityID]	
commit transaction
GO

SET ANSI_NULLS ON
GO
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

GO