IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
BEGIN
ALTER TABLE [dbo].[City]
	ADD	[CityRating] [decimal](18,2) DEFAULT(0)
END