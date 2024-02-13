<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCtaPg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtaPg))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTermino = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDeb = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtPago = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtAPagar = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgCtaPg = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtHist = New Cls_Controls.Cls_TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboFPagto = New Cls_Controls.Cls_ComboBox()
        Me.txtDocPagto = New Cls_Controls.Cls_TextBox()
        Me.txtDtPagto = New Cls_Controls.Cls_TextBoxData()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btoPagto = New System.Windows.Forms.Button()
        Me.btoEstorno = New System.Windows.Forms.Button()
        Me.txtVdoPagto = New Cls_Controls.Cls_TexBoxMonetario()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFaltante = New Cls_Controls.Cls_TexBoxMonetario()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtValorPago = New Cls_Controls.Cls_TexBoxMonetario()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalLancDupl = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtId = New Cls_Controls.Cls_TextBox()
        Me.dgDupl = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOrdemDupl = New Cls_Controls.Cls_TextBox()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.btoExcluir = New System.Windows.Forms.Button()
        Me.txtVDupl = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtDtVcto = New Cls_Controls.Cls_TextBoxData()
        Me.txtNroDupl = New Cls_Controls.Cls_TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtVTotal = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtDtNtF = New Cls_Controls.Cls_TextBoxData()
        Me.txtNroNtF = New Cls_Controls.Cls_TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboInstituicao = New Cls_Controls.Cls_ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboEvento = New System.Windows.Forms.ComboBox()
        Me.cboCusto = New Cls_Controls.Cls_ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtAberto = New Cls_Controls.Cls_TexBoxMonetario()
        Me.dgDoFornec = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgCtaPg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDupl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgDoFornec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1313, 732)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.txtTermino)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtDeb)
        Me.TabPage1.Controls.Add(Me.txtPago)
        Me.TabPage1.Controls.Add(Me.txtAPagar)
        Me.TabPage1.Controls.Add(Me.txtInicio)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.DgCtaPg)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1305, 703)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contas por Data"
        '
        'txtTermino
        '
        Me.txtTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtTermino.Location = New System.Drawing.Point(425, 6)
        Me.txtTermino.Name = "txtTermino"
        Me.txtTermino.Size = New System.Drawing.Size(155, 30)
        Me.txtTermino.TabIndex = 182
        Me.txtTermino.Value = New Date(2023, 11, 14, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(327, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 25)
        Me.Label22.TabIndex = 183
        Me.Label22.Text = "Término"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(904, 667)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 17)
        Me.Label21.TabIndex = 181
        Me.Label21.Text = "A Pagar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(435, 668)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 17)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "Pago"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 668)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 17)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "Total"
        '
        'txtDeb
        '
        Me.txtDeb.EnviaTab = True
        Me.txtDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDeb.Location = New System.Drawing.Point(75, 658)
        Me.txtDeb.Name = "txtDeb"
        Me.txtDeb.Size = New System.Drawing.Size(162, 30)
        Me.txtDeb.TabIndex = 178
        '
        'txtPago
        '
        Me.txtPago.EnviaTab = True
        Me.txtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPago.Location = New System.Drawing.Point(482, 658)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(162, 30)
        Me.txtPago.TabIndex = 177
        '
        'txtAPagar
        '
        Me.txtAPagar.EnviaTab = True
        Me.txtAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAPagar.Location = New System.Drawing.Point(969, 658)
        Me.txtAPagar.Name = "txtAPagar"
        Me.txtAPagar.Size = New System.Drawing.Size(162, 30)
        Me.txtAPagar.TabIndex = 176
        '
        'txtInicio
        '
        Me.txtInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInicio.Location = New System.Drawing.Point(82, 6)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(155, 30)
        Me.txtInicio.TabIndex = 174
        Me.txtInicio.Value = New Date(2023, 11, 14, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 25)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "Ínicio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgCtaPg
        '
        Me.DgCtaPg.AllowUserToOrderColumns = True
        Me.DgCtaPg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgCtaPg.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DgCtaPg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgCtaPg.GridColor = System.Drawing.Color.White
        Me.DgCtaPg.Location = New System.Drawing.Point(6, 56)
        Me.DgCtaPg.MultiSelect = False
        Me.DgCtaPg.Name = "DgCtaPg"
        Me.DgCtaPg.RowHeadersWidth = 51
        Me.DgCtaPg.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DgCtaPg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgCtaPg.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.DgCtaPg.RowTemplate.Height = 24
        Me.DgCtaPg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgCtaPg.Size = New System.Drawing.Size(1293, 582)
        Me.DgCtaPg.TabIndex = 170
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.txtHist)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtFaltante)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtValorPago)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtTotalLancDupl)
        Me.TabPage2.Controls.Add(Me.txtId)
        Me.TabPage2.Controls.Add(Me.dgDupl)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1305, 703)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lançamentos"
        '
        'txtHist
        '
        Me.txtHist.EnviaTab = True
        Me.txtHist.Location = New System.Drawing.Point(771, 499)
        Me.txtHist.Multiline = True
        Me.txtHist.Name = "txtHist"
        Me.txtHist.Size = New System.Drawing.Size(476, 178)
        Me.txtHist.SomenteNumero = False
        Me.txtHist.TabIndex = 182
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.cboFPagto)
        Me.GroupBox4.Controls.Add(Me.txtDocPagto)
        Me.GroupBox4.Controls.Add(Me.txtDtPagto)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.btoPagto)
        Me.GroupBox4.Controls.Add(Me.btoEstorno)
        Me.GroupBox4.Controls.Add(Me.txtVdoPagto)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 464)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(662, 219)
        Me.GroupBox4.TabIndex = 181
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Do Pagamento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(29, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 17)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Forma"
        '
        'cboFPagto
        '
        Me.cboFPagto.EnviaTab = True
        Me.cboFPagto.FormattingEnabled = True
        Me.cboFPagto.Location = New System.Drawing.Point(85, 72)
        Me.cboFPagto.Name = "cboFPagto"
        Me.cboFPagto.Size = New System.Drawing.Size(447, 24)
        Me.cboFPagto.TabIndex = 29
        '
        'txtDocPagto
        '
        Me.txtDocPagto.EnviaTab = True
        Me.txtDocPagto.Location = New System.Drawing.Point(85, 113)
        Me.txtDocPagto.Name = "txtDocPagto"
        Me.txtDocPagto.Size = New System.Drawing.Size(442, 22)
        Me.txtDocPagto.SomenteNumero = False
        Me.txtDocPagto.TabIndex = 28
        '
        'txtDtPagto
        '
        Me.txtDtPagto.EnviaTab = True
        Me.txtDtPagto.Location = New System.Drawing.Point(85, 25)
        Me.txtDtPagto.Name = "txtDtPagto"
        Me.txtDtPagto.Size = New System.Drawing.Size(100, 22)
        Me.txtDtPagto.SomenteNumero = True
        Me.txtDtPagto.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 17)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Nro.Doc."
        '
        'btoPagto
        '
        Me.btoPagto.Location = New System.Drawing.Point(85, 176)
        Me.btoPagto.Name = "btoPagto"
        Me.btoPagto.Size = New System.Drawing.Size(148, 37)
        Me.btoPagto.TabIndex = 18
        Me.btoPagto.Text = "Efetuar Pagto."
        Me.btoPagto.UseVisualStyleBackColor = True
        '
        'btoEstorno
        '
        Me.btoEstorno.Location = New System.Drawing.Point(411, 176)
        Me.btoEstorno.Name = "btoEstorno"
        Me.btoEstorno.Size = New System.Drawing.Size(148, 37)
        Me.btoEstorno.TabIndex = 20
        Me.btoEstorno.Text = "Estornor"
        Me.btoEstorno.UseVisualStyleBackColor = True
        '
        'txtVdoPagto
        '
        Me.txtVdoPagto.EnviaTab = True
        Me.txtVdoPagto.Location = New System.Drawing.Point(538, 25)
        Me.txtVdoPagto.Name = "txtVdoPagto"
        Me.txtVdoPagto.Size = New System.Drawing.Size(100, 22)
        Me.txtVdoPagto.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(486, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Valor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(39, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 17)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Data"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1086, 300)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 17)
        Me.Label16.TabIndex = 179
        Me.Label16.Text = "ID Reg."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1082, 448)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 17)
        Me.Label15.TabIndex = 178
        Me.Label15.Text = "Faltante"
        '
        'txtFaltante
        '
        Me.txtFaltante.EnviaTab = True
        Me.txtFaltante.Location = New System.Drawing.Point(1147, 445)
        Me.txtFaltante.Name = "txtFaltante"
        Me.txtFaltante.Size = New System.Drawing.Size(100, 22)
        Me.txtFaltante.TabIndex = 177
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1063, 385)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 17)
        Me.Label14.TabIndex = 176
        Me.Label14.Text = "Valor Pago"
        '
        'txtValorPago
        '
        Me.txtValorPago.EnviaTab = True
        Me.txtValorPago.Location = New System.Drawing.Point(1147, 382)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(100, 22)
        Me.txtValorPago.TabIndex = 175
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(988, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 17)
        Me.Label13.TabIndex = 174
        Me.Label13.Text = "Valores das Duplicatas"
        '
        'txtTotalLancDupl
        '
        Me.txtTotalLancDupl.EnviaTab = True
        Me.txtTotalLancDupl.Location = New System.Drawing.Point(1147, 340)
        Me.txtTotalLancDupl.Name = "txtTotalLancDupl"
        Me.txtTotalLancDupl.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalLancDupl.TabIndex = 173
        '
        'txtId
        '
        Me.txtId.EnviaTab = True
        Me.txtId.Location = New System.Drawing.Point(1147, 300)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.SomenteNumero = False
        Me.txtId.TabIndex = 172
        '
        'dgDupl
        '
        Me.dgDupl.AllowUserToOrderColumns = True
        Me.dgDupl.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgDupl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDupl.GridColor = System.Drawing.Color.White
        Me.dgDupl.Location = New System.Drawing.Point(771, 19)
        Me.dgDupl.MultiSelect = False
        Me.dgDupl.Name = "dgDupl"
        Me.dgDupl.ReadOnly = True
        Me.dgDupl.RowHeadersVisible = False
        Me.dgDupl.RowHeadersWidth = 51
        Me.dgDupl.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgDupl.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgDupl.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgDupl.RowTemplate.Height = 24
        Me.dgDupl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDupl.Size = New System.Drawing.Size(487, 245)
        Me.dgDupl.TabIndex = 171
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtOrdemDupl)
        Me.GroupBox3.Controls.Add(Me.btoIncluir)
        Me.GroupBox3.Controls.Add(Me.btoExcluir)
        Me.GroupBox3.Controls.Add(Me.txtVDupl)
        Me.GroupBox3.Controls.Add(Me.txtDtVcto)
        Me.GroupBox3.Controls.Add(Me.txtNroDupl)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 136)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados para Pagamento"
        '
        'txtOrdemDupl
        '
        Me.txtOrdemDupl.EnviaTab = True
        Me.txtOrdemDupl.Location = New System.Drawing.Point(198, 37)
        Me.txtOrdemDupl.Name = "txtOrdemDupl"
        Me.txtOrdemDupl.Size = New System.Drawing.Size(37, 22)
        Me.txtOrdemDupl.SomenteNumero = False
        Me.txtOrdemDupl.TabIndex = 24
        '
        'btoIncluir
        '
        Me.btoIncluir.Location = New System.Drawing.Point(85, 85)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(148, 37)
        Me.btoIncluir.TabIndex = 18
        Me.btoIncluir.Text = "Incluir"
        Me.btoIncluir.UseVisualStyleBackColor = True
        '
        'btoExcluir
        '
        Me.btoExcluir.Location = New System.Drawing.Point(404, 85)
        Me.btoExcluir.Name = "btoExcluir"
        Me.btoExcluir.Size = New System.Drawing.Size(148, 37)
        Me.btoExcluir.TabIndex = 20
        Me.btoExcluir.Text = "Excluir"
        Me.btoExcluir.UseVisualStyleBackColor = True
        '
        'txtVDupl
        '
        Me.txtVDupl.EnviaTab = True
        Me.txtVDupl.Location = New System.Drawing.Point(538, 40)
        Me.txtVDupl.Name = "txtVDupl"
        Me.txtVDupl.Size = New System.Drawing.Size(100, 22)
        Me.txtVDupl.TabIndex = 17
        '
        'txtDtVcto
        '
        Me.txtDtVcto.EnviaTab = True
        Me.txtDtVcto.Location = New System.Drawing.Point(334, 40)
        Me.txtDtVcto.Name = "txtDtVcto"
        Me.txtDtVcto.Size = New System.Drawing.Size(100, 22)
        Me.txtDtVcto.SomenteNumero = True
        Me.txtDtVcto.TabIndex = 16
        '
        'txtNroDupl
        '
        Me.txtNroDupl.EnviaTab = True
        Me.txtNroDupl.Location = New System.Drawing.Point(85, 37)
        Me.txtNroDupl.Name = "txtNroDupl"
        Me.txtNroDupl.Size = New System.Drawing.Size(89, 22)
        Me.txtNroDupl.SomenteNumero = False
        Me.txtNroDupl.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(491, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Valor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(246, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Vencimento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nro.Dp."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVTotal)
        Me.GroupBox2.Controls.Add(Me.txtDtNtF)
        Me.GroupBox2.Controls.Add(Me.txtNroNtF)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboInstituicao)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 100)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados do Lançamento"
        '
        'txtVTotal
        '
        Me.txtVTotal.EnviaTab = True
        Me.txtVTotal.Location = New System.Drawing.Point(538, 61)
        Me.txtVTotal.Name = "txtVTotal"
        Me.txtVTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtVTotal.TabIndex = 17
        '
        'txtDtNtF
        '
        Me.txtDtNtF.EnviaTab = True
        Me.txtDtNtF.Location = New System.Drawing.Point(290, 61)
        Me.txtDtNtF.Name = "txtDtNtF"
        Me.txtDtNtF.Size = New System.Drawing.Size(100, 22)
        Me.txtDtNtF.SomenteNumero = True
        Me.txtDtNtF.TabIndex = 16
        '
        'txtNroNtF
        '
        Me.txtNroNtF.EnviaTab = True
        Me.txtNroNtF.Location = New System.Drawing.Point(85, 61)
        Me.txtNroNtF.Name = "txtNroNtF"
        Me.txtNroNtF.Size = New System.Drawing.Size(89, 22)
        Me.txtNroNtF.SomenteNumero = False
        Me.txtNroNtF.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(455, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Valor Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(246, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nro.NTF."
        '
        'cboInstituicao
        '
        Me.cboInstituicao.EnviaTab = True
        Me.cboInstituicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInstituicao.FormattingEnabled = True
        Me.cboInstituicao.Location = New System.Drawing.Point(85, 18)
        Me.cboInstituicao.Name = "cboInstituicao"
        Me.cboInstituicao.Size = New System.Drawing.Size(553, 28)
        Me.cboInstituicao.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Instituição"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboEvento)
        Me.GroupBox1.Controls.Add(Me.cboCusto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 124)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Classificação"
        '
        'cboEvento
        '
        Me.cboEvento.FormattingEnabled = True
        Me.cboEvento.Location = New System.Drawing.Point(85, 21)
        Me.cboEvento.Name = "cboEvento"
        Me.cboEvento.Size = New System.Drawing.Size(442, 24)
        Me.cboEvento.TabIndex = 12
        '
        'cboCusto
        '
        Me.cboCusto.EnviaTab = True
        Me.cboCusto.FormattingEnabled = True
        Me.cboCusto.Location = New System.Drawing.Point(85, 72)
        Me.cboCusto.Name = "cboCusto"
        Me.cboCusto.Size = New System.Drawing.Size(287, 24)
        Me.cboCusto.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "C. Custo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtAberto)
        Me.TabPage3.Controls.Add(Me.dgDoFornec)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1305, 703)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CC. Fornecedor"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtAberto
        '
        Me.txtAberto.EnviaTab = True
        Me.txtAberto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAberto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAberto.Location = New System.Drawing.Point(18, 643)
        Me.txtAberto.Name = "txtAberto"
        Me.txtAberto.Size = New System.Drawing.Size(162, 30)
        Me.txtAberto.TabIndex = 173
        '
        'dgDoFornec
        '
        Me.dgDoFornec.AllowUserToOrderColumns = True
        Me.dgDoFornec.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgDoFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDoFornec.GridColor = System.Drawing.Color.White
        Me.dgDoFornec.Location = New System.Drawing.Point(18, 21)
        Me.dgDoFornec.MultiSelect = False
        Me.dgDoFornec.Name = "dgDoFornec"
        Me.dgDoFornec.ReadOnly = True
        Me.dgDoFornec.RowHeadersVisible = False
        Me.dgDoFornec.RowHeadersWidth = 51
        Me.dgDoFornec.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgDoFornec.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgDoFornec.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgDoFornec.RowTemplate.Height = 24
        Me.dgDoFornec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDoFornec.Size = New System.Drawing.Size(1251, 602)
        Me.dgDoFornec.TabIndex = 172
        '
        'frmCtaPg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1354, 756)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtaPg"
        Me.Text = "Contas a Pagar"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgCtaPg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgDupl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgDoFornec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents DgCtaPg As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cboCusto As Cls_Controls.Cls_ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents dgDupl As Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents btoIncluir As Windows.Forms.Button
    Friend WithEvents txtVDupl As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtDtVcto As Cls_Controls.Cls_TextBoxData
    Friend WithEvents txtNroDupl As Cls_Controls.Cls_TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents txtVTotal As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtDtNtF As Cls_Controls.Cls_TextBoxData
    Friend WithEvents txtNroNtF As Cls_Controls.Cls_TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents cboInstituicao As Cls_Controls.Cls_ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtId As Cls_Controls.Cls_TextBox
    Friend WithEvents btoExcluir As Windows.Forms.Button
    Friend WithEvents txtOrdemDupl As Cls_Controls.Cls_TextBox
    Friend WithEvents txtTotalLancDupl As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txtFaltante As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txtValorPago As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents cboEvento As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents txtDocPagto As Cls_Controls.Cls_TextBox
    Friend WithEvents txtDtPagto As Cls_Controls.Cls_TextBoxData
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents btoPagto As Windows.Forms.Button
    Friend WithEvents btoEstorno As Windows.Forms.Button
    Friend WithEvents txtVdoPagto As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents cboFPagto As Cls_Controls.Cls_ComboBox
    Friend WithEvents txtHist As Cls_Controls.Cls_TextBox
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents txtInicio As Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents dgDoFornec As Windows.Forms.DataGridView
    Friend WithEvents txtAberto As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtAPagar As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtPago As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtDeb As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtTermino As Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As Windows.Forms.Label
End Class
