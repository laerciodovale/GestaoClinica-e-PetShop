CREATE TABLE [dbo].[CADESTOQUE_old] (
    [ETITEM]        NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [ETCCUSTO]      SMALLINT      NOT NULL,
    [ETSETOR]       SMALLINT      NOT NULL,
    [ETDEPTO]       SMALLINT      NOT NULL,
    [ETDTREF]       INT           NOT NULL,
    [ETSOLIC]       INT           NOT NULL,
    [ETHRREF]       NVARCHAR (8)  COLLATE Latin1_General_CI_AS NOT NULL,
    [ETOC]          INT           NOT NULL,
    [ETQTDE]        FLOAT (53)    NOT NULL,
    [ETVALOR]       MONEY         NOT NULL,
    [ETQTDS]        FLOAT (53)    NOT NULL,
    [ETVLRS]        MONEY         NOT NULL,
    [ETFORNEC]      INT           NOT NULL,
    [ETEMPRESA]     INT           NOT NULL,
    [ETVLRUENT]     MONEY         NULL,
    [ETLOTE]        NVARCHAR (20) COLLATE Latin1_General_CI_AS NOT NULL,
    [ETVLRUNISDCTO] MONEY         NULL,
    [ETSEQ]         INT           IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_CADESTOQUE] PRIMARY KEY CLUSTERED ([ETSEQ] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_CADESTOQUE_1]
    ON [dbo].[CADESTOQUE_old]([ETITEM] ASC, [ETDTREF] ASC, [ETSOLIC] ASC, [ETOC] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CADESTOQUE]
    ON [dbo].[CADESTOQUE_old]([ETITEM] ASC);


GO
CREATE TRIGGER SaldoItem
ON [dbo].[CADESTOQUE_old]

FOR  INSERT
AS 
BEGIN

DECLARE @item CHAR(20)
DECLARE @Qtd INT
 
SELECT @item = etitem, @Qtd = sum(etqtde - etqtds) FROM 
INSERTED  
GROUP BY ETITEM

UPDATE CADITEM
SET mssaldo =  @Qtd
WHERE msmat = @item
 
END