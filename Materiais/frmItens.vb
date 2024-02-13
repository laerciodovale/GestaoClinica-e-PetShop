Imports System.Data.SqlClient
Imports System.IO
Imports AForge.Video.DirectShow
Imports DataBase

Public Class FrmItens
    Private Materiais As New Cls_Materiais
    Private ClsGeral As New Utils

    Private CAMARA As VideoCaptureDevice

    Private BMP As Bitmap
    Private PAR As List(Of SqlParameter)
    Dim nomeArquivoImagem As String = "C:\SisVet\Sistema\Imagens\ImgItem.bmp"
    Dim fs As FileStream
    Dim br As BinaryReader
    Private Sub ZeraTela()
        opServ.Checked = True
        cboUnid.SelectedValue = 1
        txtDesc.Text = ""
        txtMin.Text = 0
        txtMax.Text = 0
        txtCompra.Text = 0
        txtLucro.Text = 0
        txtLucratividade.Text = 0
        txtValor.Text = 0
        txtEstoque.Text = 0
        txtComissao.Text = 0
        cboConv.SelectedValue = 1
        ckPromo.Checked = False
        ckAtivo.Checked = True
        txtCEST.Text = 0
        txtCNAE.Text = 0
        txtNCM.Text = 0
        txtCST.Text = 0
        txtCFOP.Text = 0
        txtICMS.Text = 0
        txtIPI.Text = 0
        txtISS.Text = 0
        imgItem.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        txtEAN.Text = 0
        txtANVISA.Text = 0
        cboServico.SelectedValue = 1
        btoAlterar.Enabled = False
        txtItemPEmb.Text = 1

    End Sub
    Private Sub TransfereBaseTela()
        'Materiais.IT_ID
        If Materiais.IT_ITEM = "" Then
            ZeraTela()
            Exit Sub
        End If

        cboSegmento.SelectedValue = Materiais.IT_SEGMENTO
        cboGrupo.SelectedValue = Materiais.IT_GRUPO
        cboSubGrupo.SelectedValue = Materiais.IT_SUBGRP
        txtID.Text = Materiais.IT_ID
        txtItem.Text = Materiais.IT_ITEM

        If Materiais.IT_TIPO = "S" Then
            opServ.Checked = True
            opMat.Checked = False
        Else
            opServ.Checked = False
            opMat.Checked = True
        End If

        cboUnid.Text = Materiais.IT_UNID
        txtDesc.Text = Materiais.IT_DESC
        txtMin.Text = Materiais.IT_ESTQMIN
        txtMax.Text = Materiais.IT_ESTQMAX
        txtCompra.Text = Materiais.IT_COMPRA
        txtItemPEmb.Text = Materiais.IT_QTDEMB

        txtLucro.Text = Materiais.IT_LUCRO
        txtLucratividade.Text = Materiais.IT_VLUCRO

        txtValor.Text = Materiais.IT_VENDA
        txtEstoque.Text = Materiais.IT_SALDO

        'If Materiais.IT_COMPRA > 0 Then
        '    Calc_Lucro()
        'End If

        txtComissao.Text = Materiais.IT_COMISSAO
        cboConv.Text = Materiais.IT_CONVENIO
        ckPromo.Checked = Materiais.IT_PROMO
        ckAtivo.Checked = Materiais.IT_ATIVO

        txtCEST.Text = Materiais.IT_CEST
        txtCNAE.Text = Materiais.IT_CNAE
        txtNCM.Text = Materiais.IT_NCM
        txtCST.Text = Materiais.IT_CST
        txtCFOP.Text = Materiais.IT_CFOP
        txtICMS.Text = Materiais.IT_ALQICMS
        txtIPI.Text = Materiais.IT_ALQPIS
        txtISS.Text = Materiais.IT_ALQISS
        'salva imagem
        If Materiais.IT_IMAGEM.Length = 0 Or IsDBNull(Materiais.IT_IMAGEM) = True Then
            imgItem.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
            Materiais.IT_IMAGEM = ClsGeral.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        Else
            imgItem.Image = ClsGeral.AbrirArquivoBase64(Materiais.IT_IMAGEM)
        End If

        txtEAN.Text = Materiais.IT_EAN
        txtANVISA.Text = Materiais.IT_ANVISA

        If Materiais.IT_LISTSERV IsNot Nothing Then
            cboServico.SelectedValue = Materiais.IT_LISTSERV
        Else
            cboServico.SelectedValue = " "
        End If

    End Sub
    Private Sub TransfereTelaBase()

        'Materiais.IT_ID
        Materiais.IT_SEGMENTO = cboSegmento.Text

        Materiais.IT_GRUPO = cboGrupo.Text
        Materiais.IT_SUBGRP = cboSubGrupo.Text
        Materiais.IT_ITEM = txtItem.Text

        If opServ.Checked = True Then
            Materiais.IT_TIPO = "S"
        Else
            Materiais.IT_TIPO = "M"
        End If

        Materiais.IT_UNID = cboUnid.Text
        Materiais.IT_DESC = txtDesc.Text
        Materiais.IT_ESTQMIN = txtMin.Text
        Materiais.IT_ESTQMAX = txtMax.Text
        Materiais.IT_COMPRA = txtCompra.Text
        Materiais.IT_QTDEMB = txtItemPEmb.Text

        Materiais.IT_LUCRO = txtLucro.Text
        Materiais.IT_VLUCRO = txtLucratividade.Text

        Materiais.IT_VENDA = txtObs.Text
        Materiais.IT_SALDO = txtEstoque.Text

        Materiais.IT_COMISSAO = txtComissao.Text
        Materiais.IT_CONVENIO = cboConv.Text
        Materiais.IT_PROMO = ckPromo.Checked
        Materiais.IT_ATIVO = ckAtivo.Checked
        Materiais.IT_CNAE = txtCNAE.Text
        Materiais.IT_NCM = txtNCM.Text
        Materiais.IT_CEST = txtCEST.Text
        Materiais.IT_CFOP = txtCFOP.Text
        Materiais.IT_ALQICMS = txtICMS.Text
        Materiais.IT_ALQCOFINS = 0
        Materiais.IT_ALQPIS = txtIPI.Text
        Materiais.IT_ALQISS = txtISS.Text
        Materiais.IT_ANVISA = txtANVISA.Text
        '''salva a imagem
        If imgItem.Image IsNot Nothing Then
            imgItem.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        End If

        imgItem.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
        Materiais.IT_IMAGEM = ClsGeral.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

    End Sub
    Private Sub PreencheDgItens()
        picLoading.Visible = True
        picLoading.Enabled = True
        'picLoading.Image = New Bitmap("C:\SisVet\Sistema\Imagens\Carregando.gif")

        Dim dt As DataTable
        dt = Materiais.BuscaItens

        dgItens.DataSource = dt

        dgItens.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(0).HeaderText = " Descrição        "
        dgItens.Columns(0).Width = 180

        dgItens.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(1).HeaderText = " Codigo "
        dgItens.Columns(1).Width = 55

        dgItens.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItens.Columns(2).HeaderText = " ID "
        dgItens.Columns(2).Width = 30

        picLoading.Enabled = False
        picLoading.Visible = False

        ''pnItem.Visible = True

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        picLoading.Enabled = False
        picLoading.Visible = False

        ''pnItem.Visible = True

    End Sub
    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged

        picLoading.Enabled = False
        picLoading.Visible = False

        ''pnItem.Visible = True

    End Sub
    'Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)

    '    imgItem.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    'End Sub


    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

        picLoading.Enabled = False
        picLoading.Visible = False

        ''pnItem.Visible = False
    End Sub

    Private Sub dgItens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItens.CellContentClick
        imgItem.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        txtItem.Text = dgItens.CurrentRow.Cells(1).Value.ToString()
        Materiais.IT_ITEM = txtItem.Text
        txtID.Text = dgItens.CurrentRow.Cells(2).Value.ToString()

        Materiais.Le_Item()
        TransfereBaseTela()
        btoAlterar.Enabled = True
    End Sub

    Private Sub txtItem_LostFocus(sender As Object, e As EventArgs) Handles txtItem.LostFocus

        Materiais.IT_ITEM = txtItem.Text
        Materiais.IT_ID = 0
        Materiais.Le_Item()
        ''txtEAN.Enabled = False
        If Materiais.IT_ID > 0 Then
            ''txtEAN.Enabled = True
            TransfereBaseTela()
        End If

        ''pnItem.Visible = False

    End Sub

    Private Sub btoIncluir_Click(sender As Object, e As EventArgs) Handles btoIncluir.Click
        If txtDesc.Text = "" Then
            MessageBox.Show("Item sem descrição. " & vbCrLf & "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        EnviaInsert()
        ZeraTela()
        txtID.Text = ""
        txtItem.Text = ""
        txtEAN.Text = ""
        Materiais.IT_EAN = ""
    End Sub
    Private Function EnviaInsert() As Object
        Try
            Dim RETORNO As Integer
            Dim DAccess As New DataAcces
            '''adiciona os parametros
            MoveParametros()

            'EXECUTA A PROCEDURE
            RETORNO = DAccess.ExecuteStoreProcedureIncremento("SP_ITENS_INSERT_ID", PAR)

            Return RETORNO
            PreencheDgItens()
            MessageBox.Show("Item cadastrado com sucesso. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Function
    Private Sub MoveParametros()
        PAR = New List(Of SqlParameter)
        PAR.Add(New SqlParameter("@IT_SEGMENTO", 1))
        PAR.Add(New SqlParameter("@IT_GRUPO", cboGrupo.SelectedValue))
        PAR.Add(New SqlParameter("@IT_SUBGRP", cboSubGrupo.SelectedValue))

        txtItem.Text = UCase(txtItem.Text)
        PAR.Add(New SqlParameter("@IT_ITEM", txtItem.Text))

        If opServ.Checked = True Then
            PAR.Add(New SqlParameter("@IT_TIPO", "S"))
        Else
            PAR.Add(New SqlParameter("@IT_TIPO", "M"))
        End If

        PAR.Add(New SqlParameter("@IT_UNID", cboUnid.Text))
        txtDesc.Text = UCase(txtDesc.Text)
        PAR.Add(New SqlParameter("@IT_DESC", txtDesc.Text))
        Dim vdec As Double
        vdec = txtMin.Text
        PAR.Add(New SqlParameter("@IT_ESTQMIN", vdec))

        vdec = txtMax.Text
        PAR.Add(New SqlParameter("@IT_ESTQMAX", vdec))

        vdec = txtCompra.Text
        PAR.Add(New SqlParameter("@IT_COMPRA", vdec))

        PAR.Add(New SqlParameter("@IT_QTDEMB", txtItemPEmb.Text))

        vdec = txtLucro.Text
        PAR.Add(New SqlParameter("@IT_LUCRO", vdec))

        vdec = txtLucratividade.Text
        PAR.Add(New SqlParameter("@IT_VLUCRO", vdec))

        vdec = txtValor.Text
        PAR.Add(New SqlParameter("@IT_VENDA", vdec))

        PAR.Add(New SqlParameter("@IT_DCTO", 0))
        PAR.Add(New SqlParameter("@IT_SALDO", txtEstoque.Text))

        vdec = txtComissao.Text
        PAR.Add(New SqlParameter("@IT_COMISSAO", vdec))

        ' PAR.Add(New SqlParameter("@IT_CONVENIO", cboConv.SelectedItem))
        PAR.Add(New SqlParameter("@IT_CONVENIO", 1))

        PAR.Add(New SqlParameter("@IT_PROMO", ckPromo.Checked))
        PAR.Add(New SqlParameter("@IT_ATIVO", ckAtivo.Checked))

        PAR.Add(New SqlParameter("@IT_CNAE", txtCNAE.Text))
        PAR.Add(New SqlParameter("@IT_NCM", txtNCM.Text))
        PAR.Add(New SqlParameter("@IT_CEST", txtCEST.Text))
        PAR.Add(New SqlParameter("@IT_CST", txtCST.Text))
        PAR.Add(New SqlParameter("@IT_CFOP", txtCFOP.Text))
        PAR.Add(New SqlParameter("@IT_ALQCOFINS", 0))
        PAR.Add(New SqlParameter("@IT_ALQICMS", 0))
        PAR.Add(New SqlParameter("@IT_ALQPIS", 0))
        PAR.Add(New SqlParameter("@IT_ALQISS", 0))
        PAR.Add(New SqlParameter("@IT_EAN", txtEAN.Text))
        PAR.Add(New SqlParameter("@IT_LISTSERV", cboServico.SelectedValue))
        PAR.Add(New SqlParameter("@IT_ANVISA", txtANVISA.Text))

        'If imgItem.Image IsNot Nothing Then
        'imgItem.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
        'End If

        imgItem.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
        Materiais.IT_IMAGEM = ClsGeral.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

        PAR.Add(New SqlParameter("@IT_IMAGEM", Materiais.IT_IMAGEM))

    End Sub

    Private Function EnviaUpDate() As Object
        Try

            Dim RETORNO As Boolean
            Dim DAccess As New DataAcces

            MoveParametros()

            PAR.Add(New SqlParameter("@IT_ID", txtID.Text))
            'EXECUTA A PROCEDURE
            RETORNO = DAccess.ExecuteStoreProcedure("SP_ITENS_update", PAR)

            'RETORNO O RESULTADO
            Return RETORNO


            MessageBox.Show("Alteração efetuada com sucesso. ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Function
    Private Function PreencheCombos()
        'preenche os combos
        'segmento

        'Grupo
        Dim Materiais As New Cls_Materiais
        Dim ds As DataSet

        Try
            'ADICIONA NOVA LINHA NO COMBO Unidade
            ds = Materiais.Busca_Grupo_CBO("Sp_Unidade_Sel")

            Dim novaUF As DataRow = ds.Tables(0).NewRow
            novaUF.Item("UNDESC") = "UNITARIO"
            novaUF.Item("unund") = "UN"

            ds.Tables(0).Rows.InsertAt(novaUF, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboUnid.DisplayMember = "UNDESC"
            cboUnid.ValueMember = "unund"
            cboUnid.DataSource = ds.Tables(0)

            'ADICIONA NOVA LINHA NO COMBO SEGMENTO
            ds = Materiais.Busca_Sub_Grupo_CBO("Sp_Segmento_Sel", cboSegmento.SelectedValue)

            Dim novaSEGMENTO As DataRow = ds.Tables(0).NewRow
            novaSEGMENTO.Item("SEGDESC") = "--- Selecione o Segmento ---"
            novaSEGMENTO.Item("SEGID") = "0"
            ds.Tables(0).Rows.InsertAt(novaSEGMENTO, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboSegmento.DisplayMember = "SEGDESC"
            cboSegmento.ValueMember = "SEGID"
            cboSegmento.DataSource = ds.Tables(0)

            'ADICIONA NOVA LINHA NO COMBO GRUPO
            ds = Materiais.Busca_Grupo_CBO("sp_grupo_sel")

            Dim nova As DataRow = ds.Tables(0).NewRow
            nova.Item("GRDESC") = "--- Selecione o Grupo ---"
            nova.Item("GRGRUPO") = "0"

            ds.Tables(0).Rows.InsertAt(nova, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboGrupo.DisplayMember = "GRDESC"
            cboGrupo.ValueMember = "GRGRUPO"
            cboGrupo.DataSource = ds.Tables(0)

            'ADICIONA NOVA LINHA NO COMBO SUBGRUPO
            ds = Materiais.Busca_Sub_Grupo_CBO("Sp_SubGrupo_Sel", cboSubGrupo.SelectedValue)

            Dim novaSGP As DataRow = ds.Tables(0).NewRow
            novaSGP.Item("SGRDESC") = "--- Selecione o SubGrupo ---"
            novaSGP.Item("SGRSUBGRP") = "0"
            ds.Tables(0).Rows.InsertAt(novaSGP, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboSubGrupo.DisplayMember = "SGRDESC"
            cboSubGrupo.ValueMember = "SGRSUBGRP"
            cboSubGrupo.DataSource = ds.Tables(0)

            'ADICIONA NOVA LINHA NO COMBO servicos


            ds = Materiais.Busca_Grupo_CBO("Sp_TipoServicos_Sel")

            Dim novoServ As DataRow = ds.Tables(0).NewRow
            novoServ.Item("tpDesc") = "--- Selecione o Serviço ---"
            novoServ.Item("tpserv") = " "

            ds.Tables(0).Rows.InsertAt(novoServ, 0)
            ds.Tables(0).AcceptChanges()

            'VINCULA DATASET NO COMBO BOX
            cboServico.DisplayMember = "tpDesc"
            cboServico.ValueMember = "tpserv"
            cboServico.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Function
    Private Sub FrmItens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ZeraTela()
        PreencheCombos()
        PreencheDgItens()
        Dim CAMARA_Anis = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If CAMARA_Anis IsNot Nothing AndAlso CAMARA_Anis.Count > 0 Then
            CAMARA = New VideoCaptureDevice(CAMARA_Anis(0).MonikerString)
            AddHandler CAMARA.NewFrame, AddressOf CAMARA_NewFrame
        End If

        ''Me.Size = New Size(1470, 781)

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupo.SelectedIndexChanged
        ' Dim Materiais As New ClsMateriais
        ' Dim ds As DataSet

        'ADICIONA NOVA LINHA NO COMBO SUBGRUPO
        Try

            'ds = Materiais.Busca_Sub_Grupo_CBO("Sp_SubGrupo_Sel", cboGrupo.SelectedValue)

            'Dim novaSGP As DataRow = ds.Tables(0).NewRow
            'novaSGP.Item("SGRDESC") = "--- Selecione o SubGrupo ---"
            'novaSGP.Item("SGRGRUPO") = "0"
            'ds.Tables(0).Rows.InsertAt(novaSGP, 0)
            'ds.Tables(0).AcceptChanges()

            ''VINCULA DATASET NO COMBO BOX
            'cboSubGrupo.DisplayMember = "SGRDESC"
            'cboSubGrupo.ValueMember = "SGRSUBGRP"
            'cboSubGrupo.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            '            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Calc_Lucro()
        Try
            Dim VCompra As Double
            Dim VVenda As Double
            Dim Vlucro As Double
            Dim VLucratividade As Double

            Double.TryParse(txtCompra.Text, VCompra)

            Double.TryParse((txtCompra.Text / txtItemPEmb.Text), VVenda)

            Double.TryParse(txtLucro.Text, Vlucro)
            Double.TryParse(txtLucratividade.Text, VLucratividade)

            VLucratividade = (VVenda * Vlucro) / 100

            'VLucratividade = (VCompra / (1 - (Vlucro / 100)))

            txtLucratividade.Text = VLucratividade ' Format((VLucratividade - VCompra), "#,##0.00")

            VVenda += VLucratividade  'Format(VLucratividade, "#,##0.00") )
            txtValor.Text = Format(VVenda, "#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtLucro_LostFocus(sender As Object, e As EventArgs) Handles txtLucro.LostFocus

        Calc_Lucro()

    End Sub
    Private Sub btoAlterar_Click(sender As Object, e As EventArgs) Handles btoAlterar.Click
        EnviaUpDate()

        ZeraTela()
        txtID.Text = ""
        txtItem.Text = ""
        txtEAN.Text = ""
        Materiais.IT_EAN = ""
        txtEAN.Focus()
    End Sub
    Private Sub opServ_CheckedChanged(sender As Object, e As EventArgs) Handles opServ.CheckedChanged
        txtISS.Enabled = True
        cboServico.Enabled = True
    End Sub
    Private Sub opMat_CheckedChanged(sender As Object, e As EventArgs) Handles opMat.CheckedChanged
        txtISS.Enabled = False
        txtISS.Text = 0
        cboServico.Enabled = False
        cboServico.SelectedValue = " "
    End Sub
    Private Sub btnCapturar_Click_1(sender As Object, e As EventArgs) Handles btnCapturar.Click
        Materiais.IT_IMAGEM = ""
        If imgItem.Image IsNot Nothing Then
            Try
                My.Computer.Audio.Play("C:\SisVet\Sistema\Imagens\Camera1.wav")
                CAMARA.Stop()
                RemoveHandler CAMARA.NewFrame, AddressOf CAMARA_NewFrame
                'salva a imagem nA PASTA
                imgItem.Image.Save("C:\SisVet\Sistema\Imagens\ImagemItemParaSalvar.png")

                Materiais.IT_IMAGEM = ClsGeral.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemItemParaSalvar.png")

                Materiais.IT_ITEM = txtItem.Text

                Materiais.UpImagemItem()

                MessageBox.Show("Imagem do item salva com sucesso ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                AddHandler CAMARA.NewFrame, AddressOf CAMARA_NewFrame
            End Try
        End If
    End Sub
    Private Sub imgItem_Click(sender As Object, e As EventArgs) Handles imgItem.Click

        If CAMARA.IsRunning Then
            CAMARA.Stop()
        Else
            CAMARA.Start()
        End If
    End Sub
    Private Sub CAMARA_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        If imgItem.Image IsNot Nothing Then
            imgItem.Image.Dispose()
        End If
        imgItem.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If CAMARA.IsRunning Then
            CAMARA.[Stop]()
        End If
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'carrega uma imagem da pasta
            Using abrir As New OpenFileDialog With {
                .Title = "Carregar uma imagem.",
                .FileName = "",
                .Filter = "Imagens PNG, JPG, JPEG e BMP|*.png; *.jpg;*.jpeg;*.bmp"}
                If abrir.ShowDialog = DialogResult.OK Then
                    imgItem.Image = Image.FromFile(abrir.FileName)

                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtItem_GotFocus(sender As Object, e As EventArgs) Handles txtItem.GotFocus
        ZeraTela()

        txtID.Text = ""
        txtItem.Text = ""
        txtEAN.Text = ""
        Materiais.IT_ITEM = ""
        Materiais.IT_EAN = ""

    End Sub


    Private Sub BuscaProd()
        PreencheDgItens()

        If txtBusca.TextLength <= 1 Then
            dgItens.DataSource = Nothing
            dgItens.Rows.Clear()
            Exit Sub
        End If

        Materiais.IT_DESC = Trim(txtBusca.Text)

        Dim dt As DataTable
        dt = Materiais.BuscaItensLike()
        dgItens.DataSource = dt

        'dgItens.Columns(0).Width = 520
        'dgItens.Columns(0).HeaderText = "Descrição do Item"
        'dgItens.Columns(1).Width = 180
        'dgItens.Columns(1).HeaderText = "ID"
        'dgItens.Columns(2).Width = 100
        'dgItens.Columns(2).HeaderText = "Código de Barras"

    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        BuscaProd()
    End Sub
    Private Sub txtEAN_LostFocus(sender As Object, e As EventArgs) Handles txtEAN.LostFocus
        If Len(Trim(txtEAN.Text)) > 2 Then
            Materiais.IT_EAN = txtEAN.Text
            Materiais.Le_Item_CB()
            If Materiais.IT_ID > 0 Then
                TransfereBaseTela()
                btoAlterar.Enabled = True
            End If
        End If

    End Sub

End Class
