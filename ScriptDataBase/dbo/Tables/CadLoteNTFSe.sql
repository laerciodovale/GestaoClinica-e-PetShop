CREATE TABLE [dbo].[CadLoteNTFSe] (
    [NtfSeLote] INT        IDENTITY (3520, 1) NOT NULL,
    [NtfSeData] DATE       NULL,
    [NtfSeDesc] NCHAR (40) NULL,
    CONSTRAINT [PK_CadLoteNTFSeN] PRIMARY KEY CLUSTERED ([NtfSeLote] ASC)
);

