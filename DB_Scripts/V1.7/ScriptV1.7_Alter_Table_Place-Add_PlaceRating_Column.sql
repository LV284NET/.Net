IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Place]') AND type in (N'U'))
BEGIN
ALTER TABLE [dbo].[Place]
	ADD	[PlaceRating] [decimal](18,2) DEFAULT(0)
END