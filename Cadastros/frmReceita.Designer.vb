<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceita
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckEspecial = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstReceitasAv = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRecomendacao = New System.Windows.Forms.TextBox()
        Me.lstFarmacos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFarmaco = New System.Windows.Forms.TextBox()
        Me.dgReceita = New System.Windows.Forms.DataGridView()
        Me.btoLimparReceita = New System.Windows.Forms.Button()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.btoAlterar = New System.Windows.Forms.Button()
        Me.btoExcluir = New System.Windows.Forms.Button()
        Me.txtIdReceita = New Cls_Controls.Cls_TextBoxOld()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        CType(Me.dgReceita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 44)
        Me.Panel1.TabIndex = 1
        '
        'ckEspecial
        '
        Me.ckEspecial.AutoSize = True
        Me.ckEspecial.Location = New System.Drawing.Point(162, 70)
        Me.ckEspecial.Name = "ckEspecial"
        Me.ckEspecial.Size = New System.Drawing.Size(135, 21)
        Me.ckEspecial.TabIndex = 138
        Me.ckEspecial.Text = "Receita Especial"
        Me.ckEspecial.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Receita"
        '
        'lstReceitasAv
        '
        Me.lstReceitasAv.FormatString = "d"
        Me.lstReceitasAv.FormattingEnabled = True
        Me.lstReceitasAv.ItemHeight = 16
        Me.lstReceitasAv.Location = New System.Drawing.Point(10, 125)
        Me.lstReceitasAv.Name = "lstReceitasAv"
        Me.lstReceitasAv.Size = New System.Drawing.Size(137, 308)
        Me.lstReceitasAv.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = " Receitas Aviadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(435, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Recomendações"
        '
        'txtRecomendacao
        '
        Me.txtRecomendacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecomendacao.Location = New System.Drawing.Point(162, 364)
        Me.txtRecomendacao.MaxLength = 50
        Me.txtRecomendacao.Multiline = True
        Me.txtRecomendacao.Name = "txtRecomendacao"
        Me.txtRecomendacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRecomendacao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRecomendacao.Size = New System.Drawing.Size(830, 68)
        Me.txtRecomendacao.TabIndex = 133
        '
        'lstFarmacos
        '
        Me.lstFarmacos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFarmacos.FormattingEnabled = True
        Me.lstFarmacos.ItemHeight = 20
        Me.lstFarmacos.Location = New System.Drawing.Point(162, 124)
        Me.lstFarmacos.Name = "lstFarmacos"
        Me.lstFarmacos.Size = New System.Drawing.Size(602, 184)
        Me.lstFarmacos.Sorted = True
        Me.lstFarmacos.TabIndex = 132
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Farmacos"
        '
        'txtFarmaco
        '
        Me.txtFarmaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFarmaco.Location = New System.Drawing.Point(162, 314)
        Me.txtFarmaco.Name = "txtFarmaco"
        Me.txtFarmaco.Size = New System.Drawing.Size(602, 27)
        Me.txtFarmaco.TabIndex = 130
        '
        'dgReceita
        '
        Me.dgReceita.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgReceita.AllowUserToAddRows = False
        Me.dgReceita.AllowUserToDeleteRows = False
        Me.dgReceita.AllowUserToOrderColumns = True
        Me.dgReceita.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgReceita.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgReceita.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgReceita.ColumnHeadersHeight = 29
        Me.dgReceita.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgReceita.Location = New System.Drawing.Point(7, 480)
        Me.dgReceita.MultiSelect = False
        Me.dgReceita.Name = "dgReceita"
        Me.dgReceita.ReadOnly = True
        Me.dgReceita.RowHeadersVisible = False
        Me.dgReceita.RowHeadersWidth = 51
        Me.dgReceita.RowTemplate.Height = 24
        Me.dgReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReceita.Size = New System.Drawing.Size(985, 216)
        Me.dgReceita.StandardTab = True
        Me.dgReceita.TabIndex = 139
        '
        'btoLimparReceita
        '
        Me.btoLimparReceita.Location = New System.Drawing.Point(10, 723)
        Me.btoLimparReceita.Name = "btoLimparReceita"
        Me.btoLimparReceita.Size = New System.Drawing.Size(179, 29)
        Me.btoLimparReceita.TabIndex = 140
        Me.btoLimparReceita.Text = "Limpar"
        Me.btoLimparReceita.UseVisualStyleBackColor = True
        '
        'btoIncluir
        '
        Me.btoIncluir.Location = New System.Drawing.Point(267, 723)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(179, 29)
        Me.btoIncluir.TabIndex = 141
        Me.btoIncluir.Text = "Incluir"
        Me.btoIncluir.UseVisualStyleBackColor = True
        '
        'btoAlterar
        '
        Me.btoAlterar.Location = New System.Drawing.Point(550, 719)
        Me.btoAlterar.Name = "btoAlterar"
        Me.btoAlterar.Size = New System.Drawing.Size(179, 29)
        Me.btoAlterar.TabIndex = 142
        Me.btoAlterar.Text = "Alterar"
        Me.btoAlterar.UseVisualStyleBackColor = True
        '
        'btoExcluir
        '
        Me.btoExcluir.Location = New System.Drawing.Point(813, 723)
        Me.btoExcluir.Name = "btoExcluir"
        Me.btoExcluir.Size = New System.Drawing.Size(179, 29)
        Me.btoExcluir.TabIndex = 143
        Me.btoExcluir.Text = "Excluir"
        Me.btoExcluir.UseVisualStyleBackColor = True
        '
        'txtIdReceita
        '
        Me.txtIdReceita.EnviaTab = True
        Me.txtIdReceita.Location = New System.Drawing.Point(10, 439)
        Me.txtIdReceita.Name = "txtIdReceita"
        Me.txtIdReceita.Size = New System.Drawing.Size(137, 22)
        Me.txtIdReceita.SomenteNumero = False
        Me.txtIdReceita.TabIndex = 145
        '
        'btnImpirmir
        '
        Me.btnImpirmir.Enabled = False
        Me.btnImpirmir.Image = Global.Cadastros.My.Resources.Resources.printer_medicine_receipt_result_hospital_icon_188995
        Me.btnImpirmir.Location = New System.Drawing.Point(10, 55)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(55, 46)
        Me.btnImpirmir.TabIndex = 146
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'frmReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1009, 764)
        Me.Controls.Add(Me.btnImpirmir)
        Me.Controls.Add(Me.txtIdReceita)
        Me.Controls.Add(Me.btoExcluir)
        Me.Controls.Add(Me.btoAlterar)
        Me.Controls.Add(Me.btoIncluir)
        Me.Controls.Add(Me.btoLimparReceita)
        Me.Controls.Add(Me.dgReceita)
        Me.Controls.Add(Me.ckEspecial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstReceitasAv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRecomendacao)
        Me.Controls.Add(Me.lstFarmacos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFarmaco)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReceita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receita"
        CType(Me.dgReceita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ckEspecial As Windows.Forms.CheckBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lstReceitasAv As Windows.Forms.ListBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtRecomendacao As Windows.Forms.TextBox
    Friend WithEvents lstFarmacos As Windows.Forms.ListBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtFarmaco As Windows.Forms.TextBox
    Friend WithEvents dgReceita As Windows.Forms.DataGridView
    Friend WithEvents btoLimparReceita As Windows.Forms.Button
    Friend WithEvents btoIncluir As Windows.Forms.Button
    Friend WithEvents btoAlterar As Windows.Forms.Button
    Friend WithEvents btoExcluir As Windows.Forms.Button
    Friend WithEvents txtIdReceita As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents btnImpirmir As Windows.Forms.Button
End Class
