CREATE  PROCEDURE [Sp_Estoque_Sel_ID]( @ET_SEQ int ) as
BEGIN
 	select * from  CadEstoque 
	WHERE ETSEQ =  @ET_SEQ;
	
END