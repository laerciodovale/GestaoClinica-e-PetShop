CREATE  PROCEDURE [Sp_Estoque_Sum] ( @ET_ITEM int ) as
BEGIN
 	select SUM(ETQTDE - ETQTDS) AS SALDO from  CadEstoque 
	WHERE ETITEM =  @ET_ITEM;
	
END