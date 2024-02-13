CREATE TABLE [dbo].[CadExame] (
    [ExId]    INT           NOT NULL,
    [ExGrupo] INT           NULL,
    [ExDesc]  NVARCHAR (40) COLLATE Latin1_General_CI_AS NULL,
    [ExAtivo] BIT           NOT NULL
);

