CREATE   PROCEDURE [Sp_FinS_Estorno] (  
 @Fi_NssNro int ) as
BEGIN
 
	update CadFinS set fidtpgto = '1900-01-01', filote = 0, fivlrad =0, fivlrdev =0,
    fivlrpgto =0, fivlrdcto =0, fivlracre =0, fifpagto = ''    
    where 	FiNssNro = 	 @Fi_NssNro  ;

END