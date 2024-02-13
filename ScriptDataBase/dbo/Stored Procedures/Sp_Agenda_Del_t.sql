CREATE PROCEDURE  [dbo].[Sp_Agenda_Del_t] ( @ag_Id  INT)  as  BEGIN
	    
	delete FROM CadAgClinica where  adid = @ag_Id 
   
END