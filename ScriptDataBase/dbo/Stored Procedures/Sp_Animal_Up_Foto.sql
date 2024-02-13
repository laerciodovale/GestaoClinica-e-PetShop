create procedure [dbo].[Sp_Animal_Up_Foto]
(	@ID_Animal Int, 	
	@AniFoto nvarchar(max)	)
AS
BEGIN
  
	SET NOCOUNT ON
    	update CadAnimal set AniFoto =@AniFoto	where IdAnimal = @ID_Animal
    
END