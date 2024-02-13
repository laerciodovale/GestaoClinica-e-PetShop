create procedure [dbo].[Sp_FinS_NssNro] 
(@NssNro integer )

AS
BEGIN
 
	SET NOCOUNT ON

	select * from  CadFinS
	WHERE FiNssNro = @NssNro
		
   
END