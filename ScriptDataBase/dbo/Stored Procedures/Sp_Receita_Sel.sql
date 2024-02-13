CREATE procedure [dbo].[Sp_Receita_Sel] 
(@ID_Ani Int
 )

AS
BEGIN
 
	SET NOCOUNT ON

	select DISTINCT RCDT, RcNss FROM CadReceita where rcani  = @ID_Ani 
	
   
END