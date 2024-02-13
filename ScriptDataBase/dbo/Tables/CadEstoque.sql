CREATE TABLE [dbo].[CadEstoque] (
    [ETITEM]        NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [ETCCUSTO]      SMALLINT      NOT NULL,
    [ETSETOR]       SMALLINT      NOT NULL,
    [ETDEPTO]       SMALLINT      NOT NULL,
    [ETDTREF]       DATE          NULL,
    [ETSOLIC]       INT           NOT NULL,
    [ETHRREF]       NVARCHAR (8)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ETOC]          INT           NOT NULL,
    [ETQTDE]        FLOAT (53)    NOT NULL,
    [ETVALOR]       MONEY         NOT NULL,
    [ETQTDS]        FLOAT (53)    NOT NULL,
    [ETVLRS]        MONEY         NOT NULL,
    [ETCLIENTE]     INT           NULL,
    [ETFORNEC]      INT           NOT NULL,
    [ETEMPRESA]     INT           NOT NULL,
    [ETVLRUENT]     MONEY         NULL,
    [ETLOTE]        NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [ETVLRUNISDCTO] MONEY         NULL,
    [ETSEQ]         INT           IDENTITY (1, 1) NOT NULL,
    [ETNLOTE]       NCHAR (20)    NULL,
    CONSTRAINT [PK_CadEstoque_1] PRIMARY KEY CLUSTERED ([ETSEQ] ASC)
);

