IF EXISTS (SELECT * FROM sys.objects WHERE name = 'City')
BEGIN	
	UPDATE [City] SET CityRating=0
END