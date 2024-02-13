
CREATE procedure [dbo].[Sp_Cliente_SelDtNas]
(	@Cl_DtNas	date		)

AS
BEGIN
	
	SET NOCOUNT ON;
    
	select ClId, ClNome, ClDtNas, ClEmail, ClCel  from CadCliente where  ClDtNas = @Cl_DtNas 
   
END