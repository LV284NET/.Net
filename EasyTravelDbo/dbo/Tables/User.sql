CREATE TABLE [dbo].[User] (
    [UserID]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Email]        NVARCHAR (40)   NOT NULL,
    [Password]     VARBINARY (128) NOT NULL,
    [FirstName]    NVARCHAR (40)   NOT NULL,
    [LastName]     NVARCHAR (40)   NOT NULL,
    [ProfilePhoto] NVARCHAR (MAX)  NULL,
    [RoleID]       INT             CONSTRAINT [DF__User__RoleID__108B795B] DEFAULT ((1)) NULL,
    CONSTRAINT [PK__User__1788CCAC92E83658] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [FK__User__RoleID__182C9B23] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([RoleID])
);

