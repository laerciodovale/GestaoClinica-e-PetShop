Imports System.Drawing
Imports System.Windows.Forms
Imports DataBase

Public Class frmLancaFinan
    Public Property codigo_do_Paciente As Integer
    Public Property codigo_do_Cliente As Integer
    Public Property lf_NssNro As Integer
    Public Usr_Aut As Integer
    Public Property Bx_Nome_do_Cliente As String
    Public Property Bx_Nome_do_Paciente As String

    Private Nome_Usuario As String
    Private Aut_usuario As Integer

    Private Materiais As New Cls_Materiais
    Private ClsGer As New Utils
    Private ClsFinan As New Cls_Financeiro
    Private ClsCliente As New Cls_Cliente

    Private xmlPath As String '' = "C:\xml_Ntfe\MyData.xml 

    'Private PAR As List(Of SqlParameter)
    Dim Lote_NtfSe As Integer
    Dim Email_Destino As String
    Dim NomeFunc As String
    Public Sub New(ByVal cliente As Integer, ByVal paciente As Integer, ByVal os As Integer, Usuario As String, Aut As Integer)



        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        codigo_do_Cliente = cliente
        codigo_do_Paciente = paciente
        lf_NssNro = os
        Nome_Usuario = Usuario
        Aut_usuario = Aut

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub ZerarVar()
        txtQtd.Text = 0
        txtUnit.Text = 0
        txtVDcto.Text = 0
        txtPercDcto.Text = 0
        txtVDcto.Text = 0
        txtBruto.Text = 0
        lbQtd.Text = "0"
        Email_Destino = ""

    End Sub

    Private Sub PreencheForm()
        Try

            ZerarVar()
            txtNssNro.Enabled = True
            If dgListaFat.RowCount > 0 Then
                dgListaFat.Rows.Clear()
            End If

            If lf_NssNro > 0 Then
                txtNssNro.Text = lf_NssNro
                ClsFinan.id_Grid = lf_NssNro
                ClsFinan.LeFinan()

                If ClsFinan.fi_Retorno = True Then
                    txtBxIdCli.Text = ClsFinan.Fi_Cli
                    txtBxNomeCli.Text = ClsFinan.Fi_NomeCli
                    txtBxIdPac.Text = ClsFinan.Fi_Ani
                    txtBxNomeAni.Text = ClsFinan.Fi_NomeAni
                    txtFaturado.Text = ClsFinan.Fi_Vlr
                    txtNssNro.Enabled = False
                    txtBaixa.Text = ClsFinan.Fi_Vlr
                    txtBaixa.Focus()
                Else
                    MessageBox.Show("Financeiro não encontrado.", "Leitura de financeiro.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                End If
            End If

            If codigo_do_Cliente > 0 Then
                Email_Destino = ClsCliente.Cl_Email
                txtBxIdCli.Text = codigo_do_Cliente
                txtBxNomeCli.Text = Bx_Nome_do_Cliente
                txtBxIdPac.Text = codigo_do_Paciente
                txtBxNomeAni.Text = Bx_Nome_do_Paciente
                mskDtNasAni.Text = FormatDateTime(Now, DateFormat.ShortDate)
                txtFaturado.Text = 0
                txtBaixa.Text = 0

            End If

            Dim dt As DataTable = Materiais.Busca_DataTable("Sp_Grupo_Sel")
            cboGrupo.DisplayMember = "GrDesc"
            cboGrupo.ValueMember = "GrGrupo"
            cboGrupo.DataSource = dt

            'verifica se tem registro em aberto

            Materiais.Fa_Cli = codigo_do_Cliente
            Materiais.Fa_Ani = codigo_do_Paciente
            ClsFinan.Fa_Cli = codigo_do_Cliente
            ClsFinan.Fa_Ani = codigo_do_Paciente
            ClsGer.Id_Cliente = codigo_do_Cliente
            ClsGer.Id_Paciente = codigo_do_Paciente
            Ler_Lista()
            cboGrupo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ler_Lista()
        ZerarVar()
        If txtBxIdCli.Text = "" Then
            Exit Sub

        End If
        'dgListaFat.Rows.Clear()

        Dim dt As DataTable
        dt = Materiais.BuscaLista("Sp_FinA_LeLista")
        dgListaFat.DataSource = dt

        'dgListaFat.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'dgListaFat.Columns(0).HeaderText = "Cli"
        'dgListaFat.Columns(0).Width = 4
        'dgListaFat.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'dgListaFat.Columns(1).HeaderText = "Ani"
        'dgListaFat.Columns(1).Width = 4

        'dgListaFat.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(0).Width = 420
        dgListaFat.Columns(0).HeaderText = "Descricao do Evento"

        dgListaFat.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(1).Width = 12
        dgListaFat.Columns(1).HeaderText = "Qtd."
        dgListaFat.Columns(1).DefaultCellStyle.Format = "0.000"
        dgListaFat.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(2).Width = 30
        dgListaFat.Columns(2).HeaderText = "Unit."
        dgListaFat.Columns(2).DefaultCellStyle.Format = "0.00"
        dgListaFat.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(3).Width = 30
        dgListaFat.Columns(3).HeaderText = "Dcto."
        dgListaFat.Columns(3).DefaultCellStyle.Format = "C2"
        dgListaFat.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(4).Width = 30
        dgListaFat.Columns(4).HeaderText = "Total"
        dgListaFat.Columns(4).DefaultCellStyle.Format = "0.00"
        dgListaFat.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(5).Width = 30
        dgListaFat.Columns(5).HeaderText = "Evento"
        dgListaFat.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(6).Width = 20
        dgListaFat.Columns(6).HeaderText = "Id_Ev"
        dgListaFat.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgListaFat.Columns(7).Width = 20
        dgListaFat.Columns(7).HeaderText = "Func."

        ClsFinan.valorTotal = 0

        For Each col As DataGridViewRow In dgListaFat.Rows
            ClsFinan.valorTotal = ClsFinan.valorTotal + Convert.ToDecimal(col.Cells(4).Value)
        Next

        lblTotal.Text = ClsFinan.valorTotal.ToString("R$ #,###.00")
    End Sub

    Private Function ConvDec(ByVal ValorMoeda As String) As String
        Dim PosicaoVirgula As Integer
        ConvDec = Nothing
        PosicaoVirgula = InStr(1, ValorMoeda, ",")
        If PosicaoVirgula > 0 Then
            Mid(ValorMoeda, PosicaoVirgula) = "."
            ConvDec = ValorMoeda
        Else
            ConvDec = ValorMoeda
        End If
    End Function

    Private Sub PreencheCombo()
        'Combo Forma de Pagamento
        Dim ds As DataSet
        'ADICIONA NOVA LINHA NO COMBO Unidade
        'ds = Materiais.Busca_DataSet("Sp_FPgto_Sel")

        'Dim NCbo As DataRow = ds.Tables(0).NewRow
        'NCbo.Item("FpgtoDesc") = "A Vista - Dinheiro"
        'NCbo.Item("FpgtoId") = "01"

        'ds.Tables(0).Rows.InsertAt(NCbo, 0)
        'ds.Tables(0).AcceptChanges()
        ''VINCULA DATASET NO COMBO BOX
        'cboFPagto.DisplayMember = "FpgtoDesc"
        'cboFPagto.ValueMember = "FpgtoId"
        'cboFPagto.DataSource = ds.Tables(0)

        ds = Materiais.Busca_DataSet("Sp_Func_Sel")
        'VINCULA DATASET NO COMBO BOX
        cboFunc.DisplayMember = "FuNome"
        cboFunc.ValueMember = "FuId"
        cboFunc.DataSource = ds.Tables(0)


    End Sub

    Private Sub frmLancaFinan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(40, 73)
        Me.Size = New Size(1200, 650)
        btoAgEstetica.Enabled = True

        'ZerarVar()

        PreencheCombo()
        PreencheForm()
        Ler_Lista()

        If txtBxIdCli.Text <> "" Then
            Dim rt As Boolean
            ClsFinan.Fi_Cli = txtBxIdCli.Text
            rt = ClsFinan.BuscaDebCliente(txtBxIdCli.Text)

            If rt = True Then

                MessageBox.Show("Existe Lançamento de Financeiro em Aberto para este cliente." & vbCr & "Favor verificar se não se trata de duplicidade." &
               vbCr & "Para dar continuidade aos lançamentos." & vbCr & "", "Aviso Importante de débitos.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            End If
        Else
            MessageBox.Show("Cliente não informado." & vbCr & "" &
               vbCr & "" & vbCr & "", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End If

        ''MsgBox(Aut_usuario & " " & Nome_Usuario)

    End Sub

    Private Sub btoFaturar_Click(sender As Object, e As EventArgs) Handles btoFaturar.Click
        Try
            'Dim rt As Boolean
            'rt = ClsFinan.LeCxAberto()

            'If rt = False Then
            '    MessageBox.Show("Processo encerrado." & vbCr & "Favor efetuar a abertura de caixa.", "Aviso." & vbCr & "Abertura de caixa ainda não efetuada.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            '    ''Exit Sub
            'End If

            If txtBxIdPac.Text = "" Or txtBxIdPac.Text = 0 Then
                MessageBox.Show("Sem informação do Tutor.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                btoListar.Focus()
                Exit Sub
            End If

            If lblTotal.Text = "" Or lblTotal.Text = 0 Then
                MessageBox.Show("Sem valor comercial.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                btoListar.Focus()
                Exit Sub
            End If

            ClsFinan.GravaNssNro()
            txtNssNro.Text = ClsFinan.NssNro
            ClsFinan.MoveVar()
            ClsFinan.IncluirFinS()
            ClsFinan.UpDateFaNssNro()
            ''LANCA O ESTOQUE
            Dim cta As Integer
            cta = dgListaFat.Rows.Count

            For Each col As DataGridViewRow In dgListaFat.Rows
                If col.Cells(5).Value <> String.Empty Then

                    Materiais.ET_CLIENTE = txtBxIdCli.Text 'col.Cells(0).Value
                    Materiais.ET_FORNEC = 1
                    Materiais.ET_ITEM = col.Cells(5).Value
                    Materiais.Fa_Ev = Materiais.ET_ITEM
                    Materiais.ET_DTREF = FormatDateTime(Now, DateFormat.LongDate)
                    Materiais.ET_HRREF = FormatDateTime(TimeOfDay)
                    Materiais.ET_SOLIC = ClsFinan.NssNro
                    Materiais.ET_OC = ClsFinan.NssNro
                    Materiais.ET_QTDE = 0
                    Materiais.ET_VALOR = 0
                    Materiais.ET_QTDS = col.Cells(1).Value
                    Materiais.ET_VLRS = col.Cells(4).Value
                    Materiais.ET_NLOTE = " "
                    '' atualiza OC da lista do cliente
                    Materiais.UpLista()
                    '' enviar para o estoque
                    Materiais.GravarEstoque()

                End If
            Next

            'Dim u As New Utils
            'If u.usr_Aut > 50 Then

            '    ZerarVar()
            '    '    Ler_Lista()
            '    dgListaFat.DataSource = Nothing
            '    dgListaFat.Rows.Clear()

            '    Dim result2 As DialogResult = MessageBox.Show("Inclusão do Faturamento efetuada com sucesso. " & vbCr & "Deseja efetuar a Baixa ?",
            '                                           "Nota importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            '    If result2 = DialogResult.Yes Then
            '        GrupoBaixa.Enabled = True
            '        txtNssNro.Text = ClsFinan.NssNro
            '        txtFaturado.Text = ClsFinan.valorTotal
            '        txtBaixa.Text = ClsFinan.valorTotal
            '        cboFPagto.Text = "À Vista"
            '        cboFPagto.Focus()
            '        Exit Sub
            '    Else
            '        Close()
            '    End If
            'Else
            MessageBox.Show("Faturamento efetuado com sucesso.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Dim clsMat As New Cls_Materiais
            clsMat.Busca_Banho_da_Os(txtNssNro.Text)

            If clsMat.IT_GRUPO = 3 Then

                btoAgEstetica.Enabled = True
                txtNssNro.Text = ClsFinan.NssNro
                Dim nss As Integer = ClsFinan.NssNro

                Dim frRm As New frmAgBanho()
                frRm.txtOs.Text = ClsFinan.NssNro
                frRm.ShowDialog()
                Me.Close()

            End If

            If clsMat.IT_GRUPO = 7 Then
                MessageBox.Show("Esta OS contém lançamento de Vacina. Favor efetuar o " & vbCr _
                                & "Agendamento das vacinas antes de efetuar a baixa." & vbCr _
                                & "OBS** A Baixa devera ser feita pelo : " & vbCr & " Menu Lateral/Caixa/Movimento.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
                Exit Sub
            End If

            '' EFETUA A BAIXA
            Dim frm As New frmCaixa(Nome_Usuario, txtBxIdCli.Text, txtNssNro.Text, Aut_usuario)
            frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If Len(txtNssNro.Text) = 0 Or IsNumeric(txtNssNro.Text) = 0 Then

            MessageBox.Show("Ordem de Servico não informada.", "Selecione o financeiro a ser excluido.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Try
            ClsFinan.NssNro = txtNssNro.Text
            ClsFinan.ExProcNssNro("Sp_FinS_Delete")
            ZerarVar()

            MessageBox.Show("Ordem de Servico Excluída.", "Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception

            MessageBox.Show("Erro ao tentar excluir o financeiro.", "Exclusão de financeiro.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click

        If Len(txtNssNro.Text) = 0 Or IsNumeric(txtNssNro.Text) = 0 Then

            MessageBox.Show("Ordem de Servico não informada.", "Selecione o financeiro a ser excluido.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Try
            ClsFinan.NssNro = txtNssNro.Text
            ClsFinan.ExProcNssNro("Sp_FinS_Estorno")
            ZerarVar()

            MessageBox.Show("Baixa da Ordem de Servico Estornada.", "Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception

            MessageBox.Show("Erro ao tentar estornar o financeiro.", "Estorno de financeiro.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        End Try
    End Sub



    Private Sub dgListaFat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged


        Materiais.IT_GRUPO = cboGrupo.SelectedValue

        Dim dt As DataTable
        dt = Materiais.BuscaItensDoGrupo()

        dgItens.DataSource = dt

        dgItens.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(0).HeaderText = " Nome do Item        "
        dgItens.Columns(0).Width = 15
        dgItens.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(1).HeaderText = " Codigo "
        dgItens.Columns(1).Width = 10

    End Sub

    Private Sub txtItemBusca_TextChanged(sender As Object, e As EventArgs) Handles txtItemBusca.TextChanged

        Materiais.IT_DESC = txtItemBusca.Text

        Dim dt As DataTable
        dt = Materiais.BuscaItensLike
        dgItens.DataSource = dt

        dgItens.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(0).HeaderText = " Nome        "
        dgItens.Columns(0).Width = 15
        dgItens.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(1).HeaderText = " Codigo "
        dgItens.Columns(1).Width = 10

    End Sub

    Private Sub dgItens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItens.CellContentClick
        Try
            Me.Cursor = System.Windows.Forms.Cursors.AppStarting

            Materiais.IT_ITEM = dgItens.CurrentRow.Cells(1).Value.ToString()
            Materiais.Le_Item()
            cboGrupo.SelectedValue = Materiais.IT_GRUPO

            My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\ping.wav")
            TansfereDadosItem()

            txtQtd.Text = 1
            txtQtd.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub TansfereDadosItem()

        'IT_ID
        'IT_SEGMENTO 
        'IT_GRUPO 
        'IT_SUBGRP 
        txtItem.Text = Materiais.IT_ITEM
        'IT_TIPO 
        'IT_UNID 
        txtDescItem.Text = Materiais.IT_DESC
        'IT_ESTQMIN 
        'IT_ESTQMAX 
        'IT_COMPRA 
        'IT_LUCRO 
        'IT_VLUCRO 

        txtQtd.Text = 1
        txtUnit.Text = Format(Materiais.IT_VENDA, "0.00")
        txtVDcto.Text = 0
        txtPercDcto.Text = Format(Materiais.IT_DCTO, "0.00")
        txtVDcto.Text = Format(((Materiais.IT_VENDA * Materiais.IT_DCTO) / 100), "0.00")
        txtBruto.Text = Format((Materiais.IT_VENDA - txtVDcto.Text), "0.00")
        If Materiais.IT_SALDO > 0 Then
            lbQtd.Text = Format(Materiais.IT_SALDO, "0.00")
        Else
            lbQtd.Text = "0"
        End If

        'IT_COMISSAO 
        'IT_CONVENIO 
        'IT_PROMO
        'IT_ATIVO 
        'IT_CNAE 
        'IT_NCM 
        'IT_CST 
        'IT_CFOP 
        'IT_ALQICMS 
        'IT_ALQIPI 
        'IT_ALQISS 
        'IT_IMAGEM 

        dgItens.Focus()
        txtItem.Text = Materiais.IT_ITEM
        'IT_TIPO 
        'IT_UNID 
        txtDescItem.Text = Materiais.IT_DESC
        'IT_ESTQMIN 
        'IT_ESTQMAX 
        'IT_COMPRA 
        'IT_LUCRO 
        'IT_VLUCRO 

    End Sub

    Private Sub btoListar_Click(sender As Object, e As EventArgs) Handles btoListar.Click
        Try

            If Len(Trim(txtBxIdCli.Text)) = 0 Then
                MessageBox.Show("Cliente não informado." & vbCr & "Processo não aceito.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If Len(Trim(txtBxNomeCli.Text)) = 0 Then
                MessageBox.Show("Cliente não informado." & vbCr & "Processo não aceito.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If txtBruto.Text = "" Or txtBruto.Text = 0 Then
                MessageBox.Show("Sem valor comercial.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txtQtd.Focus()
                Exit Sub
            End If

            Materiais.Fa_NssNro = 0
            Materiais.Fa_Ev = txtItem.Text
            Materiais.Fa_Desc = txtDescItem.Text
            Materiais.Fa_Qtd = txtQtd.Text
            Materiais.Fa_VlrU = txtUnit.Text
            Materiais.Fa_Dcto = txtVDcto.Text
            Materiais.Fa_Vlr = txtBruto.Text
            Materiais.Fa_Func = cboFunc.SelectedValue
            Materiais.Fa_Dt = Now
            Materiais.Fa_VlrAd = 0
            Materiais.Fa_NssPai = 0

            If Len(Trim(Materiais.Fa_Ev)) <> 0 Then
                Materiais.InsertLista()
                Ler_Lista()

                txtItem.Text = ""
                txtDescItem.Text = ""
                txtQtd.Text = 0
                txtUnit.Text = 0
                txtVDcto.Text = 0
                txtBruto.Text = 0
                lbQtd.Text = ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub txtPercDcto_TextChanged(sender As Object, e As EventArgs) Handles txtPercDcto.TextChanged

    End Sub

    Private Sub txtPercDcto_Leave(sender As Object, e As EventArgs) Handles txtPercDcto.Leave
        Dim VDcto As Double
        Try
            If IsNumeric(txtQtd.Text) And IsNumeric(txtUnit.Text) = True Then

                VDcto = (txtQtd.Text * txtUnit.Text) * (txtPercDcto.Text / 100)
                txtVDcto.Text = VDcto
                txtBruto.Text = (txtQtd.Text * txtUnit.Text) - VDcto

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtVDcto_Leave(sender As Object, e As EventArgs) Handles txtVDcto.Leave
        Try
            If IsNumeric(txtQtd.Text) And IsNumeric(txtUnit.Text) = True Then
                txtPercDcto.Text = 0
                txtBruto.Text = (txtQtd.Text * txtUnit.Text) - txtVDcto.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtQtd_Leave(sender As Object, e As EventArgs) Handles txtQtd.Leave
        Dim VDcto As Double
        Try
            If IsNumeric(txtQtd.Text) And IsNumeric(txtUnit.Text) = True Then

                VDcto = (txtQtd.Text * txtUnit.Text) * (txtPercDcto.Text / 100)
                txtVDcto.Text = VDcto
                txtBruto.Text = (txtQtd.Text * txtUnit.Text) - VDcto

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'apgar linha do datagrid

        Dim result1 As DialogResult = MessageBox.Show("Você realmente deseja remover o Item " & dgListaFat.CurrentRow.Cells(0).Value.ToString() & " - " & dgListaFat.CurrentRow.Cells(1).Value.ToString() & " da lista?",
                                                       "Pergunta importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result1 = DialogResult.Yes Then
            Materiais.Fa_Seq = dgListaFat.CurrentRow.Cells(6).Value.ToString()
            Materiais.DeletaItem()
            '            dgListaFat.Rows.Remove(dgListaFat.CurrentRow)
            txtItem.Text = ""
            txtDescItem.Text = ""
            txtQtd.Text = 0
            txtUnit.Text = 0
            txtVDcto.Text = 0
            txtBruto.Text = 0

            Ler_Lista()

        End If

    End Sub

    Private Sub btnBaixa_Click(sender As Object, e As EventArgs) Handles btnBaixa.Click

        Dim rt As Boolean
        rt = ClsFinan.LeCxAberto()

        If rt = False Then
            MessageBox.Show("Abertura de caixa ainda não efetuada.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If

        If Len(txtNssNro.Text) = 0 Or IsNumeric(txtNssNro.Text) = 0 Then
            MessageBox.Show("Ordem de Servico não informada.", "Selecione o financeiro a ser excluido.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Try
            If cboFPagto.Text = "" Then
                MessageBox.Show("Forma de pagamento não informada.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cboFPagto.Focus()
                Exit Sub
            End If
            If txtBaixa.Text = 0 Or txtBaixa.Text = "" Then
                Dim StrMsg As DialogResult = MessageBox.Show(Me, "Valor da baixa é igual a 0 (Zero) ou nula. Deseja continuar??", "Baixa de Financeiro",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button1, 0)
                If StrMsg <> 6 Then
                    'SE NÃO
                    txtBaixa.Focus()
                    Exit Sub
                End If
            End If

            ClsFinan.MoveVar()
            Dim diaDoAno As Integer = Now.DayOfYear
            ClsFinan.Fi_Lote = Format(Now, "yy") & diaDoAno

            ClsFinan.Fi_DtPgto = Now
            ClsFinan.Fi_VlrPgto = txtBaixa.Text

            Dim ACRE As Double
            ACRE = Convert.ToDouble(txtBaixa.Text) - Convert.ToDouble(txtFaturado.Text)
            If ACRE > 0 Then
                ClsFinan.Fi_VlrAcre = ACRE
                ClsFinan.Fi_VlrDcto = 0
            Else
                ClsFinan.Fi_VlrAcre = 0
                ClsFinan.Fi_VlrDcto = ACRE
            End If

            ClsFinan.Fi_Caixa = "Usuario" 'v_Usuario
            ClsFinan.Fi_FPagto = cboFPagto.Text

            ClsFinan.Fi_NssNro = txtNssNro.Text

            ClsFinan.ExecutaBaixa() '"Sp_FinS_BaixaN"

            ''GRAVA O MOVIMENTO NO CAIXA
            'ClsFinan.Mv_NssNro = ClsFinan.Fi_NssNro
            'ClsFinan.Mv_Data = Now
            'ClsFinan.Mv_VlrEnt = Convert.ToDouble(txtBaixa.Text)
            'ClsFinan.Mv_VlrSai = 0
            'ClsFinan.Mv_Custo = 1
            'ClsFinan.MV_Caixa = mdVar.v_Usuario

            'ClsFinan.IncluirCx()

            Dim pergunta As DialogResult = MessageBox.Show("Baixa efetuada com sucesso." & vbCr & vbCr & "Deseja emitir a Nota Fiscal ?? ", "Nota importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            If pergunta = DialogResult.Yes Then
                Tx1.Text = txtNssNro.Text
                ' btoNFSe.PerformClick()  '' emite a nota fiscal

                ClsFinan.Fa_NssNro = txtNssNro.Text
                Dim NtF As New cls_NTFeS
                NtF.NTFe_Cliente = ClsFinan.Fa_Cli
                NtF.NTFe_Paciente = ClsFinan.Fa_Ani
                NtF.NTFe_NssNro = txtNssNro.Text

                NtF.Emitir_NTFSe()
                MessageBox.Show("Nota Emitida. " & vbCr & "Verifique o retorno.", "Nota importante", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub frmLancaFinan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Windows.Forms.Keys.F11 Then ''' F11 Lanca o financeiro
            btoFaturar_Click(btoListar, Nothing)
        End If

        If e.KeyCode = Windows.Forms.Keys.F12 Then ''' F12 Coloca na lista
            btoListar_Click(btoListar, Nothing)
        End If
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Dim StrMsg As DialogResult = MessageBox.Show(Me, "Deseja realmente sair do Financeiro??", "Sair do Financeiro",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1, 0)
            If StrMsg = 6 Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Windows.Forms.Keys.F4 Then ''' F4 Caixa do lancamento financeiro

            Dim frm As New frmCaixa(Nome_Usuario, txtBxIdCli.Text, 0, Aut_usuario)
            frm.ShowDialog()

        End If

    End Sub

    Private Sub txtNssNro_LostFocus(sender As Object, e As EventArgs) Handles txtNssNro.LostFocus
        txtFaturado.Text = 0
        txtBaixa.Text = 0

        If Len(Trim(txtNssNro.Text)) > 0 Then
            Try

                ClsFinan.id_Grid = txtNssNro.Text
                ClsFinan.LeFinan()
                If ClsFinan.fi_Retorno = True Then
                    txtFaturado.Text = ClsFinan.Fi_Vlr
                    txtBaixa.Text = ClsFinan.Fi_Vlr
                Else
                    MessageBox.Show("Financeiro não encontrado.", "Leitura de financeiro.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show("Financeiro com problema.", "Estorno de financeiro.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End Try

        End If
    End Sub
    Private Sub txtQtd_LostFocus(sender As Object, e As EventArgs) Handles txtQtd.LostFocus
        txtQtd.BackColor = Color.SteelBlue
    End Sub
    Private Sub txtPercDcto_LostFocus(sender As Object, e As EventArgs) Handles txtPercDcto.LostFocus
        txtPercDcto.BackColor = Color.SteelBlue
    End Sub
    Private Sub txtVDcto_LostFocus(sender As Object, e As EventArgs) Handles txtVDcto.LostFocus
        txtVDcto.BackColor = Color.SteelBlue
    End Sub

    Private Sub btoAgEstetica_Click(sender As Object, e As EventArgs) Handles btoAgEstetica.Click

        If ClsFinan.NssNro > 0 Then
            Dim nss As Integer = ClsFinan.NssNro
            Dim frm As New frmAgBanho()
            frm.txtOs.Text = ClsFinan.NssNro
            frm.ShowDialog()

            Me.Close()
        End If

    End Sub

    Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged

    End Sub

    Private Sub txtVDcto_TextChanged(sender As Object, e As EventArgs) Handles txtVDcto.TextChanged

    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged

    End Sub

    Private Sub txtCB_TextChanged(sender As Object, e As EventArgs) Handles txtCB.TextChanged
        If IsNumeric(txtCB.Text) = True Then

            If txtCB.Text <> 0 Then

                Materiais.IT_EAN = txtCB.Text

                Dim dt As DataTable
                dt = Materiais.BuscaItensCB
                dgItens.DataSource = dt

                dgItens.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgItens.Columns(0).HeaderText = " Nome        "
                dgItens.Columns(0).Width = 15
                dgItens.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                dgItens.Columns(1).HeaderText = " Codigo "
                dgItens.Columns(1).Width = 10
                Materiais.IT_ITEM = txtCB.Text
                Materiais.Le_Item()
                cboGrupo.SelectedValue = Materiais.IT_GRUPO

                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\ping.wav")
                TansfereDadosItem()

                txtQtd.Text = 1
                txtQtd.Focus()
            End If
        End If
    End Sub

    Private Sub cboFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFunc.SelectedIndexChanged


        Materiais.Fa_Func = cboFunc.SelectedValue
        NomeFunc = cboFunc.Text

    End Sub

End Class
