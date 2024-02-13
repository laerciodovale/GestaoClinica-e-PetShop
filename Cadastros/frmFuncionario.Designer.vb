<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionario))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New Cls_Controls.Cls_TextBox()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.ckAtivo = New System.Windows.Forms.CheckBox()
        Me.dgFunc = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCNH = New Cls_Controls.Cls_TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnGravaImagem = New System.Windows.Forms.Button()
        Me.imgFunc = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDtNas = New Cls_Controls.Cls_TextBoxData()
        Me.txtEMail = New Cls_Controls.Cls_TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRgProf = New Cls_Controls.Cls_TextBox()
        Me.cboFuncao = New Cls_Controls.Cls_ComboBox()
        Me.txtNome = New Cls_Controls.Cls_TextBox()
        Me.txtRG = New Cls_Controls.Cls_TextBox()
        Me.txtCPF = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFixo = New Cls_Controls.Cls_TextBoxFone()
        Me.txtCel = New Cls_Controls.Cls_TextBoxFone()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNro = New Cls_Controls.Cls_TextBox()
        Me.cboUF = New Cls_Controls.Cls_ComboBox()
        Me.txtCidade = New Cls_Controls.Cls_TextBox()
        Me.txtBairro = New Cls_Controls.Cls_TextBox()
        Me.txtCompl = New Cls_Controls.Cls_TextBox()
        Me.txtEndereco = New Cls_Controls.Cls_TextBox()
        Me.txtCEP = New Cls_Controls.Cls_CEP()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bto_Img_Cli = New System.Windows.Forms.Button()
        CType(Me.dgFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(15, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 17)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.EnviaTab = True
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(42, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(93, 34)
        Me.txtID.SomenteNumero = False
        Me.txtID.TabIndex = 183
        '
        'btoIncluir
        '
        Me.btoIncluir.Location = New System.Drawing.Point(816, 740)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(154, 38)
        Me.btoIncluir.TabIndex = 0
        Me.btoIncluir.Text = "Incluir "
        Me.btoIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(1045, 740)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(158, 38)
        Me.btnAlterar.TabIndex = 1
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ckAtivo
        '
        Me.ckAtivo.AutoSize = True
        Me.ckAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAtivo.Location = New System.Drawing.Point(166, 5)
        Me.ckAtivo.Name = "ckAtivo"
        Me.ckAtivo.Size = New System.Drawing.Size(78, 29)
        Me.ckAtivo.TabIndex = 225
        Me.ckAtivo.Text = "Ativo"
        Me.ckAtivo.UseVisualStyleBackColor = True
        '
        'dgFunc
        '
        Me.dgFunc.AllowUserToAddRows = False
        Me.dgFunc.AllowUserToDeleteRows = False
        Me.dgFunc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFunc.GridColor = System.Drawing.Color.White
        Me.dgFunc.Location = New System.Drawing.Point(803, 35)
        Me.dgFunc.MultiSelect = False
        Me.dgFunc.Name = "dgFunc"
        Me.dgFunc.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFunc.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgFunc.RowHeadersVisible = False
        Me.dgFunc.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgFunc.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgFunc.RowTemplate.Height = 24
        Me.dgFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFunc.Size = New System.Drawing.Size(428, 665)
        Me.dgFunc.StandardTab = True
        Me.dgFunc.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bto_Img_Cli)
        Me.GroupBox1.Controls.Add(Me.txtCNH)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btnGravaImagem)
        Me.GroupBox1.Controls.Add(Me.imgFunc)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtDtNas)
        Me.GroupBox1.Controls.Add(Me.txtEMail)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtRgProf)
        Me.GroupBox1.Controls.Add(Me.cboFuncao)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.txtRG)
        Me.GroupBox1.Controls.Add(Me.txtCPF)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCNH
        '
        Me.txtCNH.EnviaTab = True
        Me.txtCNH.Location = New System.Drawing.Point(152, 200)
        Me.txtCNH.Name = "txtCNH"
        Me.txtCNH.Size = New System.Drawing.Size(153, 22)
        Me.txtCNH.SomenteNumero = False
        Me.txtCNH.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(77, 205)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 17)
        Me.Label19.TabIndex = 242
        Me.Label19.Text = "CNH"
        '
        'btnGravaImagem
        '
        Me.btnGravaImagem.Location = New System.Drawing.Point(531, 273)
        Me.btnGravaImagem.Name = "btnGravaImagem"
        Me.btnGravaImagem.Size = New System.Drawing.Size(198, 39)
        Me.btnGravaImagem.TabIndex = 8
        Me.btnGravaImagem.Text = "Gravar Imagem"
        Me.btnGravaImagem.UseVisualStyleBackColor = True
        Me.btnGravaImagem.Visible = False
        '
        'imgFunc
        '
        Me.imgFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgFunc.Image = CType(resources.GetObject("imgFunc.Image"), System.Drawing.Image)
        Me.imgFunc.Location = New System.Drawing.Point(531, 21)
        Me.imgFunc.Name = "imgFunc"
        Me.imgFunc.Size = New System.Drawing.Size(198, 239)
        Me.imgFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgFunc.TabIndex = 240
        Me.imgFunc.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(41, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 17)
        Me.Label15.TabIndex = 239
        Me.Label15.Text = "Dt.Nascimento"
        '
        'txtDtNas
        '
        Me.txtDtNas.EnviaTab = True
        Me.txtDtNas.Location = New System.Drawing.Point(152, 128)
        Me.txtDtNas.Name = "txtDtNas"
        Me.txtDtNas.Size = New System.Drawing.Size(120, 22)
        Me.txtDtNas.SomenteNumero = True
        Me.txtDtNas.TabIndex = 3
        '
        'txtEMail
        '
        Me.txtEMail.EnviaTab = True
        Me.txtEMail.Location = New System.Drawing.Point(152, 238)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(365, 22)
        Me.txtEMail.SomenteNumero = False
        Me.txtEMail.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(86, 238)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 17)
        Me.Label16.TabIndex = 236
        Me.Label16.Text = "E-Mail"
        '
        'txtRgProf
        '
        Me.txtRgProf.EnviaTab = True
        Me.txtRgProf.Location = New System.Drawing.Point(152, 165)
        Me.txtRgProf.Name = "txtRgProf"
        Me.txtRgProf.Size = New System.Drawing.Size(153, 22)
        Me.txtRgProf.SomenteNumero = False
        Me.txtRgProf.TabIndex = 4
        '
        'cboFuncao
        '
        Me.cboFuncao.EnviaTab = True
        Me.cboFuncao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuncao.FormattingEnabled = True
        Me.cboFuncao.Location = New System.Drawing.Point(154, 273)
        Me.cboFuncao.Name = "cboFuncao"
        Me.cboFuncao.Size = New System.Drawing.Size(318, 37)
        Me.cboFuncao.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.EnviaTab = True
        Me.txtNome.Location = New System.Drawing.Point(152, 87)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(318, 22)
        Me.txtNome.SomenteNumero = False
        Me.txtNome.TabIndex = 2
        '
        'txtRG
        '
        Me.txtRG.EnviaTab = True
        Me.txtRG.Location = New System.Drawing.Point(152, 51)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(169, 22)
        Me.txtRG.SomenteNumero = False
        Me.txtRG.TabIndex = 1
        '
        'txtCPF
        '
        Me.txtCPF.CpfValido = True
        Me.txtCPF.EnviaTab = True
        Me.txtCPF.ExibirMensagem = False
        Me.txtCPF.Location = New System.Drawing.Point(152, 15)
        Me.txtCPF.MaxLength = 18
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(169, 22)
        Me.txtCPF.SomenteNumero = True
        Me.txtCPF.TabIndex = 0
        Me.txtCPF.ValidaCNPJ = True
        Me.txtCPF.ValidaCPF = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(77, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 17)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "RG-Prof."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(89, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Funcao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(96, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(112, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "RG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(112, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "CPF"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPlaca)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtDesc)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtFixo)
        Me.GroupBox3.Controls.Add(Me.txtCel)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 618)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(755, 174)
        Me.GroupBox3.TabIndex = 230
        Me.GroupBox3.TabStop = False
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(153, 135)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(135, 22)
        Me.txtPlaca.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 17)
        Me.Label17.TabIndex = 256
        Me.Label17.Text = "Placa do Veiculo"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(153, 100)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(421, 22)
        Me.txtDesc.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 17)
        Me.Label18.TabIndex = 255
        Me.Label18.Text = "Descricao do Veiculo"
        '
        'txtFixo
        '
        Me.txtFixo.EnviaTab = True
        Me.txtFixo.Location = New System.Drawing.Point(153, 61)
        Me.txtFixo.Name = "txtFixo"
        Me.txtFixo.Size = New System.Drawing.Size(154, 22)
        Me.txtFixo.SomenteNumero = False
        Me.txtFixo.TabIndex = 1
        '
        'txtCel
        '
        Me.txtCel.EnviaTab = True
        Me.txtCel.Location = New System.Drawing.Point(154, 21)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(158, 22)
        Me.txtCel.SomenteNumero = False
        Me.txtCel.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(105, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 229
        Me.Label12.Text = "Fixo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(91, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 228
        Me.Label11.Text = "Celular"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNro)
        Me.GroupBox2.Controls.Add(Me.cboUF)
        Me.GroupBox2.Controls.Add(Me.txtCidade)
        Me.GroupBox2.Controls.Add(Me.txtBairro)
        Me.GroupBox2.Controls.Add(Me.txtCompl)
        Me.GroupBox2.Controls.Add(Me.txtEndereco)
        Me.GroupBox2.Controls.Add(Me.txtCEP)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(755, 259)
        Me.GroupBox2.TabIndex = 231
        Me.GroupBox2.TabStop = False
        '
        'txtNro
        '
        Me.txtNro.EnviaTab = True
        Me.txtNro.Location = New System.Drawing.Point(443, 64)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(74, 22)
        Me.txtNro.SomenteNumero = False
        Me.txtNro.TabIndex = 2
        '
        'cboUF
        '
        Me.cboUF.EnviaTab = True
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Location = New System.Drawing.Point(154, 217)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(241, 24)
        Me.cboUF.TabIndex = 6
        '
        'txtCidade
        '
        Me.txtCidade.EnviaTab = True
        Me.txtCidade.Location = New System.Drawing.Point(153, 176)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(242, 22)
        Me.txtCidade.SomenteNumero = False
        Me.txtCidade.TabIndex = 5
        '
        'txtBairro
        '
        Me.txtBairro.EnviaTab = True
        Me.txtBairro.Location = New System.Drawing.Point(152, 137)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(243, 22)
        Me.txtBairro.SomenteNumero = False
        Me.txtBairro.TabIndex = 4
        '
        'txtCompl
        '
        Me.txtCompl.EnviaTab = True
        Me.txtCompl.Location = New System.Drawing.Point(153, 103)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(158, 22)
        Me.txtCompl.SomenteNumero = False
        Me.txtCompl.TabIndex = 3
        '
        'txtEndereco
        '
        Me.txtEndereco.EnviaTab = True
        Me.txtEndereco.Location = New System.Drawing.Point(153, 64)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(284, 22)
        Me.txtEndereco.SomenteNumero = False
        Me.txtEndereco.TabIndex = 1
        '
        'txtCEP
        '
        Me.txtCEP.EnviaTab = True
        Me.txtCEP.Location = New System.Drawing.Point(153, 30)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(115, 22)
        Me.txtCEP.SomenteNumero = False
        Me.txtCEP.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(50, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 17)
        Me.Label14.TabIndex = 201
        Me.Label14.Text = "Complemento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(113, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 200
        Me.Label10.Text = "UF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(104, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "CEP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(87, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(93, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Bairro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(70, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "Endereço"
        '
        'bto_Img_Cli
        '
        Me.bto_Img_Cli.Cursor = System.Windows.Forms.Cursors.Default
        Me.bto_Img_Cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bto_Img_Cli.Location = New System.Drawing.Point(531, 278)
        Me.bto_Img_Cli.Name = "bto_Img_Cli"
        Me.bto_Img_Cli.Size = New System.Drawing.Size(198, 29)
        Me.bto_Img_Cli.TabIndex = 243
        Me.bto_Img_Cli.Text = "Busca Uma Imagem"
        Me.bto_Img_Cli.UseVisualStyleBackColor = True
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 810)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFunc)
        Me.Controls.Add(Me.ckAtivo)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btoIncluir)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Pessoa"
        CType(Me.dgFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtID As Cls_Controls.Cls_TextBox
    Friend WithEvents btoIncluir As Windows.Forms.Button
    Friend WithEvents btnAlterar As Windows.Forms.Button
    Friend WithEvents ckAtivo As Windows.Forms.CheckBox
    Friend WithEvents dgFunc As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnGravaImagem As Windows.Forms.Button
    Friend WithEvents imgFunc As Windows.Forms.PictureBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txtDtNas As Cls_Controls.Cls_TextBoxData
    Friend WithEvents txtEMail As Cls_Controls.Cls_TextBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txtRgProf As Cls_Controls.Cls_TextBox
    Friend WithEvents cboFuncao As Cls_Controls.Cls_ComboBox
    Friend WithEvents txtNome As Cls_Controls.Cls_TextBox
    Friend WithEvents txtRG As Cls_Controls.Cls_TextBox
    Friend WithEvents txtCPF As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents txtFixo As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents txtCel As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents cboUF As Cls_Controls.Cls_ComboBox
    Friend WithEvents txtCidade As Cls_Controls.Cls_TextBox
    Friend WithEvents txtBairro As Cls_Controls.Cls_TextBox
    Friend WithEvents txtCompl As Cls_Controls.Cls_TextBox
    Friend WithEvents txtEndereco As Cls_Controls.Cls_TextBox
    Friend WithEvents txtCEP As Cls_Controls.Cls_CEP
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtPlaca As Windows.Forms.TextBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtDesc As Windows.Forms.TextBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents txtCNH As Cls_Controls.Cls_TextBox
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents txtNro As Cls_Controls.Cls_TextBox
    Friend WithEvents bto_Img_Cli As Windows.Forms.Button
End Class
