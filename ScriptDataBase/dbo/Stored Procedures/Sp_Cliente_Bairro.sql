-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Cliente_Bairro]
 as
BEGIN
 
	  

	SELECT  DISTINCT  ClBairro from cadcliente   order by ClBairro 
      
END