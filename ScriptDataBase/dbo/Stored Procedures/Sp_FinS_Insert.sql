CREATE procedure [dbo].[Sp_FinS_Insert] 
(  
@Fi_NssNro as	int,
@Fi_Cli as	int,
@Fi_Ani	 as int,
@Fi_AnoMes	as int,
@Fi_DtVcto	as smalldatetime,
@Fi_DtPgto	as 	smalldatetime,
@Fi_Lote	as real,
@Fi_VlrAd	as money,
@Fi_VlrDev 	as 	money,
@Fi_Vlr		as money,
@Fi_VlrPgto	as money,
@Fi_VlrDcto	as money,
@Fi_VlrAcre	as 	money,
@Fi_CodBar	as 	nvarchar(100),
@Fi_LinDig	as 	nvarchar(80),
@Fi_Emi		as real,
@Fi_DtLan	as 	datetime,
@Fi_Emp		as real,
@Fi_Custo	as real,
@Fi_BcoCh	as nvarchar(5),
@Fi_AgCh	as nvarchar(6),
@Fi_Cta		as nvarchar(10),
@Fi_NroCh	as nvarchar(15),
@Fi_Emitente as nvarchar(50),
@Fi_ChPre	as int,
@Fi_Cartao	as nvarchar(50),
@Fi_Caixa	as nvarchar(10),
@Fi_DevCh	as nvarchar(2),
@Fi_Obs		as nvarchar(150),
@Fi_NroCar	as int,
@Fi_DtVCtr	as int,
@FI_LancImp	as int,
@Fi_ChAnt	as char(30),
@Fi_Conv	as int,
@Fi_ConvReq	as int,
@Fi_NF		as int,
@Fi_Ordem	as int,
@Fi_Ev		as int,
@Fi_Fat		as 	int,
@Fi_VlrImp	as money,
@Fi_FPagto	as nvarchar(50)
 )

AS
BEGIN
 
	SET NOCOUNT ON
DECLARE  @ID Int 
	insert into CadFinS   (
	FiNssNro,	FiCli,		FiAni,		FiAnoMes,	
	FiDtVcto,	FiDtPgto,	FiLote,		FiVlrAd, FiVlrDev, 	
	FiVlr,		FiVlrPgto,	FiVlrDcto,	FiVlrAcre,	
	FiCodBar, FiLinDig,	FiEmi,		FiDtLan,	FiEmp,		
	FiCusto,	FiBcoCh,	FiAgCh,		FiCta,		
	FiNroCh,	FiEmitente,	FiChPre,	FiCartao,		
	FiCaixa,	FiDevCh,	FiObs,		FiNroCar,		
	FiDtVCtr,	FILancImp,	FiChAnt,	FiConv,		
	FiConvReq,	FiNF,		FiOrdem,	FiEv,		
	FiFat,		FiVlrImp,	FiFPagto	)
	VALUES ( 
	@Fi_NssNro, @Fi_Cli,	@Fi_Ani ,	@Fi_AnoMes,	
	@Fi_DtVcto, @Fi_DtPgto, @Fi_Lote,	@Fi_VlrAd, @Fi_VlrDev,
	@Fi_Vlr,	@Fi_VlrPgto,@Fi_VlrDcto,@Fi_VlrAcre,	
	@Fi_CodBar, @Fi_LinDig,	@Fi_Emi,	@Fi_DtLan,	@Fi_Emp,		
	@Fi_Custo,	@Fi_BcoCh,	@Fi_AgCh,	@Fi_Cta,		
	@Fi_NroCh,	@Fi_Emitente, @Fi_ChPre, @Fi_Cartao,		
	@Fi_Caixa,	@Fi_DevCh,	@Fi_Obs,	@Fi_NroCar,		
	@Fi_DtVCtr,	@FI_LancImp, @Fi_ChAnt,	@Fi_Conv,		
	@Fi_ConvReq, @Fi_NF,	@Fi_Ordem,	@Fi_Ev,		
	@Fi_Fat,	@Fi_VlrImp,	@Fi_FPagto ) 



 set   @ID = SCOPE_IDENTITY ();
	select   @ID;
	

END