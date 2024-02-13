Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Public Class Cls_TextBoxData
    Inherits TextBox
#Region "Propriedades"
    Public Property EnviaTab As Boolean = True
    Public Property SomenteNumero As Boolean = True

#End Region

    Private Sub Cls_TextBoxData_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        '27/03/1962
        'Or e.KeyCode <> Keys.Delete


        If e.KeyCode <> Keys.Back Then
            If Me.TextLength = 2 Then
                Me.Text = Me.Text & "/"
                Me.SelectionStart = Me.TextLength
            End If
            If Me.TextLength = 5 Then
                Me.Text = Me.Text & "/"
                Me.SelectionStart = Me.TextLength
            End If
        End If
        If e.KeyCode = Keys.Delete Then
            Me.Text = ""
        End If
    End Sub

    Private Sub Cls_TextBoxData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub Cls_TextBoxData_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub

    Private Sub Cls_TextBoxData_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Azure
    End Sub

    Private Sub Cls_TextBoxData_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class
