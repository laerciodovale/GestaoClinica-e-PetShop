
create procedure [dbo].[Sp_Consulta_Insert]
(@ConsAnimal int,
@ConsData date,
@ConsHora datetime,
@ConsTipo nvarchar(8),
@ConsAnamnese ntext,
@ConsT nvarchar(10),
@ConsPeso money,
@ConsRPM int,
@ConsBPM int,
@ConsPA nvarchar(10),
@ConsHistsic ntext,
@ConsProg ntext,
@ConsDiag ntext,
@ConsDtRet date	)

AS
BEGIN
	DECLARE @ConsId Int 
    
	SET NOCOUNT ON
    
	INSERT INTO CadConsulta(ConsAnimal, ConsData,
	ConsHora, ConsTipo, ConsAnamnese, ConsT,
	ConsPeso, ConsRPM, ConsBPM,ConsPA,
	ConsHistsic, ConsProg, ConsDiag, ConsDtRet	  )	
    VALUES  ( @ConsAnimal, @ConsData,
	@ConsHora, @ConsTipo, @ConsAnamnese, @ConsT,
	@ConsPeso, @ConsRPM, @ConsBPM,@ConsPA,
	@ConsHistsic, @ConsProg, @ConsDiag, @ConsDtRet	  	)
	
	set  @ConsId = SCOPE_IDENTITY ()
	select  @ConsId 
   
END