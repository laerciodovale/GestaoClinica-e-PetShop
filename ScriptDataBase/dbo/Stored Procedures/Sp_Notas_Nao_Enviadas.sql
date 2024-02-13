-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Notas_Nao_Enviadas]
	-- Add the parameters for the stored procedure here
(
@DataLan date)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	set nocount on

    -- Insert statements for procedure here
	select FiNssNro, FiCli, ClNome,
	FiDtVcto,FiVlr, mvdesc
	from cadfins, CadCliente, caixamov
	where FiNF = 0 and FiDtLan >= @DataLan 
	and FiVlr >0 and ClId=FiCli and MVOS = FiNssNro 
	
	end