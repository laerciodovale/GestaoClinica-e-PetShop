
create procedure [dbo].[Sp_Consulta_Sel_An]
(	@ConsAnimal	int		)

AS
BEGIN
	
	SET NOCOUNT ON
    
	select ConsData, ConsHora, ConsTipo, ConsId from CadConsulta where  ConsAnimal  = @ConsAnimal 
   
END