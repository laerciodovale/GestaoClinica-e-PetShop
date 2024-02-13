
create procedure [dbo].[Sp_SelDtNasCli_Id]
(	@Cl_DtNas	date		)

AS
BEGIN
	
	SET NOCOUNT ON;
    
	select ClId, ClNome, ClDtNas, ClEmail, ClCel  from CadCliente where  ClDtNas = @Cl_DtNas 
   
END