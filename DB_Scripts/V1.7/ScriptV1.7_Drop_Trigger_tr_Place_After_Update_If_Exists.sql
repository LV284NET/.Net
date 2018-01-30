IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_Place_After_Update')
BEGIN
	DROP TRIGGER tr_Place_After_Update
END