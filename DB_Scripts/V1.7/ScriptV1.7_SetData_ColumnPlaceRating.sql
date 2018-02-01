IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Place')
BEGIN	
	UPDATE [Place] SET PlaceRating=0
END