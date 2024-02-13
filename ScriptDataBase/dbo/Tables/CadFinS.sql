CREATE TABLE [dbo].[CadFinS] (
    [FiNssNro]   INT            NOT NULL,
    [FiCli]      INT            NOT NULL,
    [FiAni]      INT            NOT NULL,
    [FiAnoMes]   INT            NOT NULL,
    [FiDtVcto]   SMALLDATETIME  NOT NULL,
    [FiDtPgto]   SMALLDATETIME  NOT NULL,
    [FiLote]     REAL           NOT NULL,
    [FiVlrAd]    MONEY          NOT NULL,
    [FiVlrDev]   MONEY          NOT NULL,
    [FiVlr]      MONEY          NOT NULL,
    [FiVlrPgto]  MONEY          NOT NULL,
    [FiVlrDcto]  MONEY          NOT NULL,
    [FiVlrAcre]  MONEY          NOT NULL,
    [FiCodBar]   NVARCHAR (100) COLLATE Latin1_General_CI_AS NOT NULL,
    [FiLinDig]   NVARCHAR (80)  COLLATE Latin1_General_CI_AS NOT NULL,
    [FiEmi]      REAL           NOT NULL,
    [FiDtLan]    DATETIME       NOT NULL,
    [FiEmp]      REAL           NOT NULL,
    [FiCusto]    REAL           NOT NULL,
    [FiBcoCh]    NVARCHAR (5)   COLLATE Latin1_General_CI_AS NOT NULL,
    [FiAgCh]     NVARCHAR (6)   COLLATE Latin1_General_CI_AS NOT NULL,
    [FiCta]      NVARCHAR (10)  COLLATE Latin1_General_CI_AS NOT NULL,
    [FiNroCh]    NVARCHAR (15)  COLLATE Latin1_General_CI_AS NOT NULL,
    [FiEmitente] NVARCHAR (50)  COLLATE Latin1_General_CI_AS NOT NULL,
    [FiChPre]    INT            NOT NULL,
    [FiCartao]   NVARCHAR (50)  COLLATE Latin1_General_CI_AS NOT NULL,
    [FiCaixa]    NVARCHAR (10)  COLLATE Latin1_General_CI_AS NOT NULL,
    [FiDevCh]    NVARCHAR (2)   COLLATE Latin1_General_CI_AS NOT NULL,
    [FiObs]      NVARCHAR (150) COLLATE Latin1_General_CI_AS NOT NULL,
    [FiNroCar]   INT            NOT NULL,
    [FiDtVCtr]   INT            NOT NULL,
    [FILancImp]  INT            NOT NULL,
    [FiChAnt]    CHAR (30)      COLLATE Latin1_General_CI_AS NOT NULL,
    [FiConv]     INT            NULL,
    [FiConvReq]  INT            NULL,
    [FiNF]       INT            NULL,
    [FiOrdem]    INT            NULL,
    [FiEv]       INT            NULL,
    [FiFat]      INT            NULL,
    [FiVlrImp]   MONEY          NULL,
    [FiFPagto]   NVARCHAR (50)  NULL,
    CONSTRAINT [PK_CadFinS] PRIMARY KEY CLUSTERED ([FiNssNro] ASC),
    CONSTRAINT [IX_CadFinS_2] UNIQUE NONCLUSTERED ([FiCli] ASC, [FiNssNro] ASC, [FiAni] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadFinS_3]
    ON [dbo].[CadFinS]([FiCli] ASC, [FiDtVcto] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadFinS_1]
    ON [dbo].[CadFinS]([FiDtVcto] ASC, [FiVlrPgto] ASC, [FiLote] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadFinS]
    ON [dbo].[CadFinS]([FiLote] ASC, [FiDtVcto] ASC);

