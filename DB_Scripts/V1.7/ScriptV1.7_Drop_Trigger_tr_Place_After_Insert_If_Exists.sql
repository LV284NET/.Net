IF EXISTS (SELECT * FROM sys.objects WHERE name = 'tr_Place_After_Insert')
BEGIN
	DROP TRIGGER tr_Place_After_Insert
END