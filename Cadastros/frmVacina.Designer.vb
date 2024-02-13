<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacina
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ckTosse = New System.Windows.Forms.CheckBox()
        Me.mskTosse = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskAntR = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ckG2Dose = New System.Windows.Forms.CheckBox()
        Me.ckG1Dose = New System.Windows.Forms.CheckBox()
        Me.mskGiar2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskGiar1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckV2Reforco = New System.Windows.Forms.CheckBox()
        Me.ckV1Reforco = New System.Windows.Forms.CheckBox()
        Me.ckV3Dose = New System.Windows.Forms.CheckBox()
        Me.ckV2Dose = New System.Windows.Forms.CheckBox()
        Me.ckV1Dose = New System.Windows.Forms.CheckBox()
        Me.ckPuppy = New System.Windows.Forms.CheckBox()
        Me.mskRefor2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskRefor1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskDose3 = New System.Windows.Forms.MaskedTextBox()
        Me.mskDose2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskDose1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskPuppy = New System.Windows.Forms.MaskedTextBox()
        Me.cboVacinas = New System.Windows.Forms.ComboBox()
        Me.dgVacinasEfetuadas = New System.Windows.Forms.DataGridView()
        Me.dgVacinasCadastradas = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btoIncluir = New System.Windows.Forms.Button()
        Me.btoImpirmir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgVacinasEfetuadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVacinasCadastradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cboVacinas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 259)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plano de Vacina"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ckTosse)
        Me.GroupBox5.Controls.Add(Me.mskTosse)
        Me.GroupBox5.Location = New System.Drawing.Point(758, 141)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(231, 68)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tosse"
        '
        'ckTosse
        '
        Me.ckTosse.AutoSize = True
        Me.ckTosse.Checked = True
        Me.ckTosse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckTosse.Location = New System.Drawing.Point(29, 25)
        Me.ckTosse.Name = "ckTosse"
        Me.ckTosse.Size = New System.Drawing.Size(63, 21)
        Me.ckTosse.TabIndex = 57
        Me.ckTosse.Text = "Dose"
        Me.ckTosse.UseVisualStyleBackColor = True
        '
        'mskTosse
        '
        Me.mskTosse.BackColor = System.Drawing.Color.White
        Me.mskTosse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskTosse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTosse.ForeColor = System.Drawing.Color.Black
        Me.mskTosse.Location = New System.Drawing.Point(132, 21)
        Me.mskTosse.Mask = "00/00/0000"
        Me.mskTosse.Name = "mskTosse"
        Me.mskTosse.Size = New System.Drawing.Size(85, 26)
        Me.mskTosse.TabIndex = 35
        Me.mskTosse.ValidatingType = GetType(Date)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.mskAntR)
        Me.GroupBox4.Location = New System.Drawing.Point(758, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 68)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Anti-Rábica"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Dose"
        '
        'mskAntR
        '
        Me.mskAntR.BackColor = System.Drawing.Color.White
        Me.mskAntR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskAntR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskAntR.ForeColor = System.Drawing.Color.Black
        Me.mskAntR.Location = New System.Drawing.Point(132, 23)
        Me.mskAntR.Mask = "00/00/0000"
        Me.mskAntR.Name = "mskAntR"
        Me.mskAntR.Size = New System.Drawing.Size(85, 26)
        Me.mskAntR.TabIndex = 35
        Me.mskAntR.ValidatingType = GetType(Date)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ckG2Dose)
        Me.GroupBox3.Controls.Add(Me.ckG1Dose)
        Me.GroupBox3.Controls.Add(Me.mskGiar2)
        Me.GroupBox3.Controls.Add(Me.mskGiar1)
        Me.GroupBox3.Location = New System.Drawing.Point(497, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 142)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Giardiase"
        '
        'ckG2Dose
        '
        Me.ckG2Dose.AutoSize = True
        Me.ckG2Dose.Checked = True
        Me.ckG2Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckG2Dose.Location = New System.Drawing.Point(27, 96)
        Me.ckG2Dose.Name = "ckG2Dose"
        Me.ckG2Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckG2Dose.TabIndex = 57
        Me.ckG2Dose.Text = "2 Dose"
        Me.ckG2Dose.UseVisualStyleBackColor = True
        '
        'ckG1Dose
        '
        Me.ckG1Dose.AutoSize = True
        Me.ckG1Dose.Checked = True
        Me.ckG1Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckG1Dose.Location = New System.Drawing.Point(27, 27)
        Me.ckG1Dose.Name = "ckG1Dose"
        Me.ckG1Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckG1Dose.TabIndex = 56
        Me.ckG1Dose.Text = "1 Dose"
        Me.ckG1Dose.UseVisualStyleBackColor = True
        '
        'mskGiar2
        '
        Me.mskGiar2.BackColor = System.Drawing.Color.White
        Me.mskGiar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskGiar2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskGiar2.ForeColor = System.Drawing.Color.Black
        Me.mskGiar2.Location = New System.Drawing.Point(132, 94)
        Me.mskGiar2.Mask = "00/00/0000"
        Me.mskGiar2.Name = "mskGiar2"
        Me.mskGiar2.Size = New System.Drawing.Size(85, 26)
        Me.mskGiar2.TabIndex = 37
        Me.mskGiar2.ValidatingType = GetType(Date)
        '
        'mskGiar1
        '
        Me.mskGiar1.BackColor = System.Drawing.Color.White
        Me.mskGiar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskGiar1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskGiar1.ForeColor = System.Drawing.Color.Black
        Me.mskGiar1.Location = New System.Drawing.Point(132, 25)
        Me.mskGiar1.Mask = "00/00/0000"
        Me.mskGiar1.Name = "mskGiar1"
        Me.mskGiar1.Size = New System.Drawing.Size(85, 26)
        Me.mskGiar1.TabIndex = 35
        Me.mskGiar1.ValidatingType = GetType(Date)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckV2Reforco)
        Me.GroupBox2.Controls.Add(Me.ckV1Reforco)
        Me.GroupBox2.Controls.Add(Me.ckV3Dose)
        Me.GroupBox2.Controls.Add(Me.ckV2Dose)
        Me.GroupBox2.Controls.Add(Me.ckV1Dose)
        Me.GroupBox2.Controls.Add(Me.ckPuppy)
        Me.GroupBox2.Controls.Add(Me.mskRefor2)
        Me.GroupBox2.Controls.Add(Me.mskRefor1)
        Me.GroupBox2.Controls.Add(Me.mskDose3)
        Me.GroupBox2.Controls.Add(Me.mskDose2)
        Me.GroupBox2.Controls.Add(Me.mskDose1)
        Me.GroupBox2.Controls.Add(Me.mskPuppy)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 186)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vacinas"
        '
        'ckV2Reforco
        '
        Me.ckV2Reforco.AutoSize = True
        Me.ckV2Reforco.Checked = True
        Me.ckV2Reforco.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV2Reforco.Location = New System.Drawing.Point(233, 68)
        Me.ckV2Reforco.Name = "ckV2Reforco"
        Me.ckV2Reforco.Size = New System.Drawing.Size(92, 21)
        Me.ckV2Reforco.TabIndex = 55
        Me.ckV2Reforco.Text = "2 Reforço"
        Me.ckV2Reforco.UseVisualStyleBackColor = True
        '
        'ckV1Reforco
        '
        Me.ckV1Reforco.AutoSize = True
        Me.ckV1Reforco.Checked = True
        Me.ckV1Reforco.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV1Reforco.Location = New System.Drawing.Point(233, 27)
        Me.ckV1Reforco.Name = "ckV1Reforco"
        Me.ckV1Reforco.Size = New System.Drawing.Size(92, 21)
        Me.ckV1Reforco.TabIndex = 54
        Me.ckV1Reforco.Text = "1 Reforço"
        Me.ckV1Reforco.UseVisualStyleBackColor = True
        '
        'ckV3Dose
        '
        Me.ckV3Dose.AutoSize = True
        Me.ckV3Dose.Checked = True
        Me.ckV3Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV3Dose.Location = New System.Drawing.Point(22, 141)
        Me.ckV3Dose.Name = "ckV3Dose"
        Me.ckV3Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckV3Dose.TabIndex = 53
        Me.ckV3Dose.Text = "3 Dose"
        Me.ckV3Dose.UseVisualStyleBackColor = True
        '
        'ckV2Dose
        '
        Me.ckV2Dose.AutoSize = True
        Me.ckV2Dose.Checked = True
        Me.ckV2Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV2Dose.Location = New System.Drawing.Point(22, 101)
        Me.ckV2Dose.Name = "ckV2Dose"
        Me.ckV2Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckV2Dose.TabIndex = 52
        Me.ckV2Dose.Text = "2 Dose"
        Me.ckV2Dose.UseVisualStyleBackColor = True
        '
        'ckV1Dose
        '
        Me.ckV1Dose.AccessibleDescription = ""
        Me.ckV1Dose.AutoSize = True
        Me.ckV1Dose.Checked = True
        Me.ckV1Dose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckV1Dose.Location = New System.Drawing.Point(22, 68)
        Me.ckV1Dose.Name = "ckV1Dose"
        Me.ckV1Dose.Size = New System.Drawing.Size(75, 21)
        Me.ckV1Dose.TabIndex = 51
        Me.ckV1Dose.Text = "1 Dose"
        Me.ckV1Dose.UseVisualStyleBackColor = True
        '
        'ckPuppy
        '
        Me.ckPuppy.AutoSize = True
        Me.ckPuppy.Checked = True
        Me.ckPuppy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckPuppy.Location = New System.Drawing.Point(22, 28)
        Me.ckPuppy.Name = "ckPuppy"
        Me.ckPuppy.Size = New System.Drawing.Size(70, 21)
        Me.ckPuppy.TabIndex = 50
        Me.ckPuppy.Text = "Puppy"
        Me.ckPuppy.UseVisualStyleBackColor = True
        '
        'mskRefor2
        '
        Me.mskRefor2.BackColor = System.Drawing.Color.White
        Me.mskRefor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskRefor2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRefor2.ForeColor = System.Drawing.Color.Black
        Me.mskRefor2.Location = New System.Drawing.Point(358, 68)
        Me.mskRefor2.Mask = "00/00/0000"
        Me.mskRefor2.Name = "mskRefor2"
        Me.mskRefor2.Size = New System.Drawing.Size(85, 26)
        Me.mskRefor2.TabIndex = 43
        Me.mskRefor2.ValidatingType = GetType(Date)
        '
        'mskRefor1
        '
        Me.mskRefor1.BackColor = System.Drawing.Color.White
        Me.mskRefor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskRefor1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRefor1.ForeColor = System.Drawing.Color.Black
        Me.mskRefor1.Location = New System.Drawing.Point(358, 23)
        Me.mskRefor1.Mask = "00/00/0000"
        Me.mskRefor1.Name = "mskRefor1"
        Me.mskRefor1.Size = New System.Drawing.Size(85, 26)
        Me.mskRefor1.TabIndex = 41
        Me.mskRefor1.ValidatingType = GetType(Date)
        '
        'mskDose3
        '
        Me.mskDose3.BackColor = System.Drawing.Color.White
        Me.mskDose3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDose3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDose3.ForeColor = System.Drawing.Color.Black
        Me.mskDose3.Location = New System.Drawing.Point(142, 137)
        Me.mskDose3.Mask = "00/00/0000"
        Me.mskDose3.Name = "mskDose3"
        Me.mskDose3.Size = New System.Drawing.Size(85, 26)
        Me.mskDose3.TabIndex = 39
        Me.mskDose3.ValidatingType = GetType(Date)
        '
        'mskDose2
        '
        Me.mskDose2.BackColor = System.Drawing.Color.White
        Me.mskDose2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDose2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDose2.ForeColor = System.Drawing.Color.Black
        Me.mskDose2.Location = New System.Drawing.Point(142, 97)
        Me.mskDose2.Mask = "00/00/0000"
        Me.mskDose2.Name = "mskDose2"
        Me.mskDose2.Size = New System.Drawing.Size(85, 26)
        Me.mskDose2.TabIndex = 37
        Me.mskDose2.ValidatingType = GetType(Date)
        '
        'mskDose1
        '
        Me.mskDose1.BackColor = System.Drawing.Color.White
        Me.mskDose1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDose1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDose1.ForeColor = System.Drawing.Color.Black
        Me.mskDose1.Location = New System.Drawing.Point(142, 61)
        Me.mskDose1.Mask = "00/00/0000"
        Me.mskDose1.Name = "mskDose1"
        Me.mskDose1.Size = New System.Drawing.Size(85, 26)
        Me.mskDose1.TabIndex = 35
        Me.mskDose1.ValidatingType = GetType(Date)
        '
        'mskPuppy
        '
        Me.mskPuppy.BackColor = System.Drawing.Color.White
        Me.mskPuppy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskPuppy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPuppy.ForeColor = System.Drawing.Color.Black
        Me.mskPuppy.Location = New System.Drawing.Point(142, 21)
        Me.mskPuppy.Mask = "00/00/0000"
        Me.mskPuppy.Name = "mskPuppy"
        Me.mskPuppy.Size = New System.Drawing.Size(85, 26)
        Me.mskPuppy.TabIndex = 33
        Me.mskPuppy.ValidatingType = GetType(Date)
        '
        'cboVacinas
        '
        Me.cboVacinas.FormattingEnabled = True
        Me.cboVacinas.Location = New System.Drawing.Point(20, 37)
        Me.cboVacinas.Name = "cboVacinas"
        Me.cboVacinas.Size = New System.Drawing.Size(462, 24)
        Me.cboVacinas.TabIndex = 1
        '
        'dgVacinasEfetuadas
        '
        Me.dgVacinasEfetuadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVacinasEfetuadas.Location = New System.Drawing.Point(560, 317)
        Me.dgVacinasEfetuadas.Name = "dgVacinasEfetuadas"
        Me.dgVacinasEfetuadas.RowHeadersWidth = 51
        Me.dgVacinasEfetuadas.RowTemplate.Height = 24
        Me.dgVacinasEfetuadas.Size = New System.Drawing.Size(469, 321)
        Me.dgVacinasEfetuadas.TabIndex = 2
        '
        'dgVacinasCadastradas
        '
        Me.dgVacinasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVacinasCadastradas.Location = New System.Drawing.Point(12, 317)
        Me.dgVacinasCadastradas.Name = "dgVacinasCadastradas"
        Me.dgVacinasCadastradas.RowHeadersWidth = 51
        Me.dgVacinasCadastradas.RowTemplate.Height = 24
        Me.dgVacinasCadastradas.Size = New System.Drawing.Size(540, 321)
        Me.dgVacinasCadastradas.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(744, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Efetuadas"
        '
        'btoIncluir
        '
        Me.btoIncluir.Location = New System.Drawing.Point(12, 654)
        Me.btoIncluir.Name = "btoIncluir"
        Me.btoIncluir.Size = New System.Drawing.Size(285, 38)
        Me.btoIncluir.TabIndex = 47
        Me.btoIncluir.Text = "Cadastrar"
        Me.btoIncluir.UseVisualStyleBackColor = True
        '
        'btoImpirmir
        '
        Me.btoImpirmir.Location = New System.Drawing.Point(734, 654)
        Me.btoImpirmir.Name = "btoImpirmir"
        Me.btoImpirmir.Size = New System.Drawing.Size(285, 38)
        Me.btoImpirmir.TabIndex = 48
        Me.btoImpirmir.Text = "Impirmir"
        Me.btoImpirmir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Plano"
        '
        'frmVacina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 704)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btoImpirmir)
        Me.Controls.Add(Me.btoIncluir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgVacinasCadastradas)
        Me.Controls.Add(Me.dgVacinasEfetuadas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmVacina"
        Me.Text = "frmVacina"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgVacinasEfetuadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVacinasCadastradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents ckTosse As Windows.Forms.CheckBox
    Friend WithEvents mskTosse As Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents mskAntR As Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents ckG2Dose As Windows.Forms.CheckBox
    Friend WithEvents ckG1Dose As Windows.Forms.CheckBox
    Friend WithEvents mskGiar2 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskGiar1 As Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents ckV2Reforco As Windows.Forms.CheckBox
    Friend WithEvents ckV1Reforco As Windows.Forms.CheckBox
    Friend WithEvents ckV3Dose As Windows.Forms.CheckBox
    Friend WithEvents ckV2Dose As Windows.Forms.CheckBox
    Friend WithEvents ckV1Dose As Windows.Forms.CheckBox
    Friend WithEvents ckPuppy As Windows.Forms.CheckBox
    Friend WithEvents mskRefor2 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskRefor1 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskDose3 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskDose2 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskDose1 As Windows.Forms.MaskedTextBox
    Friend WithEvents mskPuppy As Windows.Forms.MaskedTextBox
    Friend WithEvents cboVacinas As Windows.Forms.ComboBox
    Friend WithEvents dgVacinasEfetuadas As Windows.Forms.DataGridView
    Friend WithEvents dgVacinasCadastradas As Windows.Forms.DataGridView
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btoIncluir As Windows.Forms.Button
    Friend WithEvents btoImpirmir As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
