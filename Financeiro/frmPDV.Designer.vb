<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPDV
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbNss = New System.Windows.Forms.Label()
        Me.lbUSR = New System.Windows.Forms.Label()
        Me.txtIdCli = New Cls_Controls.Cls_TextBox()
        Me.txtCpf = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.txtNome = New Cls_Controls.Cls_TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbItem = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotItem = New Cls_Controls.Cls_TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnit = New Cls_Controls.Cls_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnd = New Cls_Controls.Cls_TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtd = New Cls_Controls.Cls_TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCB = New Cls_Controls.Cls_TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotNota = New Cls_Controls.Cls_TextBox()
        Me.dgListaFat = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgListaFat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbNss)
        Me.Panel2.Controls.Add(Me.lbUSR)
        Me.Panel2.Controls.Add(Me.txtIdCli)
        Me.Panel2.Controls.Add(Me.txtCpf)
        Me.Panel2.Controls.Add(Me.txtNome)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lbItem)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtTotItem)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtUnit)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtUnd)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtQtd)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCB)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1642, 404)
        Me.Panel2.TabIndex = 1
        '
        'lbNss
        '
        Me.lbNss.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNss.Location = New System.Drawing.Point(16, 84)
        Me.lbNss.Name = "lbNss"
        Me.lbNss.Size = New System.Drawing.Size(282, 103)
        Me.lbNss.TabIndex = 166
        Me.lbNss.Text = "ID Venda"
        Me.lbNss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbUSR
        '
        Me.lbUSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUSR.Location = New System.Drawing.Point(16, 20)
        Me.lbUSR.Name = "lbUSR"
        Me.lbUSR.Size = New System.Drawing.Size(259, 52)
        Me.lbUSR.TabIndex = 165
        Me.lbUSR.Text = "usuario"
        Me.lbUSR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIdCli
        '
        Me.txtIdCli.Enabled = False
        Me.txtIdCli.EnviaTab = True
        Me.txtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCli.Location = New System.Drawing.Point(884, 72)
        Me.txtIdCli.Name = "txtIdCli"
        Me.txtIdCli.Size = New System.Drawing.Size(103, 26)
        Me.txtIdCli.SomenteNumero = False
        Me.txtIdCli.TabIndex = 164
        '
        'txtCpf
        '
        Me.txtCpf.EnviaTab = True
        Me.txtCpf.ExibirMensagem = False
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(407, 26)
        Me.txtCpf.MaxLength = 18
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(471, 72)
        Me.txtCpf.SomenteNumero = True
        Me.txtCpf.TabIndex = 0
        Me.txtCpf.ValidaCNPJ = True
        Me.txtCpf.ValidaCPF = False
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.EnviaTab = True
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(407, 104)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(1206, 72)
        Me.txtNome.SomenteNumero = False
        Me.txtNome.TabIndex = 162
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(311, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 46)
        Me.Label10.TabIndex = 163
        Me.Label10.Text = "CPF"
        '
        'lbItem
        '
        Me.lbItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbItem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItem.ForeColor = System.Drawing.Color.White
        Me.lbItem.Location = New System.Drawing.Point(330, 200)
        Me.lbItem.Name = "lbItem"
        Me.lbItem.Size = New System.Drawing.Size(1204, 60)
        Me.lbItem.TabIndex = 0
        Me.lbItem.Text = "Item"
        Me.lbItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Navy
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(337, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1212, 38)
        Me.Label6.TabIndex = 160
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1392, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 46)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "$Total"
        '
        'txtTotItem
        '
        Me.txtTotItem.Enabled = False
        Me.txtTotItem.EnviaTab = True
        Me.txtTotItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotItem.Location = New System.Drawing.Point(1357, 309)
        Me.txtTotItem.Name = "txtTotItem"
        Me.txtTotItem.Size = New System.Drawing.Size(204, 64)
        Me.txtTotItem.SomenteNumero = False
        Me.txtTotItem.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1136, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 46)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "$ Unit."
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.EnviaTab = True
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(1126, 310)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(184, 64)
        Me.txtUnit.SomenteNumero = False
        Me.txtUnit.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(976, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 46)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Und."
        '
        'txtUnd
        '
        Me.txtUnd.Enabled = False
        Me.txtUnd.EnviaTab = True
        Me.txtUnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnd.Location = New System.Drawing.Point(968, 309)
        Me.txtUnd.Name = "txtUnd"
        Me.txtUnd.Size = New System.Drawing.Size(122, 64)
        Me.txtUnd.SomenteNumero = False
        Me.txtUnd.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 46)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Qtd."
        '
        'txtQtd
        '
        Me.txtQtd.EnviaTab = True
        Me.txtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(340, 309)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(122, 72)
        Me.txtQtd.SomenteNumero = False
        Me.txtQtd.TabIndex = 1
        Me.txtQtd.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(544, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 46)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Cod.Produto"
        '
        'txtCB
        '
        Me.txtCB.EnviaTab = True
        Me.txtCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCB.Location = New System.Drawing.Point(497, 309)
        Me.txtCB.Name = "txtCB"
        Me.txtCB.Size = New System.Drawing.Size(433, 64)
        Me.txtCB.SomenteNumero = False
        Me.txtCB.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtTotNota)
        Me.Panel3.Controls.Add(Me.dgListaFat)
        Me.Panel3.Location = New System.Drawing.Point(0, 404)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1642, 518)
        Me.Panel3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(461, 29)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "F4 - Abre a Venda    F5 - Finaliza a Venda "
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(502, 29)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "F10 - Consulta Cliente F11 - Consulta Produto"
        '
        'txtTotNota
        '
        Me.txtTotNota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotNota.Enabled = False
        Me.txtTotNota.EnviaTab = True
        Me.txtTotNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotNota.Location = New System.Drawing.Point(1151, 439)
        Me.txtTotNota.Name = "txtTotNota"
        Me.txtTotNota.Size = New System.Drawing.Size(462, 72)
        Me.txtTotNota.SomenteNumero = False
        Me.txtTotNota.TabIndex = 1
        '
        'dgListaFat
        '
        Me.dgListaFat.AllowUserToAddRows = False
        Me.dgListaFat.AllowUserToDeleteRows = False
        Me.dgListaFat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgListaFat.BackgroundColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListaFat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgListaFat.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgListaFat.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgListaFat.GridColor = System.Drawing.Color.White
        Me.dgListaFat.Location = New System.Drawing.Point(16, 3)
        Me.dgListaFat.MultiSelect = False
        Me.dgListaFat.Name = "dgListaFat"
        Me.dgListaFat.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListaFat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgListaFat.RowHeadersVisible = False
        Me.dgListaFat.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgListaFat.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgListaFat.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgListaFat.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgListaFat.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgListaFat.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgListaFat.RowTemplate.Height = 24
        Me.dgListaFat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgListaFat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaFat.Size = New System.Drawing.Size(1614, 430)
        Me.dgListaFat.TabIndex = 0
        '
        'frmPDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1642, 922)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmPDV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ponto de Venda a Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgListaFat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtCB As Cls_Controls.Cls_TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtTotItem As Cls_Controls.Cls_TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtUnit As Cls_Controls.Cls_TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtUnd As Cls_Controls.Cls_TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtQtd As Cls_Controls.Cls_TextBox
    Private WithEvents dgListaFat As Windows.Forms.DataGridView
    Friend WithEvents txtTotNota As Cls_Controls.Cls_TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents lbItem As Windows.Forms.Label
    Friend WithEvents txtIdCli As Cls_Controls.Cls_TextBox
    Friend WithEvents txtCpf As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents txtNome As Cls_Controls.Cls_TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Private WithEvents lbNss As Windows.Forms.Label
    Private WithEvents lbUSR As Windows.Forms.Label
End Class
