CREATE VIEW dbo.VWFINANI
AS
SELECT     dbo.CadFinS.FiCli, dbo.CadFinS.FiAni, dbo.CadAnimal.AniNome, dbo.CadCliente.ClNome, dbo.CadFinS.FiDtVcto, dbo.CadFinS.FiDtPgto, dbo.CadFinS.FiVlr, 
                      dbo.CadFinS.FiVlrPgto, dbo.CadFaCli.FaEv, dbo.CadFaCli.FaDesc, dbo.CadFaCli.FaQtd, dbo.CadFaCli.FaVlrU, dbo.CadFaCli.FaVlr, dbo.CadFinS.FiNssNro
FROM         dbo.CadFinS INNER JOIN
                      dbo.CadCliente ON dbo.CadFinS.FiCli = dbo.CadCliente.ClId INNER JOIN
                      dbo.CadAnimal ON dbo.CadFinS.FiAni = dbo.CadAnimal.IdAnimal INNER JOIN
                      dbo.CadFaCli ON dbo.CadFinS.FiNssNro = dbo.CadFaCli.FaNssNro