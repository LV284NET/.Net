USE [Lv-284.Net_EasyTravel]
GO
/****** Object:  StoredProcedure [dbo].[GetCountCity]    Script Date: 2018-01-23 1:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetCountCity]
as
select COUNT (*) from [City]