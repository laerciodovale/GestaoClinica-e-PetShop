Imports System.Windows.Forms
Imports DataBase
Public Class frmFConsProd
    Private Cliente As New Cls_Cliente
    Private Materiais As New Cls_Materiais
    Private ClsFinan As New Cls_Financeiro
    Public Property fcp_Id As String
    Public Property fcp_Desc As String
    Public Property fcp_CB As String
    Private Sub BuscaProd()
        If txtBusca.TextLength <= 1 Then
            dgResultado.DataSource = Nothing
            dgResultado.Rows.Clear()
            Exit Sub
        End If

        Materiais.IT_DESC = Trim(txtBusca.Text)

        Dim dt As DataTable
        dt = Materiais.BuscaItensLike()
        dgResultado.DataSource = dt

        dgResultado.Columns(0).Width = 520
        dgResultado.Columns(0).HeaderText = "Descrição do Item"
        dgResultado.Columns(1).Width = 1
        dgResultado.Columns(1).HeaderText = "Item"
        dgResultado.Columns(2).Width = 1
        dgResultado.Columns(2).HeaderText = "ID"

        dgResultado.Columns(3).Width = 180
        dgResultado.Columns(3).HeaderText = "Código de Barras"
        dgResultado.Columns(4).Width = 40
        dgResultado.Columns(4).HeaderText = "Tp"

    End Sub

    Private Sub frmFConsProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmFConsProd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = 27 Then
            Me.Close()
        End If

    End Sub

    Private Sub dgResultado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellContentClick
        Try
            If Me.dgResultado.CurrentRow.Cells(4).Value.ToString() <> "S" Then
                fcp_Id = Me.dgResultado.CurrentRow.Cells(1).Value.ToString()
                fcp_Desc = Me.dgResultado.CurrentRow.Cells(0).Value.ToString()
                fcp_CB = Me.dgResultado.CurrentRow.Cells(2).Value.ToString()

                Me.Close()
            Else
                MessageBox.Show("Item selecionado é um Serviço e não pode ser vendido pelo PDV.", "Aviso - Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        BuscaProd()
    End Sub

    Private Sub txtBusca_LostFocus(sender As Object, e As EventArgs) Handles txtBusca.LostFocus
        'BuscaProd()
    End Sub
End Class