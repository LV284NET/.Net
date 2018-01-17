CREATE TABLE [dbo].[Version] (
    [VersionID] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Version]   NVARCHAR (10) NOT NULL,
    [Date]      SMALLDATETIME NOT NULL,
    [Author]    NVARCHAR (40) NULL,
    CONSTRAINT [PK__Version__16C6402FAB3F1935] PRIMARY KEY CLUSTERED ([VersionID] ASC)
);

