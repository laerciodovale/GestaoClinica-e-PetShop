-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_LoteNFSe_Insert]

 ( @NtfSe_Data datetime ,
@NtfSe_Desc varchar(45) ) as
BEGIN
 
	DECLARE  @ID_Lote Int 
    	     
	INSERT INTO CadLoteNTFSe (  NtfSeData , NtfSeDesc	)
    VALUES  (   @NtfSe_Data , @NtfSe_Desc );
	
    
	set   @ID_Lote = SCOPE_IDENTITY ();
	select   @ID_Lote ;
   
END