CREATE  PROCEDURE [Sp_Estoque_Sel_ITEM] ( @ET_ITEM varchar(20) ) as
BEGIN
 	select * from  CadEstoque 
	WHERE etitem =  @ET_ITEM;
	
END