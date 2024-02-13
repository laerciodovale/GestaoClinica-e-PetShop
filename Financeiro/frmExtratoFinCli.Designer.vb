<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtratoFinCli
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExtratoFinCli))
        Me.lbId = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.txtFaturado = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgFinanceiro = New System.Windows.Forms.DataGridView()
        Me.btoImprimir = New System.Windows.Forms.Button()
        CType(Me.dgFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.ForeColor = System.Drawing.Color.White
        Me.lbId.Location = New System.Drawing.Point(85, 29)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(51, 17)
        Me.lbId.TabIndex = 5
        Me.lbId.Text = "Label1"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNome.ForeColor = System.Drawing.Color.White
        Me.lbNome.Location = New System.Drawing.Point(142, 21)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(92, 29)
        Me.lbNome.TabIndex = 6
        Me.lbNome.Text = "Label2"
        '
        'txtFaturado
        '
        Me.txtFaturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaturado.Location = New System.Drawing.Point(263, 667)
        Me.txtFaturado.Name = "txtFaturado"
        Me.txtFaturado.Size = New System.Drawing.Size(165, 34)
        Me.txtFaturado.TabIndex = 7
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(560, 667)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(165, 34)
        Me.txtPago.TabIndex = 8
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(850, 667)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(165, 34)
        Me.txtSaldo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 633)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Faturado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(606, 633)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(897, 633)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Saldo"
        '
        'dgFinanceiro
        '
        Me.dgFinanceiro.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgFinanceiro.AllowUserToAddRows = False
        Me.dgFinanceiro.AllowUserToDeleteRows = False
        Me.dgFinanceiro.AllowUserToOrderColumns = True
        Me.dgFinanceiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFinanceiro.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFinanceiro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFinanceiro.GridColor = System.Drawing.Color.White
        Me.dgFinanceiro.Location = New System.Drawing.Point(88, 65)
        Me.dgFinanceiro.MultiSelect = False
        Me.dgFinanceiro.Name = "dgFinanceiro"
        Me.dgFinanceiro.ReadOnly = True
        Me.dgFinanceiro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFinanceiro.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgFinanceiro.RowHeadersVisible = False
        Me.dgFinanceiro.RowHeadersWidth = 20
        Me.dgFinanceiro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgFinanceiro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgFinanceiro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgFinanceiro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgFinanceiro.RowTemplate.Height = 24
        Me.dgFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFinanceiro.Size = New System.Drawing.Size(1259, 544)
        Me.dgFinanceiro.StandardTab = True
        Me.dgFinanceiro.TabIndex = 137
        '
        'btoImprimir
        '
        Me.btoImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btoImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btoImprimir.Image = CType(resources.GetObject("btoImprimir.Image"), System.Drawing.Image)
        Me.btoImprimir.Location = New System.Drawing.Point(1106, 642)
        Me.btoImprimir.Name = "btoImprimir"
        Me.btoImprimir.Size = New System.Drawing.Size(65, 55)
        Me.btoImprimir.TabIndex = 138
        Me.btoImprimir.UseVisualStyleBackColor = False
        '
        'frmExtratoFinCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1430, 729)
        Me.Controls.Add(Me.btoImprimir)
        Me.Controls.Add(Me.dgFinanceiro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.txtFaturado)
        Me.Controls.Add(Me.lbNome)
        Me.Controls.Add(Me.lbId)
        Me.Name = "frmExtratoFinCli"
        Me.Text = "Extrato Financeiro"
        CType(Me.dgFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNome As Windows.Forms.Label
    Friend WithEvents txtFaturado As Windows.Forms.TextBox
    Friend WithEvents txtPago As Windows.Forms.TextBox
    Friend WithEvents txtSaldo As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Public WithEvents lbId As Windows.Forms.Label
    Friend WithEvents dgFinanceiro As Windows.Forms.DataGridView
    Friend WithEvents btoImprimir As Windows.Forms.Button
End Class
