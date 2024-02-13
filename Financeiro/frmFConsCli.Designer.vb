<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFConsCli
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBusca = New Cls_Controls.Cls_TextBox()
        Me.dgResultado = New System.Windows.Forms.DataGridView()
        Me.pnDadosCliente = New System.Windows.Forms.Panel()
        Me.lbIdadeTutor = New System.Windows.Forms.Label()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
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
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pic_Cliente = New System.Windows.Forms.PictureBox()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDadosCliente.SuspendLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBusca
        '
        Me.txtBusca.BackColor = System.Drawing.Color.White
        Me.txtBusca.EnviaTab = True
        Me.txtBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusca.Location = New System.Drawing.Point(34, 12)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(477, 53)
        Me.txtBusca.SomenteNumero = False
        Me.txtBusca.TabIndex = 0
        '
        'dgResultado
        '
        Me.dgResultado.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgResultado.AllowUserToAddRows = False
        Me.dgResultado.AllowUserToDeleteRows = False
        Me.dgResultado.AllowUserToOrderColumns = True
        Me.dgResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgResultado.BackgroundColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResultado.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgResultado.GridColor = System.Drawing.Color.White
        Me.dgResultado.Location = New System.Drawing.Point(34, 86)
        Me.dgResultado.MultiSelect = False
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.ReadOnly = True
        Me.dgResultado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResultado.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgResultado.RowHeadersVisible = False
        Me.dgResultado.RowHeadersWidth = 20
        Me.dgResultado.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgResultado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgResultado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgResultado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightCyan
        Me.dgResultado.RowTemplate.Height = 24
        Me.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResultado.Size = New System.Drawing.Size(1102, 306)
        Me.dgResultado.StandardTab = True
        Me.dgResultado.TabIndex = 1
        '
        'pnDadosCliente
        '
        Me.pnDadosCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnDadosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDadosCliente.Controls.Add(Me.pic_Cliente)
        Me.pnDadosCliente.Controls.Add(Me.lbIdadeTutor)
        Me.pnDadosCliente.Controls.Add(Me.btnAlterar)
        Me.pnDadosCliente.Controls.Add(Me.btnIncluir)
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
        Me.pnDadosCliente.Location = New System.Drawing.Point(34, 427)
        Me.pnDadosCliente.Name = "pnDadosCliente"
        Me.pnDadosCliente.Size = New System.Drawing.Size(1100, 228)
        Me.pnDadosCliente.TabIndex = 6
        '
        'lbIdadeTutor
        '
        Me.lbIdadeTutor.AutoSize = True
        Me.lbIdadeTutor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbIdadeTutor.Location = New System.Drawing.Point(242, 143)
        Me.lbIdadeTutor.Name = "lbIdadeTutor"
        Me.lbIdadeTutor.Size = New System.Drawing.Size(43, 17)
        Me.lbIdadeTutor.TabIndex = 35
        Me.lbIdadeTutor.Text = "Idade"
        '
        'btnAlterar
        '
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Location = New System.Drawing.Point(775, 187)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(135, 29)
        Me.btnAlterar.TabIndex = 33
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        Me.btnAlterar.Visible = False
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncluir.Location = New System.Drawing.Point(523, 187)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(135, 29)
        Me.btnIncluir.TabIndex = 32
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Location = New System.Drawing.Point(29, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Dt.Nas."
        '
        'txt_Cidade
        '
        Me.txt_Cidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Cidade.EnviaTab = True
        Me.txt_Cidade.Location = New System.Drawing.Point(481, 110)
        Me.txt_Cidade.Name = "txt_Cidade"
        Me.txt_Cidade.Size = New System.Drawing.Size(243, 22)
        Me.txt_Cidade.SomenteNumero = False
        Me.txt_Cidade.TabIndex = 11
        '
        'cbo_UF
        '
        Me.cbo_UF.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbo_UF.EnviaTab = True
        Me.cbo_UF.FormattingEnabled = True
        Me.cbo_UF.Location = New System.Drawing.Point(793, 113)
        Me.cbo_UF.Name = "cbo_UF"
        Me.cbo_UF.Size = New System.Drawing.Size(84, 24)
        Me.cbo_UF.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Location = New System.Drawing.Point(604, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Contato"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Location = New System.Drawing.Point(37, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Nome"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Location = New System.Drawing.Point(33, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "E-Mail"
        '
        'txt_Fone2
        '
        Me.txt_Fone2.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Fone2.EnviaTab = True
        Me.txt_Fone2.Location = New System.Drawing.Point(245, 171)
        Me.txt_Fone2.Name = "txt_Fone2"
        Me.txt_Fone2.Size = New System.Drawing.Size(148, 22)
        Me.txt_Fone2.SomenteNumero = False
        Me.txt_Fone2.TabIndex = 15
        '
        'txt_Fone1
        '
        Me.txt_Fone1.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Fone1.EnviaTab = True
        Me.txt_Fone1.Location = New System.Drawing.Point(87, 171)
        Me.txt_Fone1.Name = "txt_Fone1"
        Me.txt_Fone1.Size = New System.Drawing.Size(148, 22)
        Me.txt_Fone1.SomenteNumero = False
        Me.txt_Fone1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Location = New System.Drawing.Point(25, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Fone 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Location = New System.Drawing.Point(761, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Location = New System.Drawing.Point(423, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Location = New System.Drawing.Point(37, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Bairro"
        '
        'cbo_Bairro
        '
        Me.cbo_Bairro.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbo_Bairro.EnviaTab = True
        Me.cbo_Bairro.FormattingEnabled = True
        Me.cbo_Bairro.Location = New System.Drawing.Point(88, 110)
        Me.cbo_Bairro.Name = "cbo_Bairro"
        Me.cbo_Bairro.Size = New System.Drawing.Size(327, 24)
        Me.cbo_Bairro.TabIndex = 10
        '
        'Cbo_Endereco
        '
        Me.Cbo_Endereco.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cbo_Endereco.EnviaTab = True
        Me.Cbo_Endereco.FormattingEnabled = True
        Me.Cbo_Endereco.Location = New System.Drawing.Point(268, 80)
        Me.Cbo_Endereco.Name = "Cbo_Endereco"
        Me.Cbo_Endereco.Size = New System.Drawing.Size(327, 24)
        Me.Cbo_Endereco.TabIndex = 7
        '
        'Txt_CEP
        '
        Me.Txt_CEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_CEP.EnviaTab = True
        Me.Txt_CEP.Location = New System.Drawing.Point(88, 82)
        Me.Txt_CEP.Name = "Txt_CEP"
        Me.Txt_CEP.Size = New System.Drawing.Size(100, 22)
        Me.Txt_CEP.SomenteNumero = False
        Me.Txt_CEP.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Location = New System.Drawing.Point(47, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CEP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Location = New System.Drawing.Point(193, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Location = New System.Drawing.Point(575, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Location = New System.Drawing.Point(396, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RG"
        '
        'txt_DtNas
        '
        Me.txt_DtNas.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_DtNas.EnviaTab = True
        Me.txt_DtNas.Location = New System.Drawing.Point(87, 143)
        Me.txt_DtNas.Name = "txt_DtNas"
        Me.txt_DtNas.Size = New System.Drawing.Size(113, 22)
        Me.txt_DtNas.SomenteNumero = True
        Me.txt_DtNas.TabIndex = 13
        '
        'Txt_CPF_CNPJ
        '
        Me.Txt_CPF_CNPJ.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_CPF_CNPJ.EnviaTab = True
        Me.Txt_CPF_CNPJ.ExibirMensagem = False
        Me.Txt_CPF_CNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CPF_CNPJ.Location = New System.Drawing.Point(208, 4)
        Me.Txt_CPF_CNPJ.MaxLength = 14
        Me.Txt_CPF_CNPJ.Name = "Txt_CPF_CNPJ"
        Me.Txt_CPF_CNPJ.Size = New System.Drawing.Size(163, 26)
        Me.Txt_CPF_CNPJ.SomenteNumero = True
        Me.Txt_CPF_CNPJ.TabIndex = 1
        Me.Txt_CPF_CNPJ.ValidaCNPJ = False
        Me.Txt_CPF_CNPJ.ValidaCPF = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(123, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CPF/CNPJ"
        '
        'chkFJ
        '
        Me.chkFJ.AutoSize = True
        Me.chkFJ.Cursor = System.Windows.Forms.Cursors.Default
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
        Me.Txt_Contato.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Contato.EnviaTab = True
        Me.Txt_Contato.Location = New System.Drawing.Point(667, 50)
        Me.Txt_Contato.Name = "Txt_Contato"
        Me.Txt_Contato.Size = New System.Drawing.Size(243, 22)
        Me.Txt_Contato.SomenteNumero = False
        Me.Txt_Contato.TabIndex = 5
        '
        'txt_Email
        '
        Me.txt_Email.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Email.EnviaTab = True
        Me.txt_Email.Location = New System.Drawing.Point(88, 199)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(395, 22)
        Me.txt_Email.SomenteNumero = False
        Me.txt_Email.TabIndex = 16
        '
        'Txt_Nome_Cli
        '
        Me.Txt_Nome_Cli.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Nome_Cli.EnviaTab = True
        Me.Txt_Nome_Cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nome_Cli.Location = New System.Drawing.Point(87, 48)
        Me.Txt_Nome_Cli.Name = "Txt_Nome_Cli"
        Me.Txt_Nome_Cli.Size = New System.Drawing.Size(482, 26)
        Me.Txt_Nome_Cli.SomenteNumero = False
        Me.Txt_Nome_Cli.TabIndex = 4
        '
        'txt_Compl
        '
        Me.txt_Compl.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Compl.EnviaTab = True
        Me.txt_Compl.Location = New System.Drawing.Point(668, 82)
        Me.txt_Compl.Name = "txt_Compl"
        Me.txt_Compl.Size = New System.Drawing.Size(242, 22)
        Me.txt_Compl.SomenteNumero = False
        Me.txt_Compl.TabIndex = 9
        '
        'Txt_ID
        '
        Me.Txt_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_ID.Enabled = False
        Me.Txt_ID.EnviaTab = True
        Me.Txt_ID.Location = New System.Drawing.Point(602, 2)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(57, 22)
        Me.Txt_ID.SomenteNumero = False
        Me.Txt_ID.TabIndex = 3
        '
        'txt_RG
        '
        Me.txt_RG.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_RG.EnviaTab = True
        Me.txt_RG.Location = New System.Drawing.Point(431, 2)
        Me.txt_RG.Name = "txt_RG"
        Me.txt_RG.Size = New System.Drawing.Size(138, 22)
        Me.txt_RG.SomenteNumero = False
        Me.txt_RG.TabIndex = 2
        '
        'txt_Nro
        '
        Me.txt_Nro.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Nro.EnviaTab = True
        Me.txt_Nro.Location = New System.Drawing.Point(601, 82)
        Me.txt_Nro.Name = "txt_Nro"
        Me.txt_Nro.Size = New System.Drawing.Size(61, 22)
        Me.txt_Nro.SomenteNumero = False
        Me.txt_Nro.TabIndex = 8
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'pic_Cliente
        '
        Me.pic_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Cliente.Location = New System.Drawing.Point(935, 4)
        Me.pic_Cliente.Name = "pic_Cliente"
        Me.pic_Cliente.Size = New System.Drawing.Size(160, 216)
        Me.pic_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Cliente.TabIndex = 36
        Me.pic_Cliente.TabStop = False
        Me.pic_Cliente.Visible = False
        '
        'frmFConsCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1166, 667)
        Me.Controls.Add(Me.pnDadosCliente)
        Me.Controls.Add(Me.dgResultado)
        Me.Controls.Add(Me.txtBusca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmFConsCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Cliente"
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDadosCliente.ResumeLayout(False)
        Me.pnDadosCliente.PerformLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBusca As Cls_Controls.Cls_TextBox
    Friend WithEvents dgResultado As Windows.Forms.DataGridView
    Friend WithEvents pnDadosCliente As Windows.Forms.Panel
    Friend WithEvents lbIdadeTutor As Windows.Forms.Label
    Friend WithEvents btnAlterar As Windows.Forms.Button
    Friend WithEvents btnIncluir As Windows.Forms.Button
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
    Friend WithEvents Txt_ID As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txt_RG As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txt_Nro As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents pic_Cliente As Windows.Forms.PictureBox
End Class
