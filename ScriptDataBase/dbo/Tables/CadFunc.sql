CREATE TABLE [dbo].[CadFunc] (
    [FuId]     INT            IDENTITY (1, 1) NOT NULL,
    [FuNome]   NVARCHAR (100) NULL,
    [FuRg]     NVARCHAR (20)  NULL,
    [FuCpf]    NVARCHAR (20)  NULL,
    [FuFuncao] INT            NULL,
    [FuRgProf] NVARCHAR (20)  NULL,
    [FuEnd]    NVARCHAR (100) NULL,
    [FuNro]    NCHAR (6)      NULL,
    [FuCompl]  NVARCHAR (30)  NULL,
    [FuBairro] NVARCHAR (30)  NULL,
    [FuCidade] NVARCHAR (45)  NULL,
    [FuUf]     NCHAR (2)      NULL,
    [FuCel]    NVARCHAR (20)  NULL,
    [FuFixo]   NVARCHAR (20)  NULL,
    [FuAtivo]  BIT            NULL,
    [FuFoto]   NVARCHAR (MAX) NULL,
    [FuCep]    NCHAR (10)     NULL,
    [FuEmail]  NVARCHAR (100) NULL,
    CONSTRAINT [PK_CadFunc] PRIMARY KEY CLUSTERED ([FuId] ASC)
);

