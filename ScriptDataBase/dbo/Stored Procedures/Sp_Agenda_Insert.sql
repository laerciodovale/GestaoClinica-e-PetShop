CREATE   PROCEDURE  [dbo].[Sp_Agenda_Insert]  ( @ag_Data  DATE,  @ag_Hora  CHAR(5),  @ag_Cliente  VARCHAR(50),  @ag_Contato  CHAR(20),
 @ag_Email  VARCHAR(50),  @ag_Tipo  VARCHAR(50),  @ag_Obs  VARCHAR(50),  @ag_Funcionario  VARCHAR(50),  @ag_St  CHAR(10))   AS BEGIN
	
	DECLARE  @ID_cliente Int 

  	INSERT INTO CadAgClinica ( agData, agHora, agCliente, agContato, agEmail, AgTipo, 
    agObs,agFuncionario, agSt )	
    VALUES  ( @ag_Data, @ag_Hora, @ag_Cliente, @ag_Contato, @ag_Email, @ag_Tipo, @ag_Obs,
    @ag_Funcionario, @ag_St );
	
	
	set   @ID_cliente = SCOPE_IDENTITY ();
	select   @ID_cliente ;
	
END