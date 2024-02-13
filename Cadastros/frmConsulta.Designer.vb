<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Me.dgAtendimentos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbAnaminese = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rtbHistorico = New System.Windows.Forms.RichTextBox()
        Me.rtbDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.rtbPrognostico = New System.Windows.Forms.RichTextBox()
        Me.opConsulta = New System.Windows.Forms.RadioButton()
        Me.opRetorno = New System.Windows.Forms.RadioButton()
        Me.txtTemp = New Cls_Controls.Cls_TextBoxOld()
        Me.txtPeso = New Cls_Controls.Cls_TextBoxOld()
        Me.txtRPM = New Cls_Controls.Cls_TextBoxOld()
        Me.txtBPM = New Cls_Controls.Cls_TextBoxOld()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPA = New Cls_Controls.Cls_TextBoxOld()
        Me.mcRetorno = New System.Windows.Forms.MonthCalendar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgAtendimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAtendimentos
        '
        Me.dgAtendimentos.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgAtendimentos.AllowUserToAddRows = False
        Me.dgAtendimentos.AllowUserToDeleteRows = False
        Me.dgAtendimentos.AllowUserToOrderColumns = True
        Me.dgAtendimentos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgAtendimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgAtendimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgAtendimentos.ColumnHeadersHeight = 29
        Me.dgAtendimentos.GridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgAtendimentos.Location = New System.Drawing.Point(30, 45)
        Me.dgAtendimentos.MultiSelect = False
        Me.dgAtendimentos.Name = "dgAtendimentos"
        Me.dgAtendimentos.ReadOnly = True
        Me.dgAtendimentos.RowHeadersVisible = False
        Me.dgAtendimentos.RowHeadersWidth = 51
        Me.dgAtendimentos.RowTemplate.Height = 24
        Me.dgAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAtendimentos.Size = New System.Drawing.Size(215, 216)
        Me.dgAtendimentos.StandardTab = True
        Me.dgAtendimentos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Atendimentos"
        '
        'rtbAnaminese
        '
        Me.rtbAnaminese.Location = New System.Drawing.Point(28, 307)
        Me.rtbAnaminese.Name = "rtbAnaminese"
        Me.rtbAnaminese.Size = New System.Drawing.Size(807, 60)
        Me.rtbAnaminese.TabIndex = 9
        Me.rtbAnaminese.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 17)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "Anaminese"
        '
        'rtbHistorico
        '
        Me.rtbHistorico.Location = New System.Drawing.Point(25, 411)
        Me.rtbHistorico.Name = "rtbHistorico"
        Me.rtbHistorico.Size = New System.Drawing.Size(807, 60)
        Me.rtbHistorico.TabIndex = 10
        Me.rtbHistorico.Text = ""
        '
        'rtbDiagnostico
        '
        Me.rtbDiagnostico.Location = New System.Drawing.Point(25, 518)
        Me.rtbDiagnostico.Name = "rtbDiagnostico"
        Me.rtbDiagnostico.Size = New System.Drawing.Size(807, 60)
        Me.rtbDiagnostico.TabIndex = 11
        Me.rtbDiagnostico.Text = ""
        '
        'rtbPrognostico
        '
        Me.rtbPrognostico.Location = New System.Drawing.Point(25, 615)
        Me.rtbPrognostico.Name = "rtbPrognostico"
        Me.rtbPrognostico.Size = New System.Drawing.Size(807, 60)
        Me.rtbPrognostico.TabIndex = 12
        Me.rtbPrognostico.Text = ""
        '
        'opConsulta
        '
        Me.opConsulta.AutoSize = True
        Me.opConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opConsulta.Location = New System.Drawing.Point(368, 14)
        Me.opConsulta.Name = "opConsulta"
        Me.opConsulta.Size = New System.Drawing.Size(96, 24)
        Me.opConsulta.TabIndex = 2
        Me.opConsulta.TabStop = True
        Me.opConsulta.Text = "Consulta"
        Me.opConsulta.UseVisualStyleBackColor = True
        '
        'opRetorno
        '
        Me.opRetorno.AutoSize = True
        Me.opRetorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opRetorno.Location = New System.Drawing.Point(368, 44)
        Me.opRetorno.Name = "opRetorno"
        Me.opRetorno.Size = New System.Drawing.Size(89, 24)
        Me.opRetorno.TabIndex = 3
        Me.opRetorno.TabStop = True
        Me.opRetorno.Text = "Retorno"
        Me.opRetorno.UseVisualStyleBackColor = True
        '
        'txtTemp
        '
        Me.txtTemp.EnviaTab = True
        Me.txtTemp.Location = New System.Drawing.Point(368, 81)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(130, 22)
        Me.txtTemp.SomenteNumero = False
        Me.txtTemp.TabIndex = 4
        '
        'txtPeso
        '
        Me.txtPeso.EnviaTab = True
        Me.txtPeso.Location = New System.Drawing.Point(368, 125)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(130, 22)
        Me.txtPeso.SomenteNumero = False
        Me.txtPeso.TabIndex = 5
        '
        'txtRPM
        '
        Me.txtRPM.EnviaTab = True
        Me.txtRPM.Location = New System.Drawing.Point(368, 165)
        Me.txtRPM.Name = "txtRPM"
        Me.txtRPM.Size = New System.Drawing.Size(130, 22)
        Me.txtRPM.SomenteNumero = False
        Me.txtRPM.TabIndex = 6
        '
        'txtBPM
        '
        Me.txtBPM.EnviaTab = True
        Me.txtBPM.Location = New System.Drawing.Point(368, 202)
        Me.txtBPM.Name = "txtBPM"
        Me.txtBPM.Size = New System.Drawing.Size(130, 22)
        Me.txtBPM.SomenteNumero = False
        Me.txtBPM.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 17)
        Me.Label6.TabIndex = 192
        Me.Label6.Text = "PA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 191
        Me.Label5.Text = "BPM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "RPM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(272, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Temperatura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Peso"
        '
        'txtPA
        '
        Me.txtPA.EnviaTab = True
        Me.txtPA.Location = New System.Drawing.Point(368, 241)
        Me.txtPA.Name = "txtPA"
        Me.txtPA.Size = New System.Drawing.Size(130, 22)
        Me.txtPA.SomenteNumero = False
        Me.txtPA.TabIndex = 8
        '
        'mcRetorno
        '
        Me.mcRetorno.Location = New System.Drawing.Point(566, 56)
        Me.mcRetorno.Name = "mcRetorno"
        Me.mcRetorno.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(640, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 17)
        Me.Label9.TabIndex = 195
        Me.Label9.Text = "Data para Retorno"
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(73, 688)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(118, 30)
        Me.btnIncluir.TabIndex = 196
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(380, 688)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(118, 30)
        Me.btnAlterar.TabIndex = 197
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(705, 688)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(118, 30)
        Me.btnExcluir.TabIndex = 198
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Diagnóstico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Historico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 595)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Prognóstico"
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(865, 730)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mcRetorno)
        Me.Controls.Add(Me.txtPA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBPM)
        Me.Controls.Add(Me.txtRPM)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.opRetorno)
        Me.Controls.Add(Me.opConsulta)
        Me.Controls.Add(Me.rtbPrognostico)
        Me.Controls.Add(Me.rtbDiagnostico)
        Me.Controls.Add(Me.rtbHistorico)
        Me.Controls.Add(Me.rtbAnaminese)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgAtendimentos)
        Me.Name = "frmConsulta"
        Me.Text = "Consulta"
        CType(Me.dgAtendimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgAtendimentos As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents rtbAnaminese As Windows.Forms.RichTextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents rtbHistorico As Windows.Forms.RichTextBox
    Friend WithEvents rtbDiagnostico As Windows.Forms.RichTextBox
    Friend WithEvents rtbPrognostico As Windows.Forms.RichTextBox
    Friend WithEvents opConsulta As Windows.Forms.RadioButton
    Friend WithEvents opRetorno As Windows.Forms.RadioButton
    Friend WithEvents txtTemp As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtPeso As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtRPM As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtBPM As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtPA As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents mcRetorno As Windows.Forms.MonthCalendar
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btnIncluir As Windows.Forms.Button
    Friend WithEvents btnAlterar As Windows.Forms.Button
    Friend WithEvents btnExcluir As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
