Imports DataBase
Imports System.Drawing
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmAnaminese
    Private clsPront As New Cls_Prontuario
    Private clsAnami As New cls_Anaminese
    Public Veterinario As Integer

#Region "Consulta"
    Private Sub LimpaForm()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                CType(ctl, TextBox).Clear()
            ElseIf TypeOf ctl Is ComboBox Then
                CType(ctl, ComboBox).Text = String.Empty
            ElseIf TypeOf ctl Is CheckBox Then
                CType(ctl, CheckBox).Checked = False
            ElseIf TypeOf ctl Is RadioButton Then
                CType(ctl, RadioButton).Checked = False

            End If
        Next
        dtp.Value = Now
        dtpVacinaData.Value = Now
        dtpEctoData.Value = Now
        dtpEndoData.Value = Now

        mcRetorno.SelectionStart = Now
        mcRetorno.SelectionEnd = Now

        lbId.Text = 0
        txtFc.Text = 0
        txtResp.Text = 0
        txtTemp.Text = 0
        txtPA.Text = 0
        ''Me.dgAtendimentos.DefaultCellStyle.Font = New Font("Tahoma", 12)
    End Sub
    Private Sub LimpaDados()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                ''CType(ctl, TextBox).Clear()
            ElseIf TypeOf ctl Is ComboBox Then
                CType(ctl, ComboBox).Text = String.Empty
            ElseIf TypeOf ctl Is CheckBox Then
                CType(ctl, CheckBox).Checked = False
            ElseIf TypeOf ctl Is RadioButton Then
                CType(ctl, RadioButton).Checked = False

            End If
        Next
        dtp.Value = Now
        dtpVacinaData.Value = Now
        dtpEctoData.Value = Now
        dtpEndoData.Value = Now

        mcRetorno.SelectionStart = Now
        mcRetorno.SelectionEnd = Now

        lbId.Text = 0
        txtSuVolume.Text = ""
        txtScOutros.Text = ""
        txtAlergiaMedic.Text = ""
        txtAmbOutros.Text = ""
        txtOlOutros.Text = ""
        txtOuOutros.Text = ""
        txtPOutros.Text = ""
        txtScOutros.Text = ""
        txtSdOutros.Text = ""
        txtSlOutros.Text = ""
        txtSnOutros.Text = ""
        txtSuOutros.Text = ""
        txtTemp.Text = 38
        txtTratamento.Text = ""
        txtUsoMedicacao.Text = ""
        txtUsoSupl.Text = ""
        txtVacinaObs.Text = ""
        txtDoeAnt.Text = ""
        txtDoeAtu.Text = ""
        txtEctoObs.Text = ""
        txtEndoObs.Text = ""
        txtVacinaObs.Text = ""
        txtFc.Text = 0
        txtResp.Text = 0
        txtTemp.Text = 0
        txtPA.Text = 0

    End Sub
    Private Sub frmAnaminese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpaForm()
        LimpaReceita()

        If md_Id_Pet <= 0 Then
            MessageBox.Show("Pet não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If

        lbIdPet.Text = md_Id_Pet
        lbId.Text = md_Id_Consulta

        LePet()
        LeDados()
        LeConsultas()
        BuscaReceitas()

        '        BuscaVacinas()
        'BuscaImagens()

        Me.Size = New Size(1050, 825)
        Me.Location = New Point(60, 25)

    End Sub
    Private Sub LeDados()
        Try
            If lbId.Text > 0 Then
                clsAnami.Tp = 4
                clsAnami.anami_Pet = lbIdPet.Text
                clsAnami.anami_ID = lbId.Text
                clsAnami.LeAnaminese()

                Move_BT()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub LePet()
        Try
            Dim Util As New DataBase.Utils
            Dim objPet As New cls_Anaminese
            With objPet
                .Pet_Id = md_Id_Pet
                .BuscaPet(md_Id_Pet)

                lbIdPet.Text = .Pet_Id
                lbNomePet.Text = UCase(.Pet_Nome)

                If Len(Trim(.Pet_Foto)) > 0 Then
                    pic_Pet.Image = Util.AbrirArquivoBase64(.Pet_Foto)
                Else
                    pic_Pet.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Move_TB()
        clsAnami.anami_ID = lbId.Text
        clsAnami.anami_Pet = lbIdPet.Text
        clsAnami.anami_Data = Format(dtp.Value, "yyyy/MM/dd")
        clsAnami.anami_Hora = Format(Now, "hh:mm")
        clsAnami.anami_Ret = False
        clsAnami.anami_DoeAnt = txtDoeAnt.Text
        clsAnami.anami_DoeAtu = txtDoeAtu.Text
        clsAnami.anami_SdVomito = CkSdVomito.Checked
        clsAnami.anami_SdRegurgitacao = ckSdRegurgitacao.Checked
        clsAnami.anami_SdDiarreia = ckSdDiarreia.Checked
        clsAnami.anami_SdApetite = ckSdApetite.Checked
        clsAnami.anami_SdAgua = ckSdAgua.Checked
        clsAnami.anami_SdOutros = txtSdOutros.Text
        clsAnami.anami_SuUrinaNormal = ckSuUrinaNormal.Checked
        clsAnami.anami_SuVolume = txtSuVolume.Text
        clsAnami.anami_SuDificuldade = ckSuDificuldade.Checked
        clsAnami.anami_SuSecrecao = ckSuSecrecao.Checked
        clsAnami.anami_SuOutros = txtSuOutros.Text
        clsAnami.anami_ScTosse = ckScTosse.Checked
        clsAnami.anami_ScCansaco = ckScCansaco.Checked
        clsAnami.anami_ScSecreNasal = ckScSecreNasal.Checked
        clsAnami.anami_ScOutros = txtScOutros.Text
        clsAnami.anami_SnConvulcao = ckSnConvulcao.Checked
        clsAnami.anami_SnInclinacao = ckSnInclinacao.Checked
        clsAnami.anami_SnAtaxia = ckSnAtaxia.Checked
        clsAnami.anami_SnOutros = txtSnOutros.Text
        clsAnami.anami_SlDificuldade = ckSlDificuldade.Checked
        clsAnami.anami_SlAltPostura = ckSlAltPostura.Checked
        clsAnami.anami_SlFraturas = ckSlFraturas.Checked
        clsAnami.anami_SlOutros = txtSlOutros.Text
        clsAnami.anami_PPurido = ckPPurido.Checked
        clsAnami.anami_PEctoparasita = ckPEctoparasita.Checked
        clsAnami.anami_PQuedaPelo = ckPQuedaPelo.Checked
        clsAnami.anami_PAlopecia = ckPAlopecia.Checked
        clsAnami.anami_POutros = txtPOutros.Text
        clsAnami.anami_OlSecrecao = ckOlSecrecao.Checked
        clsAnami.anami_OlDefict = ckOlDefict.Checked
        clsAnami.anami_OlPrurido = ckOlPrurido.Checked
        clsAnami.anami_OlOutros = txtOlOutros.Text
        clsAnami.anami_OuPurido = ckOlPrurido.Checked
        clsAnami.anami_OuSecrecao = ckOuSecreção.Checked
        clsAnami.anami_OuOutros = txtOuOutros.Text
        clsAnami.anami_AmbRural = ckAmbRural.Checked
        clsAnami.anami_AmbUrbamo = ckAmbUrbano.Checked
        clsAnami.anami_AmbAcessoRua = ckAmbAcessoRua.Checked
        clsAnami.anami_AmbOutros = txtAmbOutros.Text
        clsAnami.anami_Contactantes = txtContactantes.Text
        clsAnami.anami_ProdToxico = txtProdToxico.Text
        clsAnami.anami_AlRacaoSeca = ckAlRacaoSeca.Checked
        clsAnami.anami_AlRacaoUmida = ckAlRacaoUmida.Checked
        clsAnami.anami_AlRacaoPetisco = ckAlRacaoPetisco.Checked
        clsAnami.anami_AlNatCOsso = ckAlNatCOsso.Checked
        clsAnami.anami_AlNatSOsso = ckAlNatSOsso.Checked
        clsAnami.anami_AlNatCozida = ckAlNatCozida.Checked
        clsAnami.anami_Vacina = ckVacina.Checked
        clsAnami.anami_VacinaData = dtpVacinaData.Value
        clsAnami.anami_VacinaObs = txtVacinaObs.Text
        clsAnami.anami_Endo = ckEndo.Checked
        clsAnami.anami_EndoData = dtpEndoData.Value
        clsAnami.anami_EndoObs = txtEndoObs.Text
        clsAnami.anami_Ecto = ckEcto.Checked
        clsAnami.anami_EctoData = dtpEctoData.Value
        clsAnami.anami_EctoObs = txtEctoObs.Text
        clsAnami.anami_AlergiaMedic = txtAlergiaMedic.Text
        clsAnami.anami_UsoMedicacao = txtUsoMedicacao.Text
        clsAnami.anami_UsoSupl = txtUsoSupl.Text
        clsAnami.anami_Cirurgias = txtCirurgias.Text
        clsAnami.anami_Exames = txtExames.Text

        If rbNegativo.Checked = False Then
            clsAnami.anami_FIVFeLV = False
        Else
            clsAnami.anami_FIVFeLV = True
        End If

        clsAnami.anami_PcHidratacao = True
        clsAnami.anami_PcGlicemia = True
        clsAnami.anami_PcMucosa = True
        clsAnami.anami_PcPelagem = True
        clsAnami.anami_PcFC = txtFc.Text
        clsAnami.anami_PcFR = txtResp.Text
        clsAnami.anami_PcCavOral = True
        clsAnami.anami_PcCondAuditivo = True
        clsAnami.anami_PcTemp = txtTemp.Text
        clsAnami.anami_PcPressao = txtPA.Text
        clsAnami.anami_PcLinfonodos = True
        clsAnami.anami_PcDeambulacao = True
        clsAnami.anami_PcPropriocepcao = True
        clsAnami.anami_PcPalpacao = True
        clsAnami.anami_PcCavNasal = True
        clsAnami.anami_PcOfitalmo = True

        If rbPcHidratacaoN.Checked = False Then
            clsAnami.anami_PcHidratacao = False
        End If
        If rbPcGlicemiaN.Checked = False Then
            clsAnami.anami_PcGlicemia = False
        End If
        If rbPcMucosaN.Checked = False Then
            clsAnami.anami_PcMucosa = False
        End If
        If rbPcPelagemN.Checked = False Then
            clsAnami.anami_PcPelagem = False
        End If
        If rbPcCavOralN.Checked = False Then
            clsAnami.anami_PcCavOral = False
        End If
        If rbPcCondAuditivoN.Checked = False Then
            clsAnami.anami_PcCondAuditivo = False
        End If
        If rbPcLinfonodosN.Checked = False Then
            clsAnami.anami_PcLinfonodos = False
        End If
        If rbPcDeambulacaoN.Checked = False Then
            clsAnami.anami_PcDeambulacao = False
        End If
        If rbPcPropriocepcaoN.Checked = False Then
            clsAnami.anami_PcPropriocepcao = False
        End If
        If rbPcPalpacaoN.Checked = False Then
            clsAnami.anami_PcPalpacao = False
        End If
        If rbPcCavNasalN.Checked = False Then
            clsAnami.anami_PcCavNasal = True
        End If
        If rbPcOfitalmoN.Checked = False Then
            clsAnami.anami_PcOfitalmo = False
        End If

        clsAnami.anami_Conduta = txtConduta.Text
        clsAnami.anami_Tratamento = txtTratamento.Text
        clsAnami.anami_Diagnostico = txtDiagnostico.Text
        clsAnami.anami_Prognostico = txtPrognostico.Text



    End Sub
    Private Sub Move_BT()
        lbId.Text = clsAnami.anami_ID
        lbIdPet.Text = clsAnami.anami_Pet
        dtp.Value = Format(clsAnami.anami_Data, "yyyy/MM/dd")
        'clsAnami.anami_Hora = Format(Now, "hh:mm")
        opRetorno.Checked = clsAnami.anami_Ret
        txtDoeAnt.Text = clsAnami.anami_DoeAnt
        txtDoeAtu.Text = clsAnami.anami_DoeAtu
        CkSdVomito.Checked = clsAnami.anami_SdVomito
        ckSdRegurgitacao.Checked = clsAnami.anami_SdRegurgitacao
        ckSdDiarreia.Checked = clsAnami.anami_SdDiarreia
        ckSdApetite.Checked = clsAnami.anami_SdApetite
        ckSdAgua.Checked = clsAnami.anami_SdAgua
        txtSdOutros.Text = clsAnami.anami_SdOutros
        ckSuUrinaNormal.Checked = clsAnami.anami_SuUrinaNormal
        txtSuVolume.Text = clsAnami.anami_SuVolume
        ckSuDificuldade.Checked = clsAnami.anami_SuDificuldade
        ckSuSecrecao.Checked = clsAnami.anami_SuSecrecao
        txtSuOutros.Text = clsAnami.anami_SuOutros
        ckScTosse.Checked = clsAnami.anami_ScTosse
        ckScCansaco.Checked = clsAnami.anami_ScCansaco
        ckScSecreNasal.Checked = clsAnami.anami_ScSecreNasal
        txtScOutros.Text = clsAnami.anami_ScOutros
        ckSnConvulcao.Checked = clsAnami.anami_SnConvulcao
        ckSnInclinacao.Checked = clsAnami.anami_SnInclinacao
        ckSnAtaxia.Checked = clsAnami.anami_SnAtaxia
        txtSnOutros.Text = clsAnami.anami_SnOutros
        ckSlDificuldade.Checked = clsAnami.anami_SlDificuldade
        ckSlAltPostura.Checked = clsAnami.anami_SlAltPostura
        ckSlFraturas.Checked = clsAnami.anami_SlFraturas
        txtSlOutros.Text = clsAnami.anami_SlOutros
        ckPPurido.Checked = clsAnami.anami_PPurido
        ckPEctoparasita.Checked = clsAnami.anami_PEctoparasita
        ckPQuedaPelo.Checked = clsAnami.anami_PQuedaPelo
        ckPAlopecia.Checked = clsAnami.anami_PAlopecia
        txtPOutros.Text = clsAnami.anami_POutros
        ckOlSecrecao.Checked = clsAnami.anami_OlSecrecao
        ckOlDefict.Checked = clsAnami.anami_OlDefict
        ckOlPrurido.Checked = clsAnami.anami_OlPrurido
        txtOlOutros.Text = clsAnami.anami_OlOutros
        ckOlPrurido.Checked = clsAnami.anami_OuPurido
        ckOuSecreção.Checked = clsAnami.anami_OuSecrecao
        txtOuOutros.Text = clsAnami.anami_OuOutros
        ckAmbRural.Checked = clsAnami.anami_AmbRural
        ckAmbUrbano.Checked = clsAnami.anami_AmbUrbamo
        ckAmbAcessoRua.Checked = clsAnami.anami_AmbAcessoRua
        txtAmbOutros.Text = clsAnami.anami_AmbOutros
        txtContactantes.Text = clsAnami.anami_Contactantes
        txtProdToxico.Text = clsAnami.anami_ProdToxico
        ckAlRacaoSeca.Checked = clsAnami.anami_AlRacaoSeca
        ckAlRacaoUmida.Checked = clsAnami.anami_AlRacaoUmida
        ckAlRacaoPetisco.Checked = clsAnami.anami_AlRacaoPetisco
        ckAlNatCOsso.Checked = clsAnami.anami_AlNatCOsso
        ckAlNatSOsso.Checked = clsAnami.anami_AlNatSOsso
        ckAlNatCozida.Checked = clsAnami.anami_AlNatCozida
        ckVacina.Checked = clsAnami.anami_Vacina

        If clsAnami.anami_VacinaData.Year > 1 Then
            dtpVacinaData.Value = clsAnami.anami_VacinaData
        Else
            dtpVacinaData.Value = Now
        End If

        txtVacinaObs.Text = clsAnami.anami_VacinaObs
        ckEndo.Checked = clsAnami.anami_Endo
        If clsAnami.anami_EndoData.Year > 1 Then
            dtpEndoData.Value = clsAnami.anami_EndoData
        Else
            dtpEndoData.Value = Now
        End If
        txtEndoObs.Text = clsAnami.anami_EndoObs
        ckEcto.Checked = clsAnami.anami_Ecto

        If clsAnami.anami_EctoData.Year > 1 Then
            dtpEctoData.Value = clsAnami.anami_EctoData
        Else
            dtpEctoData.Value = Now
        End If
        txtEctoObs.Text = clsAnami.anami_EctoObs
        txtAlergiaMedic.Text = clsAnami.anami_AlergiaMedic
        txtUsoMedicacao.Text = clsAnami.anami_UsoMedicacao
        txtUsoSupl.Text = clsAnami.anami_UsoSupl
        txtCirurgias.Text = clsAnami.anami_Cirurgias
        txtExames.Text = clsAnami.anami_Exames

        If clsAnami.anami_FIV = True Then

            If clsAnami.anami_FIVFeLV = True Then
                rbNegativo.Checked = False
                rbPositivo.Checked = True
            Else
                rbNegativo.Checked = True
                rbPositivo.Checked = False
            End If

        Else

            rbNegativo.Checked = False
            rbPositivo.Checked = False

        End If

        txtFc.Text = clsAnami.anami_PcFC
        txtResp.Text = clsAnami.anami_PcFR
        txtTemp.Text = clsAnami.anami_PcTemp
        txtPA.Text = clsAnami.anami_PcPressao
        rbPcHidratacaoA.Checked = True
        rbPcGlicemiaA.Checked = True
        rbPcMucosaA.Checked = True
        rbPcPelagemA.Checked = True
        rbPcCavOralA.Checked = True
        rbPcCondAuditivoa.Checked = True
        rbPcLinfonodosA.Checked = True
        rbPcDeambulacaoA.Checked = True
        rbPcPropriocepcaoA.Checked = True
        rbPcPalpacaoA.Checked = True
        rbPcCavNasalA.Checked = True
        rbPcOfitalmoA.Checked = True

        rbPcHidratacaoN.Checked = clsAnami.anami_PcHidratacao
        rbPcGlicemiaN.Checked = clsAnami.anami_PcGlicemia
        rbPcMucosaN.Checked = clsAnami.anami_PcMucosa
        rbPcPelagemN.Checked = clsAnami.anami_PcPelagem
        rbPcCavOralN.Checked = clsAnami.anami_PcCavOral
        rbPcCondAuditivoN.Checked = clsAnami.anami_PcCondAuditivo
        rbPcLinfonodosN.Checked = clsAnami.anami_PcLinfonodos
        rbPcDeambulacaoN.Checked = clsAnami.anami_PcDeambulacao
        rbPcPropriocepcaoN.Checked = clsAnami.anami_PcPropriocepcao
        rbPcPalpacaoN.Checked = clsAnami.anami_PcPalpacao
        rbPcCavNasalN.Checked = clsAnami.anami_PcCavNasal
        rbPcOfitalmoN.Checked = clsAnami.anami_PcOfitalmo

        txtConduta.Text = clsAnami.anami_Conduta
        txtTratamento.Text = clsAnami.anami_Tratamento
        txtDiagnostico.Text = clsAnami.anami_Diagnostico
        txtPrognostico.Text = clsAnami.anami_Prognostico

    End Sub

    Private Sub btnIncluirConsulta_Click(sender As Object, e As EventArgs) Handles btnIncluirConsulta.Click
        Try
            Move_TB()

            ''EFETUA A INCLUSAO
            clsAnami.Tp = "1"
            clsAnami.CRUD_Anaminese()
            MessageBox.Show("Consulta cadastrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '' LimpaTelaConsulta()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BuscaConsulta()

        clsAnami.anami_ID = lbId.Text
        LeDados()

        mcRetorno.SelectionStart = Date.Now.AddDays(7)
        mcRetorno.SelectionEnd = Date.Now.AddDays(7)

        If Weekday(mcRetorno.SelectionStart) = 6 Then
            mcRetorno.SelectionStart = Date.Now.AddDays(8)
            mcRetorno.SelectionEnd = Date.Now.AddDays(8)
        End If

        If Weekday(mcRetorno.SelectionStart) = 7 Then
            mcRetorno.SelectionStart = Date.Now.AddDays(9)
            mcRetorno.SelectionEnd = Date.Now.AddDays(9)
        End If

        btnAlterarConsulta.Enabled = False
        btnExcluirConsulta.Enabled = False

    End Sub

    Private Sub dgAtendimentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAtendimentos.CellContentClick

        clsAnami.anami_ID = dgAtendimentos.CurrentRow.Cells(3).Value.ToString()
        lbId.Text = dgAtendimentos.CurrentRow.Cells(3).Value.ToString()
        lbIdPet.Text = md_Id_Pet

        opConsulta.Checked = True
        LeDados()

        If clsAnami.anami_Ret = True Then
            opRetorno.Checked = True
        End If

        btnAlterarConsulta.Enabled = True
        btnExcluirConsulta.Enabled = True

        txtDoeAnt.Focus()
    End Sub
    Private Sub LeConsultas()

        Dim dtg As DataTable
        dtg = clsAnami.BuscaConsultasPet(lbIdPet.Text)
        dgAtendimentos.DataSource = dtg

        dgAtendimentos.Columns(0).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(0).HeaderText = " Data "
        dgAtendimentos.Columns(0).Width = 10
        dgAtendimentos.Columns(1).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(1).HeaderText = " hora "
        dgAtendimentos.Columns(1).Width = 10
        dgAtendimentos.Columns(1).DefaultCellStyle.Format = "HH:mm"
        dgAtendimentos.Columns(2).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(2).HeaderText = "Ret."
        dgAtendimentos.Columns(2).Width = 10
        dgAtendimentos.Columns(3).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(3).HeaderText = " ID "
        dgAtendimentos.Columns(3).Width = 10

    End Sub

    Private Sub btnAlterarConsulta_Click(sender As Object, e As EventArgs) Handles btnAlterarConsulta.Click
        Try
            If lbId.Text = 0 Then
                MessageBox.Show("Id da Consulta não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Move_TB()
            '    clsPront.UpDate_Consulta()

            clsAnami.Tp = 2
            clsAnami.CRUD_Anaminese()
            MessageBox.Show("Alteração da Consulta efetuada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TabControl1.SelectedIndex = 0

            LimpaDados()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnAlterarConsulta.Enabled = False
        btnExcluirConsulta.Enabled = False

    End Sub

    Private Sub btnExcluirConsulta_Click(sender As Object, e As EventArgs) Handles btnExcluirConsulta.Click
        Try
            If lbId.Text = 0 Then
                MessageBox.Show("Id da Consulta não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja deltear os registros desta consulta ??", "Exclusão de Consulta",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button1, 0)
            If StrMsg = 6 Then

                Move_TB()
                clsAnami.Tp = 3
                clsAnami.CRUD_Anaminese()
                MessageBox.Show("Exclusão da Consulta efetuada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TabControl1.SelectedIndex = 0

                LeConsultas()

                lbId.Text = 0

                LimpaDados()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnAlterarConsulta.Enabled = False
        btnExcluirConsulta.Enabled = False
    End Sub

#End Region
#Region "RECEITA"
    Private Sub LimpaReceita()
        lbCountItem.Text = 0
        txtFarmaco.Text = ""
        txtRecomendacao.Text = ""
        txtIdReceita.Text = 0
        dgReceita.DataSource = Nothing
        dgReceita.Rows.Clear()

        btnImpirmirReceita.Enabled = False
        txtFarmaco.Focus()
    End Sub
    Private Sub BuscaReceitas()

        clsPront.Rc_Ani = md_Id_Pet
        If clsPront.Rc_Ani = 0 Then
            MessageBox.Show("Código do animal não informado.", "Nota importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
        Else
            ''Preenche A ListBox
            Dim dt As DataTable = clsPront.LeReceitaAv()

            lstReceitasAv.DisplayMember = "RCDT"
            lstReceitasAv.ValueMember = "RcNss"
            lstReceitasAv.DataSource = dt

        End If

    End Sub
    Private Sub PreencheLstReceita()
        ''Preenche A ListBox
        Dim dt As DataTable
        dt = clsPront.LeReceitaAv()
        lstReceitasAv.DisplayMember = "RCDT"
        lstReceitasAv.ValueMember = "RCnss"
        lstReceitasAv.DataSource = dt
    End Sub
    Private Sub ImprimirReceita(ByVal os_receita As Integer)
        Try
            Dim Caminho As String
            Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\CryReceita.rpt"

            If ckEspecial.Checked = True Then
                Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryReceitaEspecial.rpt"
            End If

            ''envia direto para impressora
            'Using Relatorio = New ReportDocument()

            '    Relatorio.Load(Caminho)
            '    Relatorio.ParameterFields("nroReceita").CurrentValues.AddValue(Convert.ToInt32(txt_Id_Paciente.Text))

            '    Using Crystal = New cryReceita()

            '        Using Dialogo = New PrintDialog()
            '            If Dialogo.ShowDialog() = DialogResult.OK Then
            '                Crystal.PrintToPrinter(Dialogo.PrinterSettings, Dialogo.PrinterSettings.DefaultPageSettings, False)
            '            End If
            '        End Using

            '    End Using

            'End Using

            'Exit Sub

            frmCrystal.Show()

            Dim CR As New ReportDocument
            CR.Load(Caminho)

            Dim crParameterDiscreteValue As ParameterDiscreteValue
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldLocation As ParameterFieldDefinition
            Dim crParameterValues As ParameterValues

            CR.SetDatabaseLogon("sa", "nunsey", "SrvMyPets", "CadVet")

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
            crParameterFieldLocation = crParameterFieldDefinitions.Item("nroReceita")
            crParameterValues = crParameterFieldLocation.CurrentValues
            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterDiscreteValue.Value = os_receita

            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

            'Dim PrintDoc As System.Drawing.Printing.PrintDocument = New System.Drawing.Printing.PrintDocument()
            'PrintDoc.PrinterSettings.PrinterName = "NPID3C10A (HP LaserJet M102w)"

            'Dim PkSize As System.Drawing.Printing.PaperSize = New System.Drawing.Printing.PaperSize()

            'For intPaperSize As Integer = 0 To PrintDoc.PrinterSettings.PaperSizes.Count - 1

            '    If PrintDoc.PrinterSettings.PaperSizes.Item(intPaperSize).PaperName = "Receita" Then
            '        PkSize = PrintDoc.PrinterSettings.PaperSizes.Item(intPaperSize)
            '        Exit For
            '    End If
            'Next

            frmCrystal.crtVwGeral.ReportSource = CR
            frmCrystal.crtVwGeral.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub LeReceita()
        Dim dt As DataTable
        dt = clsPront.BuscaReceita
        dgReceita.DataSource = dt

        If dt.Rows.Count > 0 Then
            ckEspecial.Checked = Me.dgReceita.CurrentRow.Cells(0).Value.ToString()
            ConfigDataGrid()

            btnImpirmirReceita.Enabled = True
        Else
            txtIdReceita.Text = 0
        End If
    End Sub
    Private Sub btoLimparReceita_Click(sender As Object, e As EventArgs) Handles btoLimparReceita.Click
        LimpaReceita()
    End Sub

    Private Sub btoIncluirReceita_Click(sender As Object, e As EventArgs) Handles btoIncluirReceita.Click
        If lbIdPet.Text = 0 Then
            MessageBox.Show("Código do animal não informado.", "Nota importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
            Exit Sub
        End If


        Try
            Dim uT As New Utils
            uT.InsertNssNro()
            txtIdReceita.Text = uT.Id_Nss_Nro
            clsPront.Rc_Nss = uT.Id_Nss_Nro
            ' Os_Impressao = clsPront.Rc_Nss

            clsPront.TipoOperacao = "I"
            clsPront.Rc_Ani = md_Id_Pet
            clsPront.Rc_Cli = md_Id_Tutor
            clsPront.Rc_Dt = Now

            clsPront.Rc_Meio = ""
            clsPront.Rc_Qtd = 1
            clsPront.Rc_Via = 1
            clsPront.Rc_Freq = 1
            clsPront.Rc_Dias = 11
            clsPront.Rc_Func = clsPront.Rc_Func
            For i As Integer = 0 To dgReceita.Rows.Count - 1
                If dgReceita.Rows(i).Cells(1).Value IsNot Nothing Then

                    clsPront.Rc_Farmaco = ""
                    clsPront.Rc_DescFarmaco = dgReceita.Rows(i).Cells(1).Value.ToString()
                    clsPront.Rc_Reco = dgReceita.Rows(i).Cells(2).Value.ToString()
                    clsPront.Rc_Esp = ckEspecial.Checked

                    clsPront.I_U_D_Receita()

                End If
            Next

            clsPront.Rc_Ani = lbIdPet.Text
            clsPront.Rc_Nss = 0
            clsPront.DeletaReceitaGeral()

            MessageBox.Show("Receita lançada.", "Nota importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)

            PreencheLstReceita()

            ImprimirReceita(txtIdReceita.Text)
            LimpaReceita()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtFarmaco_TextChanged(sender As Object, e As EventArgs) Handles txtFarmaco.TextChanged
        lbCountItem.Text = 0
        clsPront.Nome_Like = txtFarmaco.Text

        If Trim(txtFarmaco.TextLength) <= 1 Then
            Exit Sub
        End If

        Dim dtAg As DataTable = clsPront.LeFarmaco("Sp_Farmaco_Lk")

        dgFarmacos.DataSource = dtAg
        lbCountItem.Text = dtAg.Rows.Count

        '' dgFarmacos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFarmacos.Columns(0).HeaderText = "Descrição do Farmaco "
        dgFarmacos.Columns(0).Width = 350
        dgFarmacos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFarmacos.Columns(1).HeaderText = "Saldo "
        dgFarmacos.Columns(1).Width = 20
        dgFarmacos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFarmacos.Columns(2).HeaderText = "Cod.Item "
        dgFarmacos.Columns(2).Width = 80

        Try

            For Each Row As DataGridViewRow In dgFarmacos.Rows

                ''Convert.ToDecimal(Row.Cells(1).Value)
                If Row.Cells(1).Value = 0 Then
                    Row.Cells(1).Value = "0"
                Else
                    Row.DefaultCellStyle.BackColor = Color.GreenYellow
                    If Row.Cells(1).Value = 1 Then
                        Row.Cells(1).Style.BackColor = Color.OrangeRed
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnImpirmirReceita_Click(sender As Object, e As EventArgs) Handles btnImpirmirReceita.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.AppStarting
            ImprimirReceita(txtIdReceita.Text)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgFarmacos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFarmacos.CellContentClick

        txtFarmaco.Text = dgFarmacos.CurrentRow.Cells(0).Value.ToString()
        txtRecomendacao.Focus()

    End Sub
    Private Sub lstReceitasAv_Click(sender As Object, e As EventArgs) Handles lstReceitasAv.Click
        ''Preenche A Receita
        clsPront.Rc_Nss = lstReceitasAv.SelectedValue
        txtIdReceita.Text = clsPront.Rc_Nss
        clsPront.Rc_Ani = md_Id_Pet
        LeReceita()

        'Dim dt As DataTable
        'dt = clsPront.BuscaReceita
        'dgReceita.DataSource = dt

        'If dt.Rows.Count > 0 Then
        '    ckEspecial.Checked = Me.dgReceita.CurrentRow.Cells(0).Value.ToString()
        '    ConfigDataGrid()

        '    btnImpirmirReceita.Enabled = True
        'Else
        '    txtIdReceita.Text = 0
        'End If

    End Sub
    Private Sub ConfigDataGrid()
        With dgReceita
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8)
            '    ' Estilo do cabeçalho
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White

                .Font = New Font("Tahoma", 8)
                .Font = New Font(dgReceita.Font, FontStyle.Bold)
            End With

            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(0).HeaderText = "Esp"
            .Columns(0).Width = 10

            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(1).HeaderText = " Farmaco               "
            .Columns(1).Width = 20
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).HeaderText = " Recomendações               "
            .Columns(2).Width = 25
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).HeaderText = " id   "
            .Columns(3).Width = 15

        End With
    End Sub

    Private Sub txtRecomendacao_TextChanged(sender As Object, e As EventArgs) Handles txtRecomendacao.TextChanged

    End Sub
    Private Sub txtRecomendacao_LostFocus(sender As Object, e As EventArgs) Handles txtRecomendacao.LostFocus
        If Trim(txtRecomendacao.Text) = "" Then
            Exit Sub
        End If


        Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja adicionar este item na lista de Receita??", "Emissão de Receita",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1, 0)

        If StrMsg = 6 Then
            If Len(Trim(txtRecomendacao.Text)) = 0 Then
                MessageBox.Show("Possologia do farmaco não informada", "Nota importante",
                            MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1)
                txtFarmaco.Focus()
                Exit Sub
            End If

            clsPront.TipoOperacao = "I"
            clsPront.Rc_Farmaco = ""
            clsPront.Rc_DescFarmaco = txtFarmaco.Text
            clsPront.Rc_Ani = md_Id_Pet
            clsPront.Rc_Cli = md_Id_Tutor
            clsPront.Rc_Dt = Now
            clsPront.Rc_Nss = txtIdReceita.Text ' (fixa  receita nao terminada)
            clsPront.Rc_Qtd = 1
            clsPront.Rc_Via = 1
            clsPront.Rc_Meio = ""
            clsPront.Rc_Freq = 1
            clsPront.Rc_Dias = 11
            clsPront.Rc_Reco = txtRecomendacao.Text
            clsPront.Rc_Esp = ckEspecial.Checked
            clsPront.Rc_Func = Veterinario
            clsPront.I_U_D_Receita()

            Dim dt As DataTable
            dt = clsPront.BuscaReceita
            dgReceita.DataSource = dt
            ConfigDataGrid()
            txtFarmaco.Text = ""
            txtRecomendacao.Text = ""
            txtFarmaco.Focus()

        Else
            ''NAO
            txtFarmaco.Text = ""
            txtRecomendacao.Text = ""
            dgReceita.DataSource = Nothing
            dgReceita.Rows.Clear()

        End If

    End Sub

    Private Sub txtFarmaco_GotFocus(sender As Object, e As EventArgs) Handles txtFarmaco.GotFocus

    End Sub

    Private Sub Deletar_Item_Da_Receita_Click(sender As Object, e As EventArgs) Handles Deletar_Item_Da_Receita.Click
        Dim result1 As DialogResult = MessageBox.Show("Você realmente deseja Deletar este Item da Receita ?",
                                                    "Pergunta importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result1 = DialogResult.Yes Then
            clsPront.Rc_Id = Me.dgReceita.CurrentRow.Cells(3).Value.ToString()
            clsPront.Rc_Ani = md_Id_Pet

            clsPront.DeletaItemReceita()

            ckEspecial.Checked = Me.dgReceita.CurrentRow.Cells(0).Value.ToString()
            ConfigDataGrid()
            LeReceita()
            'PreencheLstReceita()
            btnImpirmirReceita.Enabled = False

        End If
    End Sub

    Private Sub lstReceitasAv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReceitasAv.SelectedIndexChanged

    End Sub

    Private Sub tsmExcluirReceita_Click(sender As Object, e As EventArgs) Handles tsmExcluirReceita.Click
        Dim result1 As DialogResult = MessageBox.Show("Você realmente deseja Excluir esta Receita ?",
                                                     "Pergunta importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result1 = DialogResult.Yes Then
            clsPront.Rc_Nss = lstReceitasAv.SelectedValue
            txtIdReceita.Text = clsPront.Rc_Nss
            clsPront.Rc_Ani = md_Id_Pet

            clsPront.DeletaReceitaGeral()

            ckEspecial.Checked = Me.dgReceita.CurrentRow.Cells(0).Value.ToString()

            LeReceita()

            ConfigDataGrid()

            btnImpirmirReceita.Enabled = False

        End If
    End Sub

    Private Sub dgReceita_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReceita.CellContentClick

    End Sub


#End Region
End Class
