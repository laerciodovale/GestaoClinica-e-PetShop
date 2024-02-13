CREATE VIEW dbo.VWVACINA
AS
SELECT     TOP 100 PERCENT dbo.CadFaCli.FaCli, dbo.CadFaCli.FaAni, dbo.CadFaCli.FaNssNro, dbo.CadFaCli.FaEv, dbo.CadFaCli.FaDesc, dbo.CadItem.MSGRUPO, 
                      dbo.CadFaCli.FaDt
FROM         dbo.CadFaCli INNER JOIN
                      dbo.CadItem ON dbo.CadFaCli.FaEv = dbo.CadItem.MSMAT
WHERE     (dbo.CadItem.MSGRUPO = 7)
ORDER BY dbo.CadFaCli.FaAni