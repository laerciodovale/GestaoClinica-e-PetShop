Imports System.Data.SqlClient
Imports DataBase.Utils
Public Class Cls_Financeiro
    '' VARIAVEIS DO FINANCEIRO SINTETICO
    Public Dt_Pesq As Date
    Public NssNro As Integer
    Public fi_cpf As String
    Public Fi_Id As Integer
    Public Fi_NssNro As Integer
    Public Fi_DtVcto As Date
    Public Fi_Vlr As Decimal
    Public Fi_VlrDcto As Decimal
    Public Fi_VlrPgto As Decimal

    Public Fi_Cli As Integer
    Public Fi_NomeCli As String

    Public Fi_Ani As Integer
    Public Fi_NomeAni As String

    Public Fi_AnoMes As Integer
    Public Fi_DtPgto As Date
    Public Fi_Lote As Integer
    Public Fi_VlrAd As Decimal
    Public Fi_VlrDev As Decimal
    Public Fi_VlrAcre As Decimal

    Public Fi_CodBar As String
    Public Fi_LinDig As String
    Public Fi_Emi As Integer
    Public Fi_DtLan As Date
    Public Fi_Emp As Integer
    Public Fi_Custo As Integer
    Public Fi_BcoCh As String
    Public Fi_AgCh As String
    Public Fi_Cta As String
    Public Fi_NroCh As String
    Public Fi_Emitente As String
    Public Fi_ChPre As Integer
    Public Fi_Cartao As String
    Public Fi_Caixa As String
    Public Fi_DevCh As String
    Public Fi_Obs As String
    Public Fi_NroCar As Integer
    Public Fi_DtVCtr As Integer
    Public FI_LancImp As Integer
    Public Fi_ChAnt As String
    Public Fi_Conv As Integer
    Public Fi_ConvReq As Integer
    Public Fi_NF As Integer
    Public Fi_Ordem As Integer
    Public Fi_Ev As Integer
    Public Fi_Fat As Integer
    Public Fi_VlrImp As Double
    Public Fi_FPagto As String

    ''
    Public Fa_Seq As Integer
    Public Fa_Cli As Integer
    Public Fa_Ani As Integer
    Public Fa_NssNro As Integer
    Public Fa_Ev As String
    Public Fa_Desc As String
    Public Fa_Qtd As Double
    Public Fa_VlrU As Decimal
    Public Fa_Dcto As Decimal
    Public Fa_Vlr As Decimal
    Public Fa_Func As Integer
    Public Fa_Dt As Date
    Public Fa_VlrAd As Decimal

    Public Mv_NssNro As Integer
    Public Mv_Data As Date
    Public Mv_VlrEnt As Decimal
    Public Mv_VlrSai As Decimal
    Public Mv_Custo As Integer
    Public MV_Caixa As String
    Public MV_Desc As String

    '' caixa abretura / fechamento
    Public cx_Id As Integer
    Public cx_Data As Date
    Public Property cx_Usuario As String
    Friend cx_usr As Cls_Financeiro

    Public cx_Fechado As Boolean
    Public cx_Abertura As Decimal
    Public cx_Fundo As Decimal
    Public cx_Receita As Decimal
    Public cx_Sangria As Decimal
    Public cx_Saida As Decimal
    Public cx_SaldoDia As Decimal
    Public cx_Dinheiro As Decimal
    Public cx_PIX As Decimal
    Public cx_CartaoDeb As Decimal
    Public cx_Cartao As Decimal
    Public cx_Emp As Integer
    Public cx_Custo As Integer
    Public cx_Aberto As Decimal
    Public cx_Atrasados As Decimal

    '' contas a pagar
    Public CT_ID As Integer
    Public CT_DTREF As Date
    Public CT_FORNEC As String
    Public CT_OC As Integer
    Public CT_NF As Integer
    Public CT_DTNF As Date
    Public CT_DUPL As Double
    Public CT_FATURA As Integer
    Public CT_DTVCTO As Date
    Public CT_VALOR As Double
    Public CT_DTPAGTO As Date
    Public CT_VALORP As Double
    Public CT_DOCPG As Integer

    Public CT_EVENTO As String
    Public CT_CCUSTO As Integer
    Public CT_VALORNTF As Double
    Public CT_FPAGTO As Integer
    Public CT_HISTREG As String
    '' pivot
    Public sld_AVista As Decimal
    Public sld_Pix As Decimal
    Public sld_CDeb As Decimal
    Public sld_CCred As Decimal
    Public sld_CCred2 As Decimal
    Public sld_CCred3 As Decimal
    Public sld_CCred4 As Decimal
    Public sld_Outros As Decimal
    Public sld_Atrasados As Decimal
    ''
    Public Tipo_Operacao As String
    Public dt_Base As String
    Public fi_Retorno As Boolean
    Public valorTotal As Double = 0
    Public id_Grid As Integer
    Public VlrFisio As Integer
    Public NroZap As String
    Public Agenda_da_OS As String
    Public Det_OS_FinanA(6, 50) As String
    Public Ind As Integer
    Private Parametro As List(Of SqlParameter)
    Public Function GravaNssNro() As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("id_Dt", Now))

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_NssNro_Insert", Parametro)
            NssNro = banco.id_Increment
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function IncluirFinS()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try

            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Fi_NssNro", NssNro))
            Parametro.Add(New SqlParameter("Fi_Cli", Fi_Cli))
            Parametro.Add(New SqlParameter("Fi_Ani", Fi_Ani))
            Parametro.Add(New SqlParameter("Fi_AnoMes", Fi_AnoMes))
            Parametro.Add(New SqlParameter("Fi_DtVcto", Fi_DtVcto))
            Parametro.Add(New SqlParameter("Fi_DtPgto", Fi_DtPgto))
            Parametro.Add(New SqlParameter("Fi_Lote", Fi_Lote))
            Parametro.Add(New SqlParameter("Fi_VlrAd", Fi_VlrAd))
            Parametro.Add(New SqlParameter("Fi_VlrDev", Fi_VlrDev))
            Parametro.Add(New SqlParameter("Fi_Vlr", Fi_Vlr))
            Parametro.Add(New SqlParameter("Fi_VlrPgto", Fi_VlrPgto))
            Parametro.Add(New SqlParameter("Fi_VlrAcre", Fi_VlrAcre))
            Parametro.Add(New SqlParameter("Fi_VlrDcto", Fi_VlrDcto))
            Parametro.Add(New SqlParameter("Fi_CodBar", Fi_CodBar))
            Parametro.Add(New SqlParameter("Fi_LinDig", Fi_LinDig))
            Parametro.Add(New SqlParameter("Fi_Emi", Fi_Emi))
            Parametro.Add(New SqlParameter("Fi_DtLan", Fi_DtLan))
            Parametro.Add(New SqlParameter("Fi_Emp", Fi_Emp))
            Parametro.Add(New SqlParameter("Fi_Custo", Fi_Custo))
            Parametro.Add(New SqlParameter("Fi_BcoCh", Fi_BcoCh))
            Parametro.Add(New SqlParameter("Fi_AgCh", Fi_AgCh))
            Parametro.Add(New SqlParameter("Fi_Cta", Fi_Cta))
            Parametro.Add(New SqlParameter("Fi_NroCh", Fi_NroCh))
            Parametro.Add(New SqlParameter("Fi_Emitente", Fi_Emitente))
            Parametro.Add(New SqlParameter("Fi_ChPre", Fi_ChPre))
            Parametro.Add(New SqlParameter("Fi_Cartao", Fi_Cartao))
            Parametro.Add(New SqlParameter("Fi_Caixa", Fi_Caixa))
            Parametro.Add(New SqlParameter("Fi_DevCh", Fi_DevCh))
            Parametro.Add(New SqlParameter("Fi_Obs", Fi_Obs))
            Parametro.Add(New SqlParameter("Fi_NroCar", Fi_NroCar))
            Parametro.Add(New SqlParameter("Fi_DtVCtr", Fi_DtVCtr))
            Parametro.Add(New SqlParameter("FI_LancImp", FI_LancImp))
            Parametro.Add(New SqlParameter("Fi_ChAnt", Fi_ChAnt))
            Parametro.Add(New SqlParameter("Fi_Conv", Fi_Conv))
            Parametro.Add(New SqlParameter("Fi_ConvReq", Fi_ConvReq))
            Parametro.Add(New SqlParameter("Fi_NF", Fi_NF))
            Parametro.Add(New SqlParameter("Fi_Ordem", Fi_Ordem))
            Parametro.Add(New SqlParameter("Fi_Ev", Fi_Ev))
            Parametro.Add(New SqlParameter("Fi_Fat", Fi_Fat))
            Parametro.Add(New SqlParameter("Fi_VlrImp", Fi_VlrImp))
            Parametro.Add(New SqlParameter("Fi_FPagto", Fi_FPagto))
            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_FinS_Insert", Parametro)
            Fi_Id = banco.id_Increment
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function MoveVar()

        Fa_NssNro = NssNro
        Fi_NssNro = NssNro

        'Dim u As Utils
        'Fa_Cli = u.Id_Cliente
        'Fa_Ani = u.Id_Paciente
        Fi_Cli = Fa_Cli
        Fi_Ani = Fa_Ani

        Fi_DtVcto = Now
        Fi_AnoMes = Format(Now, "yyyyMM")
        Fi_DtPgto = "01/01/1900"
        'Dim diaDoAno As Integer = Now.DayOfYear
        Fi_Lote = 0 'Format(Now, "yy") & diaDoAno

        Fi_Vlr = valorTotal

        Fi_VlrAd = 0
        Fi_VlrPgto = 0
        Fi_VlrAcre = 0
        Fi_VlrDcto = 0

        Fi_BcoCh = ""
        Fi_AgCh = ""
        Fi_Cta = ""
        Fi_NroCh = ""
        Fi_Emitente = ""
        Fi_ChPre = 0
        Fi_Cartao = ""
        Fi_Caixa = ""
        Fi_DevCh = ""
        Fi_NroCar = 0
        Fi_DtVCtr = 0

        Fi_CodBar = ""
        Fi_LinDig = ""
        Fi_Emi = 0
        Fi_DtLan = FormatDateTime(Now, DateFormat.LongDate)
        Fi_Emp = 1
        Fi_Custo = 1
        Fi_Obs = ""
        FI_LancImp = 0
        Fi_ChAnt = 0
        Fi_Conv = 1
        Fi_ConvReq = 0
        Fi_NF = 0
        Fi_Ordem = 0 'NSSNRO
        Fi_Ev = 0 'VAGO
        Fi_Fat = 1 'ORCAMENTO
        Fi_VlrImp = 0 'VAGO
        Fi_FPagto = ""

        Mv_VlrSai = 0
    End Function
    Public Function UpDateFaNssNro()
        Try
            Dim retorno As Boolean = False
            '  Dim Parametro As List(Of SqlParameter)
            Dim banco As DataAcces
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@FaNssNro", NssNro))
            Parametro.Add(New SqlParameter("@FaCli", Fi_Cli))
            Parametro.Add(New SqlParameter("@FaAni", Fi_Ani))
            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("Sp_FinA_UpLista", Parametro)

            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ExProcNssNro(ByVal procedure As String)

        Dim retorno As Boolean = False
        '  Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@NssNro", NssNro))

        ' EXCUTA A PROCEDURE
        retorno = banco.ExecuteStoreProcedure(procedure, Parametro)

        banco.CloseConn()

    End Function

    'Public Function ExecutaBaixa(ByVal procedure As String)
    '    Dim retorno As Boolean
    '    Dim banco As New DataAcces

    '    Try
    '        Parametro = New List(Of SqlParameter)
    '        MoveParam()
    '        Parametro.Add(New SqlParameter("@mv_VlrSai", 0))
    '        retorno = banco.ExecuteStoreProcedure(procedure, Parametro)
    '        banco.CloseConn()
    '        '  RecalCx()  '' processo lento
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function
    Public Function RecalCx() As Object
        Exit Function

        Dim recal As New DataAcces
        recal.RecalculoCx()

        'Dim Sql As String
        'Dim Mv_Seq As Integer
        'Dim Mv_SldAn As Double
        'Dim Mv_SldAt As Double
        'Dim retorno As Object

        ''Sql = "SELECT  min(mvseq) as mvseq from caixamov where MVData = " & Chr(39) & dt_Base & Chr(39) & ""

        ''comando.CommandText = Sql
        ''comando = New SqlCommand(Sql, conexao)
        ''conexao.Close()
        ''conexao.Open()
        ''dr = comando.ExecuteReader

        ''retorno = False
        ''Do While dr.Read
        ''    Mv_Seq = dr("mvseq")
        ''    retorno = True
        ''Loop

        ''conexao.Close()

        ''Sql = "SELECT  * from caixamov where mvseq >= " & Mv_Seq & " order by mvseq asc "
        'Sql = "SELECT  * from caixamov  order by mvseq asc "
        'conexao.Close()
        'comando.CommandText = Sql
        'comando = New SqlCommand(Sql, conexao)
        'conexao.Open()
        'dr = comando.ExecuteReader

        'retorno = False
        'Mv_SldAn = 0
        'Mv_SldAt = 0
        'conexaoS = New SqlConnection("Server=162.241.2.67:3306;Database=cvmype23_cadvet;Uid=cvmype23_sa;Pwd=nunsey;")
        'conexaoS.Open()
        'Do While dr.Read
        '    Mv_Seq = dr("mvseq")

        '    Mv_SldAn = Mv_SldAt

        '    Mv_SldAt = Format(Mv_SldAt + (dr("MVE") + dr("MVs")), "0.00")

        '    comando = New SqlCommand
        '    comando.CommandType = CommandType.StoredProcedure
        '    comando.CommandText = "Sp_Caixa_Sld"
        '    comando.Connection = conexaoS
        '    comando.Parameters.AddWithValue("Mv_Seq", Mv_Seq)
        '    comando.Parameters.AddWithValue("Mv_SldAn", Mv_SldAn)
        '    comando.Parameters.AddWithValue("Mv_SldAt", Mv_SldAt)

        '    retorno = comando.ExecuteNonQuery()

        '    retorno = True
        'Loop
        'conexaoS.Close()

        'conexao.Close()

    End Function

    Public Function ExtornoCx(ByVal procedure As String)
        Dim retorno As Boolean
        Dim banco As DataAcces

        Parametro = New List(Of SqlParameter)
        MoveParam()

        retorno = banco.ExecuteStoreProcedure(procedure, Parametro)

        banco.CloseConn()

        RecalCx()

    End Function
    Private Sub MoveParam()

        Parametro.Add(New SqlParameter("@Fi_NssNro", Fi_NssNro))
        Parametro.Add(New SqlParameter("@Fi_Cli", Fi_Cli))
        Parametro.Add(New SqlParameter("@Fi_Ani", Fi_Ani))
        Parametro.Add(New SqlParameter("@Fi_AnoMes", Fi_AnoMes))
        Parametro.Add(New SqlParameter("@Fi_DtVcto", Fi_DtVcto))
        Parametro.Add(New SqlParameter("@Fi_DtPgto", Fi_DtPgto))
        Parametro.Add(New SqlParameter("@Fi_Lote", Fi_Lote))
        Parametro.Add(New SqlParameter("@Fi_VlrAd", Fi_VlrAd))
        Parametro.Add(New SqlParameter("@Fi_VlrDev", Fi_VlrDev))
        Parametro.Add(New SqlParameter("@Fi_Vlr", Fi_Vlr))
        Parametro.Add(New SqlParameter("@Fi_VlrPgto", Fi_VlrPgto))
        Parametro.Add(New SqlParameter("@Fi_VlrAcre", Fi_VlrAcre))
        Parametro.Add(New SqlParameter("@Fi_VlrDcto", Fi_VlrDcto))
        Parametro.Add(New SqlParameter("@Fi_CodBar", Fi_CodBar))
        Parametro.Add(New SqlParameter("@Fi_LinDig", Fi_LinDig))
        Parametro.Add(New SqlParameter("@Fi_Emi", Fi_Emi))
        Parametro.Add(New SqlParameter("@Fi_DtLan", Fi_DtLan))
        Parametro.Add(New SqlParameter("@Fi_Emp", Fi_Emp))
        Parametro.Add(New SqlParameter("@Fi_Custo", Fi_Custo))
        Parametro.Add(New SqlParameter("@Fi_BcoCh", Fi_BcoCh))
        Parametro.Add(New SqlParameter("@Fi_AgCh", Fi_AgCh))
        Parametro.Add(New SqlParameter("@Fi_Cta", Fi_Cta))
        Parametro.Add(New SqlParameter("@Fi_NroCh", Fi_NroCh))
        Parametro.Add(New SqlParameter("@Fi_Emitente", Fi_Emitente))
        Parametro.Add(New SqlParameter("@Fi_ChPre", Fi_ChPre))
        Parametro.Add(New SqlParameter("@Fi_Cartao", Fi_Cartao))
        Parametro.Add(New SqlParameter("@Fi_Caixa", Fi_Caixa))
        Parametro.Add(New SqlParameter("@Fi_DevCh", Fi_DevCh))
        Parametro.Add(New SqlParameter("@Fi_Obs", Fi_Obs))
        Parametro.Add(New SqlParameter("@Fi_NroCar", Fi_NroCar))
        Parametro.Add(New SqlParameter("@Fi_DtVCtr", Fi_DtVCtr))
        Parametro.Add(New SqlParameter("@FI_LancImp", FI_LancImp))
        Parametro.Add(New SqlParameter("@Fi_ChAnt", Fi_ChAnt))
        Parametro.Add(New SqlParameter("@Fi_Conv", Fi_Conv))
        Parametro.Add(New SqlParameter("@Fi_ConvReq", Fi_ConvReq))
        Parametro.Add(New SqlParameter("@Fi_NF", Fi_NF))
        Parametro.Add(New SqlParameter("@Fi_Ordem", Fi_Ordem))
        Parametro.Add(New SqlParameter("@Fi_Ev", Fi_Ev))
        Parametro.Add(New SqlParameter("@Fi_Fat", Fi_Fat))
        Parametro.Add(New SqlParameter("@Fi_VlrImp", Fi_VlrImp))
        Parametro.Add(New SqlParameter("@Fi_FPagto", Fi_FPagto))

    End Sub
    Public Function LeFinan() As Object
        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("NssNro", id_Grid))
            dr = banco.ExecutaStoreProcedureReader("Sp_FinS_NssNro", Parametro)
            retorno = False
            Do While dr.Read

                Fi_NssNro = dr("FiNSSNRO")

                Fi_Ani = dr("FIANI")
                Fi_NomeAni = dr("aninome")
                Fi_Cli = dr("FICLI")
                Fi_NomeCli = dr("clnome")
                NroZap = dr("clfixo")
                Fi_DtVcto = dr("fidtvcto")
                Fi_Vlr = dr("fivlr")
                ''Fi_VlrDcto = dr("FIdcto")
                Fi_VlrPgto = dr("FIvlrpgto")
                fi_Retorno = True
                retorno = True
            Loop
            Return retorno
            banco.CloseConn()
            '  RecalCx()  '' processo lento
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeFinA()

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("NssNro", id_Grid))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_FinA_Det", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeDetFinanA() As Object
        Dim retorno As Boolean = False
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("NssNro", id_Grid))
            dr = banco.ExecutaStoreProcedureReader("Sp_FinA_Le_Det_OS", Parametro)

            'Erase Det_OS_FinanA
            Ind = 0
            Do While dr.Read

                Det_OS_FinanA(0, Ind) = dr("FaDt")
                Det_OS_FinanA(1, Ind) = dr("FaEv")
                Det_OS_FinanA(2, Ind) = dr("FaDesc")
                Det_OS_FinanA(3, Ind) = Format(dr("FaQtd"), "0.0")
                Det_OS_FinanA(4, Ind) = Format(dr("FaVlrU"), "0.00")
                Det_OS_FinanA(5, Ind) = Format(dr("FaVlr"), "0.00")
                Det_OS_FinanA(6, Ind) = Format(dr("FiVlr"), "0.00")
                retorno = True
                Ind += 1
            Loop
            Return retorno
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function LeExtratoCli()

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("ID", Fi_Cli))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_FinS_Extrato", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function ExecutaBaixa()
        Dim retorno As Boolean
        Dim banco As New DataAcces

        Try
            Parametro = New List(Of SqlParameter)
            MoveParam()
            Parametro.Add(New SqlParameter("mv_VlrSai", Mv_VlrSai))

            retorno = banco.ExecuteStoreProcedure("Sp_FinS_BaixaN", Parametro)
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

        'RecalCx()

    End Function
    Public Function ExtornoCx()
        Dim retorno As Boolean
        Dim banco As New DataAcces

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("Fi_NssNro", Fi_NssNro))
        Parametro.Add(New SqlParameter("Fi_DtPgto", Format(Fi_DtPgto, "yyyy-MM-dd")))
        Parametro.Add(New SqlParameter("Fi_Lote", Fi_Lote))
        Parametro.Add(New SqlParameter("Fi_VlrPgto", Fi_VlrPgto))
        Parametro.Add(New SqlParameter("Fi_VlrAcre", Fi_VlrAcre))
        Parametro.Add(New SqlParameter("Fi_VlrDcto", Fi_VlrDcto))
        Parametro.Add(New SqlParameter("Fi_BcoCh", Fi_BcoCh))
        Parametro.Add(New SqlParameter("Fi_AgCh", Fi_AgCh))
        Parametro.Add(New SqlParameter("Fi_Cta", Fi_Cta))
        Parametro.Add(New SqlParameter("Fi_NroCh", Fi_NroCh))
        Parametro.Add(New SqlParameter("Fi_Emitente", Fi_Emitente))
        Parametro.Add(New SqlParameter("Fi_ChPre", Fi_ChPre))
        Parametro.Add(New SqlParameter("Fi_Cartao", Fi_Cartao))
        Parametro.Add(New SqlParameter("Fi_Caixa", Fi_Caixa))
        Parametro.Add(New SqlParameter("Fi_NroCar", Fi_NroCar))
        Parametro.Add(New SqlParameter("Fi_DtVCtr", Fi_DtVCtr))
        Parametro.Add(New SqlParameter("Fi_FPagto", Fi_FPagto))
        ' Parametro.Add(New SqlParameter("mv_VlrSai", Mv_VlrSai))

        retorno = banco.ExecuteStoreProcedure("Sp_Caixa_Extorno", Parametro)

        RecalCx()

    End Function
    Public Function FinanDoDia(ByVal procedure As String) As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Dt_Fat", Dt_Pesq))

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
    Public Function IncluirCx()
        Dim retorno As Boolean
        Dim banco As New DataAcces

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("Mv_NssNro", Mv_NssNro))
        Parametro.Add(New SqlParameter("Mv_Data", Now))
        Parametro.Add(New SqlParameter("Mv_VlrEnt", Mv_VlrEnt))
        Parametro.Add(New SqlParameter("Mv_VlrSai", Mv_VlrSai))
        Parametro.Add(New SqlParameter("Mv_Custo", Mv_Custo))
        Parametro.Add(New SqlParameter("MV_Caixa", MV_Caixa))
        'Parametro.Add(New SqlParameter("MV_Desc", MV_Desc))
        Parametro.Add(New SqlParameter("Fi_FPagto", Fi_FPagto))

        retorno = banco.ExecuteStoreProcedure("Sp_Caixa_Insert", Parametro)

    End Function
    Private Sub MoveParamCx()
        Parametro.Add(New SqlParameter("@TipoOperacao", Tipo_Operacao))
        Parametro.Add(New SqlParameter("@cxID", cx_Id))
        Parametro.Add(New SqlParameter("@cxData", cx_Data))
        Parametro.Add(New SqlParameter("@cxUsuario", cx_Usuario))
        Parametro.Add(New SqlParameter("@cxFechado", cx_Fechado))
        Parametro.Add(New SqlParameter("@cxAbertura", cx_Abertura))
        Parametro.Add(New SqlParameter("@cxFundo", cx_Fundo))
        Parametro.Add(New SqlParameter("@cxReceita", cx_Receita))
        Parametro.Add(New SqlParameter("@cxSangria", cx_Sangria))
        Parametro.Add(New SqlParameter("@cxSaida", cx_Saida))
        Parametro.Add(New SqlParameter("@cxSaldoDia", cx_SaldoDia))
        Parametro.Add(New SqlParameter("@cxDinheiro", cx_Dinheiro))
        Parametro.Add(New SqlParameter("@cxPIX", cx_PIX))
        Parametro.Add(New SqlParameter("@cxCartaoDeb", cx_CartaoDeb))
        Parametro.Add(New SqlParameter("@cxCartao", cx_Cartao))
        Parametro.Add(New SqlParameter("@cxEmp", cx_Emp))
        Parametro.Add(New SqlParameter("@cxCusto", cx_Custo))
        Parametro.Add(New SqlParameter("@cxAberto", cx_Aberto))
        Parametro.Add(New SqlParameter("@cxAtrasados", cx_Atrasados))

    End Sub
    Public Function LeCx(ByVal cx_caixa As String, ByVal DtPesq As Date) As Object
        '  Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader
        Dim Tabela As DataTable
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@cxData", DtPesq))
            'Parametro.Add(New SqlParameter("@cxUsuario", cx_caixa))
            dr = banco.ExecutaStoreProcedureReader("Sp_Cx_Dia", Parametro)

            cx_Id = 0
            cx_Abertura = 0
            cx_Fundo = 0
            cx_Sangria = 0
            Do While dr.Read
                cx_Id = dr("cxId")
                cx_Data = dr("cxData")
                cx_Usuario = dr("cxUsuario")
                cx_Fechado = dr("cxFechado")
                cx_Abertura = cx_Abertura + dr("cxAbertura")
                cx_Fundo = cx_Fundo + dr("cxFundo")
                cx_Receita = dr("cxReceita")
                cx_Sangria = cx_Sangria + dr("cxSangria")
                cx_Saida = dr("cxSaida")
                cx_SaldoDia = dr("cxSaldoDia")
                cx_Dinheiro = dr("cxDinheiro")
                cx_PIX = dr("cxPIX")
                cx_CartaoDeb = dr("cxCartaoDeb")
                cx_Cartao = dr("cxCartao")
                cx_Emp = dr("cxEmp")
                cx_Custo = dr("cxCusto")
                cx_Aberto = dr("cxAberto")
                cx_Atrasados = dr("cxAtrasados")

            Loop

            banco.CloseConn()
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@cxData", DtPesq))
            ' Parametro.Add(New SqlParameter("@cxUsuario", cx_caixa))
            Tabela = banco.ExecutaDataTable("Sp_Cx_Dia_S", Parametro)
            LeVlrFisio(DtPesq)

            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeVlrFisio(ByVal DtPesq As Date) As Object
        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Data", DtPesq))
            dr = banco.ExecutaStoreProcedureReader("Sp_FinA_Fisio", Parametro)
            VlrFisio = 0
            Do While dr.Read

                If IsDBNull(dr("vlrfisio")) = False Then
                    VlrFisio = dr("VlrFisio")
                End If

            Loop
            ''Return dr
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeCxAberto() As Object
        Dim retorno As Boolean = False
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@cxData", Now))
            dr = banco.ExecutaStoreProcedureReader("Sp_Cx_SeAberto", Parametro)

            cx_Id = 0
            Do While dr.Read
                cx_Id = dr("cxId")
                retorno = True
            Loop

            banco.CloseConn()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function AbreCx()
        Dim retorno As Integer = 0
        Dim banco As New DataAcces
        Try
            Parametro = New List(Of SqlParameter)

            MoveParamCx()

            'banco.ExecuteStoreProcedure("Sp_CxLan_I_U_D", Parametro)
            'retorno = True

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_CxLan_I_U_D", Parametro)
            Return retorno
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function LePivotFP(ByVal PvData As Date)

        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Mv_Data", PvData))
            dr = banco.ExecutaStoreProcedureReader("Sp_CxPivot_FPgto", Parametro)
            retorno = False
            sld_AVista = 0
            sld_Pix = 0
            sld_CDeb = 0
            sld_CCred = 0
            sld_CCred2 = 0
            sld_CCred3 = 0
            sld_CCred4 = 0
            sld_Outros = 0
            sld_Atrasados = 0
            Do While dr.Read
                '' pivot
                If IsDBNull(dr("Á Vista")) = False Then
                    sld_AVista = dr("Á Vista")
                End If
                If IsDBNull(dr("PIX")) = False Then
                    sld_Pix = dr("PIX")
                End If
                If IsDBNull(dr("Cartão Débito")) = False Then
                    sld_CDeb = dr("Cartão Débito")
                End If
                If IsDBNull(dr("Cartão Crédito Á Vista")) = False Then
                    sld_CCred = dr("Cartão Crédito Á Vista")
                End If
                If IsDBNull(dr("Cartão Crédito x 2")) = False Then
                    sld_CCred2 = dr("Cartão Crédito x 2")
                End If
                If IsDBNull(dr("Cartão Crédito x 3")) = False Then
                    sld_CCred3 = dr("Cartão Crédito x 3")
                End If
                If IsDBNull(dr("Cartão Crédito x 4")) = False Then
                    sld_CCred4 = dr("Cartão Crédito x 4")
                End If
                If IsDBNull(dr("Outros")) = False Then
                    sld_Outros = dr("Outros")
                End If

            Loop
            Return retorno
            banco.CloseConn()


        Catch ex As Exception
            Throw ex
        End Try


    End Function
    Public Function LeAtrasados(ByVal DataPg As Date)
        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Dt_Pagto", DataPg))
        dr = banco.ExecutaStoreProcedureReader("Sp_FinS_PgAtrasados", Parametro)

        Do While dr.Read

            sld_Atrasados = dr("VlrPagto")

        Loop

    End Function
    Public Function LeSaidas(ByVal cx_caixa As String) As Object
        '  Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader
        Dim Tabela As DataTable
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Mv_Data", NOW))
            ''Parametro.Add(New SqlParameter("@cxUsuario", cx_caixa))
            Tabela = banco.ExecutaDataTable("Sp_Caixa_Saidas", Parametro)
            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Busca_Duplicata()

        Dim banco As New DataAcces
        Dim dr As IDataReader
        Dim Tabela As DataTable
        Try
            Parametro = New List(Of SqlParameter)

            Tabela = banco.ExecutaDataTable("Sp_Duplicata_Sel", Parametro)
            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Busca_Dupl_Nota()

        Dim banco As New DataAcces
        Dim dr As IDataReader
        Dim Tabela As DataTable
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("CT_FORNEC", CT_FORNEC))
            Parametro.Add(New SqlParameter("CT_NF", CT_NF))
            Tabela = banco.ExecutaDataTable("SP_CTAPG_DUPL_NOTA", Parametro)
            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EnviaInsertCT()
        'Dim retorno As Boolean = False

        'comando = New SqlCommand
        'comando.CommandType = CommandType.StoredProcedure
        'comando.CommandText = "Sp_Duplicata_Sel"
        'comando.Parameters.AddWithValue("Item", IT_ITEM)
        'comando.Connection = conexao

        'conexao.Open()

        'dr = comando.ExecuteReader

        'Do While dr.Read

        '    IT_ID = dr("ITID")

        '    retorno = True
        'Loop

        'conexao.Close()

    End Function


    Public Function Busca_Cliente_Os(ByVal OS As Integer) As Object
        Dim retorno As Boolean
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try

            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@OS", OS))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Clientes_Os", Parametro)

            Do While dr.Read

                Fi_Ani = dr("IdAnimal")
                Fi_NomeAni = dr("AniNome")
                Fi_Cli = dr("ClId")
                Fi_NomeCli = dr("ClNome")
                fi_cpf = dr("ClCpf")
                NroZap = dr("clfixo")
            Loop
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Busca_Itens_da_OS(ByVal Os As Integer)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@OS", Os))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Itens_DaOS", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Agenda_da_Os(ByVal OS As Integer) As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Ag_OS", OS))

        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Agenda_OS", Parametro)
        Agenda_da_OS = ""
        Do While dr.Read
            Agenda_da_OS += "Dia : " & dr("AgData") & " Hora : " & dr("AgHora") & vbCrLf
        Loop
        retorno = True

        banco.CloseConn()
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
        Dim Mt As New Cls_Materiais
        Do While dr.Read
            Mt.IT_GRUPO = dr("ItGrupo")
            retorno = True
        Loop

        banco.CloseConn()
    End Function
    Public Function FechaPdv(ByVal NssPai As Integer)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@FaNssNro", 0))
            Parametro.Add(New SqlParameter("@FaNssPai", NssPai))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_FinA_Fecha_PDV", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Busca_Fat_Per(ByVal Per_De As Date, ByVal Per_Ate As Date)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@DeData", Per_De))
            Parametro.Add(New SqlParameter("@AteData", Per_Ate))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Fat_Per", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Banhos_Ativos(ByVal Per_De As Date, ByVal Per_Ate As Date)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@DeData", Per_De))
            Parametro.Add(New SqlParameter("@AteData", Per_Ate))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_BT_Qtd_Ativo", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Fat_Por_Grupo(ByVal Per_De As Date, ByVal Per_Ate As Date)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@DeData", Per_De))
            Parametro.Add(New SqlParameter("@AteData", Per_Ate))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Qtd_PorGrupo", Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscaDebCliente(ByVal Cli As Integer)

        'Dim retorno As Boolean = False
        'Dim banco As DataAcces
        'banco = New DataAcces
        'Parametro = New List(Of SqlParameter)
        'Parametro.Add(New SqlParameter("@FiCli", Cli))
        'retorno = banco.ExecuteStoreProcedure("Sp_Fin_Deb_Cli", Parametro)

        'banco.CloseConn()


        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@FiCli", Cli))

        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Fin_Deb_Cli", Parametro)
        Dim Mt As New Cls_Materiais
        Do While dr.Read
            retorno = True
        Loop
        Return retorno
        banco.CloseConn()

    End Function
    Public Function DeleteFiNssNro(ByVal os As Integer)
        Try
            Dim retorno As Boolean = False
            '  Dim Parametro As List(Of SqlParameter)
            Dim banco As DataAcces
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@NssNro", os))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("Sp_FinS_Delete", Parametro)

            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Procedure(ByVal NomeProcedure As String)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            'Parametro.Add(New SqlParameter("@DeData", Per_De))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(NomeProcedure, Parametro)
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function IncluirCtaPagar()
        Dim retorno As Boolean
        Dim banco As New DataAcces

        Parametro = New List(Of SqlParameter)
        ''Parametro.Add(New SqlParameter("", CT_ID))
        Parametro.Add(New SqlParameter("@CT_DTREF", Now))
        Parametro.Add(New SqlParameter("@CT_FORNEC", CT_FORNEC))
        Parametro.Add(New SqlParameter("@CT_NF", CT_NF))
        Parametro.Add(New SqlParameter("@CT_DTNF", CT_DTNF))
        Parametro.Add(New SqlParameter("@CT_DUPL", CT_DUPL))
        Parametro.Add(New SqlParameter("@CT_FATURA", CT_FATURA))
        Parametro.Add(New SqlParameter("@CT_DTVCTO", CT_DTVCTO))
        Parametro.Add(New SqlParameter("@CT_VALOR", CT_VALOR))
        Parametro.Add(New SqlParameter("@CT_DTPAGTO", CT_DTPAGTO))
        Parametro.Add(New SqlParameter("@CT_VALORP", CT_VALORP))
        Parametro.Add(New SqlParameter("@CT_DOCPG", CT_DOCPG))
        Parametro.Add(New SqlParameter("@CT_Evento", CT_EVENTO))
        Parametro.Add(New SqlParameter("@CT_CCUSTO", CT_CCUSTO))
        Parametro.Add(New SqlParameter("@CT_VALORNTF", CT_VALORNTF))
        Parametro.Add(New SqlParameter("@CT_FPAGTO", CT_FPAGTO))
        Parametro.Add(New SqlParameter("@CT_HISTREG", CT_HISTREG))
        retorno = banco.ExecuteStoreProcedure("Sp_CtaPg_Insert", Parametro)

    End Function
    Public Function Busca_CtaPgNtf()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            banco = New DataAcces

            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@CT_FORNEC", CT_FORNEC))
            Parametro.Add(New SqlParameter("@CT_NF", CT_NF))
            Tabela = banco.ExecutaDataTable("SP_CTAPG_BUSCA_NOTA", Parametro)
            Return Tabela

            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Conta_Registros()
        Try

            Dim Parametro As List(Of SqlParameter)
            Dim banco As DataAcces
            Dim dr As IDataReader

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@CT_FORNEC", CT_FORNEC))
            Parametro.Add(New SqlParameter("@CT_NF", CT_NF))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("SP_CTAPG_cta_dupl", Parametro)

            Do While dr.Read

                If IsDBNull(dr("resultado")) = True Then
                    CT_DUPL = 1
                Else
                    CT_DUPL = dr("resultado") + 1
                End If
            Loop

            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Nota(ByVal Fornec As String, ByVal Nota As Integer)

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@CT_FORNEC", Fornec))
        Parametro.Add(New SqlParameter("@CT_NF", Nota))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("SP_CTAPG_Dados_NOTA", Parametro)
        CT_ID = 0

        Do While dr.Read
            CT_ID = dr("ctREG")
            CT_FORNEC = dr("CTfORNEC")
            CT_NF = dr("CTNF")
            CT_DTNF = dr("CTDTNF")
            CT_DUPL = dr("CTDUPL")
            CT_FATURA = dr("CTFATURA")
            CT_DTVCTO = dr("CTDTVCTO")
            CT_VALOR = dr("CTVALOR")
            CT_DTPAGTO = dr("CTDTPAGTO")
            CT_VALORP = dr("CTVALORP")
            CT_DOCPG = dr("CTDOCPG")
            CT_EVENTO = dr("ctevento")
            CT_CCUSTO = dr("ctccusto")
            CT_VALORNTF = dr("ctvalorntf")
            CT_FPAGTO = dr("CTFPAGTO")
            CT_HISTREG = dr("CTHISTREG")

        Loop

    End Function
    Public Function Le_RegDupl(ByVal Reg As Integer)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@CT_REG", Reg))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("SP_CTAPG_BUSCA_dp", Parametro)
        CT_ID = 0
        Do While dr.Read
            CT_ID = dr("CTREG")
            CT_FORNEC = dr("CTfORNEC")
            CT_NF = dr("CTNF")
            CT_DTNF = dr("CTDTNF")
            CT_DUPL = dr("CTDUPL")
            CT_FATURA = dr("CTFATURA")
            CT_DTVCTO = dr("CTDTVCTO")
            CT_VALOR = dr("CTVALOR")
            CT_DTPAGTO = dr("CTDTPAGTO")
            CT_VALORP = dr("CTVALORP")
            CT_DOCPG = dr("CTDOCPG")
            CT_EVENTO = dr("ctevento")
            CT_CCUSTO = dr("ctccusto")
            CT_VALORNTF = dr("ctvalorntf")
            CT_FPAGTO = dr("CTFPAGTO")
            CT_HISTREG = dr("CTHISTREG")
        Loop
        banco.CloseConn()

    End Function
    Public Function DeleteRegDupl(ByVal id As Integer)
        Try
            Dim retorno As Boolean = False
            '  Dim Parametro As List(Of SqlParameter)
            Dim banco As DataAcces
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ct_reg", id))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("SP_CTAPG_Del_dp", Parametro)

            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_CtaPg_DoDia(ByVal dt As Date, ByVal dt_ate As Date)
        Try
            Dim retorno As Boolean = False
            Dim banco As DataAcces
            banco = New DataAcces
            Dim Tabela As DataTable
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ct_dtvcto", Format(dt, "dd-MM-yyyy")))
            Parametro.Add(New SqlParameter("@ct_dtvcto_ate", Format(dt_ate, "dd-MM-yyyy")))

            Tabela = banco.ExecutaDataTable("SP_CTAPG_Dia", Parametro)

            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpDatectaPg_Pagto(ByVal id As Integer)
        Try
            Dim retorno As Boolean = False
            '  Dim Parametro As List(Of SqlParameter)
            Dim banco As DataAcces
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@CT_VALORP", CT_VALORP))
            Parametro.Add(New SqlParameter("@CT_DTPAGTO", CT_DTPAGTO))
            Parametro.Add(New SqlParameter("@CT_DOCPG", CT_DOCPG))
            Parametro.Add(New SqlParameter("@CT_FPAGTO", CT_FPAGTO))
            Parametro.Add(New SqlParameter("@CT_HISTREG", CT_HISTREG))
            Parametro.Add(New SqlParameter("@ID", id))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedure("Sp_CTAPG_Up_PAGTO", Parametro)

            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_CtaPg_DoFor(ByVal Fornec As String)
        Try
            Dim retorno As Boolean = False
            Dim banco As DataAcces
            banco = New DataAcces
            Dim Tabela As DataTable
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ct_fornec", Fornec))

            Tabela = banco.ExecutaDataTable("SP_CTAPG_DoFornec", Parametro)
            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LeFlxRed(ByVal procedure As String, ByVal DeDt As Date, ByVal AteDt As Date) As Object
        Dim banco As New DataAcces
        Dim Tabela As DataTable
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@DeData", DeDt))
            Parametro.Add(New SqlParameter("@AteData", AteDt))

            Tabela = banco.ExecutaDataTable(procedure, Parametro)
            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function PreencheCbo(ByVal procedure As String) As Object
        Try
            Dim retorno As Boolean = False
            Dim banco As DataAcces
            banco = New DataAcces
            Dim Tabela As DataTable
            Parametro = New List(Of SqlParameter)

            Tabela = banco.ExecutaDataTable(procedure, Parametro)

            Return Tabela
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class