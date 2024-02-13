CREATE TABLE [dbo].[EXTRATO_conv] (
    [DataVenda]    SMALLDATETIME  NULL,
    [Cliente]      FLOAT (53)     NULL,
    [Vendas]       FLOAT (53)     NULL,
    [Produto]      NVARCHAR (255) NULL,
    [Parcela]      FLOAT (53)     NULL,
    [Plano]        FLOAT (53)     NULL,
    [Comprovantes] FLOAT (53)     NULL,
    [ValoBruto]    FLOAT (53)     NULL,
    [VlrDcto]      FLOAT (53)     NULL,
    [VlrPgto]      FLOAT (53)     NULL,
    [DtCredito]    SMALLDATETIME  NULL,
    [ID]           NUMERIC (18)   IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_EXTRATO_conv] PRIMARY KEY CLUSTERED ([ID] ASC)
);

