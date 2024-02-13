<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItens))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtID = New Cls_Controls.Cls_TextBox()
        Me.imgItem = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.ckAtivo = New System.Windows.Forms.CheckBox()
        Me.opMat = New System.Windows.Forms.RadioButton()
        Me.opServ = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboUnid = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObs = New Cls_Controls.Cls_TextBox()
        Me.txtMax = New Cls_Controls.Cls_TextBox()
        Me.txtMin = New Cls_Controls.Cls_TextBox()
        Me.txtDesc = New Cls_Controls.Cls_TextBox()
        Me.txtEAN = New Cls_Controls.Cls_TextBox()
        Me.txtItem = New Cls_Controls.Cls_TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSubGrupo = New System.Windows.Forms.ComboBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.cboSegmento = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtIPI = New Cls_Controls.Cls_TextBox()
        Me.txtICMS = New Cls_Controls.Cls_TextBox()
        Me.cboServico = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtANVISA = New Cls_Controls.Cls_TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtISS = New Cls_Controls.Cls_TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCFOP = New Cls_Controls.Cls_TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCST = New Cls_Controls.Cls_TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCEST = New Cls_Controls.Cls_TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNCM = New Cls_Controls.Cls_TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCNAE = New Cls_Controls.Cls_TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LABELQTD = New System.Windows.Forms.Label()
        Me.txtItemPEmb = New Cls_Controls.Cls_TextBox()
        Me.cboConv = New System.Windows.Forms.ComboBox()
        Me.ckPromo = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEstoque = New Cls_Controls.Cls_TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtComissao = New Cls_Controls.Cls_TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtLucratividade = New Cls_Controls.Cls_TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtValor = New Cls_Controls.Cls_TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtLucro = New Cls_Controls.Cls_TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCompra = New Cls_Controls.Cls_TextBox()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.btoAlterar = New System.Windows.Forms.Button()
        Me.dgItens = New System.Windows.Forms.DataGridView()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.txtBusca = New Cls_Controls.Cls_TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.imgItem)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnCapturar)
        Me.GroupBox1.Controls.Add(Me.ckAtivo)
        Me.GroupBox1.Controls.Add(Me.opMat)
        Me.GroupBox1.Controls.Add(Me.opServ)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboUnid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.txtMax)
        Me.GroupBox1.Controls.Add(Me.txtMin)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.txtEAN)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 301)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.EnviaTab = True
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(94, 20)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(61, 23)
        Me.txtID.SomenteNumero = False
        Me.txtID.TabIndex = 148
        '
        'imgItem
        '
        Me.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgItem.Image = CType(resources.GetObject("imgItem.Image"), System.Drawing.Image)
        Me.imgItem.Location = New System.Drawing.Point(582, 21)
        Me.imgItem.Name = "imgItem"
        Me.imgItem.Size = New System.Drawing.Size(148, 208)
        Me.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgItem.TabIndex = 147
        Me.imgItem.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(582, 235)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(148, 26)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCapturar
        '
        Me.btnCapturar.Location = New System.Drawing.Point(582, 267)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(144, 28)
        Me.btnCapturar.TabIndex = 11
        Me.btnCapturar.Text = "Capiturar"
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'ckAtivo
        '
        Me.ckAtivo.AutoSize = True
        Me.ckAtivo.Location = New System.Drawing.Point(94, 140)
        Me.ckAtivo.Name = "ckAtivo"
        Me.ckAtivo.Size = New System.Drawing.Size(61, 21)
        Me.ckAtivo.TabIndex = 4
        Me.ckAtivo.Text = "Ativo"
        Me.ckAtivo.UseVisualStyleBackColor = True
        '
        'opMat
        '
        Me.opMat.AutoSize = True
        Me.opMat.Location = New System.Drawing.Point(372, 140)
        Me.opMat.Name = "opMat"
        Me.opMat.Size = New System.Drawing.Size(79, 21)
        Me.opMat.TabIndex = 6
        Me.opMat.TabStop = True
        Me.opMat.Text = "Material"
        Me.opMat.UseVisualStyleBackColor = True
        '
        'opServ
        '
        Me.opServ.AutoSize = True
        Me.opServ.Location = New System.Drawing.Point(265, 140)
        Me.opServ.Name = "opServ"
        Me.opServ.Size = New System.Drawing.Size(76, 21)
        Me.opServ.TabIndex = 5
        Me.opServ.TabStop = True
        Me.opServ.Text = "Serviço"
        Me.opServ.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Unidade"
        '
        'cboUnid
        '
        Me.cboUnid.FormattingEnabled = True
        Me.cboUnid.Location = New System.Drawing.Point(94, 110)
        Me.cboUnid.Name = "cboUnid"
        Me.cboUnid.Size = New System.Drawing.Size(168, 24)
        Me.cboUnid.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Obs.**"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Est.Máximo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Est.Minimo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descrição"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "EAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'txtObs
        '
        Me.txtObs.EnviaTab = True
        Me.txtObs.Location = New System.Drawing.Point(94, 202)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(357, 93)
        Me.txtObs.SomenteNumero = False
        Me.txtObs.TabIndex = 9
        '
        'txtMax
        '
        Me.txtMax.EnviaTab = True
        Me.txtMax.Location = New System.Drawing.Point(328, 174)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(123, 22)
        Me.txtMax.SomenteNumero = False
        Me.txtMax.TabIndex = 8
        '
        'txtMin
        '
        Me.txtMin.EnviaTab = True
        Me.txtMin.Location = New System.Drawing.Point(94, 174)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(107, 22)
        Me.txtMin.SomenteNumero = False
        Me.txtMin.TabIndex = 7
        '
        'txtDesc
        '
        Me.txtDesc.EnviaTab = True
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(94, 80)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(429, 26)
        Me.txtDesc.SomenteNumero = False
        Me.txtDesc.TabIndex = 2
        '
        'txtEAN
        '
        Me.txtEAN.EnviaTab = True
        Me.txtEAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEAN.Location = New System.Drawing.Point(365, 48)
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(158, 26)
        Me.txtEAN.SomenteNumero = False
        Me.txtEAN.TabIndex = 1
        '
        'txtItem
        '
        Me.txtItem.EnviaTab = True
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(94, 48)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(168, 26)
        Me.txtItem.SomenteNumero = False
        Me.txtItem.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboSubGrupo)
        Me.GroupBox2.Controls.Add(Me.cboGrupo)
        Me.GroupBox2.Controls.Add(Me.cboSegmento)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(463, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Sub-Grupo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Grupo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Segmento"
        '
        'cboSubGrupo
        '
        Me.cboSubGrupo.FormattingEnabled = True
        Me.cboSubGrupo.Location = New System.Drawing.Point(467, 38)
        Me.cboSubGrupo.Name = "cboSubGrupo"
        Me.cboSubGrupo.Size = New System.Drawing.Size(210, 24)
        Me.cboSubGrupo.TabIndex = 2
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(241, 36)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(210, 24)
        Me.cboGrupo.TabIndex = 1
        '
        'cboSegmento
        '
        Me.cboSegmento.FormattingEnabled = True
        Me.cboSegmento.Location = New System.Drawing.Point(7, 38)
        Me.cboSegmento.Name = "cboSegmento"
        Me.cboSegmento.Size = New System.Drawing.Size(210, 24)
        Me.cboSegmento.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtIPI)
        Me.GroupBox3.Controls.Add(Me.txtICMS)
        Me.GroupBox3.Controls.Add(Me.cboServico)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtANVISA)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtISS)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtCFOP)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtCST)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtCEST)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtNCM)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtCNAE)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(763, 132)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Impostos"
        '
        'txtIPI
        '
        Me.txtIPI.EnviaTab = True
        Me.txtIPI.Location = New System.Drawing.Point(584, 67)
        Me.txtIPI.Name = "txtIPI"
        Me.txtIPI.Size = New System.Drawing.Size(92, 22)
        Me.txtIPI.SomenteNumero = False
        Me.txtIPI.TabIndex = 23
        Me.txtIPI.Visible = False
        '
        'txtICMS
        '
        Me.txtICMS.EnviaTab = True
        Me.txtICMS.Location = New System.Drawing.Point(470, 67)
        Me.txtICMS.Name = "txtICMS"
        Me.txtICMS.Size = New System.Drawing.Size(92, 22)
        Me.txtICMS.SomenteNumero = False
        Me.txtICMS.TabIndex = 22
        Me.txtICMS.Visible = False
        '
        'cboServico
        '
        Me.cboServico.FormattingEnabled = True
        Me.cboServico.Location = New System.Drawing.Point(241, 88)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Size = New System.Drawing.Size(446, 24)
        Me.cboServico.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(238, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 17)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "SERVIÇO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 17)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "ANVISA"
        '
        'txtANVISA
        '
        Me.txtANVISA.EnviaTab = True
        Me.txtANVISA.Location = New System.Drawing.Point(10, 90)
        Me.txtANVISA.Name = "txtANVISA"
        Me.txtANVISA.Size = New System.Drawing.Size(210, 22)
        Me.txtANVISA.SomenteNumero = False
        Me.txtANVISA.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(590, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 17)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "ISS"
        '
        'txtISS
        '
        Me.txtISS.EnviaTab = True
        Me.txtISS.Location = New System.Drawing.Point(584, 38)
        Me.txtISS.Name = "txtISS"
        Me.txtISS.Size = New System.Drawing.Size(92, 22)
        Me.txtISS.SomenteNumero = False
        Me.txtISS.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(482, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "CFOP"
        '
        'txtCFOP
        '
        Me.txtCFOP.EnviaTab = True
        Me.txtCFOP.Location = New System.Drawing.Point(470, 38)
        Me.txtCFOP.Name = "txtCFOP"
        Me.txtCFOP.Size = New System.Drawing.Size(92, 22)
        Me.txtCFOP.SomenteNumero = False
        Me.txtCFOP.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(374, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 17)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "CST"
        '
        'txtCST
        '
        Me.txtCST.EnviaTab = True
        Me.txtCST.Location = New System.Drawing.Point(362, 38)
        Me.txtCST.Name = "txtCST"
        Me.txtCST.Size = New System.Drawing.Size(92, 22)
        Me.txtCST.SomenteNumero = False
        Me.txtCST.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(253, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CEST"
        '
        'txtCEST
        '
        Me.txtCEST.EnviaTab = True
        Me.txtCEST.Location = New System.Drawing.Point(241, 38)
        Me.txtCEST.Name = "txtCEST"
        Me.txtCEST.Size = New System.Drawing.Size(92, 22)
        Me.txtCEST.SomenteNumero = False
        Me.txtCEST.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(140, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "NCM"
        '
        'txtNCM
        '
        Me.txtNCM.EnviaTab = True
        Me.txtNCM.Location = New System.Drawing.Point(128, 38)
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(92, 22)
        Me.txtNCM.SomenteNumero = False
        Me.txtNCM.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "CNAE"
        '
        'txtCNAE
        '
        Me.txtCNAE.EnviaTab = True
        Me.txtCNAE.Location = New System.Drawing.Point(10, 38)
        Me.txtCNAE.Name = "txtCNAE"
        Me.txtCNAE.Size = New System.Drawing.Size(92, 22)
        Me.txtCNAE.SomenteNumero = False
        Me.txtCNAE.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.LABELQTD)
        Me.GroupBox4.Controls.Add(Me.txtItemPEmb)
        Me.GroupBox4.Controls.Add(Me.cboConv)
        Me.GroupBox4.Controls.Add(Me.ckPromo)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtEstoque)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtComissao)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtLucratividade)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtValor)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtLucro)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtCompra)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 545)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(763, 138)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valores "
        '
        'LABELQTD
        '
        Me.LABELQTD.AutoSize = True
        Me.LABELQTD.Location = New System.Drawing.Point(185, 20)
        Me.LABELQTD.Name = "LABELQTD"
        Me.LABELQTD.Size = New System.Drawing.Size(92, 17)
        Me.LABELQTD.TabIndex = 23
        Me.LABELQTD.Text = "Qtd por Emb."
        '
        'txtItemPEmb
        '
        Me.txtItemPEmb.EnviaTab = True
        Me.txtItemPEmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPEmb.Location = New System.Drawing.Point(200, 39)
        Me.txtItemPEmb.Name = "txtItemPEmb"
        Me.txtItemPEmb.Size = New System.Drawing.Size(65, 30)
        Me.txtItemPEmb.SomenteNumero = False
        Me.txtItemPEmb.TabIndex = 1
        '
        'cboConv
        '
        Me.cboConv.FormattingEnabled = True
        Me.cboConv.Location = New System.Drawing.Point(695, 13)
        Me.cboConv.Name = "cboConv"
        Me.cboConv.Size = New System.Drawing.Size(62, 24)
        Me.cboConv.TabIndex = 21
        Me.cboConv.Visible = False
        '
        'ckPromo
        '
        Me.ckPromo.AutoSize = True
        Me.ckPromo.Location = New System.Drawing.Point(663, 68)
        Me.ckPromo.Name = "ckPromo"
        Me.ckPromo.Size = New System.Drawing.Size(94, 21)
        Me.ckPromo.TabIndex = 6
        Me.ckPromo.Text = "Promoção"
        Me.ckPromo.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(492, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 17)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Estoque"
        '
        'txtEstoque
        '
        Me.txtEstoque.EnviaTab = True
        Me.txtEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoque.Location = New System.Drawing.Point(480, 105)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(95, 26)
        Me.txtEstoque.SomenteNumero = False
        Me.txtEstoque.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(253, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 17)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Comissão"
        '
        'txtComissao
        '
        Me.txtComissao.EnviaTab = True
        Me.txtComissao.Location = New System.Drawing.Point(241, 105)
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.Size = New System.Drawing.Size(95, 22)
        Me.txtComissao.SomenteNumero = False
        Me.txtComissao.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 85)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 17)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Lucratividade"
        '
        'txtLucratividade
        '
        Me.txtLucratividade.EnviaTab = True
        Me.txtLucratividade.Location = New System.Drawing.Point(6, 105)
        Me.txtLucratividade.Name = "txtLucratividade"
        Me.txtLucratividade.Size = New System.Drawing.Size(95, 22)
        Me.txtLucratividade.SomenteNumero = False
        Me.txtLucratividade.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(492, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 17)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.EnviaTab = True
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(480, 43)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(95, 26)
        Me.txtValor.SomenteNumero = False
        Me.txtValor.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(354, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 17)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "%Lucro"
        '
        'txtLucro
        '
        Me.txtLucro.EnviaTab = True
        Me.txtLucro.Location = New System.Drawing.Point(342, 43)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.Size = New System.Drawing.Size(95, 22)
        Me.txtLucro.SomenteNumero = False
        Me.txtLucro.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Compra"
        '
        'txtCompra
        '
        Me.txtCompra.EnviaTab = True
        Me.txtCompra.Location = New System.Drawing.Point(6, 43)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(95, 22)
        Me.txtCompra.SomenteNumero = False
        Me.txtCompra.TabIndex = 0
        '
        'btoIncluir
        '
        Me.btoIncluir.Location = New System.Drawing.Point(9, 689)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(170, 40)
        Me.btoIncluir.TabIndex = 1
        Me.btoIncluir.Text = "Incluir"
        Me.btoIncluir.UseVisualStyleBackColor = True
        '
        'btoAlterar
        '
        Me.btoAlterar.Location = New System.Drawing.Point(533, 689)
        Me.btoAlterar.Name = "btoAlterar"
        Me.btoAlterar.Size = New System.Drawing.Size(170, 40)
        Me.btoAlterar.TabIndex = 2
        Me.btoAlterar.Text = "Alterar"
        Me.btoAlterar.UseVisualStyleBackColor = True
        '
        'dgItens
        '
        Me.dgItens.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgItens.AllowUserToAddRows = False
        Me.dgItens.AllowUserToDeleteRows = False
        Me.dgItens.AllowUserToOrderColumns = True
        Me.dgItens.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dgItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgItens.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItens.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgItens.GridColor = System.Drawing.Color.White
        Me.dgItens.Location = New System.Drawing.Point(790, 60)
        Me.dgItens.MultiSelect = False
        Me.dgItens.Name = "dgItens"
        Me.dgItens.ReadOnly = True
        Me.dgItens.RowHeadersVisible = False
        Me.dgItens.RowHeadersWidth = 51
        Me.dgItens.RowTemplate.Height = 24
        Me.dgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItens.Size = New System.Drawing.Size(647, 662)
        Me.dgItens.StandardTab = True
        Me.dgItens.TabIndex = 3
        '
        'picLoading
        '
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.Location = New System.Drawing.Point(635, 344)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(107, 98)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoading.TabIndex = 157
        Me.picLoading.TabStop = False
        '
        'txtBusca
        '
        Me.txtBusca.EnviaTab = True
        Me.txtBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusca.Location = New System.Drawing.Point(790, 25)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(300, 30)
        Me.txtBusca.SomenteNumero = False
        Me.txtBusca.TabIndex = 158
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(124, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(23, 36)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "/"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(301, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(27, 36)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(447, 39)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(32, 36)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "="
        '
        'FrmItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1465, 745)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.picLoading)
        Me.Controls.Add(Me.dgItens)
        Me.Controls.Add(Me.btoAlterar)
        Me.Controls.Add(Me.btoIncluir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmItens"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itens"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckAtivo As CheckBox
    Friend WithEvents opMat As RadioButton
    Friend WithEvents opServ As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents cboUnid As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtObs As Cls_Controls.Cls_TextBox
    Friend WithEvents txtMax As Cls_Controls.Cls_TextBox
    Friend WithEvents txtMin As Cls_Controls.Cls_TextBox
    Friend WithEvents txtDesc As Cls_Controls.Cls_TextBox
    Friend WithEvents txtEAN As Cls_Controls.Cls_TextBox
    Friend WithEvents txtItem As Cls_Controls.Cls_TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents imgItem As PictureBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCapturar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSubGrupo As ComboBox
    Friend WithEvents cboGrupo As ComboBox
    Friend WithEvents cboSegmento As ComboBox
    Friend WithEvents cboServico As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtANVISA As Cls_Controls.Cls_TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtISS As Cls_Controls.Cls_TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCFOP As Cls_Controls.Cls_TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCST As Cls_Controls.Cls_TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCEST As Cls_Controls.Cls_TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNCM As Cls_Controls.Cls_TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCNAE As Cls_Controls.Cls_TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ckPromo As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtEstoque As Cls_Controls.Cls_TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtComissao As Cls_Controls.Cls_TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtLucratividade As Cls_Controls.Cls_TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtValor As Cls_Controls.Cls_TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtLucro As Cls_Controls.Cls_TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCompra As Cls_Controls.Cls_TextBox
    Friend WithEvents btoIncluir As Button
    Friend WithEvents btoAlterar As Button
    Friend WithEvents dgItens As DataGridView
    Friend WithEvents txtIPI As Cls_Controls.Cls_TextBox
    Friend WithEvents txtICMS As Cls_Controls.Cls_TextBox
    Friend WithEvents cboConv As ComboBox
    Friend WithEvents picLoading As PictureBox
    Friend WithEvents txtID As Cls_Controls.Cls_TextBox
    Friend WithEvents txtBusca As Cls_Controls.Cls_TextBox
    Friend WithEvents LABELQTD As Label
    Friend WithEvents txtItemPEmb As Cls_Controls.Cls_TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
End Class
