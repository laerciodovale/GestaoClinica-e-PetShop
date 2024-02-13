

CREATE procedure [dbo].[Sp_Agenda_Tp]
AS
BEGIN

	SET NOCOUNT ON
    
	select agTp, agDesc   from CadAgTipo Order by agDesc
	

END