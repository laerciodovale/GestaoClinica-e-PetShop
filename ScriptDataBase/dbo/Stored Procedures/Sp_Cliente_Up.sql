CREATE procedure [dbo].[Sp_Cliente_Up] 
(@ID_cliente Int ,
	@ClNome    nvarchar  (100) ,
	@ClContato    nvarchar  (100) ,
	@ClEnd    nvarchar  (100) ,
	@ClNro    nvarchar  (8) ,
	@ClBairro    nvarchar  (50) ,
	@ClCidade    nvarchar  (50) ,
	@ClUf    nvarchar  (2) ,
	@ClCEP    nvarchar  (10) ,
	@ClCel    nvarchar  (20) ,
	@ClFixo    nvarchar  (20) ,
	@ClEmail    nvarchar  (100) ,
	@ClDtNas    smalldatetime   ,
	@ClRG    nvarchar  (20) ,
	@ClCpf    nvarchar  (20) ,
	@ClCompl    nvarchar  (50) 
	)

AS
BEGIN
 
	SET NOCOUNT ON

	UPDATE CadCliente SET 
	ClNome = @ClNome ,	
	ClContato= @ClContato,  
	ClEnd = @ClEnd,
	ClNro = @ClNro, 
	ClBairro = @ClBairro,
	ClCidade = @ClCidade ,
	ClUf = @ClUf, 
	ClCEP = @ClCEP, 
	ClCel = @ClCel, 
	ClFixo = @ClFixo, 
	ClEmail = @ClEmail, 
	ClDtNas = @ClDtNas, 
	ClRG = @ClRG, 
	ClCpf = @ClCpf, 
	ClCompl = @ClCompl
	WHERE CLID = @ID_cliente
		
   
END