

CREATE procedure [dbo].[Sp_USER_Up](
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
    
	UPDATE CADUSER SET USSENHA =@USSENHA, USNOME  = @USNOME, USAUT  =@USAUT, USATIV = @USATIV,
    USEMAIL  = @USEMAIL, USCODFOL  = @USCODFOL, USCCUSTO   = @USCCUSTO, USNIVEL  = @USNIVEL, USid = @USID
	WHERE USUARIO	=@USUARIO

END