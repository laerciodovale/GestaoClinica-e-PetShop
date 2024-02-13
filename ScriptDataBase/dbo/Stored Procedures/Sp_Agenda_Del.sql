CREATE PROCEDURE  [dbo].[Sp_Agenda_Del] ( @ag_Id  INT)   AS BEGIN
	    
	delete FROM CadAgClinica where  adId = @ag_Id 
   
END