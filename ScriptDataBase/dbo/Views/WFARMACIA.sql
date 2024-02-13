CREATE VIEW dbo.WFARMACIA
AS
SELECT     dbo.CadFaCli.FaDt, dbo.CadFaCli.FaCli, dbo.CadFaCli.FaAni, dbo.CadFaCli.FaEv, dbo.CadFaCli.FaDesc, dbo.CadFaCli.FaVlr, dbo.CadFaCli.FaNssNro, 
                      dbo.CadAnimal.AniNome, dbo.CadCliente.ClNome, dbo.CadFinS.FiVlrPgto, dbo.CaixaMov.MVDesc
FROM         dbo.CadFaCli INNER JOIN
                      dbo.CadItem ON dbo.CadFaCli.FaEv = dbo.CadItem.MSMAT INNER JOIN
                      dbo.CadAnimal ON dbo.CadFaCli.FaAni = dbo.CadAnimal.IdAnimal INNER JOIN
                      dbo.CadCliente ON dbo.CadAnimal.AniCliente = dbo.CadCliente.ClId INNER JOIN
                      dbo.CadFinS ON dbo.CadFaCli.FaNssNro = dbo.CadFinS.FiNssNro INNER JOIN
                      dbo.CaixaMov ON dbo.CadFinS.FiNssNro = dbo.CaixaMov.MVOS
WHERE     (dbo.CadItem.MSGRUPO = 6) AND (dbo.CadFaCli.FaDt >= CONVERT(DATETIME, '2018-11-20 00:00:00', 102))