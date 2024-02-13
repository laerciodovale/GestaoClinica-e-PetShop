Imports System.Drawing
Imports System.Windows.Forms
Imports DataBase
Public Class frmCtaPg
    Private cls_Finan As New Cls_Financeiro
    Private TpLanca As Integer
    Private CCusto As Integer
    Private Cgc As String
    Private NtF As Integer
    Private DtLan As Date
    Private DtVcto As Date
    Private VTotal As Double
    Private VDupl As Double
    Private NroDupl As Integer
    Private Sub Limpa()
        txtInicio.Value = Format(Now, "dd-MM-yyyy")
        txtTermino.Value = Format(Now, "dd-MM-yyyy")

        txtId.Text = 0
        cboEvento.SelectedItem = 1
        cboCusto.SelectedItem = 1
        cboInstituicao.SelectedItem = 1
        txtNroNtF.Text = 0
        txtDtNtF.Text = 0
        txtDtVcto.Text = 0
        txtDtPagto.Text = 0
        txtVTotal.Text = 0
        txtVDupl.Text = 0
        txtNroDupl.Text = 0
        txtOrdemDupl.Text = 0
        txtDocPagto.Text = 0
        txtTotalLancDupl.Text = 0
        btoExcluir.Enabled = False

        txtDtPagto.Text = Format(Now, "dd-MM-yyyy")
        txtVdoPagto.Text = 0
        txtDocPagto.Text = 0

        btoIncluir.Enabled = True
        txtDtNtF.Enabled = True
        txtVTotal.Enabled = True
    End Sub
    Private Sub LeCtaPg()
        Dim dtg As DataTable
        dtg = cls_Finan.Busca_CtaPg_DoDia(txtInicio.Value.ToString, txtTermino.Value.ToString)
        DgCtaPg.DataSource = dtg
        If DgCtaPg.Rows.Count > 0 Then
            formata_dg()

        End If

    End Sub
    Private Sub LeInstituicao()

        Dim dtg As DataTable
        dtg = cls_Finan.Busca_CtaPg_DoFor(cboInstituicao.SelectedValue)
        dgDoFornec.DataSource = dtg

        dgDoFornec.Columns(0).HeaderText = "Dt.Nota"
        dgDoFornec.Columns(0).Width = 70
        dgDoFornec.Columns(0).DefaultCellStyle.Format = "dd-MM-yyyy"

        dgDoFornec.Columns(1).HeaderText = "Nro.Nt"
        dgDoFornec.Columns(1).Width = 60
        dgDoFornec.Columns(2).HeaderText = "Vlr.Nota "
        dgDoFornec.Columns(2).Width = 80
        dgDoFornec.Columns(2).DefaultCellStyle.Format = "C2"

        dgDoFornec.Columns(3).HeaderText = "Fatura"
        dgDoFornec.Columns(3).Width = 80
        dgDoFornec.Columns(4).HeaderText = "Nro."
        dgDoFornec.Columns(4).Width = 60
        dgDoFornec.Columns(5).HeaderText = "Vencimento"
        dgDoFornec.Columns(5).Width = 70

        dgDoFornec.Columns(6).HeaderText = "Vlr.Dpl."
        dgDoFornec.Columns(6).Width = 80
        dgDoFornec.Columns(6).DefaultCellStyle.Format = "C2"
        dgDoFornec.Columns(7).HeaderText = "Dt.Pagto."
        dgDoFornec.Columns(7).Width = 70
        dgDoFornec.Columns(8).HeaderText = "Vlr. Pago"
        dgDoFornec.Columns(8).Width = 80
        dgDoFornec.Columns(8).DefaultCellStyle.Format = "C2"

        dgDoFornec.Columns(9).HeaderText = "Saldo"
        dgDoFornec.Columns(9).Width = 80
        dgDoFornec.Columns(9).DefaultCellStyle.Format = "C2"

        dgDoFornec.Columns(10).HeaderText = "Forma de Pagto."
        dgDoFornec.Columns(10).Width = 200

        dgDoFornec.Columns(11).HeaderText = "ID"
        dgDoFornec.Columns(11).Width = 5

        Dim valorAberto As Decimal = 0
        Dim Saldo As Double = 0
        For Each Row As DataGridViewRow In dgDoFornec.Rows

            If Row.Cells(8).Value = 0 Then
                valorAberto = valorAberto + Convert.ToDecimal(Row.Cells(6).Value)
            Else
                Row.DefaultCellStyle.BackColor = Color.Aquamarine
            End If

            Saldo += CDbl(valorAberto) - CDbl(Saldo)
            Row.Cells(9).Value = Saldo
        Next

        txtAberto.Text = Format(valorAberto, "0.00")


    End Sub
    Private Sub MoveRegDupl()
        txtId.Text = cls_Finan.CT_ID
        txtNroDupl.Text = cls_Finan.CT_FATURA
        txtOrdemDupl.Text = cls_Finan.CT_DUPL
        txtDtVcto.Text = cls_Finan.CT_DTVCTO
        txtVDupl.Text = cls_Finan.CT_VALOR

        btoExcluir.Enabled = True
        btoIncluir.Enabled = False

        txtVdoPagto.Text = cls_Finan.CT_VALORP
        txtDtPagto.Text = cls_Finan.CT_DTPAGTO
        txtHist.Text = cls_Finan.CT_HISTREG
        txtDocPagto.Text = cls_Finan.CT_DOCPG

        If cls_Finan.CT_VALORP > 0 Then
            btoPagto.Enabled = False
            btoEstorno.Enabled = True
            txtDtNtF.Focus()
        Else
            txtDtPagto.Text = Format(Now, "dd/MM/yyyy")
            txtVdoPagto.Text = cls_Finan.CT_VALOR

            cboFPagto.Focus()

            btoEstorno.Enabled = False
            btoPagto.Enabled = True
        End If

    End Sub

    Private Sub SomasDaNota()
        Dim dt As DataTable
        dt = cls_Finan.Busca_CtaPgNtf()
        dgDupl.DataSource = dt

        '' dgDupl.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDupl.Columns(0).HeaderText = "Id"
        dgDupl.Columns(0).Width = 35

        ''dgDupl.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDupl.Columns(1).HeaderText = "Vcto."
        dgDupl.Columns(1).Width = 80

        ''dgDupl.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDupl.Columns(2).HeaderText = "Valor"
        dgDupl.Columns(2).Width = 70
        dgDupl.Columns(2).DefaultCellStyle.Format = "C2"

        ''  dgDupl.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDupl.Columns(3).HeaderText = "$ Pagto."
        dgDupl.Columns(3).Width = 80
        dgDupl.Columns(3).DefaultCellStyle.Format = "C2"

        ''dgDupl.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDupl.Columns(4).HeaderText = "$ Nota"
        dgDupl.Columns(4).Width = 80
        dgDupl.Columns(4).DefaultCellStyle.Format = "C2"

        dgDupl.Columns(5).HeaderText = "id"
        dgDupl.Columns(5).Width = 1
        dgDupl.Columns(5).DefaultCellStyle.Format = "C2"

        Dim valor As Decimal = 0
        Dim valorPago As Decimal = 0
        Dim ValorNota As Decimal = 0

        For Each Row As DataGridViewRow In dgDupl.Rows
            If Row.Cells(2).Value > 0 Then
                valor += Convert.ToDecimal(Row.Cells(2).Value)
                valorPago += Convert.ToDecimal(Row.Cells(3).Value)
                ValorNota = Convert.ToDecimal(Row.Cells(4).Value)
            End If
        Next

        txtTotalLancDupl.Text = Format(valor, "0.00")
        txtValorPago.Text = Format(valorPago, "0.00")
        txtVTotal.Text = Format(ValorNota, "0.00")

        txtFaltante.Text = Format((ValorNota - valorPago), "0.00")

        btoExcluir.Enabled = False
        btoIncluir.Enabled = False

        If txtVTotal.Text <> valor Then
            btoIncluir.Enabled = True
        End If

    End Sub
    Private Sub Move_Tela_Base()

        With cls_Finan

            .CT_ID = txtId.Text
            .CT_EVENTO = Format(cboEvento.SelectedValue, "00000")
            .CT_CCUSTO = cboCusto.SelectedValue
            .CT_FORNEC = cboInstituicao.SelectedValue

            .CT_NF = txtNroNtF.Text
            .CT_DTNF = txtDtNtF.Text
            .CT_DTVCTO = txtDtVcto.Text

            .CT_DTPAGTO = "01-01-1900" 'txtDtVcto.Text

            .CT_VALOR = txtVDupl.Text
            .CT_VALORP = 0
            .CT_FATURA = txtNroDupl.Text

            ''.Conta_Registros()

            .CT_DUPL = txtOrdemDupl.Text
            .CT_DOCPG = txtDocPagto.Text
            .CT_VALORNTF = txtVTotal.Text
            .CT_FPAGTO = cboFPagto.SelectedValue
            .CT_HISTREG = txtHist.Text

        End With
    End Sub
    Private Sub MOve_Base_Tela()

        With cls_Finan

            txtId.Text = .CT_ID

            cboEvento.SelectedValue = .CT_EVENTO
            cboCusto.SelectedValue = .CT_CCUSTO
            cboInstituicao.SelectedValue = .CT_FORNEC

            txtNroNtF.Text = .CT_NF
            txtDtNtF.Text = .CT_DTNF
            txtDtVcto.Text = .CT_DTVCTO
            txtDtPagto.Text = .CT_DTPAGTO
            txtVTotal.Text = .CT_VALOR
            txtVDupl.Text = .CT_VALORP
            txtNroDupl.Text = .CT_FATURA
            txtOrdemDupl.Text = .CT_DUPL
            txtDocPagto.Text = .CT_DOCPG

            cboFPagto.SelectedValue = .CT_FPAGTO
            txtHist.Text = .CT_HISTREG

        End With
    End Sub
    'Private Sub ListBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseMove

    '    Label11.Text = e.X
    '    Label12.Text = e.Y

    'End Sub
    Private Sub formata_dg()

        DgCtaPg.Columns(0).HeaderText = "Fornecedor  "
        DgCtaPg.Columns(0).Width = 100
        DgCtaPg.Columns(1).HeaderText = "CPF/CNPF  "
        DgCtaPg.Columns(1).Width = 80

        DgCtaPg.Columns(2).HeaderText = "Dt.Nota"
        DgCtaPg.Columns(2).Width = 70
        DgCtaPg.Columns(3).HeaderText = "Nro.Nt"
        DgCtaPg.Columns(3).Width = 60
        DgCtaPg.Columns(4).HeaderText = "Vlr.Nota "
        DgCtaPg.Columns(4).Width = 80
        DgCtaPg.Columns(4).DefaultCellStyle.Format = "C2"

        DgCtaPg.Columns(5).HeaderText = "Fatura"
        DgCtaPg.Columns(5).Width = 60
        DgCtaPg.Columns(6).HeaderText = "Nro."
        DgCtaPg.Columns(6).Width = 50
        DgCtaPg.Columns(7).HeaderText = "Vencimento"
        DgCtaPg.Columns(7).Width = 70

        DgCtaPg.Columns(8).HeaderText = "Vlr.Dpl."
        DgCtaPg.Columns(8).Width = 80
        DgCtaPg.Columns(8).DefaultCellStyle.Format = "C2"
        DgCtaPg.Columns(9).HeaderText = "Dt.Pagto."
        DgCtaPg.Columns(9).Width = 70
        DgCtaPg.Columns(10).HeaderText = "Vlr. Pago"
        DgCtaPg.Columns(10).Width = 80
        DgCtaPg.Columns(10).DefaultCellStyle.Format = "C2"
        DgCtaPg.Columns(11).HeaderText = "Forma de Pagto."
        DgCtaPg.Columns(11).Width = 150
        DgCtaPg.Columns(12).HeaderText = "ID"
        DgCtaPg.Columns(12).Width = 10
        Dim SldAb As Double
        Dim SldPago As Double
        Dim SldTotal As Double
        For Each Row As DataGridViewRow In DgCtaPg.Rows
            SldTotal = CDbl(SldTotal) + CDbl(Row.Cells(8).Value)

            If Row.Cells(10).Value = 0 Then '' nao pagou
                SldAb = CDbl(SldAb) + CDbl(Row.Cells(8).Value)
                ''Row.Cells(4).Value = SldFat
            Else
                SldPago = CDbl(SldPago) + CDbl(Row.Cells(8).Value)
                '' Row.Cells(6).Value = SldRec

            End If
        Next

        txtDeb.Text = SldTotal
        txtPago.Text = SldPago
        txtAPagar.Text = SldAb

    End Sub
    Private Sub frmCtaPg_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpa()

        Dim dt As DataTable

        dt = cls_Finan.Busca_Procedure("Sp_Evento_Sel")
        cboEvento.DisplayMember = "evdesc"
        cboEvento.ValueMember = "evred"
        cboEvento.DataSource = dt

        dt = cls_Finan.Busca_Procedure("Sp_CCusto_Sel")
        cboCusto.DisplayMember = "cdesc"
        cboCusto.ValueMember = "ccusto"
        cboCusto.DataSource = dt

        dt = cls_Finan.Busca_Procedure("Sp_Fornecedor_SelTodos")
        cboInstituicao.DisplayMember = "frazao"
        cboInstituicao.ValueMember = "fcgc"
        cboInstituicao.DataSource = dt

        dt = cls_Finan.Busca_Procedure("Sp_FPgto_Sel")
        cboFPagto.DisplayMember = "FpgtoDesc"
        cboFPagto.ValueMember = "Fpgtoid"
        cboFPagto.DataSource = dt
        cboFPagto.SelectedValue = 11

    End Sub

    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click
        Try
            Move_Tela_Base()
            cls_Finan.IncluirCtaPagar()

            SomasDaNota()
            LeInstituicao()
            txtOrdemDupl.Focus()
            btoIncluir.Enabled = True
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso importante.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        End Try

    End Sub


    Private Sub txtNroDupl_LostFocus(sender As Object, e As EventArgs) Handles txtNroDupl.LostFocus

        Try
            cls_Finan.CT_FORNEC = cboInstituicao.SelectedValue
            cls_Finan.CT_NF = txtNroNtF.Text

            cls_Finan.Conta_Registros()

            txtOrdemDupl.Text = cls_Finan.CT_DUPL

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso importante.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

    Private Sub btoExcluir_Click(sender As Object, e As EventArgs) Handles btoExcluir.Click
        Try
            cls_Finan.DeleteRegDupl(txtId.Text)

            txtId.Text = 0
            txtNroDupl.Text = ""
            txtOrdemDupl.Text = 0
            txtDtVcto.Text = Now
            txtVDupl.Text = 0
            btoExcluir.Enabled = False
            btoIncluir.Enabled = True

            cls_Finan.Conta_Registros()
            txtOrdemDupl.Text = cls_Finan.CT_DUPL

            SomasDaNota()
            LeInstituicao()
            btoIncluir.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNroNtF_LostFocus(sender As Object, e As EventArgs) Handles txtNroNtF.LostFocus
        Try

            cls_Finan.Busca_Nota(cboInstituicao.SelectedValue, txtNroNtF.Text)

            If cls_Finan.CT_ID > 0 Then
                MOve_Base_Tela()

                txtId.Text = cls_Finan.CT_ID

                cls_Finan.Conta_Registros()
                txtOrdemDupl.Text = cls_Finan.CT_DUPL

                SomasDaNota()

                btoIncluir.Enabled = True
                txtDtNtF.Enabled = False
                txtVTotal.Enabled = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgDupl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDupl.CellContentClick

        cls_Finan.Le_RegDupl(Me.dgDupl.CurrentRow.Cells(5).Value.ToString())
        If cls_Finan.CT_ID > 0 Then

            MoveRegDupl()

        End If


    End Sub

    Private Sub txtInicio_ValueChanged(sender As Object, e As EventArgs) Handles txtInicio.ValueChanged

        If txtTermino.Value >= txtInicio.Value Then
            LeCtaPg()
        End If
    End Sub

    Private Sub btoPagto_Click(sender As Object, e As EventArgs) Handles btoPagto.Click
        Try
            cls_Finan.CT_DTPAGTO = txtDtPagto.Text
            cls_Finan.CT_VALORP = txtVdoPagto.Text
            cls_Finan.CT_FPAGTO = cboFPagto.SelectedValue
            cls_Finan.CT_HISTREG = txtHist.Text

            cls_Finan.UpDatectaPg_Pagto(txtId.Text)
            SomasDaNota()
            LeInstituicao()
            LeCtaPg()
            MessageBox.Show("Baixa de Pagamento efetuada.", "Aviso importante.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso importante.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

    Private Sub btoEstorno_Click(sender As Object, e As EventArgs) Handles btoEstorno.Click
        Try

            cls_Finan.CT_DTPAGTO = "01-01-1900"
            cls_Finan.CT_VALORP = 0
            cls_Finan.CT_FPAGTO = 10
            cls_Finan.CT_HISTREG = txtHist.Text

            cls_Finan.UpDatectaPg_Pagto(txtId.Text)
            SomasDaNota()
            LeInstituicao()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso importante.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        End Try
    End Sub
    Private Sub cboInstituicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstituicao.SelectedIndexChanged
        LeInstituicao()

    End Sub

    Private Sub DgCtaPg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCtaPg.CellContentClick

        ''cls_Finan.Busca_Nota(Me.DgCtaPg.CurrentRow.Cells(1).Value.ToString(), Me.DgCtaPg.CurrentRow.Cells(3).Value.ToString())
        cls_Finan.Le_RegDupl(Me.DgCtaPg.CurrentRow.Cells(12).Value.ToString())

        MOve_Base_Tela()
        MoveRegDupl()
        SomasDaNota()

        btoIncluir.Enabled = True
        txtDtNtF.Enabled = False
        txtVTotal.Enabled = False

        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub cboInstituicao_Click(sender As Object, e As EventArgs) Handles cboInstituicao.Click

        'Dim dtg As DataTable
        'dtg = cls_Finan.Busca_CtaPg_DoFor(cboInstituicao.SelectedValue)
        'DgCtaPg.DataSource = dtg
        'formata_dg()

    End Sub


    Private Sub txtTermino_ValueChanged(sender As Object, e As EventArgs) Handles txtTermino.ValueChanged

        If txtTermino.Value >= txtInicio.Value Then
            LeCtaPg()
        End If

    End Sub

    Private Sub dgDoFornec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDoFornec.CellContentClick

        cls_Finan.Le_RegDupl(Me.dgDoFornec.CurrentRow.Cells(11).Value.ToString())

        MOve_Base_Tela()
        MoveRegDupl()
        SomasDaNota()

        btoIncluir.Enabled = True
        txtDtNtF.Enabled = False
        txtVTotal.Enabled = False

        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txtNroDupl_TextChanged(sender As Object, e As EventArgs) Handles txtNroDupl.TextChanged

    End Sub
End Class