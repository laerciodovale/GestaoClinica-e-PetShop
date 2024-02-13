CREATE procedure [dbo].[Sp_Receita_NssNro] 
(@ID_Ani Int,
@ID_Rec int )

AS
BEGIN
 
	SET NOCOUNT ON

	select RcEsp, RcDescFarmaco , RcReco, RcId  FROM CadReceita where rcani  = @ID_Ani and  RcNss  = @ID_Rec
	
   
END