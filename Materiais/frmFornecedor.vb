''Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports DataBase
Public Class frmFornecedor
    Private Materiais As New Cls_Materiais
    Private CtaPg As New Cls_Financeiro
    Private Sub LimparForm(ByVal controlP As Control)
        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is ComboBox Then
                DirectCast(ctl, ComboBox).Text = ""

            ElseIf TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = ""

            ElseIf TypeOf ctl Is CheckBox Then
                DirectCast(ctl, CheckBox).Checked = False

            ElseIf TypeOf ctl Is ProgressBar Then
                DirectCast(ctl, ProgressBar).Value = 0

            ElseIf ctl.Controls.Count > 0 Then
                LimparForm(ctl)
            End If
        Next

        lblID.Text = ""
        dgNotas.DataSource = Nothing
        dgNotas.Rows.Clear()
        dgItensNota.DataSource = Nothing
        dgItensNota.Rows.Clear()
        dgCtaPg.DataSource = Nothing
        dgCtaPg.Rows.Clear()

    End Sub

    Private Sub Enviar()
        Try

            Dim RETORNO As Integer
            Dim DataAccess As New DataAcces

            'adiciona os parametros
            Dim PAR As List(Of SqlParameter)
            PAR = New List(Of SqlParameter)
            Dim spROCEDURE As String = "SP_FORNECEDOR_INSERT"
            If LTrim(lblID.Text) > 0 Then
                spROCEDURE = "SP_FORNECEDOR_UPDATE"
                PAR.Add(New SqlParameter("F_SEQ", lblID.Text))

            End If

            PAR.Add(New SqlParameter("F_CGC", txtCNPJ.Text))
            PAR.Add(New SqlParameter("F_IE", txtIE.Text))
            PAR.Add(New SqlParameter("F_IM", txtIM.Text))
            PAR.Add(New SqlParameter("F_RAZAO", txtRazao.Text))
            PAR.Add(New SqlParameter("F_FANTASIA", txtFantasia.Text))
            PAR.Add(New SqlParameter("F_END", txtEnd.Text))
            PAR.Add(New SqlParameter("F_NRO", txtNro.Text))
            PAR.Add(New SqlParameter("F_COMPLE", txtCompl.Text))
            PAR.Add(New SqlParameter("F_CIDADE", txtCidade.Text))
            PAR.Add(New SqlParameter("F_BAIRRO", txtBairro.Text))
            PAR.Add(New SqlParameter("F_UF", txtUF.Text))
            PAR.Add(New SqlParameter("F_CEP", txtCEP.Text))
            PAR.Add(New SqlParameter("F_CONTATO", " "))
            PAR.Add(New SqlParameter("F_DDD", Mid(txtFone.Text, 1, 2)))
            PAR.Add(New SqlParameter("F_TEL", Mid(txtFone.Text, 3)))
            PAR.Add(New SqlParameter("F_DDDFAX", 65))
            PAR.Add(New SqlParameter("F_FAX", " "))
            PAR.Add(New SqlParameter("F_HTTP", txtHTTP.Text))
            PAR.Add(New SqlParameter("F_MAIL", txtEmail.Text))
            PAR.Add(New SqlParameter("F_DTREG", Now))
            PAR.Add(New SqlParameter("F_DTULTCOM", Now))

            'EXECUTA A PROCEDURE
            RETORNO = DataAccess.ExecuteStoreProcedureIncremento(spROCEDURE, PAR)
            Materiais.F_SEQ = RETORNO
            lblID.Text = RETORNO
            'FECHA A CONEXAO
            DataAccess.CloseConn()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click

        Enviar()
        PreencheDg()

    End Sub
    Private Sub txtCNPJ_LostFocus(sender As Object, e As EventArgs) Handles txtCNPJ.LostFocus
        Dim trimString As String
        trimString = LTrim(RTrim(txtCNPJ.Text))
        Try
            If trimString.Length > 0 Then
                Materiais.F_CGC = txtCNPJ.Text
                Materiais.Le_Fornecedor()
                If Materiais.F_SEQ > 0 Then
                    btoIncluir.Enabled = False
                    btoAlterar.Enabled = True

                    lblID.Text = Materiais.F_SEQ
                    txtCNPJ.Text = Materiais.F_CGC
                    txtIE.Text = Materiais.F_IE
                    txtIM.Text = Materiais.F_IM
                    txtRazao.Text = Materiais.F_RAZAO
                    txtFantasia.Text = Materiais.F_FANTASIA
                    txtEnd.Text = Materiais.F_END
                    txtNro.Text = Materiais.F_NRO
                    txtCompl.Text = Materiais.F_COMPLE
                    txtBairro.Text = Materiais.F_BAIRRO
                    txtCidade.Text = Materiais.F_CIDADE
                    txtUF.Text = Materiais.F_UF
                    txtCEP.Text = Materiais.F_CEP
                    txtFone.Text = Materiais.F_DDD
                    txtFone.Text = txtFone.Text & " - " & Materiais.F_TEL
                    txtHTTP.Text = Materiais.F_HTTP
                    txtEmail.Text = Materiais.F_MAIL
                    PreencheNotasFor()
                Else
                    btoIncluir.Enabled = True
                    btoAlterar.Enabled = False
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub PreencheNotasFor()
        Try
            Dim dt As DataTable
            Materiais.ET_FORNEC = lblID.Text
            dt = Materiais.Busca_NotasFor

            dgNotas.DataSource = dt
            dgNotas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgNotas.Columns(0).HeaderText = " Nro.Nota "
            dgNotas.Columns(0).Width = 30

            dgNotas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgNotas.Columns(1).HeaderText = " Data "
            dgNotas.Columns(1).Width = 60

            dgNotas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgNotas.Columns(2).HeaderText = " Valor        "
            dgNotas.Columns(2).Width = 60
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click
        Enviar()
    End Sub

    Private Sub txtCNPJ_GotFocus(sender As Object, e As EventArgs) Handles txtCNPJ.GotFocus
        Call Me.LimparForm(Me)
    End Sub
    Private Sub PreencheDg()
        Dim dt As DataTable
        dt = Materiais.Busca_For_Todos
        dgFornec.DataSource = dt

        dgFornec.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFornec.Columns(0).HeaderText = " CNPJ        "
        dgFornec.Columns(0).Width = 90
        dgFornec.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFornec.Columns(1).HeaderText = " Razão Social "
        dgFornec.Columns(1).Width = 300

    End Sub
    Private Sub frmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreencheDg()
    End Sub
    Private Sub frmFornecedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub dgNotas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotas.CellContentClick
        Try


            ''GRID DO ITEM
            Materiais.ET_FORNEC = lblID.Text
            Materiais.ET_SOLIC = dgNotas.CurrentRow.Cells(0).Value.ToString()

            Dim dt As DataTable
            dt = Materiais.Busca_Itens_da_Nota
            dgItensNota.DataSource = dt

            dgItensNota.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgItensNota.Columns(0).HeaderText = " item  "
            dgItensNota.Columns(0).Width = 80

            dgItensNota.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgItensNota.Columns(1).HeaderText = " Descrição do Item "
            dgItensNota.Columns(1).Width = 400

            dgItensNota.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgItensNota.Columns(2).HeaderText = " Qtd.  "
            dgItensNota.Columns(2).Width = 50

            dgItensNota.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgItensNota.Columns(3).HeaderText = " Valor  "
            dgItensNota.Columns(3).Width = 80

            '''''GRID DO CONTAS A PAGAR
            CtaPg.CT_FORNEC = txtCNPJ.Text
            CtaPg.CT_NF = dgNotas.CurrentRow.Cells(0).Value.ToString()

            ''   Dim dt As DataTable
            dt = CtaPg.Busca_Dupl_Nota
            dgCtaPg.DataSource = dt

            dgCtaPg.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgCtaPg.Columns(0).HeaderText = "ID"
            dgCtaPg.Columns(0).Width = 15

            dgCtaPg.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgCtaPg.Columns(1).HeaderText = " DT.VCTO."
            dgCtaPg.Columns(1).Width = 80

            dgCtaPg.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgCtaPg.Columns(2).HeaderText = " VALOR "
            dgCtaPg.Columns(2).Width = 60

            dgCtaPg.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgCtaPg.Columns(3).HeaderText = "$ PAGTO."
            dgCtaPg.Columns(3).Width = 60

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub LimpaDg()
        dgCtaPg.DataSource = Nothing    '' //Remover a datasource
        dgCtaPg.Columns.Clear() ''Remover As colunas
        dgCtaPg.Rows.Clear() ''Remover As linhas
        dgCtaPg.Refresh() ''Para a grid se actualizar

        dgItensNota.DataSource = Nothing
        dgItensNota.Columns.Clear()
        dgItensNota.Rows.Clear()
        dgItensNota.Refresh()

        dgNotas.DataSource = Nothing
        dgNotas.Columns.Clear()
        dgNotas.Rows.Clear()
        dgNotas.Refresh()
    End Sub
    Private Sub dgFornec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFornec.CellContentClick
        LimpaDg()

        Try
            txtCNPJ.Text = dgFornec.CurrentRow.Cells(0).Value.ToString()
            Materiais.F_CGC = txtCNPJ.Text
            Materiais.Le_Fornecedor()
            txtFantasia.Focus()
            btoIncluir.Enabled = False
            btoAlterar.Enabled = True

            lblID.Text = Materiais.F_SEQ

            txtIE.Text = Materiais.F_IE
            txtIM.Text = Materiais.F_IM
            txtRazao.Text = Materiais.F_RAZAO
            txtFantasia.Text = Materiais.F_FANTASIA
            txtEnd.Text = Materiais.F_END
            txtNro.Text = Materiais.F_NRO
            txtCompl.Text = Materiais.F_COMPLE
            txtBairro.Text = Materiais.F_BAIRRO
            txtCidade.Text = Materiais.F_CIDADE
            txtUF.Text = Materiais.F_UF
            txtCEP.Text = Materiais.F_CEP
            txtFone.Text = Materiais.F_DDD
            txtFone.Text = txtFone.Text & " - " & Materiais.F_TEL
            txtHTTP.Text = Materiais.F_HTTP
            txtEmail.Text = Materiais.F_MAIL
            PreencheNotasFor()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btoIncluir.Enabled = True
            btoAlterar.Enabled = False
        End Try

    End Sub

    Private Sub txtCNPJ_TextChanged(sender As Object, e As EventArgs) Handles txtCNPJ.TextChanged

    End Sub
End Class