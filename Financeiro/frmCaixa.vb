Imports System.Drawing
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports DataBase
'Imports CrystalDecisions.Shared

Public Class frmCaixa
    Private ClsFinan As New Cls_Financeiro
    Private ClsGer As New Utils
    Private ClsPrint As New Cls_Prontuario
    Private cliente As New Cls_Cliente
    Private Total_Aberto As Double = 0
    Private Aut_Usr As Integer
    Public Sub New(ByVal NomeDoCaixa As String, CodCliente As Integer, os As Integer, Aut As Integer)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        txtNomeDoCaixa.Text = NomeDoCaixa
        lbCodcli.Text = CodCliente
        txtNssNro.Text = os
        Aut_Usr = Aut
    End Sub

    Private Sub AtualizaDados()

        lbTotalDeb.Text = ""
        If lbCodcli.Text > 0 Then
            cliente.BuscaCliente("Sp_Cliente_Sel", lbCodcli.Text)
            lbNomeCli.Text = cliente.Cl_Nome

            Dim dt As DataTable
            ''Le o financeiro do cliente em aberto
            dt = cliente.BuscaFinCliAberto(lbCodcli.Text)
            dgCaixa.DataSource = dt

            dgCaixa.Columns(0).HeaderText = "Ck"
            dgCaixa.Columns(0).Width = 25

            dgCaixa.Columns(1).HeaderText = "Situação"
            dgCaixa.Columns(1).Width = 65
            dgCaixa.Columns(2).HeaderText = "Id.Ani"
            dgCaixa.Columns(2).Width = 50
            dgCaixa.Columns(3).HeaderText = "Nome do Animal"
            dgCaixa.Columns(3).Width = 150
            dgCaixa.Columns(4).HeaderText = "Vlr. Dcto."
            dgCaixa.Columns(4).Width = 68
            dgCaixa.Columns(5).HeaderText = "Valor "
            dgCaixa.Columns(5).Width = 68
            dgCaixa.Columns(5).DefaultCellStyle.Format = "C2"
            dgCaixa.Columns(6).HeaderText = "Adiant "
            dgCaixa.Columns(6).Width = 68
            dgCaixa.Columns(6).DefaultCellStyle.Format = "C2"
            dgCaixa.Columns(7).HeaderText = "OS"
            dgCaixa.Columns(7).Width = 50

            'percorre as linhas do grid
            If dgCaixa.RowCount > 0 Then
                For i As Byte = 0 To dgCaixa.RowCount - 1

                    ' Converte a célula da coluna 5 para Double (usa CDbl ao estilo VB6 ...)
                    Total_Aberto = CDbl(Total_Aberto) + CDbl(dgCaixa.Rows(i).Cells(5).Value)
                Next

            End If
            '//formata e exibe o valor da soma

            Total_Aberto = Format(CDbl(Total_Aberto), "#,##0.00")
            lbTotalDeb.Text = Total_Aberto

            'AddLinha()
            ''' le saldo devedor
            lbTotalDeb.Text = cliente.LeSaldoDev(lbCodcli.Text)

            Exit Sub
        End If


        LimpaVar()
        mskDtCx.Text = Now

        If ClsFinan.id_Grid > 0 Then

            txtNssNro.Text = ClsFinan.id_Grid

            ClsFinan.LeFinan()

            If ClsFinan.Fi_VlrPgto > 0 Then
                LimpaVar()
                MessageBox.Show("Baixa já efetuada.", "Nota importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
            Else
                MoveVarCx()

                cliente.Id_Animal = ClsFinan.Fi_Ani
                cliente.BuscaPaciente()

                cliente.Cl_Id = ClsFinan.Fi_Cli
                cliente.BuscaCliente("Sp_Cliente_Sel", ClsFinan.Fi_Cli)

                cboFPagto.Focus()
                txtVBaixa.Text = ClsFinan.Fi_Vlr.ToString("0.00")
                txtVFat.Text = ClsFinan.Fi_Vlr.ToString("0.00")
            End If

            Dim dt As DataTable
            ''Le o analitico do lançamento
            dt = ClsFinan.LeFinA
            dgDetLan.DataSource = dt
            FormataDetalhe()
        Else
            ClsFinan.Dt_Pesq = Format(mskDtCx.SelectionStart, "dd/MM/yyyy")
            Dim dt As DataTable
            dt = ClsFinan.FinanDoDia("Sp_FinS_Caixa_Dia")
            dgCaixa.DataSource = dt
            ClsFinan.dt_Base = Format(mskDtCx.SelectionStart, "dd/MM/yyyy")
            FormataDgw()

        End If

        ClsFinan.NssNro = 0
    End Sub
    Private Sub frmCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ClsFinan.RecalCx()

        Me.Location = New Point(40, 93)
        Me.Size = New Size(1190, 700)

        Me.Text = "Nome do Caixa : " & txtNomeDoCaixa.Text
        AtualizaDados()

        If txtNssNro.Text > 0 Then
            ClsFinan.Fi_Cli = lbCodcli.Text
            LeOS()
            cboFPagto.Focus()
        End If

        If Aut_Usr >= 10 Then
            btoExcluir.Enabled = True
        Else
            btoExcluir.Enabled = False
        End If

    End Sub
    Private Sub MoveVarCx()
        LbCodAni.Text = ClsFinan.Fi_Ani
        LbNomeAni.Text = ClsFinan.Fi_NomeAni
        lbCodcli.Text = ClsFinan.Fi_Cli
        lbNomeCli.Text = ClsFinan.Fi_NomeCli
        txtNssNro.Text = ClsFinan.Fi_NssNro
        txtVFat.Text = ClsFinan.Fi_Vlr.ToString("0.00")
        txtVAdiant.Text = ClsFinan.Fi_VlrAd
        txtVBaixa.Text = ClsFinan.Fi_Vlr.ToString("0.00")

    End Sub
    Private Sub LimpaVar()
        txtNssNro.Text = 0
        txtVFat.Text = 0
        txtVAdiant.Text = 0
        'txtVBaixa.Text = 0
        lbCodcli.Text = ""
        lbNomeCli.Text = ""
        LbCodAni.Text = ""
        LbNomeAni.Text = ""
        txtDescDesp.Text = ""
        txtVlrDesp.Text = ""
    End Sub
    Private Sub dgCaixa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCaixa.CellContentClick

        Dim valor As Double
        For i As Integer = 0 To dgCaixa.RowCount - 1
            Dim c As Boolean
            c = dgCaixa.Rows(i).Cells(0).Value
            If c = True Then
                valor += Convert.ToDecimal(dgCaixa.Rows(i).Cells(3).Value)

            End If

        Next

    End Sub
    Private Sub txtVDinheiro_Leave(sender As Object, e As EventArgs) Handles txtVDinheiro.Leave
        Calc_Troco()
    End Sub
    Private Sub MoveVar()
        ClsFinan.Fi_NssNro = txtNssNro.Text
        ClsFinan.Fi_DtPgto = Now

        Dim diaDoAno As Integer = Now.DayOfYear
        ClsFinan.Fi_Lote = Format(Now, "yy") & diaDoAno

        ClsFinan.Fi_VlrPgto = txtVBaixa.Text

        Dim ACRE As Double
        ACRE = Convert.ToDouble(txtVBaixa.Text) - Convert.ToDouble(txtVFat.Text)
        If ACRE > 0 Then
            ClsFinan.Fi_VlrAcre = ACRE
            ClsFinan.Fi_VlrDcto = 0
        Else
            ClsFinan.Fi_VlrAcre = 0
            ClsFinan.Fi_VlrDcto = ACRE
        End If

        ClsFinan.Fi_BcoCh = ""
        ClsFinan.Fi_AgCh = ""
        ClsFinan.Fi_Cta = ""
        ClsFinan.Fi_NroCh = ""
        ClsFinan.Fi_Emitente = ""
        ClsFinan.Fi_ChPre = 0
        ClsFinan.Fi_Cartao = ""

        ClsFinan.Fi_Caixa = txtNomeDoCaixa.Text
        ClsFinan.Fi_DevCh = ""
        ClsFinan.Fi_NroCar = 0
        ClsFinan.Fi_DtVCtr = 0

        ClsFinan.Fi_CodBar = ""
        ClsFinan.Fi_LinDig = ""
        ClsFinan.Fi_Emi = 0
        ClsFinan.Fi_DtLan = Now
        ClsFinan.Fi_Emp = 1
        ClsFinan.Fi_Custo = 1
        ClsFinan.Fi_Obs = ""
        ClsFinan.FI_LancImp = 0
        ClsFinan.Fi_ChAnt = 0
        ClsFinan.Fi_Conv = 1
        ClsFinan.Fi_ConvReq = 0
        ClsFinan.Fi_NF = 0
        ClsFinan.Fi_Ordem = 0 'NSSNRO
        ClsFinan.Fi_Ev = 0 'VAGO
        ClsFinan.Fi_Fat = 1 'ORCAMENTO
        ClsFinan.Fi_VlrImp = 0 'VAGO
        ClsFinan.Fi_FPagto = cboFPagto.Text

        ClsFinan.Mv_VlrSai = 0

    End Sub
    Private Sub btoBaixa_Click(sender As Object, e As EventArgs) Handles btoBaixa.Click
        ClsFinan.id_Grid = txtNssNro.Text
        ClsFinan.LeFinan()

        If ClsFinan.Fi_VlrPgto > 0 Then

            MessageBox.Show("Baixa já efetuada.", "Nota importante",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1)

            Exit Sub
        End If

        If txtNssNro.Text = "" Or txtVBaixa.Text = 0 Then
            MessageBox.Show("Registro não informado.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            dgCaixa.Focus()
            Exit Sub
        End If
        If txtVBaixa.Text = "" Or txtVBaixa.Text = 0 Then
            MessageBox.Show("Sem valor comercial.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtVBaixa.Focus()
            Exit Sub
        End If
        If cboFPagto.Text = "" Then
            MessageBox.Show("Forma de pagamento não informada.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cboFPagto.Focus()
            Exit Sub
        End If

        Try


            MoveVar()
            ClsFinan.ExecutaBaixa()


            Dim pergunta As DialogResult = MessageBox.Show("Baixa efetuada com sucesso." & vbCr & vbCr & "Deseja emitir a Nota Fiscal ?? ", "Nota importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            If pergunta = DialogResult.Yes Then

                ClsFinan.Fa_NssNro = txtNssNro.Text
                Dim NtF As New cls_NTFeS
                NtF.NTFe_Cliente = lbCodcli.Text
                NtF.NTFe_Paciente = LbCodAni.Text
                NtF.NTFe_NssNro = txtNssNro.Text

                NtF.Emitir_NTFSe()
                MessageBox.Show("Nota Emitida. " & vbCr & "Verifique o retorno.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                Dim cryRpt As New ReportDocument
                cryRpt.Load("C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryCupom.rpt")
                cryRpt.SetDatabaseLogon("sa", "nunsey", "SrvMyPets", "CadVet")
                cryRpt.ParameterFields("NSSNRO").CurrentValues.AddValue(Convert.ToInt32(txtNssNro.Text))

                Dim frm As New frmImpressao
                frm.crwImp.ReportSource = cryRpt
                frm.crwImp.Refresh()
                ''     frm.ShowDialog()

            End If

            Dim clsMat As New Cls_Materiais
            clsMat.Busca_Banho_da_Os(txtNssNro.Text)

            If clsMat.IT_GRUPO = 3 And clsMat.Fi_VlrPgto > 0 Then
                MessageBox.Show("OS com grupo Banho " & vbCr & "Verifique o Agendamento.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Dim nss As Integer = txtNssNro.Text
                Dim frm As New frmAgBanho()
                frm.txtOs.Text = txtNssNro.Text
                frm.ShowDialog()
                Me.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        AtualizaDados()

    End Sub
    Private Sub Calc_Troco()
        Try
            Dim dinheiro As Double
            Dim baixa As Double
            Dim adianta As Double
            Dim faturado As Double
            Dim acre As Double
            Dim dcto As Double

            Double.TryParse(txtVFat.Text, faturado)
            Double.TryParse(txtVDinheiro.Text, dinheiro)
            Double.TryParse(txtVAdiant.Text, adianta)
            Double.TryParse(txtVBaixa.Text, baixa)

            txtVTroco.Text = 0
            If dinheiro > 0 Then
                txtVTroco.Text = Format((dinheiro - baixa), "0.00")
                txtVAdiant.Text = 0
            End If
            If adianta > 0 Then
                txtVTroco.Text = Format((adianta - baixa), "0.00")
                txtVDinheiro.Text = 0
            End If
            If txtVTroco.Text > 0 Then
                txtVTroco.ForeColor = Color.Red
            Else
                txtVTroco.Text = 0
                txtVTroco.ForeColor = Color.Black
            End If

            If baixa < faturado Then
                dcto = faturado - baixa
                acre = 0
            End If
            If baixa > faturado Then
                acre = baixa - faturado
                dcto = 0
            End If
            txtVAcr.Text = Format(acre, "0.00")
            txtVDcto.Text = Format(dcto, "0.00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtVDinheiro_TextChanged(sender As Object, e As EventArgs) Handles txtVDinheiro.TextChanged

        Calc_Troco()

    End Sub
    Private Sub cboFPagto_Enter(sender As Object, e As EventArgs) Handles cboFPagto.Enter
        '' cboFPagto.DroppedDown = True
    End Sub

    Private Sub btoExtorno_Click(sender As Object, e As EventArgs) Handles btoExtorno.Click
        Try

            txtVBaixa.Text = 0
            cboFPagto.Text = "Estorno"

            MoveVar()

            ClsFinan.Fi_VlrDcto = 0
            ClsFinan.Fi_VlrAcre = 0
            ClsFinan.NssNro = txtNssNro.Text
            ClsFinan.ExtornoCx()
            AtualizaDados()

            MsgBox("Estorno efetuado com sucesso.", vbOK, vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmCaixa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
            e.SuppressKeyPress = True
        End If

    End Sub
    Private Sub cboFPagto_Click(sender As Object, e As EventArgs) Handles cboFPagto.Click
        ''SendKeys.Send("{tab}")
    End Sub
    Private Sub mskDtCx_MouseClick(sender As Object, e As MouseEventArgs)
        ClsFinan.Dt_Pesq = Format(mskDtCx.SelectionStart, "dd/MM/yyyy")
        Dim dt As DataTable
        dt = ClsFinan.FinanDoDia("Sp_FinS_Caixa")
        dgCaixa.DataSource = dt
        ClsFinan.dt_Base = Format(mskDtCx.SelectionStart, "dd/MM/yyyy")

    End Sub

    Private Sub btnIncluirDesp_Click(sender As Object, e As EventArgs) Handles btnIncluirDesp.Click
        Try
            ClsFinan.GravaNssNro()
            txtNssNro.Text = ClsFinan.NssNro
            MoveVar()
            ClsFinan.Fi_Vlr = txtVlrDesp.Text * -1
            ClsFinan.Fi_VlrPgto = txtVlrDesp.Text * -1
            ClsFinan.Mv_NssNro = ClsFinan.NssNro
            ClsFinan.Mv_Data = Now
            ClsFinan.Mv_VlrEnt = 0
            ClsFinan.Mv_VlrSai = txtVlrDesp.Text * -1
            ClsFinan.Mv_Custo = 1
            ClsFinan.MV_Caixa = txtNomeDoCaixa.Text 'ClsGer.usr_Nome
            ClsFinan.MV_Desc = txtDescDesp.Text
            ClsFinan.Fi_FPagto = txtDescDesp.Text
            ClsFinan.IncluirCx()

            MessageBox.Show("Inclusão de Despesa efetuada com sucesso.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ClsFinan.RecalCx()

            LimpaVar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboFPagto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFPagto.SelectedIndexChanged
        txtVAdiant.Text = 0
        txtVDinheiro.Text = 0
        txtVTroco.Text = 0
        If cboFPagto.SelectedIndex.ToString() = 0 Then
            txtVAdiant.Enabled = True
            txtVDinheiro.Enabled = True
            txtVTroco.Enabled = True
        Else
            txtVAdiant.Enabled = False
            txtVDinheiro.Enabled = False
            txtVTroco.Enabled = False
        End If
    End Sub

    Private Sub txtVBaixa_GotFocus(sender As Object, e As EventArgs) Handles txtVBaixa.GotFocus
        txtVBaixa.SelectAll()
    End Sub

    Private Sub LeOS()
        ClsFinan.id_Grid = txtNssNro.Text
        Dim r As Boolean
        r = ClsFinan.LeFinan()

        If r = False Then
            MessageBox.Show("Registro Financeiro não encontrado.", "Nota importante",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1)
            Exit Sub

        End If

        cliente.Id_Animal = ClsFinan.Fi_Ani

        MoveVarCx()

        cliente.BuscaPaciente()

        LbNomeAni.Text = Trim(cliente.Ani_Nome)

        cliente.BuscaCliente("Sp_Cliente_Sel", ClsFinan.Fi_Cli)
        lbCodcli.Text = cliente.Cl_Id
        lbNomeCli.Text = Trim(cliente.Cl_Nome)

        txtVBaixa.Text = ClsFinan.Fi_Vlr.ToString("0.00")
        txtVFat.Text = ClsFinan.Fi_Vlr.ToString("0.00")

        Dim dt As DataTable
        ''Le o analitico do lançamento
        dt = ClsFinan.LeFinA
        dgDetLan.DataSource = dt
        FormataDetalhe()
    End Sub
    Private Sub txtNssNro_LostFocus(sender As Object, e As EventArgs) Handles txtNssNro.LostFocus

        If IsNumeric(txtNssNro.Text) = True Then
            LeOS()
            cboFPagto.Focus()
        Else
            ClsFinan.NssNro = 0
        End If

    End Sub

    Private Sub txtNssNro_GotFocus(sender As Object, e As EventArgs) Handles txtNssNro.GotFocus

        txtNssNro.SelectAll()

    End Sub

    Private Sub txtVBaixa_TextChanged(sender As Object, e As EventArgs) Handles txtVBaixa.TextChanged
        If Len(Trim(txtVAdiant.Text)) = 0 Then
            txtVAdiant.Text = 0
        End If
        If Len(Trim(txtVDinheiro.Text)) = 0 Then
            txtVDinheiro.Text = 0
        End If

        Calc_Troco()

    End Sub

    Private Sub txtVAdiant_TextChanged(sender As Object, e As EventArgs) Handles txtVAdiant.TextChanged

        If Len(Trim(txtVAdiant.Text)) = 0 Then
            txtVAdiant.Text = 0
        End If
        If Len(Trim(txtVDinheiro.Text)) = 0 Then
            txtVDinheiro.Text = 0
        End If

        Calc_Troco()

    End Sub

    Private Sub txtVAdiant_GotFocus(sender As Object, e As EventArgs) Handles txtVAdiant.GotFocus
        If txtVDinheiro.Text > 0 Then
            txtVDinheiro.Text = 0
        End If
        txtVAdiant.SelectAll()
    End Sub

    Private Sub txtVDinheiro_GotFocus(sender As Object, e As EventArgs) Handles txtVDinheiro.GotFocus
        txtVDinheiro.SelectAll()

    End Sub

    Private Sub mskDtCx_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mskDtCx.DateChanged
        btoBaixa.Enabled = True
        ClsFinan.Dt_Pesq = mskDtCx.SelectionStart

        Dim dt As DataTable
        dt = ClsFinan.FinanDoDia("Sp_FinS_Caixa")
        dgCaixa.DataSource = dt
        ClsFinan.dt_Base = Format(mskDtCx.SelectionStart, "dd/MM/yyyy")

        FormataDgw()
    End Sub

    Private Sub btoFechar_Click(sender As Object, e As EventArgs)
        Dim recal As New DataAcces
        recal.RecalculoCx()
    End Sub
    Private Sub FormataDgw()
        dgCaixa.Columns(0).HeaderText = "Ck"
        dgCaixa.Columns(0).Width = 25

        '   dgCaixa.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixa.Columns(1).HeaderText = "Data Pagto."
        dgCaixa.Columns(1).Width = 75
        ' dgCaixa.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixa.Columns(2).HeaderText = "Nome"
        dgCaixa.Columns(2).Width = 250
        '    dgCaixa.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixa.Columns(3).HeaderText = "Valor Fat."
        dgCaixa.Columns(3).Width = 68
        dgCaixa.Columns(3).DefaultCellStyle.Format = "C2"
        dgCaixa.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '  dgCaixa.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixa.Columns(4).HeaderText = "Vlr.Dcto."
        dgCaixa.Columns(4).Width = 60
        dgCaixa.Columns(4).DefaultCellStyle.Format = "C2"
        '  dgCaixa.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixa.Columns(5).HeaderText = "Vlr.Acrésc."
        dgCaixa.Columns(5).Width = 68
        dgCaixa.Columns(5).DefaultCellStyle.Format = "C2"
        dgCaixa.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgCaixa.Columns(6).HeaderText = "Vlr. Pagto."
        dgCaixa.Columns(6).Width = 68
        dgCaixa.Columns(6).DefaultCellStyle.Format = "C2"
        dgCaixa.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgCaixa.Columns(7).HeaderText = "OS"
        dgCaixa.Columns(7).Width = 40

        dgCaixa.Columns(8).HeaderText = "Data Fat."
        dgCaixa.Columns(8).Width = 65

        Dim valorFat As Decimal = 0
        Dim valorAtrasados As Decimal = 0
        Dim valorAberto As Decimal = 0
        Dim valorAcres As Decimal = 0
        Dim valorDcto As Decimal = 0
        Dim valorPago As Decimal = 0

        For Each Row As DataGridViewRow In dgCaixa.Rows
            If Row.Cells(0).Value <> Row.Cells(8).Value Then
                valorAtrasados = valorAtrasados + Convert.ToDecimal(Row.Cells(3).Value)
            Else
                valorFat = valorFat + Convert.ToDecimal(Row.Cells(3).Value)
            End If

            If Convert.ToDecimal(Row.Cells(3).Value) > 0 Then
                valorDcto += Convert.ToDecimal(Row.Cells(4).Value)
            End If
            If Convert.ToDecimal(Row.Cells(6).Value) > 0 Then
                valorPago += Convert.ToDecimal(Row.Cells(6).Value)
                valorAcres += Convert.ToDecimal(Row.Cells(5).Value) ''Convert.ToDecimal(Row.Cells(5).Value) - Convert.ToDecimal(Row.Cells(3).Value)
                Row.DefaultCellStyle.BackColor = Color.GreenYellow
            Else
                valorAberto += Convert.ToDecimal(Row.Cells(3).Value)
                Row.DefaultCellStyle.BackColor = Color.PaleVioletRed
            End If

        Next

        txtFaturado.Text = Format(valorFat, "0.00")
        txtAtrasados.Text = Format(valorAtrasados, "0.00")
        txtPagos.Text = Format(valorPago, "0.00")
        txtDcto.Text = Format(valorDcto, "0.00")
        txtAbertos.Text = Format(valorAberto, "0.00")
        txtAcre.Text = Format(valorAcres, "0.00")
        txtSaldo.Text = Format(((valorFat + valorAtrasados + valorAcres) - (valorDcto + valorAberto)), "0.00")

    End Sub

    Private Sub btoExcluir_Click(sender As Object, e As EventArgs) Handles btoExcluir.Click
        Try

            Dim pergunta As DialogResult = MessageBox.Show(Trim(txtNomeDoCaixa.Text) & ", você realmente deseja excluir definitivamente este Registro ?? .", "Nota importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            If pergunta = DialogResult.Yes Then

                ClsFinan.DeleteFiNssNro(txtNssNro.Text)

                MessageBox.Show("Exclusão efetuada.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgCaixa_Click(sender As Object, e As EventArgs) Handles dgCaixa.Click
        btoBaixa.Enabled = True
        ClsFinan.id_Grid = dgCaixa.CurrentRow.Cells(7).Value.ToString()
        ClsFinan.LeFinan()
        LimpaVar()
        MoveVarCx()
        If ClsFinan.Fi_VlrPgto > 0 Then
            txtVBaixa.Text = ClsFinan.Fi_VlrPgto.ToString("0.00")
            MessageBox.Show("Baixa já efetuada.", "Nota importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
            btoBaixa.Enabled = False
        Else
            'cboFPagto.Focus()
            'cboFPagto.Select()
        End If
        My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\ping.wav")
        Dim dt As DataTable
        ''Le o analitico do lançamento
        dt = ClsFinan.LeFinA
        dgDetLan.DataSource = dt

        FormataDetalhe()

    End Sub
    Private Sub FormataDetalhe()

        dgDetLan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDetLan.Columns(0).HeaderText = "Descrição"
        dgDetLan.Columns(0).Width = 600

        dgDetLan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDetLan.Columns(1).HeaderText = "Qtd."
        dgDetLan.Columns(1).Width = 20
        dgDetLan.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDetLan.Columns(2).HeaderText = "Vlr.Unit."
        dgDetLan.Columns(2).Width = 80
        dgDetLan.Columns(2).DefaultCellStyle.Format = "c"

        dgDetLan.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDetLan.Columns(3).HeaderText = "Total"
        dgDetLan.Columns(3).Width = 80
        dgDetLan.Columns(3).DefaultCellStyle.Format = "c"
        dgDetLan.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgDetLan.Columns(4).HeaderText = "Dcto."
        dgDetLan.Columns(4).Width = 80
        dgDetLan.Columns(4).DefaultCellStyle.Format = "c"
    End Sub

    Private Sub dgCaixa_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles dgCaixa.CellContextMenuStripNeeded

    End Sub

    Private Sub txtNssNro_TextChanged(sender As Object, e As EventArgs) Handles txtNssNro.TextChanged

    End Sub

    Private Sub txtVFat_TextChanged(sender As Object, e As EventArgs) Handles txtVFat.TextChanged

    End Sub
End Class