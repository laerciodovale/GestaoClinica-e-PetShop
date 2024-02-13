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
        Me.lblZap = New System.Windows.Forms.Label()
        Me.txtCpf = New Cls_Controls.Cls_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboServicos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObs = New Cls_Controls.Cls_TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ddM = New System.Windows.Forms.DomainUpDown()
        Me.ddH = New System.Windows.Forms.DomainUpDown()
        Me.txtTermino = New System.Windows.Forms.DateTimePicker()
        Me.txtInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomePet = New Cls_Controls.Cls_TextBox()
        Me.txtIdPet = New Cls_Controls.Cls_TextBox()
        Me.txtNomeCli = New Cls_Controls.Cls_TextBox()
        Me.txtIdCli = New Cls_Controls.Cls_TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOs = New Cls_Controls.Cls_TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSab = New System.Windows.Forms.CheckBox()
        Me.cbSex = New System.Windows.Forms.CheckBox()
        Me.cbQui = New System.Windows.Forms.CheckBox()
        Me.cbQua = New System.Windows.Forms.CheckBox()
        Me.cbTer = New System.Windows.Forms.CheckBox()
        Me.cbSeg = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ddOcorr = New System.Windows.Forms.DomainUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtObsServ = New Cls_Controls.Cls_TextBoxOld()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObsTutor = New Cls_Controls.Cls_TextBoxOld()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.chkEnfeiteNao = New System.Windows.Forms.CheckBox()
        Me.chkAdesivo = New System.Windows.Forms.CheckBox()
        Me.chkGravata = New System.Windows.Forms.CheckBox()
        Me.chkBandana = New System.Windows.Forms.CheckBox()
        Me.chkLaco = New System.Windows.Forms.CheckBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.chkTosaTesoura = New System.Windows.Forms.CheckBox()
        Me.chkTosaTrimming = New System.Windows.Forms.CheckBox()
        Me.chkTosaPadraoRaca = New System.Windows.Forms.CheckBox()
        Me.chkTosaMaq = New System.Windows.Forms.CheckBox()
        Me.chkTosaHig = New System.Windows.Forms.CheckBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txtAlergiasOutras = New Cls_Controls.Cls_TextBoxOld()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkAlergiaPerfume = New System.Windows.Forms.CheckBox()
        Me.chkAlergiaLamina = New System.Windows.Forms.CheckBox()
        Me.chkAlergiaShampoo = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHidratacao = New Cls_Controls.Cls_TextBoxOld()
        Me.txtPenteado = New Cls_Controls.Cls_TextBoxOld()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btoAgendar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblZap)
        Me.GroupBox2.Controls.Add(Me.txtCpf)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboServicos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtObs)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtTermino)
        Me.GroupBox2.Controls.Add(Me.txtInicio)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNomePet)
        Me.GroupBox2.Controls.Add(Me.txtIdPet)
        Me.GroupBox2.Controls.Add(Me.txtNomeCli)
        Me.GroupBox2.Controls.Add(Me.txtIdCli)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtOs)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbSab)
        Me.GroupBox2.Controls.Add(Me.cbSex)
        Me.GroupBox2.Controls.Add(Me.cbQui)
        Me.GroupBox2.Controls.Add(Me.cbQua)
        Me.GroupBox2.Controls.Add(Me.cbTer)
        Me.GroupBox2.Controls.Add(Me.cbSeg)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboPeriodo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ddOcorr)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 692)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodicidade"
        '
        'lblZap
        '
        Me.lblZap.AutoSize = True
        Me.lblZap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZap.Location = New System.Drawing.Point(380, 171)
        Me.lblZap.Name = "lblZap"
        Me.lblZap.Size = New System.Drawing.Size(42, 25)
        Me.lblZap.TabIndex = 183
        Me.lblZap.Text = "OS"
        '
        'txtCpf
        '
        Me.txtCpf.Enabled = False
        Me.txtCpf.EnviaTab = True
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(168, 64)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(254, 30)
        Me.txtCpf.SomenteNumero = False
        Me.txtCpf.TabIndex = 182
        Me.txtCpf.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Serviços"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboServicos
        '
        Me.cboServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboServicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicos.FormattingEnabled = True
        Me.cboServicos.Items.AddRange(New Object() {"Diário", "Semanal", "Quinzenal", "Mensal", "Anual"})
        Me.cboServicos.Location = New System.Drawing.Point(16, 240)
        Me.cboServicos.Name = "cboServicos"
        Me.cboServicos.Size = New System.Drawing.Size(487, 33)
        Me.cboServicos.TabIndex = 180
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(239, 591)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Obs**"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtObs
        '
        Me.txtObs.EnviaTab = True
        Me.txtObs.Location = New System.Drawing.Point(16, 619)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(559, 64)
        Me.txtObs.SomenteNumero = False
        Me.txtObs.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ddM)
        Me.GroupBox1.Controls.Add(Me.ddH)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(296, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 94)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horário"
        '
        'ddM
        '
        Me.ddM.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddM.Items.Add("00")
        Me.ddM.Items.Add("15")
        Me.ddM.Items.Add("30")
        Me.ddM.Items.Add("45")
        Me.ddM.Location = New System.Drawing.Point(153, 25)
        Me.ddM.Name = "ddM"
        Me.ddM.Size = New System.Drawing.Size(80, 41)
        Me.ddM.TabIndex = 3
        Me.ddM.Text = "00"
        '
        'ddH
        '
        Me.ddH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddH.Items.Add("07")
        Me.ddH.Items.Add("08")
        Me.ddH.Items.Add("09")
        Me.ddH.Items.Add("10")
        Me.ddH.Items.Add("11")
        Me.ddH.Items.Add("12")
        Me.ddH.Items.Add("13")
        Me.ddH.Items.Add("14")
        Me.ddH.Items.Add("15")
        Me.ddH.Items.Add("16")
        Me.ddH.Items.Add("17")
        Me.ddH.Items.Add("18")
        Me.ddH.Items.Add("19")
        Me.ddH.Items.Add("")
        Me.ddH.Location = New System.Drawing.Point(23, 25)
        Me.ddH.Name = "ddH"
        Me.ddH.Size = New System.Drawing.Size(80, 41)
        Me.ddH.TabIndex = 2
        Me.ddH.Text = "07"
        '
        'txtTermino
        '
        Me.txtTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtTermino.Location = New System.Drawing.Point(114, 436)
        Me.txtTermino.Name = "txtTermino"
        Me.txtTermino.Size = New System.Drawing.Size(155, 30)
        Me.txtTermino.TabIndex = 176
        Me.txtTermino.Value = New Date(2023, 3, 13, 0, 0, 0, 0)
        '
        'txtInicio
        '
        Me.txtInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInicio.Location = New System.Drawing.Point(114, 397)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(155, 30)
        Me.txtInicio.TabIndex = 1
        Me.txtInicio.Value = New Date(2023, 3, 13, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNomePet
        '
        Me.txtNomePet.Enabled = False
        Me.txtNomePet.EnviaTab = True
        Me.txtNomePet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePet.Location = New System.Drawing.Point(90, 166)
        Me.txtNomePet.Name = "txtNomePet"
        Me.txtNomePet.Size = New System.Drawing.Size(252, 30)
        Me.txtNomePet.SomenteNumero = False
        Me.txtNomePet.TabIndex = 173
        '
        'txtIdPet
        '
        Me.txtIdPet.Enabled = False
        Me.txtIdPet.EnviaTab = True
        Me.txtIdPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPet.Location = New System.Drawing.Point(16, 166)
        Me.txtIdPet.Name = "txtIdPet"
        Me.txtIdPet.Size = New System.Drawing.Size(68, 30)
        Me.txtIdPet.SomenteNumero = False
        Me.txtIdPet.TabIndex = 172
        '
        'txtNomeCli
        '
        Me.txtNomeCli.Enabled = False
        Me.txtNomeCli.EnviaTab = True
        Me.txtNomeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCli.Location = New System.Drawing.Point(90, 123)
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(485, 30)
        Me.txtNomeCli.SomenteNumero = False
        Me.txtNomeCli.TabIndex = 171
        '
        'txtIdCli
        '
        Me.txtIdCli.Enabled = False
        Me.txtIdCli.EnviaTab = True
        Me.txtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCli.Location = New System.Drawing.Point(16, 123)
        Me.txtIdCli.Name = "txtIdCli"
        Me.txtIdCli.Size = New System.Drawing.Size(68, 30)
        Me.txtIdCli.SomenteNumero = False
        Me.txtIdCli.TabIndex = 170
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 397)
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
        Me.txtOs.Location = New System.Drawing.Point(14, 64)
        Me.txtOs.Name = "txtOs"
        Me.txtOs.Size = New System.Drawing.Size(141, 30)
        Me.txtOs.SomenteNumero = False
        Me.txtOs.TabIndex = 165
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 25)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "OS"
        '
        'cbSab
        '
        Me.cbSab.AutoSize = True
        Me.cbSab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSab.Location = New System.Drawing.Point(478, 548)
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
        Me.cbSex.Location = New System.Drawing.Point(384, 548)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(69, 29)
        Me.cbSex.TabIndex = 163
        Me.cbSex.Text = "Sex"
        Me.cbSex.UseVisualStyleBackColor = True
        '
        'cbQui
        '
        Me.cbQui.AutoSize = True
        Me.cbQui.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQui.Location = New System.Drawing.Point(296, 548)
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
        Me.cbQua.Location = New System.Drawing.Point(206, 548)
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
        Me.cbTer.Location = New System.Drawing.Point(114, 548)
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
        Me.cbSeg.Location = New System.Drawing.Point(26, 548)
        Me.cbSeg.Name = "cbSeg"
        Me.cbSeg.Size = New System.Drawing.Size(70, 29)
        Me.cbSeg.TabIndex = 159
        Me.cbSeg.Text = "Seg"
        Me.cbSeg.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Término"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Items.AddRange(New Object() {"Diário", "Semanal", "Quinzenal", "Mensal", "Anual"})
        Me.cboPeriodo.Location = New System.Drawing.Point(106, 318)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(172, 33)
        Me.cboPeriodo.TabIndex = 156
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 25)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Qtd."
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
        Me.ddOcorr.Location = New System.Drawing.Point(20, 318)
        Me.ddOcorr.Name = "ddOcorr"
        Me.ddOcorr.Size = New System.Drawing.Size(80, 38)
        Me.ddOcorr.TabIndex = 154
        Me.ddOcorr.Text = "1"
        Me.ddOcorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtObsServ)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtObsTutor)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.GroupBox16)
        Me.GroupBox3.Controls.Add(Me.GroupBox15)
        Me.GroupBox3.Controls.Add(Me.GroupBox14)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtHidratacao)
        Me.GroupBox3.Controls.Add(Me.txtPenteado)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(646, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(532, 692)
        Me.GroupBox3.TabIndex = 168
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Observações para Banho/Tosa"
        '
        'txtObsServ
        '
        Me.txtObsServ.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtObsServ.EnviaTab = True
        Me.txtObsServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsServ.Location = New System.Drawing.Point(36, 619)
        Me.txtObsServ.Multiline = True
        Me.txtObsServ.Name = "txtObsServ"
        Me.txtObsServ.Size = New System.Drawing.Size(463, 67)
        Me.txtObsServ.SomenteNumero = False
        Me.txtObsServ.TabIndex = 177
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(195, 591)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 25)
        Me.Label11.TabIndex = 178
        Me.Label11.Text = "Obs** do Banho"
        '
        'txtObsTutor
        '
        Me.txtObsTutor.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtObsTutor.EnviaTab = True
        Me.txtObsTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsTutor.Location = New System.Drawing.Point(34, 510)
        Me.txtObsTutor.Multiline = True
        Me.txtObsTutor.Name = "txtObsTutor"
        Me.txtObsTutor.Size = New System.Drawing.Size(463, 67)
        Me.txtObsTutor.SomenteNumero = False
        Me.txtObsTutor.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 25)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "Obs** do Tutor"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.chkEnfeiteNao)
        Me.GroupBox16.Controls.Add(Me.chkAdesivo)
        Me.GroupBox16.Controls.Add(Me.chkGravata)
        Me.GroupBox16.Controls.Add(Me.chkBandana)
        Me.GroupBox16.Controls.Add(Me.chkLaco)
        Me.GroupBox16.Location = New System.Drawing.Point(34, 250)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(465, 86)
        Me.GroupBox16.TabIndex = 174
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Enfeites"
        '
        'chkEnfeiteNao
        '
        Me.chkEnfeiteNao.AutoSize = True
        Me.chkEnfeiteNao.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkEnfeiteNao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnfeiteNao.ForeColor = System.Drawing.Color.Black
        Me.chkEnfeiteNao.Location = New System.Drawing.Point(163, 55)
        Me.chkEnfeiteNao.Name = "chkEnfeiteNao"
        Me.chkEnfeiteNao.Size = New System.Drawing.Size(96, 24)
        Me.chkEnfeiteNao.TabIndex = 16
        Me.chkEnfeiteNao.Text = "Não Usa"
        Me.chkEnfeiteNao.UseVisualStyleBackColor = True
        '
        'chkAdesivo
        '
        Me.chkAdesivo.AutoSize = True
        Me.chkAdesivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAdesivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdesivo.ForeColor = System.Drawing.Color.Black
        Me.chkAdesivo.Location = New System.Drawing.Point(60, 55)
        Me.chkAdesivo.Name = "chkAdesivo"
        Me.chkAdesivo.Size = New System.Drawing.Size(90, 24)
        Me.chkAdesivo.TabIndex = 15
        Me.chkAdesivo.Text = "Adesivo"
        Me.chkAdesivo.UseVisualStyleBackColor = True
        '
        'chkGravata
        '
        Me.chkGravata.AutoSize = True
        Me.chkGravata.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGravata.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGravata.ForeColor = System.Drawing.Color.Black
        Me.chkGravata.Location = New System.Drawing.Point(278, 25)
        Me.chkGravata.Name = "chkGravata"
        Me.chkGravata.Size = New System.Drawing.Size(90, 24)
        Me.chkGravata.TabIndex = 14
        Me.chkGravata.Text = "Gravata"
        Me.chkGravata.UseVisualStyleBackColor = True
        '
        'chkBandana
        '
        Me.chkBandana.AutoSize = True
        Me.chkBandana.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBandana.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBandana.ForeColor = System.Drawing.Color.Black
        Me.chkBandana.Location = New System.Drawing.Point(163, 25)
        Me.chkBandana.Name = "chkBandana"
        Me.chkBandana.Size = New System.Drawing.Size(97, 24)
        Me.chkBandana.TabIndex = 13
        Me.chkBandana.Text = "Bandana"
        Me.chkBandana.UseVisualStyleBackColor = True
        '
        'chkLaco
        '
        Me.chkLaco.AutoSize = True
        Me.chkLaco.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLaco.ForeColor = System.Drawing.Color.Black
        Me.chkLaco.Location = New System.Drawing.Point(60, 25)
        Me.chkLaco.Name = "chkLaco"
        Me.chkLaco.Size = New System.Drawing.Size(68, 24)
        Me.chkLaco.TabIndex = 12
        Me.chkLaco.Text = "Laço"
        Me.chkLaco.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.chkTosaTesoura)
        Me.GroupBox15.Controls.Add(Me.chkTosaTrimming)
        Me.GroupBox15.Controls.Add(Me.chkTosaPadraoRaca)
        Me.GroupBox15.Controls.Add(Me.chkTosaMaq)
        Me.GroupBox15.Controls.Add(Me.chkTosaHig)
        Me.GroupBox15.Location = New System.Drawing.Point(34, 145)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(465, 86)
        Me.GroupBox15.TabIndex = 173
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Tosa"
        '
        'chkTosaTesoura
        '
        Me.chkTosaTesoura.AutoSize = True
        Me.chkTosaTesoura.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTosaTesoura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTosaTesoura.ForeColor = System.Drawing.Color.Black
        Me.chkTosaTesoura.Location = New System.Drawing.Point(163, 51)
        Me.chkTosaTesoura.Name = "chkTosaTesoura"
        Me.chkTosaTesoura.Size = New System.Drawing.Size(92, 24)
        Me.chkTosaTesoura.TabIndex = 11
        Me.chkTosaTesoura.Text = "Tesoura"
        Me.chkTosaTesoura.UseVisualStyleBackColor = True
        '
        'chkTosaTrimming
        '
        Me.chkTosaTrimming.AutoSize = True
        Me.chkTosaTrimming.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTosaTrimming.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTosaTrimming.ForeColor = System.Drawing.Color.Black
        Me.chkTosaTrimming.Location = New System.Drawing.Point(60, 51)
        Me.chkTosaTrimming.Name = "chkTosaTrimming"
        Me.chkTosaTrimming.Size = New System.Drawing.Size(101, 24)
        Me.chkTosaTrimming.TabIndex = 10
        Me.chkTosaTrimming.Text = "Trimming"
        Me.chkTosaTrimming.UseVisualStyleBackColor = True
        '
        'chkTosaPadraoRaca
        '
        Me.chkTosaPadraoRaca.AutoSize = True
        Me.chkTosaPadraoRaca.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTosaPadraoRaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTosaPadraoRaca.ForeColor = System.Drawing.Color.Black
        Me.chkTosaPadraoRaca.Location = New System.Drawing.Point(278, 21)
        Me.chkTosaPadraoRaca.Name = "chkTosaPadraoRaca"
        Me.chkTosaPadraoRaca.Size = New System.Drawing.Size(151, 24)
        Me.chkTosaPadraoRaca.TabIndex = 9
        Me.chkTosaPadraoRaca.Text = "Padrão da Raça"
        Me.chkTosaPadraoRaca.UseVisualStyleBackColor = True
        '
        'chkTosaMaq
        '
        Me.chkTosaMaq.AutoSize = True
        Me.chkTosaMaq.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTosaMaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTosaMaq.ForeColor = System.Drawing.Color.Black
        Me.chkTosaMaq.Location = New System.Drawing.Point(163, 21)
        Me.chkTosaMaq.Name = "chkTosaMaq"
        Me.chkTosaMaq.Size = New System.Drawing.Size(94, 24)
        Me.chkTosaMaq.TabIndex = 8
        Me.chkTosaMaq.Text = "Maquina"
        Me.chkTosaMaq.UseVisualStyleBackColor = True
        '
        'chkTosaHig
        '
        Me.chkTosaHig.AutoSize = True
        Me.chkTosaHig.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTosaHig.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTosaHig.ForeColor = System.Drawing.Color.Black
        Me.chkTosaHig.Location = New System.Drawing.Point(60, 21)
        Me.chkTosaHig.Name = "chkTosaHig"
        Me.chkTosaHig.Size = New System.Drawing.Size(101, 24)
        Me.chkTosaHig.TabIndex = 7
        Me.chkTosaHig.Text = "Higiênica"
        Me.chkTosaHig.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.txtAlergiasOutras)
        Me.GroupBox14.Controls.Add(Me.Label9)
        Me.GroupBox14.Controls.Add(Me.chkAlergiaPerfume)
        Me.GroupBox14.Controls.Add(Me.chkAlergiaLamina)
        Me.GroupBox14.Controls.Add(Me.chkAlergiaShampoo)
        Me.GroupBox14.Location = New System.Drawing.Point(34, 362)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(463, 104)
        Me.GroupBox14.TabIndex = 172
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Alergias"
        '
        'txtAlergiasOutras
        '
        Me.txtAlergiasOutras.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtAlergiasOutras.EnviaTab = True
        Me.txtAlergiasOutras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlergiasOutras.Location = New System.Drawing.Point(97, 65)
        Me.txtAlergiasOutras.Name = "txtAlergiasOutras"
        Me.txtAlergiasOutras.Size = New System.Drawing.Size(290, 26)
        Me.txtAlergiasOutras.SomenteNumero = False
        Me.txtAlergiasOutras.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 25)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Outras"
        '
        'chkAlergiaPerfume
        '
        Me.chkAlergiaPerfume.AutoSize = True
        Me.chkAlergiaPerfume.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlergiaPerfume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlergiaPerfume.ForeColor = System.Drawing.Color.Black
        Me.chkAlergiaPerfume.Location = New System.Drawing.Point(280, 29)
        Me.chkAlergiaPerfume.Name = "chkAlergiaPerfume"
        Me.chkAlergiaPerfume.Size = New System.Drawing.Size(94, 24)
        Me.chkAlergiaPerfume.TabIndex = 19
        Me.chkAlergiaPerfume.Text = "Perfume"
        Me.chkAlergiaPerfume.UseVisualStyleBackColor = True
        '
        'chkAlergiaLamina
        '
        Me.chkAlergiaLamina.AutoSize = True
        Me.chkAlergiaLamina.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlergiaLamina.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlergiaLamina.ForeColor = System.Drawing.Color.Black
        Me.chkAlergiaLamina.Location = New System.Drawing.Point(156, 29)
        Me.chkAlergiaLamina.Name = "chkAlergiaLamina"
        Me.chkAlergiaLamina.Size = New System.Drawing.Size(86, 24)
        Me.chkAlergiaLamina.TabIndex = 18
        Me.chkAlergiaLamina.Text = "Lâmina"
        Me.chkAlergiaLamina.UseVisualStyleBackColor = True
        '
        'chkAlergiaShampoo
        '
        Me.chkAlergiaShampoo.AutoSize = True
        Me.chkAlergiaShampoo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlergiaShampoo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlergiaShampoo.ForeColor = System.Drawing.Color.Black
        Me.chkAlergiaShampoo.Location = New System.Drawing.Point(27, 29)
        Me.chkAlergiaShampoo.Name = "chkAlergiaShampoo"
        Me.chkAlergiaShampoo.Size = New System.Drawing.Size(101, 24)
        Me.chkAlergiaShampoo.TabIndex = 17
        Me.chkAlergiaShampoo.Text = "Shampoo"
        Me.chkAlergiaShampoo.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(37, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 25)
        Me.Label17.TabIndex = 171
        Me.Label17.Text = "Penteado"
        '
        'txtHidratacao
        '
        Me.txtHidratacao.BackColor = System.Drawing.Color.White
        Me.txtHidratacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtHidratacao.EnviaTab = True
        Me.txtHidratacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHidratacao.Location = New System.Drawing.Point(141, 60)
        Me.txtHidratacao.Name = "txtHidratacao"
        Me.txtHidratacao.Size = New System.Drawing.Size(358, 26)
        Me.txtHidratacao.SomenteNumero = False
        Me.txtHidratacao.TabIndex = 5
        '
        'txtPenteado
        '
        Me.txtPenteado.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPenteado.EnviaTab = True
        Me.txtPenteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenteado.Location = New System.Drawing.Point(139, 100)
        Me.txtPenteado.Name = "txtPenteado"
        Me.txtPenteado.Size = New System.Drawing.Size(358, 26)
        Me.txtPenteado.SomenteNumero = False
        Me.txtPenteado.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 25)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "Hidratação"
        '
        'btoAgendar
        '
        Me.btoAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoAgendar.ForeColor = System.Drawing.Color.Black
        Me.btoAgendar.Location = New System.Drawing.Point(45, 718)
        Me.btoAgendar.Name = "btoAgendar"
        Me.btoAgendar.Size = New System.Drawing.Size(1133, 46)
        Me.btoAgendar.TabIndex = 22
        Me.btoAgendar.Text = "Agendar"
        Me.btoAgendar.UseVisualStyleBackColor = True
        '
        'frmAgBanho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1210, 776)
        Me.Controls.Add(Me.btoAgendar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmAgBanho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Serviços"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents cbSab As Windows.Forms.CheckBox
    Friend WithEvents cbSex As Windows.Forms.CheckBox
    Friend WithEvents cbQui As Windows.Forms.CheckBox
    Friend WithEvents cbQua As Windows.Forms.CheckBox
    Friend WithEvents cbTer As Windows.Forms.CheckBox
    Friend WithEvents cbSeg As Windows.Forms.CheckBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents cboPeriodo As Windows.Forms.ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents ddOcorr As Windows.Forms.DomainUpDown
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtNomePet As Cls_Controls.Cls_TextBox
    Friend WithEvents txtNomeCli As Cls_Controls.Cls_TextBox
    Friend WithEvents txtInicio As Windows.Forms.DateTimePicker
    Friend WithEvents txtTermino As Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents ddM As Windows.Forms.DomainUpDown
    Friend WithEvents ddH As Windows.Forms.DomainUpDown
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtObs As Cls_Controls.Cls_TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents cboServicos As Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents txtObsTutor As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents GroupBox16 As Windows.Forms.GroupBox
    Friend WithEvents chkEnfeiteNao As Windows.Forms.CheckBox
    Friend WithEvents chkAdesivo As Windows.Forms.CheckBox
    Friend WithEvents chkGravata As Windows.Forms.CheckBox
    Friend WithEvents chkBandana As Windows.Forms.CheckBox
    Friend WithEvents chkLaco As Windows.Forms.CheckBox
    Friend WithEvents GroupBox15 As Windows.Forms.GroupBox
    Friend WithEvents chkTosaTesoura As Windows.Forms.CheckBox
    Friend WithEvents chkTosaTrimming As Windows.Forms.CheckBox
    Friend WithEvents chkTosaPadraoRaca As Windows.Forms.CheckBox
    Friend WithEvents chkTosaMaq As Windows.Forms.CheckBox
    Friend WithEvents chkTosaHig As Windows.Forms.CheckBox
    Friend WithEvents GroupBox14 As Windows.Forms.GroupBox
    Friend WithEvents txtAlergiasOutras As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents chkAlergiaPerfume As Windows.Forms.CheckBox
    Friend WithEvents chkAlergiaLamina As Windows.Forms.CheckBox
    Friend WithEvents chkAlergiaShampoo As Windows.Forms.CheckBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtHidratacao As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents txtPenteado As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents btoAgendar As Windows.Forms.Button
    Public WithEvents txtOs As Cls_Controls.Cls_TextBox
    Friend WithEvents txtCpf As Cls_Controls.Cls_TextBox
    Friend WithEvents txtObsServ As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents lblZap As Windows.Forms.Label
    Public WithEvents txtIdPet As Cls_Controls.Cls_TextBox
    Public WithEvents txtIdCli As Cls_Controls.Cls_TextBox
End Class
