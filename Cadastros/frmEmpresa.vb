Imports System.Windows.Forms
Imports DataBase
Imports System.Drawing
Imports AForge.Video.DirectShow


Public Class frmEmpresa

    Private obj As New Utils
    Private VideoSource As VideoCaptureDevice
    Private blnValida As Boolean
    Private T_O As String
    Private Caminho As String
    Private Sub Cls_CEP1_LostFocus(sender As Object, e As EventArgs) Handles TxtCEP.LostFocus

        If TxtCEP.TextLength > 0 Then
            Try
                Me.Cursor = Cursors.AppStarting '.WaitCursor
                Dim cep As Cls_BuscaCEP = DataBase.Utils.PesquisaCEP(TxtCEP.Text.Replace("-", ""))
                txtBairro.Text = UCase(cep.bairro)
                txtEnd.Text = UCase(cep.logradouro)
                txtCidade.Text = UCase(cep.localidade)
                txtUF.Text = UCase(cep.uf)

                txtNro.Select()
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                DataBase.Utils.TrataErro("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex)
            End Try
        End If

    End Sub

    Private Sub pic_Cliente_Click(sender As Object, e As EventArgs) Handles pic_Cliente.Click
        'If VideoSource.IsRunning Then
        '    VideoSource.Stop()
        '    pic_Cliente.Image = Nothing
        'Else
        '    VideoSource.Start()
        'End If
    End Sub

    Private Sub bto_Img_Cli_Click(sender As Object, e As EventArgs) Handles bto_Img_Cli.Click

        Try
            'carrega uma imagem da pasta
            Using abrir As New OpenFileDialog With {
                .Title = "Carregar uma imagem.",
                .FileName = "",
                .Filter = "Imagens PNG, JPG, JPEG e BMP|*.png; *.jpg;*.jpeg;*.bmp"}
                If abrir.ShowDialog = DialogResult.OK Then
                    pic_Cliente.Image = Image.FromFile(abrir.FileName)
                    Caminho = abrir.FileName
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        blnValida = True

        Try
            'grava o registro
            T_O = "1"
            ValidaCampos()
            T_O = ""
            'EnviaWatts()
            If blnValida = False Then
                MessageBox.Show("Problema ao tentar INCLUIR os dados do Prestador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            DataBase.Utils.TrataErro("Problema ao tentar gravar os dados do cliente.", ex)
        End Try

    End Sub
    Private Sub ValidaCampos()

        ''Dim obj As Cls_Prestador
        blnValida = True
        'VALIDACAO DOS CAMPOS OBRIGATORIOS
        If txtFantasia.TextLength = 0 Then
            epValida.SetError(txtFantasia, "Informar o campo nome.")
            blnValida = False
        End If
        If TxtCEP.TextLength = 0 Then
            epValida.SetError(TxtCEP, "Informar o campo nome.")
            blnValida = False
        End If
        If txtFone.TextLength = 0 Then
            epValida.SetError(txtFone, "Informar o campo Telefone")
            blnValida = False
        End If
        If blnValida = False Then Exit Sub

        'INSTANCIA O CLIENTE
        obj = New Utils
        With obj

            If Txt_ID.TextLength = 0 Then
                Txt_ID.Text = 0

            End If

            'grava o registro
            ''.GravaPrestador()

            If .emp_id > 0 Then

                Txt_ID.Text = .emp_id
                MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Alteração de cadastrado efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With

    End Sub
    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\logo_mac.png")

        dgEmp.DataSource = obj.Le_Empresa()
        MoveBaseTela()

        txtCNPJ.ValidaCNPJ = False
        txtCNPJ.ValidaCNPJ = True
    End Sub
    Private Sub MoveTelaBase()
        With obj

            .emp_id = Txt_ID.Text
            .emp_cgc = txtCNPJ.Text
            .emp_fanta = UCase(txtFantasia.Text)
            .emp_razao = UCase(txtRazao.Text)
            .emp_cep = TxtCEP.Text
            .emp_end = UCase(Trim(txtEnd.Text))
            .emp_nro = txtNro.Text
            .emp_compl = UCase(txtCompl.Text)
            .emp_bairro = UCase(txtBairro.Text)
            .emp_cidade = UCase(txtCidade.Text)
            .emp_uf = UCase(Trim(txtUF.Text))
            .emp_codMunIbge = txtCidIBGE.Text
            .emp_ufIbge = txtUfIBGE.Text
            .emp_iss = txtISS.Text
            .emp_fone = txtFone.Text

            Dim cpf As String = txtCNPJ.Text
            cpf = Replace(cpf, ".", "")
            cpf = Replace(cpf, "/", "")
            cpf = Replace(cpf, "-", "")
            .emp_cgc = cpf

            .emp_email = txtEmail.Text
            .emp_http = txtHttp.Text

            pic_Cliente.Image.Save("C:\SisVet\Sistema\Imagens\LogoGravado.png") 'salva a imagem nA PASTA
            .emp_Logo = .ArquivoParaBase64("C:\SisVet\Sistema\Imagens\LogoGravado.png") ' transfere
            .emp_Caminho = "C:\SisVet\Sistema\Imagens\LogoGravado.png"

        End With
    End Sub
    Private Sub MoveBaseTela()

        With obj

            Txt_ID.Text = .emp_id
            txtCNPJ.Text = .emp_cgc
            txtFantasia.Text = .emp_fanta

            TxtCEP.Text = .emp_cep
            txtEnd.Text = .emp_end
            txtNro.Text = .emp_nro
            txtCompl.Text = .emp_compl
            txtBairro.Text = .emp_bairro
            txtCidade.Text = .emp_cidade
            txtUF.Text = .emp_uf
            txtCidIBGE.Text = .emp_codMunIbge
            txtUfIBGE.Text = .emp_ufIbge
            txtISS.Text = .emp_iss

            txtFone.Text = .emp_fone
            txtEmail.Text = .emp_email
            txtHttp.Text = .emp_http
            'If .emp_Logo IsNot Nothing Then
            pic_Cliente.Image = DataBase.Utils.AbrirArquivoBase64(.emp_Logo) 'TRANSFERE 
            'Else
            '    pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
            'End If

        End With
    End Sub

    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click
        ''Dim obj As New Utils
        Dim ret As Boolean
        MoveTelaBase()

        obj.T_O = "2"

        ''grava o registro
        ret = obj.Contratante()

        If ret = True Then
            MessageBox.Show("Alteração de cadastro efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Problemas na alteração efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class