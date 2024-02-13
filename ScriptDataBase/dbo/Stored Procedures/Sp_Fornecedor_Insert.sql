CREATE   PROCEDURE Sp_Fornecedor_Insert( 
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
DECLARE  @ID Int 
insert into CADfornec   
(FCGC, FIE, FIM, FRAZAO, FFANTASIA, FEND, FNRO, FCOMPLE, FCIDADE, 
FBAIRRO, FUF, FCEP, FCONTATO, FDDD, FFONE, FDDDFAX, 
FFAX, FHTTP, FMAIL, FDTREG,  FDTULTCOM )
VALUES( @F_CGC,  @F_IE,  @F_IM, @F_RAZAO,  @F_FANTASIA,  @F_END,  @F_NRO,  @F_COMPLE,  @F_CIDADE, 
@F_BAIRRO,  @F_UF,  @F_CEP,  @F_CONTATO,  @F_DDD,  @F_FONE,  @F_DDDFAX, 
 @F_FAX,  @F_HTTP,  @F_MAIL,  @F_DTREG,   @F_DTULTCOM  ) ;
 
 set   @ID = SCOPE_IDENTITY ();
	select   @ID ;
END