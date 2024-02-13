
Imports Cadastros
Imports DataBase
Imports DataBase.Utils

Public Class frmMenu
#Region "Proriedades dos Clientes"
    Public Property Id_Cliente_Menu As Integer
    Public Property Id_Paciente_Menu As Integer

#End Region
    Private Cliente As New Cls_Cliente
    Private formPront As frmProntuario = Nothing
    Private Sub MontaDgGridTop()
        Try
            DgGridTop.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgGridTop.Columns(0).HeaderText = " Nome        "
            DgGridTop.Columns(0).Width = 15

            DgGridTop.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgGridTop.Columns(0).HeaderText = " Codigo "
            DgGridTop.Columns(0).Width = 10
        Catch ex As Exception
            TrataErro("Problema ao efetuar a pesquisa", ex)
        End Try
    End Sub
    Private Sub txt_Busca_GotFocus(sender As Object, e As EventArgs)
        Try
            txt_Busca.Text = ""

        Catch ex As Exception
            TrataErro("Problema ao tentar efetuar a pesquisa.", ex)
        End Try

    End Sub

    Private Sub DgGridTop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim frm As New FrmClientes
        Dim U As New Utils
        If cboTiposPesquisa.SelectedValue = 1 Or cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 5 Then
            U.Id_Paciente = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            U.Id_Cliente = Me.DgGridTop.CurrentRow.Cells(2).Value.ToString()
        Else
            U.Id_Cliente = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            U.Id_Paciente = 0
        End If

        frm.show()

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dt As DataTable = Cliente.Preenche_Combo("Sp_Tipo_Pesquisa")
        cboTiposPesquisa.DisplayMember = "DescTpPS"
        cboTiposPesquisa.ValueMember = "idTPPS"
        cboTiposPesquisa.DataSource = dt

        Cliente.Cl_Nome = " "
        Cliente.Tipo_Operacao = 5
        cboTiposPesquisa.SelectedValue = 5

        Dim banco As New Cls_Cliente

        DgGridTop.Show()
        Cliente.Cl_Nome = " "
        Cliente.Tipo_Operacao = 5 'ultimas consultas

        ''Faz a pesquisa
        dt = banco.BuscaNome(Cliente.Tipo_Operacao, Cliente.Cl_Nome)
        'vincula a tabela
        DgGridTop.DataSource = dt
        MontaDgGridTop()

    End Sub
    Private Sub cboTiposPesquisa_SelectionChangeCommitted(sender As Object, e As EventArgs)

        If cboTiposPesquisa.SelectedValue = "1" Or cboTiposPesquisa.SelectedValue = "2" And txt_Busca.TextLength = 0 Then
            txt_Busca.Focus()
            Exit Sub
        End If

        Cliente.Cl_Nome = txt_Busca.Text
        Cliente.Tipo_Operacao = cboTiposPesquisa.SelectedValue

        Dim banco As New Cls_Cliente
        Dim dt As DataTable
        Dim Tipo As String
        Dim N_lk As String

        DgGridTop.Show()
        Try

            If Cliente.Tipo_Operacao IsNot Nothing Then
                Cliente.Cl_Nome = txt_Busca.Text
                Cliente.Tipo_Operacao = cboTiposPesquisa.SelectedValue
                If Cliente.Tipo_Operacao = "1" Or Cliente.Tipo_Operacao = "2" Then
                    If txt_Busca.TextLength = 0 Then
                        ' MessageBox.Show("Tipo da pesquisa exige uma parte do nome do Paciente/Cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_Busca.Focus()
                    End If
                End If
            Else
                Cliente.Cl_Nome = " "
                Cliente.Tipo_Operacao = 5 'ultimas consultas
            End If

            ''Faz a pesquisa
            dt = banco.BuscaNome(Cliente.Tipo_Operacao, Cliente.Cl_Nome)
            'vincula a tabela
            DgGridTop.DataSource = dt

        Catch ex As Exception
            TrataErro("Problema ao tentar efetuar a leitura", ex)
        End Try

        MontaDgGridTop()

    End Sub

    Private Sub txt_Busca_LostFocus(sender As Object, e As EventArgs) Handles txt_Busca.LostFocus
        If cboTiposPesquisa.SelectedValue = 1 Or cboTiposPesquisa.SelectedValue = 2 Then
            Busca()
            Exit Sub
        End If

        ''pnAgenda.Visible = False
        Dim banco As New Cls_Cliente
        Dim dt As DataTable
        Dim Tipo As String
        Dim N_lk As String

        DgGridTop.Show()
        Try
            If txt_Busca.TextLength = 0 Then
                Cliente.Cl_Nome = " "
                Cliente.Tipo_Operacao = "5" 'Top 50 consultas
            Else
                Cliente.Cl_Nome = txt_Busca.Text
                Cliente.Tipo_Operacao = cboTiposPesquisa.SelectedValue
            End If

            ''Faz a pesquisa
            dt = banco.BuscaNome(Cliente.Tipo_Operacao, Cliente.Cl_Nome)
            'vincula a tabela
            DgGridTop.DataSource = dt

        Catch ex As Exception
            TrataErro("Problema ao tentar efetuar a leitura", ex)
        End Try

        MontaDgGridTop()

    End Sub

    Private Sub DgGridTop_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DgGridTop.CellContentClick

        If cboTiposPesquisa.SelectedValue = 1 Or cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 5 Then
            Id_Cliente_Menu = Me.DgGridTop.CurrentRow.Cells(2).Value.ToString()
            Id_Paciente_Menu = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
        Else
            Id_Cliente_Menu = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            Id_Paciente_Menu = 0
        End If

        'Using FormClientes As New FrmClientes(Parametro_cLI:=Id_Cliente_Menu, Parametro_Pac:=Id_Paciente_Menu)
        '    '      FormClientes.ShowDialog()
        'End Using

        If formPront Is Nothing Then
            formPront = New frmProntuario
            '   formPront.MdiParent = Me
            'formPront.Id_Enviado_Cli = Id_Cliente_Menu
            'formPront.Id_Enviado_Pac = Id_Paciente_Menu
            'formPront.Show()
        ElseIf formPront.IsHandleCreated = False Then
            formPront = New frmProntuario
            '   formPront.MdiParent = Me
            '    formPront.Id_Enviado_Cli = Id_Cliente_Menu
            '    formPront.Id_Enviado_Pac = Id_Paciente_Menu
            '    formPront.Show()
        Else
            formPront.Close()
            'formPront.Focus()
        End If

        'formPront = New frmProntuario
        '  formPront.MdiParent = Me
        formPront.Id_Enviado_Cli = Id_Cliente_Menu
        formPront.Id_Enviado_Pac = Id_Paciente_Menu

        formPront.ShowDialog()


    End Sub

    Private Sub Busca()
        Dim banco As New Cls_Cliente
        Dim dt As DataTable
        Dim Tipo As String
        Dim N_lk As String

        DgGridTop.Show()
        Try
            If cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 4 Or cboTiposPesquisa.SelectedValue = 5 Then
                Cliente.Cl_Nome = txt_Busca.Text
                Cliente.Tipo_Operacao = cboTiposPesquisa.SelectedValue
            Else

                If txt_Busca.TextLength = 0 Then
                    Cliente.Cl_Nome = " "
                    Cliente.Tipo_Operacao = "5" 'Top 50 consultas
                Else
                    Cliente.Cl_Nome = txt_Busca.Text
                    Cliente.Tipo_Operacao = cboTiposPesquisa.SelectedValue

                End If

            End If

            ''Faz a pesquisa
            dt = banco.BuscaNome(Cliente.Tipo_Operacao, Cliente.Cl_Nome)
            'vincula a tabela
            DgGridTop.DataSource = dt

        Catch ex As Exception
            TrataErro("Problema ao tentar efetuar a leitura", ex)
        End Try

        MontaDgGridTop()
    End Sub
    Private Sub cboTiposPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposPesquisa.SelectedIndexChanged
        Busca()

    End Sub

    Private Sub txt_Busca_TextChanged(sender As Object, e As EventArgs) Handles txt_Busca.TextChanged
        Busca()
    End Sub





    'Private Sub Le_Vacinas_Mdi()
    'clsPront.Vc_Ani = Paciente_Id_Vacina
    '  Dim dt As DataTable = clsPront.LeVacina(clsPront.Vc_Ani)
    '    Dim dtg As DataTable
    '    clsPront.Vc_Mes = Format(Now, "MM")
    '    dtg = clsPront.LeVacinasDoMes
    '    dgVacinasDoMes.DataSource = dtg

    '    If dtg.Rows.Count.ToString = 0 Then
    '        pnVacina.Visible = False
    '        Exit Sub
    '    End If
    '    dgVacinasDoMes.ColumnHeadersHeight = 20

    '    dgVacinasDoMes.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '    dgVacinasDoMes.Columns(0).HeaderText = "Tipo"
    '    dgVacinasDoMes.Columns(0).Width = 4
    '    dgVacinasDoMes.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '    dgVacinasDoMes.Columns(1).HeaderText = " Data "
    '    dgVacinasDoMes.Columns(1).Width = 35
    '    dgVacinasDoMes.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '    dgVacinasDoMes.Columns(2).HeaderText = " Nome do Animal "
    '    dgVacinasDoMes.Columns(2).Width = 35
    '    dgVacinasDoMes.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '    dgVacinasDoMes.Columns(3).HeaderText = " Nome do Cliente "
    '    dgVacinasDoMes.Columns(3).Width = 80
    '    dgVacinasDoMes.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '    dgVacinasDoMes.Columns(4).HeaderText = " Contato "
    '    dgVacinasDoMes.Columns(4).Width = 50
    'End Sub
End Class