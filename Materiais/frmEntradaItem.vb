Imports System.Data.SqlClient
Imports DataBase
Public Class frmEntradaItem
    Private Materiais As New Cls_Materiais
    Private ClsComum As New DataAcces
    Private CtaPg As New Cls_Financeiro

    Private Sub LimparForm(ByVal controlP As Control)

        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is ComboBox Then
                DirectCast(ctl, ComboBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is CheckBox Then
                DirectCast(ctl, CheckBox).Checked = False

            ElseIf TypeOf ctl Is ProgressBar Then
                DirectCast(ctl, ProgressBar).Value = 0

            ElseIf ctl.Controls.Count > 0 Then
                LimparForm(ctl)
            End If
        Next

        cboItem.Text = "--- Selecione o ITEM para o lançamento  ---"
        LstItens.Items.Clear()
        LstPagtos.Items.Clear()
        lblTotalNota.Text = ""

        lblID.Text = ""
        lblIE.Text = ""
        lblIM.Text = ""
        lblRazao.Text = ""
        lblFantazia.Text = ""
        lblEndereco.Text = ""
        lblNro.Text = ""
        lblCompl.Text = ""
        lblBairro.Text = ""
        lblCidade.Text = ""
        lblUF.Text = ""
        lblCep.Text = ""
        lblFone.Text = ""
        lblFone.Text = ""
        lblHTTP.Text = ""
        lblEmail.Text = ""

    End Sub

    Private Sub txtCNPJ_LostFocus(sender As Object, e As EventArgs) Handles txtCNPJ.LostFocus
        If Len(Trim(txtCNPJ.Text)) = 0 Then
            Exit Sub
        End If

        Materiais.F_CGC = txtCNPJ.Text
        Materiais.Le_Fornecedor()

        If Materiais.F_SEQ > 0 Then

            lblID.Text = Materiais.F_SEQ
            txtCNPJ.Text = Materiais.F_CGC
            lblIE.Text = Materiais.F_IE
            lblIM.Text = Materiais.F_IM
            lblRazao.Text = Materiais.F_RAZAO
            lblFantazia.Text = Materiais.F_FANTASIA
            lblEndereco.Text = Materiais.F_END
            lblNro.Text = Materiais.F_NRO
            lblCompl.Text = Materiais.F_COMPLE
            lblBairro.Text = Materiais.F_BAIRRO
            lblCidade.Text = Materiais.F_CIDADE
            lblUF.Text = Materiais.F_UF
            lblCep.Text = Materiais.F_CEP
            lblFone.Text = Materiais.F_DDD
            lblFone.Text = lblFone.Text & " - " & Materiais.F_TEL
            lblHTTP.Text = Materiais.F_HTTP
            lblEmail.Text = Materiais.F_MAIL

        Else

            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            MessageBox.Show("Fornecedor não localizado.", "Lançamento de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub frmEntradaItemImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Materiais As New Cls_Materiais
        Dim ds As DataSet

        'ADICIONA NOVA LINHA NO COMBO GRUPO
        ds = Materiais.Busca_Grupo_CBO("Sp_Itens_Busca")

        Dim nova As DataRow = ds.Tables(0).NewRow
        nova.Item("ITDESC") = "--- Selecione o ITEM para o lançamento  ---"
        nova.Item("ITITEM") = "0"

        ds.Tables(0).Rows.InsertAt(nova, 0)
        ds.Tables(0).AcceptChanges()

        'VINCULA DATASET NO COMBO BOX
        cboItem.DisplayMember = "ITDESC"
        cboItem.ValueMember = "ITITEM"
        cboItem.DataSource = ds.Tables(0)

    End Sub

    Private Sub txtVUnit_TextChanged(sender As Object, e As EventArgs) Handles txtVUnit.TextChanged
        Calc_Total()
    End Sub
    Private Sub Calc_Total()

        Dim Total As Double
        Dim Qtd As Double
        Dim VUnit As Double
        Dim VDcto As Double

        Double.TryParse(txtTotal.Text, Total)
        Double.TryParse(txtQtd.Text, Qtd)
        Double.TryParse(txtVUnit.Text, VUnit)
        Double.TryParse(txtDcto.Text, VDcto)

        Total = (Qtd * VUnit) - VDcto
        txtTotal.Text = Format(Total, "#,##0.00")
    End Sub
    Private Sub txtVUnit_LostFocus(sender As Object, e As EventArgs) Handles txtVUnit.LostFocus

        Calc_Total()
    End Sub

    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click

        If LstItens.Items.Count = 0 Then
            MessageBox.Show("Itens para lançamento não encontrados." & vbCr & "Processo encerrado.", "Lançamento de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If LstPagtos.Items.Count = 0 Then
            MessageBox.Show("Itens de cobrança não encontrados.", "Lançamento de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Len(Trim(txtNroNota.Text)) = 0 Then
            MessageBox.Show("Numero da Nota Fiscal não informado.", "Lançamento de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNroNota.Select()
            Exit Sub
        End If

        If Len(Trim(txtCNPJ.Text)) = 0 Then
            MessageBox.Show("CNPJ oo fornecedor não informado.", "Lançamento de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCNPJ.Select()
            Exit Sub
        End If

        'cabecalho
        Materiais.ET_DTREF = mskDtNf.Text
        Materiais.ET_HRREF = FormatDateTime(TimeOfDay)
        Materiais.ET_SOLIC = txtNroNota.Text
        Materiais.ET_OC = txtNroNota.Text
        Materiais.ET_FORNEC = lblID.Text
        Materiais.ET_CLIENTE = 0
        Materiais.ET_EMPRESA = 1

        Dim x As Integer
        For x = 0 To (LstItens.Items.Count - 1)
            Materiais.ET_ITEM = LstItens.Items.Item(x).SubItems.Item(0).Text 'codigo
            If Len(Trim(LstItens.Items.Item(x).SubItems.Item(0).Text)) > 0 Then

                Materiais.ET_QTDE = LstItens.Items.Item(x).SubItems.Item(3).Text
                Materiais.ET_QTDS = 0
                Materiais.ET_VALOR = LstItens.Items.Item(x).SubItems.Item(6).Text
                Materiais.ET_VLRS = 0
                Materiais.ET_NLOTE = LstItens.Items.Item(x).SubItems.Item(7).Text

                Materiais.GravarEstoque()

            End If
        Next

        Dim RETORNO As Integer
        Dim DataAccess As DataAcces
        Dim PAR As List(Of SqlParameter)
        DataAccess = New DataAcces
        '' incluir  cobranca
        With CtaPg
            For x = 0 To (LstPagtos.Items.Count - 1)

                .CT_DUPL = LstPagtos.Items.Item(x).SubItems.Item(0).Text
                .CT_DTVCTO = Format(LstPagtos.Items.Item(x).SubItems.Item(1).Text, "short Date")
                .CT_VALOR = LstPagtos.Items.Item(x).SubItems.Item(2).Text

                ''adiciona os parametros
                PAR = New List(Of SqlParameter)
                PAR.Add(New SqlParameter("CT_DTREF", Format(Now, "yyyy-MM-dd")))
                PAR.Add(New SqlParameter("CT_FORNEC", txtCNPJ.Text))
                PAR.Add(New SqlParameter("CT_OC", txtNroNota.Text))
                PAR.Add(New SqlParameter("CT_NF", txtNroNota.Text))

                ''converte data de vencimento
                Dim dateTime As String = mskDtNf.Text
                Dim dt As DateTime = Convert.ToDateTime(dateTime)
                Dim forma As String = "yyyy-MM-dd"
                Dim str As String = dt.ToString(forma)
                ''''

                PAR.Add(New SqlParameter("CT_DTNF", str))

                PAR.Add(New SqlParameter("CT_DUPL", .CT_DUPL))
                PAR.Add(New SqlParameter("CT_FATURA", txtNroNota.Text))
                PAR.Add(New SqlParameter("CT_DTVCTO", .CT_DTVCTO))

                PAR.Add(New SqlParameter("CT_VALOR", .CT_VALOR))
                PAR.Add(New SqlParameter("CT_DTPAGTO", Nothing))
                PAR.Add(New SqlParameter("CT_VALORP", 0))
                PAR.Add(New SqlParameter("CT_DOCPG", Nothing))

                'EXECUTA A PROCEDURE
                RETORNO = DataAccess.ExecuteStoreProcedureIncremento("SP_CTAPG_INSERT", PAR)
                CtaPg.CT_ID = RETORNO
                'FECHA A CONEXAO
                DataAccess.CloseConn()

            Next
            MessageBox.Show("Nota Fiscal lançada com sucesso.", "Lançamento de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCNPJ.Focus()

        End With

    End Sub

    Private Sub txtValorDupl_LostFocus(sender As Object, e As EventArgs) Handles txtValorDupl.LostFocus
        Dim Linha As String() = New String(3) {}
        Dim item As ListViewItem

        Linha(0) = LstPagtos.Items.Count + 1
        Linha(1) = txtVctoDupl.Text
        Linha(2) = txtValorDupl.Text

        item = New ListViewItem(Linha)

        LstPagtos.Items.Add(item)
        txtValorDupl.Focus()

    End Sub

    Private Sub txtCNPJ_GotFocus(sender As Object, e As EventArgs) Handles txtCNPJ.GotFocus

        Call Me.LimparForm(Me)


    End Sub

    Private Sub txtLote_LostFocus(sender As Object, e As EventArgs) Handles txtLote.LostFocus

        Dim Linha As String() = New String(8) {}
        Dim item As ListViewItem

        Linha(0) = LstItens.Items.Count + 1
        Linha(1) = cboItem.SelectedValue
        Linha(2) = cboItem.Text
        Linha(3) = txtQtd.Text
        Linha(4) = txtVUnit.Text
        Linha(5) = txtDcto.Text
        Linha(6) = txtTotal.Text
        Linha(7) = txtLote.Text

        item = New ListViewItem(Linha)

        LstItens.Items.Add(item)

        CalcTotNota()

        cboItem.Focus()

    End Sub
    Private Sub CalcTotNota()
        Dim i As Integer = 0
        Dim Vlr As Double
        Vlr = 0
        For Each LinhaR As ListViewItem In LstItens.Items
            'MsgBox(item.SubItems(0).Text)
            i += 1
            Vlr = Vlr + LinhaR.SubItems(6).Text

        Next

        lblTotalNota.Text = Vlr
    End Sub
    Private Sub DeletarItemDaListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletarItemDaListaToolStripMenuItem.Click

    End Sub
    Private Sub DeletarItemDeCobrançaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletarItemDeCobrançaToolStripMenuItem.Click

    End Sub

    Private Sub txtCNPJ_TextChanged(sender As Object, e As EventArgs) Handles txtCNPJ.TextChanged

    End Sub

    Private Sub txtValorDupl_TextChanged(sender As Object, e As EventArgs) Handles txtValorDupl.TextChanged

    End Sub

    Private Sub txtDcto_TextChanged(sender As Object, e As EventArgs) Handles txtDcto.TextChanged
        Calc_Total()
    End Sub

    Private Sub txtLote_TextChanged(sender As Object, e As EventArgs) Handles txtLote.TextChanged

    End Sub

    Private Sub txtNroNota_TextChanged(sender As Object, e As EventArgs) Handles txtNroNota.TextChanged

    End Sub

    Private Sub txtNroNota_LostFocus(sender As Object, e As EventArgs) Handles txtNroNota.LostFocus
        If Trim(txtNroNota.Text) = "" Then
            Exit Sub
        End If

        'EXECUTA A PROCEDURE
        Materiais.ET_FORNEC = lblID.Text
        Materiais.ET_SOLIC = txtNroNota.Text

        Materiais.BuscaNotaFiscal()

        If Materiais.ET_SEQ > 0 Then
            MessageBox.Show("Fornecedor e Nota fiscal " & vbCr &
                            "consta como lançada.", "Lançamento de Nota Fiscal.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'txtCNPJ.Focus()
        End If

    End Sub


    Private Sub frmEntradaItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LstItens_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstItens.SelectedIndexChanged

    End Sub
End Class
