CREATE TABLE [dbo].[CadCtrVacina] (
    [VcCliente]  INT           NOT NULL,
    [VcItem]     NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [VcData]     DATETIME      NOT NULL,
    [VcTD]       INT           NULL,
    [VcND]       INT           NULL,
    [VcInt]      INT           NULL,
    [VcDoseML]   REAL          NULL,
    [VcMedico]   INT           NULL,
    [VcConvenio] INT           NULL,
    [VcLote]     NCHAR (20)    COLLATE Latin1_General_CI_AS NULL,
    [VcValor]    MONEY         NULL,
    [VcNssNro]   INT           NULL,
    [VcSeq]      INT           NOT NULL,
    [VcPago]     BIT           NULL,
    [VcDtAplic]  DATETIME      NULL
);

