Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rptViewer.RefreshReport()

    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles rptViewer.Load

    End Sub
End Class