Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports AForge.Video.DirectShow
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DataBase
Imports DataBase.Utils


Public Class FrmClientes

    Private VideoSource As VideoCaptureDevice
    Private VideoSourcePaciente As VideoCaptureDevice
    Private T_O As String
    Public Property Id_Enviado_Cli As Integer
    Public Property Id_Enviado_Pac As Integer
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(Parametro_Cli As String, Parametro_Pac As String)
        Me.New()
        Id_Enviado_Cli = Parametro_Cli
        Id_Enviado_Pac = Parametro_Pac
    End Sub
    Public Property Parametro_cLI As String
        Get
            Return Parametro_cLI
        End Get
        Set(value As String)
            Parametro_cLI = value
        End Set
    End Property
    Public Property Parametro_Pac As String
        Get
            Return Parametro_Pac
        End Get
        Set(value As String)
            Parametro_Pac = value
        End Set
    End Property
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
        txt_Nro.Text = ""
        txt_Compl.Text = ""
        cbo_Bairro.Text = ""
        txt_Cidade.Text = ""
        cbo_UF.Text = ""

        txt_Fone1.Text = ""
        txt_Fone2.Text = ""

        Txt_DtNasAni.Text = ""
        txt_RG.Text = ""
        Txt_CPF_CNPJ.Text = ""

        ' .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)
        txt_Email.Text = ""

        pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
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
        cbo_Bairro.DisplayMember = "ClBairro"
        cbo_Bairro.ValueMember = "ClBairro"
        cbo_Bairro.DataSource = dt

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
        Txt_DtNasAni.Text = ""
        Txt_Pedigree.Text = ""
        Txt_Chip.Text = ""
        Txt_Obs.Text = ""
        Txt_DtNasAni.Text = ""
        cboConvenio.Text = ""
        pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")

        'Le termos dos pacientes
        dt = banco.ExecutaDataTable("Sp_Cliente_Termos", Parametro)
        cboTermos.DisplayMember = Trim("TrDesc")
        cboTermos.ValueMember = "TrCaminho"
        cboTermos.DataSource = dt

        btoMenu.PerformClick()

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
                    txt_Nro.Text = .Cl_Nro
                    txt_Compl.Text = UCase(.Cl_Compl)
                    cbo_Bairro.Text = UCase(.Cl_Bairro)
                    txt_Cidade.Text = UCase(.Cl_Cidade)
                    cbo_UF.Text = UCase(Trim(.Cl_Uf))

                    txt_Fone1.Text = .Cl_Fixo
                    txt_Fone2.Text = .Cl_Cel

                    Txt_DtNasAni.Text = .Cl_DtNas
                    txt_RG.Text = .Cl_RG
                    Txt_CPF_CNPJ.Text = .Cl_Cpf

                    ' .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)
                    txt_Email.Text = .Cl_Email
                    'If .Cl_Foto <> Nothing Then
                    '    If .Cl_Foto.Trim = "" Or .Cl_Foto.Length = 0 Then
                    pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                    '    Else
                    '        pic_Cliente.Image = AbrirArquivoBase64(.Cl_Foto)
                    '    End If
                    'End If

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

                    txt_DtNas.Text = .Ani_DtNas

                    Txt_Pedigree.Text = .Ani_Pedigree
                    Txt_Chip.Text = .Ani_Chip
                    Txt_Obs.Text = .Ani_Obs
                    Txt_DtNasAni.Text = .Ani_DtNas

                    cboConvenio.Text = .Ani_Conv

                    If .Ani_Foto.Trim <> "" Then
                        pic_Paciente.Image = AbrirArquivoBase64(.Ani_Foto) 'TRANSFERE 
                    Else
                        pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                    End If

                End With

            Else
                MessageBox.Show("ID nao cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            TrataErro("Problema ao tentar localizar o Paciente.", ex)
        End Try
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
        If txt_Fone1.TextLength = 0 Then
            epValida.SetError(txt_Fone1, "Informar o campo Telefone")
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
            .Cl_Nro = txt_Nro.Text
            .Cl_Compl = UCase(txt_Compl.Text)
            .Cl_Bairro = UCase(cbo_Bairro.Text)
            .Cl_Cidade = UCase(txt_Cidade.Text)
            .Cl_Uf = UCase(Trim(cbo_UF.Text))

            .Cl_Fixo = txt_Fone1.Text
            .Cl_Cel = txt_Fone2.Text

            .Cl_DtNas = Txt_DtNasAni.Text
            .Cl_RG = txt_RG.Text
            .Cl_Cpf = Txt_CPF_CNPJ.Text

            .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)

            .Cl_Email = txt_Email.Text

            'If Pic_Cliente.Image IsNot Nothing Then
            '    Pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
            'End If

            'salva a imagem nA PASTA
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

            .Ani_Nome = UCase(Txt_Nome_Ani.Text)

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

            .Ani_DtNas = Txt_DtNasAni.Text

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

            pic_Paciente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
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
    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If pic_Cliente.Image IsNot Nothing Then
            pic_Cliente.Image.Dispose()
        End If
        pic_Cliente.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub VideoSourcePaciente_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If pic_Paciente.Image IsNot Nothing Then
            pic_Paciente.Image.Dispose()
        End If
        pic_Paciente.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimparForm(Me)
        pnLateralCliente.Size = New Size(64, 275)
        pnDadosCliente.Location = New Point(88, 12)
        pnDetalhe.Location = New Point(88, 290)
        pnDadosPaciente.Location = New Point(88, 480)
        btoFrmConsulta.Size = New Size(50, 40)
        btoFrmConsulta.Text = ""
        btoFrmVacina.Size = New Size(50, 40)
        btoFrmVacina.Text = ""
        btoFrmReceita.Size = New Size(50, 40)
        btoFrmReceita.Text = ""
        btnFrmFinanceiro.Size = New Size(50, 40)
        btnFrmFinanceiro.Text = ""

        Me.Size = New Size(1190, 1050)

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
        txt_Id_Paciente.Text = Id_Enviado_Pac
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

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nome_Cli.TextChanged

    End Sub

    Private Sub txtNome_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Nome_Cli.Validating
        If Txt_Nome_Cli.TextLength = 0 Then
            epValida.SetError(Txt_Nome_Cli, "Favor informar o campo nome.")
        End If
    End Sub

    Private Sub txtFone1_Validating(sender As Object, e As CancelEventArgs) Handles txt_Fone1.Validating
        If txt_Fone1.TextLength = 0 Then
            epValida.SetError(txt_Fone1, "Favor informar o campo Telefone.")
        End If
    End Sub

    Private Sub txtCEP_Validating(sender As Object, e As CancelEventArgs) Handles Txt_CEP.Validating
        If Txt_CEP.TextLength = 0 Then
            epValida.SetError(Txt_CEP, "Favor informar o campo CEP.")
        End If
    End Sub
    Private Sub txtCEP_LostFocus(sender As Object, e As EventArgs) Handles Txt_CEP.LostFocus

        If Txt_CEP.TextLength > 0 Then
            Try
                Me.Cursor = Cursors.AppStarting '.WaitCursor
                Dim cep As Cls_BuscaCEP = PesquisaCEP(Txt_CEP.Text.Replace("-", ""))
                'Dim c = PesquisaCEP(Txt_CEP.Text.Replace("-", ""))
                'c.
                cbo_Bairro.Text = cep.bairro
                Cbo_Endereco.Text = cep.logradouro
                txt_Cidade.Text = cep.localidade
                cbo_UF.Text = cep.uf

                txt_Nro.Select()
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                TrataErro("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex)
            End Try
        End If
    End Sub

    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
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

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub
    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

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
    Private Sub picCliente_Click(sender As Object, e As EventArgs) Handles pic_Cliente.Click
        If VideoSource.IsRunning Then
            VideoSource.Stop()
            pic_Cliente.Image = Nothing
        Else
            VideoSource.Start()
        End If
    End Sub

    Private Sub FrmClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If VideoSource.IsRunning Then
                VideoSource.Stop()
                VideoSourcePaciente.Stop()
            End If
        Catch ex As Exception

        End Try

        MyBase.OnFormClosing(e)
    End Sub

    Private Sub txtIdCli_TextChanged(sender As Object, e As EventArgs) Handles Txt_ID.TextChanged

    End Sub

    Private Sub txtIdCli_LostFocus(sender As Object, e As EventArgs) Handles Txt_ID.LostFocus
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

    Private Sub FrmClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            LimparForm(Me)

            Txt_CPF_CNPJ.Focus()
        End If
    End Sub

    Private Sub bto_Img_Cli_Click(sender As Object, e As EventArgs) Handles bto_Img_Cli.Click
        If Trim(Txt_ID.Text) = "" Then
            MessageBox.Show("ID do Cliente nao informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If pic_Cliente.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                VideoSource.Stop()
                RemoveHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
                'salva a imagem nA PASTA
                pic_Cliente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                'MessageBox.Show("Imagem salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                AddHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
            End Try
        End If
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

    Private Sub btoFrmReceita_Click(sender As Object, e As EventArgs) Handles btoFrmReceita.Click
        If txt_Id_Paciente.TextLength <> 0 Or txt_Id_Paciente.TextLength > 0 Then

            'Dim frm As New frmReceita
            'frm.Receita_ID_Paciente = txt_Id_Paciente.Text
            'frm.Receita_ID_Cliente = Txt_ID.Text
            'frm.ShowDialog()
        Else
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btoFrmVacina_Click(sender As Object, e As EventArgs) Handles btoFrmVacina.Click
        If txt_Id_Paciente.TextLength <> 0 Or txt_Id_Paciente.TextLength > 0 Then
            'Dim frm As New frmVacina
            'frm.Paciente_Id_Vacina = txt_Id_Paciente.Text
            'frm.ShowDialog()
        Else
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btoMenu_Click(sender As Object, e As EventArgs) Handles btoMenu.Click
        If pnLateralCliente.Size = New Size(178, 275) Then
            pnLateralCliente.Size = New Size(64, 275)
            pnDadosCliente.Location = New Point(88, 12)
            pnDetalhe.Location = New Point(88, 290)
            pnDadosPaciente.Location = New Point(88, 480)
            btoFrmConsulta.Size = New Size(50, 40)
            btoFrmConsulta.Text = ""
            btoFrmVacina.Size = New Size(50, 40)
            btoFrmVacina.Text = ""
            btoFrmReceita.Size = New Size(50, 40)
            btoFrmReceita.Text = ""
            btnFrmFinanceiro.Size = New Size(50, 40)
            btnFrmFinanceiro.Text = ""
            'Me.Size = New Size(1000, 600)
        Else
            'tamanho default
            pnLateralCliente.Size = New Size(178, 275)
            pnDadosCliente.Location = New Point(200, 12)
            pnDetalhe.Location = New Point(200, 290)
            pnDadosPaciente.Location = New Point(200, 480)
            btoFrmConsulta.Size = New Size(120, 40)
            btoFrmVacina.Size = New Size(120, 40)
            btoFrmReceita.Size = New Size(120, 40)
            btoFrmConsulta.Text = btoFrmConsulta.Tag
            btoFrmConsulta.Text = "Consulta"
            btoFrmReceita.Text = btoFrmReceita.Tag
            btoFrmReceita.Text = "Receita"
            btoFrmVacina.Text = btoFrmVacina.Tag
            btoFrmVacina.Text = "Vacina"
            btnFrmFinanceiro.Size = New Size(120, 40)
            btnFrmFinanceiro.Text = btoFrmVacina.Tag
            btnFrmFinanceiro.Text = "Financeiro"
            'Me.Size = New Size(1450, 900)
        End If
    End Sub



    Private Sub Txt_CPF_CNPJ_GotFocus(sender As Object, e As EventArgs) Handles Txt_CPF_CNPJ.GotFocus
        LimparForm(Me)
    End Sub

    Private Sub cboTermos_SelectedIndexChanged(sender As Object, e As EventArgs)
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

    Private Sub btoGravaPaciente_Click(sender As Object, e As EventArgs) Handles btoGravaPaciente.Click
        Try
            'grava o registro
            T_O = "I"
            ValidaPaciente()
            T_O = ""
        Catch ex As Exception
            TrataErro("Problema ao tentar gravar os dados do Paciente.", ex)
        End Try

    End Sub

    Private Sub pic_Paciente_Click(sender As Object, e As EventArgs) Handles pic_Paciente.Click
        If VideoSourcePaciente.IsRunning Then
            VideoSourcePaciente.Stop()
            pic_Paciente.Image = Nothing
        Else
            VideoSourcePaciente.Start()
        End If
    End Sub

    Private Sub cboTermos_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboTermos.SelectedIndexChanged
        If txt_Id_Paciente.TextLength = 0 Then
            ' MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Try
        '    Dim cryRpt As New ReportDocument
        '    frmCrystal.Show()
        '    cryRpt.Load(cboTermos.SelectedValue)
        '    cryRpt.ParameterFields(0).CurrentValues.AddValue(Convert.ToInt32(txt_Id_Paciente.Text))
        '    frmCrystal.crtVwGeral.ReportSource = cryRpt
        '    frmCrystal.crtVwGeral.Refresh()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Me.Close()
        'End Try



        'If txt_Id_Paciente.TextLength = 0 Then
        '    MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If


        'frmCrystal.Show()
        'Dim Caminho As String
        'Dim CR As New ReportDocument

        'Dim crParameterDiscreteValue As New ParameterDiscreteValue
        'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim crParameterFieldLocation As ParameterFieldDefinition
        'Dim crParameterValues As ParameterValues

        'Caminho = cboTermos.SelectedValue

        'CR.Load(Caminho)

        'crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
        'crParameterFieldLocation = crParameterFieldDefinitions.Item("IdAnimal")
        'crParameterDiscreteValue.Value = txt_Id_Paciente.Text
        'crParameterValues = crParameterFieldLocation.CurrentValues
        'crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

        'Dim ciReportConnection As New ConnectionInfo

        'ciReportConnection.ServerName = "LAPTOP-7DFB87U7"
        'ciReportConnection.DatabaseName = "CadVet"
        'ciReportConnection.UserID = "rpts"
        'ciReportConnection.Password = ""

        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        'frmCrystal.crtVwGeral.ReportSource = CR
        'frmCrystal.crtVwGeral.Refresh()


    End Sub

    Private Sub btoImprimir_Click(sender As Object, e As EventArgs) Handles btoImprimir.Click

        If txt_Id_Paciente.TextLength = 0 Then
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Dim cryRpt As New ReportDocument
            frmCrystal.Show()
            cryRpt.Load(cboTermos.SelectedValue)
            cryRpt.ParameterFields(0).CurrentValues.AddValue(Convert.ToInt32(txt_Id_Paciente.Text))
            frmCrystal.crtVwGeral.ReportSource = cryRpt
            frmCrystal.crtVwGeral.Refresh()
            Exit Sub

            'instancia o relaorio e carrega
            frmCrystal.Show()

            Dim CR As New ReportDocument

            CR.Load(cboTermos.SelectedValue)
            Dim crParameterDiscreteValue As ParameterDiscreteValue
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldLocation As ParameterFieldDefinition
            Dim crParameterValues As ParameterValues

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
            crParameterFieldLocation = crParameterFieldDefinitions.Item("IdAnimal")
            crParameterValues = crParameterFieldLocation.CurrentValues
            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterDiscreteValue.Value = txt_Id_Paciente.Text
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

            frmCrystal.crtVwGeral.ReportSource = CR
            frmCrystal.crtVwGeral.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            'ReportInterface.Show()

        End Try
    End Sub

    Private Sub btnFrmFinanceiro_Click(sender As Object, e As EventArgs) Handles btnFrmFinanceiro.Click
        If Txt_ID.TextLength <> 0 Or Txt_ID.TextLength > 0 Then
            'Dim frm As New frmLancaFinan(Txt_ID.Text, txt_Id_Paciente.Text, 0)
            'frm.codigo_do_Cliente = Txt_ID.Text
            'frm.Bx_Nome_do_Cliente = Txt_Nome_Cli.Text
            'frm.codigo_do_Paciente = txt_Id_Paciente.Text
            'frm.Bx_Nome_do_Paciente = Txt_Nome_Ani.Text

            'frm.ShowDialog()
        Else
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btoFrmConsulta_Click(sender As Object, e As EventArgs) Handles btoFrmConsulta.Click
        'Dim frm As New frmConsulta

        'frm.ShowDialog()
    End Sub

    Private Sub txt_DtNas_TextChanged(sender As Object, e As EventArgs) Handles txt_DtNas.TextChanged

    End Sub

    Private Sub Txt_CPF_CNPJ_TextChanged(sender As Object, e As EventArgs) Handles Txt_CPF_CNPJ.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Caminho As String
        Dim CR As New ReportDocument

        Dim crParameterDiscreteValue As New ParameterDiscreteValue
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

    Private Sub Txt_CEP_TextChanged(sender As Object, e As EventArgs) Handles Txt_CEP.TextChanged

    End Sub
End Class