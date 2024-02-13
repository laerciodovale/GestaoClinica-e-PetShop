<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestador
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgPrestadores = New System.Windows.Forms.DataGridView()
        Me.btoAlterar = New System.Windows.Forms.Button()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboFuncao = New Cls_Controls.Cls_ComboBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_ID = New Cls_Controls.Cls_TextBoxOld()
        Me.bto_Img_Cli = New System.Windows.Forms.Button()
        Me.pic_Cliente = New System.Windows.Forms.PictureBox()
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
        Me.txtNome = New System.Windows.Forms.TextBox()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgNotas = New System.Windows.Forms.DataGridView()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgPrestadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1079, 704)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.dgPrestadores)
        Me.TabPage1.Controls.Add(Me.btoAlterar)
        Me.TabPage1.Controls.Add(Me.txtPlaca)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cboFuncao)
        Me.TabPage1.Controls.Add(Me.txtDesc)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnIncluir)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Txt_ID)
        Me.TabPage1.Controls.Add(Me.bto_Img_Cli)
        Me.TabPage1.Controls.Add(Me.pic_Cliente)
        Me.TabPage1.Controls.Add(Me.txtFone)
        Me.TabPage1.Controls.Add(Me.txtCNPJ)
        Me.TabPage1.Controls.Add(Me.TxtCEP)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtUF)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtCompl)
        Me.TabPage1.Controls.Add(Me.txtNro)
        Me.TabPage1.Controls.Add(Me.txtEnd)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Fone)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1071, 675)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        '
        'dgPrestadores
        '
        Me.dgPrestadores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPrestadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestadores.GridColor = System.Drawing.Color.White
        Me.dgPrestadores.Location = New System.Drawing.Point(155, 480)
        Me.dgPrestadores.Name = "dgPrestadores"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPrestadores.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPrestadores.RowHeadersVisible = False
        Me.dgPrestadores.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgPrestadores.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPrestadores.RowTemplate.Height = 24
        Me.dgPrestadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPrestadores.Size = New System.Drawing.Size(793, 180)
        Me.dgPrestadores.TabIndex = 254
        '
        'btoAlterar
        '
        Me.btoAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btoAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btoAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btoAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btoAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoAlterar.Location = New System.Drawing.Point(436, 446)
        Me.btoAlterar.Name = "btoAlterar"
        Me.btoAlterar.Size = New System.Drawing.Size(134, 29)
        Me.btoAlterar.TabIndex = 253
        Me.btoAlterar.Text = "Alterar"
        Me.btoAlterar.UseVisualStyleBackColor = True
        Me.btoAlterar.Visible = False
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(161, 400)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(135, 22)
        Me.txtPlaca.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 17)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Placa do Veiculo"
        '
        'cboFuncao
        '
        Me.cboFuncao.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFuncao.EnviaTab = True
        Me.cboFuncao.FormattingEnabled = True
        Me.cboFuncao.Location = New System.Drawing.Point(163, 43)
        Me.cboFuncao.Name = "cboFuncao"
        Me.cboFuncao.Size = New System.Drawing.Size(235, 24)
        Me.cboFuncao.TabIndex = 0
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(161, 372)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(421, 22)
        Me.txtDesc.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 17)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Descricao de Veiculo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "Tipo"
        '
        'btnIncluir
        '
        Me.btnIncluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncluir.Location = New System.Drawing.Point(161, 446)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(134, 29)
        Me.btnIncluir.TabIndex = 18
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        Me.btnIncluir.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(135, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "ID"
        '
        'Txt_ID
        '
        Me.Txt_ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.Txt_ID.Enabled = False
        Me.Txt_ID.EnviaTab = True
        Me.Txt_ID.Location = New System.Drawing.Point(166, 5)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(57, 22)
        Me.Txt_ID.SomenteNumero = False
        Me.Txt_ID.TabIndex = 243
        '
        'bto_Img_Cli
        '
        Me.bto_Img_Cli.Cursor = System.Windows.Forms.Cursors.Default
        Me.bto_Img_Cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bto_Img_Cli.Location = New System.Drawing.Point(734, 400)
        Me.bto_Img_Cli.Name = "bto_Img_Cli"
        Me.bto_Img_Cli.Size = New System.Drawing.Size(273, 29)
        Me.bto_Img_Cli.TabIndex = 17
        Me.bto_Img_Cli.Text = "Busca Uma Imagem"
        Me.bto_Img_Cli.UseVisualStyleBackColor = True
        Me.bto_Img_Cli.Visible = False
        '
        'pic_Cliente
        '
        Me.pic_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Cliente.Location = New System.Drawing.Point(734, 35)
        Me.pic_Cliente.Name = "pic_Cliente"
        Me.pic_Cliente.Size = New System.Drawing.Size(273, 346)
        Me.pic_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Cliente.TabIndex = 241
        Me.pic_Cliente.TabStop = False
        '
        'txtFone
        '
        Me.txtFone.EnviaTab = True
        Me.txtFone.Location = New System.Drawing.Point(161, 303)
        Me.txtFone.Name = "txtFone"
        Me.txtFone.Size = New System.Drawing.Size(125, 22)
        Me.txtFone.SomenteNumero = False
        Me.txtFone.TabIndex = 12
        '
        'txtCNPJ
        '
        Me.txtCNPJ.CpfValido = True
        Me.txtCNPJ.EnviaTab = True
        Me.txtCNPJ.ExibirMensagem = False
        Me.txtCNPJ.Location = New System.Drawing.Point(163, 82)
        Me.txtCNPJ.MaxLength = 18
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(172, 22)
        Me.txtCNPJ.SomenteNumero = True
        Me.txtCNPJ.TabIndex = 1
        Me.txtCNPJ.ValidaCNPJ = True
        Me.txtCNPJ.ValidaCPF = False
        '
        'TxtCEP
        '
        Me.TxtCEP.EnviaTab = True
        Me.TxtCEP.Location = New System.Drawing.Point(162, 150)
        Me.TxtCEP.Name = "TxtCEP"
        Me.TxtCEP.Size = New System.Drawing.Size(128, 22)
        Me.TxtCEP.SomenteNumero = False
        Me.TxtCEP.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(162, 331)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(421, 22)
        Me.txtEmail.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(107, 331)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 17)
        Me.Label18.TabIndex = 240
        Me.Label18.Text = "E-Mail"
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(436, 261)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(48, 22)
        Me.txtUF.TabIndex = 11
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(162, 261)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(235, 22)
        Me.txtCidade.TabIndex = 8
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(161, 233)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(235, 22)
        Me.txtBairro.TabIndex = 7
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(161, 205)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(219, 22)
        Me.txtCompl.TabIndex = 6
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(632, 176)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(82, 22)
        Me.txtNro.TabIndex = 5
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(162, 178)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(420, 22)
        Me.txtEnd.TabIndex = 4
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(163, 110)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(461, 22)
        Me.txtNome.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(591, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 239
        Me.Label13.Text = "Nro."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 238
        Me.Label4.Text = "Complemento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(120, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 237
        Me.Label11.Text = "CEP"
        '
        'Fone
        '
        Me.Fone.AutoSize = True
        Me.Fone.Location = New System.Drawing.Point(114, 303)
        Me.Fone.Name = "Fone"
        Me.Fone.Size = New System.Drawing.Size(40, 17)
        Me.Fone.TabIndex = 236
        Me.Fone.Text = "Fone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(404, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "Bairro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 232
        Me.Label9.Text = "End."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 231
        Me.Label7.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "CNPJ/CPF"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.dgNotas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1071, 675)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Servicos"
        '
        'dgNotas
        '
        Me.dgNotas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgNotas.GridColor = System.Drawing.Color.White
        Me.dgNotas.Location = New System.Drawing.Point(32, 25)
        Me.dgNotas.Name = "dgNotas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgNotas.RowHeadersVisible = False
        Me.dgNotas.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgNotas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgNotas.RowTemplate.Height = 24
        Me.dgNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgNotas.Size = New System.Drawing.Size(793, 366)
        Me.dgNotas.TabIndex = 223
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'frmPrestador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1103, 728)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPrestador"
        Me.Text = "Prestador de Serviços"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgPrestadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents txtEmail As Windows.Forms.TextBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents txtUF As Windows.Forms.TextBox
    Friend WithEvents txtCidade As Windows.Forms.TextBox
    Friend WithEvents txtBairro As Windows.Forms.TextBox
    Friend WithEvents txtCompl As Windows.Forms.TextBox
    Friend WithEvents txtNro As Windows.Forms.TextBox
    Friend WithEvents txtEnd As Windows.Forms.TextBox
    Friend WithEvents txtNome As Windows.Forms.TextBox
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
    Friend WithEvents TxtCEP As Cls_Controls.Cls_CEP
    Friend WithEvents dgNotas As Windows.Forms.DataGridView
    Friend WithEvents txtCNPJ As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents txtFone As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents bto_Img_Cli As Windows.Forms.Button
    Friend WithEvents pic_Cliente As Windows.Forms.PictureBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Txt_ID As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents btnIncluir As Windows.Forms.Button
    Friend WithEvents txtDesc As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cboFuncao As Cls_Controls.Cls_ComboBox
    Friend WithEvents txtPlaca As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents dgPrestadores As Windows.Forms.DataGridView
    Friend WithEvents btoAlterar As Windows.Forms.Button
End Class
