create procedure [dbo].[Sp_Animal_Up]
(	@ID_Animal Int, 	@AniNome nvarchar (80),
	@AniCliente int,	@AniEspécie int ,
	@AniRaca nvarchar(50) ,	@AniPorte nvarchar(15) ,
	@AniCor nvarchar(50) ,	@AniPelo nvarchar(15),
	@AniSexo nvarchar(1) ,	@AniDtNas smalldatetime,
	@AniAlergias int,	@AniRegistro bit,
	@AniRepro bit,	@AniVivo bit,
	@AniAgressico bit,	@AniPedigree nvarchar(100) ,
	@AniChip nvarchar(50) ,	@AniObs ntext ,
	@AniConv numeric(18, 0) 	
	)
AS
BEGIN
  
	SET NOCOUNT ON
    
	update CadAnimal set 
	AniNome =@AniNome,	AniCliente =@AniCliente,	AniEspécie =@AniEspécie ,	AniRaca  =@AniRaca,
	AniPorte  = @AniPorte,	AniCor = @AniCor ,	AniPelo =@AniPelo,	AniSexo =@AniSexo ,
	AniDtNas =@AniDtNas,	AniAlergias =@AniAlergias,	AniRegistro =@AniRegistro,	AniRepro =@AniRepro,
	AniVivo =@AniVivo,	AniAgressico =@AniAgressico,	AniPedigree =@AniPedigree ,	AniChip  =@AniChip,
	AniObs =@AniObs ,	AniConv  =@AniConv 
	where IdAnimal = @ID_Animal
    
END