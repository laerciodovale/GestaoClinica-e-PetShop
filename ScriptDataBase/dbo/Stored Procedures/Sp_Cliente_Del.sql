CREATE procedure [dbo].[Sp_Cliente_Del] 
(@ID_cliente Int )

AS
BEGIN
 
	SET NOCOUNT ON

	DELETE  CadCliente 
	WHERE CLID = @ID_cliente
		
   
END