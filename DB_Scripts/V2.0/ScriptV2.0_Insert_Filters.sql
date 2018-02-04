IF EXISTS (SELECT * FROM sys.objects WHERE name = 'Filters')
BEGIN
	SET IDENTITY_INSERT [dbo].[Filters] ON 
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (1, N'Monument')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (2, N'Church')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (3, N'Food&Drink')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (4, N'Theater')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (5, N'Museum')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (6, N'Park')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (7, N'Shop')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (8, N'Entertaiment')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (9, N'Sightseeing')
	INSERT [dbo].[Filters] ([FilterId], [FilterName]) VALUES (10, N'Bar')
	SET IDENTITY_INSERT [dbo].[Filters] OFF
END
	