-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_ConfigEmail_Sel]
	-- Add the parameters for the stored procedure here
	(@ID_Em Int)
AS
BEGIN
	
	select * from CadConfigEmail where Emid = @Id_Em 

END