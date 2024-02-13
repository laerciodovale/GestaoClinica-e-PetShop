CREATE TABLE [dbo].[CadVacina] (
    [VcId]      INT           IDENTITY (1, 1) NOT NULL,
    [VcAni]     INT           NULL,
    [VcTp]      CHAR (11)     NULL,
    [VcDt]      SMALLDATETIME NULL,
    [VcDose]    INT           NULL,
    [VcData]    SMALLDATETIME NULL,
    [VcItem]    NVARCHAR (20) COLLATE Latin1_General_CI_AS NULL,
    [VcMes]     INT           NULL,
    [VcContato] BIT           NULL,
    CONSTRAINT [PK_CadVacina] PRIMARY KEY CLUSTERED ([VcId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadVacina]
    ON [dbo].[CadVacina]([VcAni] ASC, [VcData] ASC);

