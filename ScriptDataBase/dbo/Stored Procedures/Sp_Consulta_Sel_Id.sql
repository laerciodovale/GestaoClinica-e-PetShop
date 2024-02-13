
create procedure [dbo].[Sp_Consulta_Sel_Id]
(	@ConsId	int		)

AS
BEGIN
	
	SET NOCOUNT ON
    
	select * from CadConsulta where  ConsId  = @ConsId 
   
END