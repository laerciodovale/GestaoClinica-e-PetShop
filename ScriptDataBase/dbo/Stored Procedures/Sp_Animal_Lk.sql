CREATE   PROCEDURE  [dbo].[Sp_Animal_Lk]  
( @NomeLike  VARCHAR(20)) 
  AS BEGIN
  select AniNome    Nome_do_Animal, IdAnimal    Id_Ani from CadAnimal 
    where AniNome like  '%'+ @NomeLike + '%' order by AniNome;
    
END