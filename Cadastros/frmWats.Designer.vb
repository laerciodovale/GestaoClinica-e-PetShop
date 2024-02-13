<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWats))
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btoAnexo = New System.Windows.Forms.Button()
        Me.lblAnexo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btoMetodo3 = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(78, 56)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(201, 22)
        Me.txtTelefone.TabIndex = 0
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(78, 136)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(367, 129)
        Me.txtMensagem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro. Telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mensagem"
        '
        'btoAnexo
        '
        Me.btoAnexo.Image = CType(resources.GetObject("btoAnexo.Image"), System.Drawing.Image)
        Me.btoAnexo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btoAnexo.Location = New System.Drawing.Point(519, 103)
        Me.btoAnexo.Name = "btoAnexo"
        Me.btoAnexo.Size = New System.Drawing.Size(55, 55)
        Me.btoAnexo.TabIndex = 4
        Me.btoAnexo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btoAnexo.UseVisualStyleBackColor = True
        '
        'lblAnexo
        '
        Me.lblAnexo.AutoSize = True
        Me.lblAnexo.Location = New System.Drawing.Point(580, 103)
        Me.lblAnexo.Name = "lblAnexo"
        Me.lblAnexo.Size = New System.Drawing.Size(125, 17)
        Me.lblAnexo.TabIndex = 5
        Me.lblAnexo.Text = "Caminho do anexo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(583, 223)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(698, 153)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(146, 64)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        Me.btnEnviar.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(356, 64)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Enviar Mensagem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btoMetodo3
        '
        Me.btoMetodo3.Location = New System.Drawing.Point(402, 12)
        Me.btoMetodo3.Name = "btoMetodo3"
        Me.btoMetodo3.Size = New System.Drawing.Size(203, 35)
        Me.btoMetodo3.TabIndex = 9
        Me.btoMetodo3.Text = "Enviar"
        Me.btoMetodo3.UseVisualStyleBackColor = True
        Me.btoMetodo3.Visible = False
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(624, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(176, 35)
        Me.btnConectar.TabIndex = 10
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        Me.btnConectar.Visible = False
        '
        'frmWats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 438)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btoMetodo3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAnexo)
        Me.Controls.Add(Me.btoAnexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.txtTelefone)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWats"
        Me.Text = "Envio de Mensagem pelo WatsApp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTelefone As Windows.Forms.TextBox
    Friend WithEvents txtMensagem As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btoAnexo As Windows.Forms.Button
    Friend WithEvents lblAnexo As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btnEnviar As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents btoMetodo3 As Windows.Forms.Button
    Friend WithEvents btnConectar As Windows.Forms.Button
End Class
