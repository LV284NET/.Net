IF EXISTS (SELECT * FROM sys.objects Where name = 'FiltersPlacesJT')
BEGIN
	DROP TABLE [dbo].[FiltersPlacesJT]
END
GO

CREATE TABLE [dbo].[FiltersPlacesJT](
	[FilterId] [bigint] NOT NULL,
	[PlaceId] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FilterId] ASC,
	[PlaceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[FiltersPlacesJT]  WITH CHECK ADD FOREIGN KEY([FilterId])
REFERENCES [dbo].[Filters] ([FilterId])
GO

ALTER TABLE [dbo].[FiltersPlacesJT]  WITH CHECK ADD FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Place] ([PlaceID])
GO