IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_Place_After_Delete')
BEGIN
	DROP TRIGGER tr_Place_After_Delete
END