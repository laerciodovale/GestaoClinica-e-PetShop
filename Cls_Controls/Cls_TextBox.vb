Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Public Class Cls_TextBox
    Inherits TextBox
    <Category("SisPet")>
    <Description("Permite digitar somente numeros")>
    Public Property SomenteNumero As Boolean = False
    Public Property EnviaTab As Boolean = True

    Private Sub Cls_TextBox_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged

    End Sub

    Private Sub Cls_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Keys.Back = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If Keys.Delete Then
            e.Handled = False
            Exit Sub
        End If
        If SomenteNumero = True Then
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = True 'nao digita
            ElseIf Char.IsPunctuation(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = True
            ElseIf Char.IsSymbol(e.KeyChar) Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub Cls_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Cls_TextBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.SelectionStart = 0
        Me.SelectionLength = Len(Me.Text)
        Me.BackColor = Color.Azure
    End Sub

    Private Sub Cls_TextBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub

End Class
