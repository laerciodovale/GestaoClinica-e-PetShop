-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Grupo_Sel]
 as
BEGIN
  
	  
    
	Select distinct  GRDESC, GRGRUPO from CADGRUPO order by grdesc    
END