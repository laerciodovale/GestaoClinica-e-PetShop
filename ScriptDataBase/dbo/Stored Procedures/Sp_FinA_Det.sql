create procedure [dbo].[Sp_FinA_Det] 
(@NssNro integer )

AS
BEGIN
 
	SET NOCOUNT ON

	select FaDesc, FaQtd, FaVlrU, FaVlr , FaDcto  from  CadFaCli
	WHERE FaNssNro = @NssNro
		
   
END