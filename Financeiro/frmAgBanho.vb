Imports System.Windows.Forms
Imports DataBase


Public Class frmAgBanho
    Private clsPront As New Cls_Prontuario
    Private ClsFinan As New Cls_Financeiro
    Private ClsCliente As New Cls_Cliente
    Private ClsBanho As New Cls_Banho
    Private clsUtil As New Utils

    Private DataIni As Date
    Private DataFim As Date
    Private Per As Integer
    Private nro As Integer
    Private Ordem As Integer
    Private MsgZap As String
    ' Public Sub New(Nro_OS As Integer)
    ' Esta chamada é requerida pelo designer.
    'Try
    '    'InitializeComponent()
    '    ' txtOs.Text = Nro_OS
    '    nro = Nro_OS
    'Catch ex As Exception
    '    MessageBox.Show(ex.Message)
    'End Try

    '  End Sub
    Private Sub LimpaForm()
        txtIdCli.Text = ""
        txtIdPet.Text = ""
        txtInicio.Text = Now 'Format(Now, "dd/mm/yyyy")
        txtNomeCli.Text = ""
        txtNomePet.Text = ""
        'txtOs.Text = "0"
        txtTermino.Text = Now 'Format(Now, "dd/mm/yyyy")
        ddOcorr.Text = 1
        cboPeriodo.Text = "Semanal"

        chkTosaHig.Checked = False
        chkTosaMaq.Checked = False
        chkTosaPadraoRaca.Checked = False
        chkTosaTesoura.Checked = False
        chkTosaTrimming.Checked = False
        ''.Bt_Outros 
        txtPenteado.Text = ""
        lblZap.Text = ""
        'txtOs.Text = nro
    End Sub
    Private Sub ZeraCheck()
        cbSeg.Checked = False
        cbTer.Checked = False
        cbQua.Checked = False
        cbQui.Checked = False
        cbSex.Checked = False
        cbSab.Checked = False
    End Sub
    Private Sub LeOs()
        Try

            Dim clsMat As New Cls_Materiais
            clsMat.Busca_Banho_da_Os(txtOs.Text)

            If clsMat.IT_GRUPO <> 3 Then
                MessageBox.Show("Não existe Banho para esta OS. " & vbCr & "Verifique o Agendamento.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
                Exit Sub
            End If

            ClsFinan.Busca_Cliente_Os(txtOs.Text)

            If ClsFinan.Fi_Cli = 0 Then
                MessageBox.Show("Dados da Ordem de Serviço não encontrados.", "Leitura da Ordem Serviço.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Me.LimpaForm()
            Else
                txtIdPet.Text = ClsFinan.Fi_Ani
                txtIdCli.Text = ClsFinan.Fi_Cli
                txtNomeCli.Text = ClsFinan.Fi_NomeCli
                txtNomePet.Text = ClsFinan.Fi_NomeAni
                lblZap.Text = Replace(ClsFinan.NroZap, ".", "")
                lblZap.Text = Replace(lblZap.Text, "(", "")
                lblZap.Text = Replace(lblZap.Text, ")", "")
                lblZap.Text = Replace(lblZap.Text, "-", "")
                lblZap.Text = Replace(lblZap.Text, " ", "")

                ''lblZap.Text = ClsFinan.NroZap

                ClsFinan.Fi_NssNro = txtOs.Text
                txtCpf.Text = ClsFinan.fi_cpf

                Dim dt As DataTable
                dt = ClsFinan.Busca_Itens_da_OS(txtOs.Text)
                cboServicos.DisplayMember = "FaDesc"
                cboServicos.ValueMember = "FaEv"

                cboServicos.DataSource = dt
                ddOcorr.Text = 1 '' Format(cboServicos.SelectedValue, "0")
            End If

            CalcTermino()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CalcTermino()
        Try
            CalcPeriodo()

            Dim today As DateTime = txtInicio.Value

            today = today.AddDays(-Per)
            DataFim = today

            Dim X As Integer
            For X = 1 To (ddOcorr.Text)

                DataFim = today.AddDays(Per)
                today = DataFim

            Next
            txtTermino.Text = DataFim

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmAgBanho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' LimpaForm()
        If IsNumeric(txtOs.Text) = True Then
            LeOs()
        End If

    End Sub
    Private Sub txtInicio_ValueChanged(sender As Object, e As EventArgs) Handles txtInicio.ValueChanged
        ZeraCheck()

        Dim d1 As DateTime = txtInicio.Value
        CalcTermino()
        If d1.DayOfWeek = 1 Then
            cbSeg.Checked = True
        End If
        If d1.DayOfWeek = 2 Then
            cbTer.Checked = True
        End If
        If d1.DayOfWeek = 3 Then
            cbQua.Checked = True
        End If
        If d1.DayOfWeek = 4 Then
            cbQui.Checked = True
        End If
        If d1.DayOfWeek = 5 Then
            cbSex.Checked = True
        End If
        If d1.DayOfWeek = 6 Then
            cbSab.Checked = True
        End If

    End Sub
    Private Sub CalcPeriodo()
        If cboPeriodo.Text = "" Then
            cboPeriodo.Text = "Semanal"
            Per = 7
        End If
        If cboPeriodo.Text = "Diário" Then
            Per = 1
        End If
        If cboPeriodo.Text = "Semanal" Then
            Per = 7
        End If
        If cboPeriodo.Text = "Quinzenal" Then
            Per = 15
        End If
        If cboPeriodo.Text = "Mensal" Then
            Per = 30
        End If
        If cboPeriodo.Text = "Anual" Then
            Per = 366
        End If
    End Sub
    Private Sub MoveContratoBase()
        Try
            With ClsBanho
                .Bt_OS = txtOs.Text
                .Bt_Tutor = txtIdCli.Text
                .Bt_Pet = txtIdPet.Text
                .Bt_TpPcte = 0
                .Bt_TpBanho = 0
                .Bt_TosaHig = chkTosaHig.Checked
                .Bt_TosaMaq = chkTosaMaq.Checked
                .Bt_TosaPadaoRaca = chkTosaPadraoRaca.Checked
                .Bt_TosaTesoura = chkTosaTesoura.Checked
                .Bt_TosaTrimming = chkTosaTrimming.Checked
                .Bt_Outros = ""
                .Bt_Hidratacao = txtHidratacao.Text
                .Bt_Penteado = txtPenteado.Text

                .Bt_AlergiaShampoo = chkAlergiaShampoo.Checked
                .Bt_AlergiaLamina = chkAlergiaLamina.Checked
                .Bt_AlergiaPerfume = chkAlergiaPerfume.Checked
                .Bt_AlergiaOutros = txtAlergiasOutras.Text
                .Bt_Enfeite = chkEnfeiteNao.Checked
                .Bt_ObsTutor = txtObsTutor.Text

                chkLaco.Checked = .Bt_EnfeiteLaco
                chkBandana.Checked = .Bt_EnfeiteBandana
                chkGravata.Checked = .Bt_EnfeiteGravata
                chkAdesivo.Checked = .Bt_EnfeiteAdesivo
                chkEnfeiteNao.Checked = .Bt_EnfeiteNaoUsa

                .Bt_ObsServico = txtObs.Text
                .Bt_St = ""
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub MoveCheckBase()

        With ClsBanho
            .BtCk_os = txtOs.Text
            .BtCk_Nro = Ordem
            .BtCk_Tutor = txtIdCli.Text
            .BtCk_Pet = txtIdPet.Text
            .BtCk_InData = DataIni

            ''Entrada
            .BtCk_InGaiola = 1
            .BtCk_InCarrapatos = False
            .BtCk_InPulgas = False
            .BtCk_InNos = False
            .BtCk_InLesoesPele = False
            .BtCk_InOuvidoInfla = False
            .BtCk_InOlhosIrritados = False
            .BtCk_InOlhosSecrecao = False
            .BtCk_InColeira = False
            .BtCk_InColeiraAntPulga = False
            .BtCk_InColeiraRetratil = False
            .BtCk_InEnfocador = False
            .BtCk_InEscovaDt = False
            .BtCk_InPastaDt = False
            .BtCk_InGuia = False
            .BtCk_InPeitoral = False
            .BtCk_InOutros = ""

            '' Saida
            .BtCk_OutData = "01/01/1900"
            .BtCk_OutDesembolo = 1
            .BtCk_OutSubPelos = 1
            .BtCk_OutConfOuvidos = False
            .BtCk_OutConfUnhas = False
            .BtCk_OutOutros = ""
            .BtCk_OutFBanho = 1
            .BtCk_OutFSecagem = 1
            .BtCk_OutFTosa = 1
            .BtCk_St = ""
            .BtCk_IdAg = clsPront.Ag_Id
            .BtCk_Aplique = False
            .BtCk_Bandana = False
            .BtCk_Borboleta = False
            .BtCk_Borrachinha = False
            .BtCk_Cachecol = False
            .BtCk_Gola = False
            .BtCk_Gravata = False
            .BtCk_LacinhoQtd = 0
            .BtCk_PresilhaQtd = 0
            .BtCk_Scrunchie = False
            .BtCk_Tematico = False
            .BtCk_Item = 0 'cboServicos.SelectedItem
        End With
        ClsBanho.TipoOperacao = "I"
        ClsBanho.ChecksBanho()

    End Sub
    Private Sub btoAgendar_Click(sender As Object, e As EventArgs) Handles btoAgendar.Click
        ''Try

        CalcPeriodo()
        DataIni = txtInicio.Value
        MoveVar()

        '' insere no cotrole do Banho/Tosa
        MoveContratoBase()
        ClsBanho.TipoOperacao = "I"
        ClsBanho.BT_Contrato()
        Dim today As DateTime = txtInicio.Value
        For Ordem = 1 To ddOcorr.Text

            clsPront.ag_Ordem = Ordem
            clsPront.Insert_Agenda()

            '' insere no cheklist
            MoveCheckBase()
            '''proxima data
            '''
            If Per = 15 Then

                DataIni = today.AddDays(Per - 1)

            Else
                DataIni = today.AddDays(Per)
            End If

            today = DataIni
            clsPront.Ag_Data = DataIni

        Next

        ' String to search in.
        Dim searchChar As String = " "
        Dim testPos As Integer

        testPos = InStr(4, txtNomeCli.Text, searchChar, CompareMethod.Text)

        If testPos = 0 Then
            testPos = Len(txtNomeCli.Text)
        End If

        MsgZap = "Oi " & Mid(txtNomeCli.Text, 1, Trim(testPos)) & " " & vbCrLf _
            & "Agendamos para seu Pet " & Trim(txtNomePet.Text) & " o serviço : " & vbCrLf _
            & cboServicos.Text & vbCrLf _
            & "para a(s) data(s) e horário(s) a seguir : " & vbCrLf

        ClsFinan.Busca_Agenda_da_Os(txtOs.Text)
        MsgZap = MsgZap & ClsFinan.Agenda_da_OS

        MsgZap = MsgZap & vbCrLf & "Aguardamos." &
                vbCrLf & "Obrigado." &
                vbCrLf & clsUtil.emp_fanta ''"Clinica My Pets."

        SendWhatsApp(lblZap.Text, MsgZap)

        MessageBox.Show("Agendamento efetuado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        Me.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub SendWhatsApp(ByVal Nro As String, ByVal Msg As String)

        Nro = "55" & Nro

        System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" & Nro _
        & "&text=" & Uri.EscapeDataString(Msg))


    End Sub
    Private Sub MoveVar()

        'Ag_Id As Integer
        clsPront.ag_Os = txtOs.Text
        clsPront.Ag_Data = DataIni
        clsPront.ag_Hora = ddH.Text & ":" & ddM.Text
        clsPront.ag_idCli = txtIdCli.Text
        clsPront.ag_Cliente = txtNomeCli.Text
        clsPront.ag_Cpf = txtCpf.Text
        clsPront.ag_IdPet = txtIdPet.Text
        clsPront.ag_NomePet = txtNomePet.Text
        clsPront.ag_Contato = ""
        clsPront.ag_Email = ""
        clsPront.ag_Tipo = "Banho"
        clsPront.ag_Obs = txtObs.Text
        clsPront.ag_Funcionario = "Banho"

        clsPront.ag_St = "Agendado"

    End Sub
    Private Sub txtOs_LostFocus(sender As Object, e As EventArgs) Handles txtOs.LostFocus
        If IsNumeric(txtOs.Text) = True Then
            'Dim CLSMAT As Cls_Materiais

            'Dim ret As Boolean = False
            'ret = ClsFinan.Busca_Banho_da_Os(txtOs.Text)
            'If CLSMAT.IT_GRUPO = 3 Then
            '    MessageBox.Show("Não existe Serviço para agendamento. " & vbCr & "Verifique o Nro. da OS.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            '    LimpaForm()
            '    Exit Sub
            'End If

            LeOs()

        End If
    End Sub

    Private Sub txtOs_TextChanged(sender As Object, e As EventArgs) Handles txtOs.TextChanged

    End Sub

    Private Sub cboServicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicos.SelectedIndexChanged
        ddOcorr.Text = Format(cboServicos.SelectedValue, "#0")
    End Sub

    Private Sub ddOcorr_MouseUp(sender As Object, e As MouseEventArgs) Handles ddOcorr.MouseUp
        CalcTermino()
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodo.SelectedIndexChanged
        CalcTermino()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtIdPet_TextChanged(sender As Object, e As EventArgs) Handles txtIdPet.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class