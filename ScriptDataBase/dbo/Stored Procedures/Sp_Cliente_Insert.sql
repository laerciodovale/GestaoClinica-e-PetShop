CREATE PROCEDURE  [Sp_Cliente_Insert] (
	 @Cl_Nome    varchar  (100) ,
	 @Cl_Contato    varchar  (100) ,
	 @Cl_End    varchar  (100) ,
	 @Cl_Nro    varchar  (8) ,
	 @Cl_Bairro    varchar  (50) ,
	 @Cl_Cidade    varchar  (50) ,
	 @Cl_Uf    varchar  (2) ,
	 @Cl_CEP    varchar  (10) ,
	 @Cl_Cel    varchar  (20) ,
	 @Cl_Fixo    varchar  (20) ,
	 @Cl_Email    varchar  (100) ,
	 @Cl_DtN      date   ,
	 @Cl_RG    varchar  (20) ,
	 @Cl_Cpf    varchar  (20) ,
	 @Cl_DtCad    date   ,
	 @Cl_Compl    varchar  (50),
     @Cl_Foto    nvarchar(max)
	)
	as
BEGIN
	DECLARE  @ID_cliente Int 
    	     
	INSERT INTO CadCliente (
    ClNome ,	ClContato, ClEnd, ClNro, ClBairro, ClCidade,    
	ClUf, ClCEP, ClCel, ClFixo, ClEmail, ClDtNas  , 
	ClRG, ClCpf, ClDtCad, ClCompl, ClFoto)
    VALUES  (  @Cl_Nome ,	 @Cl_Contato,  @Cl_End,  @Cl_Nro,  @Cl_Bairro,  @Cl_Cidade,    
	 @Cl_Uf,  @Cl_CEP,  @Cl_Cel,  @Cl_Fixo,  @Cl_Email,  @Cl_DtN  , 
	 @Cl_RG,  @Cl_Cpf,  @Cl_DtCad,  @Cl_Compl, @Cl_Foto )
	  
	set   @ID_cliente = SCOPE_IDENTITY ();
	select   @ID_cliente ;
   
END