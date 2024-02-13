create procedure [dbo].[Sp_NssNro_Max] 
( @id_NssNro	int)
AS
BEGIN
 	SET NOCOUNT ON
	select max(IdNss) as IdNss from CadNssNro 
END