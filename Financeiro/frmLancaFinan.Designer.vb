<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLancaFinan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancaFinan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCB = New Cls_Controls.Cls_TextBoxOld()
        Me.dgItens = New System.Windows.Forms.DataGridView()
        Me.txtItemBusca = New Cls_Controls.Cls_TextBoxOld()
        Me.GrupoBaixa = New System.Windows.Forms.GroupBox()
        Me.btnBaixa = New System.Windows.Forms.Button()
        Me.btnExtornar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboFPagto = New Cls_Controls.Cls_ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBaixa = New Cls_Controls.Cls_TextBoxOld()
        Me.txtFaturado = New Cls_Controls.Cls_TextBoxOld()
        Me.txtNssNro = New Cls_Controls.Cls_TextBoxOld()
        Me.cboGrupo = New Cls_Controls.Cls_ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tx1 = New Cls_Controls.Cls_TextBoxOld()
        Me.lbQtd = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBruto = New Cls_Controls.Cls_TextBoxOld()
        Me.txtVDcto = New Cls_Controls.Cls_TextBoxOld()
        Me.txtPercDcto = New Cls_Controls.Cls_TextBoxOld()
        Me.txtUnit = New Cls_Controls.Cls_TextBoxOld()
        Me.txtQtd = New Cls_Controls.Cls_TextBoxOld()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescItem = New Cls_Controls.Cls_TextBoxOld()
        Me.txtItem = New Cls_Controls.Cls_TextBoxOld()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btoAgEstetica = New System.Windows.Forms.Button()
        Me.dgListaFat = New System.Windows.Forms.DataGridView()
        Me.cmsListaFat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ckOrcamento = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btoFaturar = New System.Windows.Forms.Button()
        Me.btoListar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mskDtNasAni = New Cls_Controls.Cls_TextBoxData()
        Me.txtBxNomeAni = New Cls_Controls.Cls_TextBoxOld()
        Me.txtBxIdPac = New Cls_Controls.Cls_TextBoxOld()
        Me.txtBxNomeCli = New Cls_Controls.Cls_TextBoxOld()
        Me.txtBxIdCli = New Cls_Controls.Cls_TextBoxOld()
        Me.cboFunc = New Cls_Controls.Cls_ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoBaixa.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgListaFat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsListaFat.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCB)
        Me.GroupBox1.Controls.Add(Me.dgItens)
        Me.GroupBox1.Controls.Add(Me.txtItemBusca)
        Me.GroupBox1.Controls.Add(Me.cboGrupo)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 721)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Itens"
        '
        'txtCB
        '
        Me.txtCB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCB.EnviaTab = True
        Me.txtCB.Location = New System.Drawing.Point(28, 114)
        Me.txtCB.Name = "txtCB"
        Me.txtCB.Size = New System.Drawing.Size(198, 26)
        Me.txtCB.SomenteNumero = False
        Me.txtCB.TabIndex = 4
        '
        'dgItens
        '
        Me.dgItens.AllowUserToAddRows = False
        Me.dgItens.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgItens.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItens.GridColor = System.Drawing.Color.White
        Me.dgItens.Location = New System.Drawing.Point(6, 156)
        Me.dgItens.MultiSelect = False
        Me.dgItens.Name = "dgItens"
        Me.dgItens.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItens.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgItens.RowHeadersVisible = False
        Me.dgItens.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.dgItens.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgItens.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgItens.RowTemplate.Height = 24
        Me.dgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItens.Size = New System.Drawing.Size(522, 550)
        Me.dgItens.TabIndex = 2
        '
        'txtItemBusca
        '
        Me.txtItemBusca.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtItemBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemBusca.EnviaTab = True
        Me.txtItemBusca.Location = New System.Drawing.Point(28, 68)
        Me.txtItemBusca.Name = "txtItemBusca"
        Me.txtItemBusca.Size = New System.Drawing.Size(447, 26)
        Me.txtItemBusca.SomenteNumero = False
        Me.txtItemBusca.TabIndex = 1
        '
        'GrupoBaixa
        '
        Me.GrupoBaixa.Controls.Add(Me.btnBaixa)
        Me.GrupoBaixa.Controls.Add(Me.btnExtornar)
        Me.GrupoBaixa.Controls.Add(Me.btnExcluir)
        Me.GrupoBaixa.Controls.Add(Me.Label9)
        Me.GrupoBaixa.Controls.Add(Me.cboFPagto)
        Me.GrupoBaixa.Controls.Add(Me.Label6)
        Me.GrupoBaixa.Controls.Add(Me.Label7)
        Me.GrupoBaixa.Controls.Add(Me.Label8)
        Me.GrupoBaixa.Controls.Add(Me.txtBaixa)
        Me.GrupoBaixa.Controls.Add(Me.txtFaturado)
        Me.GrupoBaixa.Controls.Add(Me.txtNssNro)
        Me.GrupoBaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoBaixa.Location = New System.Drawing.Point(561, 512)
        Me.GrupoBaixa.Name = "GrupoBaixa"
        Me.GrupoBaixa.Size = New System.Drawing.Size(882, 163)
        Me.GrupoBaixa.TabIndex = 3
        Me.GrupoBaixa.TabStop = False
        Me.GrupoBaixa.Text = "Baixa"
        Me.GrupoBaixa.Visible = False
        '
        'btnBaixa
        '
        Me.btnBaixa.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnBaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaixa.Image = Global.Financeiro.My.Resources.Resources._money_bank_payment_Azul1
        Me.btnBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaixa.Location = New System.Drawing.Point(611, 93)
        Me.btnBaixa.Name = "btnBaixa"
        Me.btnBaixa.Size = New System.Drawing.Size(170, 53)
        Me.btnBaixa.TabIndex = 20
        Me.btnBaixa.Text = "Baixar"
        Me.btnBaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBaixa.UseVisualStyleBackColor = True
        '
        'btnExtornar
        '
        Me.btnExtornar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExtornar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnExtornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExtornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtornar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtornar.Image = Global.Financeiro.My.Resources.Resources.cancel_localizacao
        Me.btnExtornar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtornar.Location = New System.Drawing.Point(307, 94)
        Me.btnExtornar.Name = "btnExtornar"
        Me.btnExtornar.Size = New System.Drawing.Size(170, 53)
        Me.btnExtornar.TabIndex = 19
        Me.btnExtornar.Text = "Estornar"
        Me.btnExtornar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExtornar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.Financeiro.My.Resources.Resources.delete_location
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(33, 93)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(170, 53)
        Me.btnExcluir.TabIndex = 18
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(445, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Forma de Pagamento"
        '
        'cboFPagto
        '
        Me.cboFPagto.EnviaTab = True
        Me.cboFPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFPagto.FormattingEnabled = True
        Me.cboFPagto.Location = New System.Drawing.Point(433, 47)
        Me.cboFPagto.Name = "cboFPagto"
        Me.cboFPagto.Size = New System.Drawing.Size(434, 33)
        Me.cboFPagto.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "$ Baixa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "$ Faturado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "NssNro"
        '
        'txtBaixa
        '
        Me.txtBaixa.EnviaTab = True
        Me.txtBaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaixa.Location = New System.Drawing.Point(289, 47)
        Me.txtBaixa.Name = "txtBaixa"
        Me.txtBaixa.Size = New System.Drawing.Size(120, 30)
        Me.txtBaixa.SomenteNumero = False
        Me.txtBaixa.TabIndex = 11
        '
        'txtFaturado
        '
        Me.txtFaturado.EnviaTab = True
        Me.txtFaturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaturado.Location = New System.Drawing.Point(156, 47)
        Me.txtFaturado.Name = "txtFaturado"
        Me.txtFaturado.Size = New System.Drawing.Size(120, 30)
        Me.txtFaturado.SomenteNumero = False
        Me.txtFaturado.TabIndex = 10
        '
        'txtNssNro
        '
        Me.txtNssNro.EnviaTab = True
        Me.txtNssNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNssNro.Location = New System.Drawing.Point(15, 47)
        Me.txtNssNro.Name = "txtNssNro"
        Me.txtNssNro.Size = New System.Drawing.Size(120, 30)
        Me.txtNssNro.SomenteNumero = False
        Me.txtNssNro.TabIndex = 9
        '
        'cboGrupo
        '
        Me.cboGrupo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cboGrupo.EnviaTab = True
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(25, 27)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(451, 28)
        Me.cboGrupo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tx1)
        Me.GroupBox2.Controls.Add(Me.lbQtd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtBruto)
        Me.GroupBox2.Controls.Add(Me.txtVDcto)
        Me.GroupBox2.Controls.Add(Me.txtPercDcto)
        Me.GroupBox2.Controls.Add(Me.txtUnit)
        Me.GroupBox2.Controls.Add(Me.txtQtd)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDescItem)
        Me.GroupBox2.Controls.Add(Me.txtItem)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(586, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(883, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descrição do Item"
        '
        'Tx1
        '
        Me.Tx1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Tx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tx1.EnviaTab = True
        Me.Tx1.Location = New System.Drawing.Point(643, 23)
        Me.Tx1.Name = "Tx1"
        Me.Tx1.Size = New System.Drawing.Size(65, 26)
        Me.Tx1.SomenteNumero = False
        Me.Tx1.TabIndex = 16
        Me.Tx1.Visible = False
        '
        'lbQtd
        '
        Me.lbQtd.AutoSize = True
        Me.lbQtd.Location = New System.Drawing.Point(819, 95)
        Me.lbQtd.Name = "lbQtd"
        Me.lbQtd.Size = New System.Drawing.Size(49, 20)
        Me.lbQtd.TabIndex = 15
        Me.lbQtd.Text = "QTD."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(686, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "$ Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "$ Dcto."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "% Desc."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "$ Unit"
        '
        'txtBruto
        '
        Me.txtBruto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBruto.EnviaTab = True
        Me.txtBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBruto.Location = New System.Drawing.Point(666, 93)
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.Size = New System.Drawing.Size(114, 34)
        Me.txtBruto.SomenteNumero = False
        Me.txtBruto.TabIndex = 10
        '
        'txtVDcto
        '
        Me.txtVDcto.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtVDcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVDcto.EnviaTab = True
        Me.txtVDcto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVDcto.Location = New System.Drawing.Point(488, 95)
        Me.txtVDcto.Name = "txtVDcto"
        Me.txtVDcto.Size = New System.Drawing.Size(90, 30)
        Me.txtVDcto.SomenteNumero = False
        Me.txtVDcto.TabIndex = 9
        '
        'txtPercDcto
        '
        Me.txtPercDcto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPercDcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPercDcto.EnviaTab = True
        Me.txtPercDcto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPercDcto.Location = New System.Drawing.Point(340, 95)
        Me.txtPercDcto.Name = "txtPercDcto"
        Me.txtPercDcto.Size = New System.Drawing.Size(90, 30)
        Me.txtPercDcto.SomenteNumero = False
        Me.txtPercDcto.TabIndex = 8
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Enabled = False
        Me.txtUnit.EnviaTab = True
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(187, 95)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(119, 30)
        Me.txtUnit.SomenteNumero = False
        Me.txtUnit.TabIndex = 7
        '
        'txtQtd
        '
        Me.txtQtd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtd.EnviaTab = True
        Me.txtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(18, 93)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(90, 30)
        Me.txtQtd.SomenteNumero = False
        Me.txtQtd.TabIndex = 6
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Qtd."
        '
        'txtDescItem
        '
        Me.txtDescItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtDescItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescItem.EnviaTab = True
        Me.txtDescItem.Location = New System.Drawing.Point(134, 23)
        Me.txtDescItem.Name = "txtDescItem"
        Me.txtDescItem.Size = New System.Drawing.Size(500, 26)
        Me.txtDescItem.SomenteNumero = False
        Me.txtDescItem.TabIndex = 3
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.Enabled = False
        Me.txtItem.EnviaTab = True
        Me.txtItem.Location = New System.Drawing.Point(6, 23)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(122, 26)
        Me.txtItem.SomenteNumero = False
        Me.txtItem.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.cboFunc)
        Me.GroupBox3.Controls.Add(Me.btoAgEstetica)
        Me.GroupBox3.Controls.Add(Me.dgListaFat)
        Me.GroupBox3.Controls.Add(Me.ckOrcamento)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.btoFaturar)
        Me.GroupBox3.Controls.Add(Me.btoListar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(587, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(882, 439)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lançamento"
        '
        'btoAgEstetica
        '
        Me.btoAgEstetica.Enabled = False
        Me.btoAgEstetica.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoAgEstetica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btoAgEstetica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btoAgEstetica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAgEstetica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgEstetica.Image = Global.Financeiro.My.Resources.Resources.calender_day_corlor
        Me.btoAgEstetica.Location = New System.Drawing.Point(729, 363)
        Me.btoAgEstetica.Name = "btoAgEstetica"
        Me.btoAgEstetica.Size = New System.Drawing.Size(70, 53)
        Me.btoAgEstetica.TabIndex = 224
        Me.btoAgEstetica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoAgEstetica.UseVisualStyleBackColor = True
        '
        'dgListaFat
        '
        Me.dgListaFat.AllowUserToAddRows = False
        Me.dgListaFat.AllowUserToDeleteRows = False
        Me.dgListaFat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgListaFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListaFat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgListaFat.ColumnHeadersHeight = 29
        Me.dgListaFat.ContextMenuStrip = Me.cmsListaFat
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgListaFat.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgListaFat.GridColor = System.Drawing.Color.White
        Me.dgListaFat.Location = New System.Drawing.Point(6, 57)
        Me.dgListaFat.MultiSelect = False
        Me.dgListaFat.Name = "dgListaFat"
        Me.dgListaFat.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListaFat.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgListaFat.RowHeadersVisible = False
        Me.dgListaFat.RowHeadersWidth = 51
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dgListaFat.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgListaFat.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgListaFat.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgListaFat.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgListaFat.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgListaFat.RowTemplate.Height = 24
        Me.dgListaFat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgListaFat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaFat.Size = New System.Drawing.Size(850, 300)
        Me.dgListaFat.TabIndex = 223
        '
        'cmsListaFat
        '
        Me.cmsListaFat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsListaFat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cmsListaFat.Name = "cmsListaFat"
        Me.cmsListaFat.Size = New System.Drawing.Size(162, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 24)
        Me.ToolStripMenuItem1.Text = "Deletar Item"
        '
        'ckOrcamento
        '
        Me.ckOrcamento.AutoSize = True
        Me.ckOrcamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckOrcamento.Location = New System.Drawing.Point(36, 23)
        Me.ckOrcamento.Name = "ckOrcamento"
        Me.ckOrcamento.Size = New System.Drawing.Size(114, 24)
        Me.ckOrcamento.TabIndex = 14
        Me.ckOrcamento.Text = "Orçamento"
        Me.ckOrcamento.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(599, 386)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(46, 20)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total"
        '
        'btoFaturar
        '
        Me.btoFaturar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoFaturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btoFaturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btoFaturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoFaturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoFaturar.Image = Global.Financeiro.My.Resources.Resources.money_bank_Verde
        Me.btoFaturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoFaturar.Location = New System.Drawing.Point(98, 363)
        Me.btoFaturar.Name = "btoFaturar"
        Me.btoFaturar.Size = New System.Drawing.Size(207, 53)
        Me.btoFaturar.TabIndex = 6
        Me.btoFaturar.Text = "Faturar = F 11"
        Me.btoFaturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btoFaturar.UseVisualStyleBackColor = True
        '
        'btoListar
        '
        Me.btoListar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btoListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue
        Me.btoListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btoListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoListar.Location = New System.Drawing.Point(629, 19)
        Me.btoListar.Name = "btoListar"
        Me.btoListar.Size = New System.Drawing.Size(227, 31)
        Me.btoListar.TabIndex = 5
        Me.btoListar.Text = "Colocar na Lista = F12"
        Me.btoListar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mskDtNasAni)
        Me.GroupBox4.Controls.Add(Me.txtBxNomeAni)
        Me.GroupBox4.Controls.Add(Me.txtBxIdPac)
        Me.GroupBox4.Controls.Add(Me.txtBxNomeCli)
        Me.GroupBox4.Controls.Add(Me.txtBxIdCli)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Location = New System.Drawing.Point(587, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(813, 90)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados do Cliente"
        '
        'mskDtNasAni
        '
        Me.mskDtNasAni.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mskDtNasAni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDtNasAni.Enabled = False
        Me.mskDtNasAni.EnviaTab = True
        Me.mskDtNasAni.Location = New System.Drawing.Point(710, 30)
        Me.mskDtNasAni.Name = "mskDtNasAni"
        Me.mskDtNasAni.Size = New System.Drawing.Size(97, 22)
        Me.mskDtNasAni.SomenteNumero = True
        Me.mskDtNasAni.TabIndex = 10
        '
        'txtBxNomeAni
        '
        Me.txtBxNomeAni.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtBxNomeAni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBxNomeAni.Enabled = False
        Me.txtBxNomeAni.EnviaTab = True
        Me.txtBxNomeAni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNomeAni.Location = New System.Drawing.Point(113, 54)
        Me.txtBxNomeAni.Name = "txtBxNomeAni"
        Me.txtBxNomeAni.Size = New System.Drawing.Size(574, 30)
        Me.txtBxNomeAni.SomenteNumero = False
        Me.txtBxNomeAni.TabIndex = 9
        '
        'txtBxIdPac
        '
        Me.txtBxIdPac.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtBxIdPac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBxIdPac.Enabled = False
        Me.txtBxIdPac.EnviaTab = True
        Me.txtBxIdPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxIdPac.Location = New System.Drawing.Point(17, 54)
        Me.txtBxIdPac.Name = "txtBxIdPac"
        Me.txtBxIdPac.Size = New System.Drawing.Size(66, 26)
        Me.txtBxIdPac.SomenteNumero = False
        Me.txtBxIdPac.TabIndex = 8
        '
        'txtBxNomeCli
        '
        Me.txtBxNomeCli.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtBxNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBxNomeCli.Enabled = False
        Me.txtBxNomeCli.EnviaTab = True
        Me.txtBxNomeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNomeCli.Location = New System.Drawing.Point(113, 26)
        Me.txtBxNomeCli.Name = "txtBxNomeCli"
        Me.txtBxNomeCli.Size = New System.Drawing.Size(574, 30)
        Me.txtBxNomeCli.SomenteNumero = False
        Me.txtBxNomeCli.TabIndex = 7
        '
        'txtBxIdCli
        '
        Me.txtBxIdCli.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtBxIdCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBxIdCli.Enabled = False
        Me.txtBxIdCli.EnviaTab = True
        Me.txtBxIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxIdCli.Location = New System.Drawing.Point(17, 26)
        Me.txtBxIdCli.Name = "txtBxIdCli"
        Me.txtBxIdCli.Size = New System.Drawing.Size(66, 26)
        Me.txtBxIdCli.SomenteNumero = False
        Me.txtBxIdCli.TabIndex = 6
        '
        'cboFunc
        '
        Me.cboFunc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cboFunc.EnviaTab = True
        Me.cboFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFunc.FormattingEnabled = True
        Me.cboFunc.Location = New System.Drawing.Point(189, 19)
        Me.cboFunc.Name = "cboFunc"
        Me.cboFunc.Size = New System.Drawing.Size(391, 33)
        Me.cboFunc.TabIndex = 225
        '
        'frmLancaFinan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1481, 746)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrupoBaixa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLancaFinan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lança Financeiro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoBaixa.ResumeLayout(False)
        Me.GrupoBaixa.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgListaFat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsListaFat.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents dgItens As Windows.Forms.DataGridView
    Friend WithEvents txtItemBusca As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents cboGrupo As Cls_Controls.Cls_ComboBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents lbQtd As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtBruto As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtVDcto As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtPercDcto As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtUnit As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtQtd As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtDescItem As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtItem As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents ckOrcamento As Windows.Forms.CheckBox
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents btoFaturar As Windows.Forms.Button
    Friend WithEvents btoListar As Windows.Forms.Button
    Friend WithEvents GrupoBaixa As Windows.Forms.GroupBox
    Friend WithEvents btnBaixa As Windows.Forms.Button
    Friend WithEvents btnExtornar As Windows.Forms.Button
    Friend WithEvents btnExcluir As Windows.Forms.Button
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents cboFPagto As Cls_Controls.Cls_ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtBaixa As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtFaturado As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtNssNro As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents cmsListaFat As Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tx1 As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents txtBxNomeAni As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtBxIdPac As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtBxNomeCli As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtBxIdCli As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents mskDtNasAni As Cls_Controls.Cls_TextBoxData
    Private WithEvents dgListaFat As Windows.Forms.DataGridView
    Friend WithEvents btoAgEstetica As Windows.Forms.Button
    Friend WithEvents txtCB As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents cboFunc As Cls_Controls.Cls_ComboBox
End Class
