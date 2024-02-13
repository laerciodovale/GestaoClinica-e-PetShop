CREATE   PROCEDURE [Sp_FinA_DeletaItemDaLista] ( @Fa_Seq integer) as

BEGIN
 
	delete from CadFaCli WHERE FaSeq  =  @Fa_Seq;
  
END