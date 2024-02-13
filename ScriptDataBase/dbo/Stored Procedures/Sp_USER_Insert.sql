

CREATE procedure [dbo].[Sp_USER_Insert](
	 @USUARIO   nvarchar (20) ,
	 @USSENHA   nvarchar (20) ,
	 @USNOME   nvarchar (80) ,
	 @USAUT   nvarchar (2) ,
	 @USATIV   nvarchar (1) ,
	 @USEMAIL   nvarchar (80) ,
	 @USCODFOL   int  ,
	 @USCCUSTO   smallint  ,
	 @USNIVEL   nvarchar (4) ,
	 @USID   nchar (10) ) 
AS
BEGIN

	SET NOCOUNT ON
    
	INSERT INTO CADUSER (USUARIO	 , USSENHA       , USNOME      , USAUT       , USATIV 
      , USEMAIL       , USCODFOL       , USCCUSTO       , USNIVEL, USID  )
	values (	 @USUARIO    ,	 @USSENHA    ,	 @USNOME   ,	 @USAUT    ,
	 @USATIV    ,	 @USEMAIL   ,	 @USCODFOL     ,	 @USCCUSTO     ,	 @USNIVEL, @USID   )

END