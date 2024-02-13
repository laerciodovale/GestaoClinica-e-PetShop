<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAtrasados = New Cls_Controls.Cls_TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAcre = New Cls_Controls.Cls_TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDcto = New Cls_Controls.Cls_TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAbertos = New Cls_Controls.Cls_TextBox()
        Me.txtPagos = New Cls_Controls.Cls_TextBox()
        Me.txtSaldo = New Cls_Controls.Cls_TextBox()
        Me.txtFaturado = New Cls_Controls.Cls_TextBox()
        Me.mskDtCx = New System.Windows.Forms.MonthCalendar()
        Me.dgDetLan = New System.Windows.Forms.DataGridView()
        Me.dgCaixa = New System.Windows.Forms.DataGridView()
        Me.Ck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbTotalDeb = New System.Windows.Forms.Label()
        Me.LbNomeAni = New Cls_Controls.Cls_TextBox()
        Me.LbCodAni = New Cls_Controls.Cls_TextBox()
        Me.lbNomeCli = New Cls_Controls.Cls_TextBox()
        Me.lbCodcli = New Cls_Controls.Cls_TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtVDcto = New Cls_Controls.Cls_TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtVAcr = New Cls_Controls.Cls_TextBox()
        Me.btoExcluir = New System.Windows.Forms.Button()
        Me.btoExtorno = New System.Windows.Forms.Button()
        Me.btoBaixa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVTroco = New Cls_Controls.Cls_TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVDinheiro = New Cls_Controls.Cls_TextBox()
        Me.txtVAdiant = New Cls_Controls.Cls_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVBaixa = New Cls_Controls.Cls_TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVFat = New Cls_Controls.Cls_TextBox()
        Me.txtNssNro = New Cls_Controls.Cls_TextBox()
        Me.cboFPagto = New Cls_Controls.Cls_ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnIncluirDesp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVlrDesp = New Cls_Controls.Cls_TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescDesp = New Cls_Controls.Cls_TextBox()
        Me.txtNomeDoCaixa = New Cls_Controls.Cls_TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDetLan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.mskDtCx)
        Me.Panel1.Controls.Add(Me.dgDetLan)
        Me.Panel1.Controls.Add(Me.dgCaixa)
        Me.Panel1.Location = New System.Drawing.Point(20, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 740)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtAtrasados)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtAcre)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtDcto)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtAbertos)
        Me.GroupBox4.Controls.Add(Me.txtPagos)
        Me.GroupBox4.Controls.Add(Me.txtSaldo)
        Me.GroupBox4.Controls.Add(Me.txtFaturado)
        Me.GroupBox4.Location = New System.Drawing.Point(326, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(545, 207)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Saldos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(333, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Atrasados"
        '
        'txtAtrasados
        '
        Me.txtAtrasados.EnviaTab = True
        Me.txtAtrasados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtrasados.Location = New System.Drawing.Point(411, 24)
        Me.txtAtrasados.Name = "txtAtrasados"
        Me.txtAtrasados.Size = New System.Drawing.Size(100, 26)
        Me.txtAtrasados.SomenteNumero = False
        Me.txtAtrasados.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Acréscimos"
        '
        'txtAcre
        '
        Me.txtAcre.EnviaTab = True
        Me.txtAcre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcre.Location = New System.Drawing.Point(99, 148)
        Me.txtAcre.Name = "txtAcre"
        Me.txtAcre.Size = New System.Drawing.Size(100, 26)
        Me.txtAcre.SomenteNumero = False
        Me.txtAcre.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Descontos"
        '
        'txtDcto
        '
        Me.txtDcto.EnviaTab = True
        Me.txtDcto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDcto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDcto.Location = New System.Drawing.Point(99, 84)
        Me.txtDcto.Name = "txtDcto"
        Me.txtDcto.Size = New System.Drawing.Size(100, 26)
        Me.txtDcto.SomenteNumero = False
        Me.txtDcto.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(340, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 31)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Caixa do dia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Abertos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Pagos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Faturamento"
        '
        'txtAbertos
        '
        Me.txtAbertos.EnviaTab = True
        Me.txtAbertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbertos.ForeColor = System.Drawing.Color.Red
        Me.txtAbertos.Location = New System.Drawing.Point(99, 49)
        Me.txtAbertos.Name = "txtAbertos"
        Me.txtAbertos.Size = New System.Drawing.Size(100, 26)
        Me.txtAbertos.SomenteNumero = False
        Me.txtAbertos.TabIndex = 3
        '
        'txtPagos
        '
        Me.txtPagos.EnviaTab = True
        Me.txtPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPagos.Location = New System.Drawing.Point(99, 116)
        Me.txtPagos.Name = "txtPagos"
        Me.txtPagos.Size = New System.Drawing.Size(100, 26)
        Me.txtPagos.SomenteNumero = False
        Me.txtPagos.TabIndex = 2
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.EnviaTab = True
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(336, 154)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(175, 38)
        Me.txtSaldo.SomenteNumero = False
        Me.txtSaldo.TabIndex = 1
        '
        'txtFaturado
        '
        Me.txtFaturado.EnviaTab = True
        Me.txtFaturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaturado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFaturado.Location = New System.Drawing.Point(99, 18)
        Me.txtFaturado.Name = "txtFaturado"
        Me.txtFaturado.Size = New System.Drawing.Size(100, 26)
        Me.txtFaturado.SomenteNumero = False
        Me.txtFaturado.TabIndex = 0
        '
        'mskDtCx
        '
        Me.mskDtCx.Location = New System.Drawing.Point(9, 6)
        Me.mskDtCx.Name = "mskDtCx"
        Me.mskDtCx.TabIndex = 9
        '
        'dgDetLan
        '
        Me.dgDetLan.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgDetLan.AllowUserToAddRows = False
        Me.dgDetLan.AllowUserToDeleteRows = False
        Me.dgDetLan.AllowUserToOrderColumns = True
        Me.dgDetLan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgDetLan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgDetLan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDetLan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgDetLan.ColumnHeadersHeight = 29
        Me.dgDetLan.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDetLan.Location = New System.Drawing.Point(9, 571)
        Me.dgDetLan.MultiSelect = False
        Me.dgDetLan.Name = "dgDetLan"
        Me.dgDetLan.ReadOnly = True
        Me.dgDetLan.RowHeadersVisible = False
        Me.dgDetLan.RowHeadersWidth = 51
        Me.dgDetLan.RowTemplate.Height = 24
        Me.dgDetLan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetLan.Size = New System.Drawing.Size(862, 162)
        Me.dgDetLan.StandardTab = True
        Me.dgDetLan.TabIndex = 8
        '
        'dgCaixa
        '
        Me.dgCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgCaixa.AllowUserToAddRows = False
        Me.dgCaixa.AllowUserToDeleteRows = False
        Me.dgCaixa.AllowUserToOrderColumns = True
        Me.dgCaixa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgCaixa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgCaixa.ColumnHeadersHeight = 29
        Me.dgCaixa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ck})
        Me.dgCaixa.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCaixa.Location = New System.Drawing.Point(9, 240)
        Me.dgCaixa.Name = "dgCaixa"
        Me.dgCaixa.RowHeadersVisible = False
        Me.dgCaixa.RowHeadersWidth = 51
        Me.dgCaixa.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver
        Me.dgCaixa.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgCaixa.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        Me.dgCaixa.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCaixa.RowTemplate.Height = 24
        Me.dgCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCaixa.Size = New System.Drawing.Size(862, 313)
        Me.dgCaixa.StandardTab = True
        Me.dgCaixa.TabIndex = 3
        '
        'Ck
        '
        Me.Ck.HeaderText = "Ck"
        Me.Ck.MinimumWidth = 6
        Me.Ck.Name = "Ck"
        Me.Ck.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbTotalDeb)
        Me.GroupBox1.Controls.Add(Me.LbNomeAni)
        Me.GroupBox1.Controls.Add(Me.LbCodAni)
        Me.GroupBox1.Controls.Add(Me.lbNomeCli)
        Me.GroupBox1.Controls.Add(Me.lbCodcli)
        Me.GroupBox1.Location = New System.Drawing.Point(928, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'lbTotalDeb
        '
        Me.lbTotalDeb.AutoSize = True
        Me.lbTotalDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalDeb.ForeColor = System.Drawing.Color.Red
        Me.lbTotalDeb.Location = New System.Drawing.Point(180, 72)
        Me.lbTotalDeb.Name = "lbTotalDeb"
        Me.lbTotalDeb.Size = New System.Drawing.Size(0, 31)
        Me.lbTotalDeb.TabIndex = 12
        '
        'LbNomeAni
        '
        Me.LbNomeAni.Enabled = False
        Me.LbNomeAni.EnviaTab = True
        Me.LbNomeAni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomeAni.Location = New System.Drawing.Point(108, 109)
        Me.LbNomeAni.Name = "LbNomeAni"
        Me.LbNomeAni.Size = New System.Drawing.Size(403, 30)
        Me.LbNomeAni.SomenteNumero = False
        Me.LbNomeAni.TabIndex = 3
        '
        'LbCodAni
        '
        Me.LbCodAni.Enabled = False
        Me.LbCodAni.EnviaTab = True
        Me.LbCodAni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodAni.Location = New System.Drawing.Point(23, 109)
        Me.LbCodAni.Name = "LbCodAni"
        Me.LbCodAni.Size = New System.Drawing.Size(79, 30)
        Me.LbCodAni.SomenteNumero = False
        Me.LbCodAni.TabIndex = 2
        '
        'lbNomeCli
        '
        Me.lbNomeCli.Enabled = False
        Me.lbNomeCli.EnviaTab = True
        Me.lbNomeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomeCli.Location = New System.Drawing.Point(108, 39)
        Me.lbNomeCli.Name = "lbNomeCli"
        Me.lbNomeCli.Size = New System.Drawing.Size(403, 30)
        Me.lbNomeCli.SomenteNumero = False
        Me.lbNomeCli.TabIndex = 1
        '
        'lbCodcli
        '
        Me.lbCodcli.Enabled = False
        Me.lbCodcli.EnviaTab = True
        Me.lbCodcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodcli.Location = New System.Drawing.Point(23, 39)
        Me.lbCodcli.Name = "lbCodcli"
        Me.lbCodcli.Size = New System.Drawing.Size(79, 30)
        Me.lbCodcli.SomenteNumero = False
        Me.lbCodcli.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtVDcto)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtVAcr)
        Me.GroupBox2.Controls.Add(Me.btoExcluir)
        Me.GroupBox2.Controls.Add(Me.btoExtorno)
        Me.GroupBox2.Controls.Add(Me.btoBaixa)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtVTroco)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtVDinheiro)
        Me.GroupBox2.Controls.Add(Me.txtVAdiant)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtVBaixa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtVFat)
        Me.GroupBox2.Controls.Add(Me.txtNssNro)
        Me.GroupBox2.Controls.Add(Me.cboFPagto)
        Me.GroupBox2.Location = New System.Drawing.Point(928, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 315)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados para a Baixa"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(280, 234)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Desconto"
        '
        'txtVDcto
        '
        Me.txtVDcto.Enabled = False
        Me.txtVDcto.EnviaTab = True
        Me.txtVDcto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVDcto.Location = New System.Drawing.Point(354, 224)
        Me.txtVDcto.Name = "txtVDcto"
        Me.txtVDcto.Size = New System.Drawing.Size(117, 30)
        Me.txtVDcto.SomenteNumero = False
        Me.txtVDcto.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(48, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 17)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Acrécimo"
        '
        'txtVAcr
        '
        Me.txtVAcr.Enabled = False
        Me.txtVAcr.EnviaTab = True
        Me.txtVAcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAcr.Location = New System.Drawing.Point(120, 224)
        Me.txtVAcr.Name = "txtVAcr"
        Me.txtVAcr.Size = New System.Drawing.Size(117, 30)
        Me.txtVAcr.SomenteNumero = False
        Me.txtVAcr.TabIndex = 18
        '
        'btoExcluir
        '
        Me.btoExcluir.Image = CType(resources.GetObject("btoExcluir.Image"), System.Drawing.Image)
        Me.btoExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoExcluir.Location = New System.Drawing.Point(355, 277)
        Me.btoExcluir.Name = "btoExcluir"
        Me.btoExcluir.Size = New System.Drawing.Size(151, 32)
        Me.btoExcluir.TabIndex = 17
        Me.btoExcluir.Text = "Excluir"
        Me.btoExcluir.UseVisualStyleBackColor = True
        '
        'btoExtorno
        '
        Me.btoExtorno.Location = New System.Drawing.Point(174, 277)
        Me.btoExtorno.Name = "btoExtorno"
        Me.btoExtorno.Size = New System.Drawing.Size(151, 32)
        Me.btoExtorno.TabIndex = 8
        Me.btoExtorno.Text = "Estorno"
        Me.btoExtorno.UseVisualStyleBackColor = True
        '
        'btoBaixa
        '
        Me.btoBaixa.Location = New System.Drawing.Point(17, 277)
        Me.btoBaixa.Name = "btoBaixa"
        Me.btoBaixa.Size = New System.Drawing.Size(151, 32)
        Me.btoBaixa.TabIndex = 7
        Me.btoBaixa.Text = "Baixar"
        Me.btoBaixa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Troco"
        '
        'txtVTroco
        '
        Me.txtVTroco.Enabled = False
        Me.txtVTroco.EnviaTab = True
        Me.txtVTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVTroco.Location = New System.Drawing.Point(354, 188)
        Me.txtVTroco.Name = "txtVTroco"
        Me.txtVTroco.Size = New System.Drawing.Size(117, 30)
        Me.txtVTroco.SomenteNumero = False
        Me.txtVTroco.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dinheiro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "$ Adiant."
        '
        'txtVDinheiro
        '
        Me.txtVDinheiro.EnviaTab = True
        Me.txtVDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVDinheiro.Location = New System.Drawing.Point(120, 188)
        Me.txtVDinheiro.Name = "txtVDinheiro"
        Me.txtVDinheiro.Size = New System.Drawing.Size(117, 30)
        Me.txtVDinheiro.SomenteNumero = False
        Me.txtVDinheiro.TabIndex = 5
        '
        'txtVAdiant
        '
        Me.txtVAdiant.Enabled = False
        Me.txtVAdiant.EnviaTab = True
        Me.txtVAdiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAdiant.Location = New System.Drawing.Point(421, 137)
        Me.txtVAdiant.Name = "txtVAdiant"
        Me.txtVAdiant.Size = New System.Drawing.Size(85, 26)
        Me.txtVAdiant.SomenteNumero = False
        Me.txtVAdiant.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "$ Baixa"
        '
        'txtVBaixa
        '
        Me.txtVBaixa.EnviaTab = True
        Me.txtVBaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVBaixa.Location = New System.Drawing.Point(243, 137)
        Me.txtVBaixa.Name = "txtVBaixa"
        Me.txtVBaixa.Size = New System.Drawing.Size(85, 26)
        Me.txtVBaixa.SomenteNumero = False
        Me.txtVBaixa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "$ Fatura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NssNro"
        '
        'txtVFat
        '
        Me.txtVFat.Enabled = False
        Me.txtVFat.EnviaTab = True
        Me.txtVFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVFat.Location = New System.Drawing.Point(73, 137)
        Me.txtVFat.Name = "txtVFat"
        Me.txtVFat.Size = New System.Drawing.Size(85, 26)
        Me.txtVFat.SomenteNumero = False
        Me.txtVFat.TabIndex = 2
        '
        'txtNssNro
        '
        Me.txtNssNro.EnviaTab = True
        Me.txtNssNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNssNro.Location = New System.Drawing.Point(234, 21)
        Me.txtNssNro.Name = "txtNssNro"
        Me.txtNssNro.Size = New System.Drawing.Size(85, 30)
        Me.txtNssNro.SomenteNumero = False
        Me.txtNssNro.TabIndex = 0
        '
        'cboFPagto
        '
        Me.cboFPagto.EnviaTab = True
        Me.cboFPagto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboFPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFPagto.FormattingEnabled = True
        Me.cboFPagto.Items.AddRange(New Object() {"Á Vista", "PIX", "Cartão Débito", "Cartão Crédito Á Vista", "Cartão Crédito x 2", "Cartão Crédito x 3", "Cartão Crédito x 4", "Outros"})
        Me.cboFPagto.Location = New System.Drawing.Point(23, 77)
        Me.cboFPagto.Name = "cboFPagto"
        Me.cboFPagto.Size = New System.Drawing.Size(490, 28)
        Me.cboFPagto.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnIncluirDesp)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtVlrDesp)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtDescDesp)
        Me.GroupBox3.Location = New System.Drawing.Point(928, 583)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(519, 157)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Saída do Caixa (Lançamento de Despesas)"
        '
        'btnIncluirDesp
        '
        Me.btnIncluirDesp.Location = New System.Drawing.Point(108, 114)
        Me.btnIncluirDesp.Name = "btnIncluirDesp"
        Me.btnIncluirDesp.Size = New System.Drawing.Size(103, 37)
        Me.btnIncluirDesp.TabIndex = 2
        Me.btnIncluirDesp.Text = "Incluir"
        Me.btnIncluirDesp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Valor"
        '
        'txtVlrDesp
        '
        Me.txtVlrDesp.EnviaTab = True
        Me.txtVlrDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrDesp.Location = New System.Drawing.Point(108, 66)
        Me.txtVlrDesp.Name = "txtVlrDesp"
        Me.txtVlrDesp.Size = New System.Drawing.Size(85, 26)
        Me.txtVlrDesp.SomenteNumero = False
        Me.txtVlrDesp.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Descrição "
        '
        'txtDescDesp
        '
        Me.txtDescDesp.EnviaTab = True
        Me.txtDescDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescDesp.Location = New System.Drawing.Point(108, 28)
        Me.txtDescDesp.Name = "txtDescDesp"
        Me.txtDescDesp.Size = New System.Drawing.Size(363, 26)
        Me.txtDescDesp.SomenteNumero = False
        Me.txtDescDesp.TabIndex = 0
        '
        'txtNomeDoCaixa
        '
        Me.txtNomeDoCaixa.Enabled = False
        Me.txtNomeDoCaixa.EnviaTab = True
        Me.txtNomeDoCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeDoCaixa.Location = New System.Drawing.Point(937, 10)
        Me.txtNomeDoCaixa.Name = "txtNomeDoCaixa"
        Me.txtNomeDoCaixa.Size = New System.Drawing.Size(101, 26)
        Me.txtNomeDoCaixa.SomenteNumero = False
        Me.txtNomeDoCaixa.TabIndex = 7
        Me.txtNomeDoCaixa.Visible = False
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1474, 764)
        Me.Controls.Add(Me.txtNomeDoCaixa)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Movimento de Caixa"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgDetLan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lbNomeCli As Cls_Controls.Cls_TextBox
    Friend WithEvents lbCodcli As Cls_Controls.Cls_TextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents btoExtorno As Windows.Forms.Button
    Friend WithEvents btoBaixa As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtVTroco As Cls_Controls.Cls_TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtVDinheiro As Cls_Controls.Cls_TextBox
    Friend WithEvents txtVAdiant As Cls_Controls.Cls_TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtVBaixa As Cls_Controls.Cls_TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtVFat As Cls_Controls.Cls_TextBox
    Friend WithEvents txtNssNro As Cls_Controls.Cls_TextBox
    Friend WithEvents cboFPagto As Cls_Controls.Cls_ComboBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents btnIncluirDesp As Windows.Forms.Button
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtVlrDesp As Cls_Controls.Cls_TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtDescDesp As Cls_Controls.Cls_TextBox
    Friend WithEvents LbNomeAni As Cls_Controls.Cls_TextBox
    Friend WithEvents LbCodAni As Cls_Controls.Cls_TextBox
    Friend WithEvents dgCaixa As Windows.Forms.DataGridView
    Public WithEvents txtNomeDoCaixa As Cls_Controls.Cls_TextBox
    Friend WithEvents dgDetLan As Windows.Forms.DataGridView
    Friend WithEvents mskDtCx As Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents txtAbertos As Cls_Controls.Cls_TextBox
    Friend WithEvents txtPagos As Cls_Controls.Cls_TextBox
    Friend WithEvents txtSaldo As Cls_Controls.Cls_TextBox
    Friend WithEvents txtFaturado As Cls_Controls.Cls_TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txtDcto As Cls_Controls.Cls_TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txtAcre As Cls_Controls.Cls_TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txtAtrasados As Cls_Controls.Cls_TextBox
    Friend WithEvents lbTotalDeb As Windows.Forms.Label
    Friend WithEvents btoExcluir As Windows.Forms.Button
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtVDcto As Cls_Controls.Cls_TextBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txtVAcr As Cls_Controls.Cls_TextBox
    Friend WithEvents Ck As Windows.Forms.DataGridViewCheckBoxColumn
End Class
