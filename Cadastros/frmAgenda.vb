Imports System.Windows.Forms

Imports DataBase
Imports Financeiro

Public Class frmAgenda
    Private clsPront As New Cls_Prontuario
    Private clsCli As New Cls_Cliente
    Private Cpf As String
    Private Status As String
    Private DtAnterior As Date
    Private HrAnterior As String
    Private Sub LimpaTela()

        ''mcAgenda.SelectionStart = Now

        ddH.Text = Format(Now, "07")
        ddM.Text = Format(Now, "00")
        txtCpf.Text = ""
        txtId.Text = 0
        txtPet.Text = 0
        cboNomePet.Text = ""
        txtCliente.Text = ""
        mskFone.Text = ""
        txtEmail.Text = ""
        cboTpAgenda.Text = ""
        txtObs.Text = ""
        cboFunc.Text = ""
        txtIdAg.Text = 0
        txtCpf.ValidaCPF = True
        txtCpf.ValidaCNPJ = False
    End Sub
    Private Sub EnableFalse()

        ddH.Enabled = False
        ddM.Enabled = False
        txtCpf.Enabled = False
        txtCliente.Enabled = False
        cboNomePet.Enabled = False
        mskFone.Enabled = False
        txtEmail.Enabled = False
        cboTpAgenda.Enabled = True
        txtObs.Enabled = False
        cboFunc.Enabled = True
        opAgendado.Enabled = False
        opAtendido.Enabled = True
        opCancelado.Enabled = True
        opFalta.Enabled = True
        rbReAgenda.Enabled = True

        btoIncluir.Enabled = False
        btoExcluir.Enabled = True
        btoAlterar.Enabled = True

    End Sub
    Private Sub EnableTrue()
        ddH.Enabled = True
        ddM.Enabled = True
        txtCpf.Enabled = True
        txtCliente.Enabled = True
        cboNomePet.Enabled = True
        mskFone.Enabled = True
        txtEmail.Enabled = True
        cboTpAgenda.Enabled = True
        txtObs.Enabled = True
        cboFunc.Enabled = True
        opAgendado.Enabled = True
        opAtendido.Enabled = False
        opCancelado.Enabled = False
        opFalta.Enabled = False
        rbReAgenda.Enabled = False
        btoIncluir.Enabled = True
        btoExcluir.Enabled = False
        btoAlterar.Enabled = False

    End Sub

    Private Sub LeCliente()
        Cpf = txtCpf.Text
        If Cpf.Length = 0 Then
            DgAg.DataSource = Nothing
            DgAg.Rows.Clear()
            Exit Sub
        End If

        'Cpf = Replace(Cpf, ".", "")
        'Cpf = Replace(Cpf, "-", "")
        'Cpf = Replace(Cpf, "/", "")

        Try
            clsCli.BuscaCPF(Cpf)

            If clsCli.Cl_Id = 0 Then
                MessageBox.Show("Dados do Cliente com o CPF/CNPJ " & txtCpf.Text & " não encontrado." & vbCr & "Favor efetuar o cadastro no Prontuario,", "Cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                'LimpaForm()
                Exit Sub
            End If

            txtId.Text = clsCli.Cl_Id
            txtCliente.Text = clsCli.Cl_Nome
            txtPet.Text = clsCli.Id_Animal
            cboNomePet.Text = clsCli.Ani_Nome
            txtEmail.Text = clsCli.Cl_Email
            mskFone.Text = clsCli.Cl_Fixo

            'Dim dt As DataTable
            'dt = clsCli.BuscaAgDoCli(clsCli.Cl_Id)
            'dgAgenda.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmAgenda_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
    Private Sub Config_Dg()
        Try
            DgAg.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(0).HeaderText = "ID"
            'dgAgenda.Columns(0).Width = 4
            DgAg.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(1).HeaderText = " Data "
            'dgAgenda.Columns(1).Width = 35
            DgAg.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(2).HeaderText = " Hora "
            'dgAgenda.Columns(2).Width = 35
            DgAg.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(3).HeaderText = " Cliente "
            DgAg.Columns(3).Width = 25
            DgAg.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(4).HeaderText = " Nome do Cliente "
            DgAg.Columns(4).Width = 60
            DgAg.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(5).HeaderText = " Email "
            DgAg.Columns(5).Width = 60
            DgAg.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(6).HeaderText = "Agendamento "
            DgAg.Columns(6).Width = 45
            DgAg.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(7).HeaderText = " Observação "
            DgAg.Columns(7).Width = 80
            DgAg.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(8).HeaderText = " Proficional "
            DgAg.Columns(8).Width = 60
            DgAg.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgAg.Columns(9).HeaderText = " ST "
            DgAg.Columns(9).Width = 60

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub MoveVar()

        'Ag_Id As Integer
        clsPront.Ag_Data = mcAgenda.SelectionStart.ToShortDateString
        clsPront.ag_Hora = ddH.Text & ":" & ddM.Text
        clsPront.ag_Cpf = txtCpf.Text
        clsPront.ag_Cliente = txtCliente.Text
        clsPront.ag_idCli = txtId.Text
        clsPront.ag_IdPet = txtPet.Text
        clsPront.ag_NomePet = cboNomePet.Text
        clsPront.ag_Contato = Trim(mskFone.Text)
        clsPront.ag_Email = txtEmail.Text
        clsPront.ag_Tipo = cboTpAgenda.Text
        clsPront.ag_Obs = txtObs.Text
        clsPront.ag_Funcionario = cboFunc.Text
        Alt_St()
        clsPront.ag_St = Status
        clsPront.ag_Os = mdVar.md_OS

    End Sub
    Private Sub MoveDados()

        'mcAgenda.TodayDate = clsPront.Ag_Data

        mcAgenda.SelectionStart = clsPront.Ag_Data
        DtAnterior = clsPront.Ag_Data
        ddH.Text = Mid(clsPront.ag_Hora, 1, 2)
        ddM.Text = Mid(clsPront.ag_Hora, 4, 2)
        HrAnterior = clsPront.ag_Hora
        txtCpf.Text = clsPront.ag_Cpf
        txtId.Text = clsPront.ag_idCli
        txtCliente.Text = clsPront.ag_Cliente
        cboNomePet.Text = clsPront.ag_NomePet
        txtPet.Text = clsPront.ag_IdPet
        mskFone.Text = Trim(clsPront.ag_Contato)
        txtEmail.Text = clsPront.ag_Email
        cboTpAgenda.Text = clsPront.ag_Tipo
        txtObs.Text = clsPront.ag_Obs
        cboFunc.Text = clsPront.ag_Funcionario
        txtIdAg.Text = clsPront.Ag_Id
        txtOs.Text = clsPront.ag_Os
        Select Case Trim(clsPront.ag_St)
            Case "Agendado"
                opAgendado.Checked = True
            Case "Atendido"
                opAtendido.Checked = True
            Case "Cancelado"
                opCancelado.Checked = True
            Case "Falta"
                opFalta.Checked = True
            Case "ReAgendado"
                rbReAgenda.Checked = True
        End Select

    End Sub
    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click
        clsPront.Ag_Id = 0
        BuscaDuplicidade()
        'clsPront.BuscaAgendaDupl()

        If clsPront.Ag_Id > 0 Then
            MessageBox.Show("Agenda em DUPLICIDADE." & vbCrLf _
                                                & "verifique a data do agendamento." & vbCrLf _
                                                & "Processo encerrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Trim(cboTpAgenda.Text) = "" Then
            MessageBox.Show("Campo Tipo de agendamento não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboTpAgenda.Focus()
            cboTpAgenda.SelectedIndex = 1
            cboTpAgenda.[Select]()
            Exit Sub
        End If
        If Trim(cboFunc.Text) = "" Then
            MessageBox.Show("Campo Nome do Proficional não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboFunc.Focus()
            cboFunc.SelectedIndex = 0
            cboFunc.[Select]()
            Exit Sub
        End If
        If Trim(txtCliente.Text) = "" Then
            MessageBox.Show("Campo Cliente não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCliente.Focus()
            Exit Sub
        End If
        If Len(Trim(mskFone.Text)) = 0 Then
            Dim result1 As DialogResult = MessageBox.Show("Campo contato não informado." & vbCr & "Continua mesmo assim??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result1 = 7 Then
                mskFone.Focus()
                Exit Sub
            End If
        End If
        If Trim(ddH.Text) = "" Then
            MessageBox.Show("Campo Hora não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ddH.Focus()
            Exit Sub
        End If
        If Trim(ddM.Text) = "" Then
            MessageBox.Show("Campo Minuto não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ddM.Focus()
            Exit Sub
        End If
        Try
            MoveVar()
            clsPront.Insert_Agenda()

            LimpaForm()
            MessageBox.Show("Inclusão efetuada com sucesso.", "Inclusão de Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information)

            clsPront.Ag_Data = mcAgenda.SelectionStart.ToShortDateString
            PreencheAG()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub LimpaForm()

        mcAgenda.ShowToday = True
        txtId.Text = 0
        txtPet.Text = 0
        ddH.Text = "07"
        ddM.Text = "00"
        txtCliente.Text = ""
        mskFone.Text = ""
        txtObs.Text = ""
        cboTpAgenda.Text = ""
        txtEmail.Text = ""
        cboFunc.Text = ""
        opAgendado.Checked = True
        opAtendido.Checked = False
        opCancelado.Checked = False
        opFalta.Checked = False
        rbReAgenda.Checked = False

        btoAlterar.Enabled = False
        btoExcluir.Enabled = False

        txtCpf.ValidaCPF = True
        txtCpf.ValidaCNPJ = False
    End Sub
    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
        txtCliente.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub mcAgenda_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcAgenda.DateChanged
        '  LimpaForm()
        'EnableTrue()
        clsPront.Ag_Data = mcAgenda.SelectionStart.ToShortDateString
        PreencheAG()

    End Sub
    Private Sub PreencheAG()
        Dim dtg As DataTable
        dtg = clsPront.LeAgenda
        DgAg.DataSource = dtg

        'Config_Dg()

        'For Each Row As DataGridViewRow In dgAgenda.Rows

        '    Select Case Trim(Row.Cells(9).Value)
        '        Case "Atendido"
        '            Row.DefaultCellStyle.BackColor = Color.GreenYellow
        '        Case "Cancelado"
        '            Row.DefaultCellStyle.BackColor = Color.SlateBlue
        '        Case "Falta"
        '            Row.DefaultCellStyle.BackColor = Color.Red
        '    End Select

        'Next
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btoExcluir.Click
        Try
            If clsPront.Ag_Id > 0 Then
                Dim result1 As DialogResult = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result1 = 6 Then
                    clsPront.Ag_Id = txtIdAg.Text
                    clsPront.Exclui_Agenda()
                    PreencheAG()
                    LimpaForm()
                    PreencheAG()
                    EnableTrue()
                    Me.Close()
                End If

            Else
                MessageBox.Show("Agenda não selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btoAlterar.Enabled = False
        btoExcluir.Enabled = False
    End Sub
    Private Sub PreencheCbo()
        'ADICIONA NOVA LINHA NO COMBO Unidade
        Dim Prontuario As New Cls_Prontuario
        Dim ds As DataSet
        ds = Prontuario.LeTipoAgenda()

        Dim Ag As DataRow = ds.Tables(0).NewRow
        Ag.Item("agdesc") = "VETERINARIO"
        Ag.Item("agtp") = "1"

        ds.Tables(0).Rows.InsertAt(Ag, 0)
        ds.Tables(0).AcceptChanges()

        'VINCULA DATASET NO COMBO BOX
        cboTpAgenda.DisplayMember = "VETERINARIO"
        cboTpAgenda.ValueMember = "1"
        cboTpAgenda.DataSource = ds.Tables(0)

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ds = Prontuario.LeFunc()

        Dim Fu As DataRow = ds.Tables(0).NewRow
        Fu.Item("funome") = "funcionario"
        Fu.Item("fuid") = "1"

        ds.Tables(0).Rows.InsertAt(Fu, 0)
        ds.Tables(0).AcceptChanges()

        cboTpAgenda.DisplayMember = "funcionario"
        cboTpAgenda.ValueMember = "1"
        cboTpAgenda.DataSource = ds.Tables(0)

    End Sub
    Private Sub frmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpaForm()

        clsPront.Ag_Data = Now
        'Preenche Combo Tipo de Agendamento
        Dim dt As DataTable = clsPront.LeTipoAgenda()

        cboTpAgenda.DisplayMember = "agdesc"
        cboTpAgenda.ValueMember = "agtp"
        cboTpAgenda.DataSource = dt

        'Preenche Combo Funcionário
        Dim dtF As DataTable = clsPront.LeFunc()

        cboFunc.DisplayMember = "funome"
        cboFunc.ValueMember = "fuid"
        cboFunc.DataSource = dtF

        ''If Len(Trim(md_Cpf)) > 5 Then

        Dim dtAG As DataTable
        If mdVar.md_ID > 0 Then
            clsPront.Ag_Id = mdVar.md_ID
            clsPront.BuscaAgenda()
            MoveDados()
            EnableFalse()
        End If

        If md_Id_Tutor <> 0 Then
            'le os dados da agenda pelo id
            clsPront.Ag_Id = mdVar.md_ID
            clsPront.BuscaAgenda()
            MoveDados()

            clsCli.BuscaCliente("Sp_Cliente_Sel", md_Id_Tutor)
            txtId.Text = md_Id_Tutor
            txtCliente.Text = clsCli.Cl_Nome
            txtCpf.ValidaCPF = True
            txtCpf.Text = clsCli.Cl_Cpf
            txtEmail.Text = clsCli.Cl_Email
            mskFone.Text = clsCli.Cl_Fixo

            'MoveDados()
            btoAlterar.Enabled = True
            btoExcluir.Enabled = True

            'le agenda do tutor
            dtAG = clsPront.BuscaAgendaTutor(md_Id_Tutor)
            DgAg.DataSource = dtAG
            txtIdAg.Text = md_ID
            clsPront.Ag_Id = md_ID

            clsCli.Id_Animal = md_Id_Pet
            If md_Id_Pet > 0 Then
                clsCli.BuscaPaciente()
                cboNomePet.Text = clsCli.Ani_Nome
            Else
                ''pet's do tutor
                Dim dtPT As DataTable = clsPront.BuscaPetDoTutor(md_Id_Tutor)

                cboNomePet.DisplayMember = "AniNome"
                cboNomePet.ValueMember = "IdAnimal"
                cboNomePet.DataSource = dtPT
                clsCli.Id_Animal = cboNomePet.SelectedValue
                cboNomePet.Focus()
            End If
            txtPet.Text = clsCli.Id_Animal

            'Else
            '    'le agenda 
            '    'clsPront.Ag_Data = Format(Now, "yyyy-MM-dd")
            '    'dtAG = clsPront.LeAgenda(clsPront.Ag_Data)
            '    'DgAg.DataSource = dtAG


            'End If

        End If
        Dim d As Date = Format(Now, "dd/MM/yyyy")
        If IsDate(mdVar.md_Data) = False Then
            mdVar.md_Data = Now
        End If
        Dim dd As Date = mdVar.md_Data

        ' EnableFalse()

        If Format(dd, "dd/MM/yyyy") <> Format(d, "dd/MM/yyyy") Then

            mcAgenda.TodayDate = mdVar.md_Data
            clsPront.Ag_Data = mdVar.md_Data
            clsPront.Ag_Id = mdVar.md_ID

        End If

    End Sub
    Private Sub Alt_St()
        ddH.Enabled = False
        ddM.Enabled = False

        If opAgendado.Checked = True Then
            Status = "Agendado"
        End If
        If opAtendido.Checked = True Then
            Status = "Atendido"
        End If
        If opCancelado.Checked = True Then
            Status = "Cancelado"
        End If
        If opFalta.Checked = True Then
            Status = "Falta"
        End If
        If rbReAgenda.Checked = True Then
            Status = "ReAgendado"
            ddH.Enabled = True
            ddM.Enabled = True
        End If
    End Sub
    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click

        Alt_St()

        Try
            If txtIdAg.Text > 0 Then
                Dim result1 As DialogResult = MessageBox.Show("Tem certeza que deseja alterar o registro selecionado.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                ''verduplicidade

                MoveVar()

                If result1 = 6 Then

                    If Status = "ReAgendado" Then
                        Dim result2 As DialogResult = MessageBox.Show("Você esta fazendo um Re Agendamento, a Data e o Horário estão corretos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If result2 = 6 Then
                            clsPront.Ag_Id = 0
                            BuscaDuplicidade()
                            'clsPront.BuscaAgendaDupl()

                            If clsPront.Ag_Id > 0 Then
                                MessageBox.Show("Agenda em DUPLICIDADE." & vbCrLf _
                                                & "verifique a data do agendamento." & vbCrLf _
                                                & "Processo encerrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            Dim ClsBanho As New Cls_Banho
                            ClsBanho.LeContrato("TD", 0, txtOs.Text, 0)
                            clsPront.Bt_Obs = ClsBanho.Bt_ObsServico

                            clsPront.Bt_Obs = clsPront.Bt_Obs & vbCrLf & "id : " & txtIdAg.Text & " " & Status & " De data = " & DtAnterior & " para  " _
                            & mcAgenda.SelectionStart.ToShortDateString & ", De hora = " & HrAnterior & " para " & ddH.Text & ":" & ddM.Text

                            clsPront.UpDateObsAgenda()

                        Else
                            Exit Sub
                        End If

                    End If

                    clsPront.Ag_Id = txtIdAg.Text

                    clsPront.UpDateAgenda()

                    LimpaForm()
                    EnableTrue()
                    PreencheAG()
                    Me.Close()
                End If

            Else
                MessageBox.Show("Agenda não selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btoAlterar.Enabled = False
        btoExcluir.Enabled = False

    End Sub
    Private Sub BuscaDuplicidade()
        clsPront.Ag_Id = 0
        clsPront.Ag_Data = mcAgenda.SelectionStart
        clsPront.ag_Hora = ddH.Text & ":" & ddM.Text
        clsPront.ag_idCli = txtId.Text
        clsPront.ag_IdPet = txtPet.Text
        clsPront.ag_Tipo = cboTpAgenda.Text

        clsPront.BuscaAgendaDupl()


    End Sub
    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        If Len(txtCpf.Text) > 0 Then
            ' LimpaForm()
            '' LeCliente()

        End If
    End Sub

    Private Sub PesqCliente()
        Using frm As New frmFConsCli
            frm.ShowDialog()
            If frm.fcc_IdCli > 0 Then
                ' Dim enter As New KeyEventArgs(Keys.Enter)
                txtCpf.Text = frm.fcc_CpfCli
                txtCliente.Text = frm.fcc_NomeCli
                txtId.Text = frm.fcc_IdCli
                ' txtCpf_KeyDown(Nothing, enter)

                cboNomePet.Focus()
            End If

        End Using
    End Sub

    Private Sub frmAgenda_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F10 Then '''  CONSULTA CLIENTE
            PesqCliente()
        End If
    End Sub

    Private Sub DgAg_Click(sender As Object, e As EventArgs) Handles DgAg.Click
        LimpaForm()
        Try
            clsPront.Ag_Id = DgAg.CurrentRow.Cells(0).Value.ToString()
            clsPront.BuscaAgenda()
            MoveDados()

            EnableFalse()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rbReAgenda_CheckedChanged(sender As Object, e As EventArgs) Handles rbReAgenda.CheckedChanged
        Alt_St()

    End Sub

    Private Sub opCancelado_CheckedChanged(sender As Object, e As EventArgs) Handles opCancelado.CheckedChanged
        Alt_St()

    End Sub

    Private Sub opFalta_CheckedChanged(sender As Object, e As EventArgs) Handles opFalta.CheckedChanged
        Alt_St()

    End Sub

    Private Sub opAtendido_CheckedChanged(sender As Object, e As EventArgs) Handles opAtendido.CheckedChanged
        Alt_St()
    End Sub


    Private Sub cboNomePet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNomePet.SelectedIndexChanged
        txtPet.Text = cboNomePet.SelectedValue
    End Sub

    Private Sub txtCpf_TextChanged(sender As Object, e As EventArgs) Handles txtCpf.TextChanged

    End Sub
End Class