-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Ntfse_Total]
	-- Add the parameters for the stored procedure here
(
@Nss_Nro integer)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	set nocount on

    -- Insert statements for procedure here
	select SUM(FaVlr) as total 
	from cadfacli, caditem
	where FaNssNro=@Nss_Nro And FaEv=MSMAT 
	
	
	end