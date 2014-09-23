USE [Codematic]
GO
/****** 对象:  StoredProcedure [dbo].[W_Material_ShowIndex]    脚本日期: 03/27/2010 09:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





-- =============================================
-- Author:		<Author,,Neame>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[W_Material_ShowIndex] 
	-- Add the parameters for the stored procedure here
   @intTop int
	
AS
BEGIN
	
set rowcount @intTop
    -- Insert statements for procedure here
select W_Material.Name,W_Receivestate.MaterialId,W_Receivestate.IssureTime,W_Receiver.Receiver
from W_Receivestate join W_Material
on W_Receivestate. MaterialId=W_Material.Id
join W_Receiver
on W_Receivestate.ReceiverId=W_Receiver.Id

where Dormacy ='提交'
order by IssureTime desc



END








