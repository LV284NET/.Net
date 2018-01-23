USE [Lv-284.Net_EasyTravel]
GO
/****** Object:  StoredProcedure [dbo].[GetCountPlace]    Script Date: 2018-01-23 1:41:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[GetCountPlace]
as
select COUNT (*) from [Place]	