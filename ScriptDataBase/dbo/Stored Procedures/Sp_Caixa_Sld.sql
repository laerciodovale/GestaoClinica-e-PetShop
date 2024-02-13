create procedure [dbo].[Sp_Caixa_Sld]
(	@Mv_Seq Int	,
@Mv_SldAn	money,
@Mv_SldAt	money
)
AS
BEGIN
  
	SET NOCOUNT ON
    
	update caixamov set  mvsldant = @Mv_SldAn,  
            mvsldatu = @Mv_SldAt  where mvseq = @Mv_Seq

    
END