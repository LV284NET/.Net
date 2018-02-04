﻿IF EXISTS (SELECT * FROM sys.objects Where name = 'Filters')
BEGIN
	DROP TABLE [dbo].[Filters]
END
GO

CREATE TABLE [dbo].[Filters](
	[FilterId] [bigint] IDENTITY(1,1) NOT NULL,
	[FilterName] [nvarchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FilterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]