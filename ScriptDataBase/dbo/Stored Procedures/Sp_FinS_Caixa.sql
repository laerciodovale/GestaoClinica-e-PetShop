CREATE procedure [dbo].[Sp_FinS_Caixa] 
(@Dt_Fat date )

AS
BEGIN
 
	SET NOCOUNT ON

	select * from  vwCaixaDia
	WHERE fidtvcto = @Dt_Fat
		
   
END