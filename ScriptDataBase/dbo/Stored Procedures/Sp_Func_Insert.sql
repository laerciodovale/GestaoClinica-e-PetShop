CREATE  PROCEDURE [Sp_Func_Insert](	
@Fu_Nome varchar(100), 
@Fu_Rg varchar(20) ,
@Fu_Cpf varchar(20) ,
@Fu_Funcao int ,
@Fu_RgProf varchar(20), 
@Fu_End varchar(100), 
@Fu_Nro varchar(6) ,
@Fu_Compl varchar(30) ,
@Fu_Bairro varchar(45), 
@Fu_UF varchar(2),
@Fu_Cidade varchar(45) ,
@Fu_Cel varchar(20) ,
@Fu_Fixo varchar(20) ,
@Fu_CEP varchar(10),
@Fu_Ativo bit,
@Fu_Email varchar(100)
	)
as
BEGIN
SET NOCOUNT ON
DECLARE  @ID Int 

	INSERT INTO CadFunc ( FuNome, FuRg, FuCpf, FuFuncao, FuRgProf, 
    FuEnd,  FuNro, FuCompl, FuBairro, FuCidade, FuUF,
    FuCel, FuFixo,   FuCEP, FuAtivo, FuEmail)	
	VALUES  (@Fu_Nome, @Fu_Rg, @Fu_Cpf, @Fu_Funcao, @Fu_RgProf, 
    @Fu_End,  @Fu_Nro, @Fu_Compl, @Fu_Bairro, @Fu_Cidade, @Fu_UF,
    @Fu_Cel, @Fu_Fixo,   @Fu_CEP, @Fu_Ativo , @Fu_Email);
	
	set   @ID = SCOPE_IDENTITY ();
	select   @ID;

END