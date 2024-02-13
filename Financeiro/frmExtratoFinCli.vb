Imports DataBase
Imports System.Windows.Forms
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmExtratoFinCli
    Private ClsFinan As Cls_Financeiro
    Private Sub FormataDgw()
        Try


            '   dgFinanceiro.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgFinanceiro.Columns(0).HeaderText = "Nome do Pet"
            dgFinanceiro.Columns(0).Width = 160
            ' dgFinanceiro.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgFinanceiro.Columns(1).HeaderText = "OS"
            dgFinanceiro.Columns(1).Width = 50
            '    dgFinanceiro.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgFinanceiro.Columns(2).HeaderText = "Dt. Fatura"
            dgFinanceiro.Columns(2).Width = 80
            dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'dgFinanceiro.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            dgFinanceiro.Columns(3).HeaderText = "Dt. Pagto."
            dgFinanceiro.Columns(3).Width = 80
            dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgFinanceiro.Columns(4).HeaderText = "$ Faturado"
            dgFinanceiro.Columns(4).Width = 90
            dgFinanceiro.Columns(4).DefaultCellStyle.Format = "C2"
            dgFinanceiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgFinanceiro.Columns(5).HeaderText = "$ Adiantado"
            dgFinanceiro.Columns(5).Width = 90
            dgFinanceiro.Columns(5).DefaultCellStyle.Format = "C2"
            dgFinanceiro.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgFinanceiro.Columns(6).HeaderText = "$ Dcto"
            dgFinanceiro.Columns(6).Width = 90
            dgFinanceiro.Columns(6).DefaultCellStyle.Format = "C2"
            dgFinanceiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgFinanceiro.Columns(7).HeaderText = "$ Pago "
            dgFinanceiro.Columns(7).Width = 90
            dgFinanceiro.Columns(7).DefaultCellStyle.Format = "C2"
            dgFinanceiro.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgFinanceiro.Columns(8).HeaderText = "$ Acréscimo "
            dgFinanceiro.Columns(8).Width = 90
            dgFinanceiro.Columns(8).DefaultCellStyle.Format = "C2"
            dgFinanceiro.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgFinanceiro.Columns(9).HeaderText = "$ Saldo ."
            dgFinanceiro.Columns(9).Width = 100
            dgFinanceiro.Columns(9).DefaultCellStyle.Format = "C2"
            dgFinanceiro.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            Dim valorFat As Decimal = 0
            Dim valorTotal As Decimal = 0
            Dim valorPago As Decimal = 0
            Dim Saldo As Decimal = 0
            ' Dim Debito As Decimal = 0
            For Each Row As DataGridViewRow In dgFinanceiro.Rows

                valorFat += (Convert.ToDecimal(Row.Cells(4).Value) - Convert.ToDecimal(Row.Cells(5).Value))

                If Row.Cells(7).Value = 0 Then
                    '    Debito += Convert.ToDecimal(Row.Cells(4).Value)
                    Row.DefaultCellStyle.BackColor = Color.SlateBlue
                    Row.Cells(3).Value = ""
                    ''Row.Cells(5).Value = 0
                Else
                    valorPago += (Convert.ToDecimal(Row.Cells(7).Value) - Convert.ToDecimal(Row.Cells(6).Value))

                End If

                Saldo = (valorPago - valorFat) '- Debito
                Row.Cells(9).Value = Saldo

            Next

            txtFaturado.Text = Format(valorFat, "0.00")
            txtPago.Text = Format(valorPago, "0.00")
            txtSaldo.Text = Format((valorFat - valorPago), "0.00")

            If txtSaldo.Text > 0 Then

                txtSaldo.ForeColor = Color.Red

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmExtratoFinCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If lbId.Text > 0 Then
                Dim cli As New Cls_Cliente
                cli.BuscaCliente("Sp_Cliente_Sel", lbId.Text)
                lbNome.Text = cli.Cl_Nome

                Dim fin As New Cls_Financeiro
                fin.Fi_Cli = lbId.Text
                Dim dt As DataTable
                dt = fin.LeExtratoCli()
                dgFinanceiro.DataSource = dt

                FormataDgw()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btoImprimir_Click(sender As Object, e As EventArgs) Handles btoImprimir.Click
        Try


            Dim cryRpt As New ReportDocument
            Dim frm As New frmImpressao


            cryRpt.Load("C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryExtratoCli.rpt")
            cryRpt.SetDatabaseLogon("sa", "nunsey", "SrvMyPets", "CadVet")
            cryRpt.ParameterFields("CodCli").CurrentValues.AddValue(Convert.ToInt32(lbId.Text))

            frm.crwImp.ReportSource = cryRpt
            '   frm.crwImp.Refresh()
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class