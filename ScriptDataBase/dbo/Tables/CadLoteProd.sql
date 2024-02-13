CREATE TABLE [dbo].[CadLoteProd] (
    [LTITEM]     CHAR (20) NOT NULL,
    [LTLOTE]     CHAR (20) NOT NULL,
    [LTFOR]      INT       NOT NULL,
    [LTNF]       INT       NOT NULL,
    [LTDTCOMPRA] INT       NOT NULL,
    [LTQTD]      INT       NOT NULL,
    [LTVCTO]     DATETIME  NULL,
    CONSTRAINT [PK_CadLoteProd] PRIMARY KEY CLUSTERED ([LTITEM] ASC, [LTLOTE] ASC, [LTFOR] ASC, [LTNF] ASC)
);

