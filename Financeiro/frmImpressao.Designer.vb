<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpressao
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
        Me.crwImp = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crwImp
        '
        Me.crwImp.ActiveViewIndex = -1
        Me.crwImp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crwImp.Cursor = System.Windows.Forms.Cursors.Default
        Me.crwImp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crwImp.Location = New System.Drawing.Point(0, 0)
        Me.crwImp.Name = "crwImp"
        Me.crwImp.Size = New System.Drawing.Size(1287, 751)
        Me.crwImp.TabIndex = 0
        '
        'frmImpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 751)
        Me.Controls.Add(Me.crwImp)
        Me.Name = "frmImpressao"
        Me.Text = "Imprimir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents crwImp As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
