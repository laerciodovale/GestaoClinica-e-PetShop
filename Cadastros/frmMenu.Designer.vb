<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboTiposPesquisa = New Cls_Controls.Cls_ComboBox()
        Me.txt_Busca = New Cls_Controls.Cls_TextBoxOld()
        Me.DgGridTop = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgGridTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1634, 777)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 762)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cboTiposPesquisa)
        Me.Panel2.Controls.Add(Me.txt_Busca)
        Me.Panel2.Controls.Add(Me.DgGridTop)
        Me.Panel2.Location = New System.Drawing.Point(3, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 718)
        Me.Panel2.TabIndex = 3
        '
        'cboTiposPesquisa
        '
        Me.cboTiposPesquisa.EnviaTab = True
        Me.cboTiposPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTiposPesquisa.FormattingEnabled = True
        Me.cboTiposPesquisa.Location = New System.Drawing.Point(14, 13)
        Me.cboTiposPesquisa.Name = "cboTiposPesquisa"
        Me.cboTiposPesquisa.Size = New System.Drawing.Size(220, 24)
        Me.cboTiposPesquisa.TabIndex = 4
        '
        'txt_Busca
        '
        Me.txt_Busca.EnviaTab = True
        Me.txt_Busca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Busca.Location = New System.Drawing.Point(14, 64)
        Me.txt_Busca.Name = "txt_Busca"
        Me.txt_Busca.Size = New System.Drawing.Size(220, 23)
        Me.txt_Busca.SomenteNumero = False
        Me.txt_Busca.TabIndex = 3
        '
        'DgGridTop
        '
        Me.DgGridTop.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DgGridTop.AllowUserToAddRows = False
        Me.DgGridTop.AllowUserToDeleteRows = False
        Me.DgGridTop.AllowUserToOrderColumns = True
        Me.DgGridTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgGridTop.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.DgGridTop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgGridTop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgGridTop.ColumnHeadersHeight = 29
        Me.DgGridTop.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgGridTop.Location = New System.Drawing.Point(14, 92)
        Me.DgGridTop.MultiSelect = False
        Me.DgGridTop.Name = "DgGridTop"
        Me.DgGridTop.ReadOnly = True
        Me.DgGridTop.RowHeadersVisible = False
        Me.DgGridTop.RowHeadersWidth = 51
        Me.DgGridTop.RowTemplate.Height = 24
        Me.DgGridTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgGridTop.Size = New System.Drawing.Size(219, 626)
        Me.DgGridTop.StandardTab = True
        Me.DgGridTop.TabIndex = 0
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1634, 777)
        Me.Controls.Add(Me.Panel3)
        Me.IsMdiContainer = True
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SisVet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgGridTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cboTiposPesquisa As Cls_Controls.Cls_ComboBox
    Friend WithEvents txt_Busca As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents DgGridTop As DataGridView
End Class
