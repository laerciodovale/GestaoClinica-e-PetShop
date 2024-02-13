CREATE TABLE [dbo].[TabExtrato] (
    [EXITEM]    INT           NOT NULL,
    [EXDATA]    NVARCHAR (10) COLLATE Latin1_General_CI_AS NOT NULL,
    [EXDOC]     INT           NOT NULL,
    [EXOC]      INT           NOT NULL,
    [EXQTDE]    FLOAT (53)    NULL,
    [EXQTDS]    FLOAT (53)    NULL,
    [EXSALDO]   FLOAT (53)    NULL,
    [EXVALOR]   MONEY         NULL,
    [EXRAZAO]   NVARCHAR (50) COLLATE Latin1_General_CI_AS NULL,
    [EXDESCMAT] NVARCHAR (50) COLLATE Latin1_General_CI_AS NULL,
    [exmat]     NVARCHAR (50) COLLATE Latin1_General_CI_AS NULL
);

