CREATE TABLE [dbo].[CadPadrao] (
    [RcId]      INT            IDENTITY (1, 1) NOT NULL,
    [RcFarmaco] NVARCHAR (20)  NULL,
    [RcDesc]    NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    CONSTRAINT [PK_CadPadrao] PRIMARY KEY CLUSTERED ([RcId] ASC)
);

