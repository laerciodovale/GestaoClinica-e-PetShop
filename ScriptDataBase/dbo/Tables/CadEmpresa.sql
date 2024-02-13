CREATE TABLE [dbo].[CadEmpresa] (
    [empId]      INT            IDENTITY (1, 1) NOT NULL,
    [emRazao]    NVARCHAR (MAX) NULL,
    [emFantasia] NVARCHAR (50)  NULL,
    [emEnd]      NVARCHAR (50)  NULL,
    [emNro]      NCHAR (10)     NULL,
    [emCompl]    NVARCHAR (50)  NULL,
    [emCGC]      NCHAR (14)     NULL,
    [emIE]       NCHAR (20)     NULL,
    [emBairro]   NVARCHAR (50)  NULL,
    [emCidade]   NVARCHAR (50)  NULL,
    [emUF]       NCHAR (2)      NULL,
    [emCEP]      NCHAR (9)      NULL,
    [emFone]     NVARCHAR (50)  NULL,
    [emISS]      DECIMAL (18)   NULL,
    CONSTRAINT [PK_CadEmpresa] PRIMARY KEY CLUSTERED ([empId] ASC)
);

