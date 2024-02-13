Imports System.Windows.Forms
Imports DataBase
Public Class frmConsulta
    Private clsPront As New Cls_Prontuario
    Public Property codigo_do_Paciente As Integer
    Private Sub Le_Consultas()

        'Preenche CONSULTAS REALIZADAS

        Dim dtg As DataTable
        dtg = clsPront.LeConsultasAni
        dgAtendimentos.DataSource = dtg

        dgAtendimentos.Columns(0).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(0).HeaderText = " Data "
        dgAtendimentos.Columns(0).Width = 10
        dgAtendimentos.Columns(1).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(1).HeaderText = " hora "
        dgAtendimentos.Columns(1).Width = 10
        dgAtendimentos.Columns(1).DefaultCellStyle.Format = "HH:mm"
        dgAtendimentos.Columns(2).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(2).HeaderText = "Tipo"
        dgAtendimentos.Columns(2).Width = 10
        dgAtendimentos.Columns(3).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAtendimentos.Columns(3).HeaderText = " ID "
        dgAtendimentos.Columns(3).Width = 10

    End Sub
    Private Sub LimpaFormulario()
        ''LIMPA O FORMULARIO
        opConsulta.Checked = True
        rtbAnaminese.Text = ""
        txtTemp.Text = ""
        txtPeso.Text = ""
        txtRPM.Text = ""
        txtBPM.Text = ""
        txtPA.Text = ""
        rtbHistorico.Text = ""
        rtbPrognostico.Text = ""
        rtbDiagnostico.Text = ""
        mcRetorno.SelectionStart = Now
        mcRetorno.SelectionEnd = Now

        Le_Consultas()
    End Sub
    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clsPront.Cons_Animal = codigo_do_Paciente
        Le_Consultas()

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

        btnExcluir.Enabled = False
        btnAlterar.Enabled = False

    End Sub

    Private Sub dgAtendimentos_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgAtendimentos.CellContentClick

        clsPront.Cons_ID = dgAtendimentos.CurrentRow.Cells(3).Value.ToString()
        clsPront.BuscaAConsulta()

        If clsPront.Cons_Tipo = "C" Then
            opConsulta.Checked = True
        End If

        rtbAnaminese.Text = clsPront.Cons_Anamnese
        txtTemp.Text = clsPront.Cons_t
        txtPeso.Text = clsPront.Cons_Peso
        txtRPM.Text = clsPront.Cons_RPM
        txtBPM.Text = clsPront.Cons_BPM
        txtPA.Text = clsPront.Cons_PA
        rtbHistorico.Text = clsPront.Cons_Histsic
        rtbPrognostico.Text = clsPront.Cons_Prog
        rtbDiagnostico.Text = clsPront.Cons_Diag
        mcRetorno.SelectionStart = clsPront.Cons_DtRet
        mcRetorno.SelectionEnd = clsPront.Cons_DtRet
        btnAlterar.Enabled = True
        btnExcluir.Enabled = True

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Try
            MoveRegistro()

            ''EFETUA A INCLUSAO
            clsPront.TipoOperacao = "I"
            clsPront.Insert_Consulta_iud()
            MessageBox.Show("Consulta cadastrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpaFormulario()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub MoveRegistro()
        clsPront.Cons_Animal = codigo_do_Paciente
        clsPront.Cons_Data = Now
        clsPront.Cons_Hora = Now

        If opConsulta.Checked = True Then
            clsPront.Cons_Tipo = "C"
        Else
            clsPront.Cons_Tipo = "R"
        End If

        clsPront.Cons_Anamnese = rtbAnaminese.Text
        clsPront.Cons_t = txtTemp.Text
        clsPront.Cons_Peso = txtPeso.Text
        clsPront.Cons_RPM = txtRPM.Text
        clsPront.Cons_BPM = txtBPM.Text
        clsPront.Cons_PA = txtPA.Text
        clsPront.Cons_Histsic = rtbHistorico.Text
        clsPront.Cons_Prog = rtbPrognostico.Text
        clsPront.Cons_Diag = rtbDiagnostico.Text
        mcRetorno.SelectionStart = Now
        mcRetorno.SelectionEnd = Now
        clsPront.Cons_DtRet = mcRetorno.SelectionStart.ToShortDateString

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            If clsPront.Cons_ID = 0 Then
                MessageBox.Show("Id da Consulta não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            MoveRegistro()
            '    clsPront.UpDate_Consulta()

            clsPront.TipoOperacao = "U"
            clsPront.Insert_Consulta_iud()
            MessageBox.Show("Alteração da Consulta efetuada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpaFormulario()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If clsPront.Cons_ID = 0 Then
                MessageBox.Show("Id da Consulta não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja deltear os registros desta consulta ??", "Exclusão de Consulta",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button1, 0)
            If StrMsg = 6 Then 'vbYes
                ' clsPront.Cons_Animal = codigo_do_Paciente

                'clsPront.DeletaConsulta()
                clsPront.TipoOperacao = "D"
                clsPront.Insert_Consulta_iud()
                MessageBox.Show("Exclusão da Consulta efetuada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpaFormulario()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
    End Sub
End Class