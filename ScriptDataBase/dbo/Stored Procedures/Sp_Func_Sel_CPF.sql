CREATE  PROCEDURE [Sp_Func_Sel_CPF](@Fu_Cpf varchar (20)) as
BEGIN
 	Select *  from cadfunc where FuCPF = @Fu_Cpf;
END