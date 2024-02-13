CREATE TABLE [dbo].[CadDC_Cli] (
    [DcCli]      INT           NOT NULL,
    [DcNome]     NVARCHAR (50) NULL,
    [DcVlrCred]  MONEY         NULL,
    [DcVlrDeb]   MONEY         NULL,
    [DcVlrTotal] MONEY         NULL,
    CONSTRAINT [PK_CadDC_Cli] PRIMARY KEY CLUSTERED ([DcCli] ASC)
);

