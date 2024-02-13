<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgBanho
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btoAgendar = New System.Windows.Forms.Button()
        Me.txtInicio = New Cls_Controls.Cls_TextBoxData()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOs = New Cls_Controls.Cls_TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSab = New System.Windows.Forms.CheckBox()
        Me.cbSex = New System.Windows.Forms.CheckBox()
        Me.cbQui = New System.Windows.Forms.CheckBox()
        Me.cbQua = New System.Windows.Forms.CheckBox()
        Me.cbTer = New System.Windows.Forms.CheckBox()
        Me.cbSeg = New System.Windows.Forms.CheckBox()
        Me.txtTermino = New Cls_Controls.Cls_TextBoxData()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ddOcorr = New System.Windows.Forms.DomainUpDown()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btoAgendar)
        Me.GroupBox2.Controls.Add(Me.txtInicio)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtOs)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbSab)
        Me.GroupBox2.Controls.Add(Me.cbSex)
        Me.GroupBox2.Controls.Add(Me.cbQui)
        Me.GroupBox2.Controls.Add(Me.cbQua)
        Me.GroupBox2.Controls.Add(Me.cbTer)
        Me.GroupBox2.Controls.Add(Me.cbSeg)
        Me.GroupBox2.Controls.Add(Me.txtTermino)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboPeriodo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ddOcorr)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(72, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 529)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodicidade"
        '
        'btoAgendar
        '
        Me.btoAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgendar.ForeColor = System.Drawing.Color.Black
        Me.btoAgendar.Location = New System.Drawing.Point(99, 419)
        Me.btoAgendar.Name = "btoAgendar"
        Me.btoAgendar.Size = New System.Drawing.Size(256, 65)
        Me.btoAgendar.TabIndex = 169
        Me.btoAgendar.Text = "Agendar"
        Me.btoAgendar.UseVisualStyleBackColor = True
        '
        'txtInicio
        '
        Me.txtInicio.EnviaTab = True
        Me.txtInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.Location = New System.Drawing.Point(214, 90)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(141, 30)
        Me.txtInicio.SomenteNumero = True
        Me.txtInicio.TabIndex = 168
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(151, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 25)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Ínicio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOs
        '
        Me.txtOs.EnviaTab = True
        Me.txtOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOs.Location = New System.Drawing.Point(214, 41)
        Me.txtOs.Name = "txtOs"
        Me.txtOs.Size = New System.Drawing.Size(141, 30)
        Me.txtOs.SomenteNumero = False
        Me.txtOs.TabIndex = 165
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(166, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 25)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "OS"
        '
        'cbSab
        '
        Me.cbSab.AutoSize = True
        Me.cbSab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSab.Location = New System.Drawing.Point(277, 346)
        Me.cbSab.Name = "cbSab"
        Me.cbSab.Size = New System.Drawing.Size(70, 29)
        Me.cbSab.TabIndex = 164
        Me.cbSab.Text = "Sab"
        Me.cbSab.UseVisualStyleBackColor = True
        '
        'cbSex
        '
        Me.cbSex.AutoSize = True
        Me.cbSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSex.Location = New System.Drawing.Point(183, 346)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(69, 29)
        Me.cbSex.TabIndex = 163
        Me.cbSex.Text = "Ses"
        Me.cbSex.UseVisualStyleBackColor = True
        '
        'cbQui
        '
        Me.cbQui.AutoSize = True
        Me.cbQui.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQui.Location = New System.Drawing.Point(95, 346)
        Me.cbQui.Name = "cbQui"
        Me.cbQui.Size = New System.Drawing.Size(65, 29)
        Me.cbQui.TabIndex = 162
        Me.cbQui.Text = "Qui"
        Me.cbQui.UseVisualStyleBackColor = True
        '
        'cbQua
        '
        Me.cbQua.AutoSize = True
        Me.cbQua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQua.Location = New System.Drawing.Point(275, 300)
        Me.cbQua.Name = "cbQua"
        Me.cbQua.Size = New System.Drawing.Size(72, 29)
        Me.cbQua.TabIndex = 161
        Me.cbQua.Text = "Qua"
        Me.cbQua.UseVisualStyleBackColor = True
        '
        'cbTer
        '
        Me.cbTer.AutoSize = True
        Me.cbTer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTer.Location = New System.Drawing.Point(183, 300)
        Me.cbTer.Name = "cbTer"
        Me.cbTer.Size = New System.Drawing.Size(64, 29)
        Me.cbTer.TabIndex = 160
        Me.cbTer.Text = "Ter"
        Me.cbTer.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTer.UseVisualStyleBackColor = True
        '
        'cbSeg
        '
        Me.cbSeg.AutoSize = True
        Me.cbSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSeg.Location = New System.Drawing.Point(95, 300)
        Me.cbSeg.Name = "cbSeg"
        Me.cbSeg.Size = New System.Drawing.Size(70, 29)
        Me.cbSeg.TabIndex = 159
        Me.cbSeg.Text = "Seg"
        Me.cbSeg.UseVisualStyleBackColor = True
        '
        'txtTermino
        '
        Me.txtTermino.EnviaTab = True
        Me.txtTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermino.Location = New System.Drawing.Point(214, 142)
        Me.txtTermino.Name = "txtTermino"
        Me.txtTermino.Size = New System.Drawing.Size(141, 30)
        Me.txtTermino.SomenteNumero = True
        Me.txtTermino.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(124, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Término"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPeriodo
        '
        Me.cboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Items.AddRange(New Object() {"Diário", "Semanal", "Quinzenal", "Mensal", "Anual"})
        Me.cboPeriodo.Location = New System.Drawing.Point(103, 238)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(252, 33)
        Me.cboPeriodo.TabIndex = 156
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Quantidade"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddOcorr
        '
        Me.ddOcorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddOcorr.Items.Add("1")
        Me.ddOcorr.Items.Add("2")
        Me.ddOcorr.Items.Add("3")
        Me.ddOcorr.Items.Add("4")
        Me.ddOcorr.Items.Add("5")
        Me.ddOcorr.Items.Add("6")
        Me.ddOcorr.Items.Add("7")
        Me.ddOcorr.Items.Add("8")
        Me.ddOcorr.Items.Add("9")
        Me.ddOcorr.Items.Add("10")
        Me.ddOcorr.Items.Add("11")
        Me.ddOcorr.Items.Add("12")
        Me.ddOcorr.Items.Add("13")
        Me.ddOcorr.Items.Add("14")
        Me.ddOcorr.Items.Add("15")
        Me.ddOcorr.Items.Add("16")
        Me.ddOcorr.Items.Add("17")
        Me.ddOcorr.Items.Add("18")
        Me.ddOcorr.Items.Add("19")
        Me.ddOcorr.Items.Add("20")
        Me.ddOcorr.Items.Add("21")
        Me.ddOcorr.Items.Add("22")
        Me.ddOcorr.Items.Add("23")
        Me.ddOcorr.Items.Add("24")
        Me.ddOcorr.Items.Add("25")
        Me.ddOcorr.Items.Add("28")
        Me.ddOcorr.Items.Add("29")
        Me.ddOcorr.Items.Add("30")
        Me.ddOcorr.Items.Add("31")
        Me.ddOcorr.Items.Add("32")
        Me.ddOcorr.Items.Add("33")
        Me.ddOcorr.Items.Add("34")
        Me.ddOcorr.Items.Add("35")
        Me.ddOcorr.Items.Add("36")
        Me.ddOcorr.Items.Add("37")
        Me.ddOcorr.Items.Add("38")
        Me.ddOcorr.Items.Add("39")
        Me.ddOcorr.Items.Add("40")
        Me.ddOcorr.Items.Add("41")
        Me.ddOcorr.Items.Add("42")
        Me.ddOcorr.Items.Add("43")
        Me.ddOcorr.Items.Add("44")
        Me.ddOcorr.Items.Add("45")
        Me.ddOcorr.Items.Add("46")
        Me.ddOcorr.Items.Add("47")
        Me.ddOcorr.Items.Add("48")
        Me.ddOcorr.Items.Add("49")
        Me.ddOcorr.Items.Add("50")
        Me.ddOcorr.Items.Add("51")
        Me.ddOcorr.Items.Add("52")
        Me.ddOcorr.Items.Add("53")
        Me.ddOcorr.Items.Add("54")
        Me.ddOcorr.Items.Add("55")
        Me.ddOcorr.Items.Add("56")
        Me.ddOcorr.Items.Add("57")
        Me.ddOcorr.Items.Add("58")
        Me.ddOcorr.Items.Add("59")
        Me.ddOcorr.Items.Add("60")
        Me.ddOcorr.Location = New System.Drawing.Point(275, 186)
        Me.ddOcorr.Name = "ddOcorr"
        Me.ddOcorr.Size = New System.Drawing.Size(80, 38)
        Me.ddOcorr.TabIndex = 154
        Me.ddOcorr.Text = "1"
        Me.ddOcorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAgBanho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(595, 593)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAgBanho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Serviços"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents txtInicio As Cls_Controls.Cls_TextBoxData
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents cbSab As Windows.Forms.CheckBox
    Friend WithEvents cbSex As Windows.Forms.CheckBox
    Friend WithEvents cbQui As Windows.Forms.CheckBox
    Friend WithEvents cbQua As Windows.Forms.CheckBox
    Friend WithEvents cbTer As Windows.Forms.CheckBox
    Friend WithEvents cbSeg As Windows.Forms.CheckBox
    Friend WithEvents txtTermino As Cls_Controls.Cls_TextBoxData
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents cboPeriodo As Windows.Forms.ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents ddOcorr As Windows.Forms.DomainUpDown
    Friend WithEvents btoAgendar As Windows.Forms.Button
    Public WithEvents txtOs As Cls_Controls.Cls_TextBox
End Class
