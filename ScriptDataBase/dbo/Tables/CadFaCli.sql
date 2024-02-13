CREATE TABLE [dbo].[CadFaCli] (
    [FaCli]    INT             NOT NULL,
    [FaAni]    INT             NOT NULL,
    [FaNssNro] INT             NOT NULL,
    [FaEv]     NVARCHAR (20)   COLLATE Latin1_General_CI_AS NOT NULL,
    [FaDesc]   NVARCHAR (50)   COLLATE Latin1_General_CI_AS NOT NULL,
    [FaQtd]    DECIMAL (18, 2) NOT NULL,
    [FaVlrU]   MONEY           NOT NULL,
    [FaDcto]   MONEY           NOT NULL,
    [FaVlr]    MONEY           NOT NULL,
    [FaFunc]   INT             NULL,
    [FaDt]     SMALLDATETIME   NULL,
    [FaVlrAd]  MONEY           NULL,
    [FaSeq]    INT             IDENTITY (1, 1) NOT NULL,
    [FaNssPai] INT             NULL,
    CONSTRAINT [PK_CadFaCli] PRIMARY KEY CLUSTERED ([FaSeq] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadFaCli_2]
    ON [dbo].[CadFaCli]([FaCli] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadFaCli_1]
    ON [dbo].[CadFaCli]([FaCli] ASC, [FaNssNro] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CadFaCli]
    ON [dbo].[CadFaCli]([FaNssNro] ASC);

