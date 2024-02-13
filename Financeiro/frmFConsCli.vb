Imports DataBase
Imports DataBase.Utils
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Public Class frmFConsCli
    Private Cliente As New Cls_Cliente
    Private Materiais As New Cls_Materiais
    Private ClsFinan As New Cls_Financeiro
    Private T_O As String
    Private blnValida As Boolean = True
    Public Property fcc_IdCli As Integer
    Public Property fcc_NomeCli As String
    Public Property fcc_CpfCli As String
    Private Sub BuscaNome()
        If Len(Trim(txtBusca.Text)) < 3 Then
            dgResultado.DataSource = Nothing
            dgResultado.Rows.Clear()
            Exit Sub
        End If

        Dim tipo As Integer = 2
        If IsNumeric(txtBusca.Text) = True Then
            tipo = 6
        End If

        Dim dt As DataTable
        dt = Cliente.BuscaNome(tipo, txtBusca.Text)
        dgResultado.DataSource = dt

        dgResultado.Columns(1).Width = 60
        dgResultado.Columns(1).HeaderText = "ID"
        dgResultado.Columns(0).Width = 320
        dgResultado.Columns(0).HeaderText = "Nome do Cliente "
        dgResultado.Columns(2).Width = 160
        dgResultado.Columns(2).HeaderText = "CPF/CNPJ"
        dgResultado.Columns(3).Width = 130
        dgResultado.Columns(3).HeaderText = "Contato 1 "
        dgResultado.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgResultado.Columns(4).Width = 140
        dgResultado.Columns(4).HeaderText = "Contato 2 "
        dgResultado.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub dgResultado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResultado.CellContentClick
        Try
            fcc_IdCli = Me.dgResultado.CurrentRow.Cells(1).Value.ToString()
            fcc_NomeCli = Me.dgResultado.CurrentRow.Cells(0).Value.ToString()
            fcc_CpfCli = Me.dgResultado.CurrentRow.Cells(2).Value.ToString()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmFConsCli_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 27 Then
            Me.Close()
        End If
    End Sub
    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        BuscaNome()
    End Sub
    Private Sub dgResultado_KeyDown(sender As Object, e As KeyEventArgs) Handles dgResultado.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                fcc_IdCli = Me.dgResultado.CurrentRow.Cells(0).Value.ToString()
                fcc_NomeCli = Me.dgResultado.CurrentRow.Cells(1).Value.ToString()
                fcc_CpfCli = Me.dgResultado.CurrentRow.Cells(2).Value.ToString()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Try
            'grava o registro
            T_O = "I"
            ValidaCliente()
            T_O = ""
            'EnviaWatts()
            If blnValida = False Then
                MessageBox.Show("Problema ao tentar INCLUIR os dados do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                fcc_IdCli = Txt_ID.Text
                fcc_NomeCli = Txt_Nome_Cli.Text
                fcc_CpfCli = Txt_CPF_CNPJ.Text
                Me.Close()
                Exit Sub
            End If
        Catch ex As Exception
            '' TrataErro("Problema ao tentar gravar os dados do cliente.", ex)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ValidaCliente()

        Dim objCliente As Cls_Cliente
        'VALIDACAO DOS CAMPOS OBRIGATORIOS

        If Txt_Nome_Cli.TextLength = 0 Then
            epValida.SetError(Txt_Nome_Cli, "Informar o campo nome.")
            blnValida = False
        End If
        If Txt_CEP.TextLength = 0 Then
            epValida.SetError(Txt_CEP, "Informar o campo nome.")
            blnValida = False
        End If
        'If Txt_CPF_CNPJ.IsValido = False Then
        '    epValida.SetError(Txt_CPF_CNPJ, "CPF INÁVALIDO")
        '    blnValida = False
        'End If
        If txt_Fone1.TextLength = 0 Then
            epValida.SetError(txt_Fone1, "Informar o campo Telefone")
            blnValida = False
        End If
        If blnValida = False Then Exit Sub

        'INSTANCIA O CLIENTE
        objCliente = New Cls_Cliente
        With objCliente

            .Tipo_Operacao = T_O
            If Txt_ID.TextLength = 0 Then
                Txt_ID.Text = 0
            End If
            .Cl_Id = Txt_ID.Text

            .Cl_FJ = chkFJ.Checked
            .Cl_Nome = UCase(Txt_Nome_Cli.Text)
            .Cl_Contato = UCase(Trim(Txt_Contato.Text))

            .Cl_CEP = Txt_CEP.Text
            .Cl_End = UCase(Trim(Cbo_Endereco.Text))
            .Cl_Nro = txt_Nro.Text
            .Cl_Compl = UCase(txt_Compl.Text)
            .Cl_Bairro = UCase(cbo_Bairro.Text)
            .Cl_Cidade = UCase(txt_Cidade.Text)
            .Cl_Uf = UCase(Trim(cbo_UF.Text))

            .Cl_Fixo = txt_Fone1.Text
            .Cl_Cel = txt_Fone2.Text

            .Cl_DtNas = txt_DtNas.Text
            .Cl_RG = txt_RG.Text
            Dim cpf As String = Txt_CPF_CNPJ.Text
            cpf = Replace(cpf, ".", "")
            cpf = Replace(cpf, "/", "")
            cpf = Replace(cpf, "-", "")
            .Cl_Cpf = cpf

            .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)

            .Cl_Email = txt_Email.Text

            pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
            pic_Cliente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
            .Cl_Foto = ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

            'grava o registro
            .GravaCliente()
            If T_O = "I" Then
                Txt_ID.Text = .Cl_Id
                MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Alteração de cadastrado efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With

    End Sub

    Private Sub frmFConsCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_CPF_CNPJ.ValidaCPF = True
        Txt_CPF_CNPJ.ValidaCNPJ = False
    End Sub
End Class