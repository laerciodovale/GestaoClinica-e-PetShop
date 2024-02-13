
CREATE   PROCEDURE  [dbo].[Sp_Animal_Del]  ( @ID_Animal  INT)   AS BEGIN
  
	  
    
	delete FROM CadAnimal 
	where IdAnimal =  @ID_Animal;
    
END