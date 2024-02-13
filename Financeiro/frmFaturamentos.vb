Imports DataBase
Imports System.Windows.Forms
Imports System.Drawing
Public Class frmFaturamentos

    Private Sub frmFaturamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Text = ""
        Dim clsF As New Cls_Financeiro
        Dim dtF As DataTable = clsF.PreencheCbo("Sp_ResumoCx_Sel")
        cboBusca.DisplayMember = "RDESC"
        cboBusca.ValueMember = "RiD"
        cboBusca.DataSource = dtF

    End Sub

    Private Sub Calendario_LostFocus(sender As Object, e As EventArgs)



    End Sub

    Private Sub cboBusca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBusca.SelectedIndexChanged
        Try
            dgFinanceiro.RowHeadersVisible = True

            Dim fin As New Cls_Financeiro

        Dim dt As DataTable
        Dim d1 As Date = Now
        Dim d2 As Date = Now
        Dim SldFat As Double
        Dim SldRec As Double
        Dim SldTotal As Double
        Dim Qtd As Integer

            '' SALDO ESTOQUE
            If cboBusca.SelectedValue = 2 Then
                Dim MAT As New Cls_Materiais
                dt = MAT.Busca_DataTable("Sp_Saldo_Estoque")

                dgFinanceiro.DataSource = dt

                dgFinanceiro.Columns(0).HeaderText = "Grupo"
                dgFinanceiro.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(0).Width = 100
                ''   dgFinanceiro.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(1).HeaderText = "Cod. do Item "
                dgFinanceiro.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(1).Width = 100
                '' dgFinanceiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(2).HeaderText = "Descrição do Item"
                dgFinanceiro.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgFinanceiro.Columns(2).Width = 250
                ''dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(3).HeaderText = "Saldo"
                dgFinanceiro.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(3).Width = 100
                ' dgFinanceiro.Columns(3).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End If

            '' POR PERIODO
            If cboBusca.SelectedValue = 4 Then
                dt = fin.Busca_Fat_Per(dtp_De.Value, dtp_Ate.Value)
                dgFinanceiro.DataSource = dt

                '''formata o datagrid


                dgFinanceiro.Columns(0).HeaderText = "Data"
                dgFinanceiro.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(0).Width = 100
                dgFinanceiro.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(1).HeaderText = "Data Pagto. "
                dgFinanceiro.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(1).Width = 100
                dgFinanceiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(2).HeaderText = "Cliente"
                dgFinanceiro.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgFinanceiro.Columns(2).Width = 250
                dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(3).HeaderText = "$ Faturado"
                dgFinanceiro.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(3).Width = 100
                dgFinanceiro.Columns(3).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgFinanceiro.Columns(4).HeaderText = "$$ Faturado"
                dgFinanceiro.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(4).Width = 100
                dgFinanceiro.Columns(4).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgFinanceiro.Columns(5).HeaderText = "$ Recebido"
                dgFinanceiro.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(5).Width = 100
                dgFinanceiro.Columns(5).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgFinanceiro.Columns(6).HeaderText = "$$ Receita"
                dgFinanceiro.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(6).Width = 100
                dgFinanceiro.Columns(6).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                'percorre as linhas do grid
                For Each Row As DataGridViewRow In dgFinanceiro.Rows

                    ' Converte a célula da coluna para Double (usa CDbl ao estilo VB6 ...)
                    SldFat = CDbl(SldFat) + CDbl(Row.Cells(3).Value)
                    Row.Cells(4).Value = SldFat

                    SldRec = CDbl(SldRec) + CDbl(Row.Cells(5).Value)
                    Row.Cells(6).Value = SldRec

                    If Row.Cells(1).Value = "01/01/1900" Then

                        Row.DefaultCellStyle.BackColor = Color.Tomato
                        Row.Cells(1).Value = ""

                    End If

                    If Row.Cells(1).Value > Row.Cells(0).Value Then

                        Row.DefaultCellStyle.BackColor = Color.GreenYellow

                    End If


                Next


            End If

            '' faturamento POR GRUPO
            If cboBusca.SelectedValue = 3 Then

                dt = fin.Busca_Fat_Por_Grupo(dtp_De.Value, dtp_Ate.Value)

                dgFinanceiro.DataSource = dt
                dgFinanceiro.Columns(0).HeaderText = "Grupo"
                dgFinanceiro.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(0).Width = 120
                dgFinanceiro.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(1).HeaderText = "Descrição do Item "
                dgFinanceiro.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(1).Width = 350
                dgFinanceiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(2).HeaderText = "Qtd."
                dgFinanceiro.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgFinanceiro.Columns(2).Width = 50
                dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgFinanceiro.Columns(3).HeaderText = "$ Faturado"
                dgFinanceiro.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(3).Width = 100
                dgFinanceiro.Columns(3).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgFinanceiro.Columns(4).HeaderText = "+ Qtd."
                dgFinanceiro.Columns(4).Width = 50
                dgFinanceiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgFinanceiro.Columns(5).HeaderText = "+ Faturado"
                dgFinanceiro.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(5).Width = 100
                dgFinanceiro.Columns(5).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgFinanceiro.Columns(6).HeaderText = "Total Fat."
                dgFinanceiro.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(6).Width = 100
                dgFinanceiro.Columns(6).DefaultCellStyle.Format = "C2"
                dgFinanceiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                SldFat = 0
                Qtd = 0
                SldTotal = 0
                Dim Grp As String
                For Each Row As DataGridViewRow In dgFinanceiro.Rows

                    If Grp <> "" And Grp <> Row.Cells(0).Value Then
                        ' dgFinanceiro.Rows.Add(" ", "Totais do Grupo", 0, 0)
                        'Row.Cells(3).Value = SldFat
                        'Row.Cells(2).Value = Qtd
                        SldFat = 0
                        Qtd = 0
                    End If

                    ' Converte a célula da coluna para Double (usa CDbl ao estilo VB6 ...)
                    SldTotal = CDbl(SldTotal) + CDbl(Row.Cells(3).Value)
                    Row.Cells(6).Value = SldTotal

                    SldFat = CDbl(SldFat) + CDbl(Row.Cells(3).Value)
                    Row.Cells(5).Value = SldFat

                    Qtd += CDbl(Row.Cells(2).Value)
                    Row.Cells(4).Value = Qtd

                    Grp = Row.Cells(0).Value

                Next


            End If

            '' BANHOS ATIVOS
            If cboBusca.SelectedValue = 6 Then
            dt = fin.Busca_Banhos_Ativos(dtp_De.Value, dtp_Ate.Value)
            dgFinanceiro.DataSource = dt
            dgFinanceiro.Columns(0).HeaderText = "Cliente"
            dgFinanceiro.Columns(0).Width = 250
            dgFinanceiro.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgFinanceiro.Columns(1).HeaderText = "Pet "
            dgFinanceiro.Columns(1).Width = 100
            dgFinanceiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgFinanceiro.Columns(2).HeaderText = "OS"
            dgFinanceiro.Columns(2).Width = 50
            dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgFinanceiro.Columns(3).HeaderText = "Qtd."
            dgFinanceiro.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgFinanceiro.Columns(3).Width = 40
            dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgFinanceiro.Columns(4).HeaderText = "Data"
            dgFinanceiro.Columns(4).Width = 100
            dgFinanceiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Qtd = 1
            SldTotal = 0
            Dim Nss As Integer
            Dim X1 As Integer
            'percorre as linhas do grid
            For i As Byte = 0 To dgFinanceiro.RowCount - 1

                SldTotal += 1

                If Nss = dgFinanceiro.Rows(i).Cells(2).Value Then
                    Nss = dgFinanceiro.Rows(i).Cells(2).Value
                    dgFinanceiro.Rows(i).Cells(0).Value = ""
                    dgFinanceiro.Rows(i).Cells(1).Value = ""
                    dgFinanceiro.Rows(i).Cells(2).Value = 0
                    dgFinanceiro.Rows(i).Cells(3).Value = 0
                Else
                    dgFinanceiro.Rows(X1).Cells(3).Value = Qtd
                    X1 = i
                    Nss = dgFinanceiro.Rows(i).Cells(2).Value
                    Qtd = 0
                End If

                If SldTotal = dgFinanceiro.Rows.Count Then
                    ''                    Label3.Text = "Total de Banhos não efetuados = " & SldTotal
                    dgFinanceiro.Rows(i).Cells(0).Value = "TOTAL"
                    dgFinanceiro.Rows(i).Cells(3).Value = SldTotal
                End If

                ' dgFinanceiro.Rows(X1).Cells(3).Value = Qtd
                Qtd += 1

            Next

        End If

        '' fluxo de caixa reduzido
        If cboBusca.SelectedValue = 5 Then
            Dim FlxFin As New Cls_Financeiro
            dt = FlxFin.LeFlxRed("Sp_Flx_Red", dtp_De.Value, dtp_Ate.Value)

            dgFinanceiro.DataSource = dt

            dgFinanceiro.Columns(0).HeaderText = "Evento"
            dgFinanceiro.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgFinanceiro.Columns(0).Width = 100
            dgFinanceiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(1).HeaderText = "Caixa"
            dgFinanceiro.Columns(1).Width = 100
            dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(2).HeaderText = "Conta"
            dgFinanceiro.Columns(2).Width = 100
            dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(3).HeaderText = "Descricao da Conta"
            dgFinanceiro.Columns(3).Width = 200
            dgFinanceiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(4).HeaderText = "Receita\Desp"
            dgFinanceiro.Columns(4).Width = 100
            dgFinanceiro.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(5).HeaderText = "Recebido\Pago"
            dgFinanceiro.Columns(5).Width = 100
            dgFinanceiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(6).HeaderText = "A Receber\Nao Pg"
            dgFinanceiro.Columns(6).Width = 100
            dgFinanceiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'percorre as linhas do grid
            For Each Row As DataGridViewRow In dgFinanceiro.Rows


                If Row.Cells(1).Value = "Entrada" Then
                    Row.Cells(4).Style.BackColor = Color.DeepSkyBlue

                Else
                    Row.DefaultCellStyle.BackColor = Color.GreenYellow

                End If

            Next


        End If

            ''''FUNCIONARIO
            '''
            If cboBusca.SelectedValue = 7 Then

            Dim FlxFin As New Cls_Financeiro
            dt = FlxFin.LeFlxRed("Sp_Flx_Func", dtp_De.Value, dtp_Ate.Value)
            dgFinanceiro.DataSource = dt

                dgFinanceiro.RowHeadersVisible = False

                dgFinanceiro.Columns(0).HeaderText = "Funcionario"
            dgFinanceiro.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgFinanceiro.Columns(0).Width = 120

                dgFinanceiro.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(1).HeaderText = "Data"
            dgFinanceiro.Columns(1).Width = 70
            dgFinanceiro.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy"

            dgFinanceiro.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(2).HeaderText = "OS"
            dgFinanceiro.Columns(2).Width = 40

            dgFinanceiro.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(3).HeaderText = "Descricao"
            dgFinanceiro.Columns(3).Width = 200

            dgFinanceiro.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(4).HeaderText = "Qtd"
            dgFinanceiro.Columns(4).Width = 30
            ''dgFinanceiro.Columns(4).DefaultCellStyle.Format = "N3"

            dgFinanceiro.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(5).HeaderText = "Vlr. Unit."
            dgFinanceiro.Columns(5).Width = 80
            dgFinanceiro.Columns(5).DefaultCellStyle.Format = "c"
            dgFinanceiro.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(6).HeaderText = "Vlr. Dcto."
            dgFinanceiro.Columns(6).Width = 80
            dgFinanceiro.Columns(6).DefaultCellStyle.Format = "c"
            dgFinanceiro.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(7).HeaderText = "Vlr. Tot."
            dgFinanceiro.Columns(7).Width = 100
            dgFinanceiro.Columns(7).DefaultCellStyle.Format = "c"

            dgFinanceiro.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(8).HeaderText = "Tot. Func."
            dgFinanceiro.Columns(8).Width = 100
            dgFinanceiro.Columns(8).DefaultCellStyle.Format = "c"

            ''dgFinanceiro.Columns.Add("Total Geral", "total")
            dgFinanceiro.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgFinanceiro.Columns(9).HeaderText = "Total Geral"
            dgFinanceiro.Columns(9).Width = 100
            dgFinanceiro.Columns(9).DefaultCellStyle.Format = "c"

            'percorre as linhas do grid
            SldFat = 0
            Qtd = 0
            SldTotal = 0
                Dim Func As String

                'For Each Row As DataGridViewRow In dgFinanceiro.Rows
                '    If Func <> "" And Func <> Row.Cells(0).Value Then
                '        Row.Cells(7).Style.BackColor = Color.DeepSkyBlue
                '        SldFat = 0
                '    End If
                '    ' Converte a célula da coluna para Double (usa CDbl ao estilo VB6 ...)
                '    SldFat = CDbl(SldFat) + CDbl(Row.Cells(7).Value)
                '    SldTotal = CDbl(SldTotal) + CDbl(Row.Cells(7).Value)
                '    Row.Cells(8).Value = SldFat
                '    Row.Cells(9).Value = SldTotal
                '    Func = Row.Cells(0).Value
                'Next
                For i = 0 To (dgFinanceiro.Rows.Count - 1)
                    ''BOM.dgv1.Rows(j).Cells(0).Value
                    If Func <> "" And Func <> dgFinanceiro.Rows(i).Cells(0).Value Then
                        dgFinanceiro.Rows(i - 1).DefaultCellStyle.BackColor = Color.GreenYellow
                        '' dgFinanceiro.Rows(i - 1).Cells(8).Style.BackColor = Color.GreenYellow
                        SldFat = 0
                    End If
                    ' Converte a célula da coluna para Double (usa CDbl ao estilo VB6 ...)
                    SldFat = CDbl(SldFat) + CDbl(dgFinanceiro.Rows(i).Cells(7).Value)
                    SldTotal = CDbl(SldTotal) + CDbl(dgFinanceiro.Rows(i).Cells(7).Value)
                    dgFinanceiro.Rows(i).Cells(8).Value = SldFat
                    dgFinanceiro.Rows(i).Cells(9).Value = SldTotal

                    Func = dgFinanceiro.Rows(i).Cells(0).Value
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class