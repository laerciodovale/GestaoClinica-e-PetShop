Imports DataBase
Imports AForge.Video.DirectShow
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmFuncionario
    Private cls_Func As New cls_Func
    Private clsGer As New DataAcces
    Private CameraWeb As VideoCaptureDevice
    Private PAR As List(Of SqlParameter)
    Private Function PreencheCombos()
        Dim ClsGeral As New DataAcces
        Dim ds As DataSet

        Try
            'função da funcionario
            Dim PAR As New List(Of SqlParameter)
            ds = ClsGeral.ExecutaStoreProcedureDataSet("Sp_Funcao_Sel", PAR)

            Dim Nfunc As DataRow = ds.Tables(0).NewRow
            Nfunc.Item("funcdesc") = "Veterinario"
            Nfunc.Item("funcid") = "1"

            ds.Tables(0).Rows.InsertAt(Nfunc, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboFuncao.DisplayMember = "funcdesc"
            cboFuncao.ValueMember = "funcid"
            cboFuncao.DataSource = ds.Tables(0)

            'UF
            ds = ClsGeral.ExecutaStoreProcedureDataSet("Sp_UF_Sel", PAR)

            Dim Nuf As DataRow = ds.Tables(0).NewRow
            Nuf.Item("ufdesc") = "Mato Grosso"
            Nuf.Item("UF") = "MT"

            ds.Tables(0).Rows.InsertAt(Nuf, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboUF.DisplayMember = "ufdesc"
            cboUF.ValueMember = "UF"
            cboUF.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try
    End Function
    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PreencheCombos()
        PreencheDg()
        txtCPF.ValidaCPF = True
        txtCPF.ValidaCNPJ = False
        Dim VideoSources = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If VideoSources IsNot Nothing AndAlso VideoSources.Count > 0 Then
            CameraWeb = New VideoCaptureDevice(VideoSources(0).MonikerString)
            AddHandler CameraWeb.NewFrame, AddressOf CameraWeb_NewFrame
        End If


    End Sub
    Private Sub Move_Parametros()

        PAR = New List(Of SqlParameter)
        'PAR.Add(New SqlParameter("Fu_ID", txtID.Text))
        PAR.Add(New SqlParameter("Fu_Nome", txtNome.Text))
        PAR.Add(New SqlParameter("Fu_Rg", txtRG.Text))
        PAR.Add(New SqlParameter("Fu_Cpf", txtCPF.Text))
        PAR.Add(New SqlParameter("Fu_Funcao", cboFuncao.SelectedValue))
        PAR.Add(New SqlParameter("Fu_RgProf", txtRgProf.Text))
        PAR.Add(New SqlParameter("Fu_End", txtEndereco.Text))
        PAR.Add(New SqlParameter("Fu_Nro", txtNRO.Text))
        PAR.Add(New SqlParameter("Fu_Compl", txtCompl.Text))
        PAR.Add(New SqlParameter("Fu_Bairro", txtBairro.Text))
        PAR.Add(New SqlParameter("Fu_Cidade", txtCidade.Text))
        PAR.Add(New SqlParameter("Fu_UF", cboUF.SelectedValue))
        PAR.Add(New SqlParameter("Fu_Cep", txtCEP.Text))
        PAR.Add(New SqlParameter("Fu_Cel", txtCel.Text))
        PAR.Add(New SqlParameter("Fu_Fixo", txtFixo.Text))
        PAR.Add(New SqlParameter("Fu_Ativo", ckAtivo.Checked))
        PAR.Add(New SqlParameter("Fu_DtNas", txtDtNas.Text))
        imgFunc.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
        cls_Func.Fu_Foto = Utils.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
        PAR.Add(New SqlParameter("Fu_Foto", cls_Func.Fu_Foto))
        PAR.Add(New SqlParameter("Fu_Email", txtEMail.Text))
        PAR.Add(New SqlParameter("Fu_TpCarro", txtDesc.Text))
        PAR.Add(New SqlParameter("Fu_Placa", txtPlaca.Text))
        PAR.Add(New SqlParameter("Fu_CNH", txtcnh.Text))

        CameraWeb.Stop()
    End Sub

    Private Sub MoveVat_B_T()
        txtCPF.Text = cls_Func.Fu_Cpf
        txtID.Text = cls_Func.Fu_Id
        txtNome.Text = cls_Func.Fu_Nome
        txtRG.Text = cls_Func.Fu_Rg

        cboFuncao.SelectedIndex = cls_Func.Fu_Funcao

        txtDtNas.Text = cls_Func.Fu_DtNas
        txtRgProf.Text = cls_Func.Fu_RgProf
        txtEndereco.Text = cls_Func.Fu_End
        txtNRO.Text = cls_Func.Fu_Nro
        txtCompl.Text = cls_Func.Fu_Compl
        txtBairro.Text = cls_Func.Fu_Bairro
        txtCidade.Text = cls_Func.Fu_Cidade
        txtCEP.Text = cls_Func.Fu_CEP
        txtCel.Text = cls_Func.Fu_Cel
        txtFixo.Text = cls_Func.Fu_Fixo

        cboUF.SelectedValue = cls_Func.Fu_UF

        If Trim(cls_Func.Fu_Foto) <> "" Then
            imgFunc.Image = Utils.AbrirArquivoBase64(cls_Func.Fu_Foto)
            ''imgFunc.Image.Save("C:\SisVet\Sistema\Imagens\dabase.png")
        Else
            imgFunc.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        End If

        ckAtivo.Checked = cls_Func.Fu_InAtivo

    End Sub
    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click
        Try
            '''adiciona os parametros
            Move_Parametros()

            Dim RETORNO As Integer
            Dim DataAccess As New DataAcces

            'EXECUTA A PROCEDURE
            RETORNO = DataAccess.ExecuteStoreProcedureIncremento("Sp_Func_Insert", PAR)
            'RETORNO O RESULTADO
            'Return RETORNO 

            PreencheDg()
            MessageBox.Show("Funcionário registrado com sucesso !! ", "Cadastro de Funcionário ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCPF.Focus()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " Cadastro de Funcionário - erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub PreencheDg()

        Dim Geral As New DataAcces
        Dim dt As DataTable
        PAR = New List(Of SqlParameter)
        dt = Geral.ExecutaDataTable("Sp_Func_Sel", PAR)
        dgFunc.DataSource = dt

        dgFunc.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFunc.Columns(0).HeaderText = "  ID  "
        dgFunc.Columns(0).Width = 20

        dgFunc.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFunc.Columns(1).HeaderText = " NOME "
        dgFunc.Columns(1).Width = 250

        dgFunc.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgFunc.Columns(2).HeaderText = " CPF "
        dgFunc.Columns(2).Width = 80

    End Sub

    Private Sub txtCPF_GotFocus(sender As Object, e As EventArgs) Handles txtCPF.GotFocus
        btoIncluir.Enabled = True
        txtID.Text = ""
        txtNome.Text = ""
        txtRG.Text = ""
        txtRgProf.Text = ""
        txtCPF.Text = ""
        cboFuncao.Text = ""
        txtEndereco.Text = ""
        txtNRO.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCel.Text = ""
        txtFixo.Text = ""
        cboUF.SelectedValue = "MT"
        ckAtivo.Checked = 0
        txtCEP.Text = ""
        txtDtNas.Text = "01/01/1900"
    End Sub

    Private Sub txtCPF_LostFocus(sender As Object, e As EventArgs) Handles txtCPF.LostFocus

        If LTrim(txtCPF.Text) <> "" Then
            cls_Func.Le_Funcionario(txtCPF.Text)
            If cls_Func.Fu_Id > 0 Then
                MoveVat_B_T()
                btoIncluir.Enabled = False
            Else
                btoIncluir.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Try
            Move_Parametros()

            Dim RETORNO As Integer
            Dim DataAccess As New DataAcces
            Dim Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Fu_Cpf", txtCPF.Text))
            'EXECUTA A PROCEDURE
            RETORNO = DataAccess.ExecuteStoreProcedureIncremento("Sp_Func_UpDate", PAR)

            MessageBox.Show("Funcionário alterado com sucesso !! ", "Cadastro de Funcionário ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCPF.Focus()
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro na alteração do Cadastro de Funcionário : " & vbNewLine & ex.Message, " Cadastro de Funcionário - erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub imgFunc_Click(sender As Object, e As EventArgs) Handles imgFunc.Click
        My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\POP.wav")
        CameraWeb.Start()

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub CameraWeb_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If imgFunc.Image IsNot Nothing Then
            imgFunc.Image.Dispose()
        End If
        imgFunc.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub btnGravaImagem_Click(sender As Object, e As EventArgs)

        cls_Func.Fu_Foto = ""
        If Trim(txtID.Text) = "" Then
            MessageBox.Show("ID do Cliente nao informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If imgFunc.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                CameraWeb.Stop()
                RemoveHandler CameraWeb.NewFrame, AddressOf CameraWeb_NewFrame
                'salva a imagem nA PASTA
                imgFunc.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

                cls_Func.Fu_Foto = Utils.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                cls_Func.Fu_Id = txtID.Text

                cls_Func.UpFotoFunc()

                MessageBox.Show("Imagem salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                AddHandler CameraWeb.NewFrame, AddressOf CameraWeb_NewFrame
            End Try
        End If
    End Sub

    Private Sub dgFunc_Click(sender As Object, e As EventArgs) Handles dgFunc.Click
        Try

            txtID.Text = Me.dgFunc.CurrentRow.Cells(0).Value.ToString()
            cls_Func.Le_Funcionario_ID(txtID.Text)

            MoveVat_B_T()
            btoIncluir.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro com  Cadastro de selecionado : " & vbNewLine & ex.Message, " Cadastro de Funcionário - erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCEP_TextChanged(sender As Object, e As EventArgs) Handles txtCEP.TextChanged

    End Sub

    Private Sub txtCEP_LostFocus(sender As Object, e As EventArgs) Handles txtCEP.LostFocus
        If txtCEP.TextLength > 0 Then
            Try
                Me.Cursor = Cursors.AppStarting '.WaitCursor
                Dim cep As Cls_BuscaCEP = DataBase.Utils.PesquisaCEP(txtCEP.Text.Replace("-", ""))

                txtBairro.Text = UCase(cep.bairro)
                txtEndereco.Text = UCase(cep.logradouro)
                txtCidade.Text = UCase(cep.localidade)
                cboUF.Text = UCase(cep.uf)

                txtNRO.Select()
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                ''TrataErro("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex)
                MessageBox.Show("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex.Message)
                txtBairro.Text = ""
                txtEndereco.Text = ""
                txtCidade.Text = ""
                cboUF.Text = ""
                txtNRO.Text = ""
            End Try
        End If

    End Sub

    Private Sub cboUF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUF.SelectedIndexChanged

    End Sub

    Private Sub cboUF_LostFocus(sender As Object, e As EventArgs) Handles cboUF.LostFocus
        txtCel.Focus()

    End Sub

    Private Sub imgFunc_Click_1(sender As Object, e As EventArgs) Handles imgFunc.Click

    End Sub

    Private Sub imgFunc_DoubleClick(sender As Object, e As EventArgs) Handles imgFunc.DoubleClick
        If imgFunc.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                CameraWeb.Stop()
                RemoveHandler CameraWeb.NewFrame, AddressOf CameraWeb_NewFrame
                'salva a imagem nA PASTA
                imgFunc.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

                cls_Func.Fu_Foto = Utils.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

            Finally
                AddHandler CameraWeb.NewFrame, AddressOf CameraWeb_NewFrame
            End Try
        Else
            CameraWeb.Start()
        End If
    End Sub

    Private Sub btnGravaImagem_Click_1(sender As Object, e As EventArgs) Handles btnGravaImagem.Click

    End Sub

    Private Sub bto_Img_Cli_Click(sender As Object, e As EventArgs) Handles bto_Img_Cli.Click

        Try
            'carrega uma imagem da pasta
            Using abrir As New OpenFileDialog With {
                .Title = "Carregar uma imagem.",
                .FileName = "",
                .Filter = "Imagens PNG, JPG, JPEG e BMP|*.png; *.jpg;*.jpeg;*.bmp"}
                If abrir.ShowDialog = DialogResult.OK Then
                    imgFunc.Image = Image.FromFile(abrir.FileName)

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgFunc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFunc.CellContentClick

    End Sub
End Class