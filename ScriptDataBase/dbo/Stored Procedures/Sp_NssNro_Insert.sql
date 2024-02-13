
create  procedure [dbo].[Sp_NssNro_Insert]
(@id_Dt as Date	)

AS
BEGIN
	DECLARE @ID_NssNro Int 
    
	SET NOCOUNT ON
    
	INSERT INTO CadNssNro(idDt)	VALUES  (@id_Dt)
	
	set  @ID_NssNro = SCOPE_IDENTITY ()
	select  @ID_NssNro 
   
END