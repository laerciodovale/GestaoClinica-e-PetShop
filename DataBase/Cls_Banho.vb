Imports System.Data.SqlClient

Public Class Cls_Banho
#Region "Propriedades Servicos"
    Public Property TipoOperacao As String
    Public Property Bt_Id As Integer
    Public Property Bt_OS As Integer

    Public Property Bt_Tutor As Integer
    Public Property Bt_Pet As Integer
    Public Property Bt_TpPcte As String
    Public Property Bt_TpBanho As Integer
    Public Property Bt_TosaHig As Boolean
    Public Property Bt_TosaMaq As Boolean
    Public Property Bt_TosaTrimming As Boolean
    Public Property Bt_TosaTesoura As Boolean
    Public Property Bt_TosaPadaoRaca As Boolean
    Public Property Bt_Penteado As String
    Public Property Bt_Outros As String
    Public Property Bt_AlergiaShampoo As Boolean
    Public Property Bt_AlergiaLamina As Boolean
    Public Property Bt_AlergiaPerfume As Boolean
    Public Property Bt_AlergiaOutros As String
    Public Property Bt_Enfeite As Boolean
    Public Property Bt_ObsTutor As String

    Public Property Bt_ObsServico As String
    Public Property Bt_EnfeiteBandana As Boolean
    Public Property Bt_EnfeiteLaco As Boolean
    Public Property Bt_EnfeiteGravata As Boolean
    Public Property Bt_EnfeiteAdesivo As Boolean
    Public Property Bt_EnfeiteNaoUsa As Boolean
    Public Property Bt_Hidratacao As String
    Public Property Bt_St As String


#End Region
#Region "Propriedades Check"
    Public Property BtCk_Id As Integer
    Public Property BtCk_OS As Integer
    Public Property BtCk_Nro As Integer
    Public Property BtCk_Tutor As Integer
    Public Property BtCk_Pet As Integer
    Public Property BtCk_InData As Date
    Public Property BtCk_InGaiola As Integer
    Public Property BtCk_InNos As Boolean
    Public Property BtCk_InPulgas As Boolean
    Public Property BtCk_InCarrapatos As Boolean
    Public Property BtCk_InOuvidoInfla As Boolean
    Public Property BtCk_InOlhosIrritados As Boolean
    Public Property BtCk_InOlhosSecrecao As Boolean
    Public Property BtCk_InLesoesPele As Boolean
    Public Property BtCk_InColeira As Boolean
    Public Property BtCk_InColeiraAntPulga As Boolean
    Public Property BtCk_InColeiraRetratil As Boolean
    Public Property BtCk_InEnfocador As Boolean
    Public Property BtCk_InEscovaDt As Boolean
    Public Property BtCk_InPastaDt As Boolean
    Public Property BtCk_InGuia As Boolean
    Public Property BtCk_InPeitoral As Boolean
    Public Property BtCk_InOutros As String
    Public Property BtCk_OutData As Date
    Public Property BtCk_OutDesembolo As Integer
    Public Property BtCk_OutSubPelos As Integer
    Public Property BtCk_OutConfOuvidos As Boolean
    Public Property BtCk_OutConfUnhas As Boolean
    Public Property BtCk_OutOutros As String
    Public Property BtCk_OutFBanho As Integer
    Public Property BtCk_OutFSecagem As Integer
    Public Property BtCk_OutFTosa As Integer
    Public Property BtCk_St As String
    Public Property BtCk_IdAg As Integer
    Public Property BtCk_Aplique As Boolean
    Public Property BtCk_Bandana As Boolean
    Public Property BtCk_Borboleta As Boolean
    Public Property BtCk_Borrachinha As Boolean
    Public Property BtCk_Cachecol As Boolean
    Public Property BtCk_Gola As Boolean
    Public Property BtCk_Gravata As Boolean
    Public Property BtCk_LacinhoQtd As Integer
    Public Property BtCk_PresilhaQtd As Integer
    Public Property BtCk_Scrunchie As Boolean
    Public Property BtCk_Tematico As Boolean
    Public Property BtCk_Item As String
    Public Property bt_id_func As Integer
    Public Property bt_nome_Func As String
    Public Property bt_qtd_Banho As Integer
    Public Property bt_qtd_Secagem As Integer
    Public Property bt_qtd_Tosa As Integer

#End Region
    Private Parametro As List(Of SqlParameter)
    Private Sub MoveParam()
        Parametro.Add(New SqlParameter("@TipoOperacao", TipoOperacao))

        Parametro.Add(New SqlParameter("@Bt_Id", Bt_Id))
        Parametro.Add(New SqlParameter("@Bt_Os", Bt_Os))
        Parametro.Add(New SqlParameter("@Bt_Tutor", Bt_Tutor))
        Parametro.Add(New SqlParameter("@Bt_Pet", Bt_Pet))
        Parametro.Add(New SqlParameter("@Bt_TpPcte", Bt_TpPcte))
        Parametro.Add(New SqlParameter("@Bt_TpBanho", Bt_TpBanho))
        Parametro.Add(New SqlParameter("@Bt_TosaHig", Bt_TosaHig))
        Parametro.Add(New SqlParameter("@Bt_TosaMaq", Bt_TosaMaq))
        Parametro.Add(New SqlParameter("@Bt_TosaTrimming", Bt_TosaTrimming))
        Parametro.Add(New SqlParameter("@Bt_TosaTesoura", Bt_TosaTesoura))
        Parametro.Add(New SqlParameter("@Bt_TosaPadaoRaca", Bt_TosaPadaoRaca))
        Parametro.Add(New SqlParameter("@Bt_Penteado", Bt_Penteado))
        Parametro.Add(New SqlParameter("@Bt_Outros", Bt_Outros))
        Parametro.Add(New SqlParameter("@Bt_AlergiaShampoo", Bt_AlergiaShampoo))
        Parametro.Add(New SqlParameter("@Bt_AlergiaLamina", Bt_AlergiaLamina))
        Parametro.Add(New SqlParameter("@Bt_AlergiaPerfume", Bt_AlergiaPerfume))
        Parametro.Add(New SqlParameter("@Bt_AlergiaOutros", Bt_AlergiaOutros))
        Parametro.Add(New SqlParameter("@Bt_Enfeite", Bt_Enfeite))
        Parametro.Add(New SqlParameter("@Bt_ObsTutor", Bt_ObsTutor))
        Parametro.Add(New SqlParameter("@Bt_ObsServico", Bt_ObsServico))
        Parametro.Add(New SqlParameter("@Bt_EnfeiteBandana", Bt_EnfeiteBandana))
        Parametro.Add(New SqlParameter("@Bt_EnfeiteLaco", Bt_EnfeiteLaco))
        Parametro.Add(New SqlParameter("@Bt_EnfeiteGravata", Bt_EnfeiteGravata))
        Parametro.Add(New SqlParameter("@Bt_EnfeiteAdesivo", Bt_EnfeiteAdesivo))
        Parametro.Add(New SqlParameter("@Bt_EnfeiteNaoUsa", Bt_EnfeiteNaoUsa))
        Parametro.Add(New SqlParameter("@Bt_Hidratacao", Bt_Hidratacao))
        Parametro.Add(New SqlParameter("@Bt_St", Bt_St))

    End Sub
    Public Function BT_Contrato() As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            MoveParam()

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_BT_Contratado_I_U_D_S", Parametro)
            Bt_Id = banco.id_Increment
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Bt_Grupo(ByVal grp As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Grupo", grp))

            Tabela = banco.ExecutaDataTable("Sp_Itens_Grupo", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Sel_Servicos_Tutor(ByVal Tutor As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Tutor", Tutor))

            Tabela = banco.ExecutaDataTable("Sp_BT_Serv_Tutor", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Sel_Servicos_Pet(ByVal Pet As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Pet", Pet))

            Tabela = banco.ExecutaDataTable("Sp_BT_Serv_Pet", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Sel_Servicos_Bt(ByVal Os As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@OS", Os))


            Tabela = banco.ExecutaDataTable("Sp_BT_Sel_Servicos", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Sel_ContratoBanho(ByVal tp As String, ByVal Tutor As Integer, ByVal Id_Reg As Integer, ByVal Pet As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@TipoOperacao", tp))
            Parametro.Add(New SqlParameter("@Bt_Tutor", Tutor))
            Parametro.Add(New SqlParameter("@Bt_Id", Id_Reg))
            Parametro.Add(New SqlParameter("@Bt_Pet", Pet))

            Tabela = banco.ExecutaDataTable("Sp_BT_Contratado_S", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Private Sub MoveParamBanho()
        Parametro.Add(New SqlParameter("@TipoOperacao", TipoOperacao))

        Parametro.Add(New SqlParameter("@Btck_Id", BtCk_Id))
        Parametro.Add(New SqlParameter("@Btck_Os", BtCk_OS))
        Parametro.Add(New SqlParameter("@Btck_Nro", BtCk_Nro))
        Parametro.Add(New SqlParameter("@Btck_Tutor", BtCk_Tutor))
        Parametro.Add(New SqlParameter("@Btck_Pet", BtCk_Pet))
        Parametro.Add(New SqlParameter("@Btck_InData", BtCk_InData))
        Parametro.Add(New SqlParameter("@BtCk_InGaiola", BtCk_InGaiola))
        Parametro.Add(New SqlParameter("@BtCk_InNos", BtCk_InNos))
        Parametro.Add(New SqlParameter("@BtCk_InPulgas", BtCk_InPulgas))
        Parametro.Add(New SqlParameter("@BtCk_InCarrapatos", BtCk_InCarrapatos))
        Parametro.Add(New SqlParameter("@BtCk_InOuvidoInfla", BtCk_InOuvidoInfla))
        Parametro.Add(New SqlParameter("@BtCk_InOlhosIrritados", BtCk_InOlhosIrritados))
        Parametro.Add(New SqlParameter("@BtCk_InOlhosSecrecao", BtCk_InOlhosSecrecao))
        Parametro.Add(New SqlParameter("@BtCk_InLesoesPele", BtCk_InLesoesPele))
        Parametro.Add(New SqlParameter("@BtCk_InColeira", BtCk_InColeira))
        Parametro.Add(New SqlParameter("@BtCk_InColeiraAntPulga", BtCk_InColeiraAntPulga))
        Parametro.Add(New SqlParameter("@BtCk_InColeiraRetratil", BtCk_InColeiraRetratil))
        Parametro.Add(New SqlParameter("@BtCk_InEnfocador", BtCk_InEnfocador))
        Parametro.Add(New SqlParameter("@BtCk_InEscovaDt", BtCk_InEscovaDt))
        Parametro.Add(New SqlParameter("@BtCk_InPastaDt", BtCk_InPastaDt))
        Parametro.Add(New SqlParameter("@BtCk_InGuia", BtCk_InGuia))
        Parametro.Add(New SqlParameter("@BtCk_InPeitoral", BtCk_InPeitoral))
        Parametro.Add(New SqlParameter("@BtCk_InOutros", BtCk_InOutros))

        Parametro.Add(New SqlParameter("@BtCk_OutData", BtCk_OutData))
        Parametro.Add(New SqlParameter("@BtCk_OutDesembolo", BtCk_OutDesembolo))
        Parametro.Add(New SqlParameter("@BtCk_OutSubPelos", BtCk_OutSubPelos))
        Parametro.Add(New SqlParameter("@BtCk_OutConfOuvidos", BtCk_OutConfOuvidos))
        Parametro.Add(New SqlParameter("@BtCk_OutConfUnhas", BtCk_OutConfUnhas))
        Parametro.Add(New SqlParameter("@BtCk_OutOutros", BtCk_OutOutros))
        Parametro.Add(New SqlParameter("@BtCk_OutFBanho", BtCk_OutFBanho))
        Parametro.Add(New SqlParameter("@BtCk_OutFSecagem", BtCk_OutFSecagem))
        Parametro.Add(New SqlParameter("@BtCk_OutFTosa", BtCk_OutFTosa))
        Parametro.Add(New SqlParameter("@BtCk_St", BtCk_St))
        Parametro.Add(New SqlParameter("@BtCk_IdAg", BtCk_IdAg))

        Parametro.Add(New SqlParameter("@BtCk_Aplique", BtCk_Aplique))
        Parametro.Add(New SqlParameter("@BtCk_Bandana", BtCk_Bandana))
        Parametro.Add(New SqlParameter("@BtCk_Borboleta", BtCk_Borboleta))
        Parametro.Add(New SqlParameter("@BtCk_Borrachinha", BtCk_Borrachinha))
        Parametro.Add(New SqlParameter("@BtCk_Cachecol", BtCk_Cachecol))
        Parametro.Add(New SqlParameter("@BtCk_Gola", BtCk_Gola))
        Parametro.Add(New SqlParameter("@BtCk_Gravata", BtCk_Gravata))
        Parametro.Add(New SqlParameter("@BtCk_LacinhoQtd", BtCk_LacinhoQtd))
        Parametro.Add(New SqlParameter("@BtCk_PresilhaQtd", BtCk_PresilhaQtd))
        Parametro.Add(New SqlParameter("@BtCk_Scrunchie", BtCk_Scrunchie))
        Parametro.Add(New SqlParameter("@BtCk_Tematico", BtCk_Tematico))
        Parametro.Add(New SqlParameter("@BtCk_Item", BtCk_Item))

    End Sub
    Public Function ChecksBanho() As Object
        Dim retorno As Object
        Dim banco As New DataAcces
        Try
            'MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)
            MoveParamBanho()

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_BT_Check_I_U_S", Parametro)
            BtCk_Id = banco.id_Increment

            banco.CloseConn()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpDateSt(ByVal OS As Integer, ByVal dt As Date, ByVal St As String, ByVal id As Integer) As Object

        Dim retorno As Object
        Dim banco As New DataAcces
        Try
            'MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("@ag_Os", OS))
            Parametro.Add(New SqlParameter("@ag_Data", dt))
            Parametro.Add(New SqlParameter("@ag_St", St))
            Parametro.Add(New SqlParameter("@Bt_CkId", id))

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Agenda_UpDate_St", Parametro)

            banco.CloseConn()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function UpDateStDaOs(ByVal OS As Integer, ByVal St As String) As Object

        Dim retorno As Object
        Dim banco As New DataAcces
        Try
            'MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("@Bt_Os", OS))
            Parametro.Add(New SqlParameter("@Bt_St", St))

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Bt_UpDate_St", Parametro)

            banco.CloseConn()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Le_CountSt(ByVal OS As Integer) As Object

        Dim retorno As Object
        Dim banco As New DataAcces
        Try
            'MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("@Bt_Os", OS))

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_BT_CountSt", Parametro)

            banco.CloseConn()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Sel_ContratosTutor(ByVal Tutor As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Bt_Tutor", Tutor))

            Tabela = banco.ExecutaDataTable("Sp_BT_Sel_Ctrs_Tutor", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeContrato(ByVal Tp As String, ByVal TutoR As Integer, ByVal Id_Ctr As Integer, ByVal Pet As Integer) As Object
        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Bt_Id", Id_Ctr))

            dr = banco.ExecutaStoreProcedureReader("Sp_BT_Contratado_T", Parametro)
            retorno = False
            Do While dr.Read

                Bt_AlergiaLamina = dr("BtAlergiaLamina")
                Bt_AlergiaOutros = dr("BtAlergiaOutros")
                Bt_AlergiaPerfume = dr("BtAlergiaPerfume")
                Bt_AlergiaShampoo = dr("BtAlergiaShampoo")
                Bt_Enfeite = dr("BtEnfeite")
                Bt_Id = dr("BtId")
                Bt_ObsTutor = dr("BtObsTutor")
                Bt_OS = dr("BtOS")
                Bt_Outros = dr("BtOutros")
                Bt_Penteado = dr("BtPenteado")
                Bt_Pet = dr("BtPet")
                Bt_TosaHig = dr("BtTosaHig")
                Bt_TosaMaq = dr("BtTosaMaq")
                Bt_TosaPadaoRaca = dr("BtTosaPadaoRaca")
                Bt_TosaTesoura = dr("BtTosaTesoura")
                Bt_TosaTrimming = dr("BtTosaTrimming")
                Bt_TpBanho = dr("BtTpBanho")
                Bt_TpPcte = dr("BtTpPcte")
                Bt_Tutor = dr("BtTutor")
                Bt_ObsServico = dr("BtObsServico")
                Bt_EnfeiteBandana = dr("BtEnfeiteBandana")
                Bt_EnfeiteLaco = dr("BtEnfeiteLaco")
                Bt_EnfeiteGravata = dr("BtEnfeiteGravata")
                Bt_EnfeiteAdesivo = dr("BtEnfeiteAdesivo")
                Bt_EnfeiteNaoUsa = dr("BtEnfeiteNaoUsa")
                Bt_Hidratacao = dr("BtHidratacao")
                Bt_St = dr("BtSt")

                retorno = True
            Loop
            Return retorno
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LeChecks(ByVal OS As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Btck_Os", OS))

            Tabela = banco.ExecutaDataTable("Sp_BT_Check_OS", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeCeckID(ByVal Id_Check As Integer) As Object
        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@BtCk_Id", Id_Check))

            dr = banco.ExecutaStoreProcedureReader("Sp_BT_Check_Id", Parametro)
            retorno = False
            Do While dr.Read
                BtCk_Id = dr("BtCkID")
                BtCk_OS = dr("BtCkOS")
                BtCk_Nro = dr("BtCkNro")
                BtCk_Tutor = dr("BtCkTutor")
                BtCk_Pet = dr("BtCkPet")
                BtCk_InData = dr("BtCkInData")
                BtCk_InGaiola = dr("BtCkInGaiola")
                BtCk_InNos = dr("BtCkInNos")
                BtCk_InPulgas = dr("BtCkInPulgas")
                BtCk_InCarrapatos = dr("BtCkInCarrapatos")
                BtCk_InOuvidoInfla = dr("BtCkInOuvidoInfla")
                BtCk_InOlhosIrritados = dr("BtCkInOlhosIrritados")
                BtCk_InOlhosSecrecao = dr("BtCkInOlhosSecrecao")
                BtCk_InLesoesPele = dr("BtCkInLesoesPele")
                BtCk_InColeira = dr("BtCkInColeira")
                BtCk_InColeiraAntPulga = dr("BtCkInColeiraAntPulga")
                BtCk_InColeiraRetratil = dr("BtCkInColeiraRetratil")
                BtCk_InEnfocador = dr("BtCkInEnfocador")
                BtCk_InEscovaDt = dr("BtCkInEscovaDt")
                BtCk_InPastaDt = dr("BtCkInPastaDt")
                BtCk_InGuia = dr("BtCkInGuia")
                BtCk_InPeitoral = dr("BtCkInPeitoral")
                BtCk_InOutros = dr("BtCkInOutros")
                BtCk_OutData = dr("BtCkOutData")
                BtCk_OutDesembolo = dr("BtCkOutDesembolo")
                BtCk_OutSubPelos = dr("BtCkOutSubPelos")
                BtCk_OutConfOuvidos = dr("BtCkOutConfOuvidos")
                BtCk_OutConfUnhas = dr("BtCkOutConfUnhas")
                BtCk_OutOutros = dr("BtCkOutOutros")
                BtCk_OutFBanho = dr("BtCkOutFBanho")
                BtCk_OutFSecagem = dr("BtCkOutFSecagem")
                BtCk_OutFTosa = dr("BtCkOutFTosa")
                BtCk_Aplique = dr("BtCkAplique")
                BtCk_Bandana = dr("BtCkBandana")
                BtCk_Borboleta = dr("BtCkBorboleta")
                BtCk_Borrachinha = dr("BtCkBorrachinha")
                BtCk_Cachecol = dr("BtCkCachecol")
                BtCk_Gola = dr("BtCkGola")
                BtCk_Gravata = dr("BtCkGravata")
                BtCk_Scrunchie = dr("BtCkScrunchie")
                BtCk_Tematico = dr("BtCkTematico")
                BtCk_LacinhoQtd = dr("BtCkLacinhoQtd")
                BtCk_PresilhaQtd = dr("BtCkPresilhaQtd")
                BtCk_Item = dr("BtCkItem")

                retorno = True
            Loop
            Return retorno
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeObsServ(ByVal Os As Integer) As Object
        Dim retorno As Boolean
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Bt_Os", Os))

            dr = banco.ExecutaStoreProcedureReader("Sp_BT_ObsServ", Parametro)
            retorno = False
            Do While dr.Read
                Bt_ObsServico = dr("BtObsServico")

                retorno = True
            Loop
            Return retorno
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Sel_AgDoPet(ByVal Pet As Integer) As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Ag_Pet", Pet))

            Tabela = banco.ExecutaDataTable("Sp_Agenda_Sel_AgPet", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function IU_Meta(ByVal dt As Date) As Object

        Dim retorno As Object
        Dim banco As New DataAcces

        Dim dr As IDataReader
        'Dim dr_M As IDataReader
        Dim Par_Meta As List(Of SqlParameter)
        Dim Par_F As List(Of SqlParameter)

        Try
            Par_F = New List(Of SqlParameter)

            Par_F.Add(New SqlParameter("@Data", dt))
            dr = banco.ExecutaStoreProcedureReader("Sp_BT_Sel_Func", Par_F)
            bt_id_func = 0
            Do While dr.Read
                bt_id_func = dr("uscodfol")
                bt_nome_Func = dr("usuario")

                If bt_id_func = 0 Then
                    bt_nome_Func = "NAO LANCADO"
                End If

                Sel_Qtd(dt, bt_id_func)

                Par_Meta = New List(Of SqlParameter)
                Par_Meta.Add(New SqlParameter("@mt_Data", dt))
                Par_Meta.Add(New SqlParameter("@mt_Func", bt_id_func))
                Par_Meta.Add(New SqlParameter("@mt_NOME", bt_nome_Func))
                Par_Meta.Add(New SqlParameter("@mt_META", 15))
                Par_Meta.Add(New SqlParameter("@MT_BANHO", bt_qtd_Banho))
                Par_Meta.Add(New SqlParameter("@MT_SECAGEM", bt_qtd_Secagem))
                Par_Meta.Add(New SqlParameter("@MT_TOSA", bt_qtd_Tosa))
                Dim db As New DataAcces
                retorno = db.ExecuteStoreProcedure("Sp_Bt_Meta_IU", Par_Meta)

            Loop

            banco.CloseConn()
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Sel_Qtd(ByVal dt As Date, ByVal Func As Integer) As Object

        Dim retorno As Object
        Dim banco As New DataAcces
        Dim drB As IDataReader
        Dim drS As IDataReader
        Dim drF As IDataReader
        Dim P_Banho As List(Of SqlParameter)
        Dim P_Sec As List(Of SqlParameter)
        Dim P_Tosa As List(Of SqlParameter)
        bt_qtd_Banho = 0
        bt_qtd_Secagem = 0
        bt_qtd_Tosa = 0

        Try
            P_Banho = New List(Of SqlParameter)
            P_Banho.Add(New SqlParameter("@Data", dt))
            P_Banho.Add(New SqlParameter("@Func", Func))

        drB = banco.ExecutaStoreProcedureReader("Sp_BT_Count_Banho", P_Banho)
        Do While drB.Read
            bt_qtd_Banho = drB("Banho")
        Loop

        banco.CloseConn()

            P_Sec = New List(Of SqlParameter)
            P_Sec.Add(New SqlParameter("@Data", dt))
            P_Sec.Add(New SqlParameter("@Func", Func))

            Dim b1 As New DataAcces
        drS = b1.ExecutaStoreProcedureReader("Sp_BT_Count_Secagem", P_Sec)
        Do While drS.Read
                bt_qtd_Secagem = drS("Secagem")
            Loop
            banco.CloseConn()

            P_Tosa = New List(Of SqlParameter)
            P_Tosa.Add(New SqlParameter("@Data", dt))
            P_Tosa.Add(New SqlParameter("@Func", Func))

            Dim b2 As New DataAcces
        drF = b2.ExecutaStoreProcedureReader("Sp_BT_Count_Tosa", P_Tosa)
            Do While drF.Read
                bt_qtd_Tosa = drF("Tosa")
            Loop

            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Le_Metas() As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Data", Now))

            Tabela = banco.ExecutaDataTable("Sp_BT_Sel_Meta", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
