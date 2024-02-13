<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaItem
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
        Me.gbFornecedor = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblHTTP = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtCNPJ = New System.Windows.Forms.TextBox()
        Me.lblIM = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFone = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblCompl = New System.Windows.Forms.Label()
        Me.lblNro = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblRazao = New System.Windows.Forms.Label()
        Me.lblFantazia = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.gbItens = New System.Windows.Forms.GroupBox()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDcto = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskDtNf = New System.Windows.Forms.MaskedTextBox()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.txtVUnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNroNota = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstItens = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Item = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DescItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Qtd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VDcto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbCobranca = New System.Windows.Forms.GroupBox()
        Me.txtVctoDupl = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorDupl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LstPagtos = New System.Windows.Forms.ListView()
        Me.ID_PAGTO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PG_VCTO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pg_Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotalNota = New System.Windows.Forms.Label()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.cmsPagto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletarItemDeCobrançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsItens = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletarItemDaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbFornecedor.SuspendLayout()
        Me.gbItens.SuspendLayout()
        Me.gbCobranca.SuspendLayout()
        Me.cmsPagto.SuspendLayout()
        Me.cmsItens.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFornecedor
        '
        Me.gbFornecedor.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbFornecedor.Controls.Add(Me.lblEmail)
        Me.gbFornecedor.Controls.Add(Me.lblHTTP)
        Me.gbFornecedor.Controls.Add(Me.lblID)
        Me.gbFornecedor.Controls.Add(Me.txtCNPJ)
        Me.gbFornecedor.Controls.Add(Me.lblIM)
        Me.gbFornecedor.Controls.Add(Me.Label15)
        Me.gbFornecedor.Controls.Add(Me.lblIE)
        Me.gbFornecedor.Controls.Add(Me.Label5)
        Me.gbFornecedor.Controls.Add(Me.lblFone)
        Me.gbFornecedor.Controls.Add(Me.lblCep)
        Me.gbFornecedor.Controls.Add(Me.lblUF)
        Me.gbFornecedor.Controls.Add(Me.lblCidade)
        Me.gbFornecedor.Controls.Add(Me.lblBairro)
        Me.gbFornecedor.Controls.Add(Me.lblCompl)
        Me.gbFornecedor.Controls.Add(Me.lblNro)
        Me.gbFornecedor.Controls.Add(Me.lblEndereco)
        Me.gbFornecedor.Controls.Add(Me.lblRazao)
        Me.gbFornecedor.Controls.Add(Me.lblFantazia)
        Me.gbFornecedor.Controls.Add(Me.Label14)
        Me.gbFornecedor.Controls.Add(Me.Label12)
        Me.gbFornecedor.Controls.Add(Me.Label11)
        Me.gbFornecedor.Controls.Add(Me.Label10)
        Me.gbFornecedor.Controls.Add(Me.Label9)
        Me.gbFornecedor.Controls.Add(Me.Label8)
        Me.gbFornecedor.Controls.Add(Me.Label7)
        Me.gbFornecedor.Controls.Add(Me.Label31)
        Me.gbFornecedor.Controls.Add(Me.Label33)
        Me.gbFornecedor.Location = New System.Drawing.Point(12, 12)
        Me.gbFornecedor.Name = "gbFornecedor"
        Me.gbFornecedor.Size = New System.Drawing.Size(1043, 204)
        Me.gbFornecedor.TabIndex = 15
        Me.gbFornecedor.TabStop = False
        Me.gbFornecedor.Text = "Dados do Fornecedor"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(531, 179)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(490, 22)
        Me.lblEmail.TabIndex = 196
        '
        'lblHTTP
        '
        Me.lblHTTP.BackColor = System.Drawing.Color.Transparent
        Me.lblHTTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHTTP.ForeColor = System.Drawing.Color.Black
        Me.lblHTTP.Location = New System.Drawing.Point(111, 179)
        Me.lblHTTP.Name = "lblHTTP"
        Me.lblHTTP.Size = New System.Drawing.Size(404, 22)
        Me.lblHTTP.TabIndex = 195
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(839, 29)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(80, 22)
        Me.lblID.TabIndex = 194
        '
        'txtCNPJ
        '
        Me.txtCNPJ.BackColor = System.Drawing.Color.White
        Me.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNPJ.ForeColor = System.Drawing.Color.Black
        Me.txtCNPJ.Location = New System.Drawing.Point(113, 25)
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(179, 22)
        Me.txtCNPJ.TabIndex = 170
        '
        'lblIM
        '
        Me.lblIM.BackColor = System.Drawing.Color.Transparent
        Me.lblIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIM.ForeColor = System.Drawing.Color.Black
        Me.lblIM.Location = New System.Drawing.Point(599, 30)
        Me.lblIM.Name = "lblIM"
        Me.lblIM.Size = New System.Drawing.Size(149, 22)
        Me.lblIM.TabIndex = 193
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(566, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 17)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "I.M."
        '
        'lblIE
        '
        Me.lblIE.BackColor = System.Drawing.Color.Transparent
        Me.lblIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIE.ForeColor = System.Drawing.Color.Black
        Me.lblIE.Location = New System.Drawing.Point(349, 28)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(149, 22)
        Me.lblIE.TabIndex = 191
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(316, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 190
        Me.Label5.Text = "I.E."
        '
        'lblFone
        '
        Me.lblFone.BackColor = System.Drawing.Color.Transparent
        Me.lblFone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFone.ForeColor = System.Drawing.Color.Black
        Me.lblFone.Location = New System.Drawing.Point(311, 154)
        Me.lblFone.Name = "lblFone"
        Me.lblFone.Size = New System.Drawing.Size(204, 22)
        Me.lblFone.TabIndex = 189
        '
        'lblCep
        '
        Me.lblCep.BackColor = System.Drawing.Color.Transparent
        Me.lblCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCep.ForeColor = System.Drawing.Color.Black
        Me.lblCep.Location = New System.Drawing.Point(113, 154)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(111, 22)
        Me.lblCep.TabIndex = 188
        '
        'lblUF
        '
        Me.lblUF.BackColor = System.Drawing.Color.Transparent
        Me.lblUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUF.ForeColor = System.Drawing.Color.Black
        Me.lblUF.Location = New System.Drawing.Point(853, 128)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(66, 22)
        Me.lblUF.TabIndex = 187
        '
        'lblCidade
        '
        Me.lblCidade.BackColor = System.Drawing.Color.Transparent
        Me.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCidade.ForeColor = System.Drawing.Color.Black
        Me.lblCidade.Location = New System.Drawing.Point(504, 128)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(317, 22)
        Me.lblCidade.TabIndex = 186
        '
        'lblBairro
        '
        Me.lblBairro.BackColor = System.Drawing.Color.Transparent
        Me.lblBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBairro.ForeColor = System.Drawing.Color.Black
        Me.lblBairro.Location = New System.Drawing.Point(113, 128)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(318, 22)
        Me.lblBairro.TabIndex = 185
        '
        'lblCompl
        '
        Me.lblCompl.BackColor = System.Drawing.Color.Transparent
        Me.lblCompl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompl.ForeColor = System.Drawing.Color.Black
        Me.lblCompl.Location = New System.Drawing.Point(705, 104)
        Me.lblCompl.Name = "lblCompl"
        Me.lblCompl.Size = New System.Drawing.Size(214, 22)
        Me.lblCompl.TabIndex = 184
        '
        'lblNro
        '
        Me.lblNro.BackColor = System.Drawing.Color.Transparent
        Me.lblNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNro.ForeColor = System.Drawing.Color.Black
        Me.lblNro.Location = New System.Drawing.Point(625, 104)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(74, 22)
        Me.lblNro.TabIndex = 183
        '
        'lblEndereco
        '
        Me.lblEndereco.BackColor = System.Drawing.Color.Transparent
        Me.lblEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndereco.ForeColor = System.Drawing.Color.Black
        Me.lblEndereco.Location = New System.Drawing.Point(113, 104)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(506, 22)
        Me.lblEndereco.TabIndex = 182
        '
        'lblRazao
        '
        Me.lblRazao.BackColor = System.Drawing.Color.Transparent
        Me.lblRazao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRazao.ForeColor = System.Drawing.Color.Black
        Me.lblRazao.Location = New System.Drawing.Point(113, 79)
        Me.lblRazao.Name = "lblRazao"
        Me.lblRazao.Size = New System.Drawing.Size(806, 22)
        Me.lblRazao.TabIndex = 181
        '
        'lblFantazia
        '
        Me.lblFantazia.BackColor = System.Drawing.Color.Transparent
        Me.lblFantazia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFantazia.ForeColor = System.Drawing.Color.Black
        Me.lblFantazia.Location = New System.Drawing.Point(113, 55)
        Me.lblFantazia.Name = "lblFantazia"
        Me.lblFantazia.Size = New System.Drawing.Size(480, 22)
        Me.lblFantazia.TabIndex = 180
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(57, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 17)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Razão"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(264, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 178
        Me.Label12.Text = "Fone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(73, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "CEP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(821, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "UF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(442, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Cidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(62, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Bairro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(70, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "End."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(42, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 17)
        Me.Label31.TabIndex = 172
        Me.Label31.Text = "Fantazia"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(36, 27)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 17)
        Me.Label33.TabIndex = 171
        Me.Label33.Text = "CNPJ/CPF"
        '
        'gbItens
        '
        Me.gbItens.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbItens.Controls.Add(Me.cboItem)
        Me.gbItens.Controls.Add(Me.txtLote)
        Me.gbItens.Controls.Add(Me.Label19)
        Me.gbItens.Controls.Add(Me.txtDcto)
        Me.gbItens.Controls.Add(Me.txtTotal)
        Me.gbItens.Controls.Add(Me.Label16)
        Me.gbItens.Controls.Add(Me.Label3)
        Me.gbItens.Controls.Add(Me.mskDtNf)
        Me.gbItens.Controls.Add(Me.txtQtd)
        Me.gbItens.Controls.Add(Me.txtVUnit)
        Me.gbItens.Controls.Add(Me.Label1)
        Me.gbItens.Controls.Add(Me.Label4)
        Me.gbItens.Controls.Add(Me.txtNroNota)
        Me.gbItens.Controls.Add(Me.Label13)
        Me.gbItens.Controls.Add(Me.Label2)
        Me.gbItens.Controls.Add(Me.LstItens)
        Me.gbItens.Location = New System.Drawing.Point(12, 216)
        Me.gbItens.Name = "gbItens"
        Me.gbItens.Size = New System.Drawing.Size(1043, 311)
        Me.gbItens.TabIndex = 16
        Me.gbItens.TabStop = False
        Me.gbItens.Text = "Dados da Nota"
        '
        'cboItem
        '
        Me.cboItem.BackColor = System.Drawing.Color.SteelBlue
        Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItem.ForeColor = System.Drawing.Color.White
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(426, 22)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(580, 26)
        Me.cboItem.TabIndex = 173
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.White
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLote.Location = New System.Drawing.Point(739, 81)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(248, 22)
        Me.txtLote.TabIndex = 169
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(692, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 17)
        Me.Label19.TabIndex = 172
        Me.Label19.Text = "Lote"
        '
        'txtDcto
        '
        Me.txtDcto.BackColor = System.Drawing.Color.White
        Me.txtDcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDcto.Location = New System.Drawing.Point(395, 84)
        Me.txtDcto.Name = "txtDcto"
        Me.txtDcto.Size = New System.Drawing.Size(107, 22)
        Me.txtDcto.TabIndex = 167
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(575, 84)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(107, 23)
        Me.txtTotal.TabIndex = 168
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(515, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 171
        Me.Label16.Text = "$ Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(338, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "$ Dcto"
        '
        'mskDtNf
        '
        Me.mskDtNf.BackColor = System.Drawing.Color.White
        Me.mskDtNf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDtNf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDtNf.ForeColor = System.Drawing.Color.Black
        Me.mskDtNf.Location = New System.Drawing.Point(222, 21)
        Me.mskDtNf.Mask = "00-00-0000"
        Me.mskDtNf.Name = "mskDtNf"
        Me.mskDtNf.Size = New System.Drawing.Size(107, 24)
        Me.mskDtNf.TabIndex = 159
        Me.mskDtNf.ValidatingType = GetType(Date)
        '
        'txtQtd
        '
        Me.txtQtd.BackColor = System.Drawing.Color.White
        Me.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtd.Location = New System.Drawing.Point(56, 81)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(107, 22)
        Me.txtQtd.TabIndex = 160
        '
        'txtVUnit
        '
        Me.txtVUnit.BackColor = System.Drawing.Color.White
        Me.txtVUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVUnit.Location = New System.Drawing.Point(222, 81)
        Me.txtVUnit.Name = "txtVUnit"
        Me.txtVUnit.Size = New System.Drawing.Size(107, 22)
        Me.txtVUnit.TabIndex = 161
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(169, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "$ Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Qtd."
        '
        'txtNroNota
        '
        Me.txtNroNota.BackColor = System.Drawing.Color.White
        Me.txtNroNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroNota.Location = New System.Drawing.Point(60, 21)
        Me.txtNroNota.Name = "txtNroNota"
        Me.txtNroNota.Size = New System.Drawing.Size(107, 22)
        Me.txtNroNota.TabIndex = 158
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(176, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 17)
        Me.Label13.TabIndex = 163
        Me.Label13.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Nro.:"
        '
        'LstItens
        '
        Me.LstItens.AccessibleRole = System.Windows.Forms.AccessibleRole.Row
        Me.LstItens.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LstItens.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Item, Me.DescItem, Me.Qtd, Me.VUnit, Me.VDcto, Me.VTotal, Me.Lote})
        Me.LstItens.FullRowSelect = True
        Me.LstItens.GridLines = True
        Me.LstItens.HideSelection = False
        Me.LstItens.Location = New System.Drawing.Point(11, 112)
        Me.LstItens.Name = "LstItens"
        Me.LstItens.Size = New System.Drawing.Size(998, 187)
        Me.LstItens.TabIndex = 15
        Me.LstItens.UseCompatibleStateImageBehavior = False
        Me.LstItens.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 49
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 155
        '
        'DescItem
        '
        Me.DescItem.Text = "Descrição do Item"
        Me.DescItem.Width = 342
        '
        'Qtd
        '
        Me.Qtd.Text = "Qtd."
        '
        'VUnit
        '
        Me.VUnit.Text = "$ Unit."
        Me.VUnit.Width = 86
        '
        'VDcto
        '
        Me.VDcto.Text = "$ Dcto."
        '
        'VTotal
        '
        Me.VTotal.Text = "$ Total"
        Me.VTotal.Width = 92
        '
        'Lote
        '
        Me.Lote.Text = "Lote"
        Me.Lote.Width = 144
        '
        'gbCobranca
        '
        Me.gbCobranca.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbCobranca.Controls.Add(Me.txtVctoDupl)
        Me.gbCobranca.Controls.Add(Me.txtValorDupl)
        Me.gbCobranca.Controls.Add(Me.Label6)
        Me.gbCobranca.Controls.Add(Me.Label17)
        Me.gbCobranca.Controls.Add(Me.LstPagtos)
        Me.gbCobranca.Location = New System.Drawing.Point(12, 521)
        Me.gbCobranca.Name = "gbCobranca"
        Me.gbCobranca.Size = New System.Drawing.Size(1043, 217)
        Me.gbCobranca.TabIndex = 17
        Me.gbCobranca.TabStop = False
        Me.gbCobranca.Text = "Dados da Cobranca"
        '
        'txtVctoDupl
        '
        Me.txtVctoDupl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtVctoDupl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVctoDupl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVctoDupl.ForeColor = System.Drawing.Color.Black
        Me.txtVctoDupl.Location = New System.Drawing.Point(117, 72)
        Me.txtVctoDupl.Mask = "00-00-0000"
        Me.txtVctoDupl.Name = "txtVctoDupl"
        Me.txtVctoDupl.Size = New System.Drawing.Size(103, 27)
        Me.txtVctoDupl.TabIndex = 144
        Me.txtVctoDupl.ValidatingType = GetType(Date)
        '
        'txtValorDupl
        '
        Me.txtValorDupl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtValorDupl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorDupl.Location = New System.Drawing.Point(297, 72)
        Me.txtValorDupl.Name = "txtValorDupl"
        Me.txtValorDupl.Size = New System.Drawing.Size(117, 22)
        Me.txtValorDupl.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(248, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Valor"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(16, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 17)
        Me.Label17.TabIndex = 142
        Me.Label17.Text = "Vencimento"
        '
        'LstPagtos
        '
        Me.LstPagtos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LstPagtos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_PAGTO, Me.PG_VCTO, Me.pg_Valor})
        Me.LstPagtos.FullRowSelect = True
        Me.LstPagtos.GridLines = True
        Me.LstPagtos.HideSelection = False
        Me.LstPagtos.Location = New System.Drawing.Point(672, 21)
        Me.LstPagtos.Name = "LstPagtos"
        Me.LstPagtos.Size = New System.Drawing.Size(277, 174)
        Me.LstPagtos.TabIndex = 4
        Me.LstPagtos.UseCompatibleStateImageBehavior = False
        Me.LstPagtos.View = System.Windows.Forms.View.Details
        '
        'ID_PAGTO
        '
        Me.ID_PAGTO.Text = "ID"
        '
        'PG_VCTO
        '
        Me.PG_VCTO.Text = "Venimento"
        Me.PG_VCTO.Width = 113
        '
        'pg_Valor
        '
        Me.pg_Valor.Text = "Valor"
        Me.pg_Valor.Width = 93
        '
        'lblTotalNota
        '
        Me.lblTotalNota.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNota.ForeColor = System.Drawing.Color.Black
        Me.lblTotalNota.Location = New System.Drawing.Point(914, 753)
        Me.lblTotalNota.Name = "lblTotalNota"
        Me.lblTotalNota.Size = New System.Drawing.Size(136, 22)
        Me.lblTotalNota.TabIndex = 169
        '
        'btoIncluir
        '
        Me.btoIncluir.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btoIncluir.Location = New System.Drawing.Point(12, 750)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(229, 31)
        Me.btoIncluir.TabIndex = 170
        Me.btoIncluir.Text = "Incluir Nota"
        Me.btoIncluir.UseVisualStyleBackColor = False
        '
        'cmsPagto
        '
        Me.cmsPagto.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsPagto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletarItemDeCobrançaToolStripMenuItem})
        Me.cmsPagto.Name = "cmsPagto"
        Me.cmsPagto.Size = New System.Drawing.Size(248, 28)
        '
        'DeletarItemDeCobrançaToolStripMenuItem
        '
        Me.DeletarItemDeCobrançaToolStripMenuItem.Name = "DeletarItemDeCobrançaToolStripMenuItem"
        Me.DeletarItemDeCobrançaToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.DeletarItemDeCobrançaToolStripMenuItem.Text = "Deletar Item de cobrança"
        '
        'cmsItens
        '
        Me.cmsItens.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsItens.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletarItemDaListaToolStripMenuItem})
        Me.cmsItens.Name = "cmsItens"
        Me.cmsItens.Size = New System.Drawing.Size(214, 28)
        '
        'DeletarItemDaListaToolStripMenuItem
        '
        Me.DeletarItemDaListaToolStripMenuItem.Name = "DeletarItemDaListaToolStripMenuItem"
        Me.DeletarItemDaListaToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.DeletarItemDaListaToolStripMenuItem.Text = "Deletar Item da lista"
        '
        'frmEntradaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1062, 786)
        Me.Controls.Add(Me.btoIncluir)
        Me.Controls.Add(Me.lblTotalNota)
        Me.Controls.Add(Me.gbCobranca)
        Me.Controls.Add(Me.gbItens)
        Me.Controls.Add(Me.gbFornecedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntradaItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançar Nota Fiscal"
        Me.gbFornecedor.ResumeLayout(False)
        Me.gbFornecedor.PerformLayout()
        Me.gbItens.ResumeLayout(False)
        Me.gbItens.PerformLayout()
        Me.gbCobranca.ResumeLayout(False)
        Me.gbCobranca.PerformLayout()
        Me.cmsPagto.ResumeLayout(False)
        Me.cmsItens.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbFornecedor As GroupBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblHTTP As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtCNPJ As TextBox
    Friend WithEvents lblIM As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblIE As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFone As Label
    Friend WithEvents lblCep As Label
    Friend WithEvents lblUF As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblBairro As Label
    Friend WithEvents lblCompl As Label
    Friend WithEvents lblNro As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblRazao As Label
    Friend WithEvents lblFantazia As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents gbItens As GroupBox
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtDcto As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskDtNf As MaskedTextBox
    Friend WithEvents txtQtd As TextBox
    Friend WithEvents txtVUnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNroNota As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LstItens As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents DescItem As ColumnHeader
    Friend WithEvents Qtd As ColumnHeader
    Friend WithEvents VUnit As ColumnHeader
    Friend WithEvents VDcto As ColumnHeader
    Friend WithEvents VTotal As ColumnHeader
    Friend WithEvents Lote As ColumnHeader
    Friend WithEvents gbCobranca As GroupBox
    Friend WithEvents txtVctoDupl As MaskedTextBox
    Friend WithEvents txtValorDupl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LstPagtos As ListView
    Friend WithEvents ID_PAGTO As ColumnHeader
    Friend WithEvents PG_VCTO As ColumnHeader
    Friend WithEvents pg_Valor As ColumnHeader
    Friend WithEvents lblTotalNota As Label
    Friend WithEvents btoIncluir As Button
    Friend WithEvents cmsPagto As ContextMenuStrip
    Friend WithEvents DeletarItemDeCobrançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsItens As ContextMenuStrip
    Friend WithEvents DeletarItemDaListaToolStripMenuItem As ToolStripMenuItem
End Class
