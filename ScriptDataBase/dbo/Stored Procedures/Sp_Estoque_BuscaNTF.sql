CREATE  PROCEDURE [Sp_Estoque_BuscaNTF] 
( @ET_FORNEC integer, @ET_NOTA INTEGER )
as
BEGIN
 	select count(etseq) as qtd from  CadEstoque 
	WHERE etfornec =  @ET_FORNEC AND ETSOLIC = @ET_NOTA;
	
END