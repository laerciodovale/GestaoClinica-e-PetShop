<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt
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
        Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cboZoom = New System.Windows.Forms.ComboBox()
        Me.txtPesquisar = New Cls_Controls.Cls_TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'crView
        '
        Me.crView.ActiveViewIndex = -1
        Me.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crView.Cursor = System.Windows.Forms.Cursors.Default
        Me.crView.Location = New System.Drawing.Point(31, 55)
        Me.crView.Name = "crView"
        Me.crView.Size = New System.Drawing.Size(996, 550)
        Me.crView.TabIndex = 0
        '
        'cboZoom
        '
        Me.cboZoom.FormattingEnabled = True
        Me.cboZoom.Location = New System.Drawing.Point(302, 15)
        Me.cboZoom.Name = "cboZoom"
        Me.cboZoom.Size = New System.Drawing.Size(200, 24)
        Me.cboZoom.TabIndex = 1
        '
        'txtPesquisar
        '
        Me.txtPesquisar.EnviaTab = True
        Me.txtPesquisar.Location = New System.Drawing.Point(615, 22)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(181, 22)
        Me.txtPesquisar.SomenteNumero = False
        Me.txtPesquisar.TabIndex = 2
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(825, 26)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(47, 29)
        Me.btnPesquisar.TabIndex = 3
        Me.btnPesquisar.Text = "Button1"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 642)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Controls.Add(Me.cboZoom)
        Me.Controls.Add(Me.crView)
        Me.Name = "frmRpt"
        Me.Text = "frmRpt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboZoom As Windows.Forms.ComboBox
    Friend WithEvents txtPesquisar As Cls_Controls.Cls_TextBox
    Friend WithEvents btnPesquisar As Windows.Forms.Button
End Class
