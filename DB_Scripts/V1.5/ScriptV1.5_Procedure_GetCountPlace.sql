IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCountPlace')
BEGIN
	DROP PROCEDURE [dbo].[GetCountPlace]
END
GO
Create procedure [dbo].[GetCountPlace]
as
select COUNT (*) from [Place]	