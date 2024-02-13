CREATE TABLE [dbo].[CadEmpresaN] (
    [empid]     INT            NOT NULL,
    [empcgc]    NCHAR (14)     NULL,
    [empie]     NCHAR (14)     NULL,
    [empim]     NCHAR (14)     NULL,
    [emprazao]  NCHAR (80)     NULL,
    [empfanta]  NCHAR (60)     NULL,
    [empend]    NCHAR (60)     NULL,
    [empnro]    NCHAR (6)      NULL,
    [empcompl]  NCHAR (35)     NULL,
    [empbairro] NCHAR (45)     NULL,
    [empcidade] NCHAR (45)     NULL,
    [empuf]     NCHAR (2)      NULL,
    [empcep]    NCHAR (8)      NULL,
    [empfone]   NCHAR (45)     NULL,
    [emphttp]   NCHAR (100)    NULL,
    [empemail]  NCHAR (100)    NULL,
    [empxml]    NCHAR (100)    NULL,
    [empcodmun] NCHAR (7)      NULL,
    [empufibge] INT            NULL,
    [empiss]    DECIMAL (6, 2) NULL,
    CONSTRAINT [PK_CadEmpresaN] PRIMARY KEY CLUSTERED ([empid] ASC)
);

