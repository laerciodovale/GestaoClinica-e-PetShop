Imports System.Windows.Forms
Imports DataBase
Public Class frmBT
    Private ClsBanho As New Cls_Banho
    Private ClsTutor As New Cls_Cliente
    Private clsUtil As New Utils
    Public Id_Tut As Integer
    Public Os_Pesq As Integer
    Private ck As Boolean = False
    Private MsgZap As String
    Private Sub Limpa()

        ck = False

        'txtIdServ.Text = ""
        'lbIdTutor.Text = ""
        'lbNomePet.Text = ""
        'lbIdPet.Text = ""
        CboTipoBanho.Text = ""
        CboTipoBanho.ValueMember = 0
        chkTosaHig.Checked = False
        chkTosaMaq.Checked = False
        chkTosaPadraoRaca.Checked = False
        chkTosaTesoura.Checked = False
        chkTosaTrimming.Checked = False
        chkLaco.Checked = False
        chkBandana.Checked = False
        chkGravata.Checked = False
        chkAdesivo.Checked = False
        chkEnfeiteNao.Checked = False
        chkAlergiaPerfume.Checked = False
        chkAlergiaLamina.Checked = False
        chkAlergiaPerfume.Checked = False

        ''.Bt_Outros 
        txtPenteado.Text = ""
        txtIdServ.Text = 0

        ''Entrada
        txtGaiola_In.Text = 0

        rbCarrapatos_S.Checked = False
        rbPulgas_S.Checked = False
        rbPelosEmb_S.Checked = False
        rbLesaoPele_S.Checked = False
        rbOuvidosInfla_S.Checked = False
        rbOlhosIrrit_S.Checked = False
        rbSecreOlhos_S.Checked = False

        chkPColeira.Checked = False
        chkPColeiraAP.Checked = False
        chkPColeiraRetratil.Checked = False
        chkPEnfocador.Checked = False
        chkPEscova.Checked = False
        chkPPasta.Checked = False
        txtOutros.Text = ""

        '' Saida
        rbDesem_1.Checked = True
        rbSubPelo_1.Checked = True

        rbConfOuvidos_S.Checked = False
        rbConfUnhas_S.Checked = False

        txtObs_Out.Text = ""
        txtData.Text = ""
        txtIdBanho.Text = ""

        'Materiais usados
        ckAplique.Checked = False
        ckBandana.Checked = False
        ckBorboleta.Checked = False
        ckBorrachinha.Checked = False
        ckCachecol.Checked = False
        ckGola.Checked = False
        ckGravata.Checked = False
        ckScrunchie.Checked = False
        ckTematico.Checked = False
        txtLacos.Text = 0
        txtPresilhas.Text = 0

    End Sub
    Private Sub MoveContratoBase()
        Try
            With ClsBanho
                .Bt_Id = txtIdServ.Text
                .Bt_Tutor = lbIdTutor.Text
                .Bt_Pet = lbIdPet.Text
                .Bt_TpPcte = CboTipoBanho.Text
                .Bt_TpBanho = 0 'CboTipoBanho.ValueMember
                .Bt_TosaHig = chkTosaHig.Checked
                .Bt_TosaMaq = chkTosaMaq.Checked
                .Bt_TosaPadaoRaca = chkTosaPadraoRaca.Checked
                .Bt_TosaTesoura = chkTosaTesoura.Checked
                .Bt_TosaTrimming = chkTosaTrimming.Checked
                .Bt_Outros = ""
                .Bt_Penteado = txtPenteado.Text

                .Bt_AlergiaShampoo = chkAlergiaShampoo.Checked
                .Bt_AlergiaLamina = chkAlergiaLamina.Checked
                .Bt_AlergiaPerfume = chkAlergiaPerfume.Checked
                .Bt_AlergiaOutros = txtAlergiasOutras.Text
                .Bt_Enfeite = chkEnfeiteNao.Checked
                .Bt_ObsTutor = txtObsTutor.Text
                .Bt_ObsServico = txtObsServ.Text
                .Bt_EnfeiteAdesivo = chkAdesivo.Checked
                .Bt_EnfeiteBandana = chkBandana.Checked
                .Bt_EnfeiteGravata = chkGravata.Checked
                .Bt_EnfeiteLaco = chkLaco.Checked
                .Bt_EnfeiteNaoUsa = chkEnfeiteNao.Checked
                .Bt_Hidratacao = txtHidratacao.Text

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub MoveContratoTela()
        Try
            With ClsBanho
                txtIdServ.Text = .Bt_Id
                ' txtOs.Text = .Bt_OS
                lbIdTutor.Text = .Bt_Tutor
                lbIdPet.Text = .Bt_Pet
                CboTipoBanho.Text = .Bt_TpPcte
                'CboTipoBanho.ValueMember = .Bt_TpBanho
                txtPenteado.Text = .Bt_Penteado
                txtHidratacao.Text = .bt_hidratacao
                chkTosaHig.Checked = .Bt_TosaHig
                chkTosaMaq.Checked = .Bt_TosaMaq
                chkTosaPadraoRaca.Checked = .Bt_TosaPadaoRaca
                chkTosaTesoura.Checked = .Bt_TosaTesoura
                chkTosaTrimming.Checked = .Bt_TosaTrimming
                ''.Bt_Outros 
                chkLaco.Checked = .Bt_EnfeiteLaco
                chkBandana.Checked = .Bt_EnfeiteBandana
                chkGravata.Checked = .Bt_EnfeiteGravata
                chkAdesivo.Checked = .Bt_EnfeiteAdesivo
                chkEnfeiteNao.Checked = .Bt_EnfeiteNaoUsa

                chkAlergiaShampoo.Checked = .Bt_AlergiaShampoo
                chkAlergiaLamina.Checked = .Bt_AlergiaLamina
                chkAlergiaPerfume.Checked = .Bt_AlergiaPerfume
                txtAlergiasOutras.Text = .Bt_AlergiaOutros

                txtObsTutor.Text = .Bt_ObsTutor
                txtObsServ.Text = .Bt_ObsServico
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub MoveCheckBase()

        With ClsBanho
            .BtCk_Id = txtIdServ.Text

            ''Entrada
            .BtCk_InGaiola = txtGaiola_In.Text

            If rbCarrapatos_S.Checked = True Then
                .BtCk_InCarrapatos = True
            Else
                .BtCk_InCarrapatos = False
            End If

            If rbPulgas_S.Checked = True Then
                .BtCk_InPulgas = True
            Else
                .BtCk_InPulgas = False
            End If

            If rbPelosEmb_S.Checked = True Then
                .BtCk_InNos = True
            Else
                .BtCk_InNos = False
            End If

            If rbLesaoPele_S.Checked = True Then
                .BtCk_InLesoesPele = True
            Else
                .BtCk_InLesoesPele = False
            End If

            If rbOuvidosInfla_S.Checked = True Then
                .BtCk_InOuvidoInfla = True
            Else
                .BtCk_InOuvidoInfla = False
            End If

            If rbOlhosIrrit_S.Checked = True Then
                .BtCk_InOlhosIrritados = True
            Else
                .BtCk_InOlhosIrritados = False
            End If

            If rbSecreOlhos_S.Checked = True Then
                .BtCk_InOlhosSecrecao = True
            Else
                .BtCk_InOlhosSecrecao = False
            End If

            .BtCk_InColeira = chkPColeira.Checked
            .BtCk_InColeiraAntPulga = chkPColeiraAP.Checked
            .BtCk_InColeiraRetratil = chkPColeiraRetratil.Checked
            .BtCk_InEnfocador = chkPEnfocador.Checked
            .BtCk_InEscovaDt = chkPEscova.Checked
            .BtCk_InPastaDt = chkPPasta.Checked
            .BtCk_InOutros = txtOutros.Text

            '' Saida
            Dim Nro As Integer
            If rbDesem_1.Checked = True Then
                Nro = 1
            End If
            If rbDesem_2.Checked = True Then
                Nro = 2
            End If
            If rbDesem_3.Checked = True Then
                Nro = 3
            End If
            If rbDesem_4.Checked = True Then
                Nro = 4
            End If
            If rbDesem_5.Checked = True Then
                Nro = 5
            End If
            .BtCk_OutDesembolo = Nro

            If rbSubPelo_1.Checked = True Then
                Nro = 1
            End If
            If rbSubPelo_2.Checked = True Then
                Nro = 2
            End If
            If rbSubPelo_3.Checked = True Then
                Nro = 3
            End If
            If rbSubPelo_4.Checked = True Then
                Nro = 4
            End If
            If rbSubPelo_5.Checked = True Then
                Nro = 5
            End If
            .BtCk_OutSubPelos = Nro

            If rbConfOuvidos_S.Checked = True Then
                .BtCk_OutConfOuvidos = True
            Else
                .BtCk_OutConfOuvidos = False
            End If

            If rbConfUnhas_S.Checked = True Then
                .BtCk_OutConfUnhas = True
            Else
                .BtCk_OutConfUnhas = False
            End If

            .BtCk_OutOutros = txtObs_Out.Text
            .BtCk_OutFBanho = cboBanhista.SelectedValue
            .BtCk_OutFSecagem = cboSecagem.SelectedValue
            .BtCk_OutFTosa = cboTosador.SelectedValue
            .BtCk_OutData = Now

            '' materiais usados no banho
            .BtCk_Aplique = ckAplique.Checked
            .BtCk_Bandana = ckBandana.Checked
            .BtCk_Borboleta = ckBorboleta.Checked
            .BtCk_Borrachinha = ckBorrachinha.Checked
            .BtCk_Cachecol = ckCachecol.Checked
            .BtCk_Gola = ckGola.Checked
            .BtCk_Gravata = ckGravata.Checked
            .BtCk_Scrunchie = ckScrunchie.Checked
            .BtCk_Tematico = ckTematico.Checked

            .BtCk_LacinhoQtd = txtLacos.Text
            .BtCk_PresilhaQtd = txtPresilhas.Text

        End With
    End Sub
    Private Sub MoveCheckTela()

        With ClsBanho
            txtIdServ.Text = .BtCk_Id

            ''Entrada
            txtGaiola_In.Text = .BtCk_InGaiola

            rbCarrapatos_S.Checked = .BtCk_InCarrapatos
            rbPulgas_S.Checked = .BtCk_InPulgas
            rbPelosEmb_S.Checked = .BtCk_InNos
            rbLesaoPele_S.Checked = .BtCk_InLesoesPele
            rbOuvidosInfla_S.Checked = .BtCk_InOuvidoInfla
            rbOlhosIrrit_S.Checked = .BtCk_InOlhosIrritados
            rbSecreOlhos_S.Checked = .BtCk_InOlhosSecrecao

            chkPColeira.Checked = .BtCk_InColeira
            chkPColeiraAP.Checked = .BtCk_InColeiraAntPulga
            chkPColeiraRetratil.Checked = .BtCk_InColeiraRetratil
            chkPEnfocador.Checked = .BtCk_InEnfocador
            chkPEscova.Checked = .BtCk_InEscovaDt
            chkPPasta.Checked = .BtCk_InPastaDt
            txtOutros.Text = .BtCk_InOutros

            '' Saida
            Dim Nro As Integer
            Nro = .BtCk_OutDesembolo

            If Nro = 1 Then
                rbDesem_1.Checked = True
            End If
            If Nro = 2 Then
                rbDesem_2.Checked = True
            End If
            If Nro = 3 Then
                rbDesem_3.Checked = True
            End If
            If Nro = 4 Then
                rbDesem_4.Checked = True
            End If
            If Nro = 5 Then
                rbDesem_5.Checked = True
            End If

            Nro = .BtCk_OutSubPelos
            If Nro = 1 Then
                rbSubPelo_1.Checked = True
            End If
            If Nro = 2 Then
                rbSubPelo_2.Checked = True
            End If
            If Nro = 3 Then
                rbSubPelo_3.Checked = True
            End If
            If Nro = 4 Then
                rbSubPelo_4.Checked = True
            End If
            If Nro = 5 Then
                rbSubPelo_5.Checked = True
            End If

            rbConfOuvidos_S.Checked = .BtCk_OutConfOuvidos
            rbConfUnhas_S.Checked = .BtCk_OutConfUnhas

            txtObs_Out.Text = .BtCk_OutOutros

            cboBanhista.SelectedValue = .BtCk_OutFBanho
            cboSecagem.SelectedValue = .BtCk_OutFSecagem
            cboTosador.SelectedValue = .BtCk_OutFTosa

            '' materiais usados no banho
            ckAplique.Checked = .BtCk_Aplique
            ckBandana.Checked = .BtCk_Bandana
            ckBorboleta.Checked = .BtCk_Borboleta
            ckBorrachinha.Checked = .BtCk_Borrachinha
            ckCachecol.Checked = .BtCk_Cachecol
            ckGola.Checked = .BtCk_Gola
            ckGravata.Checked = .BtCk_Gravata
            ckScrunchie.Checked = .BtCk_Scrunchie
            ckTematico.Checked = .BtCk_Tematico

            txtLacos.Text = .BtCk_LacinhoQtd
            txtPresilhas.Text = .BtCk_PresilhaQtd

        End With
    End Sub

    Private Sub frmBT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdBanho.Text = ""
        '' Limpa()
        '' banhos/pacotes da OS
        txtOs.Text = Os_Pesq
        Dim dt As DataTable
        dt = ClsBanho.Sel_Servicos_Pet(lbIdPet.Text)
        dgContratado.DataSource = dt
        dgContratado.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgContratado.Columns(0).HeaderText = "Descrição dos Servicos da OS"
        dgContratado.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgContratado.Columns(1).HeaderText = " OS"

        ''Dados do tutor
        Le_Tutor()

        ''pests do tutor
        Le_contrato()

        '' Funcionarios da Estetica
        Dim clsFunc As New cls_Func
        Dim dtF As DataTable = clsFunc.LeFuncEstetica()

        cboBanhista.DisplayMember = "funome"
        cboBanhista.ValueMember = "fuid"
        cboBanhista.DataSource = dtF
        Dim dtF2 As DataTable = clsFunc.LeFuncEstetica()
        cboSecagem.DisplayMember = "funome"
        cboSecagem.ValueMember = "fuid"
        cboSecagem.DataSource = dtF2
        Dim dtF3 As DataTable = clsFunc.LeFuncEstetica()
        cboTosador.DisplayMember = "funome"
        cboTosador.ValueMember = "fuid"
        cboTosador.DataSource = dtF3

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        MoveContratoBase()
        ClsBanho.TipoOperacao = "I"
        ClsBanho.BT_Contrato()
        MessageBox.Show("Inclusão efetuada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Le_contrato()
    End Sub

    Private Sub btoAtualiza_Out_Click(sender As Object, e As EventArgs) Handles btoAtualiza_Out.Click
        Dim pergunta As DialogResult = MessageBox.Show("Deseja finalisar o Item da OS ??" & vbCr & vbCr & "Se você deseja finalizar não havera mais forma de editar o Item. ", "Nota importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        ClsBanho.BtCk_St = ""

        ' If pergunta = DialogResult.Yes Then
        ClsBanho.BtCk_St = "Finalizado"

        Dim ret As Integer
        ret = ClsBanho.Le_CountSt(txtOs.Text)

        If ret <= 1 Then
            ClsBanho.BtCk_St = "Encerrado"
            ClsBanho.UpDateStDaOs(txtOs.Text, ClsBanho.BtCk_St)
        End If

        ClsBanho.UpDateSt(txtOs.Text, txtData.Text, ClsBanho.BtCk_St, txtIdBanho.Text)

        If Len(Trim(lblZap.Text)) <> 0 Then
            EnviaZap()
        End If

        ' End If

        MoveCheckBase()
        ClsBanho.TipoOperacao = "U"
        ClsBanho.ChecksBanho()

        ClsBanho.IU_Meta(txtData.Text)

        Limpa()
        Le_contrato()

        TabControl1.SelectedIndex = 0
        If ClsBanho.BtCk_St = "Finalizado" Then
            MessageBox.Show("Serviço setado como Finalizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
        If ClsBanho.BtCk_St = "Encerrado" Then
            MessageBox.Show("Ocorreu o encerramento desta OS.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Sub
    Private Sub meta_do_banho()

    End Sub
    Private Sub EnviaZap()
        ' String to search in.
        Dim searchChar As String = " "
        Dim testPos As Integer

        testPos = InStr(4, lbNomeTutor.Text, searchChar, CompareMethod.Text)

        If testPos = 0 Then
            testPos = Len(lbNomeTutor.Text)
        End If

        MsgZap = "Oi " & Mid(lbNomeTutor.Text, 1, Trim(testPos)) & " " & vbCrLf _
            & "Viemos te dizer que o serviço do(a)  " & Trim(lbNomePet.Text) & " já foi finalizado." & vbCrLf

        If ClsBanho.BtCk_St = "Encerrado" Then
            MsgZap = MsgZap & "Aproveitamos também para te informar que a Ordem de Serviço nro: " _
                & txtOs.Text & " encerrou." & vbCrLf _
                & "Esperamos que nossos serviços tenha agradado você." & vbCrLf _
                & "Caso não, entre em contato com a nossa gerência." & vbCrLf
        End If

        MsgZap = MsgZap & "Obrigado." & vbCrLf & clsUtil.emp_fanta '"My Pets Banho e Tosa."


        SendWhatsApp(lblZap.Text, MsgZap)

    End Sub
    Private Sub SendWhatsApp(ByVal Nro As String, ByVal Msg As String)

        Nro = "55" & Nro

        System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" & Nro _
        & "&text=" & Uri.EscapeDataString(Msg))


    End Sub
    Private Sub btoAtualizar_In_Click(sender As Object, e As EventArgs) Handles btoAtualizar_In.Click
        If IsNumeric(txtGaiola_In.Text) = False Then
            MessageBox.Show("Informação da gaiola não informada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtGaiola_In.Focus()
            Exit Sub
        End If

        ClsBanho.BtCk_St = ""
        MoveCheckBase()
        ClsBanho.TipoOperacao = "U"
        ClsBanho.ChecksBanho()
        Limpa()
        Le_contrato()
        TabControl1.SelectedIndex = 0

    End Sub
    Private Sub Le_Tutor()
        ClsTutor.BuscaCliente("Sp_Cliente_Sel", lbIdTutor.Text)

        If Len(Trim(ClsTutor.Cl_Fixo)) > 0 Then
            lblZap.Text = ClsTutor.Cl_Fixo
        Else
            lblZap.Text = 0
        End If
    End Sub
    Private Sub Le_contrato()
        If txtOs.Text = 0 Then
            Exit Sub

        End If
        ClsBanho.LeContrato("TD", 0, txtOs.Text, 0)
        MoveContratoTela()

        ''checkin e checkou lancados para a os
        Dim dt As DataTable
        dt = ClsBanho.LeChecks(txtOs.Text)
        dgChecks.DataSource = dt

        dgChecks.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgChecks.Columns(0).HeaderText = "ID"
        dgChecks.Columns(0).Width = 4
        dgChecks.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgChecks.Columns(1).HeaderText = "OS"
        dgChecks.Columns(1).Width = 4
        dgChecks.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgChecks.Columns(2).HeaderText = "Seq."
        dgChecks.Columns(2).Width = 4
        dgChecks.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgChecks.Columns(3).HeaderText = "Data Agendada"
        dgChecks.Columns(3).Width = 30
        dgChecks.Columns(3).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgChecks.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgChecks.Columns(4).HeaderText = "Situação"
        dgChecks.Columns(4).Width = 30

    End Sub
    Private Sub cboPetsTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPetsTutor.SelectedIndexChanged

        Le_contrato() ''dados do contrato 

    End Sub

    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click
        Try
            MoveContratoBase()
            ClsBanho.TipoOperacao = "U"
            ClsBanho.BT_Contrato()
            MessageBox.Show("Alteração efetuada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Le_contrato()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgCaixa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgChecks.CellContentClick
        ck = True
        ''dados do contrato 
        ClsBanho.LeCeckID(dgChecks.CurrentRow.Cells(0).Value.ToString())
        txtData.Text = dgChecks.CurrentRow.Cells(3).Value.ToString()
        txtIdBanho.Text = dgChecks.CurrentRow.Cells(0).Value.ToString()
        MoveCheckTela()
        TabControl1.SelectedIndex = 1

    End Sub
    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If IsNumeric(txtIdBanho.Text) = False Then
            MessageBox.Show("Não ocorreu a seleçao do Item da OS para editar os dados." & vbCr & "Favor selecionar o item a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TabControl1.SelectedIndex = 0
        End If
    End Sub

    Private Sub dgContratado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContratado.CellContentClick
        txtOs.Text = dgContratado.CurrentRow.Cells(1).Value.ToString()
        Le_contrato()

    End Sub

End Class