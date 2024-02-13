<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresa))
        Me.btoAlterar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_ID = New Cls_Controls.Cls_TextBoxOld()
        Me.bto_Img_Cli = New System.Windows.Forms.Button()
        Me.txtFone = New Cls_Controls.Cls_TextBoxFone()
        Me.txtCNPJ = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.TxtCEP = New Cls_Controls.Cls_CEP()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Fone = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cls_TextBox_CPF_CNPJ1 = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pic_Cliente = New System.Windows.Forms.PictureBox()
        Me.dgEmp = New System.Windows.Forms.DataGridView()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCidIBGE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUfIBGE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtISS = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHttp = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btoAlterar
        '
        Me.btoAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btoAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btoAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btoAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btoAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAlterar.Location = New System.Drawing.Point(861, 482)
        Me.btoAlterar.Name = "btoAlterar"
        Me.btoAlterar.Size = New System.Drawing.Size(134, 29)
        Me.btoAlterar.TabIndex = 283
        Me.btoAlterar.Text = "Alterar"
        Me.btoAlterar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncluir.Location = New System.Drawing.Point(586, 482)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(134, 29)
        Me.btnIncluir.TabIndex = 267
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(90, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 281
        Me.Label1.Text = "ID"
        '
        'Txt_ID
        '
        Me.Txt_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_ID.Enabled = False
        Me.Txt_ID.EnviaTab = True
        Me.Txt_ID.Location = New System.Drawing.Point(120, 37)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(57, 22)
        Me.Txt_ID.SomenteNumero = False
        Me.Txt_ID.TabIndex = 280
        '
        'bto_Img_Cli
        '
        Me.bto_Img_Cli.Cursor = System.Windows.Forms.Cursors.Default
        Me.bto_Img_Cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bto_Img_Cli.Location = New System.Drawing.Point(607, 201)
        Me.bto_Img_Cli.Name = "bto_Img_Cli"
        Me.bto_Img_Cli.Size = New System.Drawing.Size(441, 29)
        Me.bto_Img_Cli.TabIndex = 266
        Me.bto_Img_Cli.Text = "Busca Uma Imagem"
        Me.bto_Img_Cli.UseVisualStyleBackColor = True
        '
        'txtFone
        '
        Me.txtFone.EnviaTab = True
        Me.txtFone.Location = New System.Drawing.Point(120, 466)
        Me.txtFone.Name = "txtFone"
        Me.txtFone.Size = New System.Drawing.Size(125, 22)
        Me.txtFone.SomenteNumero = False
        Me.txtFone.TabIndex = 264
        '
        'txtCNPJ
        '
        Me.txtCNPJ.CpfValido = True
        Me.txtCNPJ.EnviaTab = True
        Me.txtCNPJ.ExibirMensagem = False
        Me.txtCNPJ.Location = New System.Drawing.Point(120, 82)
        Me.txtCNPJ.MaxLength = 18
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(172, 22)
        Me.txtCNPJ.SomenteNumero = True
        Me.txtCNPJ.TabIndex = 255
        Me.txtCNPJ.ValidaCNPJ = True
        Me.txtCNPJ.ValidaCPF = False
        '
        'TxtCEP
        '
        Me.TxtCEP.EnviaTab = True
        Me.TxtCEP.Location = New System.Drawing.Point(120, 182)
        Me.TxtCEP.Name = "TxtCEP"
        Me.TxtCEP.Size = New System.Drawing.Size(128, 22)
        Me.TxtCEP.SomenteNumero = False
        Me.TxtCEP.TabIndex = 257
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(120, 494)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(421, 22)
        Me.txtEmail.TabIndex = 265
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(62, 494)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 17)
        Me.Label18.TabIndex = 278
        Me.Label18.Text = "E-Mail"
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(395, 350)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(48, 22)
        Me.txtUF.TabIndex = 263
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(120, 350)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(235, 22)
        Me.txtCidade.TabIndex = 262
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(120, 322)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(235, 22)
        Me.txtBairro.TabIndex = 261
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(120, 266)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(219, 22)
        Me.txtCompl.TabIndex = 260
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(120, 238)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(82, 22)
        Me.txtNro.TabIndex = 259
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(120, 210)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(420, 22)
        Me.txtEnd.TabIndex = 258
        '
        'txtFantasia
        '
        Me.txtFantasia.Location = New System.Drawing.Point(120, 110)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.Size = New System.Drawing.Size(461, 22)
        Me.txtFantasia.TabIndex = 256
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(75, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 277
        Me.Label13.Text = "Nro."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 276
        Me.Label4.Text = "Complemento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 275
        Me.Label11.Text = "CEP"
        '
        'Fone
        '
        Me.Fone.AutoSize = True
        Me.Fone.Location = New System.Drawing.Point(69, 466)
        Me.Fone.Name = "Fone"
        Me.Fone.Size = New System.Drawing.Size(40, 17)
        Me.Fone.TabIndex = 274
        Me.Fone.Text = "Fone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 273
        Me.Label10.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 272
        Me.Label8.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 271
        Me.Label6.Text = "Bairro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 270
        Me.Label9.Text = "End."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 269
        Me.Label7.Text = "Nome Fantasia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "CNPJ/CPF"
        '
        'txtRazao
        '
        Me.txtRazao.Location = New System.Drawing.Point(120, 138)
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.Size = New System.Drawing.Size(461, 22)
        Me.txtRazao.TabIndex = 284
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "Razão Social"
        '
        'Cls_TextBox_CPF_CNPJ1
        '
        Me.Cls_TextBox_CPF_CNPJ1.CpfValido = True
        Me.Cls_TextBox_CPF_CNPJ1.EnviaTab = True
        Me.Cls_TextBox_CPF_CNPJ1.ExibirMensagem = False
        Me.Cls_TextBox_CPF_CNPJ1.Location = New System.Drawing.Point(410, 82)
        Me.Cls_TextBox_CPF_CNPJ1.MaxLength = 18
        Me.Cls_TextBox_CPF_CNPJ1.Name = "Cls_TextBox_CPF_CNPJ1"
        Me.Cls_TextBox_CPF_CNPJ1.Size = New System.Drawing.Size(172, 22)
        Me.Cls_TextBox_CPF_CNPJ1.SomenteNumero = True
        Me.Cls_TextBox_CPF_CNPJ1.TabIndex = 286
        Me.Cls_TextBox_CPF_CNPJ1.ValidaCNPJ = True
        Me.Cls_TextBox_CPF_CNPJ1.ValidaCPF = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 287
        Me.Label5.Text = "I.Municipal"
        '
        'pic_Cliente
        '
        Me.pic_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Cliente.Location = New System.Drawing.Point(607, 38)
        Me.pic_Cliente.Name = "pic_Cliente"
        Me.pic_Cliente.Size = New System.Drawing.Size(438, 130)
        Me.pic_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Cliente.TabIndex = 279
        Me.pic_Cliente.TabStop = False
        '
        'dgEmp
        '
        Me.dgEmp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmp.GridColor = System.Drawing.Color.White
        Me.dgEmp.Location = New System.Drawing.Point(120, 559)
        Me.dgEmp.Name = "dgEmp"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmp.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEmp.RowHeadersVisible = False
        Me.dgEmp.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgEmp.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgEmp.RowTemplate.Height = 24
        Me.dgEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmp.Size = New System.Drawing.Size(928, 133)
        Me.dgEmp.TabIndex = 288
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'txtCidIBGE
        '
        Me.txtCidIBGE.Location = New System.Drawing.Point(120, 378)
        Me.txtCidIBGE.Name = "txtCidIBGE"
        Me.txtCidIBGE.Size = New System.Drawing.Size(120, 22)
        Me.txtCidIBGE.TabIndex = 289
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 378)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 290
        Me.Label12.Text = "Cod. IBGE"
        '
        'txtUfIBGE
        '
        Me.txtUfIBGE.Location = New System.Drawing.Point(395, 378)
        Me.txtUfIBGE.Name = "txtUfIBGE"
        Me.txtUfIBGE.Size = New System.Drawing.Size(82, 22)
        Me.txtUfIBGE.TabIndex = 291
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(327, 381)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 292
        Me.Label14.Text = "UF IBGE"
        '
        'txtISS
        '
        Me.txtISS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISS.Location = New System.Drawing.Point(120, 418)
        Me.txtISS.Name = "txtISS"
        Me.txtISS.Size = New System.Drawing.Size(82, 26)
        Me.txtISS.TabIndex = 293
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 424)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 294
        Me.Label15.Text = "% ISS"
        '
        'txtHttp
        '
        Me.txtHttp.Location = New System.Drawing.Point(120, 522)
        Me.txtHttp.Name = "txtHttp"
        Me.txtHttp.Size = New System.Drawing.Size(421, 22)
        Me.txtHttp.TabIndex = 295
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(62, 522)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 17)
        Me.Label16.TabIndex = 296
        Me.Label16.Text = "htto://"
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 721)
        Me.Controls.Add(Me.txtHttp)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtISS)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtUfIBGE)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCidIBGE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgEmp)
        Me.Controls.Add(Me.Cls_TextBox_CPF_CNPJ1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRazao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btoAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.bto_Img_Cli)
        Me.Controls.Add(Me.pic_Cliente)
        Me.Controls.Add(Me.txtFone)
        Me.Controls.Add(Me.txtCNPJ)
        Me.Controls.Add(Me.TxtCEP)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtCompl)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtFantasia)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Fone)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpresa"
        Me.Text = "Cadastro da Empresa"
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btoAlterar As Windows.Forms.Button
    Friend WithEvents btnIncluir As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Txt_ID As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents bto_Img_Cli As Windows.Forms.Button
    Friend WithEvents pic_Cliente As Windows.Forms.PictureBox
    Friend WithEvents txtFone As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents txtCNPJ As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents TxtCEP As Cls_Controls.Cls_CEP
    Friend WithEvents txtEmail As Windows.Forms.TextBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents txtUF As Windows.Forms.TextBox
    Friend WithEvents txtCidade As Windows.Forms.TextBox
    Friend WithEvents txtBairro As Windows.Forms.TextBox
    Friend WithEvents txtCompl As Windows.Forms.TextBox
    Friend WithEvents txtNro As Windows.Forms.TextBox
    Friend WithEvents txtEnd As Windows.Forms.TextBox
    Friend WithEvents txtFantasia As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Fone As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtRazao As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Cls_TextBox_CPF_CNPJ1 As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents dgEmp As Windows.Forms.DataGridView
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents txtISS As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txtUfIBGE As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txtCidIBGE As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txtHttp As Windows.Forms.TextBox
    Friend WithEvents Label16 As Windows.Forms.Label
End Class
