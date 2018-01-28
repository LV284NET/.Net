IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersPlaceRatings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UsersPlaceRatings](
	[UsersPlaceRateID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PlaceID] [bigint] NOT NULL,
	[Rating] [decimal](18,2) NOT NULL DEFAULT(0),
CONSTRAINT pk_UsersPlaceRates PRIMARY KEY ([UsersPlaceRateID]), 
CONSTRAINT fk_UsersPlaceRates_AspNetUsers FOREIGN KEY ([UserID]) REFERENCES AspNetUsers([Id]), 
CONSTRAINT fk_UsersPlaceRates_Place FOREIGN KEY ([PlaceID]) REFERENCES Place([PlaceID])
	)
END