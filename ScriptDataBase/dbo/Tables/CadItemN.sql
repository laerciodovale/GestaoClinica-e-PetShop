CREATE TABLE [dbo].[CadItemN] (
    [ItId]       INT           NOT NULL,
    [ItDesc]     NVARCHAR (50) COLLATE Latin1_General_CI_AS NULL,
    [ItCB]       NVARCHAR (13) COLLATE Latin1_General_CI_AS NULL,
    [ItUnd]      NVARCHAR (3)  COLLATE Latin1_General_CI_AS NULL,
    [ItTp]       NVARCHAR (2)  COLLATE Latin1_General_CI_AS NULL,
    [ItGrupo]    INT           NULL,
    [ItCusto]    MONEY         NULL,
    [ItVenda]    MONEY         NULL,
    [ItComissao] MONEY         NULL
);

