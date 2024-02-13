-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Agenda_Sel]
	-- Add the parameters for the stored procedure here
	(@ag_Data	date)
AS
BEGIN
	
	select * from CadAgClinica where  agData =  @ag_Data order by  agHora;    

END