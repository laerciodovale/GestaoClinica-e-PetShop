CREATE procedure [dbo].[SP_Estoque_Insert]  (  
@ET_ITEM AS varchar(20) , @ET_DTREF AS date ,
@ET_HRREF AS varchar(8) ,@ET_SOLIC AS int ,
@ET_OC AS int , @ET_QTDE AS FLOAT,
@ET_VALOR AS decimal(12,2) , @ET_QTDS AS FLOAT ,
@ET_VLRS AS decimal(12,2) , @ET_CLIENTE AS int ,
@ET_FORNEC AS int ,@ET_EMPRESA AS int ,
@ET_NLOTE AS varchar(20)  )
AS

BEGIN
DECLARE  @ID Int 
	INSERT  INTO cadestoque
	(ETITEM ,  ETDTREF , ETHRREF , ETSOLIC ,ETOC , 
ETQTDE , ETVALOR ,ETQTDS , ETVLRS , ETCLIENTE ,ETFORNEC, ETEMPRESA , ETNLOTE  ) 
	VALUES
	(@ET_ITEM ,  @ET_DTREF , @ET_HRREF , @ET_SOLIC ,@ET_OC , 
@ET_QTDE , @ET_VALOR , @ET_QTDS , @ET_VLRS , @ET_CLIENTE , @ET_FORNEC, @ET_EMPRESA , @ET_NLOTE) ;
       
 
 set   @ID = SCOPE_IDENTITY ();
	select   @ID;
	
	end