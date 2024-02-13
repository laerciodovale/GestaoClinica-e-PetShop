 CREATE  PROCEDURE [Sp_Func_Up_Foto]( @fu_id Int ,
	 @fu_Foto   nvarchar(max)	) as
BEGIN
 	  	UPDATE CadFunc SET  fufoto =  @Fu_Foto 	WHERE fuid =  @fu_id;
END