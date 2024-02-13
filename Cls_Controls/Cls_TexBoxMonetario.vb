Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel


Public Class Cls_TexBoxMonetario
    Inherits TextBox
#Region "Propriedades"
    Private texto As String

    Public Property EnviaTab As Boolean = True
    Private Sub Cls_TexBoxMonetario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If EnviaTab = True Then

            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                SendKeys.Send("{TAB}")
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Up Then
                SendKeys.Send("+{TAB}")
                e.SuppressKeyPress = True

            End If
        End If
    End Sub

    Private Sub Cls_TexBoxMonetario_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Azure
    End Sub

    Private Sub Cls_TexBoxMonetario_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub

    Private Sub Cls_TexBoxMonetario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If Char.IsLetter(e.KeyChar) Then
                e.Handled = True 'nao digitae
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
            End If

    End Sub

    Private Sub Cls_TexBoxMonetario_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If Me.TextLength > 0 Then
            Me.Text = Me.Text.Replace(",", "")
            If Me.TextLength < 3 Then
                Me.Text = Me.Text.PadLeft(3, "0")
            End If
            texto = Me.Text.Insert(Me.TextLength - 2, ",")
            Me.Text = FormatNumber(Convert.ToDouble(texto), 2)
            Me.SelectionStart = Me.TextLength
        End If
    End Sub


#End Region


End Class
