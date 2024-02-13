Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports DataBase
Public Class frmCrystal
    Public Property Crt_P1 As String
    Private Sub frmCrystal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Parametro As New List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        'Le 
        dt = banco.ExecutaDataTable("Sp_Rols_Areas_Sel", Parametro)
        cboArea.DisplayMember = Trim("rolArea")
        cboArea.ValueMember = "rolArea"
        cboArea.DataSource = dt

        crtVwGeral.Refresh()

    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged
        Dim Parametro As New List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        'Le 
        ' Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Area", cboArea.SelectedValue))

        dt = banco.ExecutaDataTable("Sp_Rols_Caminho_Sel", Parametro)
        CboRelatorios.DisplayMember = Trim("rolDescricao")
        CboRelatorios.ValueMember = "rolCaminho"
        CboRelatorios.DataSource = dt

    End Sub
    Private Sub btoAbrir_Click(sender As Object, e As EventArgs) Handles btoAbrir.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load(CboRelatorios.SelectedValue)
        cryRpt.SetDatabaseLogon("sa", "nunsey", "SrvMyPets", "CadVet")
        Me.crtVwGeral.ReportSource = cryRpt
        Me.crtVwGeral.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub crtVwGeral_Load(sender As Object, e As EventArgs) Handles crtVwGeral.Load

    End Sub
End Class
