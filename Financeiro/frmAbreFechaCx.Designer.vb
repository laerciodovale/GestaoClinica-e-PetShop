<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbreFechaCx
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbreFechaCx))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btoEncerrar = New System.Windows.Forms.Button()
        Me.txtFundo = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtSangria = New Cls_Controls.Cls_TexBoxMonetario()
        Me.txtAbertura = New Cls_Controls.Cls_TexBoxMonetario()
        Me.btoFundo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btoSangria = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btoAbrir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgSaidas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotSaida = New Cls_Controls.Cls_TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFisio = New Cls_Controls.Cls_TextBox()
        Me.txtSubTot = New Cls_Controls.Cls_TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAberto = New Cls_Controls.Cls_TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAtrasados = New Cls_Controls.Cls_TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCCx2 = New Cls_Controls.Cls_TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCCx4 = New Cls_Controls.Cls_TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCCred = New Cls_Controls.Cls_TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutros = New Cls_Controls.Cls_TextBox()
        Me.txtCCx3 = New Cls_Controls.Cls_TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAVista = New Cls_Controls.Cls_TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPIX = New Cls_Controls.Cls_TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCDeb = New Cls_Controls.Cls_TextBox()
        Me.dgCaixaAB = New System.Windows.Forms.DataGridView()
        Me.dgCaixa = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dgCaixaFat = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtFaturado = New Cls_Controls.Cls_TextBox()
        Me.txtNomeDoCaixa = New Cls_Controls.Cls_TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgSaidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCaixaAB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCaixaFat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btoEncerrar)
        Me.GroupBox4.Controls.Add(Me.txtFundo)
        Me.GroupBox4.Controls.Add(Me.txtSangria)
        Me.GroupBox4.Controls.Add(Me.txtAbertura)
        Me.GroupBox4.Controls.Add(Me.btoFundo)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.btoSangria)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.btoAbrir)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(480, 171)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Caixa Abertura/Fechamento"
        '
        'btoEncerrar
        '
        Me.btoEncerrar.Location = New System.Drawing.Point(15, 129)
        Me.btoEncerrar.Name = "btoEncerrar"
        Me.btoEncerrar.Size = New System.Drawing.Size(446, 30)
        Me.btoEncerrar.TabIndex = 31
        Me.btoEncerrar.Text = "Encerrar"
        Me.btoEncerrar.UseVisualStyleBackColor = True
        '
        'txtFundo
        '
        Me.txtFundo.EnviaTab = True
        Me.txtFundo.Location = New System.Drawing.Point(136, 97)
        Me.txtFundo.Name = "txtFundo"
        Me.txtFundo.Size = New System.Drawing.Size(140, 22)
        Me.txtFundo.TabIndex = 30
        '
        'txtSangria
        '
        Me.txtSangria.EnviaTab = True
        Me.txtSangria.Location = New System.Drawing.Point(136, 61)
        Me.txtSangria.Name = "txtSangria"
        Me.txtSangria.Size = New System.Drawing.Size(140, 22)
        Me.txtSangria.TabIndex = 29
        '
        'txtAbertura
        '
        Me.txtAbertura.EnviaTab = True
        Me.txtAbertura.Location = New System.Drawing.Point(136, 22)
        Me.txtAbertura.Name = "txtAbertura"
        Me.txtAbertura.Size = New System.Drawing.Size(140, 22)
        Me.txtAbertura.TabIndex = 28
        '
        'btoFundo
        '
        Me.btoFundo.Location = New System.Drawing.Point(351, 93)
        Me.btoFundo.Name = "btoFundo"
        Me.btoFundo.Size = New System.Drawing.Size(110, 30)
        Me.btoFundo.TabIndex = 22
        Me.btoFundo.Text = "Fundo"
        Me.btoFundo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "+ Fundo"
        '
        'btoSangria
        '
        Me.btoSangria.Location = New System.Drawing.Point(351, 57)
        Me.btoSangria.Name = "btoSangria"
        Me.btoSangria.Size = New System.Drawing.Size(110, 30)
        Me.btoSangria.TabIndex = 19
        Me.btoSangria.Text = "Sangrar"
        Me.btoSangria.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(73, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Sangria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(18, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Valor da Abertura"
        '
        'btoAbrir
        '
        Me.btoAbrir.Location = New System.Drawing.Point(351, 18)
        Me.btoAbrir.Name = "btoAbrir"
        Me.btoAbrir.Size = New System.Drawing.Size(110, 30)
        Me.btoAbrir.TabIndex = 1
        Me.btoAbrir.Text = "Abrir"
        Me.btoAbrir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Identificação do Caixa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 478)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valores do movimento no dia"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgSaidas)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtTotSaida)
        Me.GroupBox3.Location = New System.Drawing.Point(266, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 413)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Saidas"
        '
        'dgSaidas
        '
        Me.dgSaidas.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgSaidas.AllowUserToAddRows = False
        Me.dgSaidas.AllowUserToDeleteRows = False
        Me.dgSaidas.AllowUserToOrderColumns = True
        Me.dgSaidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgSaidas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgSaidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSaidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSaidas.ColumnHeadersHeight = 29
        Me.dgSaidas.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgSaidas.Location = New System.Drawing.Point(6, 25)
        Me.dgSaidas.MultiSelect = False
        Me.dgSaidas.Name = "dgSaidas"
        Me.dgSaidas.ReadOnly = True
        Me.dgSaidas.RowHeadersVisible = False
        Me.dgSaidas.RowHeadersWidth = 51
        Me.dgSaidas.RowTemplate.Height = 24
        Me.dgSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSaidas.Size = New System.Drawing.Size(180, 317)
        Me.dgSaidas.StandardTab = True
        Me.dgSaidas.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Total"
        '
        'txtTotSaida
        '
        Me.txtTotSaida.Enabled = False
        Me.txtTotSaida.EnviaTab = True
        Me.txtTotSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotSaida.Location = New System.Drawing.Point(70, 364)
        Me.txtTotSaida.Name = "txtTotSaida"
        Me.txtTotSaida.Size = New System.Drawing.Size(116, 30)
        Me.txtTotSaida.SomenteNumero = False
        Me.txtTotSaida.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtFisio)
        Me.GroupBox2.Controls.Add(Me.txtSubTot)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtAberto)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtAtrasados)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCCx2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCCx4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCCred)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtOutros)
        Me.GroupBox2.Controls.Add(Me.txtCCx3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtAVista)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPIX)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCDeb)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 451)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entrada"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1, 409)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 17)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Fisioterapia"
        '
        'txtFisio
        '
        Me.txtFisio.Enabled = False
        Me.txtFisio.EnviaTab = True
        Me.txtFisio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFisio.Location = New System.Drawing.Point(88, 409)
        Me.txtFisio.Name = "txtFisio"
        Me.txtFisio.Size = New System.Drawing.Size(116, 30)
        Me.txtFisio.SomenteNumero = False
        Me.txtFisio.TabIndex = 51
        '
        'txtSubTot
        '
        Me.txtSubTot.Enabled = False
        Me.txtSubTot.EnviaTab = True
        Me.txtSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTot.Location = New System.Drawing.Point(88, 328)
        Me.txtSubTot.Name = "txtSubTot"
        Me.txtSubTot.Size = New System.Drawing.Size(116, 30)
        Me.txtSubTot.SomenteNumero = False
        Me.txtSubTot.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Aberto"
        '
        'txtAberto
        '
        Me.txtAberto.Enabled = False
        Me.txtAberto.EnviaTab = True
        Me.txtAberto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAberto.Location = New System.Drawing.Point(88, 368)
        Me.txtAberto.Name = "txtAberto"
        Me.txtAberto.Size = New System.Drawing.Size(116, 30)
        Me.txtAberto.SomenteNumero = False
        Me.txtAberto.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Location = New System.Drawing.Point(1, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Atrasados"
        '
        'txtAtrasados
        '
        Me.txtAtrasados.Enabled = False
        Me.txtAtrasados.EnviaTab = True
        Me.txtAtrasados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtrasados.Location = New System.Drawing.Point(88, 25)
        Me.txtAtrasados.Name = "txtAtrasados"
        Me.txtAtrasados.Size = New System.Drawing.Size(116, 26)
        Me.txtAtrasados.SomenteNumero = False
        Me.txtAtrasados.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 17)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "C.C x 4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "C.C x 2"
        '
        'txtCCx2
        '
        Me.txtCCx2.Enabled = False
        Me.txtCCx2.EnviaTab = True
        Me.txtCCx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCx2.Location = New System.Drawing.Point(88, 193)
        Me.txtCCx2.Name = "txtCCx2"
        Me.txtCCx2.Size = New System.Drawing.Size(116, 26)
        Me.txtCCx2.SomenteNumero = False
        Me.txtCCx2.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "C.C x 3"
        '
        'txtCCx4
        '
        Me.txtCCx4.Enabled = False
        Me.txtCCx4.EnviaTab = True
        Me.txtCCx4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCx4.Location = New System.Drawing.Point(88, 258)
        Me.txtCCx4.Name = "txtCCx4"
        Me.txtCCx4.Size = New System.Drawing.Size(116, 26)
        Me.txtCCx4.SomenteNumero = False
        Me.txtCCx4.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "C.Crédito"
        '
        'txtCCred
        '
        Me.txtCCred.Enabled = False
        Me.txtCCred.EnviaTab = True
        Me.txtCCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCred.Location = New System.Drawing.Point(88, 163)
        Me.txtCCred.Name = "txtCCred"
        Me.txtCCred.Size = New System.Drawing.Size(116, 26)
        Me.txtCCred.SomenteNumero = False
        Me.txtCCred.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Sub-Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Outros"
        '
        'txtOutros
        '
        Me.txtOutros.Enabled = False
        Me.txtOutros.EnviaTab = True
        Me.txtOutros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutros.Location = New System.Drawing.Point(88, 290)
        Me.txtOutros.Name = "txtOutros"
        Me.txtOutros.Size = New System.Drawing.Size(116, 26)
        Me.txtOutros.SomenteNumero = False
        Me.txtOutros.TabIndex = 35
        '
        'txtCCx3
        '
        Me.txtCCx3.Enabled = False
        Me.txtCCx3.EnviaTab = True
        Me.txtCCx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCx3.Location = New System.Drawing.Point(88, 225)
        Me.txtCCx3.Name = "txtCCx3"
        Me.txtCCx3.Size = New System.Drawing.Size(116, 26)
        Me.txtCCx3.SomenteNumero = False
        Me.txtCCx3.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Dinheiro"
        '
        'txtAVista
        '
        Me.txtAVista.Enabled = False
        Me.txtAVista.EnviaTab = True
        Me.txtAVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAVista.Location = New System.Drawing.Point(88, 67)
        Me.txtAVista.Name = "txtAVista"
        Me.txtAVista.Size = New System.Drawing.Size(116, 26)
        Me.txtAVista.SomenteNumero = False
        Me.txtAVista.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "PIX"
        '
        'txtPIX
        '
        Me.txtPIX.Enabled = False
        Me.txtPIX.EnviaTab = True
        Me.txtPIX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIX.Location = New System.Drawing.Point(88, 99)
        Me.txtPIX.Name = "txtPIX"
        Me.txtPIX.Size = New System.Drawing.Size(116, 26)
        Me.txtPIX.SomenteNumero = False
        Me.txtPIX.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "C.Deb"
        '
        'txtCDeb
        '
        Me.txtCDeb.Enabled = False
        Me.txtCDeb.EnviaTab = True
        Me.txtCDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDeb.Location = New System.Drawing.Point(88, 131)
        Me.txtCDeb.Name = "txtCDeb"
        Me.txtCDeb.Size = New System.Drawing.Size(116, 26)
        Me.txtCDeb.SomenteNumero = False
        Me.txtCDeb.TabIndex = 27
        '
        'dgCaixaAB
        '
        Me.dgCaixaAB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgCaixaAB.AllowUserToAddRows = False
        Me.dgCaixaAB.AllowUserToDeleteRows = False
        Me.dgCaixaAB.AllowUserToOrderColumns = True
        Me.dgCaixaAB.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgCaixaAB.ColumnHeadersHeight = 29
        Me.dgCaixaAB.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCaixaAB.Location = New System.Drawing.Point(510, 12)
        Me.dgCaixaAB.MultiSelect = False
        Me.dgCaixaAB.Name = "dgCaixaAB"
        Me.dgCaixaAB.ReadOnly = True
        Me.dgCaixaAB.RowHeadersVisible = False
        Me.dgCaixaAB.RowHeadersWidth = 51
        Me.dgCaixaAB.RowTemplate.Height = 24
        Me.dgCaixaAB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCaixaAB.Size = New System.Drawing.Size(357, 526)
        Me.dgCaixaAB.StandardTab = True
        Me.dgCaixaAB.TabIndex = 23
        '
        'dgCaixa
        '
        Me.dgCaixa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgCaixa.AllowUserToAddRows = False
        Me.dgCaixa.AllowUserToDeleteRows = False
        Me.dgCaixa.AllowUserToOrderColumns = True
        Me.dgCaixa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgCaixa.ColumnHeadersHeight = 29
        Me.dgCaixa.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCaixa.Location = New System.Drawing.Point(873, 12)
        Me.dgCaixa.MultiSelect = False
        Me.dgCaixa.Name = "dgCaixa"
        Me.dgCaixa.ReadOnly = True
        Me.dgCaixa.RowHeadersVisible = False
        Me.dgCaixa.RowHeadersWidth = 51
        Me.dgCaixa.RowTemplate.Height = 24
        Me.dgCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCaixa.Size = New System.Drawing.Size(859, 517)
        Me.dgCaixa.StandardTab = True
        Me.dgCaixa.TabIndex = 29
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(439, -3)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(31, 25)
        Me.lblID.TabIndex = 30
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(340, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 30)
        Me.DateTimePicker1.TabIndex = 31
        Me.DateTimePicker1.Value = New Date(2023, 5, 24, 0, 0, 0, 0)
        '
        'dgCaixaFat
        '
        Me.dgCaixaFat.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgCaixaFat.AllowUserToAddRows = False
        Me.dgCaixaFat.AllowUserToDeleteRows = False
        Me.dgCaixaFat.AllowUserToOrderColumns = True
        Me.dgCaixaFat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.dgCaixaFat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCaixaFat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgCaixaFat.ColumnHeadersHeight = 29
        Me.dgCaixaFat.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCaixaFat.Location = New System.Drawing.Point(873, 537)
        Me.dgCaixaFat.MultiSelect = False
        Me.dgCaixaFat.Name = "dgCaixaFat"
        Me.dgCaixaFat.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCaixaFat.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCaixaFat.RowHeadersVisible = False
        Me.dgCaixaFat.RowHeadersWidth = 51
        Me.dgCaixaFat.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgCaixaFat.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgCaixaFat.RowTemplate.DefaultCellStyle.NullValue = Nothing
        Me.dgCaixaFat.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgCaixaFat.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCaixaFat.RowTemplate.Height = 24
        Me.dgCaixaFat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCaixaFat.Size = New System.Drawing.Size(859, 178)
        Me.dgCaixaFat.StandardTab = True
        Me.dgCaixaFat.TabIndex = 32
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(605, 615)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(181, 20)
        Me.lblTotal.TabIndex = 52
        Me.lblTotal.Text = "Faturamento do Dia "
        '
        'txtFaturado
        '
        Me.txtFaturado.Enabled = False
        Me.txtFaturado.EnviaTab = True
        Me.txtFaturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaturado.Location = New System.Drawing.Point(594, 667)
        Me.txtFaturado.Name = "txtFaturado"
        Me.txtFaturado.Size = New System.Drawing.Size(202, 41)
        Me.txtFaturado.SomenteNumero = False
        Me.txtFaturado.TabIndex = 53
        '
        'txtNomeDoCaixa
        '
        Me.txtNomeDoCaixa.Enabled = False
        Me.txtNomeDoCaixa.EnviaTab = True
        Me.txtNomeDoCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeDoCaixa.Location = New System.Drawing.Point(172, 21)
        Me.txtNomeDoCaixa.Name = "txtNomeDoCaixa"
        Me.txtNomeDoCaixa.Size = New System.Drawing.Size(159, 38)
        Me.txtNomeDoCaixa.SomenteNumero = False
        Me.txtNomeDoCaixa.TabIndex = 9
        '
        'frmAbreFechaCx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1744, 782)
        Me.Controls.Add(Me.txtFaturado)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgCaixaFat)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dgCaixa)
        Me.Controls.Add(Me.dgCaixaAB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeDoCaixa)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbreFechaCx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Abertura e Fachamento do Caixa"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgSaidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgCaixaAB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCaixaFat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents btoSangria As Windows.Forms.Button
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btoAbrir As Windows.Forms.Button
    Public WithEvents txtNomeDoCaixa As Cls_Controls.Cls_TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents dgCaixaAB As Windows.Forms.DataGridView
    Friend WithEvents btoFundo As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtAbertura As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtFundo As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents txtSangria As Cls_Controls.Cls_TexBoxMonetario
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtTotSaida As Cls_Controls.Cls_TextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtOutros As Cls_Controls.Cls_TextBox
    Friend WithEvents txtCCx3 As Cls_Controls.Cls_TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txtAVista As Cls_Controls.Cls_TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtPIX As Cls_Controls.Cls_TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtCDeb As Cls_Controls.Cls_TextBox
    Friend WithEvents dgSaidas As Windows.Forms.DataGridView
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtCCx2 As Cls_Controls.Cls_TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txtCCx4 As Cls_Controls.Cls_TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtCCred As Cls_Controls.Cls_TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents dgCaixa As Windows.Forms.DataGridView
    Friend WithEvents lblID As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txtAtrasados As Cls_Controls.Cls_TextBox
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents txtAberto As Cls_Controls.Cls_TextBox
    Friend WithEvents dgCaixaFat As Windows.Forms.DataGridView
    Friend WithEvents btoEncerrar As Windows.Forms.Button
    Friend WithEvents txtFaturado As Cls_Controls.Cls_TextBox
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents txtSubTot As Cls_Controls.Cls_TextBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtFisio As Cls_Controls.Cls_TextBox
End Class
