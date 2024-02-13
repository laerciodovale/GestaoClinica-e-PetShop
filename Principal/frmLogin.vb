Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports Cadastros

Public Class frmLogin
    Private Usr As New DataBase.Utils

    Sub ArredondaCantosdoForm()

        Dim PastaGrafica As New GraphicsPath
        Dim rect As New Rectangle(1, 1, Me.Size.Width, Me.Size.Height)
        PastaGrafica.AddRectangle(rect)

        'Arredondar canto superior esquerdo
        Dim rES As New Rectangle(1, 1, 10, 10)
        PastaGrafica.AddRectangle(rES)
        PastaGrafica.AddPie(1, 1, 20, 20, 180, 90)

        'Arredondar canto superior direito
        Dim rDS As New Rectangle(Me.Width - 12, 1, 12, 13)
        PastaGrafica.AddRectangle(rDS)
        PastaGrafica.AddPie(Me.Width - 24, 1, 24, 26, 270, 90)

        'Arredondar canto inferior esquerdo
        Dim rIE As New Rectangle(1, Me.Height - 10, 10, 10)
        PastaGrafica.AddRectangle(rIE)
        PastaGrafica.AddPie(1, Me.Height - 20, 20, 20, 90, 90)

        'Arredondar canto inferior direito
        Dim rID As New Rectangle(Me.Width - 12, Me.Height - 13, 13, 13)
        PastaGrafica.AddRectangle(rID)
        PastaGrafica.AddPie(Me.Width - 24, Me.Height - 26, 24, 26, 0, 90)

        PastaGrafica.SetMarkers()
        Me.Region = New Region(PastaGrafica)
    End Sub
    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.Text = ""
        txtSenha.Text = ""
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus

        If LTrim(txtUsuario.Text) = "" Then

            Exit Sub
        End If

        Dim Parametro As List(Of SqlParameter)
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@USUARIO", txtUsuario.Text))

        Dim reto As Boolean = False
        Usr.BuscaUsuario("Sp_USER_SelUsuario", Parametro)

        If Trim(Usr.usr_User) = "" Then
            MessageBox.Show("Usuário não cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Text = ""
            txtSenha.Text = ""
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub txtSenha_LostFocus(sender As Object, e As EventArgs) Handles txtSenha.LostFocus
        If Trim(txtUsuario.Text) = "" Then
            '  MsgBox("Usuário não informado!", vbInformation)
            ' txtUsuario.Focus()
            Exit Sub
        End If

        If Trim(txtSenha.Text) = "" Then
            '  MsgBox("Senha não informada.", vbInformation)
            ' txtUsuario.Focus()
            Exit Sub
        End If

        Usr.usr_User = txtUsuario.Text
        Usr.usr_Senha = txtSenha.Text

        Try

            Dim Parametro As List(Of SqlParameter)
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@USUARIO", txtUsuario.Text))
            Parametro.Add(New SqlParameter("@UsSenha", txtSenha.Text))

            Usr.BuscaUsuario("Sp_USER_Sel", Parametro)

            If Trim(Usr.usr_User) = "" Then
                MessageBox.Show("Usuario não encontrado.", "Loguin do Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                txtSenha.Text = ""
                txtUsuario.Text = ""
                txtUsuario.Focus()
            Else

                Dim frm As New frmM
                frm.M_Usr_Aut = Usr.usr_Aut
                frm.M_Usr_Func = Usr.usr_CodFol
                frm.lblUsuario.Text = Trim(Usr.usr_User)

                frm.Show()
                Me.Hide()
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            txtSenha.Text = ""
            txtUsuario.Text = ""
            txtUsuario.Focus()

        End Try
    End Sub
    Private Sub frmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(27) Then
            Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja realmente sair do Sistema??", "Encerramento",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1, 0)

            If StrMsg = 6 Then
                Application.Exit()

            End If

        End If

    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.GotFocus
        txtSenha.Text = ""
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmLogin_Enter(sender As Object, e As EventArgs) Handles Me.Load
        ArredondaCantosdoForm()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtSenha_TextChanged_1(sender As Object, e As EventArgs) Handles txtSenha.TextChanged

    End Sub
End Class