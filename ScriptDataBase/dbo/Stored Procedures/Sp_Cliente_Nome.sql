
CREATE procedure [dbo].[Sp_Cliente_Nome]
	(@NomeLike  nvarchar)	
AS
BEGIN
  
	SET NOCOUNT ON
    
	select * from CadCliente where (clNome like  '%'+ @NomeLike + '%'  )
	 order by ClNome
  
END