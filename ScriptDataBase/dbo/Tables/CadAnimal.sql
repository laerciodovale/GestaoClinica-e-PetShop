CREATE TABLE [dbo].[CadAnimal] (
    [IdAnimal]     INT            IDENTITY (1, 1) NOT NULL,
    [AniNome]      NVARCHAR (80)  COLLATE Latin1_General_CI_AS NULL,
    [AniCliente]   INT            NULL,
    [AniEspécie]   INT            NULL,
    [AniRaca]      NVARCHAR (50)  COLLATE Latin1_General_CI_AS NULL,
    [AniPorte]     NVARCHAR (15)  COLLATE Latin1_General_CI_AS NULL,
    [AniCor]       NVARCHAR (50)  COLLATE Latin1_General_CI_AS NULL,
    [AniPelo]      NVARCHAR (15)  COLLATE Latin1_General_CI_AS NULL,
    [AniSexo]      NVARCHAR (1)   COLLATE Latin1_General_CI_AS NULL,
    [AniDtNas]     SMALLDATETIME  NULL,
    [AniAlergias]  INT            NULL,
    [AniRegistro]  BIT            NOT NULL,
    [AniRepro]     BIT            NOT NULL,
    [AniVivo]      BIT            NOT NULL,
    [AniAgressico] BIT            NOT NULL,
    [AniPedigree]  NVARCHAR (100) COLLATE Latin1_General_CI_AS NULL,
    [AniChip]      NVARCHAR (50)  COLLATE Latin1_General_CI_AS NULL,
    [AniObs]       NTEXT          COLLATE Latin1_General_CI_AS NULL,
    [AniDtCad]     SMALLDATETIME  NULL,
    [AniConv]      NUMERIC (18)   NULL,
    [AniFoto]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CadAnimal] PRIMARY KEY CLUSTERED ([IdAnimal] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CadAnimal]
    ON [dbo].[CadAnimal]([AniCliente] ASC);

