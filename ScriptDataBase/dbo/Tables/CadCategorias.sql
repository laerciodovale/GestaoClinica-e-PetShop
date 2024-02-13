CREATE TABLE [dbo].[CadCategorias] (
    [ctID]        INT            NOT NULL,
    [ctcatid]     NVARCHAR (5)   COLLATE Latin1_General_CI_AS NULL,
    [ctclassif]   NVARCHAR (10)  COLLATE Latin1_General_CI_AS NULL,
    [ctdescricao] NVARCHAR (150) COLLATE Latin1_General_CI_AS NULL,
    [ctdesc_res]  NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [ctrefer]     NVARCHAR (10)  COLLATE Latin1_General_CI_AS NULL,
    [ctexcluidos] NVARCHAR (10)  COLLATE Latin1_General_CI_AS NULL
);

