Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel


Public Class Cls_TextBoxFone
    Inherits TextBox

#Region "Propriedades"
    ' <Category ("MeusControles")>
    '<Description("permite apenas numeros")>

#End Region
    Public Property EnviaTab As Boolean = True
    Public Property SomenteNumero As Boolean = False

    Private Sub Cls_Telefone_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub Cls_Telefone_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.White

    End Sub

    Private Sub Cls_Telefone_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Azure

    End Sub

    Private Sub Cls_Telefone_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'monta a mascara
        '(16)99123-9899
        'faz a mascara
        If e.KeyCode <> Keys.Back Then

            If Trim(Me.TextLength) = 1 Then
                Me.Text = Trim(Me.Text).Insert(0, "(")
                Me.SelectionStart = Me.TextLength
            ElseIf Trim(Me.TextLength) = 3 Then
                Me.Text = Trim(Me.Text) & ") "
                Me.SelectionStart = Me.TextLength
            ElseIf Trim(Me.TextLength) = 10 Then
                Me.Text = Trim(Me.Text) & "-"
                Me.SelectionStart = Me.TextLength
            End If
        End If

    End Sub
End Class
