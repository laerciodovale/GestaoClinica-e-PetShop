CREATE TABLE [dbo].[CadReceita] (
    [RcId]          INT           IDENTITY (1, 1) NOT NULL,
    [RcCli]         INT           NOT NULL,
    [RcAni]         INT           NOT NULL,
    [RcDt]          DATETIME      NOT NULL,
    [RcNss]         INT           NOT NULL,
    [RcFarmaco]     NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [RcMeio]        NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [RcQtd]         NTEXT         COLLATE Latin1_General_CI_AS NOT NULL,
    [RcVia]         DECIMAL (18)  NOT NULL,
    [RcFreq]        DECIMAL (18)  NOT NULL,
    [RcDias]        DECIMAL (18)  NOT NULL,
    [RcReco]        NTEXT         COLLATE Latin1_General_CI_AS NOT NULL,
    [RcEsp]         BIT           NOT NULL,
    [RcDescFarmaco] NVARCHAR (50) COLLATE Latin1_General_CI_AS NOT NULL,
    CONSTRAINT [PK_CadReceita] PRIMARY KEY CLUSTERED ([RcId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadReceita_1]
    ON [dbo].[CadReceita]([RcCli] ASC, [RcAni] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadReceita]
    ON [dbo].[CadReceita]([RcAni] ASC);

