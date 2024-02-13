CREATE procedure [dbo].[Sp_FinA_UpLista] 
(@FaCli integer,
@FaAni integer,
@FaNssNro integer )

AS
BEGIN
 
	SET NOCOUNT ON

	update CadFaCli set FaNssNro = @FaNssNro
	WHERE FaCli  = @FaCli and FaAni = @FaAni and FaNssNro = 0
		
   
END