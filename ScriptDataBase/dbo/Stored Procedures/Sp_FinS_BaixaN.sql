CREATE   PROCEDURE [Sp_FinS_BaixaN]( 
 @Fi_NssNro	int,
 @Fi_DtPgto	  DATE,
 @Fi_Lote	int,
 @Fi_VlrPgto	decimal(12,2),
 @Fi_VlrAcre	decimal(12,2),
 @Fi_VlrDcto	decimal(12,2),
 @Fi_BcoCh	VARCHAR(5),
 @Fi_AgCh	VARCHAR(6),
 @Fi_Cta	VARCHAR(10),
 @Fi_NroCh	VARCHAR(15),
 @Fi_Emitente	VARCHAR(50),
 @Fi_ChPre	int,
 @Fi_Cartao	VARCHAR(50),
 @Fi_Caixa	VARCHAR(10),
 @Fi_NroCar	int,
 @Fi_DtVCtr	int,
 @Fi_FPagto	VARCHAR(50),
 @mv_VlrSai	decimal(12,2)
) as
BEGIN
 declare   @SldAtu decimal(12,2);
 declare @SldAnt decimal(12,2);
 declare @Mv_Seq int;

set  @Mv_Seq = (select max(MVSEQ) from CaixaMov );
set  @SldAnt = (select MvSldAtu from CaixaMov where mvseq =  @Mv_Seq) ;
SET  @SldAtu = ( @SldAnt +  @Fi_VlrPgto);

	  
	UPDATE CadFinS  SET 
	FiDtPgto =  @Fi_DtPgto, 	 filote =  @Fi_Lote,
	FiVlrPgto=  @Fi_VlrPgto,	 FiVlrAcre =  @Fi_VlrAcre, 
FiVlrDcto =  @Fi_VlrDcto,
	FiBcoCh  =  @Fi_BcoCh,	 FiAgCh  =   @Fi_AgCh,
	ficartao  =  @Fi_Cartao,	 FiCaixa =  @Fi_Caixa,
	finrocar = @Fi_NroCar,	 FiFPagto =  @Fi_FPagto
	WHERE FiNSSNRO =  @Fi_NssNro ;
    
  
    
insert into caixamov   
(MVData  , MVCaixa, MVE,  MVS,  MVSLDANT, MVSLDATU , MVCusto,  MVDesc, MVOS )
VALUES(
 @Fi_DtPgto,  @Fi_Caixa,  @Fi_VlrPgto,  @mv_VlrSai,  @sldant,  @SldAtu, 1,  @Fi_FPagto,   @Fi_NssNro ) ;

END