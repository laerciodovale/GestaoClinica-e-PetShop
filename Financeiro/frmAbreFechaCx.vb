Imports System.Drawing
Imports System.Windows.Forms
Imports DataBase
Public Class frmAbreFechaCx
    Private clsFinan As New Cls_Financeiro
    Private clsUtil As New Utils
    Private DtPesq As Date
    Public Sub New(ByVal NomeDoCaixa As String)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        txtNomeDoCaixa.Text = NomeDoCaixa

    End Sub
    Private Sub Ler_Caixa()
        Dim valorFat As Decimal = 0
        Dim valorAtrasados As Decimal = 0
        Dim valorAberto As Decimal = 0
        Dim valorAcres As Decimal = 0
        Dim valorDcto As Decimal = 0
        Dim valorPago As Decimal = 0

        clsFinan.Dt_Pesq = DtPesq
        Dim dt As DataTable
        dt = clsFinan.FinanDoDia("Sp_FinS_Caixa")
        dgCaixa.DataSource = dt

        If dt.Rows.Count > 0 Then

            clsFinan.dt_Base = DtPesq
            Try

                'dgCaixa.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgCaixa.Columns(0).HeaderText = "Data Fat."
                dgCaixa.Columns(0).Width = 65
                ' dgCaixa.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgCaixa.Columns(1).HeaderText = "Nome"
                dgCaixa.Columns(1).Width = 150
                '    dgCaixa.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgCaixa.Columns(2).HeaderText = "Valor Fat."
                dgCaixa.Columns(2).Width = 67
                dgCaixa.Columns(2).DefaultCellStyle.Format = "C2"
                '  dgCaixa.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgCaixa.Columns(3).HeaderText = "Vlr. Dcto."
                dgCaixa.Columns(3).Width = 67
                dgCaixa.Columns(3).DefaultCellStyle.Format = "C2"

                dgCaixa.Columns(4).HeaderText = "Vlr. Acresc."
                dgCaixa.Columns(4).Width = 67
                dgCaixa.Columns(4).DefaultCellStyle.Format = "C2"
                '  dgCaixa.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgCaixa.Columns(5).HeaderText = "Vlr. Pagto."
                dgCaixa.Columns(5).Width = 65
                dgCaixa.Columns(5).DefaultCellStyle.Format = "C2"
                '    dgCaixa.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgCaixa.Columns(6).HeaderText = "OS"
                dgCaixa.Columns(6).Width = 40

                dgCaixa.Columns(7).HeaderText = "Data Pagto."
                dgCaixa.Columns(7).Width = 72

                dgCaixa.Columns(8).HeaderText = "Forma de Pagto."
                dgCaixa.Columns(8).Width = 82


                For Each Row As DataGridViewRow In dgCaixa.Rows

                    If Row.Cells(0).Value <> Row.Cells(7).Value Then
                        valorAtrasados = valorAtrasados + Convert.ToDecimal(Row.Cells(5).Value)
                    Else
                        valorFat = valorFat + Convert.ToDecimal(Row.Cells(2).Value)
                    End If

                    If Convert.ToDecimal(Row.Cells(3).Value) > 0 Then
                        valorDcto += Convert.ToDecimal(Row.Cells(3).Value)
                    End If

                    If Convert.ToDecimal(Row.Cells(4).Value) > 0 Then
                        valorPago += Convert.ToDecimal(Row.Cells(4).Value)
                        valorAcres += Convert.ToDecimal(Row.Cells(4).Value) - Convert.ToDecimal(Row.Cells(2).Value)

                        Row.DefaultCellStyle.BackColor = Color.SlateBlue
                    Else
                        ''      valorAberto += Convert.ToDecimal(Row.Cells(2).Value)
                    End If

                    If Row.Cells(7).Value > DtPesq Then
                        Row.DefaultCellStyle.BackColor = Color.GreenYellow
                    ElseIf Row.Cells(0).Value < Row.Cells(7).Value Then
                        Row.DefaultCellStyle.BackColor = Color.Orange
                    End If
                    If Row.Cells(7).Value = "01/01/1900" Then
                        Row.Cells(7).Value = ""
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Ocoreu um erro ao formatar os dados. " & ex.Message, "Aviso." & vbCr & "Abertura de caixa ainda não efetuada.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End Try
        End If


        ''        txtAberto.Text = Format(valorAberto, "0.00")
        txtAtrasados.Text = Format(valorAtrasados, "0.00")

        Le_OutrosFat()
        '
        txtFaturado.Text = Convert.ToDouble(txtSubTot.Text) + Convert.ToDouble(txtAberto.Text)

        ''txtFaturado.Text = Format(valorFat, "0.00")
        ''txtPagos.Text = Format(valorPago, "0.00")
        ''txtDcto.Text = Format(valorDcto, "0.00")

        ''txtAcre.Text = Format(valorAcres, "0.00")
        ''txtSaldo.Text = Format(((valorFat + valorAtrasados + valorAcres) - (valorDcto + valorAberto)), "0.00")

    End Sub
    Private Sub Le_OutrosFat()

        '''' @@@@@ faturamento fora do pagamento do caixa

        clsFinan.Dt_Pesq = DtPesq
        Dim EmAberto As Double

        Dim dt As DataTable
        dt = clsFinan.FinanDoDia("Sp_FinS_Caixa_F")
        dgCaixaFat.DataSource = dt

        If dt.Rows.Count > 0 Then

            clsFinan.dt_Base = DtPesq
            Try

                dgCaixaFat.Columns(0).HeaderText = "Data Fat."
                dgCaixaFat.Columns(0).Width = 65
                dgCaixaFat.Columns(1).HeaderText = "Nome"
                dgCaixaFat.Columns(1).Width = 200
                dgCaixaFat.Columns(2).HeaderText = "Valor Fat."
                dgCaixaFat.Columns(2).Width = 68
                dgCaixaFat.Columns(2).DefaultCellStyle.Format = "C2"
                dgCaixaFat.Columns(3).HeaderText = "Vlr. Dcto."
                dgCaixaFat.Columns(3).Width = 68
                dgCaixaFat.Columns(3).DefaultCellStyle.Format = "C2"
                dgCaixaFat.Columns(4).HeaderText = "Vlr. Acresc."
                dgCaixaFat.Columns(4).Width = 68
                dgCaixaFat.Columns(4).DefaultCellStyle.Format = "C2"
                dgCaixaFat.Columns(5).HeaderText = "Vlr. Pagto."
                dgCaixaFat.Columns(5).Width = 50
                dgCaixaFat.Columns(6).HeaderText = "OS"
                dgCaixaFat.Columns(6).Width = 82
                dgCaixaFat.Columns(7).HeaderText = "" '' "Dt. Pagto."
                dgCaixaFat.Columns(7).Width = 1
                dgCaixaFat.Columns(8).HeaderText = "" ''"Forma Pagto."
                dgCaixaFat.Columns(8).Width = 1

                Dim valorFat As Decimal = 0
                Dim valorAtrasados As Decimal = 0
                Dim valorAberto As Decimal = 0
                Dim valorAcres As Decimal = 0
                Dim valorDcto As Decimal = 0
                Dim valorPago As Decimal = 0

                For Each Row As DataGridViewRow In dgCaixaFat.Rows
                    If Row.Cells(0).Value <> Row.Cells(7).Value Then
                        valorAtrasados = valorAtrasados + Convert.ToDecimal(Row.Cells(5).Value)
                    Else
                        valorFat = valorFat + Convert.ToDecimal(Row.Cells(2).Value)
                    End If

                    If Convert.ToDecimal(Row.Cells(3).Value) > 0 Then
                        valorDcto += Convert.ToDecimal(Row.Cells(3).Value)
                    End If

                    If Convert.ToDecimal(Row.Cells(4).Value) > 0 Then
                        valorPago += Convert.ToDecimal(Row.Cells(4).Value)
                        valorAcres += Convert.ToDecimal(Row.Cells(4).Value) - Convert.ToDecimal(Row.Cells(2).Value)

                        Row.DefaultCellStyle.BackColor = Color.SlateBlue
                    Else
                        valorAberto += Convert.ToDecimal(Row.Cells(2).Value)
                    End If

                    If Row.Cells(7).Value > DtPesq Then
                        Row.DefaultCellStyle.BackColor = Color.GreenYellow
                        EmAberto = EmAberto + Convert.ToDecimal(Row.Cells(2).Value)
                    ElseIf Row.Cells(0).Value < Row.Cells(7).Value Then
                        Row.DefaultCellStyle.BackColor = Color.Orange
                    End If

                    If Row.Cells(7).Value = "01/01/1900" Then
                        Row.Cells(7).Value = ""
                        EmAberto = EmAberto + Convert.ToDecimal(Row.Cells(2).Value)

                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Ocoreu um erro ao formatar os dados. " & ex.Message, "Aviso." & vbCr & "Abertura de caixa ainda não efetuada.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End Try
        End If


        txtAberto.Text = EmAberto

    End Sub

    Private Sub txtEnabledFalse()
        txtSangria.Enabled = False
        txtFundo.Enabled = False
        txtAVista.Enabled = False
        txtPIX.Enabled = False
        txtCDeb.Enabled = False
        txtCCred.Enabled = False
        txtCCx2.Enabled = False
        txtCCx3.Enabled = False
        txtCCx4.Enabled = False
        txtOutros.Enabled = False
        'btoFechar.Enabled = False
        btoFundo.Enabled = False
        btoEncerrar.Enabled = False
        btoSangria.Enabled = False
    End Sub
    Private Sub MoveValores()
        btoAbrir.Enabled = True
        btoFundo.Enabled = True
        btoEncerrar.Enabled = True
        btoSangria.Enabled = True

        txtAbertura.Text = Format(clsFinan.cx_Abertura, "0.00")
        txtFundo.Text = Format(clsFinan.cx_Fundo, "0.00")
        txtFundo.Enabled = True
        txtSangria.Text = Format(clsFinan.cx_Sangria, "0.00")
        txtSangria.Enabled = True
        txtAVista.Text = clsFinan.cx_Dinheiro
        txtPIX.Text = clsFinan.cx_PIX
        txtCDeb.Text = clsFinan.cx_CartaoDeb
        txtCCx3.Text = clsFinan.cx_Cartao
        txtAberto.Text = Format(clsFinan.cx_Aberto, "0.00")
        txtAtrasados.Text = Format(clsFinan.cx_Atrasados, "0.00")

    End Sub
    Private Sub ZeraVar()
        txtAbertura.Text = 0
        txtSangria.Text = 0
        txtFundo.Text = 0
        txtAVista.Text = 0
        txtPIX.Text = 0
        txtCDeb.Text = 0
        txtCCred.Text = 0
        txtCCx2.Text = 0
        txtCCx3.Text = 0
        txtCCx4.Text = 0
        txtOutros.Text = 0
        txtAberto.Text = 0
        txtAtrasados.Text = 0
        txtSubTot.Text = 0
        txtFisio.Text = 0
    End Sub
    Private Sub frmAbreFechaCx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ZeraVar()
        DtPesq = Now

        DateTimePicker1.Value = Now

    End Sub
    Private Sub Atualiza()
        ''Le o analitico do caixa
        Dim dt As DataTable
        dt = clsFinan.LeCx(txtNomeDoCaixa.Text, DtPesq)
        dgCaixaAB.DataSource = dt

        Dim dts As DataTable
        dts = clsFinan.LeSaidas(txtNomeDoCaixa.Text)
        dgSaidas.DataSource = dts

        ZeraVar()

        txtFisio.Text = Format(clsFinan.VlrFisio, "0.00")

        If clsFinan.cx_Id = 0 Then
            txtEnabledFalse()
            '       ' MessageBox.Show("Abertura ainda não efetuada.", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''    Else
        End If
        FormataDgAB()
        MoveValores()
        Le_Pivot()

        clsFinan.LeAtrasados(Format(DtPesq, "yyyy-MM-dd"))
        txtAtrasados.Text = Format(clsFinan.sld_Atrasados, "0.00")

    End Sub
    Private Sub Le_Pivot()

        clsFinan.LePivotFP(Format(DtPesq, "yyyy-MM-dd"))
        lblID.Text = clsFinan.cx_Id
        txtAVista.Text = Format(clsFinan.sld_AVista, "0.00")
        txtPIX.Text = Format(clsFinan.sld_Pix, "0.00")
        txtCDeb.Text = Format(clsFinan.sld_CDeb, "0.00")

        txtCCred.Text = Format(clsFinan.sld_CCred, "0.00")
        txtCCx2.Text = Format(clsFinan.sld_CCred2, "0.00")
        txtCCx3.Text = Format(clsFinan.sld_CCred3, "0.00")
        txtCCx4.Text = Format(clsFinan.sld_CCred4, "0.00")

        txtOutros.Text = Format(clsFinan.sld_Outros, "0.00")
        Dim Total_do_Dia As Double
        Total_do_Dia = Convert.ToDouble(txtAVista.Text) +
                                Convert.ToDouble(txtPIX.Text) +
                Convert.ToDouble(txtCDeb.Text) +
                Convert.ToDouble(txtCCred.Text) +
                Convert.ToDouble(txtCCx2.Text) +
                Convert.ToDouble(txtCCx3.Text) +
                Convert.ToDouble(txtCCx4.Text) +
                Convert.ToDouble(txtOutros.Text)
        txtSubTot.Text = Format(Total_do_Dia, "0.00")

        txtAberto.Text = clsFinan.cx_Aberto
        txtAtrasados.Text = clsFinan.cx_Atrasados

    End Sub
    Private Sub MovePadrao()
        'cx_Id
        clsFinan.cx_Data = DtPesq
        clsFinan.cx_Usuario = txtNomeDoCaixa.Text

        clsFinan.cx_Abertura = Convert.ToDouble(txtAbertura.Text)
        clsFinan.cx_Sangria = txtSangria.Text
        clsFinan.cx_Fundo = Convert.ToDouble(txtFundo.Text)

        clsFinan.cx_Fechado = False
        clsFinan.cx_Receita = 0
        clsFinan.cx_Saida = 0
        clsFinan.cx_SaldoDia = 0
        clsFinan.cx_Dinheiro = 0
        clsFinan.cx_PIX = 0
        clsFinan.cx_CartaoDeb = 0
        clsFinan.cx_Cartao = 0
        clsFinan.cx_Emp = 1
        clsFinan.cx_Custo = 1
        clsFinan.cx_Aberto = 0
        clsFinan.cx_Atrasados = 0


    End Sub
    Private Sub btoAbrir_Click(sender As Object, e As EventArgs) Handles btoAbrir.Click
        Try
            'ZeraVar()
            MovePadrao()
            clsFinan.Tipo_Operacao = "I"
            clsFinan.cx_Abertura = txtAbertura.Text
            Dim retorno As Integer
            retorno = clsFinan.AbreCx()
            If retorno = 0 Then
                ZeraVar()

                MessageBox.Show("Abertura com problemas.", "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lblID.Text = retorno
                Dim dt As DataTable
                dt = clsFinan.LeCx(txtNomeDoCaixa.Text, DtPesq)
                dgCaixaAB.DataSource = dt
                FormataDgAB()
                MoveValores()
                Atualiza()
                Ler_Caixa()

                MessageBox.Show("Abertura efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btoSangria_Click(sender As Object, e As EventArgs) Handles btoSangria.Click
        Try
            MovePadrao()
            If Convert.ToDouble(txtSangria.Text) < 0 Then
                txtSangria.Text = Convert.ToDouble(txtSangria.Text) * -1
            End If

            clsFinan.Tipo_Operacao = "I"
            clsFinan.cx_Abertura = 0 ' Convert.ToDouble(txtAbertura.Text)
            clsFinan.cx_Sangria = txtSangria.Text

            Dim retorno As Boolean
            retorno = clsFinan.AbreCx()
            If retorno = False Then
                MessageBox.Show("Ocorreu um erro na Sangria.", "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dt As DataTable
                dt = clsFinan.LeCx(txtNomeDoCaixa.Text, DtPesq)
                dgCaixaAB.DataSource = dt
                FormataDgAB()

                MoveValores()
                Atualiza()
                MessageBox.Show("Sangria efetuada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btoFundo_Click(sender As Object, e As EventArgs) Handles btoFundo.Click
        Try
            MovePadrao()

            clsFinan.Tipo_Operacao = "I"
            clsFinan.cx_Abertura = 0
            clsFinan.cx_Sangria = 0
            clsFinan.cx_Fundo = Convert.ToDouble(txtFundo.Text)

            Dim retorno As Boolean
            retorno = clsFinan.AbreCx()
            If retorno = False Then
                MessageBox.Show("Ocorreu um problema ao incluir o Fundo.", "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dt As DataTable
                dt = clsFinan.LeCx(txtNomeDoCaixa.Text, DtPesq)
                dgCaixaAB.DataSource = dt
                FormataDgAB()
                MoveValores()
                Atualiza()
                MessageBox.Show("Fundo efetuado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FormataDgAB()
        dgCaixaAB.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixaAB.Columns(0).HeaderText = "FX"
        dgCaixaAB.Columns(0).Width = 4
        dgCaixaAB.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixaAB.Columns(1).HeaderText = " Abertura "
        dgCaixaAB.Columns(1).Width = 45
        dgCaixaAB.Columns(1).DefaultCellStyle.Format = "C2"
        dgCaixaAB.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixaAB.Columns(2).HeaderText = " Sangria "
        dgCaixaAB.Columns(2).Width = 45
        dgCaixaAB.Columns(2).DefaultCellStyle.Format = "C2"
        dgCaixaAB.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCaixaAB.Columns(3).HeaderText = " Fundo "
        dgCaixaAB.Columns(3).Width = 45
        dgCaixaAB.Columns(3).DefaultCellStyle.Format = "C2"

        dgSaidas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgSaidas.Columns(0).HeaderText = "Descrição"
        dgSaidas.Columns(0).Width = 55
        dgSaidas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgSaidas.Columns(1).HeaderText = "Valor"
        dgSaidas.Columns(1).Width = 45
        dgSaidas.Columns(1).DefaultCellStyle.Format = "C2"


        Dim valorTotal As Decimal = 0

        For Each col As DataGridViewRow In dgSaidas.Rows
            If col.Cells(1).Value = 0 Then
                col.Cells(1).Value = ""
            End If
            If col.Cells(2).Value = 0 Then
                col.Cells(2).Value = ""
            End If
            If col.Cells(3).Value = 0 Then
                col.Cells(3).Value = ""
            End If

            valorTotal = valorTotal + Convert.ToDecimal(col.Cells(1).Value)

        Next
        txtTotSaida.Text = Format(valorTotal, "0.00")

    End Sub

    Private Sub btoEncerrar_Click(sender As Object, e As EventArgs) Handles btoEncerrar.Click
        Try
            If lblID.Text = 0 Then
                MessageBox.Show("Ocorreu um problema ao Encerrar o caixa." & vbCrLf & "ID de registro não encontrado.", "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            MovePadrao()

            clsFinan.Tipo_Operacao = "U"
            clsFinan.cx_Id = lblID.Text
            clsFinan.cx_Abertura = Convert.ToDouble(txtAbertura.Text)
            clsFinan.cx_Sangria = Convert.ToDouble(txtSangria.Text)
            clsFinan.cx_Fundo = Convert.ToDouble(txtFundo.Text)

            clsFinan.cx_Fechado = True
            clsFinan.cx_Receita = Convert.ToDouble(txtSubTot.Text)
            clsFinan.cx_Saida = Convert.ToDouble(txtTotSaida.Text)
            clsFinan.cx_SaldoDia = Convert.ToDouble(txtSubTot.Text) + Convert.ToDouble(txtTotSaida.Text)
            clsFinan.cx_Dinheiro = Convert.ToDouble(txtAVista.Text)
            clsFinan.cx_PIX = Convert.ToDouble(txtPIX.Text)
            clsFinan.cx_CartaoDeb = Convert.ToDouble(txtCDeb.Text)

            clsFinan.cx_Cartao = Convert.ToDouble(txtCCred.Text) +
                Convert.ToDouble(txtCCx2.Text) +
                Convert.ToDouble(txtCCx3.Text) +
                Convert.ToDouble(txtCCx4.Text) +
                Convert.ToDouble(txtOutros.Text)

            ''clsFinan.cx_outros = Convert.ToDouble(txtOutros.Text)
            clsFinan.cx_Emp = 1
            clsFinan.cx_Custo = 1

            clsFinan.cx_Aberto = Convert.ToDouble(txtAberto.Text)
            clsFinan.cx_Atrasados = Convert.ToDouble(txtAtrasados.Text)

            Dim dtb As New DataAcces
            Dim retorno As Integer
            retorno = clsFinan.AbreCx()

            If retorno = 0 Then
                MessageBox.Show("Ocorreu um problema ao Encerrar o caixa.", "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dt As DataTable
                dt = clsFinan.LeCx(txtNomeDoCaixa.Text, DtPesq)
                dgCaixaAB.DataSource = dt
                FormataDgAB()
                MoveValores()

                Atualiza()
                MessageBox.Show("Caixa encerrado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocorrência de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Text = "" Then
            'MessageBox.Show("The selected value is " +
            ' DateTimePicker1.Text)

            'MessageBox.Show("The day of the week is " +
            'DateTimePicker1.Value.DayOfWeek.ToString())

            'MessageBox.Show("Millisecond is: " +
            'DateTimePicker1.Value.Millisecond.ToString())btoEncerrar
        Else
            MovePadrao()

            DtPesq = DateTimePicker1.Value
            Atualiza()
            Ler_Caixa()
        End If


    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGeral_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtFaturado_TextChanged(sender As Object, e As EventArgs) Handles txtFaturado.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DateTimePicker1_Click(sender As Object, e As EventArgs) Handles DateTimePicker1.Click
        If DateTimePicker1.Text <> "" Then

            MovePadrao()

            DtPesq = DateTimePicker1.Value
            Atualiza()
            Ler_Caixa()
        End If


    End Sub
End Class