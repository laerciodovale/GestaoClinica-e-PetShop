

CREATE procedure [dbo].[Sp_USER_Del](
	 @USUARIO   nvarchar (20) 	  ) 
AS
BEGIN

	SET NOCOUNT ON
    
	delete from CADUSER 
	WHERE USUARIO	=@USUARIO

END