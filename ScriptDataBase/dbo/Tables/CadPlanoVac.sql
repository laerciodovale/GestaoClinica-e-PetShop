CREATE TABLE [dbo].[CadPlanoVac] (
    [PlVCli]    INT           NOT NULL,
    [PlVItem]   NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [PlVDtPrev] DATETIME      NOT NULL,
    [PlVQtd]    INT           NULL,
    [PlVAplic]  INT           NULL,
    [PlvOS]     INT           NULL
);

