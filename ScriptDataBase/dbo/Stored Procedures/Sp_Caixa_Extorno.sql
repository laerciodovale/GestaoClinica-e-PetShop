CREATE   PROCEDURE  [dbo].[Sp_Caixa_Extorno]  ( @Fi_NssNro  INT,  @Fi_DtPgto  DATE,  @Fi_Lote  REAL,  @Fi_VlrPgto  DECIMAL(12,2),  
@Fi_VlrAcre  DECIMAL(12,2),  @Fi_VlrDcto  DECIMAL(12,2),  @Fi_BcoCh  VARCHAR(5),  @Fi_AgCh  VARCHAR(6),  @Fi_Cta  VARCHAR(10),
  @Fi_NroCh  VARCHAR(15),  @Fi_Emitente  VARCHAR(50),  @Fi_ChPre  INT,  @Fi_Cartao  VARCHAR(50),  @Fi_Caixa  VARCHAR(10),  
  @Fi_NroCar  INT,  @Fi_DtVCtr  INT,  @Fi_FPagto  VARCHAR(50))   AS BEGIN
    
    UPDATE CadFinS  SET 
	FiDtPgto =  @Fi_DtPgto, 	 filote =  @Fi_Lote,
	FiVlrPgto=  @Fi_VlrPgto,	 FiVlrAcre =  @Fi_VlrAcre, FiVlrDcto =  @Fi_VlrDcto,
	FiBcoCh  =  @Fi_BcoCh,	     FiAgCh  =   @Fi_AgCh,
	ficartao  = @Fi_Cartao,  	 FiCaixa =  @Fi_Caixa,
	finrocar =  @Fi_NroCar,	     FiFPagto =  @Fi_FPagto
	WHERE FiNSSNRO =  @Fi_NssNro;

	delete FROM caixamov Where MVOS =  @Fi_NssNro;
    
END