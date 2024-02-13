<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaturamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaturamentos))
        Me.dtp_De = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Ate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgFinanceiro = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBusca = New System.Windows.Forms.ComboBox()
        CType(Me.dgFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_De
        '
        Me.dtp_De.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_De.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_De.Location = New System.Drawing.Point(39, 44)
        Me.dtp_De.Name = "dtp_De"
        Me.dtp_De.Size = New System.Drawing.Size(159, 30)
        Me.dtp_De.TabIndex = 151
        '
        'dtp_Ate
        '
        Me.dtp_Ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Ate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Ate.Location = New System.Drawing.Point(323, 42)
        Me.dtp_Ate.Name = "dtp_Ate"
        Me.dtp_Ate.Size = New System.Drawing.Size(159, 30)
        Me.dtp_Ate.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "De Data para pesquisa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(296, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Até Data para pesquisa"
        '
        'dgFinanceiro
        '
        Me.dgFinanceiro.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFinanceiro.Location = New System.Drawing.Point(39, 95)
        Me.dgFinanceiro.Name = "dgFinanceiro"
        Me.dgFinanceiro.RowHeadersWidth = 51
        Me.dgFinanceiro.RowTemplate.Height = 24
        Me.dgFinanceiro.Size = New System.Drawing.Size(1261, 684)
        Me.dgFinanceiro.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1085, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Label3"
        '
        'cboBusca
        '
        Me.cboBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusca.FormattingEnabled = True
        Me.cboBusca.Location = New System.Drawing.Point(535, 39)
        Me.cboBusca.Name = "cboBusca"
        Me.cboBusca.Size = New System.Drawing.Size(479, 33)
        Me.cboBusca.TabIndex = 157
        '
        'frmFaturamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1312, 803)
        Me.Controls.Add(Me.cboBusca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgFinanceiro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_Ate)
        Me.Controls.Add(Me.dtp_De)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaturamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumos"
        CType(Me.dgFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_De As Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Ate As Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents dgFinanceiro As Windows.Forms.DataGridView
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents cboBusca As Windows.Forms.ComboBox
End Class
