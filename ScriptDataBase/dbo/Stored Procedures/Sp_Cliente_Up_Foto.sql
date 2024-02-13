CREATE procedure [dbo].[Sp_Cliente_Up_Foto] 
(@ID_cliente Int ,
	@ClFoto   nvarchar(max)	)

AS
BEGIN
 
	SET NOCOUNT ON

	UPDATE CadCliente SET ClFoto = @ClFoto
	WHERE CLID = @ID_cliente
		
   
END