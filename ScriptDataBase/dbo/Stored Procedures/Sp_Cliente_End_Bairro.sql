-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Cliente_End_Bairro]
(@Pr_Bairro nvarchar(20) )

 as
BEGIN
 
	SELECT  DISTINCT  ClEnd from cadcliente where ClBairro = @Pr_Bairro  order by CLEND 
      
END