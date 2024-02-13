Imports DataBase
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmAgendaDoPet

    Private ClsBanho As New Cls_Banho
    Private clsCliente As New Cls_Cliente

    Private Sub frmAgendaDoPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BUSCA DADOS DO PET/TUTOR
        clsCliente.LeTutorDoPet(mdVar.md_Id_Pet)
        txtNomePet.Text = clsCliente.Ani_Nome
        txtIdTutor.Text = clsCliente.Cl_Id
        txtNomeTutor.Text = clsCliente.Cl_Nome

        'BUSCA AS OS'S DO PET
        Dim dt As DataTable
        dt = ClsBanho.Sel_ContratoBanho("SP", 0, 0, mdVar.md_Id_Pet)
        dgOsPet.DataSource = dt

        dgOsPet.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgOsPet.Columns(0).HeaderText = "Descrição dos Servicos da OS"
        dgOsPet.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgOsPet.Columns(1).HeaderText = " OS"
        dgOsPet.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgOsPet.Columns(2).HeaderText = " Data e Hora do Cadastro"

    End Sub

    Private Sub dgOsPet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOsPet.CellContentClick
        txtOS.Text = dgOsPet.CurrentRow.Cells(1).Value.ToString()
        Le_Contrato()



    End Sub
    Private Sub Le_Contrato()
        ClsBanho.LeContrato("TD", 0, txtOs.Text, 0)

        ''checkin e checkou lancados para a os
        Dim dt As DataTable
        dt = ClsBanho.LeChecks(txtOS.Text)
        dgAgDaOs.DataSource = dt

        dgAgDaOs.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgDaOs.Columns(0).HeaderText = "ID"
        dgAgDaOs.Columns(0).Width = 4
        dgAgDaOs.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgDaOs.Columns(1).HeaderText = "OS"
        dgAgDaOs.Columns(1).Width = 4
        dgAgDaOs.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgDaOs.Columns(2).HeaderText = "Seq."
        dgAgDaOs.Columns(2).Width = 4
        dgAgDaOs.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgDaOs.Columns(3).HeaderText = "Data Agendada"
        dgAgDaOs.Columns(3).Width = 30
        dgAgDaOs.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgDaOs.Columns(4).HeaderText = "Situação"
        dgAgDaOs.Columns(4).Width = 30

    End Sub

End Class