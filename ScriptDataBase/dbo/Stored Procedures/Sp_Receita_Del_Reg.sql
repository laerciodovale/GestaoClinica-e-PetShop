Create procedure [dbo].[Sp_Receita_Del_Reg] 
(
@ID_Rec int )

AS
BEGIN
 
	SET NOCOUNT ON

	delete   FROM CadReceita where   RcId  = @ID_Rec
	
   
END