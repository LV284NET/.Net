USE [Lv-284.Net_EasyTravel]
GO
/****** Object:  Table [dbo].[Place]    Script Date: 12/28/2017 7:30:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place](
	[PlaceID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityID] [bigint] NOT NULL,
	[PlaceName] [nvarchar](40) NOT NULL,
	[PlaceDescription] [text] NULL,
	[MainPlaceImage] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PlaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Place]  WITH CHECK ADD FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
