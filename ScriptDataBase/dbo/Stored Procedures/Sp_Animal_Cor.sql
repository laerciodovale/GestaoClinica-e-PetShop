-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Animal_Cor]
as
BEGIN
 
	  

	SELECT  distinct AniCor from CadAnimal  order by AniCor
      
END