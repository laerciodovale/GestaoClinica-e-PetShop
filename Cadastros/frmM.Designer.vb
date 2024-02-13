Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmM
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmM))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ControleDaAgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaDoPet = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaDoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensagemAniversarioTutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensagemAniversárioPetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsAniPet = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsAniH = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.pnVacinas = New System.Windows.Forms.Panel()
        Me.dgVacinasDoMesOld = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnAniversarios = New System.Windows.Forms.Panel()
        Me.DgAniversarioAnimal = New System.Windows.Forms.DataGridView()
        Me.DgAniversarioHumanos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnBotoes = New System.Windows.Forms.Panel()
        Me.pnBtoAg = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.subBtoAgGeral = New System.Windows.Forms.Button()
        Me.btoAgGeral = New System.Windows.Forms.Button()
        Me.subBtoAgBanho = New System.Windows.Forms.Button()
        Me.BtoAgBanho = New System.Windows.Forms.Button()
        Me.subBtoAgCliente = New System.Windows.Forms.Button()
        Me.btoAgCliente = New System.Windows.Forms.Button()
        Me.btoAgenda = New System.Windows.Forms.Button()
        Me.pnUsuario = New System.Windows.Forms.Panel()
        Me.subBtoCadPrestador = New System.Windows.Forms.Button()
        Me.btoPrestador = New System.Windows.Forms.Button()
        Me.subBtoSistFat = New System.Windows.Forms.Button()
        Me.btoFaturamento = New System.Windows.Forms.Button()
        Me.subBtoRelatorios = New System.Windows.Forms.Button()
        Me.btoRelatorios = New System.Windows.Forms.Button()
        Me.subBtoCadUsuario = New System.Windows.Forms.Button()
        Me.btoUsuario = New System.Windows.Forms.Button()
        Me.subBtoCadFuncionario = New System.Windows.Forms.Button()
        Me.btoFunc = New System.Windows.Forms.Button()
        Me.btoUsuários = New System.Windows.Forms.Button()
        Me.pnFinanceiroSub = New System.Windows.Forms.Panel()
        Me.subBtoFluxos = New System.Windows.Forms.Button()
        Me.btnFluxos = New System.Windows.Forms.Button()
        Me.subBtoExtratoCliente = New System.Windows.Forms.Button()
        Me.btoExtrato = New System.Windows.Forms.Button()
        Me.subBtopdv = New System.Windows.Forms.Button()
        Me.btoPDV = New System.Windows.Forms.Button()
        Me.subBtoContas = New System.Windows.Forms.Button()
        Me.BtoContasPagar = New System.Windows.Forms.Button()
        Me.subBtoLancamentos = New System.Windows.Forms.Button()
        Me.btoLanFinan = New System.Windows.Forms.Button()
        Me.btoFi = New System.Windows.Forms.Button()
        Me.pnProntuarioSub = New System.Windows.Forms.Panel()
        Me.subBtoCadastros = New System.Windows.Forms.Button()
        Me.btoPront = New System.Windows.Forms.Button()
        Me.btoProntuario = New System.Windows.Forms.Button()
        Me.pnMateriaisSub = New System.Windows.Forms.Panel()
        Me.subBtoFornecedor = New System.Windows.Forms.Button()
        Me.btoFrmFornec = New System.Windows.Forms.Button()
        Me.subBtoEntrada = New System.Windows.Forms.Button()
        Me.btoFrmEntrada = New System.Windows.Forms.Button()
        Me.subBtoImportacao = New System.Windows.Forms.Button()
        Me.btoImport = New System.Windows.Forms.Button()
        Me.subBtoItens = New System.Windows.Forms.Button()
        Me.btoItens = New System.Windows.Forms.Button()
        Me.btoMateriais = New System.Windows.Forms.Button()
        Me.pnCaixaSub2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.subBtoMovimento = New System.Windows.Forms.Button()
        Me.btnCaixaMov = New System.Windows.Forms.Button()
        Me.subBtoAbre = New System.Windows.Forms.Button()
        Me.btnABcx = New System.Windows.Forms.Button()
        Me.btoCaixa = New System.Windows.Forms.Button()
        Me.pnMenu = New System.Windows.Forms.Panel()
        Me.btnPN = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnAgenda = New System.Windows.Forms.Panel()
        Me.dtgCount = New System.Windows.Forms.DataGridView()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgAgenda = New System.Windows.Forms.DataGridView()
        Me.mcAgenda = New System.Windows.Forms.MonthCalendar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.txtDadosEmpresa = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvMetaBanho = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmsMenu.SuspendLayout()
        Me.cmsAniPet.SuspendLayout()
        Me.cmsAniH.SuspendLayout()
        Me.pnVacinas.SuspendLayout()
        CType(Me.dgVacinasDoMesOld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnAniversarios.SuspendLayout()
        CType(Me.DgAniversarioAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgAniversarioHumanos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnBotoes.SuspendLayout()
        Me.pnBtoAg.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnUsuario.SuspendLayout()
        Me.pnFinanceiroSub.SuspendLayout()
        Me.pnProntuarioSub.SuspendLayout()
        Me.pnMateriaisSub.SuspendLayout()
        Me.pnCaixaSub2.SuspendLayout()
        Me.pnMenu.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnAgenda.SuspendLayout()
        CType(Me.dtgCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMetaBanho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsMenu
        '
        Me.cmsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControleDaAgendaToolStripMenuItem, Me.ToolStripMenuItem1, Me.AgendaDoPet, Me.AgendaDoClienteToolStripMenuItem, Me.MensagemAniversarioTutorToolStripMenuItem, Me.MensagemAniversárioPetToolStripMenuItem})
        Me.cmsMenu.Name = "cmsListaFat"
        Me.cmsMenu.ShowCheckMargin = True
        Me.cmsMenu.Size = New System.Drawing.Size(291, 148)
        '
        'ControleDaAgendaToolStripMenuItem
        '
        Me.ControleDaAgendaToolStripMenuItem.Name = "ControleDaAgendaToolStripMenuItem"
        Me.ControleDaAgendaToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.ControleDaAgendaToolStripMenuItem.Text = "Controle da Agenda"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(290, 24)
        Me.ToolStripMenuItem1.Text = "Controle de Banho"
        '
        'AgendaDoPet
        '
        Me.AgendaDoPet.Name = "AgendaDoPet"
        Me.AgendaDoPet.Size = New System.Drawing.Size(290, 24)
        Me.AgendaDoPet.Text = "Agenda Do Pet"
        '
        'AgendaDoClienteToolStripMenuItem
        '
        Me.AgendaDoClienteToolStripMenuItem.Name = "AgendaDoClienteToolStripMenuItem"
        Me.AgendaDoClienteToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.AgendaDoClienteToolStripMenuItem.Text = "Agenda do Cliente"
        '
        'MensagemAniversarioTutorToolStripMenuItem
        '
        Me.MensagemAniversarioTutorToolStripMenuItem.Name = "MensagemAniversarioTutorToolStripMenuItem"
        Me.MensagemAniversarioTutorToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.MensagemAniversarioTutorToolStripMenuItem.Text = "Mensagem Aniversário Tutor"
        '
        'MensagemAniversárioPetToolStripMenuItem
        '
        Me.MensagemAniversárioPetToolStripMenuItem.Name = "MensagemAniversárioPetToolStripMenuItem"
        Me.MensagemAniversárioPetToolStripMenuItem.Size = New System.Drawing.Size(290, 24)
        Me.MensagemAniversárioPetToolStripMenuItem.Text = "Mensagem Aniversário Pet"
        '
        'cmsAniPet
        '
        Me.cmsAniPet.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsAniPet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem11})
        Me.cmsAniPet.Name = "cmsListaFat"
        Me.cmsAniPet.ShowCheckMargin = True
        Me.cmsAniPet.Size = New System.Drawing.Size(276, 28)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(275, 24)
        Me.ToolStripMenuItem11.Text = "Mensagem Aniversário Pet"
        '
        'cmsAniH
        '
        Me.cmsAniH.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsAniH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.cmsAniH.Name = "cmsListaFat"
        Me.cmsAniH.ShowCheckMargin = True
        Me.cmsAniH.Size = New System.Drawing.Size(291, 28)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(290, 24)
        Me.ToolStripMenuItem5.Text = "Mensagem Aniversário Tutor"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 60000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'pnVacinas
        '
        Me.pnVacinas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnVacinas.Controls.Add(Me.dgVacinasDoMesOld)
        Me.pnVacinas.Controls.Add(Me.Label1)
        Me.pnVacinas.Location = New System.Drawing.Point(228, 703)
        Me.pnVacinas.Name = "pnVacinas"
        Me.pnVacinas.Size = New System.Drawing.Size(456, 228)
        Me.pnVacinas.TabIndex = 15
        '
        'dgVacinasDoMesOld
        '
        Me.dgVacinasDoMesOld.AllowUserToOrderColumns = True
        Me.dgVacinasDoMesOld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVacinasDoMesOld.BackgroundColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVacinasDoMesOld.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgVacinasDoMesOld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVacinasDoMesOld.GridColor = System.Drawing.Color.White
        Me.dgVacinasDoMesOld.Location = New System.Drawing.Point(30, 38)
        Me.dgVacinasDoMesOld.MultiSelect = False
        Me.dgVacinasDoMesOld.Name = "dgVacinasDoMesOld"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVacinasDoMesOld.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgVacinasDoMesOld.RowHeadersWidth = 20
        Me.dgVacinasDoMesOld.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgVacinasDoMesOld.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgVacinasDoMesOld.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgVacinasDoMesOld.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightCyan
        Me.dgVacinasDoMesOld.RowTemplate.Height = 24
        Me.dgVacinasDoMesOld.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVacinasDoMesOld.Size = New System.Drawing.Size(398, 165)
        Me.dgVacinasDoMesOld.StandardTab = True
        Me.dgVacinasDoMesOld.TabIndex = 136
        Me.dgVacinasDoMesOld.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 29)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Vacinas do Mês"
        Me.Label1.Visible = False
        '
        'pnAniversarios
        '
        Me.pnAniversarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnAniversarios.Controls.Add(Me.DgAniversarioAnimal)
        Me.pnAniversarios.Controls.Add(Me.DgAniversarioHumanos)
        Me.pnAniversarios.Controls.Add(Me.Label2)
        Me.pnAniversarios.Location = New System.Drawing.Point(1040, 465)
        Me.pnAniversarios.Name = "pnAniversarios"
        Me.pnAniversarios.Size = New System.Drawing.Size(800, 485)
        Me.pnAniversarios.TabIndex = 16
        '
        'DgAniversarioAnimal
        '
        Me.DgAniversarioAnimal.AllowUserToOrderColumns = True
        Me.DgAniversarioAnimal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgAniversarioAnimal.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DgAniversarioAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAniversarioAnimal.ContextMenuStrip = Me.cmsAniPet
        Me.DgAniversarioAnimal.GridColor = System.Drawing.Color.White
        Me.DgAniversarioAnimal.Location = New System.Drawing.Point(83, 279)
        Me.DgAniversarioAnimal.MultiSelect = False
        Me.DgAniversarioAnimal.Name = "DgAniversarioAnimal"
        Me.DgAniversarioAnimal.RowHeadersWidth = 51
        Me.DgAniversarioAnimal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgAniversarioAnimal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgAniversarioAnimal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DgAniversarioAnimal.RowTemplate.Height = 24
        Me.DgAniversarioAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAniversarioAnimal.Size = New System.Drawing.Size(671, 187)
        Me.DgAniversarioAnimal.TabIndex = 143
        '
        'DgAniversarioHumanos
        '
        Me.DgAniversarioHumanos.AllowUserToOrderColumns = True
        Me.DgAniversarioHumanos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgAniversarioHumanos.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DgAniversarioHumanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAniversarioHumanos.ContextMenuStrip = Me.cmsAniH
        Me.DgAniversarioHumanos.GridColor = System.Drawing.Color.White
        Me.DgAniversarioHumanos.Location = New System.Drawing.Point(83, 36)
        Me.DgAniversarioHumanos.MultiSelect = False
        Me.DgAniversarioHumanos.Name = "DgAniversarioHumanos"
        Me.DgAniversarioHumanos.RowHeadersWidth = 51
        Me.DgAniversarioHumanos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgAniversarioHumanos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgAniversarioHumanos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DgAniversarioHumanos.RowTemplate.Height = 24
        Me.DgAniversarioHumanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAniversarioHumanos.Size = New System.Drawing.Size(671, 208)
        Me.DgAniversarioHumanos.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 29)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Aniversários do dia"
        '
        'pnBotoes
        '
        Me.pnBotoes.AutoScroll = True
        Me.pnBotoes.Controls.Add(Me.pnBtoAg)
        Me.pnBotoes.Controls.Add(Me.btoAgenda)
        Me.pnBotoes.Controls.Add(Me.pnUsuario)
        Me.pnBotoes.Controls.Add(Me.btoUsuários)
        Me.pnBotoes.Controls.Add(Me.pnFinanceiroSub)
        Me.pnBotoes.Controls.Add(Me.btoFi)
        Me.pnBotoes.Controls.Add(Me.pnProntuarioSub)
        Me.pnBotoes.Controls.Add(Me.btoProntuario)
        Me.pnBotoes.Controls.Add(Me.pnMateriaisSub)
        Me.pnBotoes.Controls.Add(Me.btoMateriais)
        Me.pnBotoes.Controls.Add(Me.pnCaixaSub2)
        Me.pnBotoes.Controls.Add(Me.btoCaixa)
        Me.pnBotoes.Controls.Add(Me.pnMenu)
        Me.pnBotoes.Location = New System.Drawing.Point(0, 95)
        Me.pnBotoes.Name = "pnBotoes"
        Me.pnBotoes.Size = New System.Drawing.Size(222, 800)
        Me.pnBotoes.TabIndex = 2
        '
        'pnBtoAg
        '
        Me.pnBtoAg.Controls.Add(Me.Panel1)
        Me.pnBtoAg.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnBtoAg.Location = New System.Drawing.Point(0, 1230)
        Me.pnBtoAg.Name = "pnBtoAg"
        Me.pnBtoAg.Size = New System.Drawing.Size(201, 184)
        Me.pnBtoAg.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.subBtoAgGeral)
        Me.Panel1.Controls.Add(Me.btoAgGeral)
        Me.Panel1.Controls.Add(Me.subBtoAgBanho)
        Me.Panel1.Controls.Add(Me.BtoAgBanho)
        Me.Panel1.Controls.Add(Me.subBtoAgCliente)
        Me.Panel1.Controls.Add(Me.btoAgCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 144)
        Me.Panel1.TabIndex = 18
        '
        'subBtoAgGeral
        '
        Me.subBtoAgGeral.BackColor = System.Drawing.Color.Aqua
        Me.subBtoAgGeral.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoAgGeral.FlatAppearance.BorderSize = 0
        Me.subBtoAgGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoAgGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoAgGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoAgGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoAgGeral.ForeColor = System.Drawing.Color.White
        Me.subBtoAgGeral.Location = New System.Drawing.Point(0, 130)
        Me.subBtoAgGeral.Name = "subBtoAgGeral"
        Me.subBtoAgGeral.Size = New System.Drawing.Size(201, 5)
        Me.subBtoAgGeral.TabIndex = 22
        Me.subBtoAgGeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoAgGeral.UseVisualStyleBackColor = False
        '
        'btoAgGeral
        '
        Me.btoAgGeral.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoAgGeral.FlatAppearance.BorderSize = 0
        Me.btoAgGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btoAgGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoAgGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAgGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgGeral.ForeColor = System.Drawing.Color.White
        Me.btoAgGeral.Location = New System.Drawing.Point(0, 90)
        Me.btoAgGeral.Name = "btoAgGeral"
        Me.btoAgGeral.Size = New System.Drawing.Size(201, 40)
        Me.btoAgGeral.TabIndex = 21
        Me.btoAgGeral.Text = "Agenda Geral"
        Me.btoAgGeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoAgGeral.UseVisualStyleBackColor = True
        '
        'subBtoAgBanho
        '
        Me.subBtoAgBanho.BackColor = System.Drawing.Color.Aqua
        Me.subBtoAgBanho.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoAgBanho.FlatAppearance.BorderSize = 0
        Me.subBtoAgBanho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoAgBanho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoAgBanho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoAgBanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoAgBanho.ForeColor = System.Drawing.Color.White
        Me.subBtoAgBanho.Location = New System.Drawing.Point(0, 85)
        Me.subBtoAgBanho.Name = "subBtoAgBanho"
        Me.subBtoAgBanho.Size = New System.Drawing.Size(201, 5)
        Me.subBtoAgBanho.TabIndex = 20
        Me.subBtoAgBanho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoAgBanho.UseVisualStyleBackColor = False
        '
        'BtoAgBanho
        '
        Me.BtoAgBanho.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtoAgBanho.FlatAppearance.BorderSize = 0
        Me.BtoAgBanho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.BtoAgBanho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.BtoAgBanho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtoAgBanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoAgBanho.ForeColor = System.Drawing.Color.White
        Me.BtoAgBanho.Location = New System.Drawing.Point(0, 45)
        Me.BtoAgBanho.Name = "BtoAgBanho"
        Me.BtoAgBanho.Size = New System.Drawing.Size(201, 40)
        Me.BtoAgBanho.TabIndex = 19
        Me.BtoAgBanho.Text = "Agenda Banho"
        Me.BtoAgBanho.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtoAgBanho.UseVisualStyleBackColor = True
        '
        'subBtoAgCliente
        '
        Me.subBtoAgCliente.BackColor = System.Drawing.Color.Aqua
        Me.subBtoAgCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoAgCliente.FlatAppearance.BorderSize = 0
        Me.subBtoAgCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoAgCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoAgCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoAgCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoAgCliente.ForeColor = System.Drawing.Color.White
        Me.subBtoAgCliente.Location = New System.Drawing.Point(0, 40)
        Me.subBtoAgCliente.Name = "subBtoAgCliente"
        Me.subBtoAgCliente.Size = New System.Drawing.Size(201, 5)
        Me.subBtoAgCliente.TabIndex = 18
        Me.subBtoAgCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoAgCliente.UseVisualStyleBackColor = False
        '
        'btoAgCliente
        '
        Me.btoAgCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoAgCliente.FlatAppearance.BorderSize = 0
        Me.btoAgCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btoAgCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoAgCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAgCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgCliente.ForeColor = System.Drawing.Color.White
        Me.btoAgCliente.Location = New System.Drawing.Point(0, 0)
        Me.btoAgCliente.Name = "btoAgCliente"
        Me.btoAgCliente.Size = New System.Drawing.Size(201, 40)
        Me.btoAgCliente.TabIndex = 17
        Me.btoAgCliente.Text = "Agenda do Cliente"
        Me.btoAgCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoAgCliente.UseVisualStyleBackColor = True
        '
        'btoAgenda
        '
        Me.btoAgenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgenda.ForeColor = System.Drawing.Color.White
        Me.btoAgenda.Image = CType(resources.GetObject("btoAgenda.Image"), System.Drawing.Image)
        Me.btoAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoAgenda.Location = New System.Drawing.Point(0, 1190)
        Me.btoAgenda.Name = "btoAgenda"
        Me.btoAgenda.Size = New System.Drawing.Size(201, 40)
        Me.btoAgenda.TabIndex = 40
        Me.btoAgenda.Text = "Agenda"
        Me.btoAgenda.UseVisualStyleBackColor = True
        '
        'pnUsuario
        '
        Me.pnUsuario.Controls.Add(Me.subBtoCadPrestador)
        Me.pnUsuario.Controls.Add(Me.btoPrestador)
        Me.pnUsuario.Controls.Add(Me.subBtoSistFat)
        Me.pnUsuario.Controls.Add(Me.btoFaturamento)
        Me.pnUsuario.Controls.Add(Me.subBtoRelatorios)
        Me.pnUsuario.Controls.Add(Me.btoRelatorios)
        Me.pnUsuario.Controls.Add(Me.subBtoCadUsuario)
        Me.pnUsuario.Controls.Add(Me.btoUsuario)
        Me.pnUsuario.Controls.Add(Me.subBtoCadFuncionario)
        Me.pnUsuario.Controls.Add(Me.btoFunc)
        Me.pnUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnUsuario.Location = New System.Drawing.Point(0, 925)
        Me.pnUsuario.Name = "pnUsuario"
        Me.pnUsuario.Size = New System.Drawing.Size(201, 265)
        Me.pnUsuario.TabIndex = 38
        '
        'subBtoCadPrestador
        '
        Me.subBtoCadPrestador.BackColor = System.Drawing.Color.Aqua
        Me.subBtoCadPrestador.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoCadPrestador.FlatAppearance.BorderSize = 0
        Me.subBtoCadPrestador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoCadPrestador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoCadPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoCadPrestador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoCadPrestador.ForeColor = System.Drawing.Color.White
        Me.subBtoCadPrestador.Location = New System.Drawing.Point(0, 226)
        Me.subBtoCadPrestador.Name = "subBtoCadPrestador"
        Me.subBtoCadPrestador.Size = New System.Drawing.Size(201, 5)
        Me.subBtoCadPrestador.TabIndex = 19
        Me.subBtoCadPrestador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoCadPrestador.UseVisualStyleBackColor = False
        '
        'btoPrestador
        '
        Me.btoPrestador.BackColor = System.Drawing.Color.SteelBlue
        Me.btoPrestador.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoPrestador.FlatAppearance.BorderSize = 0
        Me.btoPrestador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoPrestador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoPrestador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoPrestador.ForeColor = System.Drawing.Color.White
        Me.btoPrestador.Location = New System.Drawing.Point(0, 183)
        Me.btoPrestador.Name = "btoPrestador"
        Me.btoPrestador.Size = New System.Drawing.Size(201, 43)
        Me.btoPrestador.TabIndex = 18
        Me.btoPrestador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoPrestador.UseVisualStyleBackColor = False
        '
        'subBtoSistFat
        '
        Me.subBtoSistFat.BackColor = System.Drawing.Color.Aqua
        Me.subBtoSistFat.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoSistFat.FlatAppearance.BorderSize = 0
        Me.subBtoSistFat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoSistFat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoSistFat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoSistFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoSistFat.ForeColor = System.Drawing.Color.White
        Me.subBtoSistFat.Location = New System.Drawing.Point(0, 178)
        Me.subBtoSistFat.Name = "subBtoSistFat"
        Me.subBtoSistFat.Size = New System.Drawing.Size(201, 5)
        Me.subBtoSistFat.TabIndex = 17
        Me.subBtoSistFat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoSistFat.UseVisualStyleBackColor = False
        '
        'btoFaturamento
        '
        Me.btoFaturamento.BackColor = System.Drawing.Color.SteelBlue
        Me.btoFaturamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoFaturamento.FlatAppearance.BorderSize = 0
        Me.btoFaturamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoFaturamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoFaturamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoFaturamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFaturamento.ForeColor = System.Drawing.Color.White
        Me.btoFaturamento.Location = New System.Drawing.Point(0, 135)
        Me.btoFaturamento.Name = "btoFaturamento"
        Me.btoFaturamento.Size = New System.Drawing.Size(201, 43)
        Me.btoFaturamento.TabIndex = 16
        Me.btoFaturamento.Text = "Resumos"
        Me.btoFaturamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFaturamento.UseVisualStyleBackColor = False
        '
        'subBtoRelatorios
        '
        Me.subBtoRelatorios.BackColor = System.Drawing.Color.Aqua
        Me.subBtoRelatorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoRelatorios.FlatAppearance.BorderSize = 0
        Me.subBtoRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoRelatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoRelatorios.ForeColor = System.Drawing.Color.White
        Me.subBtoRelatorios.Location = New System.Drawing.Point(0, 130)
        Me.subBtoRelatorios.Name = "subBtoRelatorios"
        Me.subBtoRelatorios.Size = New System.Drawing.Size(201, 5)
        Me.subBtoRelatorios.TabIndex = 15
        Me.subBtoRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoRelatorios.UseVisualStyleBackColor = False
        '
        'btoRelatorios
        '
        Me.btoRelatorios.BackColor = System.Drawing.Color.SteelBlue
        Me.btoRelatorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoRelatorios.FlatAppearance.BorderSize = 0
        Me.btoRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoRelatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoRelatorios.ForeColor = System.Drawing.Color.White
        Me.btoRelatorios.Location = New System.Drawing.Point(0, 87)
        Me.btoRelatorios.Name = "btoRelatorios"
        Me.btoRelatorios.Size = New System.Drawing.Size(201, 43)
        Me.btoRelatorios.TabIndex = 14
        Me.btoRelatorios.Text = "Relatórios"
        Me.btoRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoRelatorios.UseVisualStyleBackColor = False
        '
        'subBtoCadUsuario
        '
        Me.subBtoCadUsuario.BackColor = System.Drawing.Color.Aqua
        Me.subBtoCadUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoCadUsuario.FlatAppearance.BorderSize = 0
        Me.subBtoCadUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoCadUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoCadUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoCadUsuario.ForeColor = System.Drawing.Color.White
        Me.subBtoCadUsuario.Location = New System.Drawing.Point(0, 82)
        Me.subBtoCadUsuario.Name = "subBtoCadUsuario"
        Me.subBtoCadUsuario.Size = New System.Drawing.Size(201, 5)
        Me.subBtoCadUsuario.TabIndex = 13
        Me.subBtoCadUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoCadUsuario.UseVisualStyleBackColor = False
        '
        'btoUsuario
        '
        Me.btoUsuario.BackColor = System.Drawing.Color.SteelBlue
        Me.btoUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoUsuario.FlatAppearance.BorderSize = 0
        Me.btoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoUsuario.ForeColor = System.Drawing.Color.White
        Me.btoUsuario.Location = New System.Drawing.Point(0, 39)
        Me.btoUsuario.Name = "btoUsuario"
        Me.btoUsuario.Size = New System.Drawing.Size(201, 43)
        Me.btoUsuario.TabIndex = 12
        Me.btoUsuario.Text = "Cad.Usuario"
        Me.btoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoUsuario.UseVisualStyleBackColor = False
        '
        'subBtoCadFuncionario
        '
        Me.subBtoCadFuncionario.BackColor = System.Drawing.Color.Aqua
        Me.subBtoCadFuncionario.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoCadFuncionario.FlatAppearance.BorderSize = 0
        Me.subBtoCadFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoCadFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoCadFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoCadFuncionario.ForeColor = System.Drawing.Color.White
        Me.subBtoCadFuncionario.Location = New System.Drawing.Point(0, 34)
        Me.subBtoCadFuncionario.Name = "subBtoCadFuncionario"
        Me.subBtoCadFuncionario.Size = New System.Drawing.Size(201, 5)
        Me.subBtoCadFuncionario.TabIndex = 9
        Me.subBtoCadFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoCadFuncionario.UseVisualStyleBackColor = False
        '
        'btoFunc
        '
        Me.btoFunc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoFunc.FlatAppearance.BorderSize = 0
        Me.btoFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFunc.ForeColor = System.Drawing.Color.White
        Me.btoFunc.Location = New System.Drawing.Point(0, 0)
        Me.btoFunc.Name = "btoFunc"
        Me.btoFunc.Size = New System.Drawing.Size(201, 34)
        Me.btoFunc.TabIndex = 7
        Me.btoFunc.Text = "Cad.Funcionário"
        Me.btoFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFunc.UseVisualStyleBackColor = True
        '
        'btoUsuários
        '
        Me.btoUsuários.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoUsuários.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoUsuários.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoUsuários.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoUsuários.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoUsuários.ForeColor = System.Drawing.Color.White
        Me.btoUsuários.Image = CType(resources.GetObject("btoUsuários.Image"), System.Drawing.Image)
        Me.btoUsuários.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoUsuários.Location = New System.Drawing.Point(0, 885)
        Me.btoUsuários.Name = "btoUsuários"
        Me.btoUsuários.Size = New System.Drawing.Size(201, 40)
        Me.btoUsuários.TabIndex = 37
        Me.btoUsuários.Text = "Sistema"
        Me.btoUsuários.UseVisualStyleBackColor = True
        '
        'pnFinanceiroSub
        '
        Me.pnFinanceiroSub.Controls.Add(Me.subBtoFluxos)
        Me.pnFinanceiroSub.Controls.Add(Me.btnFluxos)
        Me.pnFinanceiroSub.Controls.Add(Me.subBtoExtratoCliente)
        Me.pnFinanceiroSub.Controls.Add(Me.btoExtrato)
        Me.pnFinanceiroSub.Controls.Add(Me.subBtopdv)
        Me.pnFinanceiroSub.Controls.Add(Me.btoPDV)
        Me.pnFinanceiroSub.Controls.Add(Me.subBtoContas)
        Me.pnFinanceiroSub.Controls.Add(Me.BtoContasPagar)
        Me.pnFinanceiroSub.Controls.Add(Me.subBtoLancamentos)
        Me.pnFinanceiroSub.Controls.Add(Me.btoLanFinan)
        Me.pnFinanceiroSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnFinanceiroSub.Location = New System.Drawing.Point(0, 585)
        Me.pnFinanceiroSub.Name = "pnFinanceiroSub"
        Me.pnFinanceiroSub.Size = New System.Drawing.Size(201, 300)
        Me.pnFinanceiroSub.TabIndex = 36
        '
        'subBtoFluxos
        '
        Me.subBtoFluxos.BackColor = System.Drawing.Color.Aqua
        Me.subBtoFluxos.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoFluxos.FlatAppearance.BorderSize = 0
        Me.subBtoFluxos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoFluxos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoFluxos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoFluxos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoFluxos.ForeColor = System.Drawing.Color.White
        Me.subBtoFluxos.Location = New System.Drawing.Point(0, 220)
        Me.subBtoFluxos.Name = "subBtoFluxos"
        Me.subBtoFluxos.Size = New System.Drawing.Size(201, 5)
        Me.subBtoFluxos.TabIndex = 18
        Me.subBtoFluxos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoFluxos.UseVisualStyleBackColor = False
        '
        'btnFluxos
        '
        Me.btnFluxos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFluxos.FlatAppearance.BorderSize = 0
        Me.btnFluxos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFluxos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnFluxos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFluxos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFluxos.ForeColor = System.Drawing.Color.White
        Me.btnFluxos.Location = New System.Drawing.Point(0, 180)
        Me.btnFluxos.Name = "btnFluxos"
        Me.btnFluxos.Size = New System.Drawing.Size(201, 40)
        Me.btnFluxos.TabIndex = 17
        Me.btnFluxos.Text = "Fluxos"
        Me.btnFluxos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFluxos.UseVisualStyleBackColor = True
        '
        'subBtoExtratoCliente
        '
        Me.subBtoExtratoCliente.BackColor = System.Drawing.Color.Aqua
        Me.subBtoExtratoCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoExtratoCliente.FlatAppearance.BorderSize = 0
        Me.subBtoExtratoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoExtratoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoExtratoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoExtratoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoExtratoCliente.ForeColor = System.Drawing.Color.White
        Me.subBtoExtratoCliente.Location = New System.Drawing.Point(0, 175)
        Me.subBtoExtratoCliente.Name = "subBtoExtratoCliente"
        Me.subBtoExtratoCliente.Size = New System.Drawing.Size(201, 5)
        Me.subBtoExtratoCliente.TabIndex = 16
        Me.subBtoExtratoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoExtratoCliente.UseVisualStyleBackColor = False
        '
        'btoExtrato
        '
        Me.btoExtrato.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoExtrato.FlatAppearance.BorderSize = 0
        Me.btoExtrato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoExtrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoExtrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoExtrato.ForeColor = System.Drawing.Color.White
        Me.btoExtrato.Location = New System.Drawing.Point(0, 135)
        Me.btoExtrato.Name = "btoExtrato"
        Me.btoExtrato.Size = New System.Drawing.Size(201, 40)
        Me.btoExtrato.TabIndex = 15
        Me.btoExtrato.Text = "Extrato do Cliente"
        Me.btoExtrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoExtrato.UseVisualStyleBackColor = True
        '
        'subBtopdv
        '
        Me.subBtopdv.BackColor = System.Drawing.Color.Aqua
        Me.subBtopdv.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtopdv.FlatAppearance.BorderSize = 0
        Me.subBtopdv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtopdv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtopdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtopdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtopdv.ForeColor = System.Drawing.Color.White
        Me.subBtopdv.Location = New System.Drawing.Point(0, 130)
        Me.subBtopdv.Name = "subBtopdv"
        Me.subBtopdv.Size = New System.Drawing.Size(201, 5)
        Me.subBtopdv.TabIndex = 14
        Me.subBtopdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtopdv.UseVisualStyleBackColor = False
        '
        'btoPDV
        '
        Me.btoPDV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoPDV.FlatAppearance.BorderSize = 0
        Me.btoPDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoPDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoPDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoPDV.ForeColor = System.Drawing.Color.White
        Me.btoPDV.Location = New System.Drawing.Point(0, 90)
        Me.btoPDV.Name = "btoPDV"
        Me.btoPDV.Size = New System.Drawing.Size(201, 40)
        Me.btoPDV.TabIndex = 13
        Me.btoPDV.Text = "P D V"
        Me.btoPDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoPDV.UseVisualStyleBackColor = True
        '
        'subBtoContas
        '
        Me.subBtoContas.BackColor = System.Drawing.Color.Aqua
        Me.subBtoContas.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoContas.FlatAppearance.BorderSize = 0
        Me.subBtoContas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoContas.ForeColor = System.Drawing.Color.White
        Me.subBtoContas.Location = New System.Drawing.Point(0, 85)
        Me.subBtoContas.Name = "subBtoContas"
        Me.subBtoContas.Size = New System.Drawing.Size(201, 5)
        Me.subBtoContas.TabIndex = 12
        Me.subBtoContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoContas.UseVisualStyleBackColor = False
        '
        'BtoContasPagar
        '
        Me.BtoContasPagar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtoContasPagar.FlatAppearance.BorderSize = 0
        Me.BtoContasPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtoContasPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.BtoContasPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtoContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtoContasPagar.ForeColor = System.Drawing.Color.White
        Me.BtoContasPagar.Location = New System.Drawing.Point(0, 45)
        Me.BtoContasPagar.Name = "BtoContasPagar"
        Me.BtoContasPagar.Size = New System.Drawing.Size(201, 40)
        Me.BtoContasPagar.TabIndex = 11
        Me.BtoContasPagar.Text = "Contas a Pagar"
        Me.BtoContasPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtoContasPagar.UseVisualStyleBackColor = True
        '
        'subBtoLancamentos
        '
        Me.subBtoLancamentos.BackColor = System.Drawing.Color.Aqua
        Me.subBtoLancamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoLancamentos.FlatAppearance.BorderSize = 0
        Me.subBtoLancamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoLancamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoLancamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoLancamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoLancamentos.ForeColor = System.Drawing.Color.White
        Me.subBtoLancamentos.Location = New System.Drawing.Point(0, 40)
        Me.subBtoLancamentos.Name = "subBtoLancamentos"
        Me.subBtoLancamentos.Size = New System.Drawing.Size(201, 5)
        Me.subBtoLancamentos.TabIndex = 10
        Me.subBtoLancamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoLancamentos.UseVisualStyleBackColor = False
        '
        'btoLanFinan
        '
        Me.btoLanFinan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoLanFinan.FlatAppearance.BorderSize = 0
        Me.btoLanFinan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoLanFinan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoLanFinan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoLanFinan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoLanFinan.ForeColor = System.Drawing.Color.White
        Me.btoLanFinan.Location = New System.Drawing.Point(0, 0)
        Me.btoLanFinan.Name = "btoLanFinan"
        Me.btoLanFinan.Size = New System.Drawing.Size(201, 40)
        Me.btoLanFinan.TabIndex = 5
        Me.btoLanFinan.Text = "Lançamentos ao Cliente"
        Me.btoLanFinan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoLanFinan.UseVisualStyleBackColor = True
        '
        'btoFi
        '
        Me.btoFi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoFi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoFi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFi.ForeColor = System.Drawing.Color.White
        Me.btoFi.Image = CType(resources.GetObject("btoFi.Image"), System.Drawing.Image)
        Me.btoFi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoFi.Location = New System.Drawing.Point(0, 545)
        Me.btoFi.Name = "btoFi"
        Me.btoFi.Size = New System.Drawing.Size(201, 40)
        Me.btoFi.TabIndex = 35
        Me.btoFi.Text = "Financeiro"
        Me.btoFi.UseVisualStyleBackColor = True
        '
        'pnProntuarioSub
        '
        Me.pnProntuarioSub.Controls.Add(Me.subBtoCadastros)
        Me.pnProntuarioSub.Controls.Add(Me.btoPront)
        Me.pnProntuarioSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnProntuarioSub.Location = New System.Drawing.Point(0, 496)
        Me.pnProntuarioSub.Name = "pnProntuarioSub"
        Me.pnProntuarioSub.Size = New System.Drawing.Size(201, 49)
        Me.pnProntuarioSub.TabIndex = 34
        '
        'subBtoCadastros
        '
        Me.subBtoCadastros.BackColor = System.Drawing.Color.Aqua
        Me.subBtoCadastros.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoCadastros.FlatAppearance.BorderSize = 0
        Me.subBtoCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoCadastros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoCadastros.ForeColor = System.Drawing.Color.White
        Me.subBtoCadastros.Location = New System.Drawing.Point(0, 40)
        Me.subBtoCadastros.Name = "subBtoCadastros"
        Me.subBtoCadastros.Size = New System.Drawing.Size(201, 5)
        Me.subBtoCadastros.TabIndex = 10
        Me.subBtoCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoCadastros.UseVisualStyleBackColor = False
        '
        'btoPront
        '
        Me.btoPront.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoPront.FlatAppearance.BorderSize = 0
        Me.btoPront.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoPront.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoPront.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoPront.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoPront.ForeColor = System.Drawing.Color.White
        Me.btoPront.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoPront.Location = New System.Drawing.Point(0, 0)
        Me.btoPront.Name = "btoPront"
        Me.btoPront.Size = New System.Drawing.Size(201, 40)
        Me.btoPront.TabIndex = 4
        Me.btoPront.Text = "Tutor / Pet"
        Me.btoPront.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoPront.UseVisualStyleBackColor = True
        '
        'btoProntuario
        '
        Me.btoProntuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoProntuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoProntuario.ForeColor = System.Drawing.Color.White
        Me.btoProntuario.Image = CType(resources.GetObject("btoProntuario.Image"), System.Drawing.Image)
        Me.btoProntuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoProntuario.Location = New System.Drawing.Point(0, 456)
        Me.btoProntuario.Name = "btoProntuario"
        Me.btoProntuario.Size = New System.Drawing.Size(201, 40)
        Me.btoProntuario.TabIndex = 33
        Me.btoProntuario.Text = "Cadastros"
        Me.btoProntuario.UseVisualStyleBackColor = True
        '
        'pnMateriaisSub
        '
        Me.pnMateriaisSub.Controls.Add(Me.subBtoFornecedor)
        Me.pnMateriaisSub.Controls.Add(Me.btoFrmFornec)
        Me.pnMateriaisSub.Controls.Add(Me.subBtoEntrada)
        Me.pnMateriaisSub.Controls.Add(Me.btoFrmEntrada)
        Me.pnMateriaisSub.Controls.Add(Me.subBtoImportacao)
        Me.pnMateriaisSub.Controls.Add(Me.btoImport)
        Me.pnMateriaisSub.Controls.Add(Me.subBtoItens)
        Me.pnMateriaisSub.Controls.Add(Me.btoItens)
        Me.pnMateriaisSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnMateriaisSub.Location = New System.Drawing.Point(0, 274)
        Me.pnMateriaisSub.Name = "pnMateriaisSub"
        Me.pnMateriaisSub.Size = New System.Drawing.Size(201, 182)
        Me.pnMateriaisSub.TabIndex = 32
        '
        'subBtoFornecedor
        '
        Me.subBtoFornecedor.BackColor = System.Drawing.Color.Aqua
        Me.subBtoFornecedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoFornecedor.FlatAppearance.BorderSize = 0
        Me.subBtoFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoFornecedor.ForeColor = System.Drawing.Color.White
        Me.subBtoFornecedor.Location = New System.Drawing.Point(0, 174)
        Me.subBtoFornecedor.Name = "subBtoFornecedor"
        Me.subBtoFornecedor.Size = New System.Drawing.Size(201, 5)
        Me.subBtoFornecedor.TabIndex = 17
        Me.subBtoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoFornecedor.UseVisualStyleBackColor = False
        '
        'btoFrmFornec
        '
        Me.btoFrmFornec.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoFrmFornec.FlatAppearance.BorderSize = 0
        Me.btoFrmFornec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoFrmFornec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoFrmFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoFrmFornec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFrmFornec.ForeColor = System.Drawing.Color.White
        Me.btoFrmFornec.Location = New System.Drawing.Point(0, 134)
        Me.btoFrmFornec.Name = "btoFrmFornec"
        Me.btoFrmFornec.Size = New System.Drawing.Size(201, 40)
        Me.btoFrmFornec.TabIndex = 16
        Me.btoFrmFornec.Text = "Fornecedor"
        Me.btoFrmFornec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFrmFornec.UseVisualStyleBackColor = True
        '
        'subBtoEntrada
        '
        Me.subBtoEntrada.BackColor = System.Drawing.Color.Aqua
        Me.subBtoEntrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoEntrada.FlatAppearance.BorderSize = 0
        Me.subBtoEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoEntrada.ForeColor = System.Drawing.Color.White
        Me.subBtoEntrada.Location = New System.Drawing.Point(0, 129)
        Me.subBtoEntrada.Name = "subBtoEntrada"
        Me.subBtoEntrada.Size = New System.Drawing.Size(201, 5)
        Me.subBtoEntrada.TabIndex = 15
        Me.subBtoEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoEntrada.UseVisualStyleBackColor = False
        '
        'btoFrmEntrada
        '
        Me.btoFrmEntrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoFrmEntrada.FlatAppearance.BorderSize = 0
        Me.btoFrmEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoFrmEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoFrmEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoFrmEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFrmEntrada.ForeColor = System.Drawing.Color.White
        Me.btoFrmEntrada.Location = New System.Drawing.Point(0, 90)
        Me.btoFrmEntrada.Name = "btoFrmEntrada"
        Me.btoFrmEntrada.Size = New System.Drawing.Size(201, 39)
        Me.btoFrmEntrada.TabIndex = 14
        Me.btoFrmEntrada.Text = "Lançar Entrada"
        Me.btoFrmEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFrmEntrada.UseVisualStyleBackColor = True
        '
        'subBtoImportacao
        '
        Me.subBtoImportacao.BackColor = System.Drawing.Color.Aqua
        Me.subBtoImportacao.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoImportacao.FlatAppearance.BorderSize = 0
        Me.subBtoImportacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoImportacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoImportacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoImportacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoImportacao.ForeColor = System.Drawing.Color.White
        Me.subBtoImportacao.Location = New System.Drawing.Point(0, 85)
        Me.subBtoImportacao.Name = "subBtoImportacao"
        Me.subBtoImportacao.Size = New System.Drawing.Size(201, 5)
        Me.subBtoImportacao.TabIndex = 13
        Me.subBtoImportacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoImportacao.UseVisualStyleBackColor = False
        '
        'btoImport
        '
        Me.btoImport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoImport.FlatAppearance.BorderSize = 0
        Me.btoImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoImport.ForeColor = System.Drawing.Color.White
        Me.btoImport.Location = New System.Drawing.Point(0, 45)
        Me.btoImport.Name = "btoImport"
        Me.btoImport.Size = New System.Drawing.Size(201, 40)
        Me.btoImport.TabIndex = 12
        Me.btoImport.Text = "Importação"
        Me.btoImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoImport.UseVisualStyleBackColor = True
        '
        'subBtoItens
        '
        Me.subBtoItens.BackColor = System.Drawing.Color.Aqua
        Me.subBtoItens.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoItens.FlatAppearance.BorderSize = 0
        Me.subBtoItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoItens.ForeColor = System.Drawing.Color.White
        Me.subBtoItens.Location = New System.Drawing.Point(0, 40)
        Me.subBtoItens.Name = "subBtoItens"
        Me.subBtoItens.Size = New System.Drawing.Size(201, 5)
        Me.subBtoItens.TabIndex = 11
        Me.subBtoItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoItens.UseVisualStyleBackColor = False
        '
        'btoItens
        '
        Me.btoItens.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoItens.FlatAppearance.BorderSize = 0
        Me.btoItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btoItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoItens.ForeColor = System.Drawing.Color.White
        Me.btoItens.Location = New System.Drawing.Point(0, 0)
        Me.btoItens.Name = "btoItens"
        Me.btoItens.Size = New System.Drawing.Size(201, 40)
        Me.btoItens.TabIndex = 7
        Me.btoItens.Text = "Itens"
        Me.btoItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoItens.UseVisualStyleBackColor = True
        '
        'btoMateriais
        '
        Me.btoMateriais.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoMateriais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoMateriais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoMateriais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoMateriais.ForeColor = System.Drawing.Color.White
        Me.btoMateriais.Image = CType(resources.GetObject("btoMateriais.Image"), System.Drawing.Image)
        Me.btoMateriais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoMateriais.Location = New System.Drawing.Point(0, 234)
        Me.btoMateriais.Name = "btoMateriais"
        Me.btoMateriais.Size = New System.Drawing.Size(201, 40)
        Me.btoMateriais.TabIndex = 30
        Me.btoMateriais.Text = "Materiais"
        Me.btoMateriais.UseVisualStyleBackColor = True
        '
        'pnCaixaSub2
        '
        Me.pnCaixaSub2.Controls.Add(Me.Button3)
        Me.pnCaixaSub2.Controls.Add(Me.Button1)
        Me.pnCaixaSub2.Controls.Add(Me.subBtoMovimento)
        Me.pnCaixaSub2.Controls.Add(Me.btnCaixaMov)
        Me.pnCaixaSub2.Controls.Add(Me.subBtoAbre)
        Me.pnCaixaSub2.Controls.Add(Me.btnABcx)
        Me.pnCaixaSub2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnCaixaSub2.Location = New System.Drawing.Point(0, 90)
        Me.pnCaixaSub2.Name = "pnCaixaSub2"
        Me.pnCaixaSub2.Size = New System.Drawing.Size(201, 144)
        Me.pnCaixaSub2.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aqua
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 5)
        Me.Button3.TabIndex = 16
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "P D V"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'subBtoMovimento
        '
        Me.subBtoMovimento.BackColor = System.Drawing.Color.Aqua
        Me.subBtoMovimento.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoMovimento.FlatAppearance.BorderSize = 0
        Me.subBtoMovimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoMovimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoMovimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoMovimento.ForeColor = System.Drawing.Color.White
        Me.subBtoMovimento.Location = New System.Drawing.Point(0, 85)
        Me.subBtoMovimento.Name = "subBtoMovimento"
        Me.subBtoMovimento.Size = New System.Drawing.Size(201, 5)
        Me.subBtoMovimento.TabIndex = 14
        Me.subBtoMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoMovimento.UseVisualStyleBackColor = False
        '
        'btnCaixaMov
        '
        Me.btnCaixaMov.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCaixaMov.FlatAppearance.BorderSize = 0
        Me.btnCaixaMov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCaixaMov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCaixaMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaixaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaixaMov.ForeColor = System.Drawing.Color.White
        Me.btnCaixaMov.Location = New System.Drawing.Point(0, 45)
        Me.btnCaixaMov.Name = "btnCaixaMov"
        Me.btnCaixaMov.Size = New System.Drawing.Size(201, 40)
        Me.btnCaixaMov.TabIndex = 13
        Me.btnCaixaMov.Text = "Movimento"
        Me.btnCaixaMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCaixaMov.UseVisualStyleBackColor = True
        '
        'subBtoAbre
        '
        Me.subBtoAbre.BackColor = System.Drawing.Color.Aqua
        Me.subBtoAbre.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtoAbre.FlatAppearance.BorderSize = 0
        Me.subBtoAbre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subBtoAbre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.subBtoAbre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtoAbre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtoAbre.ForeColor = System.Drawing.Color.White
        Me.subBtoAbre.Location = New System.Drawing.Point(0, 40)
        Me.subBtoAbre.Name = "subBtoAbre"
        Me.subBtoAbre.Size = New System.Drawing.Size(201, 5)
        Me.subBtoAbre.TabIndex = 12
        Me.subBtoAbre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subBtoAbre.UseVisualStyleBackColor = False
        '
        'btnABcx
        '
        Me.btnABcx.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnABcx.FlatAppearance.BorderSize = 0
        Me.btnABcx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnABcx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnABcx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnABcx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnABcx.ForeColor = System.Drawing.Color.White
        Me.btnABcx.Location = New System.Drawing.Point(0, 0)
        Me.btnABcx.Name = "btnABcx"
        Me.btnABcx.Size = New System.Drawing.Size(201, 40)
        Me.btnABcx.TabIndex = 5
        Me.btnABcx.Text = "Abre/Fecha"
        Me.btnABcx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnABcx.UseVisualStyleBackColor = True
        '
        'btoCaixa
        '
        Me.btoCaixa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btoCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoCaixa.ForeColor = System.Drawing.Color.White
        Me.btoCaixa.Image = CType(resources.GetObject("btoCaixa.Image"), System.Drawing.Image)
        Me.btoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoCaixa.Location = New System.Drawing.Point(0, 50)
        Me.btoCaixa.Name = "btoCaixa"
        Me.btoCaixa.Size = New System.Drawing.Size(201, 40)
        Me.btoCaixa.TabIndex = 28
        Me.btoCaixa.Text = "Caixa"
        Me.btoCaixa.UseVisualStyleBackColor = True
        '
        'pnMenu
        '
        Me.pnMenu.AutoScroll = True
        Me.pnMenu.Controls.Add(Me.btnPN)
        Me.pnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnMenu.Name = "pnMenu"
        Me.pnMenu.Size = New System.Drawing.Size(201, 50)
        Me.pnMenu.TabIndex = 22
        '
        'btnPN
        '
        Me.btnPN.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPN.FlatAppearance.BorderSize = 0
        Me.btnPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPN.ForeColor = System.Drawing.Color.White
        Me.btnPN.Image = Global.Cadastros.My.Resources.Resources.menu
        Me.btnPN.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPN.Location = New System.Drawing.Point(0, 0)
        Me.btnPN.Name = "btnPN"
        Me.btnPN.Size = New System.Drawing.Size(61, 50)
        Me.btnPN.TabIndex = 0
        Me.btnPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPN.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblTime)
        Me.Panel5.Location = New System.Drawing.Point(-2, -2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(273, 91)
        Me.Panel5.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(6, 18)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(260, 58)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "RELOGIO"
        '
        'pnAgenda
        '
        Me.pnAgenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnAgenda.Controls.Add(Me.dtgCount)
        Me.pnAgenda.Controls.Add(Me.lblUsuario)
        Me.pnAgenda.Controls.Add(Me.Label3)
        Me.pnAgenda.Controls.Add(Me.GroupBox1)
        Me.pnAgenda.Controls.Add(Me.dgAgenda)
        Me.pnAgenda.Controls.Add(Me.mcAgenda)
        Me.pnAgenda.Location = New System.Drawing.Point(228, -2)
        Me.pnAgenda.Name = "pnAgenda"
        Me.pnAgenda.Size = New System.Drawing.Size(1611, 449)
        Me.pnAgenda.TabIndex = 14
        '
        'dtgCount
        '
        Me.dtgCount.AllowUserToOrderColumns = True
        Me.dtgCount.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dtgCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCount.ContextMenuStrip = Me.cmsAniH
        Me.dtgCount.GridColor = System.Drawing.Color.White
        Me.dtgCount.Location = New System.Drawing.Point(29, 317)
        Me.dtgCount.MultiSelect = False
        Me.dtgCount.Name = "dtgCount"
        Me.dtgCount.RowHeadersWidth = 51
        Me.dtgCount.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dtgCount.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgCount.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtgCount.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dtgCount.RowTemplate.Height = 24
        Me.dtgCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCount.Size = New System.Drawing.Size(359, 121)
        Me.dtgCount.TabIndex = 142
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(64, 9)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(197, 58)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Último Banho"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(375, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(34, 38)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'dgAgenda
        '
        Me.dgAgenda.AllowUserToAddRows = False
        Me.dgAgenda.AllowUserToDeleteRows = False
        Me.dgAgenda.AllowUserToOrderColumns = True
        Me.dgAgenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAgenda.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgenda.ContextMenuStrip = Me.cmsMenu
        Me.dgAgenda.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAgenda.Location = New System.Drawing.Point(424, 9)
        Me.dgAgenda.MultiSelect = False
        Me.dgAgenda.Name = "dgAgenda"
        Me.dgAgenda.ReadOnly = True
        Me.dgAgenda.RowHeadersVisible = False
        Me.dgAgenda.RowHeadersWidth = 51
        Me.dgAgenda.RowTemplate.Height = 24
        Me.dgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAgenda.Size = New System.Drawing.Size(1184, 437)
        Me.dgAgenda.TabIndex = 1
        '
        'mcAgenda
        '
        Me.mcAgenda.BackColor = System.Drawing.Color.Black
        Me.mcAgenda.ForeColor = System.Drawing.SystemColors.MenuText
        Me.mcAgenda.Location = New System.Drawing.Point(29, 103)
        Me.mcAgenda.Name = "mcAgenda"
        Me.mcAgenda.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtFantasia)
        Me.Panel3.Controls.Add(Me.txtDadosEmpresa)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.pnAgenda)
        Me.Panel3.Controls.Add(Me.pnBotoes)
        Me.Panel3.Controls.Add(Me.pnAniversarios)
        Me.Panel3.Controls.Add(Me.pnVacinas)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1854, 1056)
        Me.Panel3.TabIndex = 3
        '
        'txtFantasia
        '
        Me.txtFantasia.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFantasia.Location = New System.Drawing.Point(680, 911)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.Size = New System.Drawing.Size(451, 22)
        Me.txtFantasia.TabIndex = 19
        Me.txtFantasia.Visible = False
        '
        'txtDadosEmpresa
        '
        Me.txtDadosEmpresa.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDadosEmpresa.Location = New System.Drawing.Point(680, 767)
        Me.txtDadosEmpresa.Multiline = True
        Me.txtDadosEmpresa.Name = "txtDadosEmpresa"
        Me.txtDadosEmpresa.Size = New System.Drawing.Size(451, 138)
        Me.txtDadosEmpresa.TabIndex = 18
        Me.txtDadosEmpresa.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvMetaBanho)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(228, 465)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 222)
        Me.Panel2.TabIndex = 17
        '
        'dgvMetaBanho
        '
        Me.dgvMetaBanho.AllowUserToOrderColumns = True
        Me.dgvMetaBanho.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMetaBanho.BackgroundColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMetaBanho.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMetaBanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMetaBanho.GridColor = System.Drawing.Color.White
        Me.dgvMetaBanho.Location = New System.Drawing.Point(30, 33)
        Me.dgvMetaBanho.MultiSelect = False
        Me.dgvMetaBanho.Name = "dgvMetaBanho"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMetaBanho.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMetaBanho.RowHeadersWidth = 20
        Me.dgvMetaBanho.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgvMetaBanho.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvMetaBanho.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgvMetaBanho.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightCyan
        Me.dgvMetaBanho.RowTemplate.Height = 24
        Me.dgvMetaBanho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMetaBanho.Size = New System.Drawing.Size(398, 159)
        Me.dgvMetaBanho.StandardTab = True
        Me.dgvMetaBanho.TabIndex = 136
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 29)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Metas do Dia"
        '
        'frmM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1854, 1055)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SisPet - Gestão de Pet's"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsMenu.ResumeLayout(False)
        Me.cmsAniPet.ResumeLayout(False)
        Me.cmsAniH.ResumeLayout(False)
        Me.pnVacinas.ResumeLayout(False)
        Me.pnVacinas.PerformLayout()
        CType(Me.dgVacinasDoMesOld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnAniversarios.ResumeLayout(False)
        Me.pnAniversarios.PerformLayout()
        CType(Me.DgAniversarioAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgAniversarioHumanos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnBotoes.ResumeLayout(False)
        Me.pnBtoAg.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnUsuario.ResumeLayout(False)
        Me.pnFinanceiroSub.ResumeLayout(False)
        Me.pnProntuarioSub.ResumeLayout(False)
        Me.pnMateriaisSub.ResumeLayout(False)
        Me.pnCaixaSub2.ResumeLayout(False)
        Me.pnMenu.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnAgenda.ResumeLayout(False)
        Me.pnAgenda.PerformLayout()
        CType(Me.dtgCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMetaBanho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmsMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControleDaAgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendaDoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer3 As Timer
    Friend WithEvents MensagemAniversarioTutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensagemAniversárioPetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsAniH As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents cmsAniPet As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents pnVacinas As Panel
    Friend WithEvents dgVacinasDoMesOld As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pnAniversarios As Panel
    Friend WithEvents DgAniversarioAnimal As DataGridView
    Friend WithEvents DgAniversarioHumanos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents pnBotoes As Panel
    Friend WithEvents pnBtoAg As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents subBtoAgGeral As Button
    Friend WithEvents btoAgGeral As Button
    Friend WithEvents subBtoAgBanho As Button
    Friend WithEvents BtoAgBanho As Button
    Friend WithEvents subBtoAgCliente As Button
    Friend WithEvents btoAgCliente As Button
    Friend WithEvents btoAgenda As Button
    Friend WithEvents pnUsuario As Panel
    Friend WithEvents subBtoSistFat As Button
    Friend WithEvents btoFaturamento As Button
    Friend WithEvents subBtoRelatorios As Button
    Friend WithEvents btoRelatorios As Button
    Friend WithEvents subBtoCadUsuario As Button
    Friend WithEvents btoUsuario As Button
    Friend WithEvents subBtoCadFuncionario As Button
    Friend WithEvents btoFunc As Button
    Friend WithEvents btoUsuários As Button
    Friend WithEvents pnFinanceiroSub As Panel
    Friend WithEvents subBtoFluxos As Button
    Friend WithEvents btnFluxos As Button
    Friend WithEvents subBtoExtratoCliente As Button
    Friend WithEvents btoExtrato As Button
    Friend WithEvents subBtopdv As Button
    Friend WithEvents btoPDV As Button
    Friend WithEvents subBtoContas As Button
    Friend WithEvents BtoContasPagar As Button
    Friend WithEvents subBtoLancamentos As Button
    Friend WithEvents btoLanFinan As Button
    Friend WithEvents btoFi As Button
    Friend WithEvents pnProntuarioSub As Panel
    Friend WithEvents subBtoCadastros As Button
    Friend WithEvents btoPront As Button
    Friend WithEvents btoProntuario As Button
    Friend WithEvents pnMateriaisSub As Panel
    Friend WithEvents subBtoFornecedor As Button
    Friend WithEvents btoFrmFornec As Button
    Friend WithEvents subBtoEntrada As Button
    Friend WithEvents btoFrmEntrada As Button
    Friend WithEvents subBtoImportacao As Button
    Friend WithEvents btoImport As Button
    Friend WithEvents subBtoItens As Button
    Friend WithEvents btoItens As Button
    Friend WithEvents btoMateriais As Button
    Friend WithEvents pnCaixaSub2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents subBtoMovimento As Button
    Friend WithEvents btnCaixaMov As Button
    Friend WithEvents subBtoAbre As Button
    Friend WithEvents btnABcx As Button
    Friend WithEvents btoCaixa As Button
    Friend WithEvents pnMenu As Panel
    Friend WithEvents btnPN As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnAgenda As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgAgenda As DataGridView
    Friend WithEvents mcAgenda As MonthCalendar
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel3 As Panel
    Public WithEvents lblUsuario As Label
    Friend WithEvents AgendaDoPet As ToolStripMenuItem
    Friend WithEvents dtgCount As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvMetaBanho As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents subBtoCadPrestador As Button
    Friend WithEvents btoPrestador As Button
    Friend WithEvents txtDadosEmpresa As TextBox
    Public WithEvents txtFantasia As TextBox
End Class
