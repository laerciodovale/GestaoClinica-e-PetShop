Imports System.Data.SqlClient

Public Class Cls_Materiais
    ''propriedades
    Public id_Item As Integer
    ''CADITENS
    Public IT_ID As Integer
    Public IT_SEGMENTO As Integer
    Public IT_GRUPO As Integer
    Public IT_SUBGRP As Integer
    Public IT_ITEM As String
    Public IT_TIPO As String
    Public IT_UNID As String
    Public IT_DESC As String
    Public IT_ESTQMIN As Double
    Public IT_ESTQMAX As Double
    Public IT_COMPRA As Double
    Public IT_DCTO As Double
    Public IT_LUCRO As Double
    Public IT_VLUCRO As Double
    Public IT_VENDA As Double
    Public IT_SALDO As Double
    Public IT_COMISSAO As Double
    Public IT_CONVENIO As Integer
    Public IT_PROMO As Boolean
    Public IT_ATIVO As Boolean
    Public IT_CNAE As String
    Public IT_NCM As String
    Public IT_CEST As String
    Public IT_CST As String
    Public IT_CFOP As String
    Public IT_ALQICMS As Double
    Public IT_ALQPIS As Double
    Public IT_ALQISS As Double
    Public IT_ALQCOFINS As Double
    Public IT_QTDEMB As Integer
    Public Property IT_IMAGEM() As String
    Public IT_LISTSERV As String
    Public IT_ANVISA As String
    Public IT_EAN As String
    Public IT_LOTE As String

    ''FINANCEIRO ANALITICO
    Public Fa_Seq As Integer
    Public Fa_Cli As Integer
    Public Fa_Ani As Integer
    Public Fa_NssNro As Integer
    Public Fa_Ev As String
    Public Fa_Desc As String
    Public Fa_Qtd As Double
    Public Fa_VlrU As Double
    Public Fa_Dcto As Double
    Public Fa_Vlr As Double
    Public Fa_Func As Integer
    Public Fa_Dt As Date
    Public Fa_VlrAd As Double
    Public Fa_NssPai As Integer
    Public Fi_VlrPgto As Double
    '' FORNECEDOR

    Public F_SEQ As Integer
    Public F_CGC As String
    Public F_IE As String
    Public F_IM As String
    Public F_RAZAO As String
    Public F_FANTASIA As String
    Public F_END As String
    Public F_NRO As String
    Public F_COMPLE As String
    Public F_CIDADE As String
    Public F_BAIRRO As String
    Public F_UF As String
    Public F_CEP As String
    Public F_CONTATO As String

    Public F_DDD As Integer
    Public F_TEL As String

    Public F_DDDFAX As Integer
    Public F_FAX As String
    Public F_HTTP As String
    Public F_MAIL As String

    Public F_DTREG As Date
    Public F_DTULTCOM As Date

    '    '' CADGRUPO
    Public GR_GRUPO As Integer
    Public GR_DESC As String
    Public GR_DCTO As Integer
    '' estoque
    Public ET_SEQ As Integer
    Public ET_ITEM As String
    Public ET_DTREF As Date
    Public ET_SOLIC As Integer
    Public ET_HRREF As DateTime
    Public ET_OC As Integer
    Public ET_QTDE As Double
    Public ET_VALOR As Double
    Public ET_QTDS As Double
    Public ET_VLRS As Double
    Public ET_CLIENTE As Integer
    Public ET_FORNEC As Integer
    Public ET_EMPRESA As Integer
    Public ET_NLOTE As String

    Public Saldo_Estq As Double

    ''LOTE DO ITEM (RASTEIO)
    Public Lt_id As Integer
    Public LT_ITEM As String
    Public LT_FORNEC As Integer
    Public LT_LOTE As String
    Public LT_NF As Integer
    Public LT_DTNF As Date
    Public LT_QTD As Double
    Public LT_VCTO As Date
    Public LT_DTFABR As Date

    '' nota fiscal
    Public Valor_NTFe As Double
    Public Nro_Lote_NFTe As Integer
    Public Nro_Nota_NFTe As Integer

    Public Function Busca_DataTable(ByVal procedure As String) As DataTable

        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(procedure, Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try


    End Function
    Public Function BuscaLista(ByVal procedure As String) As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Fa_Cli", Fa_Cli))
            Parametro.Add(New SqlParameter("Fa_Ani", Fa_Ani))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(procedure, Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaListaPdv(ByVal procedure As String) As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Fa_NssPai", Fa_NssPai))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(procedure, Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaSomaOSPDV()

        Dim retorno As Double
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("Fa_NssPai", Fa_NssPai))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_FinA_LeLista_pdv_SOMA", Parametro)
        '' preencher as propriedades
        While dr.Read
            retorno = dr("TOTAL")
        End While

        banco.CloseConn()

    End Function

    Public Function Busca_DataSet(ByVal procedure As String) As DataSet

        Dim retornoDataSet As New DataSet
        Dim Ds As New DataSet
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Try
            Parametro = New List(Of SqlParameter)
            'EXECUTA O COMANDO
            Ds = banco.ExecutaStoreProcedureDataSet(procedure, Parametro)
            Return Ds

            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Public Function BuscaItens() As Object
    '    Dim Parametro As List(Of SqlParameter)
    '    Dim banco As New DataAcces
    '    Dim tabela As DataTable
    '    Try
    '        '' INSTANCIAR A CLASSE DO BANCO
    '        'banco = New DataAcces
    '        '' ADICIONA OS PARAMETROS
    '        Parametro = New List(Of SqlParameter)

    '        ' EXCUTA A PROCEDURE
    '        tabela = banco.ExecutaDataTable("Sp_Itens_Busca", Parametro)
    '        Return tabela
    '        ''FECHA A CONEXAO
    '        banco.CloseConn()

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function
    Public Function BuscaItensLike()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@NomeLike", IT_DESC))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Itens_Like", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaItensCB()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ITEAN", IT_EAN))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Itens_CB", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function BuscaItensDoGrupo()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Grupo", IT_GRUPO))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Itens_DoGrupo", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function DeletaItem()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim Ds As DataSet
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Fa_Seq", Fa_Seq))
            ' EXCUTA A PROCEDURE
            Ds = banco.ExecutaStoreProcedureDataSet("Sp_FinA_DeletaItemDaLista", Parametro)
            '
            Return Ds
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Le_Item()

        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Item", IT_ITEM))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Itens_LeItem", Parametro)
        '' preencher as propriedades
        While dr.Read
            IT_ID = dr("ITID")
            IT_SEGMENTO = dr("ITSEGMENTO")
            IT_GRUPO = dr("ITGRUPO")
            IT_SUBGRP = dr("ITSUBGRP")
            ''IT_ITEM = dr("ITITEM")
            IT_TIPO = dr("ITTIPO")
            IT_UNID = dr("ITUNID")
            IT_DESC = dr("ITDESC")
            IT_ESTQMIN = dr("ITESTQMIN")
            IT_ESTQMAX = dr("ITESTQMAX")
            IT_COMPRA = dr("ITCOMPRA")
            IT_DCTO = dr("ITDCTO")
            IT_LUCRO = dr("ITLUCRO")
            IT_VLUCRO = dr("ITVLUCRO")
            IT_VENDA = dr("ITVENDA")
            IT_SALDO = dr("ITSALDO")
            IT_COMISSAO = dr("ITCOMISSAO")
            IT_CONVENIO = dr("ITCONVENIO")
            IT_PROMO = dr("ITPROMO")
            IT_ATIVO = dr("ITATIVO")
            IT_CNAE = dr("ITCNAE")
            IT_NCM = dr("ITNCM")
            IT_CEST = dr("ITCEST")
            IT_CST = dr("ITCST")
            IT_CFOP = dr("ITCFOP")
            IT_ALQICMS = dr("ITALQICMS")
            IT_ALQPIS = dr("ITALQPIS")
            IT_ALQCOFINS = dr("ITALQCOFINS")
            IT_ALQISS = dr("ITALQISS")
            If IsDBNull(dr("ITIMAGEM")) = False Then
                IT_IMAGEM = dr("ITIMAGEM")
            End If

            IT_EAN = dr("ITEAN")
            IT_LISTSERV = dr("ITLISTSERV")
            IT_ANVISA = dr("ITANVISA")
            IT_QTDEMB = dr("ITQTDEMB")
            retorno = True
        End While

        banco.CloseConn()

    End Function
    Public Function Le_Item_CB()

        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@itean", IT_EAN))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Itens_LeItem_CB", Parametro)
        '' preencher as propriedades
        While dr.Read
            IT_ID = dr("ITID")
            IT_SEGMENTO = dr("ITSEGMENTO")
            IT_GRUPO = dr("ITGRUPO")
            IT_SUBGRP = dr("ITSUBGRP")
            IT_ITEM = dr("ITITEM")
            IT_TIPO = dr("ITTIPO")
            IT_UNID = dr("ITUNID")
            IT_DESC = dr("ITDESC")
            IT_ESTQMIN = dr("ITESTQMIN")
            IT_ESTQMAX = dr("ITESTQMAX")
            IT_COMPRA = dr("ITCOMPRA")
            IT_DCTO = dr("ITDCTO")
            IT_LUCRO = dr("ITLUCRO")
            IT_VLUCRO = dr("ITVLUCRO")
            IT_VENDA = dr("ITVENDA")
            IT_SALDO = dr("ITSALDO")
            IT_COMISSAO = dr("ITCOMISSAO")
            IT_CONVENIO = dr("ITCONVENIO")
            IT_PROMO = dr("ITPROMO")
            IT_ATIVO = dr("ITATIVO")
            IT_CNAE = dr("ITCNAE")
            IT_NCM = dr("ITNCM")
            IT_CEST = dr("ITCEST")
            IT_CST = dr("ITCST")
            IT_CFOP = dr("ITCFOP")
            IT_ALQICMS = dr("ITALQICMS")
            IT_ALQPIS = dr("ITALQPIS")
            IT_ALQCOFINS = dr("ITALQCOFINS")
            IT_ALQISS = dr("ITALQISS")

            IT_IMAGEM = dr("ITIMAGEM")

            IT_EAN = dr("ITEAN")
            IT_LISTSERV = dr("ITLISTSERV")
            IT_ANVISA = dr("ITANVISA")
            IT_QTDEMB = dr("ITQTDEMB")
            retorno = True
        End While

        banco.CloseConn()

    End Function

    Public Function InsertLista() As Object

        Dim RETORNO As Integer
        Dim banco As DataAcces
        Dim PAR As List(Of SqlParameter)

        banco = New DataAcces

        ''adiciona os parametros
        PAR = New List(Of SqlParameter)
        PAR.Add(New SqlParameter("FaCli", Fa_Cli))
        PAR.Add(New SqlParameter("FaAni", Fa_Ani))
        PAR.Add(New SqlParameter("FaNssNro", Fa_NssNro))
        PAR.Add(New SqlParameter("FaEv", Fa_Ev))
        PAR.Add(New SqlParameter("FaDesc", Fa_Desc))
        PAR.Add(New SqlParameter("FaQtd", Fa_Qtd))
        PAR.Add(New SqlParameter("FaVlrU", Fa_VlrU))
        PAR.Add(New SqlParameter("FaDcto", Fa_Dcto))
        PAR.Add(New SqlParameter("FaVlr", Fa_Vlr))
        PAR.Add(New SqlParameter("FaFunc", Fa_Func))
        PAR.Add(New SqlParameter("FaDt", Fa_Dt))
        PAR.Add(New SqlParameter("FaVlrAd", Fa_VlrAd))
        PAR.Add(New SqlParameter("FaNssPai", Fa_NssPai))
        'EXECUTA A PROCEDURE
        RETORNO = banco.ExecuteStoreProcedureIncremento("Sp_FinA_Insert", PAR)
        Fa_Seq = RETORNO

        'FECHA A CONEXAO
        banco.CloseConn()

    End Function

    Public Function UpLista()

        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@FaNssNro", Fa_NssNro))
        Parametro.Add(New SqlParameter("@FaCli", Fa_Cli))
        Parametro.Add(New SqlParameter("@FaAni", Fa_Ani))
        ' Parametro.Add(New SqlParameter("Fa_Ev", Fa_Ev))

        ' EXCUTA A PROCEDURE
        retorno = banco.ExecuteStoreProcedure("Sp_FinA_UpLista", Parametro)

        banco.CloseConn()
    End Function
    Public Function GravarEstoque()
        Dim x As Integer
        Dim RETORNO As Integer
        Dim banco As DataAcces
        Dim PAR As List(Of SqlParameter)

        banco = New DataAcces

        ''adiciona os parametros
        PAR = New List(Of SqlParameter)
        PAR.Add(New SqlParameter("ET_item", ET_ITEM))
        PAR.Add(New SqlParameter("ET_DTREF", Now)) ' ET_DTREF))
        PAR.Add(New SqlParameter("ET_HRREF", FormatDateTime(TimeOfDay)))
        PAR.Add(New SqlParameter("ET_SOLIC", ET_SOLIC))
        PAR.Add(New SqlParameter("ET_OC", ET_OC))
        PAR.Add(New SqlParameter("ET_QTDE", ET_QTDE))
        PAR.Add(New SqlParameter("ET_VALOR", ET_VALOR))
        PAR.Add(New SqlParameter("ET_QTDS", ET_QTDS))
        PAR.Add(New SqlParameter("ET_VLRS", ET_VLRS))
        PAR.Add(New SqlParameter("ET_CLIENTE", ET_CLIENTE))
        PAR.Add(New SqlParameter("ET_FORNEC", ET_FORNEC))
        PAR.Add(New SqlParameter("ET_EMPRESA", ET_EMPRESA))
        PAR.Add(New SqlParameter("ET_NLOTE", ET_NLOTE))

        'EXECUTA A PROCEDURE
        RETORNO = banco.ExecuteStoreProcedureIncremento("SP_Estoque_INSERT", PAR)
        ET_SEQ = RETORNO

        'EXECUTA A PROCEDURE para saldo do Estoque
        Dim PAR_Soma As New List(Of SqlParameter)

        'PAR_Soma.Add(New SqlParameter("@ET_item", ET_ITEM))
        'RETORNO = banco.ExecuteStoreProcedureIncremento("SP_Estoque_Sum", PAR_Soma)
        'Saldo_Estq = RETORNO

        'FECHA A CONEXAO
        banco.CloseConn()

    End Function
    Public Function Busca_Grupo()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            'Parametro.Add(New SqlParameter("Grupo", IT_GRUPO))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Grupo_Sel", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Busca_Grupo_CBO(ByVal procedure As String) As DataSet

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim Ds As DataSet
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            ' banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            ' EXCUTA A PROCEDURE
            Ds = banco.ExecutaStoreProcedureDataSet(procedure, Parametro)
            '
            Return Ds
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Segmento_CBO(ByVal procedure As String, ByVal GRUPO As Integer) As DataSet

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim Ds As DataSet
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            ' EXCUTA A PROCEDURE
            Ds = banco.ExecutaStoreProcedureDataSet(procedure, Parametro)
            '
            Return Ds
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Busca_Sub_Grupo_CBO(ByVal procedure As String, ByVal GRUPO As Integer) As DataSet

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim Ds As DataSet
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            ' EXCUTA A PROCEDURE
            Ds = banco.ExecutaStoreProcedureDataSet(procedure, Parametro)
            '
            Return Ds
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_SubGrupo()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            'Parametro.Add(New SqlParameter("Grupo", IT_GRUPO))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Grupo_Sel", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpImagemItem() As Object

        Dim x As Integer
        Dim RETORNO As Integer
        Dim banco As DataAcces
        Dim PAR As List(Of SqlParameter)
        banco = New DataAcces
        ''adiciona os parametros
        PAR = New List(Of SqlParameter)
        PAR.Add(New SqlParameter("@It_ITEM", IT_ITEM))
        PAR.Add(New SqlParameter("@IT_IMAGEM", IT_IMAGEM))

        'EXECUTA A PROCEDURE
        RETORNO = banco.ExecuteStoreProcedureIncremento("Sp_Item_Up_Foto", PAR)

        Return RETORNO

        'FECHA A CONEXAO
        banco.CloseConn()

    End Function
    Public Function Le_Fornecedor()
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("FOR_CGC", F_CGC))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Fornecedor_Sel", Parametro)

        F_SEQ = 0
        Do While dr.Read
            F_SEQ = dr("FSEQ")
            F_CGC = dr("FCGC")
            F_IE = dr("FIE")
            F_IM = dr("FIM")
            F_RAZAO = dr("FRAZAO")
            F_FANTASIA = dr("FFANTASIA")
            F_END = dr("FEND")
            F_NRO = dr("FNRO")
            F_COMPLE = dr("FCOMPLE")
            F_BAIRRO = dr("FBAIRRO")
            F_CIDADE = dr("FCIDADE")
            F_UF = dr("FUF")
            F_CEP = dr("FCEP")
            F_CONTATO = dr("FCONTATO")
            F_DDD = dr("FDDD")
            F_TEL = dr("FFONE")
            F_DDDFAX = dr("FDDDFAX")
            F_FAX = dr("FFAX")
            F_HTTP = dr("FHTTP")
            F_MAIL = dr("FMAIL")
            F_DTREG = dr("FDTREG")
            F_DTULTCOM = dr("FDTULTCOM")

            retorno = True
        Loop

        banco.CloseConn()
    End Function
    Public Function BuscaNotaFiscal()
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("et_fornec", ET_FORNEC))
        Parametro.Add(New SqlParameter("et_nota", ET_SOLIC))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Estoque_BuscaNTF", Parametro)
        Do While dr.Read
            ET_SEQ = dr("qtd")
            retorno = True
        Loop

        banco.CloseConn()
    End Function
    Public Function BuscaItens() As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Itens_Busca", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Itens_da_Nota()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("et_fornec", ET_FORNEC))
            Parametro.Add(New SqlParameter("et_solic", ET_SOLIC))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Estoque_ITEM_Nota", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Busca_For_Todos()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Fornecedor_SelTodos", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_NotasFor()

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("et_fornec", ET_FORNEC))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Estoque_For_Notas", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Grupo_da_Os(ByVal OS As Integer) As Object
        Dim retorno As Boolean
        Dim banco As DataAcces
        Dim dr As IDataReader
        Dim Parametro As List(Of SqlParameter)
        Try

            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@OS", OS))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Itens_DaOs", Parametro)

            Do While dr.Read

                IT_GRUPO = dr("ItGrupo")
                IT_DESC = dr("ITDESC")
                IT_ITEM = dr("ITITEM")

            Loop
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Busca_Banho_da_Os(ByVal OS As Integer) As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@OS", OS))

        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_GrupoBanho_DaOs", Parametro)

        Do While dr.Read
            IT_GRUPO = dr("ItGrupo")
            Fi_VlrPgto = dr("FiVlrPgto")
            retorno = True
        Loop

        banco.CloseConn()
    End Function
    Public Function Busca_Serv_da_Os(ByVal OS As Integer) As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@OS", OS))

        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_GrupoBanho_DaOs", Parametro)
        Do While dr.Read
            'IT_GRUPO = dr("ItGrupo")
            retorno = True
        Loop

        banco.CloseConn()
    End Function
End Class
