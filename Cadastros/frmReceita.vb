Imports System.Drawing
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DataBase

Public Class frmReceita
    Private clsPront As New Cls_Prontuario
    Public Property Receita_ID_Paciente As Integer
    Public Property Receita_ID_Cliente As Integer
    Private Sub ConfigDataGrid()
        With dgReceita
            '    'define propriedades do datagridview
            '    .RowHeadersVisible = False
            '    .AllowUserToAddRows = False
            '    .AllowUserToDeleteRows = False
            '    .AllowUserToResizeRows = False
            '    .MultiSelect = False
            '    .ReadOnly = False

            '    ' Colunas
            '.Columns.Add("cK", "Ck")                         '// Col = 0
            '.Columns.Add("ProdutoID", "Cod. Farmaco")                      '// Col = 1
            '.Columns.Add("Receita", "Recomendação")                         '// Col = 2
            '.Columns.Add("ID", "ID")                         '// Col = 3

            '    ' Auto resize em todas as colunas.
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8)
            '.Columns(0).FillWeight = 100

            '    ' Coluna Total - soment leitura
            '    'With .Columns("Total")
            '    '.ReadOnly = True
            '    ' .DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow
            '    ' .DefaultCellStyle.ForeColor = System.Drawing.Color.Red
            '    ' .DefaultCellStyle.Font = New Font(dgReceita.Font, FontStyle.Bold)
            '    'End With
            '    ' Estilo do cabeçalho
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White

                .Font = New Font("Tahoma", 8)
                .Font = New Font(dgReceita.Font, FontStyle.Bold)
            End With

            '    ' Alinha somente as colunas 3 a 5
            'For i As Byte = 1 To 2
            '    ' Alinha Cabeçalho
            '    .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '    '    Alinha Celula
            '    .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'Next

            'Dim colunmCkeckBox As New DataGridViewCheckBoxColumn
            'colunmCkeckBox.HeaderText = "Chek"
            'colunmCkeckBox.Name = "Chek"
            '.Columns.AddRange(colunmCkeckBox)

            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(0).HeaderText = "Esp"
            .Columns(0).Width = 10

            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(1).HeaderText = " Farmaco               "
            .Columns(1).Width = 20
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(2).HeaderText = " Recomendações               "
            .Columns(2).Width = 25
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns(3).HeaderText = " id   "
            .Columns(3).Width = 15

        End With

    End Sub

    Private Sub frmReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnImpirmir.Enabled = False
    End Sub

    Private Sub frmReceita_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ckEspecial.Checked = False

        '  ConfigDataGrid()

        clsPront.Rc_Ani = Receita_ID_Paciente
        If clsPront.Rc_Ani = 0 Then
            MessageBox.Show("Código do animal não informado.", "Nota importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
        Else
            ''Preenche A ListBox
            Dim dt As DataTable = clsPront.LeReceitaAv()

            lstReceitasAv.DisplayMember = "RCDT"
            lstReceitasAv.ValueMember = "RCnss"
            lstReceitasAv.DataSource = dt
        End If

    End Sub

    Private Sub lstReceitasAv_Click(sender As Object, e As EventArgs) Handles lstReceitasAv.Click
        ''Preenche A Receita
        clsPront.Rc_Nss = lstReceitasAv.SelectedValue
        txtIdReceita.Text = clsPront.Rc_Nss
        clsPront.Rc_Ani = Receita_ID_Paciente

        Dim dt As DataTable
        dt = clsPront.BuscaReceita
        dgReceita.DataSource = dt

        ckEspecial.Checked = Me.dgReceita.CurrentRow.Cells(0).Value.ToString()
        ConfigDataGrid()

        btnImpirmir.Enabled = True

    End Sub

    Private Sub txtFarmaco_TextChanged(sender As Object, e As EventArgs) Handles txtFarmaco.TextChanged
        clsPront.Nome_Like = txtFarmaco.Text

        ''Preenche A ListBox
        Dim dt As DataTable = clsPront.LeFarmaco()
        lstFarmacos.DisplayMember = "RcDescFarmaco"
        lstFarmacos.ValueMember = "RcDescFarmaco"
        lstFarmacos.DataSource = dt

    End Sub
    Private Sub lstFarmacos_Click(sender As Object, e As EventArgs) Handles lstFarmacos.Click
        txtFarmaco.Text = Trim(lstFarmacos.Text)
        txtFarmaco.Focus()
    End Sub
    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click
        Try
            Dim uT As New Utils
            uT.InsertNssNro()

            For i As Integer = 0 To dgReceita.Rows.Count - 1
                If dgReceita.Rows(i).Cells(1).Value IsNot Nothing Then
                    clsPront.TipoOperacao = "I"
                    clsPront.Rc_Farmaco = ""
                    clsPront.Rc_DescFarmaco = dgReceita.Rows(i).Cells(1).Value.ToString()
                    clsPront.Rc_Ani = Receita_ID_Paciente
                    clsPront.Rc_Cli = Receita_ID_Cliente
                    clsPront.Rc_Dt = Now
                    clsPront.Rc_Nss = uT.Id_Nss_Nro
                    ' Os_Impressao = clsPront.Rc_Nss
                    clsPront.Rc_Meio = ""
                    clsPront.Rc_Qtd = 1
                    clsPront.Rc_Via = 1
                    clsPront.Rc_Freq = 1
                    clsPront.Rc_Dias = 11
                    clsPront.Rc_Reco = dgReceita.Rows(i).Cells(2).Value.ToString()
                    clsPront.Rc_Esp = ckEspecial.Checked

                    clsPront.I_U_D_Receita()
                End If
            Next

            '  dgReceita.Rows.Clear()
            Dim dt As DataTable
            'dt = clsPront.BuscaReceita
            'dgReceita.DataSource = dt
            'ConfigDataGrid()

            MessageBox.Show("Receita lançada.", "Nota importante",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1)
            ImprimirReceita(txtIdReceita.Text)

            ''Preenche A ListBox
            dt = clsPront.LeReceitaAv()
            lstReceitasAv.DisplayMember = "RCDT"
            lstReceitasAv.ValueMember = "RCnss"
            lstReceitasAv.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MoveReceita()

    End Sub
    Private Sub btoLimpar_Click(sender As Object, e As EventArgs) Handles btoLimparReceita.Click
        txtFarmaco.Text = ""
        txtRecomendacao.Text = ""
        dgReceita.DataSource = Nothing
        dgReceita.Rows.Clear()

        btnImpirmir.Enabled = False
    End Sub

    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click

    End Sub

    Private Sub txtRecomendacao_TextChanged(sender As Object, e As EventArgs) Handles txtRecomendacao.TextChanged

    End Sub
    Private Sub txtRecomendacao_LostFocus(sender As Object, e As EventArgs) Handles txtRecomendacao.LostFocus
        Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja adicionar este item na lista de Receita??", "Emissão de Receita",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1, 0)

        If StrMsg = 6 Then
            If Len(Trim(txtRecomendacao.Text)) = 0 Then
                MessageBox.Show("Possologia do farmaco não informada", "Nota importante",
                            MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1)
                txtFarmaco.Focus()
                Exit Sub
            End If
            clsPront.TipoOperacao = "I"
            clsPront.Rc_Farmaco = ""
            clsPront.Rc_DescFarmaco = txtFarmaco.Text
            clsPront.Rc_Ani = Receita_ID_Paciente
            clsPront.Rc_Cli = Receita_ID_Cliente
            clsPront.Rc_Dt = Now
            clsPront.Rc_Nss = 0 ' (fixa  receita nao terminada)
            clsPront.Rc_Qtd = 1
            clsPront.Rc_Via = 1
            clsPront.Rc_Meio = ""
            clsPront.Rc_Freq = 1
            clsPront.Rc_Dias = 11
            clsPront.Rc_Reco = txtRecomendacao.Text
            clsPront.Rc_Esp = ckEspecial.Checked

            clsPront.I_U_D_Receita()

            Dim dt As DataTable
            dt = clsPront.BuscaReceita
            dgReceita.DataSource = dt
            ConfigDataGrid()
            txtFarmaco.Text = ""
            txtRecomendacao.Text = ""
            txtFarmaco.Focus()

        Else
            ''NAO
            txtFarmaco.Text = ""
            txtRecomendacao.Text = ""
            dgReceita.DataSource = Nothing
            dgReceita.Rows.Clear()

        End If
    End Sub

    Private Sub btoExcluir_Click(sender As Object, e As EventArgs) Handles btoExcluir.Click

    End Sub
    Private Sub ImprimirReceita(ByVal os_receita As Integer)
        Try
            frmCrystal.Show()
            Dim Caminho As String
            Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryReceita.rpt"
            If ckEspecial.Checked = True Then
                Caminho = "C:\SisVet\Sistema\SistemaVeterinario\Cadastros\cryReceitaEspecial.rpt"
            End If

            Dim cryRpt As New ReportDocument
            frmCrystal.Show()
            cryRpt.Load(Caminho)
            cryRpt.ParameterFields("nroReceita").CurrentValues.AddValue(Convert.ToInt32(os_receita))
            frmCrystal.crtVwGeral.ReportSource = cryRpt
            frmCrystal.crtVwGeral.Refresh()

            Exit Sub



            Dim CR As New ReportDocument
            CR.Load(Caminho)

            Dim crParameterDiscreteValue As ParameterDiscreteValue
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldLocation As ParameterFieldDefinition
            Dim crParameterValues As ParameterValues

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields
            crParameterFieldLocation = crParameterFieldDefinitions.Item("nroReceita")
            crParameterValues = crParameterFieldLocation.CurrentValues
            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterDiscreteValue.Value = os_receita

            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

            frmCrystal.crtVwGeral.ReportSource = CR
            frmCrystal.crtVwGeral.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnImpirmir_Click(sender As Object, e As EventArgs) Handles btnImpirmir.Click
        ImprimirReceita(txtIdReceita.Text)
    End Sub

    Private Sub lstReceitasAv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReceitasAv.SelectedIndexChanged

    End Sub
End Class