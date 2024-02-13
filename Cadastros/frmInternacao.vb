Imports System.Windows.Forms
Imports DataBase

Public Class frmInternacao

    Private Materiais As New Cls_Materiais
    Private ClsInt As New Cls_Internacao
    Private Sub LimpaForm()
        txtIdMedic.Text = 0
        dtp.Value = Now
        dtpDtFim.Value = Now

        dtpMedicHora.Format = DateTimePickerFormat.Time
        dtpMedicHora.ShowUpDown = True
        dtpMedicHora.Value = DateTime.Now.ToString("dd-MM-yyyy, HH:mm:ss")

        dtpMonitorizacao.Value = Now
        dtpDtExame.Value = Now
        dtpFluido.Value = Now
        dtpInfusao.Value = Now
        dtpEvolu.Value = Now

        txtDiasInt.Text = 1
        lblIdExames.Text = 0
        lbIdFluido.Text = 0
        lbIdInfusao.Text = 0
        lbIdInternacao.Text = 0
        lbIdMonit.Text = 0
        lbIdEvolu.Text = 0
        LimpaProt()

    End Sub
    Private Sub LimpaProt()
        Label6.Text = 0
        txtProtId.Text = ""
        txtProtDesc.Text = ""
        txtItem.Text = ""
        txtProtFarmaco.Text = ""
        txtProtDose.Text = ""
        txtProtConc.Text = ""
        txtProtVolume.Text = ""
        txtProtVia.Text = ""
        txtProtFreq.Text = "1"

    End Sub
    Private Sub MoveTelaBaseProt()
        Try
            If Len(Label6.Text) > 0 Then
                ClsInt.Id_Prot = Label6.Text
            Else
                ClsInt.Id_Prot = 0
            End If
            ClsInt.int_ProtID = txtProtId.Text
            ClsInt.int_ProtDesc = txtProtDesc.Text
            ClsInt.int_ProtItem = txtItem.Text
            ClsInt.int_ProtFarmaco = txtProtFarmaco.Text
            ClsInt.int_ProtDose = txtProtDose.Text
            ClsInt.int_ProtConcent = txtProtConc.Text
            ClsInt.int_ProtVolume = txtProtVolume.Text
            ClsInt.int_ProtVia = txtProtVia.Text
            ClsInt.int_ProtFreq = txtProtFreq.Text

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub MoveBaseTelaProt()
        Try
            Label6.Text = ClsInt.Id_Prot
            txtProtId.Text = ClsInt.int_ProtID
            txtProtDesc.Text = ClsInt.int_ProtDesc
            txtItem.Text = ClsInt.int_ProtItem
            txtProtFarmaco.Text = ClsInt.int_ProtFarmaco
            txtProtDose.Text = ClsInt.int_ProtDose
            txtProtConc.Text = ClsInt.int_ProtConcent
            txtProtVolume.Text = ClsInt.int_ProtVolume
            txtProtVia.Text = ClsInt.int_ProtVia
            txtProtFreq.Text = ClsInt.int_ProtFreq

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PreencheDgItens()

        Dim dt As DataTable
        dt = Materiais.BuscaItens

        dgItens.DataSource = dt

        dgItens.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(0).HeaderText = " Descrição        "
        dgItens.Columns(0).Width = 180

        dgItens.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(1).HeaderText = " Codigo "
        dgItens.Columns(1).Width = 55

        dgItens.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(2).HeaderText = " ID "
        dgItens.Columns(2).Width = 30


    End Sub
    Private Sub PreencheProtocolo()
        'Le Todo o protocolo

        ClsInt.TipoOp = "6"

        Dim dt As DataTable
        dt = ClsInt.LeProtocolo()
        DgProt.DataSource = dt

        ''DgProt.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(0).HeaderText = "Id do Item  do Protocolo"
        '' DgProt.Columns(0).Width = 80
        ''DgProt.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(1).HeaderText = "Descrição do Farmaco do Protocolo"
        '' DgProt.Columns(1).Width = 250
        DgProt.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(2).HeaderText = "Dose"
        DgProt.Columns(2).Width = 30
        DgProt.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(3).HeaderText = "Consentração"
        DgProt.Columns(3).Width = 30
        DgProt.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(4).HeaderText = "Volume"
        DgProt.Columns(4).Width = 30
        DgProt.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(5).HeaderText = "Via"
        DgProt.Columns(5).Width = 30
        DgProt.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(6).HeaderText = "Frequencia"
        DgProt.Columns(6).Width = 30
        DgProt.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgProt.Columns(7).HeaderText = "Reg"
        DgProt.Columns(7).Width = 10

    End Sub
    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged

        If txtBusca.TextLength <= 1 Then
            dgItens.DataSource = Nothing
            dgItens.Rows.Clear()
            Exit Sub
        End If

        PreencheDgItens()

        Materiais.IT_DESC = Trim(txtBusca.Text)

        Dim dt As DataTable
        dt = Materiais.BuscaItensLike()
        dgItens.DataSource = dt

    End Sub

    Private Sub dgItens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItens.CellContentClick
        Try
            Materiais.IT_ITEM = dgItens.CurrentRow.Cells(1).Value.ToString()
            txtItem.Text = Materiais.IT_ITEM
            Materiais.Le_Item()
            txtProtFarmaco.Text = Materiais.IT_DESC
            txtProtFarmaco.Focus()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btoIncProtocolo_Click(sender As Object, e As EventArgs) Handles btoIncProtocolo.Click
        Try
            MoveTelaBaseProt()
            ClsInt.TipoOp = "1"

            ClsInt.InsertProtocolo()
            If ClsInt.Id_Prot > 0 Then
                MoveTelaBaseProt()
                PreencheProtocolo()
                MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Protocolo efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ocorreu um erro inesperado. ", " Erro de inclusão ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cls_TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtProtId.TextChanged

    End Sub

    Private Sub frmInternacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LimpaForm()
        PreencheCboProtocolos()
        txtIdPet.Text = md_Id_Pet
        txtIdTutor.Text = md_Id_Tutor

        ClsInt.BuscaTutor(md_Id_Tutor, md_Id_Pet)
        txtTutor.Text = ClsInt.N_Tutor
        txtPet.Text = ClsInt.N_Pet
        If ClsInt.N_Especie = 1 Then
            rbEspecieC.Checked = True
        Else
            rbEspecieF.Checked = True
        End If

        If ClsInt.N_Sexo = "F" Then
            rbF.Checked = True
        Else
            RbM.Checked = True
        End If
        txtRaca.Text = ClsInt.N_Raca
        Dim ut As New Utils
        picPet.Image = ut.AbrirArquivoBase64(ClsInt.N_Foto) 'TRANSFERE 

        txtDiagnostico.Focus()

        '' BUSCA AS INTERNACÓES DO PET
        LimpaTelaInt()
        Busca_int_Pet()
        If dgInternacoes.Rows.Count > 0 Then
            lbIdInternacao.Text = dgInternacoes.CurrentRow.Cells(1).Value.ToString()

            Le_Dados()

        End If

        TabControl.SelectedIndex = 1
        Config_DgMedic()

    End Sub
    Private Sub Busca_int_Pet()
        MoveTelaBaseInt()
        ClsInt.TipoOp = 5

        Dim dt As DataTable
        dt = ClsInt.LeInternacoesPet()
        dgInternacoes.DataSource = dt
        dgInternacoes.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgInternacoes.Columns(0).HeaderText = "Data "
        dgInternacoes.Columns(0).Width = 50
        dgInternacoes.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgInternacoes.Columns(1).HeaderText = "ID"
        dgInternacoes.Columns(1).Width = 20

    End Sub
    Private Sub PreencheCboProtocolos()
        MoveTelaBaseProt()
        ClsInt.TipoOp = 8

        Dim dtF As DataTable = ClsInt.LeProtocolo
        cboProtocolos.DisplayMember = "intProtDesc"
        cboProtocolos.ValueMember = "intProtID"
        cboProtocolos.DataSource = dtF

        dtF = ClsInt.LeMonitTP(1, 0)
        cboMonitTp.DisplayMember = "intTpDesc"
        cboMonitTp.ValueMember = "intTpId"
        cboMonitTp.DataSource = dtF
        ''Exames
        dtF = ClsInt.LeMonitTP(3, 3)
        cboExames.DisplayMember = "intTpDesc"
        cboExames.ValueMember = "intTpId"
        cboExames.DataSource = dtF
        ''Fluidoterapia
        dtF = ClsInt.LeMonitTP(3, 4)
        cboFluido.DisplayMember = "intTpDesc"
        cboFluido.ValueMember = "intTpId"
        cboFluido.DataSource = dtF
        ''Infusao
        dtF = ClsInt.LeMonitTP(3, 5)
        cboInfusao.DisplayMember = "intTpDesc"
        cboInfusao.ValueMember = "intTpId"
        cboInfusao.DataSource = dtF


    End Sub
    Private Sub cboProtocolos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProtocolos.SelectedIndexChanged
        Try
            MoveTelaBaseProt()

            ClsInt.Id_Prot = cboProtocolos.SelectedValue

            ClsInt.BuscaProtocolo()
            txtProtId.Text = ClsInt.int_ProtID
            txtProtDesc.Text = ClsInt.int_ProtDesc

            PreencheProtocolo()
            TabControl.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub DgProt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProt.CellContentClick
        LeRegProt()
    End Sub
    Private Sub LeRegProt()
        MoveTelaBaseProt()

        If IsNumeric(DgProt.CurrentRow.Cells(6).Value.ToString()) = False Then
            ClsInt.Id_Prot = 0
        Else
            ClsInt.Id_Prot = DgProt.CurrentRow.Cells(6).Value.ToString()
        End If
        ClsInt.BuscaTpSelProt(7) '' tipo da operacao
        MoveBaseTelaProt()
    End Sub
    Private Sub DgProt_SelectionChanged(sender As Object, e As EventArgs) Handles DgProt.SelectionChanged
        LeRegProt()
    End Sub
    Private Sub Deletar_Item_Do_Protocolo_Click(sender As Object, e As EventArgs) Handles Deletar_Item_Do_Protocolo.Click
        Dim result1 As DialogResult = MessageBox.Show("Você realmente deseja remover o Item " &
                                                      DgProt.CurrentRow.Cells(1).Value.ToString() & " - " &
                                                      DgProt.CurrentRow.Cells(2).Value.ToString() & " da lista?",
                                                       "Pergunta importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result1 = DialogResult.Yes Then
            Try
                MoveTelaBaseProt()
                ClsInt.TipoOp = "3"
                ClsInt.Id_Prot = DgProt.CurrentRow.Cells(6).Value.ToString()
                ClsInt.InsertProtocolo()
                PreencheProtocolo()
                LimpaProt()
            Catch ex As Exception
                MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub btoEcxlProt_Click(sender As Object, e As EventArgs) Handles btoEcxlProt.Click
        Dim result1 As DialogResult = MessageBox.Show("Você realmente deseja Excluir o Protocol definitivamente ? ",
                                                       "Pergunta importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result1 = DialogResult.Yes Then
            Try
                MoveTelaBaseProt()
                ClsInt.TipoOp = "4"
                ClsInt.int_ProtID = txtProtId.Text
                ClsInt.InsertProtocolo()
                PreencheProtocolo()
                LimpaProt()
            Catch ex As Exception
                MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub
    Private Sub LimpaTelaInt()
        lbIdInternacao.Text = 0
        dtp.Value = Now
        txtObsInt.Text = ""
        txtDiagnostico.Text = ""
        ''cboProtocolos.ValueMember = ""

    End Sub
    Private Sub MoveTelaBaseInt()
        If Len(lbIdInternacao.Text) = 0 Then
            lbIdInternacao.Text = 0
        End If
        ClsInt.int_Pet = txtIdPet.Text
        ClsInt.int_Data = FormatDateTime(dtp.Value, DateFormat.GeneralDate)
        ClsInt.int_Obs = txtObsInt.Text
        ClsInt.int_Diag = txtDiagnostico.Text
        ClsInt.int_ProtTerap = cboProtocolos.ValueMember
        ClsInt.int_Dias = txtDiasInt.Text
        ClsInt.int_DataFim = dtpDtFim.Value

    End Sub
    Private Sub dgInternacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInternacoes.CellContentClick
        LimpaForm()
        lbIdInternacao.Text = dgInternacoes.CurrentRow.Cells(1).Value.ToString()
        '' MoveTelaBaseInt()
        Le_Dados()
        TabControl.SelectedIndex = 1
    End Sub
    Private Sub Le_Dados()

        Dim dt As DataTable
        dt = ClsInt.LeMedicacoes_da_int(lbIdInternacao.Text)
        dgMedic.DataSource = dt

        Config_DgMedic()
        Le_Pivot_Exames()
        Le_Pivot_Fluido()
        Le_Pivot_Infusao()
        Le_Pivot_Monit()

    End Sub
    Private Sub MoveTelaBase_Medic()

        ClsInt.m_ID = txtIdMedic.Text
        ClsInt.m_Item = txtItem.Text
        ClsInt.m_Desc = txtProtFarmaco.Text
        ClsInt.m_Dose = txtProtDose.Text
        ClsInt.m_Via = txtProtVia.Text
        ClsInt.m_Pos = ""

        ClsInt.m_Cons = txtProtConc.Text
        ClsInt.m_Vol = txtProtVolume.Text
        If Len(txtProtFreq.Text) = 0 Then
            txtProtFreq.Text = 1
        End If
        ClsInt.m_Freq = txtProtFreq.Text
        ClsInt.m_Reg = lbIdInternacao.Text    '' /*  ID DA INTERNACAO */
        ClsInt.m_Data = String.Format("{0:dd/MM/yyyy}", dtpMedicData.Value)
        ClsInt.m_Hora = String.Format("{0:HH:mm:ss}", dtpMedicHora.Value)

    End Sub
    Private Sub MoveBaseTela_Medic()

        ClsInt.m_ID = 0
        txtMedicItem.Text = ClsInt.m_Item
        txtMedicFarmaco.Text = ClsInt.m_Desc
        txtMedicDose.Text = ClsInt.m_Dose
        txtMedicVia.Text = ClsInt.m_Via
        ''= ClsInt.m_Pos 
        txtMedicConc.Text = ClsInt.m_Cons
        txtMedicVol.Text = ClsInt.m_Vol
        ''= ClsInt.m_Freq  0 ''txtProtFreq.Text
        '''ClsInt.m_Reg  lbIdInternacao.Text    '' /*  ID DA INTERNACAO */
        dtpMedicData.Value = String.Format("{0:dd/MM/yyyy}", ClsInt.m_Data)
        Dim tt As Date = ClsInt.m_Hora
        dtpMedicHora.Value = Format("HH:mm:ss", tt)

    End Sub

    Private Sub btoGravaInternacao_Click(sender As Object, e As EventArgs) Handles btoGravaInternacao.Click
        Try

            If DgProt.Rows.Count.ToString() = 0 Then

                MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Não foi encontrado tratamemnto terapêutico para inclusão.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub
            End If

            MoveTelaBaseInt()
            ClsInt.TipoOp = "1"
            ClsInt.int_ID = 0

            ClsInt.ManutReg_Internacao()

            If ClsInt.int_ID > 0 Then
                lbIdInternacao.Text = ClsInt.int_ID
                Busca_int_Pet()

                'INCLUI AS MEDICAÇÕES
                MoveTelaBase_Medic()

                ClsInt.TipoOp = "1"

                ClsInt.m_Reg = lbIdInternacao.Text    '' /*  ID DA INTERNACAO */
                ClsInt.m_Hora = String.Format("{0:HH:mm:ss}", "00:00:01") 'dtpMedicHora.Value)
                Dim y As Integer = 1
                Dim x As Integer
                Do While x < txtDiasInt.Text

                    ClsInt.m_Data = String.Format("{0:dd/MM/yyyy}", dtp.Value)

                    For Each col As DataGridViewRow In DgProt.Rows

                        ClsInt.m_Item = col.Cells(0).Value
                        ClsInt.m_Desc = col.Cells(1).Value
                        ClsInt.m_Dose = col.Cells(2).Value
                        ClsInt.m_Cons = col.Cells(3).Value
                        ClsInt.m_Vol = col.Cells(4).Value
                        ClsInt.m_Via = col.Cells(5).Value
                        ClsInt.m_Pos = "" '"col.Cells().Value
                        If Trim(col.Cells(6).Value) = "" Then
                            ClsInt.m_Freq = 1
                        Else
                            ClsInt.m_Freq = col.Cells(6).Value
                        End If

                        For y = 1 To txtMedicFreq.Text ''repete a frequencia da aplicacao

                            ClsInt.ManutReg_Medicacao() ' grava a medicação

                        Next

                    Next

                    x += 1
                    dtp.Value = dtp.Value.AddDays(x)
                Loop
                MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Internação efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TabControl.SelectedIndex = 1
                ''le as medicacoes inseridas na internacao
                Le_Dados()

            Else
                MessageBox.Show("Ocorreu um erro inesperado. ", " Erro de inclusão ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btoEclxIntern_Click(sender As Object, e As EventArgs) Handles btoEclxIntern.Click
        Try
            MoveTelaBaseInt()
            ClsInt.TipoOp = "3"
            ClsInt.int_ID = lbIdInternacao.Text
            Dim r As Boolean
            r = ClsInt.ManutReg_Internacao()

            If r = True Then
                MessageBox.Show("Aviso de Exclusão de Registro :" & vbNewLine & "Exclusão de Internação efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TabControl.SelectedIndex = 0
                Le_Dados()
            Else
                MessageBox.Show("Ocorreu um erro inesperado. ", " Erro de exclusão ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDiasInt_TextChanged(sender As Object, e As EventArgs) Handles txtDiasInt.TextChanged
        dtpDtFim.Value = dtp.Value
        If IsNumeric(txtDiasInt.Text) = True Then
            If txtDiasInt.Text = 0 Then
                txtDiasInt.Text = 1
            End If
            dtpDtFim.Value = dtp.Value.AddDays(txtDiasInt.Text - 1)
        End If

    End Sub

    Private Sub dgMedic_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMedic.CellContentClick
        '' EDITA O REGISTRO DA MEDICACAO
        txtIdMedic.Text = dgMedic.CurrentRow.Cells(12).Value.ToString()
        ClsInt.BuscaMedicacao(dgMedic.CurrentRow.Cells(12).Value.ToString())

        MoveBaseTela_Medic()

        TabControl.SelectedIndex = 1

        Dim h As String = dgMedic.CurrentRow.Cells(2).Value.ToString()

        If Mid(h, 12, 5) <> "00:00" Then
            dtpMedicHora.Value = DateTime.Now.ToString("dd-MM-yyyy, HH:mm:ss")
        Else
            dtpMedicHora.Value = Now
            dtpMedicHora.Focus()
        End If

    End Sub

    Private Sub txtMedicItens_TextChanged(sender As Object, e As EventArgs) Handles txtMedicItens.TextChanged

        If txtMedicItens.TextLength <= 1 Then
            dgMedicItens.DataSource = Nothing
            dgMedicItens.Rows.Clear()
            Exit Sub
        End If

        ''PreencheDgItens()
        Materiais.IT_DESC = Trim(txtMedicItens.Text)
        Dim dt As DataTable
        dt = Materiais.BuscaItensLike()
        dgMedicItens.DataSource = dt


        dgMedicItens.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedicItens.Columns(0).HeaderText = " Descrição        "
        dgMedicItens.Columns(0).Width = 180

        dgMedicItens.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedicItens.Columns(1).HeaderText = " Codigo "
        dgMedicItens.Columns(1).Width = 55

        dgMedicItens.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedicItens.Columns(2).HeaderText = " ID "
        dgMedicItens.Columns(2).Width = 30


    End Sub

    Private Sub dgMedicItens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMedicItens.CellContentClick
        Try
            txtMedicItem.Text = dgMedicItens.CurrentRow.Cells(1).Value.ToString()
            txtMedicFarmaco.Text = dgMedicItens.CurrentRow.Cells(0).Value.ToString()
            txtMedicFarmaco.Focus()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Config_DgMedic()
        dgMedic.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(0).HeaderText = "Check"
        dgMedic.Columns(0).Width = 3
        dgMedic.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(1).HeaderText = "Data"
        dgMedic.Columns(1).Width = 50
        dgMedic.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(2).HeaderText = "Hora"
        dgMedic.Columns(2).Width = 10
        dgMedic.Columns(2).DefaultCellStyle.Format = "HH:mm"

        '' dgMedic.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(3).HeaderText = "Id do Item"
        dgMedic.Columns(3).Width = 60
        ''dgMedic.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(4).HeaderText = "Descrição do Farmaco do Protocolo"
        dgMedic.Columns(4).Width = 90
        dgMedic.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(5).HeaderText = "Dose"
        dgMedic.Columns(5).Width = 30
        dgMedic.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(6).HeaderText = "Via"
        dgMedic.Columns(6).Width = 30
        dgMedic.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(7).HeaderText = "Pos"
        dgMedic.Columns(7).Width = 30
        dgMedic.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(8).HeaderText = "Consentracao"
        dgMedic.Columns(8).Width = 30
        dgMedic.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(9).HeaderText = "Volume"
        dgMedic.Columns(9).Width = 30
        dgMedic.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(10).HeaderText = "Frequencia"
        dgMedic.Columns(10).Width = 30
        dgMedic.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(11).HeaderText = "Internacao"
        dgMedic.Columns(11).Width = 10
        dgMedic.Columns(12).HeaderText = "Id "
        dgMedic.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgMedic.Columns(12).Width = 10

        Dim h As String

        For Each col As DataGridViewRow In dgMedic.Rows

            h = Mid(col.Cells(2).Value.ToString(), 11)
            If Mid(Trim(h), 1, 5) <> "00:00" Then
                col.Cells(0).Value = True
            Else
                'col.Cells(0).Value = Image.FromFile("C:\SisVet\Sistema\SistemaVeterinario\Cadastros\Resources\delete_40623.png")
                col.Cells(0).Value = False
            End If

            If Trim(col.Cells(10).Value) = 0 Then
                col.Cells(7).Value = ""
            End If

            col.Cells(3).Value = Trim(col.Cells(3).Value)
            col.Cells(4).Value = Trim(col.Cells(4).Value)
        Next

    End Sub

    Private Sub btoAtuItemMedic_Click(sender As Object, e As EventArgs) Handles btoAtuItemMedic.Click
        If txtIdMedic.Text = 0 Or IsNumeric(txtIdMedic.Text) = False Then
            MessageBox.Show("Aviso do check do Registro :" & vbNewLine & "Alteração do status do Registro não efetuada." &
                  vbNewLine & "Você precisa selecionar um Registro. ", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Exit Sub
        End If

        MoveTelaBase_Medic()

        ClsInt.TipoOp = "5" 'altera a data e hora

        ClsInt.m_ID = txtIdMedic.Text    '' /*  ID Do registro */

        ClsInt.m_Data = String.Format("{0:dd/MM/yyyy}", dtpMedicIni.Value)
        ClsInt.m_Hora = String.Format("{0:HH:mm:ss}", dtpMedicHora.Value)

        ClsInt.ManutReg_Medicacao() ' update da medicação

        MessageBox.Show("Aviso de alteração de Registro :" & vbNewLine & "Check efetuado com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Le_Dados()
    End Sub

    Private Sub btoMed_Inc_Click(sender As Object, e As EventArgs) Handles btoMed_Inc.Click
        MoveTelaBase_Medic()

        ClsInt.TipoOp = "1"

        ClsInt.m_Reg = lbIdInternacao.Text    '' /*  ID DA INTERNACAO */
        ClsInt.m_Hora = String.Format("{0:HH:mm:ss}", "00:00:01") 'dtpMedicHora.Value)
        ClsInt.m_Item = txtMedicItem.Text
        ClsInt.m_Desc = txtMedicFarmaco.Text
        ClsInt.m_Dose = txtMedicDose.Text
        ClsInt.m_Cons = txtMedicConc.Text
        ClsInt.m_Vol = txtMedicVol.Text
        ClsInt.m_Via = txtMedicVia.Text
        ClsInt.m_Pos = ""

        If Trim(txtMedicFreq.Text) = "" Then
            ClsInt.m_Freq = 1
        Else
            ClsInt.m_Freq = txtMedicFreq.Text
        End If

        Dim x As Integer = 0
        Dim y As Integer = 1

        Do While x < txtDiasIntMedic.Text
            dtpMedicIni.Value = dtp.Value.AddDays(x)
            ClsInt.m_Data = String.Format("{0:dd/MM/yyyy}", dtpMedicIni.Value)

            For y = 1 To txtMedicFreq.Text ''repete a frequencia da aplicacao

                ClsInt.ManutReg_Medicacao() ' grava a medicação

            Next

            x += 1

        Loop

        MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Internação efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtDiasIntMedic_TextChanged(sender As Object, e As EventArgs) Handles txtDiasIntMedic.TextChanged
        dtpMedicFim.Value = dtpMedicIni.Value
        If IsNumeric(txtDiasIntMedic.Text) = True Then
            If txtDiasIntMedic.Text = 0 Then
                txtDiasIntMedic.Text = 1
            End If
            dtpMedicFim.Value = dtpMedicIni.Value.AddDays(txtDiasIntMedic.Text - 1)
        End If

    End Sub

    Private Sub dtpMedicHora_ValueChanged(sender As Object, e As EventArgs) Handles dtpMedicHora.ValueChanged
        If txtIdMedic.Text = "" Then
            txtIdMedic.Text = 0
        End If
        'If txtIdMedic.Text > 0 Then
        '    Me.btoAtuItemMedic.Image = Me.btoAtuItemMedic.Image.FromFile("C:\SisVet\Sistema\SistemaVeterinario\Cadastros\Resources\check_40622.png")
        'End If

    End Sub

    Private Sub btoMonitAtu_Click(sender As Object, e As EventArgs) Handles btoMonitAtu.Click
        lbIdInternacao.Text = 0
        txtMonitValor.Text = 0
        dtpMonitorizacao.Value = Now

        ClsInt.intMonit_IDInter = lbIdInternacao.Text
        ClsInt.intMonit_Tp = cboMonitTp.SelectedValue
        ClsInt.intMonit_Data = dtpMonitorizacao.Value

        ClsInt.intMonit_Hora = ddH.Text & ":" & ddM.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text

        ClsInt.intMonit_Valor = txtMonitValor.Text

        ClsInt.TipoOp = "1"
        Dim r As Boolean
        r = ClsInt.ManutReg_Monitorizacao()

        If r = True Then
            Le_Pivot_Monit()
            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Monitorização efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub Le_Pivot_Monit()
        ''le pivot
        Dim dtpv As DataTable
        dtpv = ClsInt.LePivot(lbIdInternacao.Text, "Sp_Int_Pivot_Monitorizacao")
        dgMonit.DataSource = dtpv

        dgMonit.Columns(0).HeaderText = "Tp"
        dgMonit.Columns(1).HeaderText = "Descrição "
        dgMonit.Columns(2).HeaderText = "Data"
        Me.dgMonit.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgMonit.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgMonit.Columns(3).Visible = False

        Dim coluna(100) As Integer

        For i As Integer = 0 To dgMonit.Rows.Count - 1

            For j As Integer = 4 To dgMonit.Columns.Count - 1

                If IsDBNull(dgMonit.Rows(i).Cells(j).Value) = False Then

                    coluna(j) += 1

                End If

            Next
            'acabou a linha
        Next
        For j As Integer = 4 To dgMonit.Columns.Count - 1

            If coluna(j) = 0 Then
                dgMonit.Columns(j).Visible = False
            Else
                dgMonit.Columns(j).Visible = True
            End If

        Next
    End Sub
    Private Sub dgMonit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMonit.CellContentClick
        Try

            Dim i As Integer = dgMonit.CurrentCell.RowIndex
            Dim x As Integer = dgMonit.CurrentCell.ColumnIndex
            Dim h As String

            If dgMonit.Columns(x).HeaderText = "Descrição " Or
                dgMonit.Columns(x).HeaderText = "Data" Then
                MessageBox.Show("Célula de Horário não selecionada." & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            dgMonit.Rows(i).Cells(x).Value.ToString()
            h = dgMonit.Columns(x).HeaderText
            ClsInt.intMonit_Hora = String.Format("{0:HH:mm:ss}", h) '' "01/01/1900 " & String.Format("{0:HH:mm:ss}", h)
            ClsInt.intMonit_IDInter = lbIdInternacao.Text
            ClsInt.intMonit_Tp = dgMonit.Rows(i).Cells(0).Value.ToString()
            ClsInt.intMonit_Data = dgMonit.Rows(i).Cells(2).Value.ToString()
            ClsInt.intMonit_Valor = txtMonitValor.Text
            ClsInt.intMonit_ID = lbIdMonit.Text
            ClsInt.TipoOp = "4"

            ClsInt.LeRegMonitorizacao()

            If ClsInt.intMonit_ID > 0 Then
                cboMonitTp.SelectedValue = ClsInt.intMonit_Tp
                ddH.Text = Mid(ClsInt.intMonit_Hora, 1, 2)
                ddM.Text = Mid(ClsInt.intMonit_Hora, 4, 2)
                txtMonitValor.Text = ClsInt.intMonit_Valor
                lbIdMonit.Text = ClsInt.intMonit_ID
            Else
                MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btoAtuExames_Click(sender As Object, e As EventArgs) Handles btoAtuExames.Click
        ClsInt.ex_IDInter = lbIdInternacao.Text
        ClsInt.ex_TpExame = cboExames.SelectedValue
        ClsInt.ex_Data = dtpDtExame.Value
        ClsInt.ex_Hora = ddh_exame.Text & ":" & ddm_exame.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text
        ClsInt.ex_Valor = txtValorExame.Text
        ClsInt.ex_Id = 0
        ClsInt.TipoOp = "1"
        Dim r As Boolean
        r = ClsInt.ManutReg_Exames()

        If r = True Then
            Le_Pivot_Exames()

            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Monitorização efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
    Private Sub Le_Pivot_Exames()
        Dim dtpv As DataTable
        dtpv = ClsInt.LePivot(lbIdInternacao.Text, "Sp_Int_Pivot_Exames")

        dgExames.DataSource = dtpv

        dgExames.Columns(0).HeaderText = "Tp"
        dgExames.Columns(1).HeaderText = "Descrição "
        dgExames.Columns(2).HeaderText = "Data"
        Me.dgExames.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgExames.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgExames.Columns(3).Visible = False

        Dim coluna(100) As Integer

        For i As Integer = 0 To dgExames.Rows.Count - 1

            For j As Integer = 4 To dgExames.Columns.Count - 1

                If IsDBNull(dgExames.Rows(i).Cells(j).Value) = False Then

                    coluna(j) += 1

                End If

            Next
            'acabou a linha
        Next
        For j As Integer = 4 To dgExames.Columns.Count - 1

            If coluna(j) = 0 Then
                dgExames.Columns(j).Visible = False
            Else
                dgExames.Columns(j).Visible = True
            End If

        Next
    End Sub
    Private Sub Le_Pivot_Fluido()
        Dim dtpv As DataTable
        dtpv = ClsInt.LePivot(lbIdInternacao.Text, "Sp_Int_Pivot_Fluido")

        dgvFluido.DataSource = dtpv

        dgvFluido.Columns(0).HeaderText = "Tp"
        dgvFluido.Columns(1).HeaderText = "Descrição "
        dgvFluido.Columns(2).HeaderText = "Data"
        Me.dgvFluido.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvFluido.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvFluido.Columns(3).Visible = False

        Dim coluna(100) As Integer

        For i As Integer = 0 To dgvFluido.Rows.Count - 1

            For j As Integer = 4 To dgvFluido.Columns.Count - 1

                If IsDBNull(dgvFluido.Rows(i).Cells(j).Value) = False Then

                    coluna(j) += 1

                End If

            Next
            'acabou a linha
        Next
        For j As Integer = 4 To dgvFluido.Columns.Count - 1

            If coluna(j) = 0 Then
                dgvFluido.Columns(j).Visible = False
            Else
                dgvFluido.Columns(j).Visible = True
            End If

        Next
    End Sub
    Private Sub Le_Pivot_Infusao()
        Dim dtpv As DataTable
        dtpv = ClsInt.LePivot(lbIdInternacao.Text, "Sp_Int_Pivot_Infusao")

        dgvInfusao.DataSource = dtpv

        dgvInfusao.DataSource = dtpv

        dgvInfusao.Columns(0).HeaderText = "Tp"
        dgvInfusao.Columns(1).HeaderText = "Descrição "
        dgvInfusao.Columns(2).HeaderText = "Data"
        Me.dgvInfusao.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgvInfusao.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvInfusao.Columns(3).Visible = False

        Dim coluna(100) As Integer

        For i As Integer = 0 To dgvInfusao.Rows.Count - 1

            For j As Integer = 4 To dgvInfusao.Columns.Count - 1

                If IsDBNull(dgvInfusao.Rows(i).Cells(j).Value) = False Then

                    coluna(j) += 1

                End If

            Next
            'acabou a linha
        Next
        For j As Integer = 4 To dgvInfusao.Columns.Count - 1

            If coluna(j) = 0 Then
                dgvInfusao.Columns(j).Visible = False
            Else
                dgvInfusao.Columns(j).Visible = True
            End If

        Next
    End Sub
    Private Sub btoIncItemNoProt_Click(sender As Object, e As EventArgs) Handles btoIncItemNoProt.Click

        If IsNumeric(txtDiasInt.Text) = False Then
            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Dias de Internação não informado.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDiasInt.Focus()
            Exit Sub

        End If

        If lbIdInternacao.Text > 0 Then

            'INCLUI AS MEDICAÇÕES
            MoveTelaBase_Medic()

            ClsInt.TipoOp = "1"

            ClsInt.m_Reg = lbIdInternacao.Text    '' /*  ID DA INTERNACAO */
            ClsInt.m_Hora = String.Format("{0:HH:mm:ss}", "00:00:01") 'dtpMedicHora.Value)
            Dim y As Integer = 1
            Dim x As Integer
            Do While x < txtDiasInt.Text

                ClsInt.m_Data = String.Format("{0:dd/MM/yyyy}", dtp.Value)

                For y = 1 To txtProtFreq.Text ''repete a frequencia da aplicacao

                    ClsInt.ManutReg_Medicacao() ' grava a medicação

                Next

                x += 1
                dtp.Value = dtp.Value.AddDays(x)
            Loop
            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Internação efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Registro :" & vbNewLine & "Não foi informado o ID da internação.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub btoAtuFluido_Click(sender As Object, e As EventArgs) Handles btoAtuFluido.Click
        ClsInt.fl_IDInter = lbIdInternacao.Text
        ClsInt.fl_TpFluido = cboFluido.SelectedValue
        ClsInt.fl_Data = dtpFluido.Value
        ClsInt.fl_Hora = ddhFluido.Text & ":" & ddmFluido.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text
        ClsInt.fl_Valor = txtValorFluido.Text
        ClsInt.fl_Id = 0
        ClsInt.TipoOp = "1"
        Dim r As Boolean
        r = ClsInt.ManutReg_Fluido()

        If r = True Then
            Le_Pivot_Fluido()

            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Fluidoterapia efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Fluidoterapia.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btoAtuInfusao_Click(sender As Object, e As EventArgs) Handles btoAtuInfusao.Click
        ClsInt.is_IDInter = lbIdInternacao.Text
        ClsInt.is_TpInfusao = cboInfusao.SelectedValue
        ClsInt.is_Data = dtpInfusao.Value
        ClsInt.is_Hora = ddhInfu.Text & ":" & ddmFluido.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text
        ClsInt.is_Valor = txtValorInfusao.Text
        ClsInt.is_Id = 0
        ClsInt.TipoOp = "1"
        Dim r As Boolean
        r = ClsInt.ManutReg_Infu()

        If r = True Then
            Le_Pivot_Infusao()

            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Infusão efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Infusão.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub dgExames_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgExames.CellContentClick
        Try

            Dim i As Integer = dgExames.CurrentCell.RowIndex
            Dim x As Integer = dgExames.CurrentCell.ColumnIndex
            Dim h As String

            If dgExames.Columns(x).HeaderText = "Descrição " Or
                dgExames.Columns(x).HeaderText = "Data" Then
                MessageBox.Show("Célula de Horário não selecionada." & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            dgExames.Rows(i).Cells(x).Value.ToString()
            h = dgExames.Columns(x).HeaderText
            ClsInt.ex_Hora = String.Format("{0:HH:mm:ss}", h) '' "01/01/1900 " & String.Format("{0:HH:mm:ss}", h)
            ClsInt.ex_IDInter = lbIdInternacao.Text
            ClsInt.ex_TpExame = dgExames.Rows(i).Cells(0).Value.ToString()
            ClsInt.ex_Data = dgExames.Rows(i).Cells(2).Value.ToString()
            ClsInt.ex_Valor = txtValorExame.Text
            ClsInt.ex_Id = lblIdExames.Text
            ClsInt.TipoOp = "4"

            ClsInt.LeRegExame()

            If ClsInt.ex_Id > 0 Then
                cboExames.SelectedValue = ClsInt.ex_TpExame
                ddh_exame.Text = Mid(ClsInt.ex_Hora, 1, 2)
                ddm_exame.Text = Mid(ClsInt.ex_Hora, 4, 2)
                txtValorExame.Text = ClsInt.ex_Valor
                lblIdExames.Text = ClsInt.ex_Id
            Else
                MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine _
                                & "Ocorreu um erro ao efetuar a Monitorização de Exames.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvFluido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFluido.CellContentClick
        Try

            Dim i As Integer = dgvFluido.CurrentCell.RowIndex
            Dim x As Integer = dgvFluido.CurrentCell.ColumnIndex
            Dim h As String

            If dgvFluido.Columns(x).HeaderText = "Descrição " Or
                dgvFluido.Columns(x).HeaderText = "Data" Then
                MessageBox.Show("Célula de Horário não selecionada da Fluidoterapia.." & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            dgvFluido.Rows(i).Cells(x).Value.ToString()
            h = dgvFluido.Columns(x).HeaderText
            ClsInt.fl_Hora = String.Format("{0:HH:mm:ss}", h) '' "01/01/1900 " & String.Format("{0:HH:mm:ss}", h)
            ClsInt.fl_IDInter = lbIdInternacao.Text
            ClsInt.fl_TpFluido = dgvFluido.Rows(i).Cells(0).Value.ToString()
            ClsInt.fl_Data = dgvFluido.Rows(i).Cells(2).Value.ToString()
            ClsInt.fl_Valor = txtValorFluido.Text
            ClsInt.fl_Id = lbIdFluido.Text
            ClsInt.TipoOp = "4"

            ClsInt.LeRegFluido()

            If ClsInt.fl_Id > 0 Then
                cboExames.SelectedValue = ClsInt.fl_TpFluido
                ddhFluido.Text = Mid(ClsInt.fl_Hora, 1, 2)
                ddmFluido.Text = Mid(ClsInt.fl_Hora, 4, 2)
                txtValorFluido.Text = ClsInt.fl_Valor
                lbIdFluido.Text = ClsInt.fl_Id
            Else
                MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine _
               & "Ocorreu um erro ao efetuar a Monitorização da Fluidoterapia.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvInfusao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInfusao.CellContentClick
        Try
            Dim i As Integer = dgvInfusao.CurrentCell.RowIndex
            Dim x As Integer = dgvInfusao.CurrentCell.ColumnIndex
            Dim h As String

            If dgvInfusao.Columns(x).HeaderText = "Descrição " Or
                dgvInfusao.Columns(x).HeaderText = "Data" Then
                MessageBox.Show("Célula de Horário não selecionada." & vbNewLine _
                & "Ocorreu um erro ao efetuar a Monitorização da Infusão.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            dgvInfusao.Rows(i).Cells(x).Value.ToString()
            h = dgvInfusao.Columns(x).HeaderText
            ClsInt.is_Hora = String.Format("{0:HH:mm:ss}", h) '' "01/01/1900 " & String.Format("{0:HH:mm:ss}", h)
            ClsInt.is_IDInter = lbIdInternacao.Text
            ClsInt.is_TpInfusao = dgvInfusao.Rows(i).Cells(0).Value.ToString()
            ClsInt.is_Data = dgvInfusao.Rows(i).Cells(2).Value.ToString()
            ClsInt.is_Valor = txtValorInfusao.Text
            ClsInt.is_Id = lbIdInfusao.Text
            ClsInt.TipoOp = "4"

            ClsInt.LeRegInfu()

            If ClsInt.is_Id > 0 Then
                cboInfusao.SelectedValue = ClsInt.is_TpInfusao
                ddhInfu.Text = Mid(ClsInt.is_Hora, 1, 2)
                ddmInfu.Text = Mid(ClsInt.is_Hora, 4, 2)
                txtValorInfusao.Text = ClsInt.is_Valor
                lbIdInfusao.Text = ClsInt.is_Id
            Else
                MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine _
                  & "Ocorreu um erro ao efetuar a Monitorização da Infusão.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btoExInfusao_Click(sender As Object, e As EventArgs) Handles btoExInfusao.Click
        ClsInt.is_IDInter = lbIdInternacao.Text
        ClsInt.is_TpInfusao = cboInfusao.SelectedValue
        ClsInt.is_Data = dtpInfusao.Value
        ClsInt.is_Hora = ddhInfu.Text & ":" & ddmFluido.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text
        ClsInt.is_Valor = txtValorInfusao.Text
        ClsInt.is_Id = lbIdInfusao.Text
        ClsInt.TipoOp = "3"
        Dim r As Boolean
        r = ClsInt.ManutReg_Infu()
        If r = True Then
            Le_Pivot_Infusao()
            MessageBox.Show("Aviso de Exclusão de Registro :" & vbNewLine & "EXCLUSÃO de Infusão efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Infusão.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btoExFluido_Click(sender As Object, e As EventArgs) Handles btoExFluido.Click
        ClsInt.fl_IDInter = lbIdInternacao.Text
        ClsInt.fl_TpFluido = cboFluido.SelectedValue
        ClsInt.fl_Data = dtpFluido.Value
        ClsInt.fl_Hora = ddhFluido.Text & ":" & ddmFluido.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text
        ClsInt.fl_Valor = txtValorFluido.Text
        ClsInt.fl_Id = lbIdFluido.Text
        ClsInt.TipoOp = "3"
        Dim r As Boolean
        r = ClsInt.ManutReg_Fluido()
        If r = True Then
            Le_Pivot_Fluido()
            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "EXCLUSÃO de Fluidoterapia efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Fluidoterapia.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btoExclExames_Click(sender As Object, e As EventArgs) Handles btoExclExames.Click
        ClsInt.ex_IDInter = lbIdInternacao.Text
        ClsInt.ex_TpExame = cboExames.SelectedValue
        ClsInt.ex_Data = dtpDtExame.Value
        ClsInt.ex_Hora = ddh_exame.Text & ":" & ddm_exame.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text
        ClsInt.ex_Valor = txtValorExame.Text
        ClsInt.ex_Id = lblIdExames.Text
        ClsInt.TipoOp = "3"
        Dim r As Boolean
        r = ClsInt.ManutReg_Exames()

        If r = True Then
            Le_Pivot_Exames()

            MessageBox.Show("Aviso de EXCLUSÃO de Registro :" & vbNewLine & "EXCLUSÃO de Exame efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar o Exame.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btoExclMonit_Click(sender As Object, e As EventArgs) Handles btoExclMonit.Click

        dtpMonitorizacao.Value = Now

        ClsInt.intMonit_IDInter = lbIdInternacao.Text
        ClsInt.intMonit_Tp = cboMonitTp.SelectedValue
        ClsInt.intMonit_Data = dtpMonitorizacao.Value

        ClsInt.intMonit_Hora = ddH.Text & ":" & ddM.Text ''"01/01/1900 " & ddH.Text & ":" & ddM.Text

        ClsInt.intMonit_Valor = txtMonitValor.Text

        ClsInt.TipoOp = "3"
        Dim r As Boolean
        r = ClsInt.ManutReg_Monitorizacao()

        If r = True Then
            Le_Pivot_Monit()
            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "EXCLUSÃO de Monitorização efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Monitorização.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub MoveTb_Evolu()
        ClsInt.ev_Hora = String.Format("{0:HH:mm:ss}", Now)
        ClsInt.ev_IDInter = lbIdInternacao.Text
        ClsInt.ev_Data = Now
        ClsInt.ev_Descricao = txtValorEvolu.Text
        ClsInt.ev_Id = lbIdEvolu.Text
    End Sub
    Private Sub MoveBt_Evolu()
        dtpEvolu.Value = ClsInt.ev_Data
        ddh_Evolu.Text = Mid(ClsInt.ev_Hora, 1, 2)
        ddm_Evolu.Text = Mid(ClsInt.ev_Hora, 4, 2)
        txtValorEvolu.Text = ClsInt.ev_Descricao
        lbIdEvolu.Text = ClsInt.ev_Id
    End Sub
    Private Sub Le_Evolucoes()
        ''Evolucao
        ClsInt.TipoOp = 6
        MoveTb_Evolu()
        Dim dt As DataTable
        dt = ClsInt.LeEvolu_da_Int(6, lbIdInternacao.Text)
        dgEvolu.DataSource = dt

        dgEvolu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgEvolu.Columns(0).HeaderText = "Data "
        dgEvolu.Columns(0).Width = 50
        dgEvolu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgEvolu.Columns(1).HeaderText = "ID"
        dgEvolu.Columns(1).Width = 20
    End Sub

    Private Sub btoAtuEvolucao_Click(sender As Object, e As EventArgs) Handles btoAtuEvolucao.Click
        MoveTb_Evolu()
        ClsInt.TipoOp = "1"
        Dim r As Boolean
        r = ClsInt.ManutReg_Evolu()

        If r = True Then
            Le_Evolucoes()
            MessageBox.Show("Aviso de inclusão de Registro :" & vbNewLine & "Inclusão de Evolução efetuada com sucesso.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Aviso de Erro de Registro :" & vbNewLine & "Ocorreu um erro ao efetuar a Evolução.", " Aviso :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class