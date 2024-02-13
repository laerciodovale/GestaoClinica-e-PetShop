-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Convenio_Sel]
as
BEGIN
 
	  

	SELECT  CvCod, CvDesc from CadConv where CvCod > 0 order by CvDesc
      
END