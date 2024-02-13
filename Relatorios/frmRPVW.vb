Public Class frmRPVW
    Private Sub frmRPVW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadVetDataSet1.vw_RelReceita'. Você pode movê-la ou removê-la conforme necessário.
        ' Me.vw_RelReceitaTableAdapter.Fill(Me.CadVetDataSet1.vw_RelReceita)


        ' Me.RvwGeral.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RvwGeral.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NroReceita", txtParametro.Text))
        Me.RvwGeral.RefreshReport()

    End Sub
End Class