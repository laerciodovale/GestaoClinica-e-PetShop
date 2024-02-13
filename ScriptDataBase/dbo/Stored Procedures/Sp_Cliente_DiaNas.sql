-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Cliente_DiaNas]
	-- Add the parameters for the stored procedure here
	( @Cl_Dia  int,
@Cl_Mes  int )
AS
BEGIN


	select ClId, ClNome, ClEmail, ClCel   from  CadCliente 
WHERE  MONTH(cldtnas) = @Cl_Mes  and day(cldtnas) = @Cl_Dia
    
    
END