CREATE TABLE [dbo].[CadConfigemail] (
    [EmId]        INT            IDENTITY (1, 1) NOT NULL,
    [EmDisplay]   NVARCHAR (30)  NULL,
    [EmEnvio]     NVARCHAR (60)  NULL,
    [EmSenha]     NVARCHAR (30)  NULL,
    [EmSMTP]      NVARCHAR (30)  NULL,
    [EmPorta]     NVARCHAR (10)  NULL,
    [EmMsg]       NVARCHAR (MAX) NULL,
    [EmMsgAninal] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CadConfigemail] PRIMARY KEY CLUSTERED ([EmId] ASC)
);

