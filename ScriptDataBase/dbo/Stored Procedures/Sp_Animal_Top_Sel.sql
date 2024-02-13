-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_Animal_Top_Sel]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
  Select  top 50 AniNome    Nome_do_Animal, IdAnimal    Id_Ani from CadAnimal 
	order by 2 desc 
    

END