Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
'Imports OpenQA.Selenium
'Imports OpenQA.Selenium.Chrome

Imports DataBase
Imports Financeiro
Imports Materiais
Public Class frmM
#Region "Proriedades dos Clientes"
    Public Property Id_Cliente_Menu As Integer
    Public Property Id_Paciente_Menu As Integer

#End Region
    Private Cliente As New Cls_Cliente
    Private clsPront As New Cls_Prontuario
    Public clsFinan As New Cls_Financeiro
    Public clsUtil As New Utils
    Private frmAtivo As Form

    Public Property M_Usr_Aut As Integer
    Public Property M_Usr_Func As Integer

    Private Conta_Timer As Integer

    'Private formPront As frmProntuario = Nothing
    'Private frmAg As frmAgenda = Nothing
    'Private frmRpt As frmRptw = Nothing
    'Private frmCx As frmCaixa = Nothing
    'Private frmFin As frmLancaFinan = Nothing
    'Private frmAb As frmAbreFechaCx = Nothing
    'Private frmIt As FrmItens = Nothing
    'Private frmImp As frmImportXMLntfe = Nothing
    'Private frmFor As frmFornecedor = Nothing
    'Private frmEnt As frmEntradaItem = Nothing
    'Private frmFun As frmFuncionario = Nothing
    'Private frmCrys As frmCrystal = Nothing
    Private Sub frmShow(frm As Form)
        'pnAgenda.Visible = False
        'pnAniversarios.Visible = False
        'pnVacinas.Visible = False

        ActiveFormClose()
        frmAtivo = frm
        frm.Show()

    End Sub
    Private Sub frmShowD(frm As Form)
        'pnAgenda.Visible = False
        'pnAniversarios.Visible = False
        'pnVacinas.Visible = False

        ActiveFormClose()
        frmAtivo = frm
        frm.ShowDialog()

    End Sub
    Private Sub ActiveFormClose()

        If frmAtivo IsNot Nothing Then
            frmAtivo.Close()
            pnAgenda.Visible = True
            pnAniversarios.Visible = True
            pnVacinas.Visible = True
        End If

    End Sub
    Private Sub AtivaBotao(bAtivo As Button)

        'For Each ctrl As Control In pnBtoAg.Controls
        '    ctrl.ForeColor = Color.White
        'Next
        'For Each ctrl As Control In pnBotoes.Controls
        '    ctrl.ForeColor = Color.White
        'Next

        'For Each ctrl As Control In pnFinanceiroSub.Controls
        '    ctrl.ForeColor = Color.White
        'Next
        'For Each ctrl As Control In pnMateriaisSub.Controls
        '    ctrl.ForeColor = Color.White
        'Next

        'For Each ctrl As Control In pnProntuarioSub.Controls
        '    ctrl.ForeColor = Color.White
        'Next

        'For Each ctrl As Control In pnUsuario.Controls
        '    ctrl.ForeColor = Color.White
        'Next

        'bAtivo.ForeColor = Color.OrangeRed

    End Sub
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmProntuario.Veterinario = M_Usr_Func
        frmAnaminese.Veterinario = M_Usr_Func
        'LE DADOS DA EMPRESA

        clsUtil.Le_Empresa()
        txtFantasia.Text = clsUtil.emp_fanta
        txtDadosEmpresa.Text = clsUtil.DadosEmpresa

        ' showPanel()
        Timer1.Start()
        Timer2.Start()

        hideSubMenu()
        EscondeBotao()

        clsPront.Ag_Data = mcAgenda.SelectionStart.ToShortDateString
        Le_Agenda_Mdi()
        Le_Vacinas_Mdi()
        Le_Aniversdarios()

        le_medias()

    End Sub
    'Private Sub Centraliza(ByVal valor As String)
    '    Dim t1 As Integer
    '    Dim t2 As Integer
    '    Dim t3 As Integer = 46

    '    t1 = (t3 - valor.Length) / 2
    '    t2 = (valor.Length)

    '    Dim sb As New System.Text.StringBuilder(valor)

    '    For x = 0 To t1
    '        If sb.Length <= t3 Then
    '            sb.Insert(x, "*")
    '            sb.Insert(sb.Length, "*")
    '        End If
    '    Next

    '    txtDadosEmpresa.Text = txtDadosEmpresa.Text & sb.ToString & vbCrLf

    'End Sub


    Private Sub Le_Medias()
        Dim dtg As DataTable
        Dim Banho As New Cls_Banho
        dtg = Banho.Le_Metas
        dgvMetaBanho.DataSource = dtg

        dgvMetaBanho.ColumnHeadersHeight = 20

        dgvMetaBanho.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvMetaBanho.Columns(0).HeaderText = "Data"
        dgvMetaBanho.Columns(0).Width = 35
        dgvMetaBanho.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvMetaBanho.Columns(1).HeaderText = "Funcionario"
        dgvMetaBanho.Columns(1).Width = 50
        dgvMetaBanho.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvMetaBanho.Columns(2).HeaderText = "Qtd.Banho"
        dgvMetaBanho.Columns(2).Width = 35
        dgvMetaBanho.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvMetaBanho.Columns(3).HeaderText = "Qtd.Secagem"
        dgvMetaBanho.Columns(3).Width = 35
        dgvMetaBanho.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvMetaBanho.Columns(4).HeaderText = "Qtd.Tosa"
        dgvMetaBanho.Columns(4).Width = 35


    End Sub
    Private Sub Le_Aniversdarios()
        Dim dtg As DataTable

        dtg = clsPront.LeAniversarios(Format(Now, "MM"), Format(Now, "dd"), "Sp_Cliente_DiaNas")

        DgAniversarioHumanos.DataSource = dtg

        If dtg.Rows.Count.ToString = 0 Then
            ''   pnAniversarios.Visible = False
            ''Exit Sub
        End If
        DgAniversarioHumanos.ColumnHeadersHeight = 20
        ''ClId, ClNome, ClEmail, ClCel
        DgAniversarioHumanos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioHumanos.Columns(0).HeaderText = "ID"
        DgAniversarioHumanos.Columns(0).Width = 4
        DgAniversarioHumanos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioHumanos.Columns(1).HeaderText = "Nome do Tutor"
        DgAniversarioHumanos.Columns(1).Width = 80
        DgAniversarioHumanos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioHumanos.Columns(2).HeaderText = "Celular"
        DgAniversarioHumanos.Columns(2).Width = 30
        DgAniversarioHumanos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioHumanos.Columns(3).HeaderText = "Email do Tutor"
        DgAniversarioHumanos.Columns(3).Width = 80

        '' Dim dtg As DataTable
        dtg = clsPront.LeAniversarios(Format(Now, "MM"), Format(Now, "dd"), "Sp_Animal_DiaNas")
        DgAniversarioAnimal.DataSource = dtg

        If dtg.Rows.Count.ToString = 0 Then
            ''   pnAniversarios.Visible = False
            '' Exit Sub
        End If
        DgAniversarioAnimal.ColumnHeadersHeight = 20
        ''select IdAnimal, AniNome, ClNome, ClEmail, ClCel, AniEspécie , anisexo
        DgAniversarioAnimal.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(0).HeaderText = "ID"
        DgAniversarioAnimal.Columns(0).Width = 4
        DgAniversarioAnimal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(1).HeaderText = "Nome do Pet"
        DgAniversarioAnimal.Columns(1).Width = 30
        DgAniversarioAnimal.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(2).HeaderText = "Nome do Tutor"
        DgAniversarioAnimal.Columns(2).Width = 80
        DgAniversarioAnimal.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(3).HeaderText = "Celular"
        DgAniversarioAnimal.Columns(3).Width = 30
        DgAniversarioAnimal.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(4).HeaderText = "Email do Tutor"
        DgAniversarioAnimal.Columns(4).Width = 80
        DgAniversarioAnimal.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(5).HeaderText = "Espéc."
        DgAniversarioAnimal.Columns(5).Width = 6
        DgAniversarioAnimal.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgAniversarioAnimal.Columns(6).HeaderText = "Sexo"
        DgAniversarioAnimal.Columns(6).Width = 6

    End Sub
    Private Sub Le_Vacinas_Mdi()

        Dim dtg As DataTable
        clsPront.Vc_Mes = Format(Now, "MM")
        dtg = clsPront.LeVacinasDoMes
        dgVacinasDoMesOld.DataSource = dtg

        If dtg.Rows.Count.ToString = 0 Then
            pnAniversarios.Visible = False
            Exit Sub
        End If

        dgVacinasDoMesOld.ColumnHeadersHeight = 20

        dgVacinasDoMesOld.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasDoMesOld.Columns(0).HeaderText = "Tipo"
        dgVacinasDoMesOld.Columns(0).Width = 10
        dgVacinasDoMesOld.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasDoMesOld.Columns(1).HeaderText = " Data "
        dgVacinasDoMesOld.Columns(1).Width = 35
        dgVacinasDoMesOld.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasDoMesOld.Columns(2).HeaderText = " Nome do Animal "
        dgVacinasDoMesOld.Columns(2).Width = 35
        dgVacinasDoMesOld.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasDoMesOld.Columns(3).HeaderText = " Nome do Cliente "
        dgVacinasDoMesOld.Columns(3).Width = 80
        dgVacinasDoMesOld.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgVacinasDoMesOld.Columns(4).HeaderText = " Contato "
        dgVacinasDoMesOld.Columns(4).Width = 50
    End Sub
    Private Sub Le_Agenda_Mdi()

        Dim dtg As DataTable
        dtg = clsPront.LeAgenda
        dgAgenda.DataSource = dtg

        'If dtg.Rows.Count.ToString = 0 Then
        '    MessageBox.Show("Agenda sem movimento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    pnAgenda.Visible = False
        '    Exit Sub
        'End If

        dgAgenda.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(0).HeaderText = "ID"
        dgAgenda.Columns(0).Width = 4
        dgAgenda.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(1).HeaderText = " Data "
        dgAgenda.Columns(1).Width = 35
        dgAgenda.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(2).HeaderText = " Hora "
        dgAgenda.Columns(2).Width = 35
        dgAgenda.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(3).HeaderText = " Cliente "
        dgAgenda.Columns(3).Width = 80
        dgAgenda.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(4).HeaderText = " Contato "
        dgAgenda.Columns(4).Width = 45
        dgAgenda.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(5).HeaderText = " ID Pet "
        dgAgenda.Columns(5).Width = 60
        dgAgenda.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(6).HeaderText = "Agendamento "
        dgAgenda.Columns(6).Width = 45
        dgAgenda.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(7).HeaderText = " Observação "
        dgAgenda.Columns(7).Width = 80
        dgAgenda.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(8).HeaderText = " Proficional "
        dgAgenda.Columns(8).Width = 60
        dgAgenda.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(9).HeaderText = "Tipo"
        dgAgenda.Columns(9).Width = 60
        dgAgenda.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(10).HeaderText = "ID_cli"
        dgAgenda.Columns(10).Width = 4

        dgAgenda.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgAgenda.Columns(11).HeaderText = "Ordem"
        dgAgenda.Columns(11).Width = 4

        For Each Row As DataGridViewRow In dgAgenda.Rows
            Row.DefaultCellStyle.Font = New Font("Thaoma", 10, FontStyle.Regular)
            Select Case Trim(Row.Cells(12).Value)
                Case "Atendido"
                    'Row.DefaultCellStyle.BackColor = Color.GreenYellow
                    'Row.DefaultCellStyle.ForeColor = Color.GreenYellow
                Case "Finalizado"
                    'Row.DefaultCellStyle.BackColor = Color.GreenYellow
                    'Row.DefaultCellStyle.ForeColor = Color.GreenYellow
                Case "Cancelado"
                    Row.DefaultCellStyle.BackColor = Color.Gray
                Case "Falta"
                    '' Row.DefaultCellStyle.BackColor = Color.Magenta
                    Row.DefaultCellStyle.ForeColor = Color.Magenta
                Case "Encerrado"
                    ''Row.DefaultCellStyle.BackColor = Color.Purple
                    Row.DefaultCellStyle.ForeColor = Color.Purple
            End Select

            If Row.Cells(13).Value.ToString() > 0 Then
                'le se esta pago
                clsFinan.id_Grid = Row.Cells(13).Value.ToString()
                clsFinan.LeFinan()

                If clsFinan.Fi_VlrPgto = 0 Then
                    Row.DefaultCellStyle.ForeColor = Color.DarkRed
                    Row.DefaultCellStyle.Font = New Font("Thaoma", 10, FontStyle.Bold)
                End If

            End If

            If Row.Cells(9).Value.ToString() = "Banho" Or Row.Cells(9).Value.ToString() = "BANHO" Then

                If Row.Cells(16).Value.ToString() > 1 Then

                    If Row.Cells(15).Value.ToString() = Row.Cells(16).Value.ToString() Then

                        Row.DefaultCellStyle.Font = New Font("Thaoma", 10, FontStyle.Italic)
                        Row.DefaultCellStyle.ForeColor = Color.Navy

                        Timer3.Start()
                        '' Beep()

                    End If

                End If
            End If

        Next

        '' conta os servicos do dia
        dtg = clsPront.BuscaQtdServico
        dtgCount.DataSource = dtg

        dtgCount.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgCount.Columns(0).HeaderText = "Serviço  "
        dtgCount.Columns(0).Width = 35
        dtgCount.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgCount.Columns(1).HeaderText = "Status "
        dtgCount.Columns(1).Width = 45
        dtgCount.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtgCount.Columns(2).HeaderText = "Qtd."
        dtgCount.Columns(2).Width = 5
    End Sub
    Private Sub btoAgenda_Click(sender As Object, e As EventArgs) Handles btoAgenda.Click
        mdVar.md_Data = Format(Now, "dd/MM/yyyy")
        'frmShow(New frmAgenda)

        showSubMenu(Panel1)

    End Sub
    Private Sub MiniBotao()

        btoAgenda.Size = New Size(70, 40)
        btoCaixa.Size = New Size(70, 40)
        btoMateriais.Size = New Size(70, 40)
        btoProntuario.Size = New Size(70, 40)
        btoFi.Size = New Size(70, 40)
        btoUsuario.Size = New Size(70, 40)

        'btoAgenda.Size = New Size(250, 40)
        'btoCaixa.Size = New Size(250, 40)
        'btoMateriais.Size = New Size(250, 40)
        'btoProntuario.Size = New Size(250, 40)
        'btoFi.Size = New Size(250, 40)
        'btoUsuario.Size = New Size(250, 40)

    End Sub
    Private Sub showPanel()
        MiniBotao()
        If pnAgenda.Visible = True Then
            pnAgenda.Visible = False
            pnAniversarios.Visible = False
            pnVacinas.Visible = False

        Else
            pnAgenda.Visible = True
            pnAniversarios.Visible = True
            pnVacinas.Visible = True

        End If
    End Sub
    Private Sub frmM_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub btnPN_Click(sender As Object, e As EventArgs) Handles btnPN.Click
        showPanel()
    End Sub

    Private Sub frmM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        mdVar.md_usuario = lblUsuario.Text
        mdVar.md_usuario_aut = M_Usr_Aut

        If e.KeyChar = ChrW(27) Then
            Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja realmente sair do Sistema??", "Encerramento",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1, 0)

            If StrMsg = 6 Then
                Application.Exit()

            End If

        End If

        'Dim nonNumberEntered As Boolean = False
        'If Control.ModifierKeys = Keys.Control Then
        '    nonNumberEntered = True
        'End If
        '' cadastro da empresa
        If Control.ModifierKeys = Keys.Control And e.KeyChar = ChrW(5) Then
            frmShow(New frmEmpresa())
        End If

        If Control.ModifierKeys = Keys.Control And e.KeyChar = ChrW(22) Then
            frmShow(New frmPDV(mdVar.md_usuario, 0, M_Usr_Func))
        End If

        If Control.ModifierKeys = Keys.Control And e.KeyChar = ChrW(16) Then
            frmShowPr()
        End If
    End Sub

    Private Sub btoCaixa_Click(sender As Object, e As EventArgs) Handles btoCaixa.Click
        showSubMenu(pnCaixaSub2)
    End Sub
    Private Sub hideSubMenu()
        ' pnBtoAg.Visible = False
        Panel1.Visible = False
        pnCaixaSub2.Visible = False
        pnMateriaisSub.Visible = False
        pnFinanceiroSub.Visible = False
        pnProntuarioSub.Visible = False
        pnUsuario.Visible = False
    End Sub
    Private Sub showSubMenu(SubMenu As Panel)
        If SubMenu.Visible = False Then
            hideSubMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub

    Private Sub btoMateriais_Click(sender As Object, e As EventArgs) Handles btoMateriais.Click
        showSubMenu(pnMateriaisSub)
    End Sub

    Private Sub btoProntuario_Click(sender As Object, e As EventArgs) Handles btoProntuario.Click
        showSubMenu(pnProntuarioSub)
    End Sub

    Private Sub btoFi_Click(sender As Object, e As EventArgs) Handles btoFi.Click
        showSubMenu(pnFinanceiroSub)
    End Sub

    Private Sub btoLanFinan_Click(sender As Object, e As EventArgs) Handles btoLanFinan.Click

        AtvSubBotao(pnFinanceiroSub, subBtoLancamentos)
        frmShow(New frmLancaFinan(0, 0, 0, lblUsuario.Text, M_Usr_Aut))
    End Sub
    Private Sub btnCaixaMov_Click(sender As Object, e As EventArgs) Handles btnCaixaMov.Click
        AtvSubBotao(pnCaixaSub2, subBtoMovimento)
        frmShowD(New frmCaixa(lblUsuario.Text, 0, 0, M_Usr_Aut))

    End Sub

    Private Sub btoItens_Click(sender As Object, e As EventArgs) Handles btoItens.Click
        AtvSubBotao(pnFinanceiroSub, subBtoItens)
        frmShow(New FrmItens)
    End Sub

    Private Sub btoImport_Click(sender As Object, e As EventArgs) Handles btoImport.Click
        AtvSubBotao(pnMateriaisSub, subBtoImportacao)
        frmShow(New frmImportXMLntfe)
    End Sub
    Private Sub btoPront_Click(sender As Object, e As EventArgs) Handles btoPront.Click
        'showPanel()

        'If formPront Is Nothing Then
        '    formPront = New frmProntuario

        'ElseIf formPront.IsHandleCreated = False Then
        '    formPront = New frmProntuario

        'Else
        '    formPront.Close()
        '    'formPront.Focus()
        'End If

        ''formPront = New frmProntuario
        ''  formPront.MdiParent = Me
        'formPront.Id_Enviado_Cli = Id_Cliente_Menu
        'formPront.Id_Enviado_Pac = Id_Paciente_Menu

        'formPront.ShowDialog()

        'AtivaBotao(btoPront)

        AtvSubBotao(pnProntuarioSub, subBtoCadastros)

        frmShowPr()

    End Sub
    Private Sub frmShowPr()

        ActiveFormClose()
        Dim Frm As New frmProntuario

        frmAtivo = Frm
        Frm.Usr = lblUsuario.Text
        Frm.UsrAut = M_Usr_Aut
        Frm.Veterinario = M_Usr_Func
        Frm.ShowDialog()

    End Sub
    Private Sub btnABcx_Click(sender As Object, e As EventArgs) Handles btnABcx.Click
        AtvSubBotao(pnCaixaSub2, subBtoAbre)
        frmShow(New frmAbreFechaCx(lblUsuario.Text))

    End Sub

    Private Sub btoFrmFornec_Click(sender As Object, e As EventArgs) Handles btoFrmFornec.Click

        AtvSubBotao(pnMateriaisSub, subBtoFornecedor)
        frmShow(New frmFornecedor)
    End Sub

    Private Sub btoFrmEntrada_Click(sender As Object, e As EventArgs) Handles btoFrmEntrada.Click

        AtvSubBotao(pnMateriaisSub, subBtoEntrada)
        frmShow(New frmEntradaItem)
    End Sub
    Private Sub frmM_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ActiveFormClose()
        EscondeBotao()
        'AtivaBotao(btnPN)
        hideSubMenu()

    End Sub
    Private Sub btoFunc_Click(sender As Object, e As EventArgs) Handles btoFunc.Click

        AtvSubBotao(pnUsuario, subBtoCadFuncionario)
        frmShow(New frmFuncionario)

    End Sub
    Private Sub btoUsuários_Click(sender As Object, e As EventArgs) Handles btoUsuários.Click

        showSubMenu(pnUsuario)

    End Sub
    Private Sub btoRelatorios_Click(sender As Object, e As EventArgs) Handles btoRelatorios.Click

        AtvSubBotao(pnUsuario, subBtoRelatorios)
        frmShow(New frmCrystal)
        'frmShow(New frmRptw)
    End Sub

    Private Sub AtvSubBotao(btAtivo As Panel, BtAt As Button)

        EscondeBotao()

        For Each ctrl As Control In btAtivo.Controls

            If ctrl.Text = BtAt.Text Then
                BtAt.Visible = True
                Exit Sub
            End If

        Next

    End Sub
    Private Sub EscondeBotao()
        'Agenda
        subBtoAgBanho.Visible = False
        subBtoAgCliente.Visible = False
        subBtoAgGeral.Visible = False
        'Caixa
        subBtoAbre.Visible = False
        subBtoMovimento.Visible = False
        Button3.Visible = False
        'Materiais
        subBtoItens.Visible = False
        subBtoImportacao.Visible = False
        subBtoEntrada.Visible = False
        subBtoFornecedor.Visible = False
        'Prontuario
        subBtoCadastros.Visible = False
        'Financeiro
        subBtoContas.Visible = False
        subBtoLancamentos.Visible = False
        subBtopdv.Visible = False
        subBtoFluxos.Visible = False
        subBtoExtratoCliente.Visible = False
        'Sistema
        subBtoRelatorios.Visible = False
        subBtoCadUsuario.Visible = False
        subBtoCadFuncionario.Visible = False
        subBtoSistFat.Visible = False
        subBtoCadPrestador.Visible = False
    End Sub
    Private Sub btoUsuario_Click(sender As Object, e As EventArgs) Handles btoUsuario.Click
        'AtvSubBotao(pnUsuario, subBtoCadUsuario)
        'frmShow(New frmConsulta)
    End Sub
    Private Sub BtoContasPagar_Click(sender As Object, e As EventArgs) Handles BtoContasPagar.Click
        AtvSubBotao(pnFinanceiroSub, subBtoContas)
        Dim Frm As New frmCtaPg
        frmAtivo = Frm
        Frm.ShowDialog()
    End Sub
    Private Sub mcAgenda_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcAgenda.DateChanged
        Timer3.Stop()
        GroupBox1.Visible = True
        Conta_Timer = 0
        clsPront.Ag_Data = mcAgenda.SelectionStart.ToShortDateString
        Le_Agenda_Mdi()

    End Sub
    Private Sub btoAgGeral_Click(sender As Object, e As EventArgs) Handles btoAgGeral.Click
        md_Cpf = 0
        md_ID = 0
        AtvSubBotao(pnBtoAg, subBtoAgGeral)
        frmShow(New frmAgenda)
    End Sub
    Private Sub BtoAgBanho_Click(sender As Object, e As EventArgs) Handles BtoAgBanho.Click
        AtvSubBotao(pnBtoAg, subBtoAgBanho)
        frmShow(New frmAgBanho())
    End Sub
    Private Sub btoAgCliente_Click(sender As Object, e As EventArgs) Handles btoAgCliente.Click
        AtvSubBotao(pnBtoAg, subBtoAgBanho)
        mdVar.md_ID = 0
        mdVar.md_Cpf = 0
        frmShow(New frmAgendaDoCliente)
    End Sub
    Private Sub dgAgenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAgenda.CellContentClick

        'mdVar.md_Data = mcAgenda.SelectionStart.ToShortDateString
        'mdVar.md_Cpf = 0 ' Me.dgAgenda.CurrentRow.Cells(2).Value.ToString()
        'mdVar.md_ID = Me.dgAgenda.CurrentRow.Cells(0).Value.ToString()

        'frmShow(New frmAgenda)
    End Sub


    Private Sub btoPDV_Click(sender As Object, e As EventArgs) Handles btoPDV.Click

        AtvSubBotao(pnFinanceiroSub, subBtopdv)
        mdVar.md_usuario = lblUsuario.Text
        frmShow(New frmPDV(lblUsuario.Text, 0, M_Usr_Func))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AtvSubBotao(pnCaixaSub2, Button3)
        mdVar.md_usuario = lblUsuario.Text
        frmShow(New frmPDV(lblUsuario.Text, 0, M_Usr_Func))
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Le_Agenda_Mdi()
        Le_Medias()
    End Sub
    Private Sub btoExtrato_Click(sender As Object, e As EventArgs) Handles btoExtrato.Click
        AtvSubBotao(pnFinanceiroSub, subBtoExtratoCliente)

        'frmShow(New frmExtratoFinCli)
    End Sub
    Private Sub btoBanhoTosa_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub cmsMenu_Opening(sender As Object, e As CancelEventArgs) Handles cmsMenu.Opening

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        '' BANHO E TOSA
        Dim frm As New frmBT

        frm.Id_Tut = Me.dgAgenda.CurrentRow.Cells(3).Value.ToString()
        frm.lbIdTutor.Text = Me.dgAgenda.CurrentRow.Cells(3).Value.ToString()
        frm.lbNomeTutor.Text = Me.dgAgenda.CurrentRow.Cells(4).Value.ToString()
        frm.lbNomePet.Text = Me.dgAgenda.CurrentRow.Cells(6).Value.ToString()
        frm.lbIdPet.Text = Me.dgAgenda.CurrentRow.Cells(5).Value.ToString()
        frm.Os_Pesq = Me.dgAgenda.CurrentRow.Cells(13).Value.ToString()

        frm.ShowDialog()

    End Sub

    Private Sub ControleDaAgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDaAgendaToolStripMenuItem.Click

        mdVar.md_Data = mcAgenda.SelectionStart.ToShortDateString
        mdVar.md_Cpf = Me.dgAgenda.CurrentRow.Cells(14).Value.ToString()
        mdVar.md_ID = Me.dgAgenda.CurrentRow.Cells(0).Value.ToString()
        mdVar.md_Id_Tutor = Me.dgAgenda.CurrentRow.Cells(3).Value.ToString()
        mdVar.md_Id_Pet = Me.dgAgenda.CurrentRow.Cells(5).Value.ToString()
        mdVar.md_OS = Me.dgAgenda.CurrentRow.Cells(13).Value.ToString()

        frmShow(New frmAgenda)
    End Sub

    Private Sub dgAgenda_MouseLeave(sender As Object, e As EventArgs) Handles dgAgenda.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dgAgenda_MouseHover(sender As Object, e As EventArgs) Handles dgAgenda.MouseHover
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub AgendaDoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaDoClienteToolStripMenuItem.Click
        AtvSubBotao(pnBtoAg, subBtoAgBanho)
        mdVar.md_Cpf = Me.dgAgenda.CurrentRow.Cells(14).Value.ToString()
        mdVar.md_ID = Me.dgAgenda.CurrentRow.Cells(3).Value.ToString()

        frmShow(New frmAgendaDoCliente)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("HH:mm:ss tt")
    End Sub

    Private Sub btoFaturamento_Click(sender As Object, e As EventArgs) Handles btoFaturamento.Click
        AtvSubBotao(pnUsuario, subBtoSistFat)
        frmShow(New frmFaturamentos)
    End Sub

    Private Sub btnFluxos_Click(sender As Object, e As EventArgs) Handles btnFluxos.Click
        AtvSubBotao(pnFinanceiroSub, subBtoFluxos)

        frmShow(New frmFaturamentos)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Conta_Timer += 1
        If GroupBox1.Visible = False Then
            GroupBox1.Visible = True
            '' Me.dgAgenda.CurrentRow.DefaultCellStyle.BackColor = Color.OrangeRed

        Else
            GroupBox1.Visible = False
            Me.dgAgenda.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen

        End If
        If Conta_Timer >= 10 Then
            Timer3.Stop()
            Conta_Timer = 0
            '' Me.dgAgenda.CurrentRow.DefaultCellStyle.BackColor = Color.OrangeRed

        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        ''Aniversario tutor
        Dim NroWhats As String = Me.DgAniversarioHumanos.CurrentRow.Cells(2).Value.ToString()
        Dim Mensagem As String

        NroWhats = Replace(NroWhats, "(", "")
        NroWhats = Replace(NroWhats, ")", "")
        NroWhats = Replace(NroWhats, ".", "")
        NroWhats = Replace(NroWhats, "-", "")
        NroWhats = Replace(NroWhats, " ", "")
        Dim Posicao As Integer
        Posicao = InStr(1, Me.DgAniversarioHumanos.CurrentRow.Cells(1).Value.ToString(), " ", 0)

        Mensagem = "Parabéns! " & "*" & Mid(Me.DgAniversarioHumanos.CurrentRow.Cells(1).Value.ToString(), 1, Posicao) & "*" & vbCrLf _
            & "Que não lhe falte saúde, paz, " & vbCrLf _
            & "alegria e que todos os seus dias" & vbCrLf _
            & "sejam abençoados e cheios de" & vbCrLf _
            & "gratidão! ???? Feliz" & vbCrLf _
            & "Aniversário!!! " & vbCrLf _
            & "*" & clsUtil.emp_fanta & "*"

        Dim frm As New frmWats(Mensagem, NroWhats)
        frm.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        ''Aniversario tutor
        Dim NroWhats As String = Me.DgAniversarioAnimal.CurrentRow.Cells(3).Value.ToString()
        Dim Mensagem As String

        NroWhats = Replace(NroWhats, "(", "")
        NroWhats = Replace(NroWhats, ")", "")
        NroWhats = Replace(NroWhats, ".", "")
        NroWhats = Replace(NroWhats, "-", "")
        NroWhats = Replace(NroWhats, " ", "")
        Dim Posicao As Integer
        Posicao = InStr(1, Me.DgAniversarioAnimal.CurrentRow.Cells(1).Value.ToString(), " ", 0)

        Mensagem = "Sem dúvida " & vbCrLf _
            & "alguma, o  " & vbCrLf _
            & "nosso melhor amigo !!!" & vbCrLf _
            & "que venham mais" & vbCrLf _
            & "muitos anos de" & vbCrLf _
            & "brincadeiras!" & vbCrLf _
            & "PARABÉNS! " & Mid(Me.DgAniversarioAnimal.CurrentRow.Cells(1).Value.ToString(), 1, Posicao) & vbCrLf _
            & vbCrLf _
            & "*" & clsUtil.emp_fanta & "*"

        Dim frm As New frmWats(Mensagem, NroWhats)
        frm.ShowDialog()

    End Sub
    Private Sub AgendaDoPet_Click(sender As Object, e As EventArgs) Handles AgendaDoPet.Click

        mdVar.md_Id_Pet = Me.dgAgenda.CurrentRow.Cells(5).Value.ToString()
        Dim Frm As New frmAgendaDoPet
        frmAtivo = Frm

        Frm.txtIdPet.Text = mdVar.md_Id_Pet
        Frm.ShowDialog()

    End Sub

    Private Sub btoPrestador_Click(sender As Object, e As EventArgs) Handles btoPrestador.Click
        'Dim Frm As New frmPrestador
        'frmAtivo = Frm
        'Frm.ShowDialog()
        AtvSubBotao(pnUsuario, subBtoCadPrestador)
    End Sub

    Private Sub txtDadosEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtDadosEmpresa.TextChanged

    End Sub

    Private Sub txtFantasia_TextChanged(sender As Object, e As EventArgs) Handles txtFantasia.TextChanged

    End Sub
End Class