-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Lista_Finan_Sint_Analitic]
 
(	 @ID_Cli Int	) as
BEGIN
SELECT  DISTINCT  idanimal, aninome , fidtvcto, finssnro ,  
 fivlr , fivlrpgto , fidtpgto ,  faev, faDesc, favlru, FAQTD, favlr
 FROM cadfins, cadfacli, cadanimal
 WHERE ficli =  @ID_Cli 
 and fanssnro = finssnro 
 and facli  =  ficli 
 and faani = fiani 
 and idanimal = fiani
 order by 1, 3, 4  ;
      
END