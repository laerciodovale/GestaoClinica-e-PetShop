Imports System.ComponentModel
Imports System.Windows.Forms
Imports DataBase.Utils
Imports DataBase
Imports System.Drawing
Imports AForge.Video.DirectShow
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPro
    Private VideoSource As VideoCaptureDevice
    Private VideoSourcePaciente As VideoCaptureDevice
    Private T_O As String
    Public Property Id_Enviado_Cli As Integer
    Public Property Id_Enviado_Pac As Integer

    Private Sub LimparForm(ByVal controlP As Control)
        Dim ctl As Control
        ' For Each ctl In controlP.Controls
        '    If TypeOf ctl Is TextBox Then
        '        DirectCast(ctl, TextBox).Text = "" 'String.Empty
        '    ElseIf TypeOf ctl Is ComboBox Then
        '        DirectCast(ctl, ComboBox).Text = "" 'String.Empty
        '    ElseIf TypeOf ctl Is MaskedTextBox Then
        '        DirectCast(ctl, MaskedTextBox).Text = "" 'String.Empty
        '    ElseIf TypeOf ctl Is CheckBox Then
        '        DirectCast(ctl, CheckBox).Checked = False
        '    ElseIf TypeOf ctl Is ProgressBar Then
        '        DirectCast(ctl, ProgressBar).Value = 0
        '        'ElseIf ctl.Controls.Count > 0 Then
        '        '    LimparForm(ctl)
        '    End If
        ' Next

        'chkFJ.Checked = False

        Txt_ID.Text = ""
        Txt_Nome_Cli.Text = ""
        Txt_Contato.Text = ""

        Txt_CEP.Text = ""
        Cbo_Endereco.Text = ""
        Txt_Nro.Text = ""
        Txt_Compl.Text = ""
        Cbo_Bairro.Text = ""
        Txt_Cidade.Text = ""
        Cbo_UF.Text = ""

        Txt_Fone1.Text = ""
        Txt_Fone2.Text = ""

        Txt_DtNas.Text = ""
        Txt_Rg.Text = ""
        Txt_CPF_CNPJ.Text = ""

        ' .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)
        Txt_EMail.Text = ""

        Pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        If chkFJ.Checked = False Then
            Txt_CPF_CNPJ.ValidaCPF = True
            Txt_CPF_CNPJ.ValidaCNPJ = False
        Else
            Txt_CPF_CNPJ.ValidaCPF = False
            Txt_CPF_CNPJ.ValidaCNPJ = True
        End If
        Txt_CPF_CNPJ.Enabled = True
        Txt_ID.Enabled = True

        TreeView1.Nodes.Clear()

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Parametro = New List(Of SqlParameter)

        Dim dt As New DataTable
        dt = banco.ExecutaDataTable("Sp_Cliente_Bairro", Parametro)
        Cbo_Bairro.DisplayMember = "ClBairro"
        Cbo_Bairro.ValueMember = "ClBairro"
        Cbo_Bairro.DataSource = dt

        '''   ANIMAL

        txt_Id_Paciente.Text = ""
        Txt_Nome_Ani.Text = ""
        rb_Canino.Checked = False
        rb_Felino.Checked = False
        CboRaca.Text = ""
        CboPorte.Text = ""
        CboCor.Text = ""
        CboPelo.Text = ""
        rbFemea.Checked = False
        rbMacho.Checked = False
        Txt_DtNas.Text = ""
        Txt_Pedigree.Text = ""
        Txt_Chip.Text = ""
        Txt_Obs.Text = ""
        Txt_DtNasAni.Text = ""
        cboConvenio.Text = ""
        Pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")

        'Le termos do paciente
        dt = banco.ExecutaDataTable("Sp_Cliente_Termos", Parametro)
        cboTermos.DisplayMember = "TrDesc"
        cboTermos.ValueMember = "TrCaminho"
        cboTermos.DataSource = dt

    End Sub
    Private Sub ValidaCliente()
        Dim blnvalida As Boolean = True
        Dim objCliente As Cls_Cliente

        'VALIDACAO DOS CAMPOS OBRIGATORIOS
        If Txt_Nome_Cli.TextLength = 0 Then
            epValida.SetError(Txt_Nome_Cli, "Informar o campo nome.")
            blnvalida = False
        End If
        If Txt_CEP.TextLength = 0 Then
            epValida.SetError(Txt_CEP, "Informar o campo nome.")
            blnvalida = False
        End If
        If Txt_CPF_CNPJ.IsValido = False Then
            blnvalida = False
        End If
        If Txt_Fone1.TextLength = 0 Then
            epValida.SetError(Txt_Fone1, "Informar o campo Telefone")
            blnvalida = False
        End If
        If blnvalida = False Then Exit Sub

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
            .Cl_Nro = Txt_Nro.Text
            .Cl_Compl = UCase(Txt_Compl.Text)
            .Cl_Bairro = UCase(Cbo_Bairro.Text)
            .Cl_Cidade = UCase(Txt_Cidade.Text)
            .Cl_Uf = UCase(Trim(Cbo_UF.Text))

            .Cl_Fixo = Txt_Fone1.Text
            .Cl_Cel = Txt_Fone2.Text

            .Cl_DtNas = Txt_DtNas.Text
            .Cl_RG = Txt_Rg.Text
            .Cl_Cpf = Txt_CPF_CNPJ.Text

            .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)

            .Cl_Email = Txt_EMail.Text

            'If Pic_Cliente.Image IsNot Nothing Then
            '    Pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
            'End If

            'salva a imagem nA PASTA
            Pic_Cliente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
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

    Private Sub ValidaPaciente()
        Dim blnvalida As Boolean = True
        Dim objCliente As Cls_Cliente

        'VALIDACAO DOS CAMPOS OBRIGATORIOS
        If Txt_Nome_Ani.TextLength = 0 Then
            epValida.SetError(Txt_Nome_Cli, "Informar o campo nome.")
            blnvalida = False
        End If

        If blnvalida = False Then Exit Sub

        'INSTANCIA O CLIENTE
        objCliente = New Cls_Cliente
        With objCliente
            .Tipo_Operacao = T_O
            If txt_Id_Paciente.TextLength = 0 Then
                txt_Id_Paciente.Text = 0
            End If

            .Id_Animal = txt_Id_Paciente.Text

            .Cl_Id = Txt_ID.Text
            .Ani_Cliente = .Cl_Id

            .Ani_Nome = UCase(Txt_Nome_Cli.Text)

            Dim Especie As Integer
            Dim Sexo As String
            Dim Vivo As Integer
            Dim Agre As Integer

            Especie = 3
            If rb_Canino.Checked = True Then
                Especie = 1
            End If
            If rb_Felino.Checked = True Then
                Especie = 2
            End If
            .Ani_Especie = Especie

            .Ani_Raca = UCase(Trim(CboRaca.Text))
            .Ani_Porte = UCase(Trim(CboPorte.Text))
            .Ani_Cor = UCase(Trim(CboCor.Text))
            .Ani_Pelo = UCase(Trim(CboPelo.Text))

            Sexo = "M"
            If rbFemea.Checked = True Then
                Sexo = "F"
            End If
            .Ani_Sexo = Sexo

            .Ani_DtNas = Txt_DtNas.Text

            Vivo = 0
            'If chVivo.Checked = True Then
            '    Vivo = 1
            'End If
            .Ani_Vivo = Vivo

            Agre = 0
            'If chAgressivo.Checked = True Then
            '    Agre = 1
            'End If
            .Ani_Agressico = Agre

            .Ani_Pedigree = Txt_Pedigree.Text
            .Ani_Chip = Txt_Chip.Text
            .Ani_Obs = Txt_Obs.Text
            .Ani_DtCad = Now
            .Ani_Conv = cboConvenio.SelectedValue

            Pic_Paciente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
            .Ani_Foto = ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

            'grava o registro
            .GravaPaciente()
            txt_Id_Paciente.Text = .Id_Animal
            If T_O = "I" Then
                txt_Id_Paciente.Text = .Id_Animal
                MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                .Id_Animal = txt_Id_Paciente.Text
                MessageBox.Show("Alteração de cadastrado efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With

    End Sub

    Private Sub frmProntuario_Load(sender As Object, e As EventArgs)
        LimparForm(Me)
        pnLateralCliente.Size = New Size(64, 275)
        btnFrmConsulta.Size = New Size(50, 40)
        btnFrmConsulta.Text = ""
        btnFrmVacina.Size = New Size(50, 40)
        btnFrmVacina.Text = ""
        btnFrmReceita.Size = New Size(50, 40)
        btnFrmReceita.Text = ""
        pnDadosCliente.Location = New Point(88, 54)
        Me.Size = New Size(1000, 600)

        Dim VideoSources = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If VideoSources IsNot Nothing AndAlso VideoSources.Count > 0 Then
            VideoSource = New VideoCaptureDevice(VideoSources(0).MonikerString)
            AddHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
        End If

        Dim CAMARA_Anis = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If CAMARA_Anis IsNot Nothing AndAlso CAMARA_Anis.Count > 0 Then
            VideoSourcePaciente = New VideoCaptureDevice(CAMARA_Anis(0).MonikerString)
            AddHandler VideoSourcePaciente.NewFrame, AddressOf VideoSourcePaciente_NewFrame
        End If

        Txt_ID.Text = Id_Enviado_Cli
        Le_Cliente()
        If Id_Enviado_Cli > 0 Then
            Txt_CPF_CNPJ.Enabled = False
            Txt_ID.Enabled = False
        End If
        If Id_Enviado_Pac > 0 Then
            txt_Id_Paciente.Text = Id_Enviado_Pac
            Le_Paciente()
        End If

    End Sub

    Private Sub Txt_Nome_Cli_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Nome_Cli.Validating
        If Txt_Nome_Cli.TextLength = 0 Then
            epValida.SetError(Txt_Nome_Cli, "Favor informar o campo nome.")
        End If
    End Sub

    Private Sub Txt_Fone1_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Fone1.Validating
        If Txt_Fone1.TextLength = 0 Then
            epValida.SetError(Txt_Fone1, "Favor informar o campo Telefone.")
        End If
    End Sub
    Private Sub Txt_CEP_Validating(sender As Object, e As CancelEventArgs) Handles Txt_CEP.Validating
        If Txt_CEP.TextLength = 0 Then
            epValida.SetError(Txt_CEP, "Favor informar o campo CEP.")
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Dim blnvalida As Boolean = True

        Try
            'grava o registro
            T_O = "I"
            ValidaCliente()
            T_O = ""
        Catch ex As Exception
            TrataErro("Problema ao tentar gravar os dados do cliente.", ex)
        End Try

    End Sub
    Private Sub Txt_CEP_LostFocus(sender As Object, e As EventArgs) Handles Txt_CEP.LostFocus

        If Txt_CEP.TextLength > 0 Then
            Try
                Me.Cursor = Cursors.AppStarting '.WaitCursor
                Dim cep As Cls_BuscaCEP = PesquisaCEP(Txt_CEP.Text.Replace("-", ""))
                'Dim c = PesquisaCEP(Txt_CEP.Text.Replace("-", ""))
                'c.
                Cbo_Bairro.Text = cep.bairro
                Cbo_Endereco.Text = cep.logradouro
                Txt_Cidade.Text = cep.localidade
                Cbo_UF.Text = cep.uf

                Txt_Nro.Select()
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                TrataErro("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex)
            End Try
        End If
    End Sub

    Private Sub btnAlterar_MouseLeave(sender As Object, e As EventArgs) Handles btnAlterar.MouseLeave
        btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub Pic_Cliente_Click(sender As Object, e As EventArgs) Handles Pic_Cliente.Click
        If VideoSource.IsRunning Then
            VideoSource.Stop()
            Pic_Cliente.Image = Nothing
        Else
            VideoSource.Start()
        End If
    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Try
            ''grava o registro
            T_O = "U"
            ValidaCliente()
            T_O = ""
        Catch ex As Exception
            btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
            TrataErro("Problema ao tentar gravar os dados do cliente.", ex)
        End Try

    End Sub

    Private Sub frmProntuario_Closing(sender As Object, e As CancelEventArgs)
        If VideoSource.IsRunning Then
            VideoSource.Stop()
            VideoSourcePaciente.Stop()
        End If
        MyBase.OnFormClosing(e)
    End Sub
    Private Sub Le_Cliente()
        If Txt_ID.TextLength <= 0 Or Txt_ID.TextLength = 0 Then
            Exit Sub
        Else
            Dim objCliente As New Cls_Cliente
            objCliente.Cl_Id = Convert.ToInt32(Txt_ID.Text)

            If objCliente.BuscaCliente("Sp_Cliente_Sel", objCliente.Cl_Id) = False Then
                'LeCliente()
                With objCliente

                    chkFJ.Checked = .Cl_FJ
                    Txt_Nome_Cli.Text = UCase(.Cl_Nome)
                    Txt_Contato.Text = UCase(Trim(.Cl_Contato))

                    Txt_CEP.Text = .Cl_CEP
                    Cbo_Endereco.Text = UCase(Trim(.Cl_End))
                    Txt_Nro.Text = .Cl_Nro
                    Txt_Compl.Text = UCase(.Cl_Compl)
                    Cbo_Bairro.Text = UCase(.Cl_Bairro)
                    Txt_Cidade.Text = UCase(.Cl_Cidade)
                    Cbo_UF.Text = UCase(Trim(.Cl_Uf))

                    Txt_Fone1.Text = .Cl_Fixo
                    Txt_Fone2.Text = .Cl_Cel

                    Txt_DtNas.Text = .Cl_DtNas
                    Txt_Rg.Text = .Cl_RG
                    Txt_CPF_CNPJ.Text = .Cl_Cpf

                    ' .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)
                    Txt_EMail.Text = .Cl_Email

                    If .Cl_Foto.Trim = "" Or .Cl_Foto.Length = 0 Then
                        Pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                    Else
                        Pic_Cliente.Image = AbrirArquivoBase64(.Cl_Foto)
                    End If

                End With
                Preenche_TreeListView()
            Else
                MessageBox.Show("ID nao cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Try
                ' MessageBox.Show("Problemas ao ler os dados de cadastrado do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                TrataErro("Problema ao tentar localizar o cliente.", ex)
            End Try
        End If
    End Sub
    Private Sub Txt_ID_LostFocus(sender As Object, e As EventArgs) Handles Txt_ID.LostFocus
        Le_Cliente()
    End Sub

    Private Sub chkFJ_CheckedChanged(sender As Object, e As EventArgs) Handles chkFJ.CheckedChanged
        LimparForm(Me)
        If chkFJ.Checked = False Then
            Txt_CPF_CNPJ.ValidaCPF = True
            Txt_CPF_CNPJ.ValidaCNPJ = False
        Else
            Txt_CPF_CNPJ.ValidaCPF = False
            Txt_CPF_CNPJ.ValidaCNPJ = True
        End If
    End Sub

    Private Sub frmProntuario_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F12 Then
            LimparForm(Me)

            Txt_CPF_CNPJ.Focus()
        End If
    End Sub

    Private Sub btnGravaPaciente_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            'grava o registro
            T_O = "I"
            ValidaPaciente()
            T_O = ""
        Catch ex As Exception
            TrataErro("Problema ao tentar gravar os dados do Paciente.", ex)
        End Try
    End Sub

    Private Sub btoGravaPaciente_Click(sender As Object, e As EventArgs) Handles btoGravaPaciente.Click

    End Sub

    Private Sub btoGravaPaciente_MouseHover(sender As Object, e As EventArgs) Handles btoGravaPaciente.MouseHover
        btoGravaPaciente.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub btoAlterarPaciente_MouseHover(sender As Object, e As EventArgs) Handles btoAlterarPaciente.MouseHover
        btoAlterarPaciente.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub btnGravar_MouseHover(sender As Object, e As EventArgs) Handles btnGravar.MouseHover
        btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub Pic_Cliente_MouseHover(sender As Object, e As EventArgs) Handles Pic_Cliente.MouseHover
        Pic_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub Pic_Paciente_MouseHover(sender As Object, e As EventArgs) Handles Pic_Paciente.MouseHover
        Pic_Paciente.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub

    Private Sub btoAlterarPaciente_Click(sender As Object, e As EventArgs) Handles btoAlterarPaciente.Click
        Try
            ''grava o registro
            T_O = "U"
            ValidaPaciente()
            T_O = ""
        Catch ex As Exception
            btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
            TrataErro("Problema ao tentar gravar os dados do Paciente.", ex)
        End Try
    End Sub

    Private Sub Le_Paciente()
        Try

            Dim objPaciente As New Cls_Cliente
            ' objPaciente.Id_Animal = Convert.ToInt32(txt_Id_Paciente.Text)
            objPaciente.Id_Animal = txt_Id_Paciente.Text
            If objPaciente.BuscaPaciente = False Then

                With objPaciente
                    txt_Id_Paciente.Text = .Id_Animal

                    Txt_Nome_Ani.Text = UCase(.Ani_Nome)

                    rb_Canino.Checked = .Ani_Especie
                    rb_Felino.Checked = .Ani_Especie

                    CboRaca.Text = UCase(Trim(.Ani_Raca))
                    CboPorte.Text = UCase(Trim(.Ani_Porte))
                    CboCor.Text = UCase(Trim(.Ani_Cor))
                    CboPelo.Text = UCase(Trim(.Ani_Pelo))

                    rbFemea.Checked = False
                    rbMacho.Checked = False
                    If .Ani_Sexo = "F" Then
                        rbFemea.Checked = True
                    Else
                        rbMacho.Checked = True
                    End If

                    Txt_DtNas.Text = .Ani_DtNas

                    Txt_Pedigree.Text = .Ani_Pedigree
                    Txt_Chip.Text = .Ani_Chip
                    Txt_Obs.Text = .Ani_Obs
                    Txt_DtNasAni.Text = .Ani_DtNas

                    cboConvenio.Text = .Ani_Conv

                    If .Ani_Foto.Trim <> "" Then
                        Pic_Paciente.Image = AbrirArquivoBase64(.Ani_Foto) 'TRANSFERE 
                    Else
                        Pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                    End If

                End With

            Else
                MessageBox.Show("ID nao cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            TrataErro("Problema ao tentar localizar o Paciente.", ex)
        End Try
    End Sub
    Private Sub txt_Id_Paciente_LostFocus(sender As Object, e As EventArgs) Handles txt_Id_Paciente.LostFocus
        If txt_Id_Paciente.TextLength > 0 Then
            Le_Paciente()
        End If
    End Sub

    Private Sub bto_Img_Cli_Click(sender As Object, e As EventArgs) Handles bto_Img_Cli.Click
        If Trim(Txt_ID.Text) = "" Then
            MessageBox.Show("ID do Cliente nao informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If Pic_Cliente.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                VideoSource.Stop()
                RemoveHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
                'salva a imagem nA PASTA
                Pic_Cliente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                'MessageBox.Show("Imagem salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                AddHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
            End Try
        End If
    End Sub

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If Pic_Cliente.Image IsNot Nothing Then
            Pic_Cliente.Image.Dispose()
        End If
        Pic_Cliente.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub VideoSourcePaciente_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If Pic_Paciente.Image IsNot Nothing Then
            Pic_Paciente.Image.Dispose()
        End If
        Pic_Paciente.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If IsNumeric(Trim(Mid(TreeView1.SelectedNode.Text, 1, 6))) = True Then

            txt_Id_Paciente.Text = Mid(TreeView1.SelectedNode.Text, 1, 6)
            Le_Paciente()
            Txt_Nome_Ani.Focus()

        End If
    End Sub
    Private Sub Preenche_TreeListView()

        Dim NssNro As Integer
        Try


            TreeView1.Nodes.Clear()

            Dim objCliente As New Cls_Cliente
            objCliente.Cl_Id = Convert.ToInt32(Txt_ID.Text)
            objCliente.BuscaTreeListView()

            Dim dtvcto As String
            Dim idanimal As String
            Dim aninome As String
            Dim finssnro As String
            Dim fivlr As String
            Dim fivlrpgto As String
            Dim fidtpgto As String
            Dim faev As String
            Dim fadesc As String
            Dim favlru As String
            Dim faqtd As String
            Dim favlr As String
            Dim id_nome As String

            finssnro = 0
            NssNro = 0
            id_nome = ""
            Dim id_no As Integer = -1
            Dim id_no_2 As Integer = -1
            Dim id_no_3 As Integer = -1

            Dim tNode As TreeNode
            tNode = TreeView1.Nodes.Add(Txt_Nome_Cli.Text)

            TreeView1.ImageList = ImageList1
            TreeView1.Nodes(0).ImageIndex = 0

            For matriz = 0 To (objCliente.CtaReg - 1)

                dtvcto = objCliente.LinhaTLV(matriz, 1)
                idanimal = objCliente.LinhaTLV(matriz, 2)
                aninome = objCliente.LinhaTLV(matriz, 3)
                finssnro = objCliente.LinhaTLV(matriz, 4)
                fivlr = objCliente.LinhaTLV(matriz, 5)
                fivlrpgto = objCliente.LinhaTLV(matriz, 6)
                fidtpgto = objCliente.LinhaTLV(matriz, 7)
                faev = objCliente.LinhaTLV(matriz, 8)
                fadesc = objCliente.LinhaTLV(matriz, 9)
                favlru = objCliente.LinhaTLV(matriz, 10)
                faqtd = objCliente.LinhaTLV(matriz, 11)
                favlr = objCliente.LinhaTLV(matriz, 12)

                Dim chave_no_2 As String
                'Dim chave_no_3 As String
                chave_no_2 = dtvcto & " - " & finssnro & " - " & Format(fivlr, "0,00") & " - " & Format(fivlrpgto, "0,00") & " - " & fidtpgto
                'chave_no_3 = fadesc & " - " & favlru & " - " & faqtd & " - " & favlr

                '  Dim chave_no_2 As String = String.Format("{0,8}, {1,6}, {2, 8}, {3, 8}, {4, 8}", dtvcto, finssnro, fivlr, fivlrpgto, fidtpgto)
                Dim chave_no_3 As String = String.Format("{0, 40}, {1, 8}, {2, 6}, {3, 8}", LTrim(fadesc), Format(favlru, "0,00"), Format(faqtd, "0.000"), Format(favlr, "0,00"))

                If id_nome <> objCliente.LinhaTLV(matriz, 3) Then
                    id_nome = aninome
                    Dim N As String = String.Format("{0,4}, {1}", idanimal, aninome)
                    TreeView1.Nodes(0).Nodes.Add(N) 'segundo nivel NOME DO ANIMAL
                    id_no = id_no + 1
                    id_no_2 = -1
                    TreeView1.Nodes(0).Nodes(id_no).ImageIndex = 1
                    'TreeView1.Nodes(0).Nodes(id_no).Expand()
                End If

                If finssnro <> NssNro Then
                    NssNro = objCliente.LinhaTLV(matriz, 4)
                    'TreeView1.Nodes(0).Nodes(id_no).Expand()
                    TreeView1.Nodes(0).Nodes(id_no).Nodes.Add(chave_no_2) 'terceiro nivel DATA DA OS
                    id_no_2 = id_no_2 + 1

                    If fivlrpgto = 0 Then
                        TreeView1.Nodes(0).Nodes(id_no).Nodes(id_no_2).ImageIndex = 2
                    Else
                        TreeView1.Nodes(0).Nodes(id_no).Nodes(id_no_2).ImageIndex = 3
                    End If

                    id_no_3 = -1
                End If

                id_no_3 = id_no_3 + 1
                TreeView1.Nodes(0).Nodes(id_no).Nodes(id_no_2).Nodes.Add(chave_no_3) 'DETALHES DA OS
                TreeView1.Nodes(0).Nodes(id_no).Nodes(id_no_2).Nodes(id_no_3).ImageIndex = 4
            Next

            TreeView1.Nodes(0).Expand()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Pic_Paciente_Click(sender As Object, e As EventArgs) Handles Pic_Paciente.Click
        If VideoSourcePaciente.IsRunning Then
            VideoSourcePaciente.Stop()
            Pic_Paciente.Image = Nothing
        Else
            VideoSourcePaciente.Start()
        End If
    End Sub

    Private Sub bto_Img_Paciente_Click(sender As Object, e As EventArgs) Handles bto_Img_Paciente.Click
        If Trim(txt_Id_Paciente.Text) = "" Then
            MessageBox.Show("ID do Paciente não informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Pic_Cliente.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                VideoSourcePaciente.Stop()
                RemoveHandler VideoSourcePaciente.NewFrame, AddressOf VideoSourcePaciente_NewFrame
                'salva a imagem nA PASTA
                Pic_Paciente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                'MessageBox.Show("Imagem salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                AddHandler VideoSourcePaciente.NewFrame, AddressOf VideoSourcePaciente_NewFrame
            End Try
        End If
    End Sub

    Private Sub Txt_CPF_CNPJ_LostFocus(sender As Object, e As EventArgs) Handles Txt_CPF_CNPJ.LostFocus

        If Txt_CPF_CNPJ.TextLength = 0 Then
            Exit Sub
        End If

        Dim Cliente As New Cls_Cliente
        Cliente.Cl_Cpf = Replace(Replace(Replace(Replace(Txt_CPF_CNPJ.Text, ".", ""), "-", ""), "/", ""), " ", "")
        Cliente.Cl_Id = 0
        Cliente.ConfereCPF()

        If Cliente.CtaReg > 0 Then
            MessageBox.Show("CPF já cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With Cliente

                chkFJ.Checked = .Cl_FJ
                Txt_Nome_Cli.Text = UCase(.Cl_Nome)
                Txt_Contato.Text = UCase(Trim(.Cl_Contato))

                Txt_CEP.Text = .Cl_CEP
                Cbo_Endereco.Text = UCase(Trim(.Cl_End))
                Txt_Nro.Text = .Cl_Nro
                Txt_Compl.Text = UCase(.Cl_Compl)
                Cbo_Bairro.Text = UCase(.Cl_Bairro)
                Txt_Cidade.Text = UCase(.Cl_Cidade)
                Cbo_UF.Text = UCase(Trim(.Cl_Uf))

                Txt_Fone1.Text = .Cl_Fixo
                Txt_Fone2.Text = .Cl_Cel

                Txt_DtNas.Text = .Cl_DtNas
                Txt_Rg.Text = .Cl_RG
                Txt_CPF_CNPJ.Text = .Cl_Cpf

                ' .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)
                Txt_EMail.Text = .Cl_Email

                If .Cl_Foto.Trim = "" Or .Cl_Foto.Length = 0 Then
                    Pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                Else
                    Pic_Cliente.Image = AbrirArquivoBase64(.Cl_Foto)
                End If

            End With
        End If

    End Sub
    Private Sub Txt_CPF_CNPJ_GotFocus(sender As Object, e As EventArgs) Handles Txt_CPF_CNPJ.GotFocus
        LimparForm(Me)
    End Sub

    Private Sub btnFrmConsulta_Click(sender As Object, e As EventArgs) Handles btnFrmConsulta.Click

        If txt_Id_Paciente.TextLength <> 0 Or txt_Id_Paciente.TextLength > 0 Then
            'Dim frm As New frmConsulta
            'frm.codigo_do_Paciente = txt_Id_Paciente.Text
            'frm.ShowDialog()
        Else
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub picMenuCliente_Click(sender As Object, e As EventArgs) Handles picMenuCliente.Click
        If pnLateralCliente.Size = New Size(178, 275) Then
            pnLateralCliente.Size = New Size(64, 275)
            pnDadosCliente.Location = New Point(88, 54)
            btnFrmConsulta.Size = New Size(50, 40)
            btnFrmConsulta.Text = ""
            btnFrmVacina.Size = New Size(50, 40)
            btnFrmVacina.Text = ""
            btnFrmReceita.Size = New Size(50, 40)
            btnFrmReceita.Text = ""
            '    Me.Size = New Size(1000, 600)
        Else
            'tamanho default
            pnLateralCliente.Size = New Size(178, 275)
            pnDadosCliente.Location = New Point(160, 55)
            btnFrmConsulta.Size = New Size(120, 40)
            btnFrmVacina.Size = New Size(120, 40)
            btnFrmReceita.Size = New Size(120, 40)
            btnFrmConsulta.Text = btnFrmConsulta.Tag
            btnFrmReceita.Text = btnFrmReceita.Tag
            btnFrmVacina.Text = btnFrmVacina.Tag
            'Me.Size = New Size(1450, 900)
        End If
    End Sub

    Private Sub btnFrmReceita_Click(sender As Object, e As EventArgs) Handles btnFrmReceita.Click
        If txt_Id_Paciente.TextLength <> 0 Or txt_Id_Paciente.TextLength > 0 Then
            'Dim frm As New frmReceita
            'frm.Receita_ID_Paciente = txt_Id_Paciente.Text
            'frm.Receita_ID_Cliente = Txt_ID.Text
            'frm.ShowDialog()
        Else
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnFrmVacina_Click(sender As Object, e As EventArgs) Handles btnFrmVacina.Click
        If txt_Id_Paciente.TextLength <> 0 Or txt_Id_Paciente.TextLength > 0 Then
            'Dim frm As New frmVacina
            'frm.Receita_ID_Paciente = txt_Id_Paciente.Text
            'frm.Receita_ID_Cliente = Txt_ID.Text
            'frm.ShowDialog()
        Else
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cboTermos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTermos.SelectedIndexChanged

        If txt_Id_Paciente.TextLength = 0 Then
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        frmCrystal.Show()
        Dim Caminho As String
        Dim CR As New ReportDocument

        Dim crParameterDiscreteValue As ParameterDiscreteValue
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldLocation As ParameterFieldDefinition
        Dim crParameterValues As ParameterValues

        Caminho = cboTermos.SelectedValue

        CR.Load(Caminho)
        crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("IdAnimal")

        crParameterDiscreteValue.Value = txt_Id_Paciente.Text

        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim ciReportConnection As New ConnectionInfo

        ciReportConnection.ServerName = "LAPTOP-7DFB87U7"
        ciReportConnection.DatabaseName = "CadVet"
        ciReportConnection.UserID = "rpts"
        ciReportConnection.Password = ""

        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        frmCrystal.crtVwGeral.ReportSource = CR
        frmCrystal.crtVwGeral.Refresh()

    End Sub

    Private Sub Cbo_Endereco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Endereco.SelectedIndexChanged

    End Sub

    Private Sub cboTermos_Click(sender As Object, e As EventArgs) Handles cboTermos.Click

    End Sub

    Private Sub frmProntuario_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmProntuario_Load_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmProntuario_Load_3(sender As Object, e As EventArgs)

    End Sub
End Class