USE [Codematic]
GO
/****** 对象:  StoredProcedure [dbo].[W_GetMaterial_MaterialName]    脚本日期: 03/27/2010 09:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[W_GetMaterial_MaterialName] 
	-- Add the parameters for the stored procedure here
   @Name nvarchar(100)
	
AS
BEGIN
	

    -- Insert statements for procedure here
select W_Material.Name,W_Receivestate.Id,W_Receivestate.Dormacy,W_Receivestate.IssureTime,W_Receiver.Receiver
from W_Receivestate join W_Material
on W_Receivestate. MaterialId=W_Material.Id
join W_Receiver
on W_Receivestate.ReceiverId=W_Receiver.Id
where 
Name like '%'+@Name+'%' order by W_Receivestate.IssureTime desc
END










