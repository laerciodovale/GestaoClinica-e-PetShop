-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Animal_Sel]
(	 @ID_Animal Int	) as
BEGIN
 
  
	  
    
	Select * from CadAnimal 
	where IdAnimal =  @ID_Animal
      
END