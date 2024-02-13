
Create procedure [dbo].[Sp_Aniversario_Lancado]
( 	@Nv_Cli int,
@Nv_CliDt	date,
@Nv_AniDt	date,
@Nv_Ani int	)
AS
BEGIN
  
	SET NOCOUNT ON
    
	Select * from CadAniversarios  
	where nvcli = @Nv_Cli and NvCliDt = @Nv_CliDt and NvAni = @Nv_Ani and NvAniDt = @Nv_AniDt 
    
END