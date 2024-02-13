-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Animal_Raca]
as
BEGIN
 

	SELECT  distinct AniRaca from CadAnimal  order by AniRaca
      
END