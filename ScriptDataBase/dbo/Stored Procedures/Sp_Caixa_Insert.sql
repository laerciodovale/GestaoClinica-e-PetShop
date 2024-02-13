create procedure [dbo].[Sp_Caixa_Insert] 
( 
@Mv_NssNro	int,
@Mv_Data	smalldatetime,
@Mv_VlrEnt	money,
@Mv_VlrSai	money,
@Mv_Custo	int,
@MV_Caixa	nvarchar(10),
@Fi_FPagto	nvarchar(50)
)

AS
BEGIN
 declare  @SldAtu money,
@SldAnt money, @Mv_Seq int

set @Mv_Seq = (select max(MVSEQ) from CaixaMov )
set @SldAnt = (select MvSldAtu from CaixaMov where mvseq = @Mv_Seq) 
SET @SldAtu = (@SldAnt + (@Mv_VlrEnt - @mv_VlrSai) )

	SET NOCOUNT ON
	
insert into caixamov   
(MVData  , MVCaixa, MVE,  MVS,  MVSLDANT, MVSLDATU , MVCusto,  MVDesc, MVOS )
VALUES( 
@Mv_Data, @MV_Caixa, @Mv_VlrEnt, @mv_VlrSai, @SldAnt, @SldAtu, @Mv_Custo, @Fi_FPagto,  @Mv_NssNro ) 

END