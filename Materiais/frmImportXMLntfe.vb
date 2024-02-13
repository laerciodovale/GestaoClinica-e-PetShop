Imports System.Data.SqlClient
Imports System.IO
Imports System.Security
Imports System.Xml
Imports DataBase
'Imports MySql.Data.MySqlClient

Public Class frmImportXMLntfe
    Private OpenFileDialog1 As OpenFileDialog
    Private a_arqListAs() As String
    Private arq_opem As String

    Private Materiais As New Cls_Materiais
    Private Geral As New Utils
    Private CtaPg As New Cls_Financeiro
    Public CaminhoArquivo As String
    'Public Sub New()
    '    OpenFileDialog1 = New OpenFileDialog
    '    'SecurityException = New Exception
    '    ' Me.OpenFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
    '    Me.OpenFileDialog1.Filter = "XML ( *.XML)|*.XML"
    '    ' Allow the user to select multiple images.
    '    Me.OpenFileDialog1.Multiselect = True
    '    Me.OpenFileDialog1.Title = "ARQUIVOS XML."
    'End Sub

    Public Function arqList() As String()
        OpenFileDialog1 = New OpenFileDialog
        'SecurityException = New Exception
        ' Me.OpenFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        Me.OpenFileDialog1.Filter = "XML ( *.XML)|*.XML"
        ' Allow the user to select multiple images.
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "ARQUIVOS XML."

        Dim I As Long
        Dim File As String
        Dim dr As DialogResult = Me.OpenFileDialog1.ShowDialog()
        I = 0
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            ' Read the files

            For Each File In OpenFileDialog1.FileNames
                ' Create a PictureBox for each file, and add that file to the FlowLayoutPanel.
                Try
                    If Not File = "" Then
                        ReDim Preserve a_arqListAs(I)
                        a_arqListAs(I) = File
                        arq_opem = File
                        ''   frmImportXMLntfe.CaminhoArquivo = File

                        I = I + 1
                    End If
                Catch SecEx As SecurityException
                    ' The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" &
                         "Mensagem : " & SecEx.Message & "\n\n" &
                        "Detalhes (enviar ao suporte):\n\n" & SecEx.StackTrace)
                Catch ex As Exception
                    ' Could not load the image - probably permissions-related.
                    MessageBox.Show(("Não é possível exibir a imagem : " & File.Substring(File.LastIndexOf("\"c)) &
                    ". Você pode não ter permissão para ler o arquivo , ou " + "ele pode estar corrompido" _
                    & ControlChars.Lf & ControlChars.Lf & "Erro reportado: " & ex.Message))
                End Try
            Next File
        End If
        Return a_arqListAs
    End Function

    Private Sub LimparForm(ByVal controlP As Control)

        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is ComboBox Then
                DirectCast(ctl, ComboBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = "" 'String.Empty

            ElseIf TypeOf ctl Is CheckBox Then
                DirectCast(ctl, CheckBox).Checked = False

            ElseIf TypeOf ctl Is ProgressBar Then
                DirectCast(ctl, ProgressBar).Value = 0

            ElseIf ctl.Controls.Count > 0 Then
                LimparForm(ctl)
            End If
        Next


        lst.Items.Clear()
        lstCob.Items.Clear()
        lblCnpj.Text = ""
        lblNroNota.Text = ""
        lblDataNtf.Text = ""
        lblID.Text = ""
        lblIE.Text = ""
        lblIM.Text = ""
        lblRazao.Text = ""
        lblFantazia.Text = ""
        lblEnd.Text = ""
        lblNro.Text = ""
        lblCompl.Text = ""
        lblBairro.Text = ""
        lblCidade.Text = ""
        lblUf.Text = ""
        lblCEP.Text = ""
        lblFone.Text = ""
        lblFone.Text = ""
    End Sub
    Private Sub Teste_Gr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Teste_Gr.Click
        Call Me.LimparForm(Me)

        Dim Teste As Object
        Dim oItens As New Itens
        Dim oList As Object
        Dim Item As Item
        Dim ListaArquivos As OpenFileDialog
        Dim Emitente = False

        Teste = arqList()  ' ListaArquivos.arqList()

        Using MeuXML = XmlReader.Create(OpenFileDialog1.FileName) ''(CaminhoArquivo)

            With MeuXML
                While .Read()
                    '-----cabecalho

                    If .NodeType = XmlNodeType.Element And .Name = "nNF" Then
                        lblNroNota.Text = .ReadElementString()
                        lblFatura.Text = lblNroNota.Text
                    End If

                    If .NodeType = XmlNodeType.Element And .Name = "dhEmi" Then
                        lblDataNtf.Text = .ReadElementString()
                        lblDataNtf.Text = Mid(lblDataNtf.Text, 1, 10)

                    End If

                    If .NodeType = XmlNodeType.Element And .Name = "emit" Then
                        Emitente = True
                    ElseIf .NodeType = XmlNodeType.Element And .Name = "dest" Then
                        Exit While
                    End If

                    If Emitente Then
                        If .NodeType = XmlNodeType.Element And .Name = "CNPJ" Then
                            lblCnpj.Text = .ReadElementString()
                        End If

                        If .NodeType = XmlNodeType.Element And .Name = "xFant" Then
                            lblFantazia.Text = .ReadElementString()
                        End If

                        If .NodeType = XmlNodeType.Element And .Name = "xNome" Then
                            lblRazao.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "xLgr" Then
                            lblEnd.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "nro" Then
                            lblNro.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "xCpl" Then
                            lblCompl.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "xBairro" Then
                            lblBairro.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "xMun" Then
                            lblCidade.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "UF" Then
                            lblUf.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "CEP" Then
                            lblCEP.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "IE" Then
                            lblIE.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "IM" Then
                            lblIM.Text = .ReadElementString()
                        End If
                        If .NodeType = XmlNodeType.Element And .Name = "fone" Then
                            lblFone.Text = .ReadElementString()
                        End If

                        '' Console.Beep()

                    End If

                    '-----rodape
                    If .NodeType = XmlNodeType.Element And .Name = "vNF" Then
                        lblValorTotal.Text = .ReadElementString()
                    End If

                End While

            End With
        End Using

        ''' leitura dos ITENS E COBRANCA

        Dim I As Long, II As Long
        II = 0
        I = 0

        For Each File In Teste

            oList = oItens.fncCaminho_XML(File)

            For Each Item In oList

                lst.Items.Add(New ListViewItem(New String() {Item.cProd, Item.xProd, Item.cEAN, Item.NCM, Item.CEST, Item.CFOP, Item.uCom, Item.qCom, Item.vUnCom, Item.vProd,
                                               Item.cEANTrib, Item.uTrib, Item.qTrib, Item.vUnTrib,
                                               Item.nLote, Item.qLote, Item.dFab, Item.dVal, Item.vvICMS, Item.vPis, Item.vCOFINS, Item.vANVISA}))
                I = I + 1
                Me.lb_tItem.Text = I

            Next
            II = II + 1
            Me.lb_tArq.Text = II
            lst.Items(lst.Items.Count - 1).EnsureVisible()
            Application.DoEvents()
        Next

        Dim x As Integer
        For x = 0 To (lst.Items.Count - 1)
            Materiais.IT_ID = 0
            Materiais.IT_ITEM = lst.Items.Item(x).Text
            Materiais.Le_Item()
            If Materiais.IT_ID = 0 Then
                lst.Items.Item(X).ForeColor = Color.Red
            End If

        Next


        II = 0
        I = 0

        For Each File In Teste


            oList = oItens.fncCobranca_XML(File)
            If oList IsNot Nothing Then


                For Each Item In oList

                    lstCob.Items.Add(New ListViewItem(New String() {Item.vnDup, Item.vVenc, Item.vDup}))

                Next

                lstCob.Items(lstCob.Items.Count - 1).EnsureVisible()
                Application.DoEvents()
            End If
        Next

        '' VERIFICA SE nota ja foi lançada
        Materiais.F_CGC = lblCnpj.Text
        Materiais.Le_Fornecedor()
        If Materiais.F_SEQ > 0 Then

            Materiais.ET_SOLIC = lblNroNota.Text
            Materiais.ET_FORNEC = Materiais.F_SEQ

            Materiais.BuscaNotaFiscal()

            If Materiais.ET_SEQ > 0 Then
                MessageBox.Show("Fornecedor e Nota fiscal " & vbCr &
                            "consta como lançada.", "Lançamento de Nota Fiscal.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ''      Call Me.LimparForm(Me)
            End If

        End If


    End Sub

    Sub Formatar_List()

        lst.View = View.Details
        lst.AllowColumnReorder = True
        lst.GridLines = True
        lst.Columns.Add("Codigo", 100, HorizontalAlignment.Left)
        lst.Columns.Add("Descrição", 250, HorizontalAlignment.Left)
        lst.Columns.Add("cEAN ", 80, HorizontalAlignment.Left)
        lst.Columns.Add("NCM", 75, HorizontalAlignment.Left)
        lst.Columns.Add("CEST", 75, HorizontalAlignment.Left)
        lst.Columns.Add("CFOP", 60, HorizontalAlignment.Left)
        lst.Columns.Add("uCom", 60, HorizontalAlignment.Left)
        lst.Columns.Add("qCom", 60, HorizontalAlignment.Left)
        lst.Columns.Add("vUnCom", 80, HorizontalAlignment.Left)
        lst.Columns.Add("vProd", 80, HorizontalAlignment.Left)
        lst.Columns.Add("cEANTrib", 100, HorizontalAlignment.Left)
        lst.Columns.Add("uTrib", 50, HorizontalAlignment.Left)
        lst.Columns.Add("qTrib", 50, HorizontalAlignment.Left)
        lst.Columns.Add("vUnTrib", 80, HorizontalAlignment.Left)

        lst.Columns.Add("nLote", 80, HorizontalAlignment.Left)
        lst.Columns.Add("qLote", 50, HorizontalAlignment.Left)
        lst.Columns.Add("dFab", 80, HorizontalAlignment.Left)
        lst.Columns.Add("dVal", 80, HorizontalAlignment.Left)

        lst.Columns.Add("ICMS", 50, HorizontalAlignment.Left)
        lst.Columns.Add("Pis", 50, HorizontalAlignment.Left)
        lst.Columns.Add("COFINS", 50, HorizontalAlignment.Left)
        lst.Columns.Add("ANVISA", 90, HorizontalAlignment.Left)

        lstCob.View = View.Details
        lstCob.AllowColumnReorder = True
        lstCob.GridLines = True
        lstCob.Columns.Add("Dupl", 35, HorizontalAlignment.Left)
        lstCob.Columns.Add("Vencimento", 80, HorizontalAlignment.Left)
        lstCob.Columns.Add("Valor ", 80, HorizontalAlignment.Left)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Formatar_List()
    End Sub
    Sub PlaySystemSoundAsterisk()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
    End Sub
    Private Sub bt_Limpar_Click(sender As Object, e As EventArgs) Handles bt_Limpar.Click
        Console.Beep()
        ' PlaySystemSoundAsterisk()

        lst.Clear()
        lstCob.Clear()

        Formatar_List()
    End Sub
    Private Sub EnviarInsert()
        Try

            Dim RETORNO As Integer
            Dim DataAccess As New DataAcces
            Dim PAR As List(Of SqlParameter)

            '''adiciona os parametros
            PAR = New List(Of SqlParameter)
            PAR.Add(New SqlParameter("F_CGC", lblCnpj.Text))
            PAR.Add(New SqlParameter("F_IE", lblIE.Text))
            PAR.Add(New SqlParameter("F_IM", lblIM.Text))
            PAR.Add(New SqlParameter("F_RAZAO", lblRazao.Text))
            PAR.Add(New SqlParameter("F_FANTASIA", lblFantazia.Text))
            PAR.Add(New SqlParameter("F_END", lblEnd.Text))
            PAR.Add(New SqlParameter("F_NRO", lblNro.Text))
            PAR.Add(New SqlParameter("F_COMPLE", lblCompl.Text))
            PAR.Add(New SqlParameter("F_CIDADE", lblCidade.Text))
            PAR.Add(New SqlParameter("F_BAIRRO", lblBairro.Text))
            PAR.Add(New SqlParameter("F_UF", lblUf.Text))
            PAR.Add(New SqlParameter("F_CEP", lblCEP.Text))
            PAR.Add(New SqlParameter("F_CONTATO", " "))
            PAR.Add(New SqlParameter("F_DDD", Mid(lblFone.Text, 1, 2)))
            PAR.Add(New SqlParameter("F_FONE", Mid(lblFone.Text, 3)))
            PAR.Add(New SqlParameter("F_DDDFAX", 65))
            PAR.Add(New SqlParameter("F_FAX", " "))
            PAR.Add(New SqlParameter("F_HTTP", " "))
            PAR.Add(New SqlParameter("F_MAIL", " "))
            PAR.Add(New SqlParameter("F_DTREG", Now))
            PAR.Add(New SqlParameter("F_DTULTCOM", Now))

            'EXECUTA A PROCEDURE
            RETORNO = DataAccess.ExecuteStoreProcedureIncremento("SP_FORNECEDOR_INSERT", PAR)
            Materiais.F_SEQ = RETORNO

            'FECHA A CONEXAO
            DataAccess.CloseConn()

            'RETORNO O RESULTADO
            'Return RETORNO 'DataAccess.AutoIncre


        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
    Private Sub EnviarItem()


        Try

            Dim RETORNO As Integer
            Dim DataAccess As New DataAcces
            Dim PAR As List(Of SqlParameter)

            ''adiciona os parametros
            PAR = New List(Of SqlParameter)
            PAR.Add(New SqlParameter("IT_SEGMENTO", 1))
            PAR.Add(New SqlParameter("IT_GRUPO", 1))
            PAR.Add(New SqlParameter("IT_SUBGRP", 1))
            PAR.Add(New SqlParameter("IT_ITEM", Materiais.IT_ITEM))
            PAR.Add(New SqlParameter("IT_TIPO", "M"))
            PAR.Add(New SqlParameter("IT_UNID", Materiais.IT_UNID))
            PAR.Add(New SqlParameter("IT_DESC", Materiais.IT_DESC))
            PAR.Add(New SqlParameter("IT_ESTQMIN", 1))
            PAR.Add(New SqlParameter("IT_ESTQMAX", 0))
            PAR.Add(New SqlParameter("IT_COMPRA", Materiais.IT_COMPRA))
            PAR.Add(New SqlParameter("it_qtdemb", Materiais.IT_QTDEMB))
            PAR.Add(New SqlParameter("IT_LUCRO", 50))
            PAR.Add(New SqlParameter("IT_VLUCRO", Materiais.IT_VLUCRO))
            PAR.Add(New SqlParameter("IT_VENDA", Materiais.IT_VENDA))
            PAR.Add(New SqlParameter("IT_DCTO", 0))
            PAR.Add(New SqlParameter("IT_SALDO", Materiais.ET_QTDE))
            PAR.Add(New SqlParameter("IT_COMISSAO", 3))
            PAR.Add(New SqlParameter("IT_CONVENIO", 1))
            PAR.Add(New SqlParameter("IT_PROMO", False))
            PAR.Add(New SqlParameter("IT_ATIVO", True))
            PAR.Add(New SqlParameter("IT_CNAE", Materiais.IT_CNAE))
            PAR.Add(New SqlParameter("IT_NCM", Materiais.IT_NCM))
            PAR.Add(New SqlParameter("IT_CEST", Materiais.IT_CEST))
            PAR.Add(New SqlParameter("IT_CST", " "))
            PAR.Add(New SqlParameter("IT_CFOP", Materiais.IT_CFOP))
            PAR.Add(New SqlParameter("IT_ALQICMS", Materiais.IT_ALQICMS))
            PAR.Add(New SqlParameter("IT_ALQPIS", Materiais.IT_ALQPIS))
            PAR.Add(New SqlParameter("IT_ALQCOFINS", Materiais.IT_ALQCOFINS))
            PAR.Add(New SqlParameter("IT_ALQISS", 0))
            PAR.Add(New SqlParameter("IT_IMAGEM", Materiais.IT_IMAGEM))
            PAR.Add(New SqlParameter("IT_EAN", Materiais.IT_EAN))
            PAR.Add(New SqlParameter("IT_LISTSERV", " "))
            PAR.Add(New SqlParameter("IT_ANVISA", Materiais.IT_ANVISA))

            'EXECUTA A PROCEDURE
            RETORNO = DataAccess.ExecuteStoreProcedureIncremento("SP_ITENS_INSERT_ID", PAR)
            Materiais.IT_ID = RETORNO
            'FECHA A CONEXAO
            DataAccess.CloseConn()

        Catch ex As Exception
            MessageBox.Show("Ocorreu o erro : " & vbNewLine & ex.Message, " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try

    End Sub
    Private Sub Calc_Lucro()
        Try
            Dim VCompra As Double
            Dim VVenda As Double
            Dim Vlucro As Double
            Dim VLucratividade As Double

            Double.TryParse(Materiais.IT_COMPRA, VCompra)
            Double.TryParse(0, VVenda)
            Double.TryParse(102, Vlucro)
            Double.TryParse(0, VLucratividade)
            Materiais.IT_VENDA = 0

            VLucratividade = (VCompra * Vlucro) / 100

            Materiais.IT_VENDA = Format((VCompra + VLucratividade), "0.00")



            ''VLucratividade = (VCompra / (1 - (Vlucro / 100)))

            Materiais.IT_VLUCRO = VLucratividade '' Format((VLucratividade - VCompra), "#,##0.00")

            ' Materiais.IT_VENDA = Format(VLucratividade, "#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btoImportar_Click(sender As Object, e As EventArgs) Handles btoImportar.Click

        If lst.Items.Count = 0 Then

            MessageBox.Show("Nota Fiscal não carregada." & vbCr & "Processo cancelado.", "Importação de NTFe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim x As Integer

        'cabecalho
        Materiais.ET_SOLIC = lblNroNota.Text
        Materiais.ET_OC = lblNroNota.Text

        '' VERIFICA SE EXISTE FORNECEDOR
        Materiais.F_CGC = lblCnpj.Text
        Materiais.F_SEQ = 0
        Materiais.Le_Fornecedor()

        If Materiais.F_SEQ = 0 Then
            EnviarInsert()
        Else
            Materiais.ET_FORNEC = Materiais.F_SEQ
        End If

        For x = 0 To (lst.Items.Count - 1)
            Materiais.IT_EAN = lst.Items.Item(x).SubItems.Item(2).Text ' cean

            If IsNumeric(Materiais.IT_EAN) = True Then
                Materiais.ET_ITEM = Materiais.IT_EAN
            Else
                Materiais.ET_ITEM = lst.Items.Item(x).SubItems.Item(0).Text 'codigo
            End If

            If Len(Trim(lst.Items.Item(x).SubItems.Item(0).Text)) > 0 Then
                Materiais.IT_ITEM = lst.Items.Item(x).SubItems.Item(0).Text 'codigo
                Materiais.IT_DESC = lst.Items.Item(x).SubItems.Item(1).Text 'descricao
                Materiais.IT_EAN = lst.Items.Item(x).SubItems.Item(2).Text ' cean
                Materiais.IT_NCM = lst.Items.Item(x).SubItems.Item(3).Text 'ncm
                Materiais.IT_CEST = lst.Items.Item(x).SubItems.Item(4).Text 'CEST
                Materiais.IT_CFOP = lst.Items.Item(x).SubItems.Item(5).Text 'cfpop
                Materiais.IT_CNAE = 0
                Materiais.IT_CST = 0
                Materiais.IT_UNID = lst.Items.Item(x).SubItems.Item(6).Text 'ucom
                Materiais.ET_QTDE = lst.Items.Item(x).SubItems.Item(7).Text 'qcom
                Materiais.IT_SALDO = lst.Items.Item(x).SubItems.Item(7).Text
                Materiais.ET_QTDS = 0
                Materiais.IT_COMPRA = lst.Items.Item(x).SubItems.Item(8).Text 'vuncom
                Materiais.IT_QTDEMB = 1

                Materiais.ET_VALOR = lst.Items.Item(x).SubItems.Item(9).Text 'vprod
                Materiais.ET_VLRS = 0

                '' LOTE
                Materiais.ET_NLOTE = lst.Items.Item(x).SubItems.Item(14).Text 'nlote
                'Materiais.ET_QLOTE = lst.Items.Item(x).SubItems.Item(14).Text 'qlote
                'Materiais.ET_DTFABR = lst.Items.Item(x).SubItems.Item(15).Text 'dfab
                'Materiais.ET_DTVAL = lst.Items.Item(x).SubItems.Item(16).Text 'dval
                ''ÍMPOSTO
                Materiais.IT_ALQICMS = lst.Items.Item(x).SubItems.Item(18).Text
                Materiais.IT_ALQPIS = lst.Items.Item(x).SubItems.Item(19).Text
                Materiais.IT_ALQCOFINS = lst.Items.Item(x).SubItems.Item(20).Text
                Materiais.IT_ANVISA = lst.Items.Item(x).SubItems.Item(21).Text

                '' VERIFICA SE EXISTE O ITEM
                Materiais.IT_ID = 0

                Materiais.Le_Item()
                Calc_Lucro()
                Dim clsgeral As New Utils
                imgItem.Image = Image.FromFile("C:\SisVet\Sistema\Imagens\sem-foto.jpg")
                imgItem.Image.Save("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")
                Materiais.IT_IMAGEM = clsgeral.ArquivoParaBase64("C:\SisVet\Sistema\Imagens\ImagemParaSalvar.png")

                If Materiais.IT_ID = 0 Then

                    EnviarItem()
                    '' MsgBox("ITEM : " & x & " " & Materiais.IT_DESC & " INCLUIDO COM SUCESSO." & vbCr & vbCr _
                    ''      & "FAVOR VERIFICAR VALOR DE VENDA. ", MsgBoxStyle.Information)

                    lst.Items.Item(x).ForeColor = Color.Red

                End If
                '' enviar para o estoque
                Materiais.GravarEstoque()
            End If
        Next

        Try

            IncluiCobranca()
            MsgBox("Cobrança : " & lblFatura.Text & " INCLUIDA COM SUCESSO.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Ocorreu o erro no envio da Cobrança : " & lblFatura.Text, ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub
    Private Sub IncluiCobranca()
        Dim x As Integer
        Dim RETORNO As Integer
        Dim DataAccess As DataAcces
        Dim PAR As List(Of SqlParameter)

        DataAccess = New DataAcces
        '' incluir  cobranca
        With CtaPg
            For x = 0 To (lstCob.Items.Count - 1)

                .CT_DUPL = lstCob.Items.Item(x).SubItems.Item(0).Text
                .CT_DTVCTO = Format(lstCob.Items.Item(x).SubItems.Item(1).Text, "short Date")
                .CT_VALOR = lstCob.Items.Item(x).SubItems.Item(2).Text

                ''adiciona os parametros
                PAR = New List(Of SqlParameter)
                PAR.Add(New SqlParameter("@CT_DTREF", Format(Now, "yyyy-MM-dd")))
                PAR.Add(New SqlParameter("@CT_FORNEC", lblCnpj.Text))
                PAR.Add(New SqlParameter("@CT_OC", lblNroNota.Text))
                PAR.Add(New SqlParameter("@CT_NF", lblNroNota.Text))
                PAR.Add(New SqlParameter("@CT_DTNF", lblDataNtf.Text))

                PAR.Add(New SqlParameter("@CT_DUPL", .CT_DUPL))
                PAR.Add(New SqlParameter("@CT_FATURA", lblFatura.Text))
                PAR.Add(New SqlParameter("@CT_DTVCTO", Format(CtaPg.CT_DTVCTO, "yyyy-MM-dd")))
                PAR.Add(New SqlParameter("@CT_VALOR", .CT_VALOR))
                PAR.Add(New SqlParameter("@CT_DTPAGTO", Now))
                PAR.Add(New SqlParameter("@CT_VALORP", 0))
                PAR.Add(New SqlParameter("@CT_DOCPG", 0))

                'EXECUTA A PROCEDURE
                RETORNO = DataAccess.ExecuteStoreProcedureIncremento("SP_CTAPG_INSERT", PAR)
                CtaPg.CT_ID = RETORNO
                'FECHA A CONEXAO

            Next
        End With

        DataAccess.CloseConn()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
