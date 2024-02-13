<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRols
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
        Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.cboZoom = New System.Windows.Forms.ComboBox()
        Me.btnProxima = New System.Windows.Forms.Button()
        Me.btnUltima = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAnterior)
        Me.Panel1.Controls.Add(Me.btnUltima)
        Me.Panel1.Controls.Add(Me.btnProxima)
        Me.Panel1.Controls.Add(Me.cboZoom)
        Me.Panel1.Controls.Add(Me.txtPesquisar)
        Me.Panel1.Controls.Add(Me.btnPesquisar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1162, 80)
        Me.Panel1.TabIndex = 0
        '
        'crView
        '
        Me.crView.ActiveViewIndex = -1
        Me.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crView.Cursor = System.Windows.Forms.Cursors.Default
        Me.crView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crView.Location = New System.Drawing.Point(0, 80)
        Me.crView.Name = "crView"
        Me.crView.Size = New System.Drawing.Size(1162, 664)
        Me.crView.TabIndex = 1
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(420, 17)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(136, 29)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Button1"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(296, 24)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(106, 22)
        Me.txtPesquisar.TabIndex = 1
        '
        'cboZoom
        '
        Me.cboZoom.FormattingEnabled = True
        Me.cboZoom.Location = New System.Drawing.Point(580, 24)
        Me.cboZoom.Name = "cboZoom"
        Me.cboZoom.Size = New System.Drawing.Size(141, 24)
        Me.cboZoom.TabIndex = 2
        '
        'btnProxima
        '
        Me.btnProxima.Location = New System.Drawing.Point(737, 21)
        Me.btnProxima.Name = "btnProxima"
        Me.btnProxima.Size = New System.Drawing.Size(39, 29)
        Me.btnProxima.TabIndex = 3
        Me.btnProxima.Text = "Button1"
        Me.btnProxima.UseVisualStyleBackColor = True
        '
        'btnUltima
        '
        Me.btnUltima.Location = New System.Drawing.Point(794, 24)
        Me.btnUltima.Name = "btnUltima"
        Me.btnUltima.Size = New System.Drawing.Size(39, 29)
        Me.btnUltima.TabIndex = 4
        Me.btnUltima.Text = "Button2"
        Me.btnUltima.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(854, 21)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(39, 29)
        Me.btnAnterior.TabIndex = 5
        Me.btnAnterior.Text = "Button3"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'frmRols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 744)
        Me.Controls.Add(Me.crView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRols"
        Me.Text = "frmRols"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtPesquisar As Windows.Forms.TextBox
    Friend WithEvents btnPesquisar As Windows.Forms.Button
    Friend WithEvents cboZoom As Windows.Forms.ComboBox
    Friend WithEvents btnAnterior As Windows.Forms.Button
    Friend WithEvents btnUltima As Windows.Forms.Button
    Friend WithEvents btnProxima As Windows.Forms.Button
End Class
