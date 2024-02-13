create procedure [dbo].[Sp_FinA_NssNro] 
(@NssNro integer )

AS
BEGIN
 
	SET NOCOUNT ON

	select * from  CadFaCli
	WHERE FaNssNro = @NssNro
		
   
END