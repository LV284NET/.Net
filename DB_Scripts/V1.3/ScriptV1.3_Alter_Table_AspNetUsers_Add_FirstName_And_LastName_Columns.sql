USE [Lv-284.Net_EasyTravel]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER TABLE [dbo].[AspNetUsers]
	ADD	[FirstName] [nvarchar](max) NULL,
		[LastName] [nvarchar](max) NULL