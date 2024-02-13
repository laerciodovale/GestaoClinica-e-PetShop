create procedure [dbo].[Sp_Vacina_Grupo]

AS
BEGIN
  
	SET NOCOUNT ON
    
	select msmat, msdesc FROM  CADitem where msgrupo = 7 order by msDESC
	
    
END