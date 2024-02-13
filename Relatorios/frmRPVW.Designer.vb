<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRPVW
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
        Me.components = New System.ComponentModel.Container()
        Me.txtParametro = New Cls_Controls.Cls_TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CadVetDataSet1 = New Relatorios.CadVetDataSet1()
        Me.vw_RelReceitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vw_RelReceitaTableAdapter = New Relatorios.CadVetDataSet1TableAdapters.vw_RelReceitaTableAdapter()
        Me.RvwGeral = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.CadVetDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_RelReceitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtParametro
        '
        Me.txtParametro.EnviaTab = True
        Me.txtParametro.Location = New System.Drawing.Point(52, 12)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(105, 22)
        Me.txtParametro.SomenteNumero = False
        Me.txtParametro.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CadVetDataSet1
        '
        Me.CadVetDataSet1.DataSetName = "CadVetDataSet1"
        Me.CadVetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vw_RelReceitaBindingSource
        '
        Me.vw_RelReceitaBindingSource.DataMember = "vw_RelReceita"
        Me.vw_RelReceitaBindingSource.DataSource = Me.CadVetDataSet1
        '
        'vw_RelReceitaTableAdapter
        '
        Me.vw_RelReceitaTableAdapter.ClearBeforeFill = True
        '
        'RvwGeral
        '
        Me.RvwGeral.LocalReport.ReportEmbeddedResource = "Relatorios.rptReceita.rdlc"
        Me.RvwGeral.Location = New System.Drawing.Point(52, 58)
        Me.RvwGeral.Name = "RvwGeral"
        Me.RvwGeral.ServerReport.BearerToken = Nothing
        Me.RvwGeral.Size = New System.Drawing.Size(936, 433)
        Me.RvwGeral.TabIndex = 3
        '
        'frmRPVW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 677)
        Me.Controls.Add(Me.RvwGeral)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtParametro)
        Me.Name = "frmRPVW"
        Me.Text = "Relatórios"
        CType(Me.CadVetDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_RelReceitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vw_RelReceitaBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CadVetDataSet1 As CadVetDataSet1
    Friend WithEvents vw_RelReceitaTableAdapter As CadVetDataSet1TableAdapters.vw_RelReceitaTableAdapter
    Friend WithEvents txtParametro As Cls_Controls.Cls_TextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents RvwGeral As Microsoft.Reporting.WinForms.ReportViewer
End Class
