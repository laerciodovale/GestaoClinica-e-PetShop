-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Ntfse_Itens_FaCli]
	-- Add the parameters for the stored procedure here
(
@Nss_Nro integer)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	set nocount on

    -- Insert statements for procedure here
	select Faseq, FaCli ,FaAni, FaNssNro, FaEv,FaDesc,FaQtd,FaVlrU,FaDcto,FaVlr,
	FaVlrAd,IDMS,MSMAT,MSTIPO,MSUNID,MSDESC 
	from cadfacli, caditem
	where FaNssNro=@Nss_Nro And FaEv=MSMAT 
	
	end