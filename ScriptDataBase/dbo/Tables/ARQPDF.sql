﻿CREATE TABLE [dbo].[ARQPDF] (
    [ID]    INT         IDENTITY (1, 1) NOT NULL,
    [IMPDF] BINARY (50) NULL,
    CONSTRAINT [PK_ARQPDF] PRIMARY KEY CLUSTERED ([ID] ASC)
);
