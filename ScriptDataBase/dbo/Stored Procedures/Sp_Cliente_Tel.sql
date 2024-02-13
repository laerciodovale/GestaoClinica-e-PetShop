
CREATE procedure [dbo].[Sp_Cliente_Tel]
	(@NomeLike  nvarchar(20))	
AS
BEGIN
  
	SET NOCOUNT ON
    
	select ClId, ClNome from CadCliente where (ClCel like  '%'+ @NomeLike + '%'  )
	or 
	(ClFixo like '%' + @NomeLike + '%') 
	 order by ClNome
	
	
    
END