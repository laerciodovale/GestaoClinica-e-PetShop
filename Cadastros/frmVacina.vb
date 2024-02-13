Imports System.ComponentModel
Imports System.Windows.Forms
Imports DataBase
Imports System.Drawing
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmVacina
    Private clsPront As New Cls_Prontuario
    Public Property Paciente_Id_Vacina As Integer
    Private Sub LimparForm(ByVal controlP As Control)

        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = "0" 'String.Empty

            ElseIf TypeOf ctl Is ComboBox Then
                DirectCast(ctl, ComboBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = Now

            ElseIf TypeOf ctl Is CheckBox Then
                DirectCast(ctl, CheckBox).Checked = True

            ElseIf ctl.Controls.Count > 0 Then
                LimparForm(ctl)
            End If
        Next

    End Sub

    Private Sub PlanoDeVacina()
        Try

            If ckPuppy.Checked = True Then
                mskPuppy.Text = Now
                ckV1Dose.Checked = True
                mskDose1.Text = DateAdd("d", 21, mskPuppy.Text)
                ckV2Dose.Checked = True
                mskDose2.Text = DateAdd("d", 21, mskDose1.Text)
                ckV3Dose.Checked = True
                mskDose3.Text = DateAdd("d", 42, mskDose1.Text)

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)

                mskGiar1.Text = mskDose2.Text
                mskGiar2.Text = mskDose3.Text

                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)
                ckTosse.Checked = True
                mskTosse.Text = DateAdd("d", 21, mskDose1.Text)

            ElseIf ckV1Dose.Checked = True Then
                ckPuppy.Checked = False
                mskPuppy.Text = ""

                mskDose1.Text = Now

                ckV2Dose.Checked = True
                mskDose2.Text = DateAdd("d", 21, mskDose1.Text)
                ckV3Dose.Checked = True
                mskDose3.Text = DateAdd("d", 42, mskDose1.Text)

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)

                mskGiar1.Text = mskDose2.Text
                mskGiar2.Text = mskDose3.Text

                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)
                ckTosse.Checked = True
                mskTosse.Text = DateAdd("d", 21, mskDose1.Text)

            ElseIf ckV2Dose.Checked = True Then
                ckPuppy.Checked = False
                mskPuppy.Text = ""
                ckV1Dose.Checked = False
                mskDose1.Text = ""

                mskDose2.Text = Now

                ckV3Dose.Checked = True
                mskDose3.Text = DateAdd("d", 21, mskDose2.Text)

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)

                mskGiar1.Text = mskDose2.Text
                mskGiar2.Text = mskDose3.Text

                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)

            ElseIf ckV3Dose.Checked = True Then
                ckPuppy.Checked = False
                mskPuppy.Text = ""
                ckV1Dose.Checked = False
                mskDose1.Text = ""
                ckV2Dose.Checked = False
                mskDose2.Text = ""

                mskDose3.Text = Now

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)
                mskGiar2.Text = mskDose3.Text
                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmVacina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Paciente_Id_Vacina = 0 Then
            MessageBox.Show("Paciente não informado." & vbCr & "Tela encerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
        End If

        clsPront.Vc_Ani = Paciente_Id_Vacina
        Dim dt As DataTable = clsPront.LeVacina("Sp_FinA_Vacina", clsPront.Vc_Ani)
        ''''''
        dgVacinasEfetuadas.DataSource = dt

        If dt.Rows.Count.ToString = 0 Then
            MessageBox.Show("Vacina sem movimento no financeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
        End If

        dgVacinasEfetuadas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasEfetuadas.Columns(0).HeaderText = "Data Efetiva"
        dgVacinasEfetuadas.Columns(0).Width = 8
        dgVacinasEfetuadas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasEfetuadas.Columns(1).HeaderText = "Descrição da Vacina"
        dgVacinasEfetuadas.Columns(1).Width = 70

        '''' vacinas cadastradas para o paciente

        Dim dtV As DataTable = clsPront.LeVacina("Sp_Vacinas_Sel", clsPront.Vc_Ani)
        dgVacinasCadastradas.DataSource = dtV

        If dtV.Rows.Count.ToString = 0 Then
            MessageBox.Show("Vacina sem movimento no financeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
        End If

        dgVacinasCadastradas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub

    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click

        clsPront.TipoOperacao = "I"
        clsPront.Vc_Ani = Paciente_Id_Vacina
        clsPront.Vc_Contato = 0
        clsPront.Vc_Dt = Now

        Try
            If ckPuppy.Checked = True Then
                clsPront.Vc_Tp = "PUPPY"
                clsPront.Vc_Data = FormatDateTime(mskPuppy.Text, DateFormat.ShortDate)
                clsPront.Vc_Mes = Mid(mskPuppy.Text, 4, 2)
                clsPront.Vc_Dose = 0
                clsPront.Vc_Item = "PUPPY"
                clsPront.InsertVacina()

            End If
            clsPront.Vc_Item = "154"
            If ckV1Dose.Checked = True Then
                clsPront.Vc_Tp = "1 VACINA"
                clsPront.Vc_Data = mskDose1.Text
                clsPront.Vc_Mes = Mid(mskDose1.Text, 4, 2)
                clsPront.Vc_Dose = 1
                clsPront.InsertVacina()

            End If
            If ckV2Dose.Checked = True Then
                clsPront.Vc_Tp = "2 VACINA"
                clsPront.Vc_Data = mskDose2.Text
                clsPront.Vc_Mes = Mid(mskDose2.Text, 4, 2)
                clsPront.Vc_Dose = 2
                clsPront.InsertVacina()

            End If
            If ckV3Dose.Checked = True Then
                clsPront.Vc_Tp = "3 VACINA"
                clsPront.Vc_Data = mskDose3.Text
                clsPront.Vc_Mes = Mid(mskDose3.Text, 4, 2)
                clsPront.Vc_Dose = 3
                clsPront.InsertVacina()

            End If

            If ckV1Reforco.Checked = True Then
                clsPront.Vc_Tp = "1 REFORCO"
                clsPront.Vc_Data = mskRefor1.Text
                clsPront.Vc_Mes = Mid(mskRefor1.Text, 4, 2)
                clsPront.Vc_Dose = 1
                clsPront.InsertVacina()

            End If
            If ckV2Reforco.Checked = True Then
                clsPront.Vc_Tp = "2 REFORCO"
                clsPront.Vc_Data = mskRefor2.Text
                clsPront.Vc_Mes = Mid(mskRefor2.Text, 4, 2)
                clsPront.Vc_Dose = 2
                clsPront.InsertVacina()

            End If
            clsPront.Vc_Item = "GIARDIASE"
            If ckG1Dose.Checked = True Then
                clsPront.Vc_Tp = "1 GIARDIASE"
                clsPront.Vc_Data = mskRefor1.Text
                clsPront.Vc_Mes = Mid(mskRefor1.Text, 4, 2)
                clsPront.Vc_Dose = 1
                clsPront.InsertVacina()

            End If
            If ckG2Dose.Checked = True Then
                clsPront.Vc_Tp = "2 GIARDIASE"
                clsPront.Vc_Data = mskGiar2.Text
                clsPront.Vc_Mes = Mid(mskGiar2.Text, 4, 2)
                clsPront.Vc_Dose = 2
                clsPront.InsertVacina()

            End If

            clsPront.Vc_Dose = 1
            clsPront.Vc_Item = "A-R"
            clsPront.Vc_Tp = "ANTI-RABICA"
            clsPront.Vc_Data = mskAntR.Text
            clsPront.Vc_Mes = Mid(mskAntR.Text, 4, 2)
            clsPront.InsertVacina()

            If ckTosse.Checked = True Then
                clsPront.Vc_Item = "vbronq"
                clsPront.Vc_Tp = "TOSSE"
                clsPront.Vc_Data = mskTosse.Text
                clsPront.Vc_Mes = Mid(mskTosse.Text, 4, 2)
                clsPront.InsertVacina()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmVacina_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call Me.LimparForm(Me)
        mskPuppy.Text = Now
        mskDose1.Text = Now
        mskDose2.Text = Now
        mskDose3.Text = Now

        ''Preenche A ListBox
        Dim dt As DataTable = clsPront.LeGrpVacina()
        cboVacinas.DisplayMember = "itdesc"
        cboVacinas.ValueMember = "ititem"
        cboVacinas.DataSource = dt

        PlanoDeVacina()

    End Sub

    Private Sub cboVacinas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVacinas.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btoImpirmir_Click(sender As Object, e As EventArgs) Handles btoImpirmir.Click
        Try


            frmCrystal.Show()
            Dim Caminho As String
            Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryVacinaPlano.rpt"

            Dim cryRpt As New ReportDocument
            frmCrystal.Show()
            cryRpt.Load(Caminho)
            cryRpt.ParameterFields("IdPaciente").CurrentValues.AddValue(Convert.ToInt32(Paciente_Id_Vacina))
            frmCrystal.crtVwGeral.ReportSource = cryRpt
            frmCrystal.crtVwGeral.Refresh()

            Exit Sub





            Me.Cursor = System.Windows.Forms.Cursors.AppStarting
            frmCrystal.Show()
            '   Dim Caminho As String
            Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryVacinaPlano.rpt"

            Dim CR As New ReportDocument
            CR.Load(Caminho)

            Dim crParameterDiscreteValue As ParameterDiscreteValue
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldLocation As ParameterFieldDefinition
            Dim crParameterValues As ParameterValues

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
            crParameterFieldLocation = crParameterFieldDefinitions.Item("IdPaciente")
            crParameterValues = crParameterFieldLocation.CurrentValues
            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterDiscreteValue.Value = Paciente_Id_Vacina

            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

            frmCrystal.crtVwGeral.ReportSource = CR
            frmCrystal.crtVwGeral.Refresh()

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class