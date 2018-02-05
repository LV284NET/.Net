IF EXISTS (SELECT * FROM sys.objects WHERE name = 'AspNetUsers')
BEGIN
	ALTER TABLE [dbo].[AspNetUsers]
		ADD	[FirstName] [nvarchar](max) NULL,
			[LastName] [nvarchar](max) NULL
END