CREATE TABLE [dbo].[CadItem] (
    [MSGRUPO]     SMALLINT      NOT NULL,
    [MSSUBGRP]    SMALLINT      NOT NULL,
    [MSMAT]       NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [MSMIN]       FLOAT (53)    NULL,
    [MSTIPO]      NVARCHAR (1)  COLLATE SQL_Latin1_General_CP1253_CI_AI NULL,
    [MSDESC]      NVARCHAR (50) COLLATE SQL_Latin1_General_CP1253_CI_AI NULL,
    [MSUNID]      NVARCHAR (30) COLLATE Latin1_General_CI_AS NULL,
    [MSPAT]       NVARCHAR (1)  COLLATE Latin1_General_CI_AS NULL,
    [MSUSOC]      NVARCHAR (1)  COLLATE Latin1_General_CI_AS NULL,
    [MSREST]      NVARCHAR (1)  COLLATE Latin1_General_CI_AS NULL,
    [MSQEST]      FLOAT (53)    NULL,
    [MSABC]       NVARCHAR (1)  COLLATE Latin1_General_CI_AS NULL,
    [MSPRR]       MONEY         NULL,
    [MSPRDL]      MONEY         NULL,
    [MSTPIMP]     NVARCHAR (3)  COLLATE Latin1_General_CI_AS NULL,
    [MSQTD]       FLOAT (53)    NULL,
    [MSPROMO]     NVARCHAR (1)  COLLATE Latin1_General_CI_AS NULL,
    [MSREFFAB]    NVARCHAR (20) COLLATE Latin1_General_CI_AS NULL,
    [MSREFLOJA]   NVARCHAR (20) COLLATE Latin1_General_CI_AS NULL,
    [MSCOR]       CHAR (20)     COLLATE Latin1_General_CI_AS NULL,
    [MSTAMANHO]   CHAR (6)      COLLATE Latin1_General_CI_AS NULL,
    [MSCOMISSAO]  MONEY         NULL,
    [MSREPASSE]   MONEY         NULL,
    [MSCONVENIO]  DECIMAL (18)  NULL,
    [MSCOMPRA]    MONEY         NULL,
    [MSLUCRO]     MONEY         NULL,
    [MSVENDA]     MONEY         NULL,
    [MSINDICACAO] NTEXT         COLLATE Latin1_General_CI_AS NULL,
    [IDMS]        DECIMAL (18)  IDENTITY (1, 1) NOT NULL,
    [MSSALDO]     NUMERIC (18)  NULL,
    [MSCB]        NVARCHAR (13) NULL,
    [MSPCTCOMPL]  INT           NULL,
    CONSTRAINT [PK_CadItem] PRIMARY KEY CLUSTERED ([MSMAT] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadItem_3]
    ON [dbo].[CadItem]([MSPAT] ASC, [MSDESC] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadItem_2]
    ON [dbo].[CadItem]([MSTIPO] ASC, [MSDESC] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadItem_1]
    ON [dbo].[CadItem]([MSDESC] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadItem]
    ON [dbo].[CadItem]([MSPAT] ASC);

