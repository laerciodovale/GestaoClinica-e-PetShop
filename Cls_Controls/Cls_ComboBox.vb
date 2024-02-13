Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing

Public Class Cls_ComboBox
    Inherits ComboBox
#Region "Propriedades"
    '<Category("MeusControles")>

    '<Description("")>

#End Region

    Public Property EnviaTab As Boolean = True



    Private Sub Cls_ComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Cls_ComboBox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Azure
    End Sub

    Private Sub Cls_ComboBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White
    End Sub
End Class
