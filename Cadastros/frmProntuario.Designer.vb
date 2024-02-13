<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProntuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProntuario))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmsListaFat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Detalhe_da_Venda_Zap = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsReceita = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Deletar_Item_Da_Receita = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDelReceita = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboTiposPesquisa = New Cls_Controls.Cls_ComboBox()
        Me.txt_Busca = New Cls_Controls.Cls_TextBoxOld()
        Me.DgGridTop = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbIdPet = New System.Windows.Forms.Label()
        Me.lbPet = New System.Windows.Forms.Label()
        Me.TbProntuario = New System.Windows.Forms.TabControl()
        Me.tbClientes = New System.Windows.Forms.TabPage()
        Me.btoAbreAnaminese = New System.Windows.Forms.Button()
        Me.btoFrmInternacao = New System.Windows.Forms.Button()
        Me.btoAgEstetica = New System.Windows.Forms.Button()
        Me.btoEnviar = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.pnDadosPaciente = New System.Windows.Forms.Panel()
        Me.ckCastrado = New System.Windows.Forms.CheckBox()
        Me.cboNomePet = New Cls_Controls.Cls_ComboBox()
        Me.lbIdade = New System.Windows.Forms.Label()
        Me.bto_Img_Pac = New System.Windows.Forms.Button()
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
        Me.pnDetalhe = New System.Windows.Forms.Panel()
        Me.TextBox1 = New Cls_Controls.Cls_TextBoxOld()
        Me.btoImprimir = New System.Windows.Forms.Button()
        Me.cboTermos = New Cls_Controls.Cls_ComboBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.pnDadosCliente = New System.Windows.Forms.Panel()
        Me.lbIdadeTutor = New System.Windows.Forms.Label()
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
        Me.TabVacina = New System.Windows.Forms.TabPage()
        Me.btoImpirmirVacina = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnIncluirVacina = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dgVacinasCadastradas = New System.Windows.Forms.DataGridView()
        Me.dgVacinasEfetuadas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ckTosse = New System.Windows.Forms.CheckBox()
        Me.mskTosse = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.mskAntR = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ckG2Dose = New System.Windows.Forms.CheckBox()
        Me.ckG1Dose = New System.Windows.Forms.CheckBox()
        Me.mskGiar2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskGiar1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ckV2Reforco = New System.Windows.Forms.CheckBox()
        Me.ckV1Reforco = New System.Windows.Forms.CheckBox()
        Me.ckV3Dose = New System.Windows.Forms.CheckBox()
        Me.ckV2Dose = New System.Windows.Forms.CheckBox()
        Me.ckV1Dose = New System.Windows.Forms.CheckBox()
        Me.ckPuppy = New System.Windows.Forms.CheckBox()
        Me.mskRefor2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskRefor1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskDose3 = New System.Windows.Forms.MaskedTextBox()
        Me.mskDose2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskDose1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskPuppy = New System.Windows.Forms.MaskedTextBox()
        Me.cboVacinas = New System.Windows.Forms.ComboBox()
        Me.pnLateralCliente = New System.Windows.Forms.Panel()
        Me.cmsListaFat.SuspendLayout()
        Me.cmsReceita.SuspendLayout()
        Me.cmsDelReceita.SuspendLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgGridTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TbProntuario.SuspendLayout()
        Me.tbClientes.SuspendLayout()
        Me.pnDadosPaciente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_Paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDetalhe.SuspendLayout()
        Me.pnDadosCliente.SuspendLayout()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVacina.SuspendLayout()
        CType(Me.dgVacinasCadastradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVacinasEfetuadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.pnLateralCliente.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ImageList1.Images.SetKeyName(5, "Cadastro.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Vacina.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Receita.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Consulta.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Imagens.jpg")
        Me.ImageList1.Images.SetKeyName(10, "printer_medicine_receipt_result_hospital_icon_188995.png")
        '
        'cmsListaFat
        '
        Me.cmsListaFat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsListaFat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.Detalhe_da_Venda_Zap})
        Me.cmsListaFat.Name = "cmsListaFat"
        Me.cmsListaFat.Size = New System.Drawing.Size(217, 52)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(216, 24)
        Me.ToolStripMenuItem1.Text = "Abrir Financeiro"
        '
        'Detalhe_da_Venda_Zap
        '
        Me.Detalhe_da_Venda_Zap.Name = "Detalhe_da_Venda_Zap"
        Me.Detalhe_da_Venda_Zap.Size = New System.Drawing.Size(216, 24)
        Me.Detalhe_da_Venda_Zap.Text = "Enviar pelo WatsApp"
        '
        'cmsReceita
        '
        Me.cmsReceita.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsReceita.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Deletar_Item_Da_Receita})
        Me.cmsReceita.Name = "cmsListaFat"
        Me.cmsReceita.Size = New System.Drawing.Size(262, 28)
        '
        'Deletar_Item_Da_Receita
        '
        Me.Deletar_Item_Da_Receita.Name = "Deletar_Item_Da_Receita"
        Me.Deletar_Item_Da_Receita.Size = New System.Drawing.Size(261, 24)
        Me.Deletar_Item_Da_Receita.Text = "Deletar Farmaco da Receita"
        '
        'cmsDelReceita
        '
        Me.cmsDelReceita.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDelReceita.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.cmsDelReceita.Name = "cmsListaFat"
        Me.cmsDelReceita.Size = New System.Drawing.Size(181, 28)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 24)
        Me.ToolStripMenuItem2.Text = "Deletar Receita"
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cboTiposPesquisa)
        Me.Panel2.Controls.Add(Me.txt_Busca)
        Me.Panel2.Controls.Add(Me.DgGridTop)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1625, 789)
        Me.Panel2.TabIndex = 38
        '
        'cboTiposPesquisa
        '
        Me.cboTiposPesquisa.EnviaTab = True
        Me.cboTiposPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTiposPesquisa.FormattingEnabled = True
        Me.cboTiposPesquisa.Location = New System.Drawing.Point(14, 13)
        Me.cboTiposPesquisa.Name = "cboTiposPesquisa"
        Me.cboTiposPesquisa.Size = New System.Drawing.Size(314, 28)
        Me.cboTiposPesquisa.TabIndex = 4
        '
        'txt_Busca
        '
        Me.txt_Busca.EnviaTab = True
        Me.txt_Busca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Busca.Location = New System.Drawing.Point(14, 49)
        Me.txt_Busca.Name = "txt_Busca"
        Me.txt_Busca.Size = New System.Drawing.Size(314, 26)
        Me.txt_Busca.SomenteNumero = False
        Me.txt_Busca.TabIndex = 3
        '
        'DgGridTop
        '
        Me.DgGridTop.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DgGridTop.AllowUserToAddRows = False
        Me.DgGridTop.AllowUserToDeleteRows = False
        Me.DgGridTop.AllowUserToOrderColumns = True
        Me.DgGridTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgGridTop.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.DgGridTop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgGridTop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgGridTop.ColumnHeadersHeight = 29
        Me.DgGridTop.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgGridTop.Location = New System.Drawing.Point(14, 92)
        Me.DgGridTop.MultiSelect = False
        Me.DgGridTop.Name = "DgGridTop"
        Me.DgGridTop.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgGridTop.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgGridTop.RowHeadersVisible = False
        Me.DgGridTop.RowHeadersWidth = 51
        Me.DgGridTop.RowTemplate.Height = 24
        Me.DgGridTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgGridTop.Size = New System.Drawing.Size(412, 663)
        Me.DgGridTop.StandardTab = True
        Me.DgGridTop.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.lbIdPet)
        Me.Panel1.Controls.Add(Me.lbPet)
        Me.Panel1.Controls.Add(Me.TbProntuario)
        Me.Panel1.Location = New System.Drawing.Point(432, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 787)
        Me.Panel1.TabIndex = 8
        '
        'lbIdPet
        '
        Me.lbIdPet.AutoSize = True
        Me.lbIdPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdPet.Location = New System.Drawing.Point(11, 0)
        Me.lbIdPet.Name = "lbIdPet"
        Me.lbIdPet.Size = New System.Drawing.Size(44, 25)
        Me.lbIdPet.TabIndex = 154
        Me.lbIdPet.Text = "Pet"
        '
        'lbPet
        '
        Me.lbPet.AutoSize = True
        Me.lbPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPet.Location = New System.Drawing.Point(85, 0)
        Me.lbPet.Name = "lbPet"
        Me.lbPet.Size = New System.Drawing.Size(44, 25)
        Me.lbPet.TabIndex = 153
        Me.lbPet.Text = "Pet"
        '
        'TbProntuario
        '
        Me.TbProntuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbProntuario.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TbProntuario.Controls.Add(Me.tbClientes)
        Me.TbProntuario.Controls.Add(Me.TabVacina)
        Me.TbProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProntuario.ImageList = Me.ImageList1
        Me.TbProntuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TbProntuario.Location = New System.Drawing.Point(3, 28)
        Me.TbProntuario.Name = "TbProntuario"
        Me.TbProntuario.SelectedIndex = 0
        Me.TbProntuario.Size = New System.Drawing.Size(1179, 745)
        Me.TbProntuario.TabIndex = 1
        '
        'tbClientes
        '
        Me.tbClientes.AutoScroll = True
        Me.tbClientes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbClientes.Controls.Add(Me.btoAbreAnaminese)
        Me.tbClientes.Controls.Add(Me.btoFrmInternacao)
        Me.tbClientes.Controls.Add(Me.btoAgEstetica)
        Me.tbClientes.Controls.Add(Me.btoEnviar)
        Me.tbClientes.Controls.Add(Me.Label43)
        Me.tbClientes.Controls.Add(Me.pnDadosPaciente)
        Me.tbClientes.Controls.Add(Me.pnDetalhe)
        Me.tbClientes.Controls.Add(Me.pnDadosCliente)
        Me.tbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClientes.ImageKey = "(nenhum/a)"
        Me.tbClientes.Location = New System.Drawing.Point(4, 28)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Padding = New System.Windows.Forms.Padding(6)
        Me.tbClientes.Size = New System.Drawing.Size(1171, 713)
        Me.tbClientes.TabIndex = 0
        Me.tbClientes.Text = "Clientes"
        '
        'btoAbreAnaminese
        '
        Me.btoAbreAnaminese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btoAbreAnaminese.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoAbreAnaminese.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btoAbreAnaminese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btoAbreAnaminese.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAbreAnaminese.Image = CType(resources.GetObject("btoAbreAnaminese.Image"), System.Drawing.Image)
        Me.btoAbreAnaminese.Location = New System.Drawing.Point(1070, 238)
        Me.btoAbreAnaminese.Name = "btoAbreAnaminese"
        Me.btoAbreAnaminese.Size = New System.Drawing.Size(69, 65)
        Me.btoAbreAnaminese.TabIndex = 231
        Me.btoAbreAnaminese.TabStop = False
        Me.btoAbreAnaminese.UseVisualStyleBackColor = True
        '
        'btoFrmInternacao
        '
        Me.btoFrmInternacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btoFrmInternacao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoFrmInternacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btoFrmInternacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btoFrmInternacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFrmInternacao.Image = CType(resources.GetObject("btoFrmInternacao.Image"), System.Drawing.Image)
        Me.btoFrmInternacao.Location = New System.Drawing.Point(1070, 311)
        Me.btoFrmInternacao.Name = "btoFrmInternacao"
        Me.btoFrmInternacao.Size = New System.Drawing.Size(69, 65)
        Me.btoFrmInternacao.TabIndex = 227
        Me.btoFrmInternacao.UseVisualStyleBackColor = True
        '
        'btoAgEstetica
        '
        Me.btoAgEstetica.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoAgEstetica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btoAgEstetica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btoAgEstetica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgEstetica.Image = CType(resources.GetObject("btoAgEstetica.Image"), System.Drawing.Image)
        Me.btoAgEstetica.Location = New System.Drawing.Point(932, 311)
        Me.btoAgEstetica.Name = "btoAgEstetica"
        Me.btoAgEstetica.Size = New System.Drawing.Size(69, 65)
        Me.btoAgEstetica.TabIndex = 225
        Me.btoAgEstetica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoAgEstetica.UseVisualStyleBackColor = True
        '
        'btoEnviar
        '
        Me.btoEnviar.Image = Global.Cadastros.My.Resources.Resources.watts
        Me.btoEnviar.Location = New System.Drawing.Point(932, 240)
        Me.btoEnviar.Name = "btoEnviar"
        Me.btoEnviar.Size = New System.Drawing.Size(69, 65)
        Me.btoEnviar.TabIndex = 8
        Me.btoEnviar.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(15, 681)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(751, 17)
        Me.Label43.TabIndex = 8
        Me.Label43.Text = "F2 = Financeiro ; F4 = Débitos do Cliente ; F5 = Novo Cliente; F6 = Extrato Finan" &
    "ceiro; F7 = Ag. Banho"
        '
        'pnDadosPaciente
        '
        Me.pnDadosPaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnDadosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDadosPaciente.Controls.Add(Me.ckCastrado)
        Me.pnDadosPaciente.Controls.Add(Me.cboNomePet)
        Me.pnDadosPaciente.Controls.Add(Me.lbIdade)
        Me.pnDadosPaciente.Controls.Add(Me.bto_Img_Pac)
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
        Me.pnDadosPaciente.Location = New System.Drawing.Point(14, 450)
        Me.pnDadosPaciente.Name = "pnDadosPaciente"
        Me.pnDadosPaciente.Size = New System.Drawing.Size(1146, 228)
        Me.pnDadosPaciente.TabIndex = 0
        '
        'ckCastrado
        '
        Me.ckCastrado.AutoSize = True
        Me.ckCastrado.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckCastrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCastrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ckCastrado.Location = New System.Drawing.Point(86, 164)
        Me.ckCastrado.Name = "ckCastrado"
        Me.ckCastrado.Size = New System.Drawing.Size(107, 24)
        Me.ckCastrado.TabIndex = 49
        Me.ckCastrado.Text = "Castrado"
        Me.ckCastrado.UseVisualStyleBackColor = True
        '
        'cboNomePet
        '
        Me.cboNomePet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNomePet.EnviaTab = True
        Me.cboNomePet.FormattingEnabled = True
        Me.cboNomePet.Location = New System.Drawing.Point(111, 3)
        Me.cboNomePet.Name = "cboNomePet"
        Me.cboNomePet.Size = New System.Drawing.Size(77, 24)
        Me.cboNomePet.TabIndex = 48
        Me.cboNomePet.Visible = False
        '
        'lbIdade
        '
        Me.lbIdade.AutoSize = True
        Me.lbIdade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbIdade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdade.Location = New System.Drawing.Point(479, 83)
        Me.lbIdade.Name = "lbIdade"
        Me.lbIdade.Size = New System.Drawing.Size(61, 25)
        Me.lbIdade.TabIndex = 47
        Me.lbIdade.Text = "Idade"
        '
        'bto_Img_Pac
        '
        Me.bto_Img_Pac.Cursor = System.Windows.Forms.Cursors.Default
        Me.bto_Img_Pac.FlatAppearance.BorderSize = 0
        Me.bto_Img_Pac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bto_Img_Pac.Image = CType(resources.GetObject("bto_Img_Pac.Image"), System.Drawing.Image)
        Me.bto_Img_Pac.Location = New System.Drawing.Point(908, 160)
        Me.bto_Img_Pac.Name = "bto_Img_Pac"
        Me.bto_Img_Pac.Size = New System.Drawing.Size(65, 58)
        Me.bto_Img_Pac.TabIndex = 13
        Me.bto_Img_Pac.UseVisualStyleBackColor = True
        '
        'btoAlterarPaciente
        '
        Me.btoAlterarPaciente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btoAlterarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAlterarPaciente.Location = New System.Drawing.Point(329, 194)
        Me.btoAlterarPaciente.Name = "btoAlterarPaciente"
        Me.btoAlterarPaciente.Size = New System.Drawing.Size(135, 29)
        Me.btoAlterarPaciente.TabIndex = 12
        Me.btoAlterarPaciente.Text = "Alterar"
        Me.btoAlterarPaciente.UseVisualStyleBackColor = True
        '
        'btoGravaPaciente
        '
        Me.btoGravaPaciente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btoGravaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoGravaPaciente.Location = New System.Drawing.Point(86, 194)
        Me.btoGravaPaciente.Name = "btoGravaPaciente"
        Me.btoGravaPaciente.Size = New System.Drawing.Size(135, 29)
        Me.btoGravaPaciente.TabIndex = 11
        Me.btoGravaPaciente.Text = "Incluir"
        Me.btoGravaPaciente.UseVisualStyleBackColor = True
        '
        'Txt_Obs
        '
        Me.Txt_Obs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Obs.EnviaTab = True
        Me.Txt_Obs.Location = New System.Drawing.Point(329, 134)
        Me.Txt_Obs.Multiline = True
        Me.Txt_Obs.Name = "Txt_Obs"
        Me.Txt_Obs.Size = New System.Drawing.Size(402, 48)
        Me.Txt_Obs.SomenteNumero = False
        Me.Txt_Obs.TabIndex = 12
        '
        'Txt_Chip
        '
        Me.Txt_Chip.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Chip.EnviaTab = True
        Me.Txt_Chip.Location = New System.Drawing.Point(86, 131)
        Me.Txt_Chip.Name = "Txt_Chip"
        Me.Txt_Chip.Size = New System.Drawing.Size(199, 23)
        Me.Txt_Chip.SomenteNumero = False
        Me.Txt_Chip.TabIndex = 11
        '
        'Txt_Pedigree
        '
        Me.Txt_Pedigree.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Pedigree.EnviaTab = True
        Me.Txt_Pedigree.Location = New System.Drawing.Point(808, 131)
        Me.Txt_Pedigree.Name = "Txt_Pedigree"
        Me.Txt_Pedigree.Size = New System.Drawing.Size(142, 23)
        Me.Txt_Pedigree.SomenteNumero = False
        Me.Txt_Pedigree.TabIndex = 8
        Me.Txt_Pedigree.Text = "10"
        '
        'Txt_DtNasAni
        '
        Me.Txt_DtNasAni.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_DtNasAni.EnviaTab = True
        Me.Txt_DtNasAni.Location = New System.Drawing.Point(351, 87)
        Me.Txt_DtNasAni.Name = "Txt_DtNasAni"
        Me.Txt_DtNasAni.Size = New System.Drawing.Size(122, 23)
        Me.Txt_DtNasAni.SomenteNumero = True
        Me.Txt_DtNasAni.TabIndex = 8
        '
        'cboConvenio
        '
        Me.cboConvenio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboConvenio.EnviaTab = True
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(816, 83)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(137, 24)
        Me.cboConvenio.TabIndex = 7
        '
        'CboPelo
        '
        Me.CboPelo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboPelo.EnviaTab = True
        Me.CboPelo.FormattingEnabled = True
        Me.CboPelo.Location = New System.Drawing.Point(816, 48)
        Me.CboPelo.Name = "CboPelo"
        Me.CboPelo.Size = New System.Drawing.Size(134, 24)
        Me.CboPelo.TabIndex = 6
        '
        'CboPorte
        '
        Me.CboPorte.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboPorte.EnviaTab = True
        Me.CboPorte.FormattingEnabled = True
        Me.CboPorte.Location = New System.Drawing.Point(609, 48)
        Me.CboPorte.Name = "CboPorte"
        Me.CboPorte.Size = New System.Drawing.Size(150, 24)
        Me.CboPorte.TabIndex = 5
        '
        'CboCor
        '
        Me.CboCor.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboCor.EnviaTab = True
        Me.CboCor.FormattingEnabled = True
        Me.CboCor.Location = New System.Drawing.Point(351, 46)
        Me.CboCor.Name = "CboCor"
        Me.CboCor.Size = New System.Drawing.Size(187, 24)
        Me.CboCor.TabIndex = 4
        '
        'CboRaca
        '
        Me.CboRaca.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboRaca.EnviaTab = True
        Me.CboRaca.FormattingEnabled = True
        Me.CboRaca.Location = New System.Drawing.Point(75, 48)
        Me.CboRaca.Name = "CboRaca"
        Me.CboRaca.Size = New System.Drawing.Size(235, 24)
        Me.CboRaca.TabIndex = 3
        '
        'txt_Id_Paciente
        '
        Me.txt_Id_Paciente.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Id_Paciente.Enabled = False
        Me.txt_Id_Paciente.EnviaTab = False
        Me.txt_Id_Paciente.Location = New System.Drawing.Point(481, 13)
        Me.txt_Id_Paciente.Name = "txt_Id_Paciente"
        Me.txt_Id_Paciente.Size = New System.Drawing.Size(57, 23)
        Me.txt_Id_Paciente.SomenteNumero = False
        Me.txt_Id_Paciente.TabIndex = 1
        '
        'Txt_Nome_Ani
        '
        Me.Txt_Nome_Ani.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txt_Nome_Ani.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Nome_Ani.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Nome_Ani.EnviaTab = True
        Me.Txt_Nome_Ani.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nome_Ani.Location = New System.Drawing.Point(81, 13)
        Me.Txt_Nome_Ani.Name = "Txt_Nome_Ani"
        Me.Txt_Nome_Ani.Size = New System.Drawing.Size(350, 26)
        Me.Txt_Nome_Ani.SomenteNumero = False
        Me.Txt_Nome_Ani.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbFemea)
        Me.GroupBox2.Controls.Add(Me.rbMacho)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox2.Location = New System.Drawing.Point(16, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 34)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'rbFemea
        '
        Me.rbFemea.AutoSize = True
        Me.rbFemea.ForeColor = System.Drawing.Color.Fuchsia
        Me.rbFemea.Location = New System.Drawing.Point(164, 11)
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
        Me.rbMacho.BackColor = System.Drawing.Color.Transparent
        Me.rbMacho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbMacho.Location = New System.Drawing.Point(59, 11)
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
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Location = New System.Drawing.Point(290, 137)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 17)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "OBS."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Location = New System.Drawing.Point(43, 134)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 17)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Chip"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Location = New System.Drawing.Point(737, 131)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Pedigree"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Location = New System.Drawing.Point(284, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 17)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Dt.Nasc."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Location = New System.Drawing.Point(743, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 17)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Convenio"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Location = New System.Drawing.Point(774, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 17)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Pelo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Location = New System.Drawing.Point(562, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 17)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Porte"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Location = New System.Drawing.Point(316, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 17)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Cor"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Location = New System.Drawing.Point(24, 46)
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
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.Location = New System.Drawing.Point(565, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 34)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Espécie"
        '
        'rb_Outros
        '
        Me.rb_Outros.AutoSize = True
        Me.rb_Outros.Location = New System.Drawing.Point(250, 11)
        Me.rb_Outros.Name = "rb_Outros"
        Me.rb_Outros.Size = New System.Drawing.Size(72, 21)
        Me.rb_Outros.TabIndex = 4
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
        Me.rb_Felino.TabIndex = 3
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
        Me.rb_Canino.TabIndex = 2
        Me.rb_Canino.TabStop = True
        Me.rb_Canino.Text = "Canina"
        Me.rb_Canino.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Location = New System.Drawing.Point(30, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 17)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nome"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Location = New System.Drawing.Point(454, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 17)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "ID"
        '
        'pic_Paciente
        '
        Me.pic_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Paciente.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_Paciente.Location = New System.Drawing.Point(979, 7)
        Me.pic_Paciente.Name = "pic_Paciente"
        Me.pic_Paciente.Size = New System.Drawing.Size(160, 216)
        Me.pic_Paciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Paciente.TabIndex = 32
        Me.pic_Paciente.TabStop = False
        '
        'pnDetalhe
        '
        Me.pnDetalhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnDetalhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDetalhe.Controls.Add(Me.TextBox1)
        Me.pnDetalhe.Controls.Add(Me.btoImprimir)
        Me.pnDetalhe.Controls.Add(Me.cboTermos)
        Me.pnDetalhe.Controls.Add(Me.TreeView1)
        Me.pnDetalhe.ForeColor = System.Drawing.Color.Black
        Me.pnDetalhe.Location = New System.Drawing.Point(14, 240)
        Me.pnDetalhe.Name = "pnDetalhe"
        Me.pnDetalhe.Size = New System.Drawing.Size(888, 196)
        Me.pnDetalhe.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Enabled = False
        Me.TextBox1.EnviaTab = False
        Me.TextBox1.Location = New System.Drawing.Point(764, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 23)
        Me.TextBox1.SomenteNumero = False
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.Visible = False
        '
        'btoImprimir
        '
        Me.btoImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btoImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btoImprimir.Image = Global.Cadastros.My.Resources.Resources.printer_medicine_receipt_result_hospital_icon_188995
        Me.btoImprimir.Location = New System.Drawing.Point(764, 110)
        Me.btoImprimir.Name = "btoImprimir"
        Me.btoImprimir.Size = New System.Drawing.Size(65, 55)
        Me.btoImprimir.TabIndex = 40
        Me.btoImprimir.UseVisualStyleBackColor = False
        '
        'cboTermos
        '
        Me.cboTermos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTermos.EnviaTab = True
        Me.cboTermos.FormattingEnabled = True
        Me.cboTermos.Location = New System.Drawing.Point(715, 49)
        Me.cboTermos.Name = "cboTermos"
        Me.cboTermos.Size = New System.Drawing.Size(156, 24)
        Me.cboTermos.TabIndex = 39
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.cmsListaFat
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeView1.Location = New System.Drawing.Point(3, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(706, 177)
        Me.TreeView1.TabIndex = 0
        '
        'pnDadosCliente
        '
        Me.pnDadosCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnDadosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnDadosCliente.Controls.Add(Me.lbIdadeTutor)
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
        Me.pnDadosCliente.Location = New System.Drawing.Point(14, 6)
        Me.pnDadosCliente.Name = "pnDadosCliente"
        Me.pnDadosCliente.Size = New System.Drawing.Size(1146, 228)
        Me.pnDadosCliente.TabIndex = 5
        '
        'lbIdadeTutor
        '
        Me.lbIdadeTutor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbIdadeTutor.AutoSize = True
        Me.lbIdadeTutor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbIdadeTutor.Location = New System.Drawing.Point(242, 143)
        Me.lbIdadeTutor.Name = "lbIdadeTutor"
        Me.lbIdadeTutor.Size = New System.Drawing.Size(43, 17)
        Me.lbIdadeTutor.TabIndex = 35
        Me.lbIdadeTutor.Text = "Idade"
        '
        'bto_Img_Cli
        '
        Me.bto_Img_Cli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bto_Img_Cli.Cursor = System.Windows.Forms.Cursors.Default
        Me.bto_Img_Cli.FlatAppearance.BorderSize = 0
        Me.bto_Img_Cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bto_Img_Cli.Image = CType(resources.GetObject("bto_Img_Cli.Image"), System.Drawing.Image)
        Me.bto_Img_Cli.Location = New System.Drawing.Point(908, 153)
        Me.bto_Img_Cli.Name = "bto_Img_Cli"
        Me.bto_Img_Cli.Size = New System.Drawing.Size(65, 58)
        Me.bto_Img_Cli.TabIndex = 34
        Me.bto_Img_Cli.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Location = New System.Drawing.Point(663, 187)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(135, 29)
        Me.btnAlterar.TabIndex = 33
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'pic_Cliente
        '
        Me.pic_Cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Cliente.Location = New System.Drawing.Point(979, 6)
        Me.pic_Cliente.Name = "pic_Cliente"
        Me.pic_Cliente.Size = New System.Drawing.Size(160, 216)
        Me.pic_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Cliente.TabIndex = 31
        Me.pic_Cliente.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txt_Cidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Cidade.EnviaTab = True
        Me.txt_Cidade.Location = New System.Drawing.Point(481, 110)
        Me.txt_Cidade.Name = "txt_Cidade"
        Me.txt_Cidade.Size = New System.Drawing.Size(243, 23)
        Me.txt_Cidade.SomenteNumero = False
        Me.txt_Cidade.TabIndex = 11
        '
        'cbo_UF
        '
        Me.cbo_UF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txt_Fone2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Fone2.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Fone2.EnviaTab = True
        Me.txt_Fone2.Location = New System.Drawing.Point(245, 171)
        Me.txt_Fone2.Name = "txt_Fone2"
        Me.txt_Fone2.Size = New System.Drawing.Size(148, 23)
        Me.txt_Fone2.SomenteNumero = False
        Me.txt_Fone2.TabIndex = 15
        '
        'txt_Fone1
        '
        Me.txt_Fone1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Fone1.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Fone1.EnviaTab = True
        Me.txt_Fone1.Location = New System.Drawing.Point(87, 171)
        Me.txt_Fone1.Name = "txt_Fone1"
        Me.txt_Fone1.Size = New System.Drawing.Size(148, 23)
        Me.txt_Fone1.SomenteNumero = False
        Me.txt_Fone1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.cbo_Bairro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Cbo_Endereco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Txt_CEP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_CEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_CEP.EnviaTab = True
        Me.Txt_CEP.Location = New System.Drawing.Point(88, 82)
        Me.Txt_CEP.Name = "Txt_CEP"
        Me.Txt_CEP.Size = New System.Drawing.Size(100, 23)
        Me.Txt_CEP.SomenteNumero = False
        Me.Txt_CEP.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txt_DtNas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DtNas.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_DtNas.EnviaTab = True
        Me.txt_DtNas.Location = New System.Drawing.Point(87, 143)
        Me.txt_DtNas.Name = "txt_DtNas"
        Me.txt_DtNas.Size = New System.Drawing.Size(113, 23)
        Me.txt_DtNas.SomenteNumero = True
        Me.txt_DtNas.TabIndex = 13
        '
        'Txt_CPF_CNPJ
        '
        Me.Txt_CPF_CNPJ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_CPF_CNPJ.CpfValido = True
        Me.Txt_CPF_CNPJ.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_CPF_CNPJ.EnviaTab = True
        Me.Txt_CPF_CNPJ.ExibirMensagem = False
        Me.Txt_CPF_CNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CPF_CNPJ.Location = New System.Drawing.Point(208, 4)
        Me.Txt_CPF_CNPJ.MaxLength = 18
        Me.Txt_CPF_CNPJ.Name = "Txt_CPF_CNPJ"
        Me.Txt_CPF_CNPJ.Size = New System.Drawing.Size(163, 26)
        Me.Txt_CPF_CNPJ.SomenteNumero = True
        Me.Txt_CPF_CNPJ.TabIndex = 1
        Me.Txt_CPF_CNPJ.ValidaCNPJ = True
        Me.Txt_CPF_CNPJ.ValidaCPF = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.chkFJ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Txt_Contato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Contato.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_Contato.EnviaTab = True
        Me.Txt_Contato.Location = New System.Drawing.Point(667, 50)
        Me.Txt_Contato.Name = "Txt_Contato"
        Me.Txt_Contato.Size = New System.Drawing.Size(243, 23)
        Me.Txt_Contato.SomenteNumero = False
        Me.Txt_Contato.TabIndex = 5
        '
        'txt_Email
        '
        Me.txt_Email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Email.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Email.EnviaTab = True
        Me.txt_Email.Location = New System.Drawing.Point(88, 199)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(395, 23)
        Me.txt_Email.SomenteNumero = False
        Me.txt_Email.TabIndex = 16
        '
        'Txt_Nome_Cli
        '
        Me.Txt_Nome_Cli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txt_Compl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Compl.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Compl.EnviaTab = True
        Me.txt_Compl.Location = New System.Drawing.Point(668, 82)
        Me.txt_Compl.Name = "txt_Compl"
        Me.txt_Compl.Size = New System.Drawing.Size(242, 23)
        Me.txt_Compl.SomenteNumero = False
        Me.txt_Compl.TabIndex = 9
        '
        'Txt_ID
        '
        Me.Txt_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_ID.Enabled = False
        Me.Txt_ID.EnviaTab = True
        Me.Txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ID.Location = New System.Drawing.Point(602, 2)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(75, 26)
        Me.Txt_ID.SomenteNumero = False
        Me.Txt_ID.TabIndex = 3
        '
        'txt_RG
        '
        Me.txt_RG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RG.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_RG.EnviaTab = True
        Me.txt_RG.Location = New System.Drawing.Point(431, 2)
        Me.txt_RG.Name = "txt_RG"
        Me.txt_RG.Size = New System.Drawing.Size(138, 23)
        Me.txt_RG.SomenteNumero = False
        Me.txt_RG.TabIndex = 2
        '
        'txt_Nro
        '
        Me.txt_Nro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nro.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_Nro.EnviaTab = True
        Me.txt_Nro.Location = New System.Drawing.Point(601, 82)
        Me.txt_Nro.Name = "txt_Nro"
        Me.txt_Nro.Size = New System.Drawing.Size(61, 23)
        Me.txt_Nro.SomenteNumero = False
        Me.txt_Nro.TabIndex = 8
        '
        'TabVacina
        '
        Me.TabVacina.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabVacina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabVacina.Controls.Add(Me.btoImpirmirVacina)
        Me.TabVacina.Controls.Add(Me.Label40)
        Me.TabVacina.Controls.Add(Me.btnIncluirVacina)
        Me.TabVacina.Controls.Add(Me.Label41)
        Me.TabVacina.Controls.Add(Me.dgVacinasCadastradas)
        Me.TabVacina.Controls.Add(Me.dgVacinasEfetuadas)
        Me.TabVacina.Controls.Add(Me.GroupBox3)
        Me.TabVacina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabVacina.ImageKey = "(nenhum/a)"
        Me.TabVacina.Location = New System.Drawing.Point(4, 28)
        Me.TabVacina.Name = "TabVacina"
        Me.TabVacina.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVacina.Size = New System.Drawing.Size(1171, 713)
        Me.TabVacina.TabIndex = 3
        Me.TabVacina.Text = "Vacina"
        '
        'btoImpirmirVacina
        '
        Me.btoImpirmirVacina.Enabled = False
        Me.btoImpirmirVacina.Image = Global.Cadastros.My.Resources.Resources.printer_medicine_receipt_result_hospital_icon_188995
        Me.btoImpirmirVacina.Location = New System.Drawing.Point(1035, 650)
        Me.btoImpirmirVacina.Name = "btoImpirmirVacina"
        Me.btoImpirmirVacina.Size = New System.Drawing.Size(55, 46)
        Me.btoImpirmirVacina.TabIndex = 57
        Me.btoImpirmirVacina.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(314, 257)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(44, 17)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "Plano"
        '
        'btnIncluirVacina
        '
        Me.btnIncluirVacina.Location = New System.Drawing.Point(73, 650)
        Me.btnIncluirVacina.Name = "btnIncluirVacina"
        Me.btnIncluirVacina.Size = New System.Drawing.Size(285, 38)
        Me.btnIncluirVacina.TabIndex = 2
        Me.btnIncluirVacina.Text = "Cadastrar"
        Me.btnIncluirVacina.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(805, 257)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 17)
        Me.Label41.TabIndex = 53
        Me.Label41.Text = "Efetuadas"
        '
        'dgVacinasCadastradas
        '
        Me.dgVacinasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVacinasCadastradas.Location = New System.Drawing.Point(73, 277)
        Me.dgVacinasCadastradas.Name = "dgVacinasCadastradas"
        Me.dgVacinasCadastradas.RowHeadersWidth = 51
        Me.dgVacinasCadastradas.RowTemplate.Height = 24
        Me.dgVacinasCadastradas.Size = New System.Drawing.Size(540, 358)
        Me.dgVacinasCadastradas.TabIndex = 0
        '
        'dgVacinasEfetuadas
        '
        Me.dgVacinasEfetuadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVacinasEfetuadas.Location = New System.Drawing.Point(621, 277)
        Me.dgVacinasEfetuadas.Name = "dgVacinasEfetuadas"
        Me.dgVacinasEfetuadas.RowHeadersWidth = 51
        Me.dgVacinasEfetuadas.RowTemplate.Height = 24
        Me.dgVacinasEfetuadas.Size = New System.Drawing.Size(469, 358)
        Me.dgVacinasEfetuadas.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.cboVacinas)
        Me.GroupBox3.Location = New System.Drawing.Point(73, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1017, 248)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Plano de Vacina"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ckTosse)
        Me.GroupBox5.Controls.Add(Me.mskTosse)
        Me.GroupBox5.Location = New System.Drawing.Point(758, 126)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(231, 68)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tosse"
        '
        'ckTosse
        '
        Me.ckTosse.AutoSize = True
        Me.ckTosse.Checked = True
        Me.ckTosse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckTosse.Location = New System.Drawing.Point(29, 25)
        Me.ckTosse.Name = "ckTosse"
        Me.ckTosse.Size = New System.Drawing.Size(63, 21)
        Me.ckTosse.TabIndex = 0
        Me.ckTosse.Text = "Dose"
        Me.ckTosse.UseVisualStyleBackColor = True
        '
        'mskTosse
        '
        Me.mskTosse.BackColor = System.Drawing.Color.White
        Me.mskTosse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskTosse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTosse.ForeColor = System.Drawing.Color.Black
        Me.mskTosse.Location = New System.Drawing.Point(132, 21)
        Me.mskTosse.Mask = "00/00/0000"
        Me.mskTosse.Name = "mskTosse"
        Me.mskTosse.Size = New System.Drawing.Size(96, 26)
        Me.mskTosse.TabIndex = 1
        Me.mskTosse.ValidatingType = GetType(Date)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.mskAntR)
        Me.GroupBox4.Location = New System.Drawing.Point(758, 52)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 68)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Anti-Rábica"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(26, 29)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(41, 17)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Dose"
        '
        'mskAntR
        '
        Me.mskAntR.BackColor = System.Drawing.Color.White
        Me.mskAntR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskAntR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskAntR.ForeColor = System.Drawing.Color.Black
        Me.mskAntR.Location = New System.Drawing.Point(132, 23)
        Me.mskAntR.Mask = "00/00/0000"
        Me.mskAntR.Name = "mskAntR"
        Me.mskAntR.Size = New System.Drawing.Size(96, 26)
        Me.mskAntR.TabIndex = 1
        Me.mskAntR.ValidatingType = GetType(Date)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ckG2Dose)
        Me.GroupBox6.Controls.Add(Me.ckG1Dose)
        Me.GroupBox6.Controls.Add(Me.mskGiar2)
        Me.GroupBox6.Controls.Add(Me.mskGiar1)
        Me.GroupBox6.Location = New System.Drawing.Point(497, 52)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(231, 142)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Giardiase"
        '
        'ckG2Dose
        '
        Me.ckG2Dose.AutoSize = True
        Me.ckG2Dose.Checked = True
        Me.ckG2Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckG2Dose.Location = New System.Drawing.Point(27, 96)
        Me.ckG2Dose.Name = "ckG2Dose"
        Me.ckG2Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckG2Dose.TabIndex = 2
        Me.ckG2Dose.Text = "2 Dose"
        Me.ckG2Dose.UseVisualStyleBackColor = True
        '
        'ckG1Dose
        '
        Me.ckG1Dose.AutoSize = True
        Me.ckG1Dose.Checked = True
        Me.ckG1Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckG1Dose.Location = New System.Drawing.Point(27, 27)
        Me.ckG1Dose.Name = "ckG1Dose"
        Me.ckG1Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckG1Dose.TabIndex = 0
        Me.ckG1Dose.Text = "1 Dose"
        Me.ckG1Dose.UseVisualStyleBackColor = True
        '
        'mskGiar2
        '
        Me.mskGiar2.BackColor = System.Drawing.Color.White
        Me.mskGiar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskGiar2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskGiar2.ForeColor = System.Drawing.Color.Black
        Me.mskGiar2.Location = New System.Drawing.Point(121, 94)
        Me.mskGiar2.Mask = "00/00/0000"
        Me.mskGiar2.Name = "mskGiar2"
        Me.mskGiar2.Size = New System.Drawing.Size(96, 26)
        Me.mskGiar2.TabIndex = 3
        Me.mskGiar2.ValidatingType = GetType(Date)
        '
        'mskGiar1
        '
        Me.mskGiar1.BackColor = System.Drawing.Color.White
        Me.mskGiar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskGiar1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskGiar1.ForeColor = System.Drawing.Color.Black
        Me.mskGiar1.Location = New System.Drawing.Point(121, 25)
        Me.mskGiar1.Mask = "00/00/0000"
        Me.mskGiar1.Name = "mskGiar1"
        Me.mskGiar1.Size = New System.Drawing.Size(96, 26)
        Me.mskGiar1.TabIndex = 1
        Me.mskGiar1.ValidatingType = GetType(Date)
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ckV2Reforco)
        Me.GroupBox7.Controls.Add(Me.ckV1Reforco)
        Me.GroupBox7.Controls.Add(Me.ckV3Dose)
        Me.GroupBox7.Controls.Add(Me.ckV2Dose)
        Me.GroupBox7.Controls.Add(Me.ckV1Dose)
        Me.GroupBox7.Controls.Add(Me.ckPuppy)
        Me.GroupBox7.Controls.Add(Me.mskRefor2)
        Me.GroupBox7.Controls.Add(Me.mskRefor1)
        Me.GroupBox7.Controls.Add(Me.mskDose3)
        Me.GroupBox7.Controls.Add(Me.mskDose2)
        Me.GroupBox7.Controls.Add(Me.mskDose1)
        Me.GroupBox7.Controls.Add(Me.mskPuppy)
        Me.GroupBox7.Location = New System.Drawing.Point(20, 52)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(462, 186)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Vacinas"
        '
        'ckV2Reforco
        '
        Me.ckV2Reforco.AutoSize = True
        Me.ckV2Reforco.Checked = True
        Me.ckV2Reforco.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV2Reforco.Location = New System.Drawing.Point(233, 68)
        Me.ckV2Reforco.Name = "ckV2Reforco"
        Me.ckV2Reforco.Size = New System.Drawing.Size(92, 21)
        Me.ckV2Reforco.TabIndex = 10
        Me.ckV2Reforco.Text = "2 Reforço"
        Me.ckV2Reforco.UseVisualStyleBackColor = True
        '
        'ckV1Reforco
        '
        Me.ckV1Reforco.AutoSize = True
        Me.ckV1Reforco.Checked = True
        Me.ckV1Reforco.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV1Reforco.Location = New System.Drawing.Point(233, 27)
        Me.ckV1Reforco.Name = "ckV1Reforco"
        Me.ckV1Reforco.Size = New System.Drawing.Size(92, 21)
        Me.ckV1Reforco.TabIndex = 8
        Me.ckV1Reforco.Text = "1 Reforço"
        Me.ckV1Reforco.UseVisualStyleBackColor = True
        '
        'ckV3Dose
        '
        Me.ckV3Dose.AutoSize = True
        Me.ckV3Dose.Checked = True
        Me.ckV3Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV3Dose.Location = New System.Drawing.Point(22, 141)
        Me.ckV3Dose.Name = "ckV3Dose"
        Me.ckV3Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckV3Dose.TabIndex = 6
        Me.ckV3Dose.Text = "3 Dose"
        Me.ckV3Dose.UseVisualStyleBackColor = True
        '
        'ckV2Dose
        '
        Me.ckV2Dose.AutoSize = True
        Me.ckV2Dose.Checked = True
        Me.ckV2Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV2Dose.Location = New System.Drawing.Point(22, 101)
        Me.ckV2Dose.Name = "ckV2Dose"
        Me.ckV2Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckV2Dose.TabIndex = 4
        Me.ckV2Dose.Text = "2 Dose"
        Me.ckV2Dose.UseVisualStyleBackColor = True
        '
        'ckV1Dose
        '
        Me.ckV1Dose.AccessibleDescription = ""
        Me.ckV1Dose.AutoSize = True
        Me.ckV1Dose.Checked = True
        Me.ckV1Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV1Dose.Location = New System.Drawing.Point(22, 68)
        Me.ckV1Dose.Name = "ckV1Dose"
        Me.ckV1Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckV1Dose.TabIndex = 2
        Me.ckV1Dose.Text = "1 Dose"
        Me.ckV1Dose.UseVisualStyleBackColor = True
        '
        'ckPuppy
        '
        Me.ckPuppy.AutoSize = True
        Me.ckPuppy.Checked = True
        Me.ckPuppy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPuppy.Location = New System.Drawing.Point(22, 28)
        Me.ckPuppy.Name = "ckPuppy"
        Me.ckPuppy.Size = New System.Drawing.Size(70, 21)
        Me.ckPuppy.TabIndex = 0
        Me.ckPuppy.Text = "Puppy"
        Me.ckPuppy.UseVisualStyleBackColor = True
        '
        'mskRefor2
        '
        Me.mskRefor2.BackColor = System.Drawing.Color.White
        Me.mskRefor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskRefor2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRefor2.ForeColor = System.Drawing.Color.Black
        Me.mskRefor2.Location = New System.Drawing.Point(347, 68)
        Me.mskRefor2.Mask = "00/00/0000"
        Me.mskRefor2.Name = "mskRefor2"
        Me.mskRefor2.Size = New System.Drawing.Size(96, 26)
        Me.mskRefor2.TabIndex = 11
        Me.mskRefor2.ValidatingType = GetType(Date)
        '
        'mskRefor1
        '
        Me.mskRefor1.BackColor = System.Drawing.Color.White
        Me.mskRefor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskRefor1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRefor1.ForeColor = System.Drawing.Color.Black
        Me.mskRefor1.Location = New System.Drawing.Point(347, 23)
        Me.mskRefor1.Mask = "00/00/0000"
        Me.mskRefor1.Name = "mskRefor1"
        Me.mskRefor1.Size = New System.Drawing.Size(96, 26)
        Me.mskRefor1.TabIndex = 9
        Me.mskRefor1.ValidatingType = GetType(Date)
        '
        'mskDose3
        '
        Me.mskDose3.BackColor = System.Drawing.Color.White
        Me.mskDose3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDose3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDose3.ForeColor = System.Drawing.Color.Black
        Me.mskDose3.Location = New System.Drawing.Point(131, 137)
        Me.mskDose3.Mask = "00/00/0000"
        Me.mskDose3.Name = "mskDose3"
        Me.mskDose3.Size = New System.Drawing.Size(96, 26)
        Me.mskDose3.TabIndex = 7
        Me.mskDose3.ValidatingType = GetType(Date)
        '
        'mskDose2
        '
        Me.mskDose2.BackColor = System.Drawing.Color.White
        Me.mskDose2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDose2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDose2.ForeColor = System.Drawing.Color.Black
        Me.mskDose2.Location = New System.Drawing.Point(131, 97)
        Me.mskDose2.Mask = "00/00/0000"
        Me.mskDose2.Name = "mskDose2"
        Me.mskDose2.Size = New System.Drawing.Size(96, 26)
        Me.mskDose2.TabIndex = 5
        Me.mskDose2.ValidatingType = GetType(Date)
        '
        'mskDose1
        '
        Me.mskDose1.BackColor = System.Drawing.Color.White
        Me.mskDose1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDose1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDose1.ForeColor = System.Drawing.Color.Black
        Me.mskDose1.Location = New System.Drawing.Point(131, 61)
        Me.mskDose1.Mask = "00/00/0000"
        Me.mskDose1.Name = "mskDose1"
        Me.mskDose1.Size = New System.Drawing.Size(96, 26)
        Me.mskDose1.TabIndex = 3
        Me.mskDose1.ValidatingType = GetType(Date)
        '
        'mskPuppy
        '
        Me.mskPuppy.BackColor = System.Drawing.Color.White
        Me.mskPuppy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskPuppy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPuppy.ForeColor = System.Drawing.Color.Black
        Me.mskPuppy.Location = New System.Drawing.Point(131, 21)
        Me.mskPuppy.Mask = "00/00/0000"
        Me.mskPuppy.Name = "mskPuppy"
        Me.mskPuppy.Size = New System.Drawing.Size(96, 26)
        Me.mskPuppy.TabIndex = 1
        Me.mskPuppy.ValidatingType = GetType(Date)
        '
        'cboVacinas
        '
        Me.cboVacinas.FormattingEnabled = True
        Me.cboVacinas.Location = New System.Drawing.Point(20, 22)
        Me.cboVacinas.Name = "cboVacinas"
        Me.cboVacinas.Size = New System.Drawing.Size(462, 24)
        Me.cboVacinas.TabIndex = 0
        '
        'pnLateralCliente
        '
        Me.pnLateralCliente.Controls.Add(Me.Panel2)
        Me.pnLateralCliente.Location = New System.Drawing.Point(0, 0)
        Me.pnLateralCliente.Name = "pnLateralCliente"
        Me.pnLateralCliente.Size = New System.Drawing.Size(1625, 789)
        Me.pnLateralCliente.TabIndex = 7
        '
        'frmProntuario
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScrollMargin = New System.Drawing.Size(40, 73)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1630, 798)
        Me.Controls.Add(Me.pnLateralCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProntuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cadastro"
        Me.cmsListaFat.ResumeLayout(False)
        Me.cmsReceita.ResumeLayout(False)
        Me.cmsDelReceita.ResumeLayout(False)
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgGridTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TbProntuario.ResumeLayout(False)
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        Me.pnDadosPaciente.ResumeLayout(False)
        Me.pnDadosPaciente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_Paciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDetalhe.ResumeLayout(False)
        Me.pnDetalhe.PerformLayout()
        Me.pnDadosCliente.ResumeLayout(False)
        Me.pnDadosCliente.PerformLayout()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVacina.ResumeLayout(False)
        Me.TabVacina.PerformLayout()
        CType(Me.dgVacinasCadastradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVacinasEfetuadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.pnLateralCliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents cmsListaFat As Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsReceita As Windows.Forms.ContextMenuStrip
    Friend WithEvents Deletar_Item_Da_Receita As Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelReceita As Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnLateralCliente As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents cboTiposPesquisa As Cls_Controls.Cls_ComboBox
    Friend WithEvents txt_Busca As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents DgGridTop As Windows.Forms.DataGridView
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents lbIdPet As Windows.Forms.Label
    Friend WithEvents lbPet As Windows.Forms.Label
    Friend WithEvents TbProntuario As Windows.Forms.TabControl
    Friend WithEvents tbClientes As Windows.Forms.TabPage
    Friend WithEvents btoAgEstetica As Windows.Forms.Button
    Friend WithEvents btoEnviar As Windows.Forms.Button
    Friend WithEvents Label43 As Windows.Forms.Label
    Friend WithEvents pnDadosPaciente As Windows.Forms.Panel
    Friend WithEvents lbIdade As Windows.Forms.Label
    Friend WithEvents bto_Img_Pac As Windows.Forms.Button
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
    Friend WithEvents txt_Id_Paciente As Cls_Controls.Cls_TextBoxOld
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
    Friend WithEvents pic_Paciente As Windows.Forms.PictureBox
    Friend WithEvents pnDetalhe As Windows.Forms.Panel
    Friend WithEvents btoImprimir As Windows.Forms.Button
    Friend WithEvents cboTermos As Cls_Controls.Cls_ComboBox
    Friend WithEvents TreeView1 As Windows.Forms.TreeView
    Friend WithEvents pnDadosCliente As Windows.Forms.Panel
    Friend WithEvents lbIdadeTutor As Windows.Forms.Label
    Friend WithEvents bto_Img_Cli As Windows.Forms.Button
    Friend WithEvents btnAlterar As Windows.Forms.Button
    Friend WithEvents btnIncluir As Windows.Forms.Button
    Friend WithEvents pic_Cliente As Windows.Forms.PictureBox
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
    Friend WithEvents TabVacina As Windows.Forms.TabPage
    Friend WithEvents btoImpirmirVacina As Windows.Forms.Button
    Friend WithEvents Label40 As Windows.Forms.Label
    Friend WithEvents btnIncluirVacina As Windows.Forms.Button
    Friend WithEvents Label41 As Windows.Forms.Label
    Friend WithEvents dgVacinasCadastradas As Windows.Forms.DataGridView
    Friend WithEvents dgVacinasEfetuadas As Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents ckTosse As Windows.Forms.CheckBox
    Friend WithEvents mskTosse As Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents Label42 As Windows.Forms.Label
    Friend WithEvents mskAntR As Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents ckG2Dose As Windows.Forms.CheckBox
    Friend WithEvents ckG1Dose As Windows.Forms.CheckBox
    Friend WithEvents mskGiar2 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskGiar1 As Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents ckV2Reforco As Windows.Forms.CheckBox
    Friend WithEvents ckV1Reforco As Windows.Forms.CheckBox
    Friend WithEvents ckV3Dose As Windows.Forms.CheckBox
    Friend WithEvents ckV2Dose As Windows.Forms.CheckBox
    Friend WithEvents ckV1Dose As Windows.Forms.CheckBox
    Friend WithEvents ckPuppy As Windows.Forms.CheckBox
    Friend WithEvents mskRefor2 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskRefor1 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskDose3 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskDose2 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskDose1 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskPuppy As Windows.Forms.MaskedTextBox
    Friend WithEvents cboVacinas As Windows.Forms.ComboBox
    Friend WithEvents Detalhe_da_Venda_Zap As Windows.Forms.ToolStripMenuItem
    Friend WithEvents btoFrmInternacao As Windows.Forms.Button
    Friend WithEvents cboNomePet As Cls_Controls.Cls_ComboBox
    Friend WithEvents ckCastrado As Windows.Forms.CheckBox
    Friend WithEvents btoAbreAnaminese As Windows.Forms.Button
    Friend WithEvents TextBox1 As Cls_Controls.Cls_TextBoxOld
End Class
