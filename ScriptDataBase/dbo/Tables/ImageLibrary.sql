CREATE TABLE [dbo].[ImageLibrary] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ImageTitle] NVARCHAR (100) NULL,
    [ImagePath]  NVARCHAR (255) NULL,
    [ImageBLOB]  IMAGE          NULL,
    [IMANI]      NUMERIC (18)   NULL,
    [IMPRO]      NUMERIC (18)   NULL,
    CONSTRAINT [PK_ImageLibrary] PRIMARY KEY CLUSTERED ([Id] ASC)
);

