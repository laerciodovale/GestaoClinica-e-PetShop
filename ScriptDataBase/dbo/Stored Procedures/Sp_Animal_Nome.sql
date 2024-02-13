CREATE   PROCEDURE  [dbo].[Sp_Animal_Nome]  ( @ID_AnimalNomeLike  VARCHAR(20))   AS BEGIN
  
	  
    
	select * from CadAnimal where (AniNome like  '%' + @ID_AnimalNomeLike + '%'   )
	 order by AniNome;
  
END