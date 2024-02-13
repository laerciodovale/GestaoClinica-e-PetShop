CREATE   PROCEDURE  [dbo].[Sp_Animal_Insert]  ( @Ani_Nome  NVARCHAR(80),  @Ani_Cliente  INT, @Ani_Especie  INT,  @Ani_Raca  VARCHAR(50),  
@Ani_Porte  VARCHAR(15),  @Ani_Cor  VARCHAR(50),  @Ani_Pelo  VARCHAR(15),  @Ani_Sexo  VARCHAR(1),  @Ani_DtNas  DATE,  @Ani_Alergias  INT,
  @Ani_Registro  BIT,  @Ani_Repro  BIT,  @Ani_Vivo  BIT,  @Ani_Agressico  BIT,  @Ani_Pedigree  VARCHAR(100),  
  @Ani_Chip  VARCHAR(50),  @Ani_Obs  NVARCHAR(MAX),  @Ani_DtCad  DATE,  @Ani_Conv  NUMERIC(18,0),  @Ani_Foto  NVARCHAR(MAX))   AS BEGIN
	
	INSERT INTO CadAnimal(
	AniNome ,	AniCliente ,	AniEspécie  ,	AniRaca  ,
	AniPorte  ,	AniCor  ,	AniPelo ,	AniSexo  ,
	AniDtNas   ,	AniAlergias   ,	AniRegistro ,	AniRepro ,
	AniVivo ,	AniAgressico ,	AniPedigree  ,	AniChip  ,
	AniObs  ,	AniDtCad  ,	AniConv, AniFoto  )	
    VALUES  ( 
	 @Ani_Nome ,	 @Ani_Cliente ,	 @Ani_EspEcie  ,	 @Ani_Raca  ,
	 @Ani_Porte  ,	 @Ani_Cor  ,	 @Ani_Pelo ,	 @Ani_Sexo  ,
	 @Ani_DtNas   ,	 @Ani_Alergias  ,	 @Ani_Registro ,	 @Ani_Repro ,
	 @Ani_Vivo ,	 @Ani_Agressico ,	 @Ani_Pedigree  ,	 @Ani_Chip  ,
	 @Ani_Obs  ,	 @Ani_DtCad  ,	 @Ani_Conv , @Ani_Foto
			);
			DECLARE  @ID_Animal Int; 
        set   @ID_Animal = SCOPE_IDENTITY ();
	select   @ID_Animal ;

END