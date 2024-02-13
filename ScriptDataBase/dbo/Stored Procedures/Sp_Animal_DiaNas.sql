-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Animal_DiaNas]( 
@An_Dia  int,
@An_Mes  int )as
BEGIN

	select IdAnimal, AniNome, ClNome, ClEmail, ClCel, AniEspécie , anisexo  from  CadCliente , cadAnimal
WHERE  MONTH(anidtnas) = @An_Mes  and day(anidtnas) = @An_Dia and anicliente = clid;
    
END