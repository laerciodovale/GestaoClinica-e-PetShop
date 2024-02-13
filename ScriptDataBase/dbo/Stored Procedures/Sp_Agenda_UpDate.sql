CREATE   PROCEDURE  [dbo].[Sp_Agenda_UpDate]  ( @ag_Id  INT,  @ag_Data  DATE,  @ag_Hora  CHAR(5),  @ag_Cliente  VARCHAR(50),  
@ag_Contato  CHAR(20),  @ag_Email  VARCHAR(50),  @ag_Tipo  VARCHAR(50),  @ag_Obs  VARCHAR(50),  @ag_Funcionario  VARCHAR(50),
@ag_St  CHAR(10))   AS BEGIN
	update CadAgClinica set agData =  @ag_Data,
	 agHora =  @ag_Hora,
	 agCliente =  @ag_Cliente,
	  agContato =  @ag_Contato, 
	  agEmail =  @ag_Email, 
	  AgTipo =  @ag_Tipo, 
	  agObs =  @ag_Obs,
	  agFuncionario =  @ag_Funcionario,
	  agSt =  @ag_St 
    where   aDID =  @ag_Id;
	
   
END