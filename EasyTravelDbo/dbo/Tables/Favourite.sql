CREATE TABLE [dbo].[Favourite] (
    [FavouriteID] BIGINT IDENTITY (1, 1) NOT NULL,
    [UserID]      BIGINT NOT NULL,
    [PlaceID]     BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([FavouriteID] ASC),
    FOREIGN KEY ([PlaceID]) REFERENCES [dbo].[Place] ([PlaceID]),
    CONSTRAINT [FK__Favourite__UserI__1B0907CE] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID])
);

