IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_UsersPlaceRatings_After_Update')
BEGIN
	DROP TRIGGER tr_UsersPlaceRatings_After_Update
END
