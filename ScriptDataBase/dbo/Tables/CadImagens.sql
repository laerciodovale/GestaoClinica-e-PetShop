CREATE TABLE [dbo].[CadImagens] (
    [FtId]    INT           NOT NULL,
    [FtAni]   INT           NULL,
    [FtDesc]  NTEXT         COLLATE Latin1_General_CI_AS NULL,
    [FtImg]   IMAGE         NULL,
    [FtDtInq] SMALLDATETIME NULL
);

