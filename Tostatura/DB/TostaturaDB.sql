SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParametriTostatura]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ParametriTostatura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[umidita_prodotto] [float] NULL,
	[umidita_esterna] [float] NULL,
	[temperatura_forno] [float] NULL,
	[tempo_cottura] [int] NULL,
	[quantita_carico] [float] NULL,
	[tipo_lavorazione] [int] NOT NULL,
 CONSTRAINT [PK_ParametriTostatura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoLavorazione]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoLavorazione](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descrizione] [varchar](50) NULL,
 CONSTRAINT [PK_TipoLavorazione] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoricoAllarmi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StoricoAllarmi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tostatura] [int] NOT NULL,
	[data_allarme] [datetime] NOT NULL,
	[valvola] [float] NOT NULL,
	[apertura_valvola] [float] NOT NULL,
 CONSTRAINT [PK_StoricoAllarmi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnagraficaGrezzi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AnagraficaGrezzi](
	[codice] [varchar](15) NOT NULL,
	[descrizione] [varchar](30) NOT NULL,
	[categoria] [varchar](30) NULL,
 CONSTRAINT [PK_AnagraficaGrezzi] PRIMARY KEY CLUSTERED 
(
	[codice] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnagraficaProdotti]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AnagraficaProdotti](
	[codice] [varchar](15) NOT NULL,
	[descrizione] [varchar](50) NULL,
	[categoria] [int] NULL,
	[calibro] [int] NULL,
	[codice_grezzo] [varchar](15) NULL,
	[id_parametri] [int] NULL,
 CONSTRAINT [PK_Anagrafica Prodotti] PRIMARY KEY CLUSTERED 
(
	[codice] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParametriTostaturaDefault]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ParametriTostaturaDefault](
	[id] [int] NOT NULL,
	[umidita_prodotto] [float] NULL,
	[umidita_esterna] [float] NULL,
	[temperatura_forno] [float] NULL,
	[tempo_cottura] [int] NULL,
	[quantita_carico] [float] NULL,
	[tipo_lavorazione] [int] NOT NULL,
 CONSTRAINT [PK_ParametriTostaturaDefault] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnagraficaDataMemory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AnagraficaDataMemory](
	[tipo_operazione] [nchar](1) NOT NULL,
	[codice_dm] [nchar](20) NOT NULL,
	[descrizione] [nvarchar](50) NULL,
	[offset] [int] NULL,
	[lunghezza] [int] NULL,
 CONSTRAINT [PK_AnagraficaDataMemory] PRIMARY KEY CLUSTERED 
(
	[tipo_operazione] ASC,
	[codice_dm] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoricoInputTostatura]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StoricoInputTostatura](
	[id_tostatura] [int] IDENTITY(1,1) NOT NULL,
	[id_operatore] [int] NOT NULL,
	[data_inizio] [datetime] NOT NULL,
	[codice_prodotto_finito] [varchar](15) NOT NULL,
	[codice_prodotto_grezzo] [varchar](15) NOT NULL,
	[umidita_prodotto] [float] NOT NULL,
	[umidita_esterna] [float] NOT NULL,
	[temperatura_forno] [float] NOT NULL,
	[tempo_cottura] [int] NOT NULL,
	[quantita_carico] [float] NOT NULL,
	[id_tipo_lavorazione] [int] NOT NULL,
	[temp_pre_carico] [float] NULL,
	[data_fine_sosta_forno] [datetime] NULL,
	[avvio_scarico_giostra] [datetime] NULL,
	[tempo_sosta_giostra] [int] NULL,
	[avvio_scarico_carrello] [datetime] NULL,
 CONSTRAINT [PK_StoricoInputTostatura] PRIMARY KEY CLUSTERED 
(
	[id_tostatura] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoricoOutputTostatura]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StoricoOutputTostatura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tostatura] [int] NOT NULL,
	[temp_pre_carico] [float] NOT NULL,
	[inizio_carico] [datetime] NULL,
	[temp_in_carico] [float] NOT NULL,
	[data_fine_sosta_forno] [datetime] NULL,
	[avvio_scarico_giostra] [datetime] NULL,
	[tempo_sosta_giostra] [int] NOT NULL,
	[avvio_scarico_carrello] [datetime] NULL,
 CONSTRAINT [PK_StoricoOutputTostatura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[OeratoriRuoliView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[OeratoriRuoliView]
AS
SELECT     dbo.Operatori.nome, dbo.Operatori.password, dbo.Ruoli.ruolo, dbo.Ruoli.descrizione
FROM         dbo.Operatori INNER JOIN
                      dbo.Ruoli ON dbo.Operatori.id_ruolo = dbo.Ruoli.id
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'OeratoriRuoliView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
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
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Operatori"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ruoli"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 106
               Right = 422
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
      Begin ColumnWidths = 9
         Width = 284
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
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OeratoriRuoliView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'OeratoriRuoliView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OeratoriRuoliView'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ruoli]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ruoli](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ruolo] [nchar](10) NOT NULL,
	[descrizione] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Ruoli] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Operatori]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Operatori](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[id_ruolo] [int] NOT NULL,
 CONSTRAINT [PK_Operatori] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[GrezziFinitiParametriView]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[GrezziFinitiParametriView]
AS
SELECT     dbo.AnagraficaProdotti.codice, dbo.AnagraficaProdotti.descrizione, dbo.AnagraficaProdotti.categoria, dbo.AnagraficaProdotti.calibro, 
                      dbo.AnagraficaGrezzi.descrizione AS grezzo, dbo.AnagraficaGrezzi.categoria AS categoria_grezzo, dbo.ParametriTostatura.umidita_prodotto, 
                      dbo.ParametriTostatura.umidita_esterna, dbo.ParametriTostatura.temperatura_forno, dbo.ParametriTostatura.tempo_cottura, 
                      dbo.ParametriTostatura.quantita_carico, dbo.ParametriTostatura.tipo_lavorazione, dbo.AnagraficaProdotti.codice_grezzo, 
                      dbo.AnagraficaProdotti.id_parametri, dbo.TipoLavorazione.descrizione AS Expr1
FROM         dbo.AnagraficaGrezzi INNER JOIN
                      dbo.AnagraficaProdotti ON dbo.AnagraficaGrezzi.codice = dbo.AnagraficaProdotti.codice_grezzo INNER JOIN
                      dbo.ParametriTostatura ON dbo.AnagraficaProdotti.id_parametri = dbo.ParametriTostatura.id INNER JOIN
                      dbo.TipoLavorazione ON dbo.ParametriTostatura.tipo_lavorazione = dbo.TipoLavorazione.id
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'GrezziFinitiParametriView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
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
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "AnagraficaGrezzi"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 177
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AnagraficaProdotti"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 198
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ParametriTostatura"
            Begin Extent = 
               Top = 5
               Left = 494
               Bottom = 120
               Right = 667
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TipoLavorazione"
            Begin Extent = 
               Top = 12
               Left = 731
               Bottom = 97
               Right = 904
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
      Begin ColumnWidths = 13
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
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder =' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GrezziFinitiParametriView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'GrezziFinitiParametriView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GrezziFinitiParametriView'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'GrezziFinitiParametriView', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GrezziFinitiParametriView'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[ParametriDeaultLavorazione]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[ParametriDeaultLavorazione]
AS
SELECT     dbo.ParametriTostaturaDefault.id, dbo.ParametriTostaturaDefault.umidita_prodotto, dbo.ParametriTostaturaDefault.umidita_esterna, 
                      dbo.ParametriTostaturaDefault.temperatura_forno, dbo.ParametriTostaturaDefault.tempo_cottura, dbo.ParametriTostaturaDefault.quantita_carico, 
                      dbo.TipoLavorazione.descrizione, dbo.ParametriTostaturaDefault.tipo_lavorazione
FROM         dbo.ParametriTostaturaDefault INNER JOIN
                      dbo.TipoLavorazione ON dbo.ParametriTostaturaDefault.tipo_lavorazione = dbo.TipoLavorazione.id
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'ParametriDeaultLavorazione', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
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
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ParametriTostaturaDefault"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TipoLavorazione"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 91
               Right = 422
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
      Begin ColumnWidths = 9
         Width = 284
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
      Begin ColumnWidths = 11
         Column = 1440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ParametriDeaultLavorazione'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'ParametriDeaultLavorazione', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ParametriDeaultLavorazione'
