CREATE VIEW dbo.VwFechaMes
AS
SELECT     dbo.CadFinS.FiNssNro, dbo.CadFinS.FiAnoMes, dbo.CadFinS.FiDtVcto, dbo.CadFinS.FiDtPgto, dbo.CadFinS.FiVlr, dbo.CadFinS.FiVlrPgto, dbo.CadFaCli.FaDesc, 
                      dbo.CadCliente.ClNome, dbo.CadAnimal.AniNome, dbo.CadFunc.FuNome, dbo.CadFaCli.FaVlr
FROM         dbo.CadAnimal INNER JOIN
                      dbo.CadFinS INNER JOIN
                      dbo.CadFaCli ON dbo.CadFinS.FiNssNro = dbo.CadFaCli.FaNssNro INNER JOIN
                      dbo.CadCliente ON dbo.CadFinS.FiCli = dbo.CadCliente.ClId ON dbo.CadAnimal.IdAnimal = dbo.CadFinS.FiAni INNER JOIN
                      dbo.CadFunc ON dbo.CadFaCli.FaFunc = dbo.CadFunc.FuId
WHERE     (dbo.CadFinS.FiAnoMes >= 202109) AND (dbo.CadFinS.FiVlrPgto >= 0)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VwFechaMes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'nWidths = 11
         Column = 4095
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VwFechaMes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[25] 3) )"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 3
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CadAnimal"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CadFinS"
            Begin Extent = 
               Top = 6
               Left = 632
               Bottom = 125
               Right = 792
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "CadFaCli"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 125
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "CadCliente"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CadFunc"
            Begin Extent = 
               Top = 6
               Left = 830
               Bottom = 125
               Right = 990
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin Colum', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VwFechaMes';

