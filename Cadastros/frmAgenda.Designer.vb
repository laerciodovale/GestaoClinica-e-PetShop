<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgenda
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFunc = New System.Windows.Forms.ComboBox()
        Me.cboTpAgenda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mcAgenda = New System.Windows.Forms.MonthCalendar()
        Me.opAgendado = New System.Windows.Forms.RadioButton()
        Me.opAtendido = New System.Windows.Forms.RadioButton()
        Me.opFalta = New System.Windows.Forms.RadioButton()
        Me.opCancelado = New System.Windows.Forms.RadioButton()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.btoAlterar = New System.Windows.Forms.Button()
        Me.btoExcluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ddM = New System.Windows.Forms.DomainUpDown()
        Me.ddH = New System.Windows.Forms.DomainUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgAg = New System.Windows.Forms.DataGridView()
        Me.rbReAgenda = New System.Windows.Forms.RadioButton()
        Me.txtIdAg = New Cls_Controls.Cls_TextBox()
        Me.txtPet = New Cls_Controls.Cls_TextBox()
        Me.txtId = New Cls_Controls.Cls_TextBox()
        Me.txtCpf = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.mskFone = New Cls_Controls.Cls_TextBoxFone()
        Me.txtObs = New Cls_Controls.Cls_TextBox()
        Me.txtEmail = New Cls_Controls.Cls_TextBox()
        Me.txtCliente = New Cls_Controls.Cls_TextBox()
        Me.txtOs = New Cls_Controls.Cls_TextBox()
        Me.cboNomePet = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgAg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "OBS **"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(49, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 25)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "Fone 1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 25)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "E-Mail"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Cliente"
        '
        'cboFunc
        '
        Me.cboFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFunc.FormattingEnabled = True
        Me.cboFunc.Location = New System.Drawing.Point(124, 348)
        Me.cboFunc.Name = "cboFunc"
        Me.cboFunc.Size = New System.Drawing.Size(323, 37)
        Me.cboFunc.TabIndex = 9
        '
        'cboTpAgenda
        '
        Me.cboTpAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTpAgenda.FormattingEnabled = True
        Me.cboTpAgenda.Location = New System.Drawing.Point(124, 302)
        Me.cboTpAgenda.Name = "cboTpAgenda"
        Me.cboTpAgenda.Size = New System.Drawing.Size(323, 37)
        Me.cboTpAgenda.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Funcionario"
        '
        'mcAgenda
        '
        Me.mcAgenda.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.mcAgenda.AllowDrop = True
        Me.mcAgenda.BackColor = System.Drawing.Color.Black
        Me.mcAgenda.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.mcAgenda.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcAgenda.Location = New System.Drawing.Point(954, 12)
        Me.mcAgenda.MaxDate = New Date(2033, 12, 31, 0, 0, 0, 0)
        Me.mcAgenda.Name = "mcAgenda"
        Me.mcAgenda.TabIndex = 18
        Me.mcAgenda.TitleBackColor = System.Drawing.Color.DeepSkyBlue
        Me.mcAgenda.TrailingForeColor = System.Drawing.SystemColors.HotTrack
        '
        'opAgendado
        '
        Me.opAgendado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opAgendado.AutoSize = True
        Me.opAgendado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opAgendado.Location = New System.Drawing.Point(129, 416)
        Me.opAgendado.Name = "opAgendado"
        Me.opAgendado.Size = New System.Drawing.Size(124, 29)
        Me.opAgendado.TabIndex = 10
        Me.opAgendado.TabStop = True
        Me.opAgendado.Text = "Agendado"
        Me.opAgendado.UseVisualStyleBackColor = True
        '
        'opAtendido
        '
        Me.opAtendido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opAtendido.AutoSize = True
        Me.opAtendido.Enabled = False
        Me.opAtendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opAtendido.Location = New System.Drawing.Point(332, 416)
        Me.opAtendido.Name = "opAtendido"
        Me.opAtendido.Size = New System.Drawing.Size(111, 29)
        Me.opAtendido.TabIndex = 11
        Me.opAtendido.TabStop = True
        Me.opAtendido.Text = "Atendido"
        Me.opAtendido.UseVisualStyleBackColor = True
        '
        'opFalta
        '
        Me.opFalta.AutoSize = True
        Me.opFalta.Enabled = False
        Me.opFalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opFalta.Location = New System.Drawing.Point(556, 416)
        Me.opFalta.Name = "opFalta"
        Me.opFalta.Size = New System.Drawing.Size(76, 29)
        Me.opFalta.TabIndex = 12
        Me.opFalta.TabStop = True
        Me.opFalta.Text = "Falta"
        Me.opFalta.UseVisualStyleBackColor = True
        '
        'opCancelado
        '
        Me.opCancelado.AutoSize = True
        Me.opCancelado.Enabled = False
        Me.opCancelado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opCancelado.Location = New System.Drawing.Point(803, 416)
        Me.opCancelado.Name = "opCancelado"
        Me.opCancelado.Size = New System.Drawing.Size(128, 29)
        Me.opCancelado.TabIndex = 13
        Me.opCancelado.TabStop = True
        Me.opCancelado.Text = "Cancelado"
        Me.opCancelado.UseVisualStyleBackColor = True
        '
        'btoIncluir
        '
        Me.btoIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btoIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoIncluir.Location = New System.Drawing.Point(13, 475)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(269, 40)
        Me.btoIncluir.TabIndex = 15
        Me.btoIncluir.Text = "Incluir"
        Me.btoIncluir.UseVisualStyleBackColor = True
        '
        'btoAlterar
        '
        Me.btoAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAlterar.Location = New System.Drawing.Point(497, 475)
        Me.btoAlterar.Name = "btoAlterar"
        Me.btoAlterar.Size = New System.Drawing.Size(269, 40)
        Me.btoAlterar.TabIndex = 16
        Me.btoAlterar.Text = "Alterar"
        Me.btoAlterar.UseVisualStyleBackColor = True
        '
        'btoExcluir
        '
        Me.btoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoExcluir.Location = New System.Drawing.Point(954, 475)
        Me.btoExcluir.Name = "btoExcluir"
        Me.btoExcluir.Size = New System.Drawing.Size(269, 40)
        Me.btoExcluir.TabIndex = 17
        Me.btoExcluir.Text = "Excluir"
        Me.btoExcluir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ddM)
        Me.GroupBox1.Controls.Add(Me.ddH)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(954, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 107)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horário"
        '
        'ddM
        '
        Me.ddM.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddM.Items.Add("00")
        Me.ddM.Items.Add("15")
        Me.ddM.Items.Add("30")
        Me.ddM.Items.Add("45")
        Me.ddM.Location = New System.Drawing.Point(161, 33)
        Me.ddM.Name = "ddM"
        Me.ddM.Size = New System.Drawing.Size(80, 41)
        Me.ddM.TabIndex = 1
        Me.ddM.Text = "00"
        '
        'ddH
        '
        Me.ddH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddH.Items.Add("07")
        Me.ddH.Items.Add("08")
        Me.ddH.Items.Add("09")
        Me.ddH.Items.Add("10")
        Me.ddH.Items.Add("11")
        Me.ddH.Items.Add("12")
        Me.ddH.Items.Add("13")
        Me.ddH.Items.Add("14")
        Me.ddH.Items.Add("15")
        Me.ddH.Items.Add("16")
        Me.ddH.Items.Add("17")
        Me.ddH.Items.Add("18")
        Me.ddH.Items.Add("19")
        Me.ddH.Items.Add("")
        Me.ddH.Location = New System.Drawing.Point(23, 33)
        Me.ddH.Name = "ddH"
        Me.ddH.Size = New System.Drawing.Size(80, 41)
        Me.ddH.TabIndex = 1
        Me.ddH.Text = "07"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 25)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "CPF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 25)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Pet"
        '
        'DgAg
        '
        Me.DgAg.AllowUserToOrderColumns = True
        Me.DgAg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgAg.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DgAg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAg.GridColor = System.Drawing.Color.White
        Me.DgAg.Location = New System.Drawing.Point(13, 531)
        Me.DgAg.MultiSelect = False
        Me.DgAg.Name = "DgAg"
        Me.DgAg.RowHeadersWidth = 51
        Me.DgAg.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgAg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgAg.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DgAg.RowTemplate.Height = 24
        Me.DgAg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgAg.Size = New System.Drawing.Size(1210, 263)
        Me.DgAg.TabIndex = 165
        '
        'rbReAgenda
        '
        Me.rbReAgenda.AutoSize = True
        Me.rbReAgenda.Enabled = False
        Me.rbReAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbReAgenda.Location = New System.Drawing.Point(1030, 416)
        Me.rbReAgenda.Name = "rbReAgenda"
        Me.rbReAgenda.Size = New System.Drawing.Size(187, 29)
        Me.rbReAgenda.TabIndex = 14
        Me.rbReAgenda.TabStop = True
        Me.rbReAgenda.Text = "Re-Agendamento"
        Me.rbReAgenda.UseVisualStyleBackColor = True
        '
        'txtIdAg
        '
        Me.txtIdAg.Enabled = False
        Me.txtIdAg.EnviaTab = True
        Me.txtIdAg.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdAg.Location = New System.Drawing.Point(821, 16)
        Me.txtIdAg.Name = "txtIdAg"
        Me.txtIdAg.Size = New System.Drawing.Size(110, 38)
        Me.txtIdAg.SomenteNumero = False
        Me.txtIdAg.TabIndex = 19
        '
        'txtPet
        '
        Me.txtPet.EnviaTab = True
        Me.txtPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPet.Location = New System.Drawing.Point(558, 113)
        Me.txtPet.Name = "txtPet"
        Me.txtPet.Size = New System.Drawing.Size(74, 34)
        Me.txtPet.SomenteNumero = False
        Me.txtPet.TabIndex = 4
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.EnviaTab = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(685, 63)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(81, 34)
        Me.txtId.SomenteNumero = False
        Me.txtId.TabIndex = 3
        '
        'txtCpf
        '
        Me.txtCpf.CpfValido = True
        Me.txtCpf.EnviaTab = True
        Me.txtCpf.ExibirMensagem = False
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(124, 20)
        Me.txtCpf.MaxLength = 18
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(323, 34)
        Me.txtCpf.SomenteNumero = True
        Me.txtCpf.TabIndex = 2
        Me.txtCpf.ValidaCNPJ = True
        Me.txtCpf.ValidaCPF = False
        '
        'mskFone
        '
        Me.mskFone.EnviaTab = True
        Me.mskFone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFone.Location = New System.Drawing.Point(124, 165)
        Me.mskFone.Name = "mskFone"
        Me.mskFone.Size = New System.Drawing.Size(182, 34)
        Me.mskFone.SomenteNumero = False
        Me.mskFone.TabIndex = 5
        '
        'txtObs
        '
        Me.txtObs.EnviaTab = True
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(124, 263)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(428, 33)
        Me.txtObs.SomenteNumero = False
        Me.txtObs.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.EnviaTab = True
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(124, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(425, 34)
        Me.txtEmail.SomenteNumero = False
        Me.txtEmail.TabIndex = 6
        '
        'txtCliente
        '
        Me.txtCliente.EnviaTab = True
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(124, 64)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(508, 34)
        Me.txtCliente.SomenteNumero = False
        Me.txtCliente.TabIndex = 0
        '
        'txtOs
        '
        Me.txtOs.Enabled = False
        Me.txtOs.EnviaTab = True
        Me.txtOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOs.Location = New System.Drawing.Point(821, 59)
        Me.txtOs.Name = "txtOs"
        Me.txtOs.Size = New System.Drawing.Size(110, 38)
        Me.txtOs.SomenteNumero = False
        Me.txtOs.TabIndex = 167
        '
        'cboNomePet
        '
        Me.cboNomePet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNomePet.FormattingEnabled = True
        Me.cboNomePet.Location = New System.Drawing.Point(120, 113)
        Me.cboNomePet.Name = "cboNomePet"
        Me.cboNomePet.Size = New System.Drawing.Size(432, 37)
        Me.cboNomePet.TabIndex = 1
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1257, 806)
        Me.Controls.Add(Me.cboNomePet)
        Me.Controls.Add(Me.txtOs)
        Me.Controls.Add(Me.rbReAgenda)
        Me.Controls.Add(Me.DgAg)
        Me.Controls.Add(Me.txtIdAg)
        Me.Controls.Add(Me.txtPet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mskFone)
        Me.Controls.Add(Me.btoExcluir)
        Me.Controls.Add(Me.btoAlterar)
        Me.Controls.Add(Me.btoIncluir)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.opCancelado)
        Me.Controls.Add(Me.opFalta)
        Me.Controls.Add(Me.opAtendido)
        Me.Controls.Add(Me.opAgendado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFunc)
        Me.Controls.Add(Me.cboTpAgenda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mcAgenda)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgAg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents cboFunc As Windows.Forms.ComboBox
    Friend WithEvents cboTpAgenda As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents opAgendado As Windows.Forms.RadioButton
    Friend WithEvents opAtendido As Windows.Forms.RadioButton
    Friend WithEvents opFalta As Windows.Forms.RadioButton
    Friend WithEvents opCancelado As Windows.Forms.RadioButton
    Friend WithEvents txtCliente As Cls_Controls.Cls_TextBox
    Friend WithEvents txtEmail As Cls_Controls.Cls_TextBox
    Friend WithEvents txtObs As Cls_Controls.Cls_TextBox
    Friend WithEvents btoIncluir As Windows.Forms.Button
    Friend WithEvents btoAlterar As Windows.Forms.Button
    Friend WithEvents btoExcluir As Windows.Forms.Button
    Friend WithEvents mskFone As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents mcAgenda As Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents ddM As Windows.Forms.DomainUpDown
    Friend WithEvents ddH As Windows.Forms.DomainUpDown
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtCpf As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents txtId As Cls_Controls.Cls_TextBox
    Friend WithEvents txtPet As Cls_Controls.Cls_TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtIdAg As Cls_Controls.Cls_TextBox
    Friend WithEvents DgAg As Windows.Forms.DataGridView
    Friend WithEvents rbReAgenda As Windows.Forms.RadioButton
    Friend WithEvents txtOs As Cls_Controls.Cls_TextBox
    Friend WithEvents cboNomePet As Windows.Forms.ComboBox
End Class
