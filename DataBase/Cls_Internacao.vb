Imports System.Data.SqlClient

Public Class Cls_Internacao
    Public Property TipoOp As String
    Public Property Id_Prot As Integer
    Public Property int_ProtID As String
    Public Property int_ProtDesc As String
    Public Property int_ProtItem As String
    Public Property int_ProtFarmaco As String
    Public Property int_ProtDose As String
    Public Property int_ProtConcent As String
    Public Property int_ProtVolume As String
    Public Property int_ProtVia As String
    Public Property int_ProtFreq As String

    Public N_Tutor As String
    Public N_Pet As String
    Public N_Sexo As String
    Public N_Especie As String
    Public N_Raca As String
    Public N_Foto As String
#Region "protocolo"
    ''' <summary>
    ''' CRUD DO PROTOCOLO TERAPEUTICO 
    ''' </summary>
    ''' <returns></returns>
    Public Function InsertProtocolo() As Boolean
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Try

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Tipo", TipoOp))
            Parametro.Add(New SqlParameter("@IdProt", Id_Prot))
            Parametro.Add(New SqlParameter("@intProtID", int_ProtID))
            Parametro.Add(New SqlParameter("@intProtDesc", int_ProtDesc))
            Parametro.Add(New SqlParameter("@intProtItem", int_ProtItem))
            Parametro.Add(New SqlParameter("@intProtFarmaco", int_ProtFarmaco))
            Parametro.Add(New SqlParameter("@intProtDose", int_ProtDose))
            Parametro.Add(New SqlParameter("@intProtConcent", int_ProtConcent))
            Parametro.Add(New SqlParameter("@intProtVolume", int_ProtVolume))
            Parametro.Add(New SqlParameter("@intProtVia", int_ProtVia))
            Parametro.Add(New SqlParameter("@intProtFreq", int_ProtFreq))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Intern_Prot_IUDS", Parametro)
            Id_Prot = banco.id_Increment
            banco.CloseConn()

            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeProtocolo() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@tipo", TipoOp))
            Parametro.Add(New SqlParameter("@intProtID", int_ProtID))
            Parametro.Add(New SqlParameter("@idProt", 0))
            Parametro.Add(New SqlParameter("@intProtDesc", int_ProtDesc))
            Parametro.Add(New SqlParameter("@intProtItem", int_ProtItem))
            Parametro.Add(New SqlParameter("@intProtFarmaco", int_ProtFarmaco))
            Parametro.Add(New SqlParameter("@intProtDose", int_ProtDose))
            Parametro.Add(New SqlParameter("@intProtConcent", int_ProtConcent))
            Parametro.Add(New SqlParameter("@intProtVolume", int_ProtVolume))
            Parametro.Add(New SqlParameter("@intProtVia", int_ProtVia))
            Parametro.Add(New SqlParameter("@intProtFreq", int_ProtFreq))

            Tabela = banco.ExecutaDataTable("Sp_Intern_Prot_IUDS", Parametro)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaProtocolo() As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("@IDprot", Id_Prot))
            ''Parametro.Add(New SqlParameter("@intProtID", int_ProtID))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Intern_Prot_Sel", Parametro)
            '' preencher as propriedades
            While dr.Read
                Id_Prot = dr("IdProt")
                int_ProtID = dr("intProtID")
                int_ProtDesc = dr("intProtDesc")
                int_ProtItem = dr("intProtItem")
                int_ProtFarmaco = dr("intProtFarmaco")
                int_ProtDose = dr("intProtDose")
                int_ProtConcent = dr("intProtConcent")
                int_ProtVolume = dr("intProtVolume")
                int_ProtVia = dr("intProtVia")
                int_ProtFreq = dr("intProtFreq")
            End While

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaTpSelProt(ByVal Tp As Integer) As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("@tipo", Tp))
            Parametro.Add(New SqlParameter("@idProt", Id_Prot))
            Parametro.Add(New SqlParameter("@intProtID", int_ProtID))
            Parametro.Add(New SqlParameter("@intProtDesc", int_ProtDesc))
            Parametro.Add(New SqlParameter("@intProtItem", int_ProtItem))
            Parametro.Add(New SqlParameter("@intProtFarmaco", int_ProtFarmaco))
            Parametro.Add(New SqlParameter("@intProtDose", int_ProtDose))
            Parametro.Add(New SqlParameter("@intProtConcent", int_ProtConcent))
            Parametro.Add(New SqlParameter("@intProtVolume", int_ProtVolume))
            Parametro.Add(New SqlParameter("@intProtVia", int_ProtVia))
            Parametro.Add(New SqlParameter("@intProtFreq", int_ProtFreq))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Intern_Prot_IUDS", Parametro)
            '' preencher as propriedades
            While dr.Read
                Id_Prot = dr("IdProt")
                int_ProtID = dr("intProtID")
                int_ProtDesc = dr("intProtDesc")
                int_ProtItem = dr("intProtItem")
                int_ProtFarmaco = dr("intProtFarmaco")
                int_ProtDose = dr("intProtDose")
                int_ProtConcent = dr("intProtConcent")
                int_ProtVolume = dr("intProtVolume")
                int_ProtVia = dr("intProtVia")
            End While

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscaTutor(ByVal tutor As Integer, ByVal pet As Integer) As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("@cl_id", tutor))
            Parametro.Add(New SqlParameter("@id_ani", pet))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Intern_Prot_Sel_TP", Parametro)
            '' preencher as propriedades
            While dr.Read
                N_Tutor = dr("clnome")
                N_Pet = dr("aninome")
                N_Sexo = dr("anisexo")
                N_Especie = dr("AniEspécie")
                N_Raca = dr("AniRaca")
                N_Foto = dr("AniFoto")
            End While

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "internacao"
    ''' <summary>
    ''' crud REGISTRO da internacao
    ''' o campo int_ID é a chave da internacao e deve estar em todos os registros
    ''' </summary>
    ''' <returns>TRUE = CLIENTE ADICIONADO</returns>
    Public int_Pet As Integer
    Public int_Data As Date
    Public int_ID As Integer
    Public int_Diag As String
    Public int_ProtTerap As String
    Public int_Obs As String
    Public int_DataFim As Date
    Public int_Dias As Integer
    Public Par_Int As List(Of SqlParameter)
    Private Sub MoveParInt()
        '' Dim Par_Int As List(Of SqlParameter)
        Par_Int = New List(Of SqlParameter)
        Par_Int.Add(New SqlParameter("@Tipo", TipoOp))
        Par_Int.Add(New SqlParameter("@intPet", int_Pet))
        Par_Int.Add(New SqlParameter("@intData", int_Data))
        Par_Int.Add(New SqlParameter("@intID", int_ID))
        Par_Int.Add(New SqlParameter("@intDiag", int_Diag))
        Par_Int.Add(New SqlParameter("@intProtTerap", int_ProtTerap))
        Par_Int.Add(New SqlParameter("@intObs", int_Obs))
        Par_Int.Add(New SqlParameter("@intDias", int_Dias))
        Par_Int.Add(New SqlParameter("@intDataFim", int_DataFim))

    End Sub
    Public Function ManutReg_Internacao()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParInt()

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Internacao_IUDS", Par_Int)
            int_ID = banco.id_Increment
            banco.CloseConn()

            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaInternacao(ByVal Tp As Integer) As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@tipo", Tp))
            Parametro.Add(New SqlParameter("@intID", int_ID))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Intern_Prot_Sel_TP", Parametro)
            '' preencher as propriedades
            While dr.Read
                int_Pet = dr("intPet")
                int_Data = dr("intData")
                int_ID = dr("intID")
                int_Diag = dr("intDiag")
                int_ProtTerap = dr("intProtTerap")
                int_Obs = dr("intObs")
                int_Dias = dr("intDias")
                int_DataFim = dr("intDataFim")

            End While

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeInternacoesPet() As Object
        Dim banco As DataAcces
        Dim Tabela As DataTable

        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParInt()

            Tabela = banco.ExecutaDataTable("Sp_Internacao_IUDS", Par_Int)
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return Tabela

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region
#Region "CONTROLE DA MEDICACAO"
    Public m_ID As Integer
    Public m_Item As String
    Public m_Desc As String
    Public m_Dose As String
    Public m_Via As String
    Public m_Pos As String
    Public m_Cons As String
    Public m_Vol As String
    Public m_Freq As Integer
    Public m_Reg As Integer '' /*  ID DA INTERNACAO */
    Public m_Data As Date
    Public m_Hora As Date
    Public Par_CtlMedic As List(Of SqlParameter)
    Private Sub MoveParMedic()

        Par_CtlMedic = New List(Of SqlParameter)

        Par_CtlMedic.Add(New SqlParameter("@Tipo", TipoOp))
        Par_CtlMedic.Add(New SqlParameter("@mID", m_ID))
        Par_CtlMedic.Add(New SqlParameter("@mItem", m_Item))
        Par_CtlMedic.Add(New SqlParameter("@mDesc", m_Desc))
        Par_CtlMedic.Add(New SqlParameter("@mDose", m_Dose))
        Par_CtlMedic.Add(New SqlParameter("@mVia", m_Via))
        Par_CtlMedic.Add(New SqlParameter("@mPos", m_Pos))
        Par_CtlMedic.Add(New SqlParameter("@mCons", m_Cons))
        Par_CtlMedic.Add(New SqlParameter("@mVol", m_Vol))
        Par_CtlMedic.Add(New SqlParameter("@mFreq", m_Freq))
        Par_CtlMedic.Add(New SqlParameter("@mReg", m_Reg))
        Par_CtlMedic.Add(New SqlParameter("@mData", String.Format("{0:dd/MM/yyyy}", m_Data)))
        Par_CtlMedic.Add(New SqlParameter("@mHora", String.Format(" {0:HH:mm:ss}", m_Hora)))


    End Sub
    Public Function ManutReg_Medicacao()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParMedic()

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Int_Medicacao_IUDS", Par_CtlMedic)
            m_ID = banco.id_Increment
            banco.CloseConn()

            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeMedicacoes_da_int(ByVal inter As Integer) As Object


        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Tipo", 1))
        Parametro.Add(New SqlParameter("@MReg", inter))

        dt = banco.ExecutaDataTable("Sp_Int_Medic_Sel_Tudo", Parametro)

        Return dt

    End Function

    Public Function BuscaMedicacao(ByVal id As Integer) As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Tipo", 2))

            Parametro.Add(New SqlParameter("@mReg", id))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Medic_Sel_Tudo", Parametro)
            '' preencher as propriedades
            While dr.Read

                m_ID = dr("mid")
                m_Item = dr("mitem")
                m_Desc = dr("mdesc")
                m_Dose = dr("mdose")
                m_Via = dr("mvia")
                m_Pos = dr("mpos")
                m_Cons = dr("mcons")
                m_Vol = dr("mvol")
                m_Freq = dr("mfreq")
                m_Reg = dr("mreg")
                m_Data = dr("mdata")

                m_Hora = Format("HH:mm:ss", dr("mhora"))

            End While

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region
#Region "Monitorização"
    ''' <summary>
    ''' CRUD Da monitorização
    ''' </summary>
    ''' <returns></returns>
    ''' 
    Public Par_CtlMonit As List(Of SqlParameter)
    Public intMonit_IDInter As Integer
    Public intMonit_Tp As Integer
    Public intMonit_Data As Date
    Public intMonit_Hora As String
    Public intMonit_Valor As String
    Public intMonit_ID As Integer
    Public Function LeMonitTP(ByVal Tp As Integer, ByVal IdTp As Integer) As Object


        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Tipo", Tp))
        Parametro.Add(New SqlParameter("@intTpId", IdTp))

        dt = banco.ExecutaDataTable("Sp_Int_MonitTp_Sel", Parametro)

        Return dt

    End Function
    Private Sub MoveParMonit()

        Par_CtlMonit = New List(Of SqlParameter)

        Par_CtlMonit.Add(New SqlParameter("@Tipo", TipoOp))
        Par_CtlMonit.Add(New SqlParameter("@intMonitIDInter", intMonit_IDInter))
        Par_CtlMonit.Add(New SqlParameter("@intMonitTp", intMonit_Tp))
        Par_CtlMonit.Add(New SqlParameter("@intMonitData", Format("yyyy-MM-dd", intMonit_Data)))
        Par_CtlMonit.Add(New SqlParameter("@intMonitHora", Format("HH:mm:ss", intMonit_Hora)))
        Par_CtlMonit.Add(New SqlParameter("@intMonitValor", intMonit_Valor))
        Par_CtlMonit.Add(New SqlParameter("@intMonitId", intMonit_ID))

    End Sub
    Public Function ManutReg_Monitorizacao()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParMonit()

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Int_Monit_IUD", Par_CtlMonit)

            banco.CloseConn()

            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LePivot(ByVal IdTp As Integer, ByVal Proced As String) As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Internacao", IdTp))

        dt = banco.ExecutaDataTable(Proced, Parametro)

        Return dt

    End Function
    Public Function LeRegMonitorizacao() As Boolean
        Dim retorno As Boolean = False
        ''Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParMonit()

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Monit_IUD", Par_CtlMonit)
            '' preencher as propriedades
            While dr.Read
                intMonit_IDInter = dr("intMonitIDInter")
                intMonit_Tp = dr("intMonitTp")
                intMonit_Data = Format("dd/MM/yyyy", dr("intMonitData"))
                intMonit_Hora = Format("HH:mm:ss", dr("intMonitHora"))
                intMonit_Valor = dr("intMonitValor")
                intMonit_ID = dr("intMonitId")
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Exames"
    ''' <summary>
    ''' CRUD Da monitorização
    ''' </summary>
    ''' <returns></returns>
    ''' 
    Public Par_CtlExames As List(Of SqlParameter)
    Public ex_IDInter As Integer
    Public ex_TpExame As Integer
    Public ex_Data As Date
    Public ex_Hora As String
    Public ex_Valor As String
    Public ex_Id As String
    Private Sub MoveParExames()

        Par_CtlExames = New List(Of SqlParameter)

        Par_CtlExames.Add(New SqlParameter("@Tipo", TipoOp))
        Par_CtlExames.Add(New SqlParameter("@exIDInter", ex_IDInter))
        Par_CtlExames.Add(New SqlParameter("@exTpExame", ex_TpExame))
        Par_CtlExames.Add(New SqlParameter("@exData", Format("dd/MM/yyyy", ex_Data)))
        Par_CtlExames.Add(New SqlParameter("@exHora", Format("HH:mm:ss", ex_Hora)))
        Par_CtlExames.Add(New SqlParameter("@exValor", ex_Valor))
        Par_CtlExames.Add(New SqlParameter("@exId", ex_Id))
    End Sub

    Public Function ManutReg_Exames()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParExames()
            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Int_Exame_IUDS", Par_CtlExames)
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeRegExame() As Boolean
        Dim retorno As Boolean = False
        ''Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParExames()
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Exame_IUDS", Par_CtlExames)
            '' preencher as propriedades
            ex_Id = 0
            While dr.Read
                ex_IDInter = dr("exIDInter")
                ex_TpExame = dr("exTpExame")
                ex_Data = Format("dd/MM/yyyy", dr("exData"))
                ex_Hora = Format("HH:mm:ss", dr("exHora"))
                ex_Valor = dr("exValor")
                ex_Id = dr("exId")
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region
#Region "Fluido"
    Public Par_CtlFluido As List(Of SqlParameter)
    Public fl_IDInter As Integer
    Public fl_TpFluido As Integer
    Public fl_Data As Date
    Public fl_Hora As String
    Public fl_Valor As String
    Public fl_Id As String
    Private Sub MoveParFluido()

        Par_CtlFluido = New List(Of SqlParameter)

        Par_CtlFluido.Add(New SqlParameter("@Tipo", TipoOp))
        Par_CtlFluido.Add(New SqlParameter("@flIDInter", fl_IDInter))
        Par_CtlFluido.Add(New SqlParameter("@flTpFluido", fl_TpFluido))
        Par_CtlFluido.Add(New SqlParameter("@flData", Format("dd/MM/yyyy", fl_Data)))
        Par_CtlFluido.Add(New SqlParameter("@flHora", Format("HH:mm:ss", fl_Hora)))
        Par_CtlFluido.Add(New SqlParameter("@flValor", fl_Valor))
        Par_CtlFluido.Add(New SqlParameter("@flId", fl_Id))
    End Sub

    Public Function ManutReg_Fluido()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParFluido()
            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Int_Fluido_IUD", Par_CtlFluido)
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeRegFluido() As Boolean
        Dim retorno As Boolean = False
        ''Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParFluido()
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Fluido_IUD", Par_CtlFluido)
            '' preencher as propriedades7
            fl_Id = 0
            While dr.Read
                fl_IDInter = dr("flIDInter")
                fl_TpFluido = dr("flTpFluido")
                fl_Data = Format("dd/MM/yyyy", dr("flData"))
                fl_Hora = Format("HH:mm:ss", dr("flHora"))
                fl_Valor = dr("flValor")
                fl_Id = dr("flId")
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Infusao"
    Public Par_CtlInfu As List(Of SqlParameter)
    Public is_IDInter As Integer
    Public is_TpInfusao As Integer
    Public is_Data As Date
    Public is_Hora As String
    Public is_Valor As String
    Public is_Id As String
    Private Sub MoveParInfu()

        Par_CtlInfu = New List(Of SqlParameter)

        Par_CtlInfu.Add(New SqlParameter("@Tipo", TipoOp))
        Par_CtlInfu.Add(New SqlParameter("@isIDInter", is_IDInter))
        Par_CtlInfu.Add(New SqlParameter("@isTpInfusao", is_TpInfusao))
        Par_CtlInfu.Add(New SqlParameter("@isData", Format("dd/MM/yyyy", is_Data)))
        Par_CtlInfu.Add(New SqlParameter("@isHora", Format("HH:mm:ss", is_Hora)))
        Par_CtlInfu.Add(New SqlParameter("@isValor", is_Valor))
        Par_CtlInfu.Add(New SqlParameter("@isId", is_Id))

    End Sub

    Public Function ManutReg_Infu()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParInfu()
            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Int_Infusao_IUD", Par_CtlInfu)
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeRegInfu() As Boolean
        Dim retorno As Boolean = False
        ''Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParInfu()
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Infusao_IUD", Par_CtlInfu)
            '' preencher as propriedades
            is_Id = 0
            While dr.Read
                is_IDInter = dr("isIDInter")
                is_TpInfusao = dr("isTpInfusao")
                is_Data = Format("dd/MM/yyyy", dr("isData"))
                is_Hora = Format("HH:mm:ss", dr("isHora"))
                is_Valor = dr("isValor")
                is_Id = dr("isId")
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region "Evolucao / obs"
    Public Par_CtlEvolu As List(Of SqlParameter)
    Public ev_IDInter As Integer
    Public ev_Data As Date
    Public ev_Hora As String
    Public ev_Descricao As String
    Public ev_Id As String
    Private Sub MoveParEvolu()
        Par_CtlEvolu = New List(Of SqlParameter)
        Par_CtlEvolu.Add(New SqlParameter("@Tipo", TipoOp))
        Par_CtlEvolu.Add(New SqlParameter("@evIDInter", ev_IDInter))
        Par_CtlEvolu.Add(New SqlParameter("@evData", Format("dd/MM/yyyy", ev_Data)))
        Par_CtlEvolu.Add(New SqlParameter("@evHora", Format("HH:mm:ss", ev_Hora)))
        Par_CtlEvolu.Add(New SqlParameter("@evDescricao", ev_Descricao))
        Par_CtlEvolu.Add(New SqlParameter("@evId", ev_Id))
    End Sub

    Public Function ManutReg_Evolu()
        Dim retorno As Boolean
        Dim banco As DataAcces
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParEvolu()
            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Int_Evolu_IUD", Par_CtlEvolu)
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeRegEvolu() As Boolean
        Dim retorno As Boolean = False
        ''Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParEvolu()
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Evolu_IUD", Par_CtlEvolu)
            '' preencher as propriedades
            ev_Id = 0
            While dr.Read
                ev_IDInter = dr("evIDInter")
                ev_Data = Format("dd/MM/yyyy", dr("evData"))
                ev_Hora = Format("HH:mm:ss", dr("evHora"))
                ev_Descricao = dr("evDescricao")
                ev_Id = dr("evId")
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeRegEvolucao() As Boolean
        Dim retorno As Boolean = False
        ''Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            MoveParEvolu()

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Int_Evolu_IUD", Par_CtlEvolu)
            '' preencher as propriedades
            While dr.Read
                ev_IDInter = dr("evIDInter")
                ev_Data = Format("dd/MM/yyyy", dr("evData"))
                ev_Hora = Format("HH:mm:ss", dr("evHora"))
                ev_Descricao = dr("evDescricao")
                ev_Id = dr("evId")
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeEvolu_da_Int(ByVal Tp As Integer, ByVal IdInter As Integer) As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Tipo", Tp))
        Parametro.Add(New SqlParameter("@evIdInter", IdInter))
        Parametro.Add(New SqlParameter("@evData", Format("dd/MM/yyyy", ev_Data)))
        Parametro.Add(New SqlParameter("@evHora", Format("HH:mm:ss", ev_Hora)))
        Parametro.Add(New SqlParameter("@evDescricao", ev_Descricao))
        Parametro.Add(New SqlParameter("@evId", ev_Id))

        dt = banco.ExecutaDataTable("Sp_Int_Evolu_IUD", Parametro)

        Return dt

    End Function
#End Region
End Class
