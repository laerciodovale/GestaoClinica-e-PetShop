CREATE TABLE [dbo].[CadFuncOld] (
    [FuId]     INT            NOT NULL,
    [FuNome]   NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [FuRg]     NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuCpf]    NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuFunc]   INT            NULL,
    [FuEnd]    NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [FuBairro] NVARCHAR (30)  COLLATE Latin1_General_CI_AS NULL,
    [FuCel]    NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuFixo]   NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL,
    [FuIdProf] NVARCHAR (20)  COLLATE Latin1_General_CI_AS NULL
);

