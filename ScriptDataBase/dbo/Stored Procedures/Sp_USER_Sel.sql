

CREATE procedure [dbo].[Sp_USER_Sel](
	 @USUARIO   nvarchar (20), 	
	 @UsSenha   nvarchar (20)  ) 
AS
BEGIN

	SET NOCOUNT ON
    
	select *  from CADUSER 
	WHERE USUARIO	= @USUARIO and ussenha = @ussenha and USATIV = 'S'

END