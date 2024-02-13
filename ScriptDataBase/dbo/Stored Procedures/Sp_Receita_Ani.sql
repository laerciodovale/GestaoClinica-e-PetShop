CREATE procedure [dbo].[Sp_Receita_Ani] 
(@ID_Rec Int )

AS
BEGIN
 
	SET NOCOUNT ON

	select  RcDescFarmaco , RcReco  FROM CadReceita where RcNss  = @ID_Rec
	
   
END