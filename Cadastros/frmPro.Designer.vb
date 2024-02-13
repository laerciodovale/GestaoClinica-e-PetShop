<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPro
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
    Private Sub InitializeComponent(crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPro))
        Me.SuspendLayout()
        '
        'frmPro
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmPro"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents epValida As Windows.Forms.ErrorProvider
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents pnDadosCliente As Windows.Forms.Panel
    Friend WithEvents TreeView1 As Windows.Forms.TreeView
    Friend WithEvents pnLateralCliente As Windows.Forms.Panel
    Friend WithEvents btnFrmConsulta As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents picMenuCliente As Windows.Forms.PictureBox
    Friend WithEvents btnFrmVacina As Windows.Forms.Button
    Friend WithEvents btnFrmReceita As Windows.Forms.Button
    Friend WithEvents PnPaciente As Windows.Forms.Panel
    Friend WithEvents bto_Img_Paciente As Windows.Forms.Button
    Friend WithEvents btoAlterarPaciente As Windows.Forms.Button
    Friend WithEvents btoGravaPaciente As Windows.Forms.Button
    Friend WithEvents Txt_DtNasAni As Cls_Controls.Cls_TextBoxData
    Friend WithEvents Pic_Paciente As Windows.Forms.PictureBox
    Friend WithEvents txt_Id_Paciente As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label28 As Windows.Forms.Label
    Friend WithEvents Txt_Obs As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Chip As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Pedigree As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents pnSexo As Windows.Forms.Panel
    Friend WithEvents rbFemea As Windows.Forms.RadioButton
    Friend WithEvents rbMacho As Windows.Forms.RadioButton
    Friend WithEvents cboConvenio As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboPelo As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboPorte As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboCor As Cls_Controls.Cls_ComboBox
    Friend WithEvents CboRaca As Cls_Controls.Cls_ComboBox
    Friend WithEvents rb_Outros As Windows.Forms.RadioButton
    Friend WithEvents rb_Felino As Windows.Forms.RadioButton
    Friend WithEvents rb_Canino As Windows.Forms.RadioButton
    Friend WithEvents Txt_Nome_Ani As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents Label26 As Windows.Forms.Label
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents PnCliente As Windows.Forms.Panel
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents bto_Img_Cli As Windows.Forms.Button
    Friend WithEvents btnAlterar As Windows.Forms.Button
    Friend WithEvents Txt_DtNas As Cls_Controls.Cls_TextBoxData
    Friend WithEvents btnGravar As Windows.Forms.Button
    Friend WithEvents Pic_Cliente As Windows.Forms.PictureBox
    Friend WithEvents Txt_CPF_CNPJ As Cls_Controls.Cls_TextBox_CPF_CNPJ
    Friend WithEvents Txt_CEP As Cls_Controls.Cls_CEP
    Friend WithEvents Txt_Fone2 As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents Txt_Fone1 As Cls_Controls.Cls_TextBoxFone
    Friend WithEvents Cbo_UF As Cls_Controls.Cls_ComboBox
    Friend WithEvents Cbo_Endereco As Cls_Controls.Cls_ComboBox
    Friend WithEvents Cbo_Bairro As Cls_Controls.Cls_ComboBox
    Friend WithEvents Txt_EMail As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Cidade As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Compl As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Nro As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Contato As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Nome_Cli As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_ID As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Txt_Rg As Cls_Controls.Cls_TextBoxOld
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents chkFJ As Windows.Forms.CheckBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cboTermos As Cls_Controls.Cls_ComboBox
    Friend WithEvents Label30 As Windows.Forms.Label
End Class
