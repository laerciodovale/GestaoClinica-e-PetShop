Imports System.Drawing
Imports System.Windows.Forms
Imports DataBase

Public Class frmAgendaDoCliente
    Private ClsCli As New Cls_Cliente
    Private ClsGeral As New Utils
    Private cpf As String
    Private Sub LimpaForm()
        txtCPF.ValidaCPF = True
        txtCPF.Text = ""
        txtId.Text = ""
        txtNome.Text = ""
        txtBairro.Text = ""
        txtEmail.Text = ""
        txtNro.Text = ""
        txtEnd.Text = ""
        dgAgenda.DataSource = Nothing
        dgAgenda.Rows.Clear()
        ImgCliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
    End Sub
    Private Sub MoveDados()
        txtCPF.Text = ClsCli.Cl_Cpf
        txtId.Text = ClsCli.Cl_Id
        txtNome.Text = ClsCli.Cl_Nome
        txtEmail.Text = ClsCli.Cl_Email
        txtBairro.Text = ClsCli.Cl_Bairro
        txtNro.Text = ClsCli.Cl_Nro
        txtEnd.Text = ClsCli.Cl_End

        If ClsCli.Cl_Foto = Nothing Or IsDBNull(ClsCli.Cl_Foto) = True Then
            ImgCliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        Else
            ImgCliente.Image = ClsGeral.AbrirArquivoBase64(ClsCli.Cl_Foto)
        End If

        Dim dt As DataTable
        dt = ClsCli.BuscaAgDoCli(ClsCli.Cl_Id)
        dgAgenda.DataSource = dt

    End Sub
    Private Sub LeCliente()
        cpf = txtCPF.Text
        If cpf.Length = 0 Then
            dgAgenda.DataSource = Nothing
            dgAgenda.Rows.Clear()
            Exit Sub
        End If

        cpf = Replace(txtCPF.Text, ".", "")
        cpf = Replace(txtCPF.Text, "-", "")
        cpf = Replace(txtCPF.Text, "/", "")

        Try
            ClsCli.BuscaCPF(cpf)

            If ClsCli.Cl_Id = 0 Then
                MessageBox.Show("Dados do Cliente com o CPF/CNPJ " & txtCPF.Text & " não encontrado.", "Cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                LimpaForm()
                Exit Sub
            End If

            MoveDados()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub txtCPF_TextChanged(sender As Object, e As EventArgs) Handles txtCPF.TextChanged

    End Sub

    Private Sub txtCPF_LostFocus(sender As Object, e As EventArgs) Handles txtCPF.LostFocus

        LeCliente()

    End Sub

    Private Sub frmAgendaDoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpaForm()
        txtCPF.Enabled = True
        If mdVar.md_ID > 0 Then

            ClsCli.BuscaCliente("Sp_Cliente_Sel", mdVar.md_ID)
            MoveDados()
            ClsCli.BuscaAgDoCli(mdVar.md_ID)
            txtCPF.Enabled = False
        End If

        'If Len(Trim(mdVar.md_Cpf)) > 0 Then

        '    ClsCli.BuscaCliente("Sp_Cliente_CPF", mdVar.md_Cpf)
        '    MoveDados()
        '    ClsCli.BuscaAgDoCli(mdVar.md_ID)

        'End If
    End Sub
End Class