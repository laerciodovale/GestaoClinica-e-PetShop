Public Class frmRpts
    Private Sub frmRpts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadVetDataSet2.CadAnimal'. Você pode movê-la ou removê-la conforme necessário.
        Me.CadAnimalTableAdapter1.Fill(Me.CadVetDataSet2.CadAnimal)
        'TODO: esta linha de código carrega dados na tabela 'CadVetDataSet2.CadAnimal'. Você pode movê-la ou removê-la conforme necessário.
        'Me.CadAnimalTableAdapter.Fill(Me.CadVetDataSet1.CadAnimal)

        'Me.ReportViewer1.RefreshReport()


        Me.ReportViewer1.RefreshReport()
    End Sub


End Class