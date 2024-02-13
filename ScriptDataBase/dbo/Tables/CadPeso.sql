CREATE TABLE [dbo].[CadPeso] (
    [psAni]   INT             NOT NULL,
    [psData]  DATE            NOT NULL,
    [psValor] NUMERIC (10, 3) NULL,
    CONSTRAINT [PK_CadPeso] PRIMARY KEY CLUSTERED ([psAni] ASC, [psData] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadPeso]
    ON [dbo].[CadPeso]([psAni] ASC);

