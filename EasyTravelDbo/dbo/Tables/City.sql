CREATE TABLE [dbo].[City] (
    [CityID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CityName]        NVARCHAR (40)  NOT NULL,
    [CityDescription] TEXT           NULL,
    [CityPhoto]       NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([CityID] ASC)
);

