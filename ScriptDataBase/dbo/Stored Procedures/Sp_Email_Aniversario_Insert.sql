
CREATE procedure [dbo].[Sp_Email_Aniversario_Insert]
( 	@Nv_Cli int,
@Nv_CliDt	date,
@Nv_AniDt	date,
@Nv_Ani int	)

AS
BEGIN
	DECLARE @Nv_Id Int 
    
	SET NOCOUNT ON
    
	INSERT INTO CademailAniversario ( EmailCli, EmailDtCli, Emailani , EmailDtAni )	
    VALUES  ( @nv_cli, @Nv_CliDt, @Nv_Ani, @Nv_AniDt )
	
	set  @nv_Id = SCOPE_IDENTITY ()
	select  @nv_Id
   
END