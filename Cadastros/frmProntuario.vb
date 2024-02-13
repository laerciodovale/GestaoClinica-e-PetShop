Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports AForge.Video.DirectShow
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DataBase
Imports DataBase.Utils
Imports Financeiro

Public Class frmProntuario
    Private clsPront As New Cls_Prontuario
    Private objCliente As New Cls_Cliente
    Private clsUtil As New Utils
    Private VideoSource As VideoCaptureDevice
    Private VideoSourcePaciente As VideoCaptureDevice
    Private T_O As String
    Public Property Id_Enviado_Cli As Integer
    Public Property Id_Enviado_Pac As Integer
    Private blnValida As Boolean = True
    Private chave_no_2 As String
    Private chave_no_3 As String
    Public Property Usr As String
    Public Property UsrAut As Integer
    Public Property UsrFunc As Integer

    Public Veterinario As Integer

    Private p As New Process
    Private Mensagem As String ''= txtMensagem.Text
    Private Numero As String ''= txtTelefone.Text
    '   Private Url As String
    '   Private naveg As New ChromeDriver
    Private MsgZap As String

    ''auto completar
    Private lst As New List(Of String)
    'AutoComplete collection that will help to filter keep the records.
    Private lista_Completar As New AutoCompleteStringCollection()

#Region "Cadastro"
    Private Sub frmProntuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Usr
        md_Cpf = 0

        'If UsrAut <= 5 Then
        '   TbProntuario.Enabled = True
        'Else
        '    TbProntuario.Enabled = False
        'End If

        '''PARA ALTERAR AS PROPRIEDADES DO TABCONTRLL
        TbProntuario.DrawMode = TabDrawMode.OwnerDrawFixed
        ''''
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

        LimparForm(Me)

        frmVacina_Shown() 'plano de vacina

        Me.Location = New Point(35, 75)
        'Me.Size = New Size(1330, 680)

    End Sub

    Private Sub LimparForm(ByVal controlP As Control)
        Try

            ''chkFJ.Checked = False
            lbIdPet.Text = ""
            lbPet.Text = ""
            Txt_ID.Text = ""
            Txt_Nome_Cli.Text = ""
            Txt_Contato.Text = ""

            Txt_CEP.Text = "00000-000"
            Cbo_Endereco.Text = ""
            txt_Nro.Text = ""
            txt_Compl.Text = ""
            cbo_Bairro.Text = ""
            txt_Cidade.Text = ""
            cbo_UF.Text = ""

            txt_Fone1.Text = ""
            txt_Fone2.Text = ""

            txt_DtNas.Text = ""
            txt_RG.Text = ""
            Txt_CPF_CNPJ.Text = ""

            ' .Cl_DtCad = FormatDateTime(Now, DateFormat.ShortDate)
            txt_Email.Text = ""

            pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\user_accounts.png")

            If chkFJ.Checked = False Then
                Txt_CPF_CNPJ.ValidaCPF = True
                Txt_CPF_CNPJ.ValidaCNPJ = False
            Else
                Txt_CPF_CNPJ.ValidaCPF = False
                Txt_CPF_CNPJ.ValidaCNPJ = True
            End If

            Txt_CPF_CNPJ.Enabled = True

            TreeView1.Nodes.Clear()

            Dim Parametro As List(Of SqlParameter)
            Dim banco As New DataAcces
            Parametro = New List(Of SqlParameter)

            Dim dt As New DataTable
            dt = banco.ExecutaDataTable("Sp_Cliente_Bairro", Parametro)
            cbo_Bairro.DisplayMember = "ClBairro"
            cbo_Bairro.ValueMember = "ClBairro"
            cbo_Bairro.DataSource = dt

            LimpaDadosPet()

            'Le termos dos pacientes

            banco = New DataAcces
            Parametro = New List(Of SqlParameter)
            dt = New DataTable

            dt = banco.ExecutaDataTable("Sp_Cliente_Termos", Parametro)
            cboTermos.DisplayMember = Trim("TrDesc")
            cboTermos.ValueMember = "TrCaminho"
            cboTermos.DataSource = dt

            ''''''''''''''''''''''''''''''''''''''
            '''
            Dim Cliente As New Cls_Cliente
            dt = Cliente.Preenche_Combo("Sp_Tipo_Pesquisa")
            cboTiposPesquisa.DisplayMember = "DescTpPS"
            cboTiposPesquisa.ValueMember = "idTPPS"
            cboTiposPesquisa.DataSource = dt

            Cliente.Cl_Nome = " "
            Cliente.Tipo_Operacao = 3
            cboTiposPesquisa.SelectedValue = 3

            DgGridTop.Show()

            Cliente.Cl_Nome = " "
            Cliente.Tipo_Operacao = 3

            ''Faz a pesquisa
            dt = Cliente.BuscaNome(Cliente.Tipo_Operacao, Cliente.Cl_Nome)
            ''vincula a tabela
            DgGridTop.DataSource = dt

            MontaDgGridTop()

            cboTiposPesquisa.Text = "Nome Paciente"
            cboTiposPesquisa.SelectedValue = 3

            PREENCHE_COMBOS_ANIMAL(1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LimpaDadosPet() '''   ANIMAL

        txt_Id_Paciente.Text = 0
        lbIdPet.Text = ""
        Txt_Nome_Ani.Text = ""
        lbPet.Text = ""

        rb_Canino.Checked = True
        rb_Felino.Checked = False
        CboRaca.Text = ""
        CboPorte.Text = ""
        CboCor.Text = ""
        CboPelo.Text = ""
        rbFemea.Checked = False
        rbMacho.Checked = False

        Txt_Pedigree.Text = ""
        Txt_Chip.Text = ""
        Txt_Obs.Text = ""
        Txt_DtNasAni.Text = ""
        cboConvenio.Text = ""

        pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\SelfPetG.jpg")

        ckCastrado.Checked = False
    End Sub
    Private Sub PREENCHE_COMBOS_ANIMAL(ByVal espec As Integer)
        Dim Cliente As New Cls_Cliente
        Dim dt As New DataTable

        dt = Cliente.Preenche_Combo_Animal("Sp_Animal_Raca", espec)
        CboRaca.DisplayMember = "AniRaca"
        CboRaca.ValueMember = "AniRaca"
        CboRaca.DataSource = dt

        dt = Cliente.Preenche_Combo_Animal("Sp_Animal_Cor", espec)
        CboCor.DisplayMember = "AniCor"
        CboCor.ValueMember = "AniCor"
        CboCor.DataSource = dt

        dt = Cliente.Preenche_Combo_Animal("Sp_Animal_Porte", espec)
        CboPorte.DisplayMember = "AniPorte"
        CboPorte.ValueMember = "AniPorte"
        CboPorte.DataSource = dt

        dt = Cliente.Preenche_Combo_Animal("Sp_Animal_Pelo", espec)
        CboPelo.DisplayMember = "AniPelo"
        CboPelo.ValueMember = "AniPelo"
        CboPelo.DataSource = dt

    End Sub
    Private Sub Le_CPF()

        objCliente.Cl_Cpf = Txt_CPF_CNPJ.Text 'Convert.ToInt32(Txt_CPF_CNPJ.Text)

        If objCliente.BuscaCPF(objCliente.Cl_Cpf) = True Then
            My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\ping.wav")
            moveCliente()
            Preenche_TreeListView()
            Txt_Nome_Ani.Focus()
        End If
    End Sub
    Private Sub moveCliente()
        With objCliente
            Txt_ID.Text = .Cl_Id
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

            txt_DtNas.Text = .Cl_DtNas
            lbIdadeTutor.Text = Idade(txt_DtNas.Text)
            txt_RG.Text = .Cl_RG

            Txt_CPF_CNPJ.Text = .Cl_Cpf
            txt_Email.Text = .Cl_Email
            ''pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\user_accounts.png")
            pic_Cliente.Image = AbrirArquivoBase64(.Cl_Foto) 'TRANSFERE 

        End With
    End Sub
    Private Sub Le_Cliente()
        If Txt_ID.TextLength <= 0 Or Txt_ID.TextLength = 0 Then
            Exit Sub
        Else
            ' Dim objCliente As New Cls_Cliente
            objCliente.Cl_Id = Convert.ToInt32(Txt_ID.Text)

            If objCliente.BuscaCliente("Sp_Cliente_Sel", objCliente.Cl_Id) = False Then
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\ping.wav")

                moveCliente()
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
                    lbIdPet.Text = .Id_Animal
                    Txt_Nome_Ani.Text = UCase(.Ani_Nome)
                    lbPet.Text = Txt_Nome_Ani.Text

                    If .Ani_Especie = 1 Then
                        rb_Canino.Checked = True
                    ElseIf .Ani_Especie = 2 Then
                        rb_Felino.Checked = True
                    ElseIf .Ani_Especie = 3 Then
                        rb_Outros.Checked = True
                    End If

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

                    Txt_Pedigree.Text = .Ani_Pedigree
                    Txt_Chip.Text = .Ani_Chip
                    Txt_Obs.Text = .Ani_Obs
                    Txt_DtNasAni.Text = .Ani_DtNas
                    lbIdade.Text = Idade(Txt_DtNasAni.Text)
                    cboConvenio.Text = .Ani_Conv

                    'If IsDBNull(.Ani_Foto) = True Then
                    'pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\SelfPetG.jpg")
                    'Else
                    '    If Len(Trim(.Ani_Foto)) > 0 Then
                    pic_Paciente.Image = AbrirArquivoBase64(.Ani_Foto) 'TRANSFERE 
                    '    Else
                    '        pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                    '    End If
                    'End If
                End With

                BuscaVacinas()
                'BuscaImagens()

            Else
                MessageBox.Show("ID nao cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            TrataErro("Problema ao tentar localizar o Paciente.", ex)
        End Try
    End Sub

    Private Sub ValidaCliente()

        Dim objCliente As Cls_Cliente
        blnValida = True
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

            'If pic_Cliente.Image IsNot Nothing Then
            '    pic_Cliente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\user_accounts.png")
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
        blnValida = True
        Dim objCliente As Cls_Cliente

        'VALIDACAO DOS CAMPOS OBRIGATORIOS
        If Txt_Nome_Ani.TextLength = 0 Then
            epValida.SetError(Txt_Nome_Cli, "Informar o campo nome.")
            blnValida = False
        End If

        If blnValida = False Then Exit Sub

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
            'If pic_Paciente.Image IsNot Nothing Then
            '    pic_Paciente.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\SelfPetG.jpg")
            'End If

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
            Dim fivlr As Decimal
            Dim fivlrpgto As Decimal
            Dim fidtpgto As String
            Dim faev As String
            Dim fadesc As String
            Dim favlru As Decimal
            Dim faqtd As Double
            Dim favlr As Decimal
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

                ' Dim chave_no_2 As String
                'Dim chave_no_3 As String
                chave_no_2 = dtvcto & " - " & finssnro & " - " & Format(fivlr, "0,00") & " - " & Format(fivlrpgto, "0,00") & " - " & fidtpgto
                'chave_no_3 = fadesc & " - " & favlru & " - " & faqtd & " - " & favlr

                '  Dim chave_no_2 As String = String.Format("{0,8}, {1,6}, {2, 8}, {3, 8}, {4, 8}", dtvcto, finssnro, fivlr, fivlrpgto, fidtpgto)
                'Private chave_no_3 As String
                chave_no_3 = String.Format("{0, 40}, {1, 12}, {2, 12}, {3, 12}", LTrim(fadesc), Format(favlru, "0,00"), Format(faqtd, "0.000"), Format(favlr, "0,00"))

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
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)
        If IsNumeric(Trim(Mid(TreeView1.SelectedNode.Text, 1, 6))) = True Then
            Me.Cursor = System.Windows.Forms.Cursors.AppStarting
            txt_Id_Paciente.Text = Mid(TreeView1.SelectedNode.Text, 1, 6)
            Le_Paciente()
            'BuscaConsulta()
            'BuscaReceitas()
            'BuscaVacinas()
            'BuscaImagens()
            Txt_Nome_Ani.Focus()

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub EnviaWatts()

        'Dim nome As String = Txt_Nome_Cli.Text
        'Dim nomePac As String = Txt_Nome_Ani.Text
        'Dim posicao As Integer
        'posicao = nome.IndexOf(" ")
        'nome = nome.Substring(0, posicao)

        'Try
        '    ' Dim Url As String = "https://web.whatsapp.com/send?phone=" + "55" + txtNro.Text +
        '    ' "&text=" + Uri.EscapeDataString(txtMensagem.Text) + "&source=&data="
        '    Dim WFone As String
        '    WFone = Replace(txt_Fone1.Text, "(", "")
        '    WFone = Replace(txt_Fone1.Text, ")", "")
        '    WFone = Replace(txt_Fone1.Text, "-", "")
        '    WFone = Replace(txt_Fone1.Text, " ", "")

        '    Dim testo As String
        '    testo = nome & " seu cadastro foi realizado com sucesso, obrigado pela confiança. Cuidaremos "
        '    If rbFemea.Checked = True Then
        '        testo = testo & "da "
        '    Else
        '        testo = testo & "do "
        '    End If

        '    testo = testo & Trim(Txt_Nome_Ani.Text) & " com muito carinho. "

        '    Url = "https://web.whatsapp.com/send?phone=" + "55" + WFone +
        '     "&text=" + Uri.EscapeDataString(testo) + "&source=&data="

        '    ' Dim naveg As New ChromeDriver

        '    naveg.Navigate.GoToUrl(Url)
        '    Threading.Thread.Sleep(6000)
        '    Dim env = naveg.FindElement(By.XPath("//span[@data-icon='send']"))
        '    env.Click()

        '    ''@@@@
        '    testo = "Ficaremos felizes se você nos avaliar neste endereço :"
        '    Url = "https://web.whatsapp.com/send?phone=" + "55" + WFone +
        '     "&text=" + Uri.EscapeDataString(testo) + "&source=&data="
        '    naveg.Navigate.GoToUrl(Url)
        '    'Threading.Thread.Sleep(1000)
        '    env = naveg.FindElement(By.XPath("//span[@data-icon='send']"))
        '    env.Click()
        '    ''@@@@
        '    testo = "https://g.page/r/CXeM0gTEx0znEAI/review"
        '    Url = "https://web.whatsapp.com/send?phone=" + "55" + WFone +
        '     "&text=" + Uri.EscapeDataString(testo) + "&source=&data="
        '    naveg.Navigate.GoToUrl(Url)
        '    'Threading.Thread.Sleep(1000)
        '    env = naveg.FindElement(By.XPath("//span[@data-icon='send']"))
        '    env.Click()
        '    MessageBox.Show("Mensagem enviada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Catch ex As Exception

        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        blnValida = True

        Try
            'grava o registro
            T_O = "I"
            ValidaCliente()
            T_O = ""
            'EnviaWatts()
            If blnValida = False Then
                MessageBox.Show("Problema ao tentar INCLUIR os dados do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Txt_Nome_Ani.Focus()
            End If
        Catch ex As Exception
            TrataErro("Problema ao tentar gravar os dados do cliente.", ex)
        End Try

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Try
            ''grava o registro
            T_O = "U"
            ValidaCliente()

            T_O = ""
            If blnValida = False Then
                MessageBox.Show("Problema ao tentar ALTERAR os dados do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
            TrataErro("Problema ao tentar gravar os dados do cliente.", ex)
        End Try

    End Sub

    Private Sub pic_Cliente_Click(sender As Object, e As EventArgs) Handles pic_Cliente.Click
        If VideoSource.IsRunning Then
            VideoSource.Stop()
            pic_Cliente.Image = Nothing
        Else
            VideoSource.Start()
        End If
    End Sub

    Private Sub btoImprimir_Click(sender As Object, e As EventArgs) Handles btoImprimir.Click


        If txt_Id_Paciente.TextLength = 0 Then
            MessageBox.Show("Sem ID para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try

            ''''novo imprimir direto
            ''''
            'Using Relatorio = New ReportDocument()

            '    Relatorio.Load(cboTermos.SelectedValue)
            '    Relatorio.ParameterFields("IdAnimal").CurrentValues.AddValue(Convert.ToInt32(txt_Id_Paciente.Text))

            'End Using

            'Using Relatorio = New cryReceita()

            '    Using Dialogo = New PrintDialog()
            '        If Dialogo.ShowDialog() = DialogResult.OK Then
            '            Relatorio.PrintToPrinter(Dialogo.PrinterSettings, Dialogo.PrinterSettings.DefaultPageSettings, False)
            '        End If
            '    End Using
            'End Using


            'Exit Sub
            ''''fim novo

            Me.Cursor = System.Windows.Forms.Cursors.Default

            Dim cryRpt As New ReportDocument
            cryRpt.Load(cboTermos.SelectedValue)
            cryRpt.SetDatabaseLogon("sa", "nunsey", "SrvMyPets", "CadVet")
            cryRpt.ParameterFields("IdAnimal").CurrentValues.AddValue(Convert.ToInt32(txt_Id_Paciente.Text))

            frmCrystal.txt_Param_1.Text = TextBox1.Text
            frmCrystal.Crt_P1 = TextBox1.Text
            frmCrystal.crtVwGeral.ReportSource = cryRpt

            frmCrystal.crtVwGeral.Refresh()
            frmCrystal.Show()

            'instancia o relaTorio e carrega
            'frmCrystal.Show()

            'Dim CR As New ReportDocument

            'CR.Load(cboTermos.SelectedValue)
            'Dim crParameterDiscreteValue As ParameterDiscreteValue
            'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            'Dim crParameterFieldLocation As ParameterFieldDefinition
            'Dim crParameterValues As ParameterValues

            'crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
            'crParameterFieldLocation = crParameterFieldDefinitions.Item("IdAnimal")
            'crParameterValues = crParameterFieldLocation.CurrentValues
            'crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            'crParameterDiscreteValue.Value = txt_Id_Paciente.Text
            'crParameterValues.Add(crParameterDiscreteValue)
            'crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

            'frmCrystal.crtVwGeral.ReportSource = CR
            'frmCrystal.crtVwGeral.Refresh()

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message)
            'Me.Close()

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


#End Region

#Region "Vacina"
    Private Sub frmVacina_Shown()

        mskPuppy.Text = Now
        mskDose1.Text = Now
        mskDose2.Text = Now
        mskDose3.Text = Now

        ''Preenche A ListBox
        Dim dt As DataTable = clsPront.LeGrpVacina()
        cboVacinas.DisplayMember = "itdesc"
        cboVacinas.ValueMember = "ititem"
        cboVacinas.DataSource = dt

        PlanoDeVacina()

    End Sub

    Private Sub LimpaVacina()
        mskPuppy.Text = Now
        mskDose1.Text = Now
        mskDose2.Text = Now
        mskDose3.Text = Now

        ''Preenche A ListBox
        Dim dt As DataTable = clsPront.LeGrpVacina()
        cboVacinas.DisplayMember = "itdesc"
        cboVacinas.ValueMember = "ititem"
        cboVacinas.DataSource = dt

        PlanoDeVacina()
    End Sub
    Private Sub PlanoDeVacina()
        Try

            If ckPuppy.Checked = True Then
                mskPuppy.Text = Now
                ckV1Dose.Checked = True
                mskDose1.Text = DateAdd("d", 21, mskPuppy.Text)
                ckV2Dose.Checked = True
                mskDose2.Text = DateAdd("d", 21, mskDose1.Text)
                ckV3Dose.Checked = True
                mskDose3.Text = DateAdd("d", 42, mskDose1.Text)

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)

                mskGiar1.Text = mskDose2.Text
                mskGiar2.Text = mskDose3.Text

                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)
                ckTosse.Checked = True
                mskTosse.Text = DateAdd("d", 21, mskDose1.Text)

            ElseIf ckV1Dose.Checked = True Then
                ckPuppy.Checked = False
                mskPuppy.Text = ""

                mskDose1.Text = Now

                ckV2Dose.Checked = True
                mskDose2.Text = DateAdd("d", 21, mskDose1.Text)
                ckV3Dose.Checked = True
                mskDose3.Text = DateAdd("d", 42, mskDose1.Text)

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)

                mskGiar1.Text = mskDose2.Text
                mskGiar2.Text = mskDose3.Text

                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)
                ckTosse.Checked = True
                mskTosse.Text = DateAdd("d", 21, mskDose1.Text)

            ElseIf ckV2Dose.Checked = True Then
                ckPuppy.Checked = False
                mskPuppy.Text = ""
                ckV1Dose.Checked = False
                mskDose1.Text = ""

                mskDose2.Text = Now

                ckV3Dose.Checked = True
                mskDose3.Text = DateAdd("d", 21, mskDose2.Text)

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)

                mskGiar1.Text = mskDose2.Text
                mskGiar2.Text = mskDose3.Text

                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)

            ElseIf ckV3Dose.Checked = True Then
                ckPuppy.Checked = False
                mskPuppy.Text = ""
                ckV1Dose.Checked = False
                mskDose1.Text = ""
                ckV2Dose.Checked = False
                mskDose2.Text = ""

                mskDose3.Text = Now

                mskRefor1.Text = DateAdd("m", 6, mskDose3.Text)
                mskRefor2.Text = DateAdd("yyyy", 1, mskRefor1.Text)
                mskGiar2.Text = mskDose3.Text
                mskAntR.Text = DateAdd("d", 15, mskDose3.Text)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BuscaVacinas()

        If Id_Enviado_Pac = 0 Then
            MessageBox.Show("Paciente não informado." & vbCr & "Tela encerrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            ' Me.Close()
        End If

        clsPront.Vc_Ani = Id_Enviado_Pac
        Dim dt As DataTable = clsPront.LeVacina("Sp_FinA_Vacina", clsPront.Vc_Ani)
        dgVacinasEfetuadas.DataSource = dt

        If dt.Rows.Count.ToString = 0 Then
            ' MessageBox.Show("Vacina sem movimento no financeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        dgVacinasEfetuadas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasEfetuadas.Columns(0).HeaderText = "Data Efetiva"
        dgVacinasEfetuadas.Columns(0).Width = 8
        dgVacinasEfetuadas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasEfetuadas.Columns(1).HeaderText = "Descrição da Vacina"
        dgVacinasEfetuadas.Columns(1).Width = 70

        '''' vacinas cadastradas para o paciente
        Dim dtV As DataTable = clsPront.LeVacina("Sp_Vacinas_Sel", clsPront.Vc_Ani)
        dgVacinasCadastradas.DataSource = dtV

        If dtV.Rows.Count.ToString = 0 Then
            '  MessageBox.Show("Paciente sem plano de vacina", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dgVacinasCadastradas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasCadastradas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

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

        Exit Sub


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

                Dim Cliente As New Cls_Cliente
                Cliente.Cl_Id = Convert.ToInt32(Txt_ID.Text)
                Cliente.Cl_Foto = Utils.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                Cliente.Cl_Id = Txt_ID.Text

                Cliente.UpFotoCliente()
                MessageBox.Show("Imagem salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                AddHandler VideoSource.NewFrame, AddressOf VideoSource_NewFrame
            End Try
        End If
    End Sub

    Private Sub bto_Img_Pac_Click(sender As Object, e As EventArgs) Handles bto_Img_Pac.Click
        Try
            'carrega uma imagem da pasta
            Using abrir As New OpenFileDialog With {
                .Title = "Carregar uma imagem.",
                .FileName = "",
                .Filter = "Imagens PNG, JPG, JPEG e BMP|*.png; *.jpg;*.jpeg;*.bmp"}
                If abrir.ShowDialog = DialogResult.OK Then
                    pic_Paciente.Image = Image.FromFile(abrir.FileName)

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Exit Sub

        If Trim(txt_Id_Paciente.Text) = "" Then
            MessageBox.Show("ID do Paciente nao informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If
        If pic_Paciente.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                VideoSourcePaciente.Stop()
                RemoveHandler VideoSourcePaciente.NewFrame, AddressOf VideoSourcePaciente_NewFrame
                'salva a imagem nA PASTA
                pic_Paciente.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                Dim Cliente As New Cls_Cliente
                Cliente.Id_Animal = Convert.ToInt32(Txt_ID.Text)
                Cliente.Ani_Foto = Utils.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                Cliente.Id_Animal = txt_Id_Paciente.Text

                Cliente.UpFotoPACIENTE()
                MessageBox.Show("Imagem salva com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Finally
                AddHandler VideoSourcePaciente.NewFrame, AddressOf VideoSourcePaciente_NewFrame
            End Try
        End If
    End Sub

    Private Sub frmProntuario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Windows.Forms.Keys.F2 Then ''' F2 abre o Financeiro para lançamento

                If Len(Trim(Txt_ID.Text)) = 0 Then
                    MessageBox.Show("Cliente não informado." & vbCr & "Financeiro não Ativado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If Len(Trim(txt_Id_Paciente.Text)) = 0 Then
                    MessageBox.Show("Paciente não informado." & vbCr & "Financeiro não Ativado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Dim frm As New frmLancaFinan(Txt_ID.Text, txt_Id_Paciente.Text, 0, Usr, UsrAut)
                frm.codigo_do_Cliente = Txt_ID.Text
                frm.Bx_Nome_do_Cliente = Txt_Nome_Cli.Text
                frm.codigo_do_Paciente = txt_Id_Paciente.Text
                frm.Bx_Nome_do_Paciente = Txt_Nome_Ani.Text

                '' frm.Usr_Aut = 

                frm.ShowDialog()

            End If

            If e.KeyCode = Windows.Forms.Keys.F4 Then '''  F4 abre o Caixa 0

                Dim frm As New frmCaixa(Usr, Txt_ID.Text, 0, UsrAut)
                frm.ShowDialog()

            End If

            If e.KeyCode = Windows.Forms.Keys.F5 Then ''' F5 novo cliente
                LimparForm(Me)
                ''   Txt_CPF_CNPJ.Enabled = True
                Txt_CPF_CNPJ.Focus()

            End If

            If e.KeyCode = Windows.Forms.Keys.F6 Then '''  F6 Extrato do financeiro do Tutor

                Dim frm As New frmExtratoFinCli()
                frm.lbId.Text = Txt_ID.Text
                frm.ShowDialog()

            End If
            If e.KeyCode = Windows.Forms.Keys.F7 Then '''  F7 ABRE A AGENDA DO BANHO E TOSA DE PET

                Dim frm As New frmAgBanho()
                frm.txtIdPet.Text = txt_Id_Paciente.Text
                frm.txtIdCli.Text = Txt_ID.Text

                frm.ShowDialog()

            End If

        Catch ex As Exception
            MessageBox.Show("Problema ao transferir valor do Id do Paciente. " & vbCr & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Private Sub btoEnviar_Click(sender As Object, e As EventArgs)
        EnviaWatts()

    End Sub


#End Region
#Region "bUSCA cLIENTE"
    Private Sub Busca()
        Dim banco As New Cls_Cliente
        Dim dt As DataTable
        'Dim Tipo As String
        'Dim N_lk As String

        DgGridTop.Show()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.AppStarting
            If cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 4 Or cboTiposPesquisa.SelectedValue = 5 Then
                banco.Cl_Nome = txt_Busca.Text
                banco.Tipo_Operacao = cboTiposPesquisa.SelectedValue

            Else

                If txt_Busca.TextLength = 0 Then
                    banco.Cl_Nome = " "
                    banco.Tipo_Operacao = "1" 'Top 50 PACIENTES
                Else
                    banco.Cl_Nome = txt_Busca.Text
                    banco.Tipo_Operacao = cboTiposPesquisa.SelectedValue

                End If

            End If

            ''Faz a pesquisa
            dt = banco.BuscaNome(banco.Tipo_Operacao, banco.Cl_Nome)
            'vincula a tabela
            DgGridTop.DataSource = dt

        Catch ex As Exception

            TrataErro("Problema ao tentar efetuar a leitura", ex)
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Default
        If banco.Tipo_Operacao = "1" Then
            MontaDgGridTop()
        End If
        If cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 4 Or cboTiposPesquisa.SelectedValue = 5 Then
            MontaDgGrid()

        End If

    End Sub
    Private Sub cboTiposPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposPesquisa.SelectedIndexChanged
        DgGridTop.DataSource = Nothing
        DgGridTop.Columns.Clear()

        txt_Busca.Text = ""
        If cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 4 Or cboTiposPesquisa.SelectedValue = 5 Then
            Busca()
        Else
            txt_Busca.Focus()
        End If

    End Sub
    Private Sub txt_Busca_TextChanged(sender As Object, e As EventArgs) Handles txt_Busca.TextChanged
        Busca()
    End Sub
    Private Sub MontaDgGridTop()
        Try

            If cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 4 Or cboTiposPesquisa.SelectedValue = 5 Then
                MontaDgGrid()
            Else
                DgGridTop.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DgGridTop.Columns(0).HeaderText = " Nome        "
                DgGridTop.Columns(0).Width = 15

                DgGridTop.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                DgGridTop.Columns(1).HeaderText = " Codigo "
                DgGridTop.Columns(1).Width = 10

            End If

        Catch ex As Exception
            TrataErro("Problema ao efetuar a pesquisa", ex)
        End Try
    End Sub
    Private Sub MontaDgGrid()
        Try
            DgGridTop.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgGridTop.Columns(0).HeaderText = " Nome do Pet  "
            DgGridTop.Columns(0).Width = 50
            DgGridTop.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgGridTop.Columns(1).HeaderText = " id "
            DgGridTop.Columns(1).Width = 30
            DgGridTop.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgGridTop.Columns(2).HeaderText = " id Cli"
            DgGridTop.Columns(2).Width = 30
            DgGridTop.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DgGridTop.Columns(3).HeaderText = " Nome do Tutor "
            DgGridTop.Columns(3).Width = 100
        Catch ex As Exception
            TrataErro("Problema ao efetuar a pesquisa", ex)
        End Try
    End Sub

    Private Sub txt_Busca_GotFocus(sender As Object, e As EventArgs)
        Try
            txt_Busca.Text = ""

        Catch ex As Exception
            TrataErro("Problema ao tentar efetuar a pesquisa.", ex)
        End Try

    End Sub

    Private Sub DgGridTop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim frm As New FrmClientes
        Dim U As New Utils
        If cboTiposPesquisa.SelectedValue = 1 Or cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 5 Then
            U.Id_Paciente = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            U.Id_Cliente = Me.DgGridTop.CurrentRow.Cells(2).Value.ToString()
        Else
            U.Id_Cliente = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            U.Id_Paciente = 0
        End If

        frm.Show()

    End Sub

    Private Sub DgGridTop_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DgGridTop.CellContentClick
        'TbProntuario.SelectedIndex = 0
        'LimparForm(Me)
        LimpaDadosPet()

        If cboTiposPesquisa.SelectedValue = 1 Or cboTiposPesquisa.SelectedValue = 3 Or cboTiposPesquisa.SelectedValue = 5 Or cboTiposPesquisa.SelectedValue = Nothing Then
            Id_Enviado_Cli = Me.DgGridTop.CurrentRow.Cells(2).Value.ToString()
            Txt_ID.Text = Id_Enviado_Cli
            'Txt_ID.Enabled = False
            Le_Cliente()

            Id_Enviado_Pac = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            txt_Id_Paciente.Text = Id_Enviado_Pac
            'txt_Id_Paciente.Enabled = False

            Le_Paciente()

            'BuscaVacinas()

        Else
            Id_Enviado_Cli = Me.DgGridTop.CurrentRow.Cells(1).Value.ToString()
            Txt_ID.Text = Id_Enviado_Cli
            Txt_ID.Enabled = False
            Le_Cliente()
            ''    Txt_CPF_CNPJ.Enabled = False
            Id_Enviado_Pac = 0
        End If

        ''btnImpirmirReceita.Enabled = False

        ''BuscaPetsTutor()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@ID", Id_Enviado_Cli))
        Dim dt As New DataTable
        dt = banco.ExecutaDataTable("Sp_Animal_Pets_Tutor", Parametro)
        cboNomePet.DisplayMember = "AniNome"
        cboNomePet.ValueMember = "AniNome"
        cboNomePet.DataSource = dt

        For item = 0 To cboNomePet.Items.Count - 1
            ''lst.Add(dt)
            cboNomePet.SelectedIndex = item
            lst.Add(cboNomePet.SelectedValue)
        Next
        lista_Completar.AddRange(lst.ToArray)
        Txt_Nome_Ani.AutoCompleteCustomSource = lista_Completar
        Txt_Nome_Ani.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Txt_Nome_Ani.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub
#End Region
#Region "OUTROS"

    Private Sub TreeView1_AfterSelect_1(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        If IsNumeric(Trim(Mid(TreeView1.SelectedNode.Text, 1, 6))) = True Then

            Id_Enviado_Pac = Mid(TreeView1.SelectedNode.Text, 1, 6)
            txt_Id_Paciente.Text = Id_Enviado_Pac
            txt_Id_Paciente.Enabled = False
            Le_Paciente()

        End If

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try

            If IsNumeric(Trim(Mid(TreeView1.SelectedNode.Text, 14, 5))) = True Then
                Dim frm As New frmLancaFinan(Txt_ID.Text, txt_Id_Paciente.Text, Mid(TreeView1.SelectedNode.Text, 14, 5), Usr, UsrAut)
                frm.codigo_do_Cliente = Txt_ID.Text
                frm.Bx_Nome_do_Cliente = Txt_Nome_Cli.Text
                frm.codigo_do_Paciente = txt_Id_Paciente.Text
                frm.Bx_Nome_do_Paciente = Txt_Nome_Ani.Text
                frm.ShowDialog()
            Else
                MessageBox.Show("Solicitação inválida." & vbCr & Mid(TreeView1.SelectedNode.Text, 14, 5) & "Financeiro não Ativado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chkFJ_CheckedChanged(sender As Object, e As EventArgs) Handles chkFJ.CheckedChanged
        LimparForm(Me)
        If chkFJ.Checked = True Then
            Txt_CPF_CNPJ.ValidaCNPJ = True
            Txt_CPF_CNPJ.ValidaCPF = False
        End If
        If chkFJ.Checked = True Then
            Txt_CPF_CNPJ.ValidaCNPJ = False
            Txt_CPF_CNPJ.ValidaCPF = True
        End If
    End Sub

    Private Sub rb_Canino_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Canino.CheckedChanged
        PREENCHE_COMBOS_ANIMAL(1)
    End Sub

    Private Sub rb_Felino_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Felino.CheckedChanged
        PREENCHE_COMBOS_ANIMAL(2)
    End Sub

    Private Sub rb_Outros_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Outros.CheckedChanged
        PREENCHE_COMBOS_ANIMAL(3)
    End Sub


    Private Sub TbProntuario_Click(sender As Object, e As EventArgs) Handles TbProntuario.Click
        'If TbProntuario.SelectedIndex = 2 Then
        '    'LimpaReceita()
        'End If
    End Sub

    Private Sub Txt_DtNasAni_LostFocus(sender As Object, e As EventArgs) Handles Txt_DtNasAni.LostFocus
        If IsDate(Txt_DtNasAni.Text) = True Then
            lbIdade.Text = Idade(Txt_DtNasAni.Text)
        End If

        If Len(Txt_DtNasAni.Text) = 0 Then
            Txt_DtNasAni.Text = "01/01/1900"
        End If

    End Sub

    Private Sub txt_DtNas_LostFocus(sender As Object, e As EventArgs) Handles txt_DtNas.LostFocus
        Try
            If IsDate(txt_DtNas.Text) = True Then
                lbIdadeTutor.Text = Idade(txt_DtNas.Text)

            End If
            If Len(txt_DtNas.Text) = 0 Then
                txt_DtNas.Text = "01/01/1900"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Txt_CPF_CNPJ_LostFocus(sender As Object, e As EventArgs) Handles Txt_CPF_CNPJ.LostFocus
        Try
            If Len(Txt_CPF_CNPJ.Text) > 0 Then

                If Txt_CPF_CNPJ.IsValido = False Then
                    MessageBox.Show("CPF/CNPJ inválido." & vbCr & "Cadastro cancelado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Txt_CPF_CNPJ.Text = ""
                    txt_Busca.Focus()
                    Exit Sub
                End If

                Le_CPF()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TbProntuario_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TbProntuario.DrawItem

        Try

            Dim font As Font

            Dim tc As TabControl = DirectCast(sender, TabControl)

            Dim caption As String = tc.TabPages(e.Index).Text

            Dim sf As New StringFormat

            sf.Alignment = StringAlignment.Center

            sf.LineAlignment = StringAlignment.Center

            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft 'DirectionVertical


            Dim b As Brush

            If e.Index = tc.SelectedIndex Then
                b = New SolidBrush(Color.Blue)
                font = New Font("Tahoma", 8, FontStyle.Regular Or FontStyle.Italic) ' New Font(e.Font, FontStyle.Bold Or FontStyle.Italic)
            Else
                b = New SolidBrush(Color.Black)
                font = New Font("Tahoma", 8, FontStyle.Regular) 'New Font(e.Font, FontStyle.Bold Or FontStyle.Regular)
            End If
            ''e.Font
            e.Graphics.DrawString(caption, font, b, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), sf)

            e.Graphics.Dispose()

            sf.Dispose()

            b.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btoAgEstetica_Click(sender As Object, e As EventArgs) Handles btoAgEstetica.Click

        If Len(Txt_CPF_CNPJ.Text) > 0 Then

            md_Cpf = Txt_CPF_CNPJ.Text
            md_Id_Tutor = Txt_ID.Text
            md_Id_Pet = txt_Id_Paciente.Text

            md_Data = Now
            Dim frm As New frmAgenda()
            frm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Solicitação inválida." & vbCr _
                            & "Cliente não Infromado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Txt_CEP_LostFocus(sender As Object, e As EventArgs) Handles Txt_CEP.LostFocus
        'If Txt_CEP.Text = "78455-000" Then
        '    txt_Cidade.Text = "LUCAS DO RIO VERDE"
        '    cbo_UF.Text = "MT"
        'End If


        If Txt_CEP.TextLength > 0 Then
            Try
                Me.Cursor = Cursors.AppStarting '.WaitCursor
                Dim cep As Cls_BuscaCEP = DataBase.Utils.PesquisaCEP(Txt_CEP.Text.Replace("-", ""))

                cbo_Bairro.Text = UCase(cep.bairro)
                Cbo_Endereco.Text = UCase(cep.logradouro)
                txt_Cidade.Text = UCase(cep.localidade)
                cbo_UF.Text = UCase(cep.uf)

                txt_Nro.Select()
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                TrataErro("Problema ao tentar consultar cep, verifique sua conexão com a internet.", ex)
            End Try
        End If

    End Sub

    Private Sub btoEnviar_Click_1(sender As Object, e As EventArgs) Handles btoEnviar.Click
        Dim NroWhats As String = txt_Fone1.Text
        Dim Mensagem As String

        NroWhats = Replace(NroWhats, "(", "")
        NroWhats = Replace(NroWhats, ")", "")
        NroWhats = Replace(NroWhats, ".", "")
        NroWhats = Replace(NroWhats, "-", "")
        NroWhats = Replace(NroWhats, " ", "")
        Mensagem = "Digite a sua Mensagem "

        Dim frm As New frmWats(Mensagem, NroWhats)
        frm.ShowDialog()
    End Sub


    Private Sub Detalhe_da_Venda_Zap_Click(sender As Object, e As EventArgs) Handles Detalhe_da_Venda_Zap.Click

        Numero = txt_Fone1.Text
        Numero = Replace(Numero, "(", "")
        Numero = Replace(Numero, ")", "")
        Numero = Replace(Numero, "-", "")
        Numero = Replace(Numero, " ", "")

        ''pega os itens da venda
        Dim cls_finan As New Cls_Financeiro
        cls_finan.id_Grid = Mid(TreeView1.SelectedNode.Text, 14, 5)

        cls_finan.LeDetFinanA()
        '       1234567890123456789012345678901234567890123456 = 46
        'Mensagem = "           CLÍNICA VETERINÁRIA MY PETS       " & vbCrLf _
        '        & "               CNPJ: 253079140001/20          " & vbCrLf _
        '        & "   AV DAS HORTÊNSIAS 966W BANDEIRANTES - LRV  " & vbCrLf _
        '& "                FONE: (65)9 9946-9595" & vbCrLf _
        '        & "         insta: @mypets_clinicaveterinaria    " & vbCrLf



        Mensagem = frmM.txtDadosEmpresa.Text & vbCrLf _
                & "_____________________________________________" & vbCrLf _
                & "           SIMPLES CONFERENCIA DA COMPRA " & vbCrLf _
                & "           *** NAO É DOCUMENTO FISCAL *** " & vbCrLf & vbCrLf _
                & " Cliente :  " & Txt_Nome_Cli.Text & vbCrLf _
                & " CPF : " & Txt_CPF_CNPJ.Text & vbCrLf _
                & " Data da emissão : " & DateTime.Now & vbCrLf _
                & "--------------------------------------------" & vbCrLf _
                & " Numero da OS : " & cls_finan.id_Grid & vbCrLf _
                & " Data do Evento : " & cls_finan.Det_OS_FinanA(0, 0) & vbCrLf

        Mensagem = Mensagem & "Descricao do ITEM " & vbCrLf _
                & "Qtd. X Vlr-Unit. = Vlr-Item" & vbCrLf
        Dim x As Integer
        Dim v_t As Single
        For x = 0 To cls_finan.Ind - 1

            Mensagem = Mensagem & Format((x + 1), "00") & " -  " & cls_finan.Det_OS_FinanA(2, x) & vbCrLf _
            & cls_finan.Det_OS_FinanA(3, x) & " X " & cls_finan.Det_OS_FinanA(4, x) _
            & " = " & cls_finan.Det_OS_FinanA(5, x) & vbCrLf
            v_t = cls_finan.Det_OS_FinanA(6, x)
        Next

        v_t = v_t.ToString("R$ #,###.00")
        Mensagem = Mensagem & "                  ______________" & vbCrLf _
        & "                  Total Geral = " & v_t.ToString("R$ #,###.00") & vbCrLf & vbCrLf _
        & "_____________________________________________" ''& vbCrLf  & " " 


        SendWhatsApp(Numero, Mensagem)

        'p.StartInfo.FileName = "C:\Users\laerc\AppData\Local\WhatsApp\WhatsApp.exe"
        'p.StartInfo.FileName = "C:\Program Files\WindowsApps\5319275A.WhatsAppDesktop_2.2336.7.0_x64__cv1g1gvanyjgm\WhatsApp.exe"

        'p.Start()

        'Threading.Thread.Sleep(8000)
        'SendKeys.SendWait("^n")
        'SendKeys.SendWait("{ENTER}")

        'Threading.Thread.Sleep(8000)
        'SendKeys.SendWait(Numero)
        'SendKeys.SendWait("{ENTER}")

        'Threading.Thread.Sleep(2000)
        'SendKeys.SendWait("^v")
        'SendKeys.SendWait("{ENTER}")

        'Threading.Thread.Sleep(8000)
        'SendKeys.SendWait(Mensagem)
        'SendKeys.SendWait("{ENTER}")

        'Threading.Thread.Sleep(1000)
        ''MessageBox.Show("enviada")

        'Me.Close()

    End Sub

    Private Sub SendWhatsApp(ByVal Nro As String, ByVal Msg As String)

        System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" & Numero _
        & "&text=" & Uri.EscapeDataString(Mensagem))


    End Sub

    Private Sub btnIncluirVacina_Click_1(sender As Object, e As EventArgs) Handles btnIncluirVacina.Click
        clsPront.Vc_Ani = txt_Id_Paciente.Text
        clsPront.Vc_Dt = Format(Now, "yyyy-MM-dd")
        clsPront.Vc_Contato = 0
        clsPront.Vc_Email = False
        clsPront.TipoOperacao = "I"

        If ckPuppy.Checked = True Then
            clsPront.Vc_Tp = "Puppy"
            clsPront.Vc_Dose = 1
            clsPront.Vc_Data = mskPuppy.Text
            ' clsPront.Vc_Mes = Format(mskPuppy.Text, "MM")
            clsPront.Vc_Mes = CDate(mskPuppy.Text).ToString("MM")
            clsPront.Vc_Item = "PUPPY"
            clsPront.InsertVacina()
        End If

        If ckV1Dose.Checked = True Then
            clsPront.Vc_Tp = "1 VACINA"
            clsPront.Vc_Dose = 1
            clsPront.Vc_Data = mskDose1.Text
            clsPront.Vc_Mes = CDate(mskDose1.Text).ToString("MM")

            clsPront.Vc_Item = "154"
            clsPront.InsertVacina()
        End If
        If ckV2Dose.Checked = True Then
            clsPront.Vc_Tp = "2 VACINA"
            clsPront.Vc_Dose = 1
            clsPront.Vc_Data = mskDose2.Text
            ''clsPront.Vc_Mes = Format(mskDose2.Text, "MM")
            clsPront.Vc_Mes = CDate(mskDose2.Text).ToString("MM")
            clsPront.Vc_Item = "154"
            clsPront.InsertVacina()
        End If
        If ckV3Dose.Checked = True Then
            clsPront.Vc_Tp = "3 VACINA"
            clsPront.Vc_Dose = 1
            clsPront.Vc_Data = mskDose3.Text
            ''clsPront.Vc_Mes = Format(mskDose3.Text, "MM")
            clsPront.Vc_Mes = CDate(mskDose3.Text).ToString("MM")
            clsPront.Vc_Item = "154"
            clsPront.InsertVacina()
        End If
        If ckV1Reforco.Checked = True Then
            clsPront.Vc_Tp = "1 REFORCO"
            clsPront.Vc_Dose = 4
            clsPront.Vc_Data = mskRefor1.Text
            '' clsPront.Vc_Mes = Format(mskRefor1.Text, "MM")
            clsPront.Vc_Mes = CDate(mskRefor1.Text).ToString("MM")
            clsPront.Vc_Item = "154"
            clsPront.InsertVacina()
        End If
        If ckV2Reforco.Checked = True Then
            clsPront.Vc_Tp = "2 REFORCO"
            clsPront.Vc_Dose = 5
            clsPront.Vc_Data = mskRefor2.Text
            'clsPront.Vc_Mes = Format(mskRefor2.Text, "MM")
            clsPront.Vc_Mes = CDate(mskRefor2.Text).ToString("MM")
            clsPront.Vc_Item = "154"
            clsPront.InsertVacina()
        End If
        If ckG1Dose.Checked = True Then
            clsPront.Vc_Tp = "1 GIARDIASE"
            clsPront.Vc_Dose = 1
            clsPront.Vc_Data = mskGiar1.Text
            'clsPront.Vc_Mes = Format(mskGiar1.Text, "MM")
            clsPront.Vc_Mes = CDate(mskGiar1.Text).ToString("MM")
            clsPront.Vc_Item = "GIARDIASE"
            clsPront.InsertVacina()
        End If
        If ckG2Dose.Checked = True Then
            clsPront.Vc_Tp = "2 GIARDIASE"
            clsPront.Vc_Dose = 2
            clsPront.Vc_Data = mskGiar2.Text
            'clsPront.Vc_Mes = Format(mskGiar2.Text, "MM")
            clsPront.Vc_Mes = CDate(mskGiar2.Text).ToString("MM")
            clsPront.Vc_Item = "GIARDIASE"
            clsPront.InsertVacina()
        End If

        clsPront.Vc_Tp = "ANTI-RÁBICA"
        clsPront.Vc_Dose = 1
        clsPront.Vc_Data = mskAntR.Text
        '' clsPront.Vc_Mes = Format(mskAntR.Text, "MM")
        clsPront.Vc_Mes = CDate(mskAntR.Text).ToString("MM")
        clsPront.Vc_Item = "A-R"
        clsPront.InsertVacina()

        If ckTosse.Checked = True Then
            clsPront.Vc_Tp = "TOSSE CANIS"
            clsPront.Vc_Dose = 1
            clsPront.Vc_Data = mskAntR.Text
            ''clsPront.Vc_Mes = Format(mskAntR.Text, "MM")
            clsPront.Vc_Mes = CDate(mskAntR.Text).ToString("MM")
            clsPront.Vc_Item = "vbronq"
            clsPront.InsertVacina()
        End If

        'MsgZap = "Oi " & Mid(txtNomeCli.Text, 1, Trim(testPos)) & " " & vbCrLf _
        '    & "Agendamos para seu Pet " & Trim(txtNomePet.Text) & " o serviço : " & vbCrLf _
        '    & cboServicos.Text & vbCrLf _
        '    & "para a(s) data(s) e horário(s) a seguir : " & vbCrLf

        'ClsFinan.Busca_Agenda_da_Os(txtOs.Text)
        'MsgZap = MsgZap & ClsFinan.Agenda_da_OS

        'MsgZap = MsgZap & vbCrLf & "Aguardamos." &
        '        vbCrLf & "Obribago." &
        'vbCrLf & clsUtil.emp_fanta 

        'SendWhatsApp(lblZap.Text, MsgZap)

    End Sub

    Private Sub Txt_Nome_Ani_LostFocus(sender As Object, e As EventArgs) Handles Txt_Nome_Ani.LostFocus
        Try
            If txt_Id_Paciente.Text = 0 Then
                Dim Ret As Integer = 0
                Ret = clsPront.LeNomePet(Txt_Nome_Ani.Text, Txt_ID.Text)
                If Ret > 0 Then
                    'MessageBox.Show("NOME do Pet já existe para este Tutor." & vbCr _
                    '          & "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Id_Enviado_Pac = Ret
                    txt_Id_Paciente.Text = Ret
                    Le_Paciente()
                    Txt_Obs.Focus()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Txt_Nome_Ani.Text = UCase(Txt_Nome_Ani.Text)
    End Sub

    Private Sub btoFrmInternacao_Click(sender As Object, e As EventArgs) Handles btoFrmInternacao.Click

        If Len(Txt_CPF_CNPJ.Text) > 0 Then

            md_Cpf = Txt_CPF_CNPJ.Text
            md_Id_Tutor = Txt_ID.Text
            md_Id_Pet = txt_Id_Paciente.Text

            md_Data = Now
            Dim frm As New frmInternacao()
            frm.ShowDialog()
            '' Me.Close()

        Else
            MessageBox.Show("Solicitação inválida." & vbCr _
                            & "Tutor não Infromado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btoAbreAnaminese_Click(sender As Object, e As EventArgs) Handles btoAbreAnaminese.Click
        If IsNumeric(lbIdPet.Text) = False Then
            MessageBox.Show("Solicitação inválida." & vbCr _
                            & "Pet não Infromado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If Me.lbIdPet.Text > 0 Then

            md_Cpf = Me.Txt_CPF_CNPJ.Text
            md_Id_Tutor = Me.Txt_ID.Text
            md_Id_Pet = Me.txt_Id_Paciente.Text
            md_Id_Consulta = 0

            md_Data = Now
            Dim frm As New frmAnaminese()
            frm.ShowDialog()
            '' Me.Close()

        Else
            MessageBox.Show("Solicitação inválida." & vbCr _
                            & "Pet não Infromado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btoImpirmirVacina_Click(sender As Object, e As EventArgs) Handles btoImpirmirVacina.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.AppStarting
            frmCrystal.Show()
            Dim Caminho As String
            Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryVacinaPlano.rpt"

            Dim CR As New ReportDocument
            CR.Load(Caminho)

            Dim crParameterDiscreteValue As ParameterDiscreteValue
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldLocation As ParameterFieldDefinition
            Dim crParameterValues As ParameterValues

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
            crParameterFieldLocation = crParameterFieldDefinitions.Item("IdPaciente")
            crParameterValues = crParameterFieldLocation.CurrentValues
            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterDiscreteValue.Value = Id_Enviado_Pac

            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

            frmCrystal.crtVwGeral.ReportSource = CR
            frmCrystal.crtVwGeral.Refresh()

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


#End Region

End Class