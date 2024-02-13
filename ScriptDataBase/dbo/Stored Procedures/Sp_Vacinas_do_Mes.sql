-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Vacinas_do_Mes]
	-- Add the parameters for the stored procedure here
	(@VcMes	int)
AS
BEGIN
	
select vctp, vcdata, aninome, clnome , clcel from vw_Vacinas_do_mes where vcmes =  @VcMes
END