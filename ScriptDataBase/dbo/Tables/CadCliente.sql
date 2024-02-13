CREATE TABLE [dbo].[CadCliente] (
    [ClId]      INT            IDENTITY (1, 1) NOT NULL,
    [ClNome]    NVARCHAR (100) COLLATE SQL_Latin1_General_CP1253_CI_AI NULL,
    [ClContato] NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [ClEnd]     NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [ClNro]     NVARCHAR (8)   COLLATE Latin1_General_CI_AS NULL,
    [ClBairro]  NVARCHAR (50)  COLLATE Latin1_General_CI_AS NULL,
    [ClCidade]  NVARCHAR (50)  COLLATE Latin1_General_CI_AS NULL,
    [ClUf]      NVARCHAR (2)   COLLATE Latin1_General_CI_AS NULL,
    [ClCEP]     NVARCHAR (10)  COLLATE Latin1_General_CI_AS NULL,
    [ClCel]     NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [ClFixo]    NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [ClEmail]   NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [ClDtNas]   SMALLDATETIME  NULL,
    [ClRG]      NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [ClCpf]     NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [ClDtCad]   SMALLDATETIME  NULL,
    [ClCompl]   NVARCHAR (50)  NULL,
    [ClFoto]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CadCliente] PRIMARY KEY CLUSTERED ([ClId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadCliente]
    ON [dbo].[CadCliente]([ClNome] ASC);

