CREATE TABLE [dbo].[CadLoteNtfe] (
    [CtlLoteRem] NUMERIC (18)  NOT NULL,
    [CtrLinha1]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_CadLoteNtfe] PRIMARY KEY CLUSTERED ([CtlLoteRem] ASC)
);

