<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpts
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CadVetDataSet2 = New Cadastros.CadVetDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CadAnimalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadVetDataSet1 = New Cadastros.CadVetDataSet1()
        Me.CadAnimalTableAdapter = New Cadastros.CadVetDataSet1TableAdapters.CadAnimalTableAdapter()
        Me.CadAnimalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadAnimalTableAdapter1 = New Cadastros.CadVetDataSet2TableAdapters.CadAnimalTableAdapter()
        CType(Me.CadVetDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadAnimalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadVetDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadAnimalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CadVetDataSet2
        '
        Me.CadVetDataSet2.DataSetName = "CadVetDataSet2"
        Me.CadVetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CadAnimalBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Cadastros.RelClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(80, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(781, 266)
        Me.ReportViewer1.TabIndex = 0
        '
        'CadAnimalBindingSource
        '
        Me.CadAnimalBindingSource.DataMember = "CadAnimal"
        Me.CadAnimalBindingSource.DataSource = Me.CadVetDataSet1
        '
        'CadVetDataSet1
        '
        Me.CadVetDataSet1.DataSetName = "CadVetDataSet1"
        Me.CadVetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CadAnimalTableAdapter
        '
        Me.CadAnimalTableAdapter.ClearBeforeFill = True
        '
        'CadAnimalBindingSource1
        '
        Me.CadAnimalBindingSource1.DataMember = "CadAnimal"
        Me.CadAnimalBindingSource1.DataSource = Me.CadVetDataSet2
        '
        'CadAnimalTableAdapter1
        '
        Me.CadAnimalTableAdapter1.ClearBeforeFill = True
        '
        'frmRpts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 553)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRpts"
        Me.Text = "Relatorios"
        CType(Me.CadVetDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadAnimalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadVetDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadAnimalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CadAnimalBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CadVetDataSet1 As CadVetDataSet1
    Friend WithEvents CadAnimalTableAdapter As CadVetDataSet1TableAdapters.CadAnimalTableAdapter
    Friend WithEvents CadVetDataSet2 As CadVetDataSet2
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CadAnimalBindingSource1 As Windows.Forms.BindingSource
    Friend WithEvents CadAnimalTableAdapter1 As CadVetDataSet2TableAdapters.CadAnimalTableAdapter
End Class
