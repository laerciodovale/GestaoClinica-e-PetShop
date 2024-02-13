CREATE   PROCEDURE  [dbo].[Sp_Caixa_Del]  ( @Fi_NssNro  INT)   AS BEGIN
   
	delete FROM caixamov Where MVOS =  @Fi_NssNro;
    
END