CREATE TABLE [dbo].[CadConsulta] (
    [ConsId]       INT           IDENTITY (1, 1) NOT NULL,
    [ConsAnimal]   INT           NULL,
    [ConsData]     SMALLDATETIME NOT NULL,
    [ConsHora]     SMALLDATETIME NULL,
    [ConsTipo]     NVARCHAR (8)  COLLATE Latin1_General_CI_AS NULL,
    [ConsAnamnese] NTEXT         COLLATE Latin1_General_CI_AS NULL,
    [ConsT]        NVARCHAR (10) COLLATE Latin1_General_CI_AS NULL,
    [ConsPeso]     MONEY         NULL,
    [ConsRPM]      INT           NULL,
    [ConsBPM]      INT           NULL,
    [ConsPA]       NVARCHAR (10) COLLATE Latin1_General_CI_AS NULL,
    [ConsHistsic]  NTEXT         COLLATE Latin1_General_CI_AS NULL,
    [ConsProg]     NTEXT         COLLATE Latin1_General_CI_AS NULL,
    [ConsDiag]     NTEXT         COLLATE Latin1_General_CI_AS NULL,
    [ConsDtRet]    SMALLDATETIME NULL,
    CONSTRAINT [PK_CadConsulta] PRIMARY KEY CLUSTERED ([ConsId] ASC),
    CONSTRAINT [IX_CadConsulta] UNIQUE NONCLUSTERED ([ConsId] ASC),
    CONSTRAINT [IX_CadConsulta_1] UNIQUE NONCLUSTERED ([ConsAnimal] ASC, [ConsId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadConsulta_2]
    ON [dbo].[CadConsulta]([ConsId] ASC);

