Imports System.Windows.Forms
Imports DataBase
Public Class frmPDV
    Private Cliente As New Cls_Cliente
    Private Materiais As New Cls_Materiais
    Private ClsFinan As New Cls_Financeiro
    Private frm As Form
    Private U_Func As Integer

#Region "Metodos"
    Private Sub LimpaLanca()
        txtCB.Text = ""
        lbItem.Text = ""
        txtQtd.Text = 1
        txtUnd.Text = ""
        txtUnit.Text = 0
        txtTotItem.Text = 0
        txtCB.Focus()
    End Sub
    Private Sub PesqCliente()
        Using frm As New frmFConsCli
            frm.ShowDialog()
            If frm.fcc_IdCli > 0 Then
                Dim enter As New KeyEventArgs(Keys.Enter)
                txtCpf.Text = frm.fcc_CpfCli
                txtNome.Text = frm.fcc_NomeCli
                txtIdCli.Text = frm.fcc_IdCli
                txtCpf_KeyDown(Nothing, enter)
                ' Le_Id_Da_Venda()
                txtCB.Focus()
            End If

        End Using
    End Sub
    Private Sub PesqProduto()
        Using frm As New frmFConsProd
            frm.ShowDialog()
            If frm.fcp_Id <> Nothing Then
                If frm.fcp_Id.Length > 0 Then

                    Dim enter As New KeyEventArgs(Keys.Enter)
                    txtCB.Text = frm.fcp_Id
                    lbItem.Text = frm.fcp_Desc
                    txtCB_KeyDown(Nothing, enter)

                    If txtQtd.TextLength = 0 Then
                        txtQtd.Text = 1
                    End If

                End If
            End If
        End Using
    End Sub
#End Region
    Public Sub New(ByVal Caixa As String, ByVal Cpf As String, ByVal Func As Integer)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        lbUSR.Text = Caixa
        u_Func = Func
        txtCpf.ValidaCPF = True
        txtCpf.ValidaCNPJ = False
        If Cpf > 0 Then
            Le_CPF()
            '  Le_Id_Da_Venda()
        Else
            lbNss.Text = 0
        End If

    End Sub
    Private Sub Le_CPF()

        Cliente.Cl_Cpf = txtCpf.Text

        If Cliente.BuscaCPF(Cliente.Cl_Cpf) = True Then
            My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\ping.wav")
            txtIdCli.Text = Cliente.Cl_Id
            txtNome.Text = Cliente.Cl_Nome

        Else
            MessageBox.Show("Cliente não encontrado ou não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub Fecha()
        Try
            ClsFinan.Fi_Cli = txtIdCli.Text
            ClsFinan.Fi_Ani = 1
            ClsFinan.Fa_Cli = txtIdCli.Text
            ClsFinan.Fa_Ani = 1
            ClsFinan.Fa_Func = U_Func

            ClsFinan.MoveVar()
            ClsFinan.IncluirFinS()
            ClsFinan.FechaPdv(lbNss.Text)

            Materiais.ET_CLIENTE = txtIdCli.Text
            Materiais.ET_FORNEC = 1
            Materiais.Fa_Ev = Materiais.ET_ITEM
            Materiais.ET_DTREF = FormatDateTime(Now, DateFormat.LongDate)
            Materiais.ET_HRREF = FormatDateTime(TimeOfDay)
            Materiais.ET_SOLIC = ClsFinan.NssNro
            Materiais.ET_OC = ClsFinan.NssNro
            Materiais.ET_QTDE = 0
            Materiais.ET_VALOR = 0
            Materiais.ET_NLOTE = " "

            For Each col As DataGridViewRow In dgListaFat.Rows
                Materiais.ET_ITEM = col.Cells(0).Value
                Materiais.ET_QTDS = col.Cells(3).Value
                Materiais.ET_VLRS = col.Cells(5).Value
                '' enviar para o estoque
                Materiais.GravarEstoque()
            Next

            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show("Venda concluida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)



        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Le_Id_Da_Venda()

        ClsFinan.GravaNssNro()
        lbNss.Text = ClsFinan.NssNro

    End Sub

    Private Sub Le_Item()
        Try
            If txtQtd.Text = 0 Or txtQtd.Text = "" Then
                txtQtd.Text = 1
            End If

            ' My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\pop.wav")
            Materiais.IT_ITEM = txtCB.Text
            Materiais.Le_Item()
            If Materiais.IT_ID > 0 Then
                TransfereBaseTela()
            Else
                MessageBox.Show("ITEM não encontrado ou não cadastrado", "Aviso de ITEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub TransfereBaseTela()

        lbItem.Text = Materiais.IT_DESC
        txtUnd.Text = Materiais.IT_UNID
        txtUnit.Text = Materiais.IT_VENDA
        txtTotItem.Text = Materiais.IT_VENDA

        If txtQtd.TextLength = 0 Then
            txtQtd.Text = 1
        End If

    End Sub
    Private Sub TransfereTelaBase()
        Materiais.ET_ITEM = txtCB.Text
    End Sub
    Private Sub MoveVar()
        If txtIdCli.Text = "" Then
            txtIdCli.Text = 0
            txtQtd.Text = 1
            txtUnit.Text = 0
            txtTotItem.Text = 0
        End If
        Materiais.Fa_Cli = txtIdCli.Text
        Materiais.Fa_Ani = 1
        Materiais.Fa_NssPai = lbNss.Text
        Materiais.Fa_Ev = txtCB.Text
        Materiais.Fa_Desc = lbItem.Text
        Materiais.Fa_Qtd = txtQtd.Text
        Materiais.Fa_VlrU = txtUnit.Text
        Materiais.Fa_Dcto = 0
        Materiais.Fa_Vlr = txtTotItem.Text
        Materiais.Fa_Func = U_Func
        Materiais.Fa_Dt = Now
        Materiais.Fa_VlrAd = 0
    End Sub
    Private Sub Ler_Lista()
        Materiais.Fa_NssPai = lbNss.Text
        Dim dt As DataTable
        dt = Materiais.BuscaListaPdv("Sp_FinA_LeLista_pdv")
        dgListaFat.DataSource = dt

        dgListaFat.Columns(0).Width = 460
        dgListaFat.Columns(0).HeaderText = "Descrição "

        dgListaFat.Columns(1).Width = 120
        dgListaFat.Columns(1).HeaderText = "Cod. do Produto"

        dgListaFat.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(2).Width = 30
        dgListaFat.Columns(2).HeaderText = "Unid."

        dgListaFat.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(3).Width = 40
        dgListaFat.Columns(3).HeaderText = "Qtd."
        dgListaFat.Columns(3).DefaultCellStyle.Format = "0.000"

        dgListaFat.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(4).Width = 30
        dgListaFat.Columns(4).HeaderText = "$ Unit."
        dgListaFat.Columns(4).DefaultCellStyle.Format = "C2"
        dgListaFat.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgListaFat.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(5).Width = 40
        dgListaFat.Columns(5).HeaderText = "$ Item."
        dgListaFat.Columns(5).DefaultCellStyle.Format = "C2"
        dgListaFat.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgListaFat.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(6).Width = 30
        dgListaFat.Columns(6).HeaderText = "Id"

        dgListaFat.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(7).Width = 30
        dgListaFat.Columns(7).HeaderText = "Total da Nota"
        dgListaFat.Columns(7).DefaultCellStyle.Format = "C2"
        'ClsFinan.valorTotal = 0

        'For Each col As DataGridViewRow In dgListaFat.Rows
        '    ClsFinan.valorTotal = ClsFinan.valorTotal + Convert.ToDecimal(col.Cells(5).Value)
        'Next

        'txtTotNota.Text = ClsFinan.valorTotal.ToString("R$ #,###.00")
        'Dim RETORNO As Double
        'RETORNO = Materiais.BuscaSomaOSPDV()
        'ClsFinan.valorTotal ' RETORNO

        ClsFinan.valorTotal = Convert.ToDecimal(dgListaFat.CurrentRow.Cells(7).Value)
        txtTotNota.Text = ClsFinan.valorTotal.ToString("R$ #,###.00")
        dgListaFat.Columns(7).Visible = False

        LimpaLanca()

    End Sub

    Private Sub frmPDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdCli.Focus()

    End Sub

    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        Try
            If Len(Trim(txtCpf.Text)) > 0 And txtCpf.Text <> "0" Then
                Le_CPF()

            Else
                txtCpf.Text = 0
                txtIdCli.Text = 1
                txtNome.Text = "Consumidior"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCB_LostFocus(sender As Object, e As EventArgs) Handles txtCB.LostFocus
        If Len(txtCB.Text) > 0 Then
            Try

                If lbNss.Text = 0 Then
                    MessageBox.Show("Venda NÃO iniciada." & vbCr & "Acionar o F4 (Abertura de Venda) para a liberação.", "Aviso de Abertura para Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If Len(txtCB.Text) > 0 Then

                    Le_Item()
                    MoveVar()

                    Materiais.InsertLista()
                    Ler_Lista()

                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub txtQtd_Leave(sender As Object, e As EventArgs) Handles txtQtd.Leave
        Try
            If IsNumeric(txtQtd.Text) And IsNumeric(txtUnit.Text) = True Then
                txtTotItem.Text = (txtQtd.Text * txtUnit.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtQtd_LostFocus(sender As Object, e As EventArgs) Handles txtQtd.LostFocus
        Try
            MoveVar()

            If Len(Trim(Materiais.Fa_Ev)) <> 0 Then
                Materiais.InsertLista()
                Ler_Lista()

            Else
                MessageBox.Show("ITEM não incluso na lista de venda" & vbCr & "", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub frmPDV_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Windows.Forms.Keys.F4 Then '''  F4 abre a VEnda
            If lbNss.Text = 0 Then
                If Len(txtCpf.Text) = 0 Then
                    MessageBox.Show("CPF do Cliente não informado." & vbCr & "Favor informar um CPF (0 = Consudor)", "Aviso de Abertura para Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Le_Id_Da_Venda()
            Else
                MessageBox.Show("Venda já iniciada", "Aviso de Abertura para Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If

        If e.KeyCode = Windows.Forms.Keys.F5 Then '''  F5 FINALIZA A VENDA
            If lbNss.Text = 0 Then
                MessageBox.Show("Venda não iniciada." & vbCr & "Favor iniciar a venda.", "Aviso de Abertura para Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Fecha()

            Using frm As New frmCaixa(lbUSR.Text, txtIdCli.Text, lbNss.Text, 0)
                frm.ShowDialog()

            End Using
        End If

        If e.KeyCode = Windows.Forms.Keys.F10 Then '''  CONSULTA CLIENTE

            PesqCliente()

        End If

        If e.KeyCode = Windows.Forms.Keys.F11 Then '''  CONSULTA PRODUTO

            PesqProduto()

        End If

    End Sub
    Private Sub txtCpf_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCpf.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Len(Trim(txtCpf.Text)) > 0 And txtCpf.Text <> "0" Then
                    Le_CPF()
                Else
                    txtCpf.Text = 0
                    txtIdCli.Text = 1
                    txtNome.Text = "Consumidior"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCB_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCB.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Len(txtCB.Text) > 0 Then
        '        Try
        '            If lbNss.Text = 0 Then
        '                MessageBox.Show("Venda NÃO iniciada." & vbCr & "Acionar o F4 (Abertura de Venda) para a liberação.", "Aviso de Abertura para Venda", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                Exit Sub
        '            End If
        '            If Len(txtCB.Text) > 0 Then
        '                If txtUnit.Text = "" Then
        '                    Le_Item()
        '                Else
        '                    'txtCB.Text = 0
        '                End If
        '            End If
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '        End Try
        '    End If
        'End If
    End Sub

    Private Sub txtCB_TextChanged(sender As Object, e As EventArgs) Handles txtCB.TextChanged

        '    Materiais.IT_EAN = txtCB.Text
        '    Materiais.Le_Item_CB()

        '    If Materiais.IT_ID > 0 Then
        '        TransfereBaseTela()
        '    Else
        '        MessageBox.Show("ITEM não encontrado ou não cadastrado", "Aviso de ITEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End If

        'End If

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dgListaFat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaFat.CellContentClick

    End Sub
End Class