
CREATE procedure [dbo].[Sp_Cliente_Lk]
	(@NomeLike  nvarchar (20) )	
AS
BEGIN
  
	SET NOCOUNT ON
    
	select ClNome as Proprietario, clid as Codigo from CadCliente where ClNome like  '%' + @NomeLike + '%'  order by ClNome
    
END