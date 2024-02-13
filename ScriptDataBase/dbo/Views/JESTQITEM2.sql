CREATE VIEW dbo.JESTQITEM2
AS
SELECT DISTINCT 
                      dbo.CadItem.MSGRUPO, dbo.CadItem.MSSUBGRP, dbo.CadItem.MSMAT, dbo.CADESTOQUE.ETITEM, dbo.CadItem.MSMIN, dbo.CadItem.MSDESC, 
                      dbo.CadItem.MSUNID, dbo.CADESTOQUE.ETDTREF, dbo.CADESTOQUE.ETSOLIC, dbo.CADESTOQUE.ETQTDE, dbo.CADESTOQUE.ETVALOR, 
                      dbo.CADESTOQUE.ETQTDS, dbo.CADESTOQUE.ETVLRS, dbo.CADESTOQUE.ETFORNEC, dbo.CADESTOQUE.ETCCUSTO, dbo.CadItem.MSPRR, dbo.CadItem.MSPRDL, 
                      dbo.CadItem.MSSALDO
FROM         dbo.CadItem INNER JOIN
                      dbo.CADESTOQUE ON dbo.CadItem.MSMAT = dbo.CADESTOQUE.ETITEM COLLATE Latin1_General_CI_AI