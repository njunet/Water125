USE [Codematic]
GO
/****** 对象:  StoredProcedure [dbo].[W_Material_GetMaterial]    脚本日期: 03/27/2010 09:54:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE [dbo].[W_Material_GetMaterial]
@key nvarchar(100)
AS

SELECT * FROM W_Material where Name like '%'+@key+'%' order by Id desc




