

create procedure [dbo].[Sp_FinA_Vacina]
(
@VcAni	int) 
AS
BEGIN

	SET NOCOUNT ON
    
	select FaDt, FaDesc from CadFaCli, CadItem	where FaAni = @VcAni and MSMAT = FaEv  and MSGRUPO = 7

END