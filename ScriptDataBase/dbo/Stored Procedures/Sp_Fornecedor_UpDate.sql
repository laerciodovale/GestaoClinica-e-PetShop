CREATE   PROCEDURE [Sp_Fornecedor_UpDate] (  @F_SEQ INTEGER,
 @F_CGC varchar(20) ,
 @F_IE varchar(20) ,
 @F_IM varchar(16) ,
 @F_RAZAO varchar(50) ,
 @F_FANTASIA varchar(30) ,
 @F_END varchar(50) ,
 @F_NRO varchar(5) ,
 @F_COMPLE varchar(15) ,
 @F_CIDADE varchar(45) ,
 @F_BAIRRO varchar(40) ,
 @F_UF varchar(2) ,
 @F_CEP varchar(9) ,
 @F_CONTATO varchar(45) ,
 @F_DDD varchar(4) ,
 @F_FONE varchar(20) ,
 @F_DDDFAX varchar(4) ,
 @F_FAX varchar(20) ,
 @F_HTTP varchar(50) ,
 @F_MAIL varchar(50) ,
 @F_DTREG DATE, 
 @F_DTULTCOM date
) as
BEGIN
UPDATE  CADfornec   SET 
FCGC =  @F_CGC, FIE =  @F_IE, FIM = @F_IM,
FRAZAO =   @F_RAZAO, FFANTASIA = @F_FANTASIA, 
FEND =  @F_END,  FNRO =  @F_NRO,FCOMPLE =  @F_COMPLE,
FCIDADE =  @F_CIDADE, FBAIRRO =  @F_BAIRRO, FUF =  @F_UF, FCEP = @F_CEP, 
FCONTATO =  @F_CONTATO,
FDDD =  @F_DDD, 
FFONE =  @F_FONE, 
FDDDFAX =  @F_DDDFAX, 
FFAX =  @F_FAX,
FHTTP =  @F_HTTP, FMAIL =   @F_MAIL,
FDTREG =   @F_DTREG,  
FDTULTCOM =  @F_DTULTCOM WHERE FSEQ =  @F_SEQ;

END