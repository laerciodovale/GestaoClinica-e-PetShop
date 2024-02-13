Imports System.Windows.Forms
Imports DataBase
Imports DataBase.Cls_Prestador
Imports System.Drawing
Imports AForge.Video.DirectShow
Public Class frmPrestador
    Private VideoSource As VideoCaptureDevice

    Private blnValida As Boolean
    Private T_O As String
    Private obj As New Cls_Prestador
    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If pic_Cliente.Image IsNot Nothing Then
            pic_Cliente.Image.Dispose()
        End If
        pic_Cliente.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
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
        If VideoSource.IsRunning Then
            VideoSource.Stop()
            pic_Cliente.Image = Nothing
        Else
            VideoSource.Start()
        End If
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
            T_O = "I"
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
        If txtNome.TextLength = 0 Then
            epValida.SetError(txtNome, "Informar o campo nome.")
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
        obj = New Cls_Prestador
        With obj

            .T_O = "I"
            If Txt_ID.TextLength = 0 Then
                Txt_ID.Text = 0
            End If
            'grava o registro
            .GravaPrestador()

            If .prest_Id > 0 Then

                    Txt_ID.Text = .prest_Id
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                    MessageBox.Show("Alteração de cadastrado efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With

    End Sub

    Private Sub frmPrestador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        obj.BuscaFuncao()
        cboFuncao.DisplayMember = "FuncDesc"
        cboFuncao.ValueMember = "FuncId"
        cboFuncao.DataSource = obj.BuscaFuncao()

        obj.BuscaPrestadores()
        dgPrestadores.DataSource = obj.BuscaPrestadores()

        Dim VideoSources = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If VideoSources IsNot Nothing AndAlso VideoSources.Count > 0 Then
            VideoSource = New VideoCaptureDevice(VideoSources(0).MonikerString)
            AddHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
        End If
        txtCNPJ.ValidaCNPJ = False
        txtCNPJ.ValidaCNPJ = True

    End Sub
    Private Sub dgPrestadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrestadores.CellContentClick
        If Me.dgPrestadores.CurrentRow.Cells(0).Value.ToString() > 0 Then

            With obj

                .prest_Id = Me.dgPrestadores.CurrentRow.Cells(0).Value.ToString()

                .BuscaPrestadorID()

                MoveBaseTela()

            End With
        End If
    End Sub
    Private Sub MoveTelaBase()
        With obj

            .prest_Id = Txt_ID.Text
            .prest_Func = cboFuncao.SelectedValue
            .prest_Nome = UCase(txtNome.Text)

            .prest_CEP = TxtCEP.Text
            .prest_End = UCase(Trim(txtEnd.Text))
            .prest_Nro = txtNro.Text
            .prest_Compl = UCase(txtCompl.Text)
            .prest_Bairro = UCase(txtBairro.Text)
            .prest_Cidade = UCase(txtCidade.Text)
            .prest_Uf = UCase(Trim(txtUF.Text))

            .prest_Fone = txtFone.Text

            Dim cpf As String = txtCNPJ.Text
            cpf = Replace(cpf, ".", "")
            cpf = Replace(cpf, "/", "")
            cpf = Replace(cpf, "-", "")
            .prest_DOC = cpf

            .prest_Email = txtEmail.Text

            .prest_TpCarro = UCase(txtDesc.Text)
            .prest_Placa = UCase(txtPlaca.Text)

            pic_Cliente.Image.Save("C:\SisVet\Sistema\Imagens\ImgPrest.png") 'salva a imagem nA PASTA
            .prest_Foto = DataBase.Utils.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImgPrest.png") ' transfere

        End With
    End Sub
    Private Sub MoveBaseTela()

        With obj

            Txt_ID.Text = .prest_Id
            cboFuncao.SelectedValue = .prest_Func
            txtNome.Text = .prest_Nome
            TxtCEP.Text = .prest_CEP
            txtEnd.Text = .prest_End
            txtNro.Text = .prest_Nro
            txtCompl.Text = .prest_Compl
            txtBairro.Text = .prest_Bairro
            txtCidade.Text = .prest_Cidade
            txtUF.Text = .prest_Uf
            txtFone.Text = .prest_Fone
            txtCNPJ.Text = .prest_DOC
            txtEmail.Text = .prest_Email
            txtDesc.Text = .prest_TpCarro
            txtPlaca.Text = .prest_Placa

            If .prest_Foto IsNot Nothing Then
                pic_Cliente.Image = DataBase.Utils.AbrirArquivoBase64(.prest_Foto) 'TRANSFERE 
            Else
                pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
            End If

        End With
    End Sub

    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click
        ''Dim obj As New Cls_Prestador
        Dim ret As Boolean
        MoveTelaBase()

        obj.T_O = "U"
        'grava o registro
        ret = obj.GravaPrestador()

        If ret = True Then
            MessageBox.Show("Alteração de cadastro efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Problemas na alteração efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Txt_ID_TextChanged(sender As Object, e As EventArgs) Handles Txt_ID.TextChanged

    End Sub
End Class