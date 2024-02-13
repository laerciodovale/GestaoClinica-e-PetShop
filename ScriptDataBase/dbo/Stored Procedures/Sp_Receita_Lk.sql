create procedure [dbo].[Sp_Receita_Lk] 
(@NomeLike nvarchar(40) )

AS
BEGIN
 
	SET NOCOUNT ON

	SELECT DISTINCT RcDescFarmaco FROM CadReceita WHERE RcDescFarmaco  
	  like  '%' + @NomeLike + '%' 

   
END