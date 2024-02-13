<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendaDoCliente
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPF = New Cls_Controls.Cls_TextBox_CPF_CNPJ()
        Me.txtId = New Cls_Controls.Cls_TextBox()
        Me.txtNome = New Cls_Controls.Cls_TextBox()
        Me.dgAgenda = New System.Windows.Forms.DataGridView()
        Me.ImgCliente = New System.Windows.Forms.PictureBox()
        Me.txtEmail = New Cls_Controls.Cls_TextBox()
        Me.txtNro = New Cls_Controls.Cls_TextBox()
        Me.txtBairro = New Cls_Controls.Cls_TextBox()
        Me.txtEnd = New Cls_Controls.Cls_TextBox()
        CType(Me.dgAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "CPF/CNPJ"
        '
        'txtCPF
        '
        Me.txtCPF.EnviaTab = True
        Me.txtCPF.ExibirMensagem = False
        Me.txtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(12, 25)
        Me.txtCPF.MaxLength = 18
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(236, 34)
        Me.txtCPF.SomenteNumero = True
        Me.txtCPF.TabIndex = 146
        Me.txtCPF.ValidaCNPJ = True
        Me.txtCPF.ValidaCPF = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.EnviaTab = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(12, 78)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(78, 34)
        Me.txtId.SomenteNumero = False
        Me.txtId.TabIndex = 147
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.EnviaTab = True
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(95, 78)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(575, 34)
        Me.txtNome.SomenteNumero = False
        Me.txtNome.TabIndex = 148
        '
        'dgAgenda
        '
        Me.dgAgenda.BackgroundColor = System.Drawing.Color.White
        Me.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAgenda.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgAgenda.Location = New System.Drawing.Point(14, 267)
        Me.dgAgenda.Name = "dgAgenda"
        Me.dgAgenda.RowHeadersWidth = 51
        Me.dgAgenda.RowTemplate.Height = 24
        Me.dgAgenda.Size = New System.Drawing.Size(1342, 372)
        Me.dgAgenda.TabIndex = 149
        '
        'ImgCliente
        '
        Me.ImgCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgCliente.Location = New System.Drawing.Point(1100, 22)
        Me.ImgCliente.Name = "ImgCliente"
        Me.ImgCliente.Size = New System.Drawing.Size(243, 130)
        Me.ImgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgCliente.TabIndex = 150
        Me.ImgCliente.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.EnviaTab = True
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(12, 198)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(576, 34)
        Me.txtEmail.SomenteNumero = False
        Me.txtEmail.TabIndex = 151
        '
        'txtNro
        '
        Me.txtNro.Enabled = False
        Me.txtNro.EnviaTab = True
        Me.txtNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro.Location = New System.Drawing.Point(592, 118)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(78, 34)
        Me.txtNro.SomenteNumero = False
        Me.txtNro.TabIndex = 152
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.EnviaTab = True
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(12, 158)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(574, 34)
        Me.txtBairro.SomenteNumero = False
        Me.txtBairro.TabIndex = 153
        '
        'txtEnd
        '
        Me.txtEnd.Enabled = False
        Me.txtEnd.EnviaTab = True
        Me.txtEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(12, 118)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(576, 34)
        Me.txtEnd.SomenteNumero = False
        Me.txtEnd.TabIndex = 154
        '
        'frmAgendaDoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1374, 666)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.ImgCliente)
        Me.Controls.Add(Me.dgAgenda)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmAgendaDoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Do Cliente"
        CType(Me.dgAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtId As Cls_Controls.Cls_TextBox
    Friend WithEvents txtNome As Cls_Controls.Cls_TextBox
    Friend WithEvents dgAgenda As Windows.Forms.DataGridView
    Friend WithEvents ImgCliente As Windows.Forms.PictureBox
    Friend WithEvents txtEmail As Cls_Controls.Cls_TextBox
    Friend WithEvents txtNro As Cls_Controls.Cls_TextBox
    Friend WithEvents txtBairro As Cls_Controls.Cls_TextBox
    Friend WithEvents txtEnd As Cls_Controls.Cls_TextBox
    Public WithEvents txtCPF As Cls_Controls.Cls_TextBox_CPF_CNPJ
End Class
