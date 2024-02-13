

CREATE procedure [dbo].[Sp_Cliente_CPF]
	(@CPF  nvarchar(20))	
AS
BEGIN
  
	SET NOCOUNT ON
    
	select * from CadCliente where (ClCpf = @CPF   )
	 order by ClNome
	
	
    
END