CREATE TABLE [dbo].[CadAprFicha] (
    [ApfId]      INT            NOT NULL,
    [ApfCli]     INT            NOT NULL,
    [ApfAni]     INT            NOT NULL,
    [ApfDt]      DATETIME       NOT NULL,
    [ApfFarmaco] NVARCHAR (20)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ApfDosagem] NVARCHAR (15)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ApfVia]     NVARCHAR (15)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ApfFreq]    NVARCHAR (15)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ApfDI]      NVARCHAR (50)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ApfDF]      NVARCHAR (50)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ApfEv]      VARCHAR (8000) COLLATE Latin1_General_CI_AS NULL
);

