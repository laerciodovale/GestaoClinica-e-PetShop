CREATE VIEW dbo.WVRESULTADO
AS
SELECT     dbo.CADGRUPO.GRGRUPO, dbo.CADGRUPO.GRDESC, dbo.CadItem.MSMAT, dbo.CadItem.MSDESC, dbo.CadFaCli.FaVlr, dbo.CadFaCli.FaNssNro, dbo.CadFaCli.FaAni, 
                      dbo.CadFaCli.FaCli
FROM         dbo.CADGRUPO INNER JOIN
                      dbo.CadItem ON dbo.CADGRUPO.GRGRUPO = dbo.CadItem.MSGRUPO INNER JOIN
                      dbo.CadFaCli ON dbo.CadItem.MSMAT = dbo.CadFaCli.FaEv COLLATE Latin1_General_CI_AI