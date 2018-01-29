IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_UsersPlaceRatings_After_Delete')
BEGIN
	DROP TRIGGER tr_UsersPlaceRatings_After_Delete
END
GO 