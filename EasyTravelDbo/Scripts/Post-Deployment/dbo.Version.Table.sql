USE [Lv-284.Net_EasyTravel]
GO
/****** Object:  Table [dbo].[Version]    Script Date: 12/28/2017 7:30:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Version](
	[VersionID] [bigint] IDENTITY(1,1) NOT NULL,
	[Version] [nvarchar](10) NOT NULL,
	[Date] [smalldatetime] NOT NULL,
	[Author] [nvarchar](40) NULL,
 CONSTRAINT [PK__Version__16C6402FAB3F1935] PRIMARY KEY CLUSTERED 
(
	[VersionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
