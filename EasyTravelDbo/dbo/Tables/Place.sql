CREATE TABLE [dbo].[Place] (
    [PlaceID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CityID]           BIGINT         NOT NULL,
    [PlaceName]        NVARCHAR (40)  NOT NULL,
    [PlaceDescription] TEXT           NULL,
    [MainPlaceImage]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([PlaceID] ASC),
    FOREIGN KEY ([CityID]) REFERENCES [dbo].[City] ([CityID])
);

