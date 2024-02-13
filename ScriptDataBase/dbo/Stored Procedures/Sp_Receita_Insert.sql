create procedure [dbo].[Sp_Receita_Insert] 
(
@RcCli	as int	,
@RcAni	as int	,
@RcDt	as datetime	,
@RcNss	as int	,
@RcFarmaco	as nvarchar(20)	,
@RcMeio	as nvarchar(20)	,
@RcQtd	as nvarchar(6)	,
@RcVia	as decimal(18, 0)	,
@RcFreq	as decimal(18, 0)	,
@RcDias	as decimal(18, 0)	,
@RcReco	as nvarchar(80)	,
@RcEsp	as bit	,
@RcDescFarmaco	nvarchar(50)	)
		
AS
BEGIN
	DECLARE @RcId Int 
    
	SET NOCOUNT ON
    
	INSERT INTO CadReceita(	
		RcCli,RcAni,RcDt,RcNss,
		RcFarmaco,RcMeio,RcQtd,
		RcVia,RcFreq,RcDias,
		RcReco,RcEsp,RcDescFarmaco)
     VALUES  ( @RcCli,@RcAni,@RcDt,@RcNss,
		@RcFarmaco,@RcMeio,@RcQtd,@RcVia,
		@RcFreq,@RcDias,@RcReco,@RcEsp,@RcDescFarmaco)
	
	set  @RcId = SCOPE_IDENTITY ()
	select  @RcId 
   
END