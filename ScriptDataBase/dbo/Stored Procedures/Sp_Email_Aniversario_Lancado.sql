
create procedure [dbo].[Sp_Email_Aniversario_Lancado]
( 	@Nv_Cli int,
@Nv_CliDt	date,
@Nv_AniDt	date,
@Nv_Ani int	)
AS
BEGIN
  
	SET NOCOUNT ON
    
	Select * from CadEmailAniversario  
	where EmailCli = @Nv_Cli and EmailDtCli = @Nv_CliDt and EmailAni = EmailAni and EmailDtAni = @Nv_AniDt 
    


END