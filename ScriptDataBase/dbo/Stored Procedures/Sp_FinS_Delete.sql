CREATE   PROCEDURE [Sp_FinS_Delete] (  
 @Fi_NssNro int ) as
BEGIN
 
	delete from CadFinS where 	FiNssNro = 	 @Fi_NssNro  ;
delete from CadFaCli where 	FaNssNro = 	 @Fi_NssNro  ;

END