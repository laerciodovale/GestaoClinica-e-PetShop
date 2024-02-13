-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Nota_Up_Finan]
	-- Add the parameters for the stored procedure here
(
@FI_NSSNRO int,
@NOTA int
)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	set nocount on

    -- Insert statements for procedure here
	update CadFinS set FiNF = @NOTA 
	where FiNssNro = @FI_NSSNRO 
	
	end