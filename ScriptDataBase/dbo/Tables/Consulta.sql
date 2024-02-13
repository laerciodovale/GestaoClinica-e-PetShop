CREATE TABLE [dbo].[Consulta] (
    [EmId]        INT           NOT NULL,
    [EmDisplay]   NVARCHAR (30) NULL,
    [EmEnvio]     NVARCHAR (60) NULL,
    [EmSenha]     NVARCHAR (30) NULL,
    [EmSMTP]      NVARCHAR (30) NULL,
    [EmPorta]     NVARCHAR (10) NULL,
    [EmMsg]       XML           NULL,
    [EmMsgAnimal] XML           NULL
);

