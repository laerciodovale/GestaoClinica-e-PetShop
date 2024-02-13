
CREATE  PROCEDURE [Sp_Func_UpDate](	
@Fu_Nome varchar(100), 
@Fu_Rg varchar(20) ,
@Fu_Cpf varchar(20) ,
@Fu_Funcao int ,
@Fu_RgProf varchar(20), 
@Fu_End varchar(100), 
@Fu_Nro varchar(6), 
@Fu_Compl varchar(30), 
@Fu_Bairro varchar(30), 
@Fu_Cidade varchar(30), 
@Fu_UF varchar(2),
@Fu_Cel varchar(20) ,
@Fu_Fixo varchar(20) ,
@Fu_CEP varchar(10),
@Fu_Ativo bit,
@Fu_Email varchar(100)
	) as
BEGIN
	update CadFunc set  FuNome=@Fu_Nome, FuRg=@Fu_Rg, 
    FuFuncao=@Fu_Funcao, FuRgProf=@Fu_RgProf,
    FuEnd=@Fu_End, FuNro = @Fu_Nro, FuCompl=@Fu_Compl, 
    FuBairro=@Fu_Bairro, FuCidade=@Fu_Cidade, FuUF=@Fu_UF, 
    FuCEP=@Fu_CEP, FuCel=@Fu_Cel, FuFixo=@Fu_Fixo, 
    FuAtivo=@Fu_Ativo, FuEmail=@Fu_Email
    where FuCpf = @Fu_Cpf ;
      END