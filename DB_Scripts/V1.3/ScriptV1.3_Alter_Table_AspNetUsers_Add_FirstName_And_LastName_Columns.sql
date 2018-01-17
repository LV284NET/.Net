IF EXISTS (SELECT * FROM sys.objects WHERE name = 'AspNetUsers')
	AND NOT EXISTS (SELECT * FROM sys.columns 
					WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUsers]')
					AND name = 'FirstName') 
	AND NOT EXISTS (SELECT * FROM sys.columns 
					WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUsers]')
					AND name = 'LastName') 				 
BEGIN 
	ALTER TABLE [dbo].[AspNetUsers]
	ADD	[FirstName] [nvarchar](max) NULL,
		[LastName] [nvarchar](max) NULL
END
GO