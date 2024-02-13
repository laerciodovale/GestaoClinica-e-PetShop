-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Itens_DoGrupo]
( @Grupo    INTEGER )
  
 as
BEGIN

	  
    
	Select distinct  ITDESC, ITITEM  from CadItemMYSql where ITGRUPO =  @Grupo
  
	  
    
END