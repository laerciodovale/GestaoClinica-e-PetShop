CREATE TABLE [dbo].[CadFuncxx] (
    [FuId]     INT            NOT NULL,
    [FuNome]   NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [FuRg]     NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuCpf]    NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuFuncao] INT            NULL,
    [FuRgProf] NCHAR (20)     NULL,
    [FuEnd]    NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [FuNro]    NCHAR (60)     NULL,
    [FuCompl]  NVARCHAR (30)  NULL,
    [FuBairro] NVARCHAR (30)  COLLATE Latin1_General_CI_AS NULL,
    [FuCidade] NVARCHAR (50)  NULL,
    [FuUf]     NCHAR (2)      NULL,
    [FuCel]    NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuFixo]   NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuAtivo]  BIT            NULL,
    [FuFoto]   NVARCHAR (MAX) COLLATE Latin1_General_CI_AS NULL,
    [FuCep]    NCHAR (10)     NULL,
    [FuEmail]  NVARCHAR (100) NULL
);

