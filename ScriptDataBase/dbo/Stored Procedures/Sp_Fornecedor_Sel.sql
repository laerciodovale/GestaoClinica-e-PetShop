CREATE   PROCEDURE [Sp_Fornecedor_Sel]( @FOR_CGC varchar(20) ) as
BEGIN
 	select * from  CADFORNEC 
	WHERE FCGC =  @FOR_CGC;
		   
END