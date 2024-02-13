CREATE TABLE [dbo].[Caixa] (
    [DATA]         DECIMAL (18) NOT NULL,
    [CAIXA]        CHAR (10)    COLLATE Latin1_General_CI_AS NOT NULL,
    [FECHADO]      NVARCHAR (1) COLLATE Latin1_General_CI_AS NULL,
    [ABERTURA]     FLOAT (53)   NULL,
    [FUNDO]        FLOAT (53)   NULL,
    [RECEITA]      FLOAT (53)   NULL,
    [SANGRIA]      FLOAT (53)   NULL,
    [SANGRIAch]    FLOAT (53)   NULL,
    [SALDOCx]      FLOAT (53)   NULL,
    [SALDODia]     FLOAT (53)   NULL,
    [DINHEIRO]     FLOAT (53)   NULL,
    [CHEQUE]       FLOAT (53)   NULL,
    [CHEQUE_PRE]   FLOAT (53)   NULL,
    [CARTAO]       FLOAT (53)   NULL,
    [cfDINHEIRO]   FLOAT (53)   NULL,
    [cfCHEQUE]     FLOAT (53)   NULL,
    [cfCHEQUE_PRE] FLOAT (53)   NULL,
    [cfCARTAO]     FLOAT (53)   NULL,
    [Emp]          REAL         NULL,
    [Custo]        REAL         NULL
);

