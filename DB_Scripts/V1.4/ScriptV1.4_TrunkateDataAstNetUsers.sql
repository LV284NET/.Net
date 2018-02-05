IF EXISTS (SELECT * FROM sys.objects WHERE name = 'AspNetUsers')
BEGIN
	truncate table [dbo].[AspNetUsers]
END
GO