CREATE TABLE [dbo].[CaixaMovAnt] (
    [MVSEQ]    INT            NOT NULL,
    [MVData]   DATETIME       NOT NULL,
    [MVCaixa]  CHAR (10)      COLLATE Latin1_General_CI_AS NOT NULL,
    [MVE]      MONEY          NULL,
    [MVS]      MONEY          NULL,
    [MVSLDANT] MONEY          NULL,
    [MVSLDATU] MONEY          NULL,
    [MVCusto]  REAL           NULL,
    [MVDesc]   NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [MVOS]     DECIMAL (18)   NULL
);

