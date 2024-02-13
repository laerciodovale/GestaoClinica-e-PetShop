-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Nota_Up_Finan_N]
	-- Add the parameters for the stored procedure here
(
@DataLan date)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	set nocount on

    -- Insert statements for procedure here
	select finssnro, FiCli, ClNome,
	FiDtVcto , FiVlr , MVDesc 
	from cadfins, CadCliente, CaixaMov 
	where FiNF = 0 and FiDtLan = @DataLan 
	and FiVlr >0 and ClId = FiCli
	and MVOS = finssnro
	
	
	end