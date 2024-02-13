CREATE TABLE [dbo].[CadAgClinica] (
    [adId]          INT           IDENTITY (1, 1) NOT NULL,
    [agData]        DATE          NULL,
    [agHora]        TIME (7)      NULL,
    [agCliente]     NVARCHAR (50) NULL,
    [agContato]     NCHAR (20)    NULL,
    [agEmail]       NVARCHAR (50) NULL,
    [agTipo]        NVARCHAR (50) NULL,
    [agObs]         NVARCHAR (50) NULL,
    [agFuncionario] NVARCHAR (50) NULL,
    [agSt]          NVARCHAR (10) NULL,
    CONSTRAINT [PK_CadAgClinica] PRIMARY KEY CLUSTERED ([adId] ASC)
);

