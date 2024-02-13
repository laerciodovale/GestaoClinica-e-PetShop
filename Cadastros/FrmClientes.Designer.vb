<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.pnLateralCliente = New System.Windows.Forms.Panel()
        Me.btnFrmFinanceiro = New System.Windows.Forms.Button()
        Me.btoMenu = New System.Windows.Forms.Button()
        Me.btoFrmReceita = New System.Windows.Forms.Button()
        Me.btoFrmVacina = New System.Windows.Forms.Button()
        Me.btoFrmConsulta = New System.Windows.Forms.Button()
        Me.pnDadosCliente = New System.Windows.Forms.Panel()
        Me.bto_Img_Cli = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.pic_Cliente = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Cidade = New Cls_Controls.Cls_TextBoxOld()
        Me.cbo_UF = New Cls_Controls.Cls_ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Fone2 = New Cls_Controls.Cls_TextBoxFone()
        Me.txt_Fone1 = New Cls_Controls.Cls_TextBoxFone()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_Bairro = New Cls_Controls.Cls_ComboBox()
        Me.Cbo_Endereco = New Cls_Controls.Cls_ComboBox()
        Me.Txt_CEP = New Cls_Controls.Cls_CEP()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_DtNas = New Cls_Controls.Cls_TextBoxData()
        Me.Txt_CPF_CNPJ = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFJ = New System.Windows.Forms.CheckBox()
        Me.Txt_Contato = New Cls_Controls.Cls_TextBoxOld()
        Me.txt_Email = New Cls_Controls.Cls_TextBoxOld()
        Me.Txt_Nome_Cli = New Cls_Controls.Cls_TextBoxOld()
        Me.txt_Compl = New Cls_Controls.Cls_TextBoxOld()
        Me.Txt_ID = New Cls_Controls.Cls_TextBoxOld()
        Me.txt_RG = New Cls_Controls.Cls_TextBoxOld()
        Me.txt_Nro = New Cls_Controls.Cls_TextBoxOld()
        Me.pnDetalhe = New System.Windows.Forms.Panel()
        Me.btoImprimir = New System.Windows.Forms.Button()
        Me.cboTermos = New Cls_Controls.Cls_ComboBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.pnDadosPaciente = New System.Windows.Forms.Panel()
        Me.btoAlterarPaciente = New System.Windows.Forms.Button()
        Me.btoGravaPaciente = New System.Windows.Forms.Button()
        Me.Txt_Obs = New Cls_Controls.Cls_TextBoxOld()
        Me.Txt_Chip = New Cls_Controls.Cls_TextBoxOld()
        Me.Txt_Pedigree = New Cls_Controls.Cls_TextBoxOld()
        Me.Txt_DtNasAni = New Cls_Controls.Cls_TextBoxData()
        Me.cboConvenio = New Cls_Controls.Cls_ComboBox()
        Me.CboPelo = New Cls_Controls.Cls_ComboBox()
        Me.CboPorte = New Cls_Controls.Cls_ComboBox()
        Me.CboCor = New Cls_Controls.Cls_ComboBox()
        Me.CboRaca = New Cls_Controls.Cls_ComboBox()
        Me.txt_Id_Paciente = New Cls_Controls.Cls_TextBoxOld()
        Me.Txt_Nome_Ani = New Cls_Controls.Cls_TextBoxOld()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbFemea = New System.Windows.Forms.RadioButton()
        Me.rbMacho = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_Outros = New System.Windows.Forms.RadioButton()
        Me.rb_Felino = New System.Windows.Forms.RadioButton()
        Me.rb_Canino = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pic_Paciente = New System.Windows.Forms.PictureBox()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnLateralCliente.SuspendLayout()
        Me.pnDadosCliente.SuspendLayout()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDetalhe.SuspendLayout()
        Me.pnDadosPaciente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_Paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnLateralCliente
        '
        Me.pnLateralCliente.Controls.Add(Me.btnFrmFinanceiro)
        Me.pnLateralCliente.Controls.Add(Me.btoMenu)
        Me.pnLateralCliente.Controls.Add(Me.btoFrmReceita)
        Me.pnLateralCliente.Controls.Add(Me.btoFrmVacina)
        Me.pnLateralCliente.Controls.Add(Me.btoFrmConsulta)
        Me.pnLateralCliente.Location = New System.Drawing.Point(12, 12)
        Me.pnLateralCliente.Name = "pnLateralCliente"
        Me.pnLateralCliente.Size = New System.Drawing.Size(181, 338)
        Me.pnLateralCliente.TabIndex = 1
        '
        'btnFrmFinanceiro
        '
        Me.btnFrmFinanceiro.Image = Global.Cadastros.My.Resources.Resources.hand_dollar_icon_icons_com_53130
        Me.btnFrmFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFrmFinanceiro.Location = New System.Drawing.Point(13, 253)
        Me.btnFrmFinanceiro.Name = "btnFrmFinanceiro"
        Me.btnFrmFinanceiro.Size = New System.Drawing.Size(156, 55)
        Me.btnFrmFinanceiro.TabIndex = 37
        Me.btnFrmFinanceiro.Text = "Financeiro"
        Me.btnFrmFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFrmFinanceiro.UseVisualStyleBackColor = True
        '
        'btoMenu
        '
        Me.btoMenu.BackColor = System.Drawing.SystemColors.Control
        Me.epValida.SetIconAlignment(Me.btoMenu, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.btoMenu.Image = Global.Cadastros.My.Resources.Resources.menu
        Me.btoMenu.Location = New System.Drawing.Point(13, 16)
        Me.btoMenu.Name = "btoMenu"
        Me.btoMenu.Size = New System.Drawing.Size(65, 55)
        Me.btoMenu.TabIndex = 36
        Me.btoMenu.UseVisualStyleBackColor = False
        '
        'btoFrmReceita
        '
        Me.btoFrmReceita.Image = Global.Cadastros.My.Resources.Resources.medicine_heh_medical_drug_pharmacy_icon_189009
        Me.btoFrmReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoFrmReceita.Location = New System.Drawing.Point(13, 133)
        Me.btoFrmReceita.Name = "btoFrmReceita"
        Me.btoFrmReceita.Size = New System.Drawing.Size(156, 55)
        Me.btoFrmReceita.TabIndex = 35
        Me.btoFrmReceita.Text = "Receita"
        Me.btoFrmReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFrmReceita.UseVisualStyleBackColor = True
        '
        'btoFrmVacina
        '
        Me.btoFrmVacina.Image = Global.Cadastros.My.Resources.Resources.medical_heh_care_doctor_hospital_icon_188998
        Me.btoFrmVacina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoFrmVacina.Location = New System.Drawing.Point(13, 192)
        Me.btoFrmVacina.Name = "btoFrmVacina"
        Me.btoFrmVacina.Size = New System.Drawing.Size(156, 55)
        Me.btoFrmVacina.TabIndex = 34
        Me.btoFrmVacina.Text = "Vacina"
        Me.btoFrmVacina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFrmVacina.UseVisualStyleBackColor = True
        '
        'btoFrmConsulta
        '
        Me.btoFrmConsulta.Image = Global.Cadastros.My.Resources.Resources.consultation_consulting_laptop_doctor_hehy_icon_189005
        Me.btoFrmConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoFrmConsulta.Location = New System.Drawing.Point(13, 72)
        Me.btoFrmConsulta.Name = "btoFrmConsulta"
        Me.btoFrmConsulta.Size = New System.Drawing.Size(156, 55)
        Me.btoFrmConsulta.TabIndex = 33
        Me.btoFrmConsulta.Text = "Consulta"
        Me.btoFrmConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFrmConsulta.UseVisualStyleBackColor = True
        '
        'pnDadosCliente
        '
        Me.pnDadosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDadosCliente.Controls.Add(Me.bto_Img_Cli)
        Me.pnDadosCliente.Controls.Add(Me.btnAlterar)
        Me.pnDadosCliente.Controls.Add(Me.btnIncluir)
        Me.pnDadosCliente.Controls.Add(Me.pic_Cliente)
        Me.pnDadosCliente.Controls.Add(Me.Label14)
        Me.pnDadosCliente.Controls.Add(Me.txt_Cidade)
        Me.pnDadosCliente.Controls.Add(Me.cbo_UF)
        Me.pnDadosCliente.Controls.Add(Me.Label13)
        Me.pnDadosCliente.Controls.Add(Me.Label12)
        Me.pnDadosCliente.Controls.Add(Me.Label11)
        Me.pnDadosCliente.Controls.Add(Me.txt_Fone2)
        Me.pnDadosCliente.Controls.Add(Me.txt_Fone1)
        Me.pnDadosCliente.Controls.Add(Me.Label10)
        Me.pnDadosCliente.Controls.Add(Me.Label9)
        Me.pnDadosCliente.Controls.Add(Me.Label8)
        Me.pnDadosCliente.Controls.Add(Me.Label7)
        Me.pnDadosCliente.Controls.Add(Me.Label6)
        Me.pnDadosCliente.Controls.Add(Me.cbo_Bairro)
        Me.pnDadosCliente.Controls.Add(Me.Cbo_Endereco)
        Me.pnDadosCliente.Controls.Add(Me.Txt_CEP)
        Me.pnDadosCliente.Controls.Add(Me.Label5)
        Me.pnDadosCliente.Controls.Add(Me.Label4)
        Me.pnDadosCliente.Controls.Add(Me.Label3)
        Me.pnDadosCliente.Controls.Add(Me.Label2)
        Me.pnDadosCliente.Controls.Add(Me.txt_DtNas)
        Me.pnDadosCliente.Controls.Add(Me.Txt_CPF_CNPJ)
        Me.pnDadosCliente.Controls.Add(Me.Label1)
        Me.pnDadosCliente.Controls.Add(Me.chkFJ)
        Me.pnDadosCliente.Controls.Add(Me.Txt_Contato)
        Me.pnDadosCliente.Controls.Add(Me.txt_Email)
        Me.pnDadosCliente.Controls.Add(Me.Txt_Nome_Cli)
        Me.pnDadosCliente.Controls.Add(Me.txt_Compl)
        Me.pnDadosCliente.Controls.Add(Me.Txt_ID)
        Me.pnDadosCliente.Controls.Add(Me.txt_RG)
        Me.pnDadosCliente.Controls.Add(Me.txt_Nro)
        Me.pnDadosCliente.Location = New System.Drawing.Point(200, 12)
        Me.pnDadosCliente.Name = "pnDadosCliente"
        Me.pnDadosCliente.Size = New System.Drawing.Size(941, 338)
        Me.pnDadosCliente.TabIndex = 1
        '
        'bto_Img_Cli
        '
        Me.bto_Img_Cli.Location = New System.Drawing.Point(744, 303)
        Me.bto_Img_Cli.Name = "bto_Img_Cli"
        Me.bto_Img_Cli.Size = New System.Drawing.Size(156, 29)
        Me.bto_Img_Cli.TabIndex = 34
        Me.bto_Img_Cli.Text = "Incluir Imagem"
        Me.bto_Img_Cli.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(326, 303)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(156, 29)
        Me.btnAlterar.TabIndex = 33
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(88, 303)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(156, 29)
        Me.btnIncluir.TabIndex = 32
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'pic_Cliente
        '
        Me.pic_Cliente.Location = New System.Drawing.Point(706, 5)
        Me.pic_Cliente.Name = "pic_Cliente"
        Me.pic_Cliente.Size = New System.Drawing.Size(200, 280)
        Me.pic_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Cliente.TabIndex = 31
        Me.pic_Cliente.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(489, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Dt.Nas."
        '
        'txt_Cidade
        '
        Me.txt_Cidade.EnviaTab = True
        Me.txt_Cidade.Location = New System.Drawing.Point(87, 205)
        Me.txt_Cidade.Name = "txt_Cidade"
        Me.txt_Cidade.Size = New System.Drawing.Size(243, 22)
        Me.txt_Cidade.SomenteNumero = False
        Me.txt_Cidade.TabIndex = 11
        '
        'cbo_UF
        '
        Me.cbo_UF.EnviaTab = True
        Me.cbo_UF.FormattingEnabled = True
        Me.cbo_UF.Location = New System.Drawing.Point(399, 208)
        Me.cbo_UF.Name = "cbo_UF"
        Me.cbo_UF.Size = New System.Drawing.Size(84, 24)
        Me.cbo_UF.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Contato"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Nome"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "E-Mail"
        '
        'txt_Fone2
        '
        Me.txt_Fone2.EnviaTab = True
        Me.txt_Fone2.Location = New System.Drawing.Point(334, 240)
        Me.txt_Fone2.Name = "txt_Fone2"
        Me.txt_Fone2.Size = New System.Drawing.Size(148, 22)
        Me.txt_Fone2.SomenteNumero = False
        Me.txt_Fone2.TabIndex = 15
        '
        'txt_Fone1
        '
        Me.txt_Fone1.EnviaTab = True
        Me.txt_Fone1.Location = New System.Drawing.Point(87, 236)
        Me.txt_Fone1.Name = "txt_Fone1"
        Me.txt_Fone1.Size = New System.Drawing.Size(148, 22)
        Me.txt_Fone1.SomenteNumero = False
        Me.txt_Fone1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Fone 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(367, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cidade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Compl."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Bairro"
        '
        'cbo_Bairro
        '
        Me.cbo_Bairro.EnviaTab = True
        Me.cbo_Bairro.FormattingEnabled = True
        Me.cbo_Bairro.Location = New System.Drawing.Point(87, 115)
        Me.cbo_Bairro.Name = "cbo_Bairro"
        Me.cbo_Bairro.Size = New System.Drawing.Size(327, 24)
        Me.cbo_Bairro.TabIndex = 7
        '
        'Cbo_Endereco
        '
        Me.Cbo_Endereco.EnviaTab = True
        Me.Cbo_Endereco.FormattingEnabled = True
        Me.Cbo_Endereco.Location = New System.Drawing.Point(88, 147)
        Me.Cbo_Endereco.Name = "Cbo_Endereco"
        Me.Cbo_Endereco.Size = New System.Drawing.Size(327, 24)
        Me.Cbo_Endereco.TabIndex = 8
        '
        'Txt_CEP
        '
        Me.Txt_CEP.EnviaTab = True
        Me.Txt_CEP.Location = New System.Drawing.Point(87, 87)
        Me.Txt_CEP.Name = "Txt_CEP"
        Me.Txt_CEP.Size = New System.Drawing.Size(100, 22)
        Me.Txt_CEP.SomenteNumero = False
        Me.Txt_CEP.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CEP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RG"
        '
        'txt_DtNas
        '
        Me.txt_DtNas.EnviaTab = True
        Me.txt_DtNas.Location = New System.Drawing.Point(547, 210)
        Me.txt_DtNas.Name = "txt_DtNas"
        Me.txt_DtNas.Size = New System.Drawing.Size(113, 22)
        Me.txt_DtNas.SomenteNumero = True
        Me.txt_DtNas.TabIndex = 13
        '
        'Txt_CPF_CNPJ
        '
        Me.Txt_CPF_CNPJ.CpfValido = True
        Me.Txt_CPF_CNPJ.EnviaTab = True
        Me.Txt_CPF_CNPJ.ExibirMensagem = False
        Me.Txt_CPF_CNPJ.Location = New System.Drawing.Point(208, 4)
        Me.Txt_CPF_CNPJ.MaxLength = 18
        Me.Txt_CPF_CNPJ.Name = "Txt_CPF_CNPJ"
        Me.Txt_CPF_CNPJ.Size = New System.Drawing.Size(163, 22)
        Me.Txt_CPF_CNPJ.SomenteNumero = True
        Me.Txt_CPF_CNPJ.TabIndex = 1
        Me.Txt_CPF_CNPJ.ValidaCNPJ = True
        Me.Txt_CPF_CNPJ.ValidaCPF = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CPF/CNPJ"
        '
        'chkFJ
        '
        Me.chkFJ.AutoSize = True
        Me.chkFJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFJ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkFJ.Location = New System.Drawing.Point(16, 4)
        Me.chkFJ.Name = "chkFJ"
        Me.chkFJ.Size = New System.Drawing.Size(90, 24)
        Me.chkFJ.TabIndex = 0
        Me.chkFJ.Text = "Jurídica"
        Me.chkFJ.UseVisualStyleBackColor = True
        '
        'Txt_Contato
        '
        Me.Txt_Contato.EnviaTab = True
        Me.Txt_Contato.Location = New System.Drawing.Point(87, 59)
        Me.Txt_Contato.Name = "Txt_Contato"
        Me.Txt_Contato.Size = New System.Drawing.Size(243, 22)
        Me.Txt_Contato.SomenteNumero = False
        Me.Txt_Contato.TabIndex = 5
        '
        'txt_Email
        '
        Me.txt_Email.EnviaTab = True
        Me.txt_Email.Location = New System.Drawing.Point(88, 264)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(395, 22)
        Me.txt_Email.SomenteNumero = False
        Me.txt_Email.TabIndex = 16
        '
        'Txt_Nome_Cli
        '
        Me.Txt_Nome_Cli.EnviaTab = True
        Me.Txt_Nome_Cli.Location = New System.Drawing.Point(87, 31)
        Me.Txt_Nome_Cli.Name = "Txt_Nome_Cli"
        Me.Txt_Nome_Cli.Size = New System.Drawing.Size(482, 22)
        Me.Txt_Nome_Cli.SomenteNumero = False
        Me.Txt_Nome_Cli.TabIndex = 4
        '
        'txt_Compl
        '
        Me.txt_Compl.EnviaTab = True
        Me.txt_Compl.Location = New System.Drawing.Point(88, 177)
        Me.txt_Compl.Name = "txt_Compl"
        Me.txt_Compl.Size = New System.Drawing.Size(242, 22)
        Me.txt_Compl.SomenteNumero = False
        Me.txt_Compl.TabIndex = 10
        '
        'Txt_ID
        '
        Me.Txt_ID.EnviaTab = True
        Me.Txt_ID.Location = New System.Drawing.Point(602, 2)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(57, 22)
        Me.Txt_ID.SomenteNumero = False
        Me.Txt_ID.TabIndex = 3
        '
        'txt_RG
        '
        Me.txt_RG.EnviaTab = True
        Me.txt_RG.Location = New System.Drawing.Point(431, 2)
        Me.txt_RG.Name = "txt_RG"
        Me.txt_RG.Size = New System.Drawing.Size(138, 22)
        Me.txt_RG.SomenteNumero = False
        Me.txt_RG.TabIndex = 2
        '
        'txt_Nro
        '
        Me.txt_Nro.EnviaTab = True
        Me.txt_Nro.Location = New System.Drawing.Point(421, 149)
        Me.txt_Nro.Name = "txt_Nro"
        Me.txt_Nro.Size = New System.Drawing.Size(61, 22)
        Me.txt_Nro.SomenteNumero = False
        Me.txt_Nro.TabIndex = 9
        '
        'pnDetalhe
        '
        Me.pnDetalhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDetalhe.Controls.Add(Me.btoImprimir)
        Me.pnDetalhe.Controls.Add(Me.cboTermos)
        Me.pnDetalhe.Controls.Add(Me.TreeView1)
        Me.pnDetalhe.Location = New System.Drawing.Point(200, 360)
        Me.pnDetalhe.Name = "pnDetalhe"
        Me.pnDetalhe.Size = New System.Drawing.Size(941, 230)
        Me.pnDetalhe.TabIndex = 3
        '
        'btoImprimir
        '
        Me.btoImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.epValida.SetIconAlignment(Me.btoImprimir, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.btoImprimir.Image = Global.Cadastros.My.Resources.Resources.printer_medicine_receipt_result_hospital_icon_188995
        Me.btoImprimir.Location = New System.Drawing.Point(812, 28)
        Me.btoImprimir.Name = "btoImprimir"
        Me.btoImprimir.Size = New System.Drawing.Size(65, 55)
        Me.btoImprimir.TabIndex = 40
        Me.btoImprimir.UseVisualStyleBackColor = False
        '
        'cboTermos
        '
        Me.cboTermos.EnviaTab = True
        Me.cboTermos.FormattingEnabled = True
        Me.cboTermos.Location = New System.Drawing.Point(770, 89)
        Me.cboTermos.Name = "cboTermos"
        Me.cboTermos.Size = New System.Drawing.Size(156, 24)
        Me.cboTermos.TabIndex = 39
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(58, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(706, 220)
        Me.TreeView1.TabIndex = 0
        '
        'pnDadosPaciente
        '
        Me.pnDadosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDadosPaciente.Controls.Add(Me.btoAlterarPaciente)
        Me.pnDadosPaciente.Controls.Add(Me.btoGravaPaciente)
        Me.pnDadosPaciente.Controls.Add(Me.Txt_Obs)
        Me.pnDadosPaciente.Controls.Add(Me.Txt_Chip)
        Me.pnDadosPaciente.Controls.Add(Me.Txt_Pedigree)
        Me.pnDadosPaciente.Controls.Add(Me.Txt_DtNasAni)
        Me.pnDadosPaciente.Controls.Add(Me.cboConvenio)
        Me.pnDadosPaciente.Controls.Add(Me.CboPelo)
        Me.pnDadosPaciente.Controls.Add(Me.CboPorte)
        Me.pnDadosPaciente.Controls.Add(Me.CboCor)
        Me.pnDadosPaciente.Controls.Add(Me.CboRaca)
        Me.pnDadosPaciente.Controls.Add(Me.txt_Id_Paciente)
        Me.pnDadosPaciente.Controls.Add(Me.Txt_Nome_Ani)
        Me.pnDadosPaciente.Controls.Add(Me.GroupBox2)
        Me.pnDadosPaciente.Controls.Add(Me.Label25)
        Me.pnDadosPaciente.Controls.Add(Me.Label24)
        Me.pnDadosPaciente.Controls.Add(Me.Label23)
        Me.pnDadosPaciente.Controls.Add(Me.Label22)
        Me.pnDadosPaciente.Controls.Add(Me.Label21)
        Me.pnDadosPaciente.Controls.Add(Me.Label20)
        Me.pnDadosPaciente.Controls.Add(Me.Label19)
        Me.pnDadosPaciente.Controls.Add(Me.Label18)
        Me.pnDadosPaciente.Controls.Add(Me.Label17)
        Me.pnDadosPaciente.Controls.Add(Me.GroupBox1)
        Me.pnDadosPaciente.Controls.Add(Me.Label16)
        Me.pnDadosPaciente.Controls.Add(Me.Label15)
        Me.pnDadosPaciente.Controls.Add(Me.pic_Paciente)
        Me.pnDadosPaciente.Location = New System.Drawing.Point(200, 600)
        Me.pnDadosPaciente.Name = "pnDadosPaciente"
        Me.pnDadosPaciente.Size = New System.Drawing.Size(941, 299)
        Me.pnDadosPaciente.TabIndex = 0
        '
        'btoAlterarPaciente
        '
        Me.btoAlterarPaciente.Location = New System.Drawing.Point(314, 262)
        Me.btoAlterarPaciente.Name = "btoAlterarPaciente"
        Me.btoAlterarPaciente.Size = New System.Drawing.Size(156, 29)
        Me.btoAlterarPaciente.TabIndex = 12
        Me.btoAlterarPaciente.Text = "Alterar"
        Me.btoAlterarPaciente.UseVisualStyleBackColor = True
        '
        'btoGravaPaciente
        '
        Me.btoGravaPaciente.Location = New System.Drawing.Point(76, 262)
        Me.btoGravaPaciente.Name = "btoGravaPaciente"
        Me.btoGravaPaciente.Size = New System.Drawing.Size(156, 29)
        Me.btoGravaPaciente.TabIndex = 11
        Me.btoGravaPaciente.Text = "Incluir"
        Me.btoGravaPaciente.UseVisualStyleBackColor = True
        '
        'Txt_Obs
        '
        Me.Txt_Obs.EnviaTab = True
        Me.Txt_Obs.Location = New System.Drawing.Point(81, 208)
        Me.Txt_Obs.Multiline = True
        Me.Txt_Obs.Name = "Txt_Obs"
        Me.Txt_Obs.Size = New System.Drawing.Size(578, 48)
        Me.Txt_Obs.SomenteNumero = False
        Me.Txt_Obs.TabIndex = 10
        '
        'Txt_Chip
        '
        Me.Txt_Chip.EnviaTab = True
        Me.Txt_Chip.Location = New System.Drawing.Point(460, 180)
        Me.Txt_Chip.Name = "Txt_Chip"
        Me.Txt_Chip.Size = New System.Drawing.Size(199, 22)
        Me.Txt_Chip.SomenteNumero = False
        Me.Txt_Chip.TabIndex = 9
        '
        'Txt_Pedigree
        '
        Me.Txt_Pedigree.EnviaTab = True
        Me.Txt_Pedigree.Location = New System.Drawing.Point(84, 180)
        Me.Txt_Pedigree.Name = "Txt_Pedigree"
        Me.Txt_Pedigree.Size = New System.Drawing.Size(266, 22)
        Me.Txt_Pedigree.SomenteNumero = False
        Me.Txt_Pedigree.TabIndex = 8
        '
        'Txt_DtNasAni
        '
        Me.Txt_DtNasAni.EnviaTab = True
        Me.Txt_DtNasAni.Location = New System.Drawing.Point(537, 110)
        Me.Txt_DtNasAni.Name = "Txt_DtNasAni"
        Me.Txt_DtNasAni.Size = New System.Drawing.Size(122, 22)
        Me.Txt_DtNasAni.SomenteNumero = True
        Me.Txt_DtNasAni.TabIndex = 7
        '
        'cboConvenio
        '
        Me.cboConvenio.EnviaTab = True
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(334, 110)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(122, 24)
        Me.cboConvenio.TabIndex = 6
        '
        'CboPelo
        '
        Me.CboPelo.EnviaTab = True
        Me.CboPelo.FormattingEnabled = True
        Me.CboPelo.Location = New System.Drawing.Point(81, 110)
        Me.CboPelo.Name = "CboPelo"
        Me.CboPelo.Size = New System.Drawing.Size(122, 24)
        Me.CboPelo.TabIndex = 5
        '
        'CboPorte
        '
        Me.CboPorte.EnviaTab = True
        Me.CboPorte.FormattingEnabled = True
        Me.CboPorte.Location = New System.Drawing.Point(537, 73)
        Me.CboPorte.Name = "CboPorte"
        Me.CboPorte.Size = New System.Drawing.Size(122, 24)
        Me.CboPorte.TabIndex = 4
        '
        'CboCor
        '
        Me.CboCor.EnviaTab = True
        Me.CboCor.FormattingEnabled = True
        Me.CboCor.Location = New System.Drawing.Point(334, 73)
        Me.CboCor.Name = "CboCor"
        Me.CboCor.Size = New System.Drawing.Size(122, 24)
        Me.CboCor.TabIndex = 3
        '
        'CboRaca
        '
        Me.CboRaca.EnviaTab = True
        Me.CboRaca.FormattingEnabled = True
        Me.CboRaca.Location = New System.Drawing.Point(84, 75)
        Me.CboRaca.Name = "CboRaca"
        Me.CboRaca.Size = New System.Drawing.Size(122, 24)
        Me.CboRaca.TabIndex = 2
        '
        'txt_Id_Paciente
        '
        Me.txt_Id_Paciente.EnviaTab = True
        Me.txt_Id_Paciente.Location = New System.Drawing.Point(602, 13)
        Me.txt_Id_Paciente.Name = "txt_Id_Paciente"
        Me.txt_Id_Paciente.Size = New System.Drawing.Size(57, 22)
        Me.txt_Id_Paciente.SomenteNumero = False
        Me.txt_Id_Paciente.TabIndex = 1
        '
        'Txt_Nome_Ani
        '
        Me.Txt_Nome_Ani.EnviaTab = True
        Me.Txt_Nome_Ani.Location = New System.Drawing.Point(81, 13)
        Me.Txt_Nome_Ani.Name = "Txt_Nome_Ani"
        Me.Txt_Nome_Ani.Size = New System.Drawing.Size(292, 22)
        Me.Txt_Nome_Ani.SomenteNumero = False
        Me.Txt_Nome_Ani.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbFemea)
        Me.GroupBox2.Controls.Add(Me.rbMacho)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 34)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'rbFemea
        '
        Me.rbFemea.AutoSize = True
        Me.rbFemea.ForeColor = System.Drawing.Color.Fuchsia
        Me.rbFemea.Location = New System.Drawing.Point(211, 11)
        Me.rbFemea.Name = "rbFemea"
        Me.rbFemea.Size = New System.Drawing.Size(86, 21)
        Me.rbFemea.TabIndex = 1
        Me.rbFemea.TabStop = True
        Me.rbFemea.Text = "Feminino"
        Me.rbFemea.UseVisualStyleBackColor = True
        '
        'rbMacho
        '
        Me.rbMacho.AutoSize = True
        Me.rbMacho.BackColor = System.Drawing.SystemColors.Control
        Me.rbMacho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbMacho.Location = New System.Drawing.Point(71, 11)
        Me.rbMacho.Name = "rbMacho"
        Me.rbMacho.Size = New System.Drawing.Size(92, 21)
        Me.rbMacho.TabIndex = 0
        Me.rbMacho.TabStop = True
        Me.rbMacho.Text = "Masculino"
        Me.rbMacho.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(27, 213)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 17)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "OBS**"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(417, 183)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 17)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Chip"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 180)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 17)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Pedogree"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(478, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 17)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Dt.Nasc."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(251, 110)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 17)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Convenio"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(30, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 17)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Pelo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(489, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 17)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Porte"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(288, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 17)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Cor"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 17)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Raça"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Outros)
        Me.GroupBox1.Controls.Add(Me.rb_Felino)
        Me.GroupBox1.Controls.Add(Me.rb_Canino)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 34)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Espécie"
        '
        'rb_Outros
        '
        Me.rb_Outros.AutoSize = True
        Me.rb_Outros.Location = New System.Drawing.Point(250, 11)
        Me.rb_Outros.Name = "rb_Outros"
        Me.rb_Outros.Size = New System.Drawing.Size(72, 21)
        Me.rb_Outros.TabIndex = 2
        Me.rb_Outros.TabStop = True
        Me.rb_Outros.Text = "Outros"
        Me.rb_Outros.UseVisualStyleBackColor = True
        '
        'rb_Felino
        '
        Me.rb_Felino.AutoSize = True
        Me.rb_Felino.Location = New System.Drawing.Point(166, 11)
        Me.rb_Felino.Name = "rb_Felino"
        Me.rb_Felino.Size = New System.Drawing.Size(67, 21)
        Me.rb_Felino.TabIndex = 1
        Me.rb_Felino.TabStop = True
        Me.rb_Felino.Text = "Felina"
        Me.rb_Felino.UseVisualStyleBackColor = True
        '
        'rb_Canino
        '
        Me.rb_Canino.AutoSize = True
        Me.rb_Canino.Location = New System.Drawing.Point(71, 11)
        Me.rb_Canino.Name = "rb_Canino"
        Me.rb_Canino.Size = New System.Drawing.Size(73, 21)
        Me.rb_Canino.TabIndex = 0
        Me.rb_Canino.TabStop = True
        Me.rb_Canino.Text = "Canina"
        Me.rb_Canino.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 17)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nome"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(575, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 17)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "ID"
        '
        'pic_Paciente
        '
        Me.pic_Paciente.Location = New System.Drawing.Point(720, 3)
        Me.pic_Paciente.Name = "pic_Paciente"
        Me.pic_Paciente.Size = New System.Drawing.Size(200, 280)
        Me.pic_Paciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Paciente.TabIndex = 32
        Me.pic_Paciente.TabStop = False
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "usuario")
        Me.ImageList1.Images.SetKeyName(1, "animal")
        Me.ImageList1.Images.SetKeyName(2, "deletado")
        Me.ImageList1.Images.SetKeyName(3, "checado")
        Me.ImageList1.Images.SetKeyName(4, "seta")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 39)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1172, 903)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnDadosPaciente)
        Me.Controls.Add(Me.pnDetalhe)
        Me.Controls.Add(Me.pnDadosCliente)
        Me.Controls.Add(Me.pnLateralCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmClientes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.pnLateralCliente.ResumeLayout(False)
        Me.pnDadosCliente.ResumeLayout(False)
        Me.pnDadosCliente.PerformLayout()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDetalhe.ResumeLayout(False)
        Me.pnDadosPaciente.ResumeLayout(False)
        Me.pnDadosPaciente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_Paciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnLateralCliente As Windows.Forms.Panel
    Friend WithEvents pnDadosCliente As Windows.Forms.Panel
    Friend WithEvents txt_Nro As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents pnDetalhe As Windows.Forms.Panel
    Friend WithEvents pnDadosPaciente As Windows.Forms.Panel
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txt_Cidade As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents cbo_UF As Cls_Controls.Cls_ComboBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_Fone2 As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents txt_Fone1 As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents cbo_Bairro As Cls_Controls.Cls_ComboBox
    Friend WithEvents Cbo_Endereco As Cls_Controls.Cls_ComboBox
    Friend WithEvents Txt_CEP As Cls_Controls.Cls_CEP
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_DtNas As Cls_Controls.Cls_TextBoxData
    Friend WithEvents Txt_CPF_CNPJ As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents chkFJ As Windows.Forms.CheckBox
    Friend WithEvents Txt_Contato As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txt_Email As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Nome_Cli As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txt_Compl As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txt_RG As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents pic_Cliente As Windows.Forms.PictureBox
    Friend WithEvents pic_Paciente As Windows.Forms.PictureBox
    Friend WithEvents btnAlterar As Windows.Forms.Button
    Friend WithEvents btnIncluir As Windows.Forms.Button
    Friend WithEvents btoFrmReceita As Windows.Forms.Button
    Friend WithEvents btoFrmVacina As Windows.Forms.Button
    Friend WithEvents btoFrmConsulta As Windows.Forms.Button
    Friend WithEvents btoAlterarPaciente As Windows.Forms.Button
    Friend WithEvents btoGravaPaciente As Windows.Forms.Button
    Friend WithEvents Txt_Obs As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Chip As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Pedigree As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_DtNasAni As Cls_Controls.Cls_TextBoxData
    Friend WithEvents cboConvenio As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboPelo As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboPorte As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboCor As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboRaca As Cls_Controls.Cls_ComboBox
    Friend WithEvents Txt_Nome_Ani As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents rbFemea As Windows.Forms.RadioButton
    Friend WithEvents rbMacho As Windows.Forms.RadioButton
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents rb_Outros As Windows.Forms.RadioButton
    Friend WithEvents rb_Felino As Windows.Forms.RadioButton
    Friend WithEvents rb_Canino As Windows.Forms.RadioButton
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents bto_Img_Cli As Windows.Forms.Button
    Friend WithEvents TreeView1 As Windows.Forms.TreeView
    Friend WithEvents btoMenu As Windows.Forms.Button
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents btoImprimir As Windows.Forms.Button
    Friend WithEvents cboTermos As Cls_Controls.Cls_ComboBox
    Friend WithEvents btnFrmFinanceiro As Windows.Forms.Button
    Public WithEvents Txt_ID As Cls_Controls.Cls_TextBoxOld
    Public WithEvents txt_Id_Paciente As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
