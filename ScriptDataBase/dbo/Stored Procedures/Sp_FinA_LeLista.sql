-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_FinA_LeLista]

 ( @Fa_Cli integer,
 @Fa_Ani integer ) as
BEGIN
 	select facli, faani, fadesc, FaQtd, FaVlrU, FaDcto, FaVlr, faev, faseq from  CadFaCli
	WHERE FaCli  =  @Fa_Cli and FaAni =  @Fa_Ani and FaNssNro = 0
	  
    
END