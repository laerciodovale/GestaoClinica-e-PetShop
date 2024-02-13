CREATE PROCEDURE [dbo].[Sp_Itens_Like]
 
(@NomeLike  varchar (20)) as
BEGIN
      	Select   ITDESC, ITITEM, ITID  from CadItemMySql
where itdesc  
    like  ('%' + @NomeLike +'%')  order by itdesc     
END