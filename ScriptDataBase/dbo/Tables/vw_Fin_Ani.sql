CREATE TABLE [dbo].[vw_Fin_Ani] (
    [IdAnimal]   INT           NOT NULL,
    [AniNome]    NVARCHAR (80) COLLATE Latin1_General_CI_AS NULL,
    [AniCliente] INT           NULL,
    [FiCli]      INT           NOT NULL,
    [FiAni]      INT           NOT NULL,
    [FiDtVcto]   SMALLDATETIME NOT NULL,
    [FiVlr]      MONEY         NOT NULL,
    [FiVlrPgto]  MONEY         NOT NULL,
    [FiDtPgto]   SMALLDATETIME NOT NULL,
    [FiNssNro]   INT           NOT NULL,
    [FiDtLan]    DATETIME      NOT NULL,
    [FaNssPai]   INT           NULL
);

