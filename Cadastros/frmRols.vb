Imports System.Windows.Forms

Imports CrystalDecisions.Windows.Forms

Imports CrystalDecisions.CrystalReports.Engine

Imports AkutipuruPMEBO.MODULO_CONFIGURACOES

 

Public Class frmRols

 

#Region “Construtores e Destrutores”

    Private Definicoes As DefinicoesAcesso

 

    Public Sub New(ByVal Deff As DefinicoesAcesso)

 

        ‘ This call is required by the Windows Form Designer.

        InitializeComponent()

 

        ‘ Atribui os valores

        Definicoes = Deff

 

    End Sub

#End Region

 

 

    Public Structure estructParametros

        Dim NOME As String

        Dim VALOR As Object

    End Structure

 

    Public rptRelatorio As New CrystalDecisions.CrystalReports.Engine.ReportDocument

 

    Private m_strTilulo As String

    ' ”’ <summary>

    '   ”’ Recebe o Título do Relatório e Sua Sigla (Ex: Contas à Pagar – REL_0001)

    '  ”’ </summary>

    ' ”’ <value>String</value>

    '”’ <returns>String</returns>

    Public Property TITULO_RELATORIO() As String

        Get

            Return m_strTilulo

        End Get

        Set(ByVal value As String)

            m_strTilulo = “Relatório: ” & value

        End Set

    End Property

 

    Private m_strCaminhoRelatorio As String

    '”’ <summary>

    '”’ Recebe o Caminho físico do Relatório a ser carregado (Ex: C:\Relatorios\REL_0001.rpt)

   ' ”’ </summary>

    '”’ <value>String</value>

    '”’ <returns>String</returns>

    Public Property CAMINHO_RELATORIO() As String

        Get

            Return m_strCaminhoRelatorio

        End Get

        Set(ByVal value As String)

            m_strCaminhoRelatorio = value

        End Set

    End Property

 

    Private m_dtsDataSet As Data.DataSet

    '”’ <summary>

    '”’ Recebe os dados do relatório em um DataSet

    '”’ </summary>

    '”’ <value>DataSet</value>

    '”’ <returns>DataSet</returns>

    Public Property DADOS_RELATORIO() As Data.DataSet

        Get

            Return m_dtsDataSet

        End Get

        Set(ByVal value As Data.DataSet)

            m_dtsDataSet = value

        End Set

    End Property

 

    Private m_parParametros As List(Of estructParametros)

    Public Property PARAMETROS() As List(Of estructParametros)

        Get

            Return m_parParametros

        End Get

        Set(ByVal value As List(Of estructParametros))

            m_parParametros = value

        End Set

    End Property

 

    Private Sub frmRelatorio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ‘Limpar título da janela

        m_strTilulo = “”

        rptRelatorio.Dispose()

        rptRelatorio = Nothing

    End Sub

 

    Public Sub LoadtoPrintReport()

        Try

            If System.IO.File.Exists(m_strCaminhoRelatorio) Then

 

                rptRelatorio.Load(m_strCaminhoRelatorio)

                rptRelatorio.SetDataSource(m_dtsDataSet)

 

                For Each a As estructParametros In m_parParametros

                    rptRelatorio.SetParameterValue(a.NOME, a.VALOR)

                Next

 

            Else

                MessageBox.Show(“O Relatório não foi encontrado!”, “Erro”, MessageBoxButtons.OK, MessageBoxIcon.Error)

                rptRelatorio.Dispose()

                Me.Close()

            End If

        Catch ex As Exception

            AkutipuruPMEControls.Configuracoes.TrataErro(ex, Definicoes)

        End Try

    End Sub

 

    Public Function GeraPDFStream() As IO.Stream

        Dim oStream As System.IO.Stream = Nothing

 

        Try

 

            If System.IO.File.Exists(m_strCaminhoRelatorio) Then

 

                rptRelatorio.Load(m_strCaminhoRelatorio)

                rptRelatorio.SetDataSource(m_dtsDataSet)

 

                For Each a As estructParametros In m_parParametros

                    Dim paramValue As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()

                    paramValue.Value = a.VALOR.ToString

                    rptRelatorio.SetParameterValue(a.NOME.ToString, paramValue)

                    paramValue = Nothing

                Next

 

                ‘Gera o relatorio em PDF na Memória

                oStream = rptRelatorio.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)

 

 

                ‘Fechar relatorio

                rptRelatorio.Close()

 

            Else

                MessageBox.Show(“O Relatório não foi encontrado!”, “Erro”, MessageBoxButtons.OK, MessageBoxIcon.Error)

                rptRelatorio.Dispose()

                Me.Close()

            End If

 

            Me.Close()

        Catch ex As Exception

            Throw ex

        End Try

 

        ‘Retorna o PDF

        Return oStream

 

    End Function

 

    Private Sub frmRelatorio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            ‘Coloca como titulo da janela o nome do relatório.

            Me.Text = m_strTilulo

 

            cboZoom.Items.Clear()

            cboZoom.Items.Add(10)

            cboZoom.Items.Add(25)

            cboZoom.Items.Add(50)

            cboZoom.Items.Add(75)

            cboZoom.Items.Add(100)

            cboZoom.Items.Add(150)

            cboZoom.Items.Add(200)

            cboZoom.SelectedIndex = 4

 

 

            If System.IO.File.Exists(m_strCaminhoRelatorio) Then

 

                rptRelatorio.Load(m_strCaminhoRelatorio)

                rptRelatorio.SetDataSource(m_dtsDataSet)

 

                For Each a As estructParametros In m_parParametros

                    Dim paramValue As CrystalDecisions.Shared.ParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue()

                    paramValue.Value = a.VALOR.ToString

                    rptRelatorio.SetParameterValue(a.NOME.ToString, paramValue)

                    paramValue = Nothing

                Next

 

                crView.ReportSource = rptRelatorio

 

                ‘Esconde a TabDoCristalView

                HideCrystalViewerTab()

 

                crView.Refresh()

 

            Else

                MessageBox.Show(“O Relatório não foi encontrado!”, “Erro”, MessageBoxButtons.OK, MessageBoxIcon.Error)

                rptRelatorio.Dispose()

                Me.Close()

            End If

        Catch ex As Exception

            AkutipuruPMEControls.Configuracoes.TrataErro(ex, Definicoes)

        End Try

 

        ‘Me.crView.RefreshReport

 

    End Sub

 

    Private Sub HideCrystalViewerTab()

        Dim tempcontrol As TabControl = crView.Controls(0).Controls(0)

        With tempcontrol

            .ItemSize = New Drawing.Size(0, 1)

            .SizeMode = TabSizeMode.Fixed

            .Appearance = TabAppearance.Buttons

        End With

 

    End Sub

 

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        crView.PrintReport()

    End Sub

 

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        crView.ExportReport()

    End Sub

 

 

    Private Sub btnPrimeira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimeira.Click

        crView.ShowFirstPage()

    End Sub

 

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click

        crView.ShowPreviousPage()

    End Sub

 

    Private Sub btnProxima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProxima.Click

        crView.ShowNextPage()

    End Sub

 

    Private Sub btnUltima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltima.Click

        crView.ShowLastPage()

    End Sub

 

    Private Sub cboZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboZoom.SelectedIndexChanged

        crView.Zoom(cboZoom.Text)

    End Sub

 

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click

        crView.SearchForText(txtPesquisar.Text)

    End Sub

 

    Private Sub txtPesquisar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPesquisar.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnPesquisar_Click(Nothing, Nothing)

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
