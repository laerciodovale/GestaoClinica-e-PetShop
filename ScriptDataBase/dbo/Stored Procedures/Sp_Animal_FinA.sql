CREATE   PROCEDURE  [dbo].[Sp_Animal_FinA]  ( @NssNro  INT)   AS BEGIN
  
	  
    
	Select FaDesc, FaVlrU, FaQtd, FaDcto, FaVlr, FaNssNro from CadFaCli
	where FaNssNro =  @NssNro;
    
END