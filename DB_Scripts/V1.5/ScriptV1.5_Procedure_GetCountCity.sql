IF EXISTS (SELECT * FROM sys.objects WHERE name = 'GetCountCity')
BEGIN
	DROP PROCEDURE [dbo].[GetCountCity]
END
GO
CREATE procedure [dbo].[GetCountCity]
as
select COUNT (*) from [City]