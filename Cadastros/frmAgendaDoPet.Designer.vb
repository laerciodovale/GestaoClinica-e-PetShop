<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgendaDoPet
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
        Me.txtNomePet = New Cls_Controls.Cls_TextBox()
        Me.txtIdPet = New Cls_Controls.Cls_TextBox()
        Me.txtNomeTutor = New Cls_Controls.Cls_TextBox()
        Me.txtIdTutor = New Cls_Controls.Cls_TextBox()
        Me.pic_Paciente = New System.Windows.Forms.PictureBox()
        Me.dgOsPet = New System.Windows.Forms.DataGridView()
        Me.dgAgDaOs = New System.Windows.Forms.DataGridView()
        Me.txtOS = New Cls_Controls.Cls_TextBox()
        CType(Me.pic_Paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOsPet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAgDaOs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomePet
        '
        Me.txtNomePet.Enabled = False
        Me.txtNomePet.EnviaTab = True
        Me.txtNomePet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePet.Location = New System.Drawing.Point(136, 12)
        Me.txtNomePet.Name = "txtNomePet"
        Me.txtNomePet.Size = New System.Drawing.Size(353, 34)
        Me.txtNomePet.SomenteNumero = False
        Me.txtNomePet.TabIndex = 161
        '
        'txtIdPet
        '
        Me.txtIdPet.Enabled = False
        Me.txtIdPet.EnviaTab = True
        Me.txtIdPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPet.Location = New System.Drawing.Point(52, 12)
        Me.txtIdPet.Name = "txtIdPet"
        Me.txtIdPet.Size = New System.Drawing.Size(78, 34)
        Me.txtIdPet.SomenteNumero = False
        Me.txtIdPet.TabIndex = 159
        '
        'txtNomeTutor
        '
        Me.txtNomeTutor.Enabled = False
        Me.txtNomeTutor.EnviaTab = True
        Me.txtNomeTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeTutor.Location = New System.Drawing.Point(136, 80)
        Me.txtNomeTutor.Name = "txtNomeTutor"
        Me.txtNomeTutor.Size = New System.Drawing.Size(575, 34)
        Me.txtNomeTutor.SomenteNumero = False
        Me.txtNomeTutor.TabIndex = 157
        '
        'txtIdTutor
        '
        Me.txtIdTutor.Enabled = False
        Me.txtIdTutor.EnviaTab = True
        Me.txtIdTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTutor.Location = New System.Drawing.Point(53, 80)
        Me.txtIdTutor.Name = "txtIdTutor"
        Me.txtIdTutor.Size = New System.Drawing.Size(78, 34)
        Me.txtIdTutor.SomenteNumero = False
        Me.txtIdTutor.TabIndex = 156
        '
        'pic_Paciente
        '
        Me.pic_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_Paciente.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_Paciente.Location = New System.Drawing.Point(951, 12)
        Me.pic_Paciente.Name = "pic_Paciente"
        Me.pic_Paciente.Size = New System.Drawing.Size(194, 242)
        Me.pic_Paciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Paciente.TabIndex = 162
        Me.pic_Paciente.TabStop = False
        '
        'dgOsPet
        '
        Me.dgOsPet.AllowUserToOrderColumns = True
        Me.dgOsPet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgOsPet.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgOsPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOsPet.GridColor = System.Drawing.Color.White
        Me.dgOsPet.Location = New System.Drawing.Point(52, 146)
        Me.dgOsPet.MultiSelect = False
        Me.dgOsPet.Name = "dgOsPet"
        Me.dgOsPet.RowHeadersWidth = 51
        Me.dgOsPet.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgOsPet.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgOsPet.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgOsPet.RowTemplate.Height = 24
        Me.dgOsPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOsPet.Size = New System.Drawing.Size(659, 242)
        Me.dgOsPet.TabIndex = 163
        '
        'dgAgDaOs
        '
        Me.dgAgDaOs.AllowUserToOrderColumns = True
        Me.dgAgDaOs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgAgDaOs.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgAgDaOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgDaOs.GridColor = System.Drawing.Color.White
        Me.dgAgDaOs.Location = New System.Drawing.Point(53, 405)
        Me.dgAgDaOs.MultiSelect = False
        Me.dgAgDaOs.Name = "dgAgDaOs"
        Me.dgAgDaOs.RowHeadersWidth = 51
        Me.dgAgDaOs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgAgDaOs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgAgDaOs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue
        Me.dgAgDaOs.RowTemplate.Height = 24
        Me.dgAgDaOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAgDaOs.Size = New System.Drawing.Size(799, 243)
        Me.dgAgDaOs.TabIndex = 164
        '
        'txtOS
        '
        Me.txtOS.Enabled = False
        Me.txtOS.EnviaTab = True
        Me.txtOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS.Location = New System.Drawing.Point(717, 354)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(78, 34)
        Me.txtOS.SomenteNumero = False
        Me.txtOS.TabIndex = 165
        Me.txtOS.Visible = False
        '
        'frmAgendaDoPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 685)
        Me.Controls.Add(Me.txtOS)
        Me.Controls.Add(Me.dgAgDaOs)
        Me.Controls.Add(Me.dgOsPet)
        Me.Controls.Add(Me.pic_Paciente)
        Me.Controls.Add(Me.txtNomePet)
        Me.Controls.Add(Me.txtIdPet)
        Me.Controls.Add(Me.txtNomeTutor)
        Me.Controls.Add(Me.txtIdTutor)
        Me.Name = "frmAgendaDoPet"
        Me.Text = "Agenda Do Pet"
        CType(Me.pic_Paciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOsPet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAgDaOs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNomePet As Cls_Controls.Cls_TextBox
    Friend WithEvents txtNomeTutor As Cls_Controls.Cls_TextBox
    Friend WithEvents txtIdTutor As Cls_Controls.Cls_TextBox
    Friend WithEvents pic_Paciente As Windows.Forms.PictureBox
    Friend WithEvents dgOsPet As Windows.Forms.DataGridView
    Public WithEvents txtIdPet As Cls_Controls.Cls_TextBox
    Friend WithEvents dgAgDaOs As Windows.Forms.DataGridView
    Friend WithEvents txtOS As Cls_Controls.Cls_TextBox
End Class
