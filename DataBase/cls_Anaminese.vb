Imports System.Data.SqlClient
Imports DataBase.Cls_Prontuario

Public Class cls_Anaminese

    Public anami_ID As Integer
    Public anami_Pet As Integer
    Public anami_Data As Date
    Public anami_Hora As String
    Public anami_Ret As Boolean
    Public anami_DoeAnt As String
    Public anami_DoeAtu As String
    Public anami_SdVomito As Boolean
    Public anami_SdRegurgitacao As Boolean
    Public anami_SdDiarreia As Boolean
    Public anami_SdApetite As Boolean
    Public anami_SdAgua As Boolean
    Public anami_SdOutros As String
    Public anami_SuUrinaNormal As Boolean
    Public anami_SuVolume As String
    Public anami_SuDificuldade As Boolean
    Public anami_SuSecrecao As Boolean
    Public anami_SuOutros As String
    Public anami_ScTosse As Boolean
    Public anami_ScCansaco As Boolean
    Public anami_ScSecreNasal As Boolean
    Public anami_ScOutros As String
    Public anami_SnConvulcao As Boolean
    Public anami_SnInclinacao As Boolean
    Public anami_SnAtaxia As Boolean
    Public anami_SnOutros As String
    Public anami_SlDificuldade As Boolean
    Public anami_SlAltPostura As Boolean
    Public anami_SlFraturas As Boolean
    Public anami_SlOutros As String
    Public anami_PPurido As Boolean
    Public anami_PEctoparasita As Boolean
    Public anami_PQuedaPelo As Boolean
    Public anami_PAlopecia As Boolean
    Public anami_POutros As String
    Public anami_OlSecrecao As Boolean
    Public anami_OlDefict As Boolean
    Public anami_OlPrurido As Boolean
    Public anami_OlOutros As String
    Public anami_OuPurido As Boolean
    Public anami_OuSecrecao As Boolean
    Public anami_OuOutros As String
    Public anami_AmbRural As Boolean
    Public anami_AmbUrbamo As Boolean
    Public anami_AmbAcessoRua As Boolean
    Public anami_AmbOutros As String
    Public anami_Contactantes As String
    Public anami_ProdToxico As String
    Public anami_AlRacaoSeca As Boolean
    Public anami_AlRacaoUmida As Boolean
    Public anami_AlRacaoPetisco As Boolean
    Public anami_AlNatCOsso As Boolean
    Public anami_AlNatSOsso As Boolean
    Public anami_AlNatCozida As Boolean
    Public anami_Vacina As Boolean
    Public anami_VacinaData As Date
    Public anami_VacinaObs As String
    Public anami_Endo As Boolean
    Public anami_EndoData As Date
    Public anami_EndoObs As String
    Public anami_Ecto As Boolean
    Public anami_EctoData As Date
    Public anami_EctoObs As String
    Public anami_AlergiaMedic As String
    Public anami_UsoMedicacao As String
    Public anami_UsoSupl As String
    Public anami_Cirurgias As String
    Public anami_Exames As String
    Public anami_FIVFeLV As Boolean
    Public anami_FIV As Boolean
    Public anami_PcHidratacao As Boolean
    Public anami_PcGlicemia As Boolean
    Public anami_PcMucosa As Boolean
    Public anami_PcPelagem As Boolean
    Public anami_PcFC As Integer
    Public anami_PcFR As Integer
    Public anami_PcCavOral As Boolean
    Public anami_PcCondAuditivo As Boolean
    Public anami_PcTemp As Integer
    Public anami_PcPressao As String
    Public anami_PcLinfonodos As Boolean
    Public anami_PcDeambulacao As Boolean
    Public anami_PcPropriocepcao As Boolean
    Public anami_PcPalpacao As Boolean
    Public anami_PcCavNasal As Boolean
    Public anami_PcOfitalmo As Boolean
    Public anami_Conduta As String
    Public anami_Tratamento As String
    Public anami_Diagnostico As String
    Public anami_Prognostico As String

    Public Tp As Integer
    Private Parametro As List(Of SqlParameter)

    Public Pet_Id As Integer
    Public Pet_Nome As String
    Public Pet_Foto As String

    Private Function MoveParam()

        Parametro.Add(New SqlParameter("@anami_ID", anami_ID))
        Parametro.Add(New SqlParameter("@anami_Pet", anami_Pet))
        Parametro.Add(New SqlParameter("@anami_Data", anami_Data))
        Parametro.Add(New SqlParameter("@anami_Hora", anami_Hora))
        Parametro.Add(New SqlParameter("@anami_Ret", anami_Ret))
        Parametro.Add(New SqlParameter("@anami_DoeAnt", anami_DoeAnt))
        Parametro.Add(New SqlParameter("@anami_DoeAtu", anami_DoeAtu))
        Parametro.Add(New SqlParameter("@anami_SdVomito", anami_SdVomito))
        Parametro.Add(New SqlParameter("@anami_SdRegurgitacao", anami_SdRegurgitacao))
        Parametro.Add(New SqlParameter("@anami_SdDiarreia", anami_SdDiarreia))
        Parametro.Add(New SqlParameter("@anami_SdApetite", anami_SdApetite))
        Parametro.Add(New SqlParameter("@anami_SdAgua", anami_SdAgua))
        Parametro.Add(New SqlParameter("@anami_SdOutros", anami_SdOutros))
        Parametro.Add(New SqlParameter("@anami_SuUrinaNormal", anami_SuUrinaNormal))
        Parametro.Add(New SqlParameter("@anami_SuVolume", anami_SuVolume))
        Parametro.Add(New SqlParameter("@anami_SuDificuldade", anami_SuDificuldade))
        Parametro.Add(New SqlParameter("@anami_SuSecrecao", anami_SuSecrecao))
        Parametro.Add(New SqlParameter("@anami_SuOutros", anami_SuOutros))
        Parametro.Add(New SqlParameter("@anami_ScTosse", anami_ScTosse))
        Parametro.Add(New SqlParameter("@anami_ScCansaco", anami_ScCansaco))
        Parametro.Add(New SqlParameter("@anami_ScSecreNasal", anami_ScSecreNasal))
        Parametro.Add(New SqlParameter("@anami_ScOutros", anami_ScOutros))
        Parametro.Add(New SqlParameter("@anami_SnConvulcao", anami_SnConvulcao))
        Parametro.Add(New SqlParameter("@anami_SnInclinacao", anami_SnInclinacao))
        Parametro.Add(New SqlParameter("@anami_SnAtaxia", anami_SnAtaxia))
        Parametro.Add(New SqlParameter("@anami_SnOutros", anami_SnOutros))
        Parametro.Add(New SqlParameter("@anami_SlDificuldade", anami_SlDificuldade))
        Parametro.Add(New SqlParameter("@anami_SlAltPostura", anami_SlAltPostura))
        Parametro.Add(New SqlParameter("@anami_SlFraturas", anami_SlFraturas))
        Parametro.Add(New SqlParameter("@anami_SlOutros", anami_SlOutros))
        Parametro.Add(New SqlParameter("@anami_PPurido", anami_PPurido))
        Parametro.Add(New SqlParameter("@anami_PEctoparasita", anami_PEctoparasita))
        Parametro.Add(New SqlParameter("@anami_PQuedaPelo", anami_PQuedaPelo))
        Parametro.Add(New SqlParameter("@anami_PAlopecia", anami_PAlopecia))
        Parametro.Add(New SqlParameter("@anami_POutros", anami_POutros))
        Parametro.Add(New SqlParameter("@anami_OlSecrecao", anami_OlSecrecao))
        '' Parametro.Add(New SqlParameter("@anami_OlSecrecao", anami_OlSecrecao))
        Parametro.Add(New SqlParameter("@anami_OlDefict", anami_OlDefict))
        Parametro.Add(New SqlParameter("@anami_OlPrurido", anami_OlPrurido))
        Parametro.Add(New SqlParameter("@anami_OlOutros", anami_OlOutros))
        Parametro.Add(New SqlParameter("@anami_OuPurido", anami_OuPurido))
        Parametro.Add(New SqlParameter("@anami_OuSecrecao", anami_OuSecrecao))
        Parametro.Add(New SqlParameter("@anami_OuOutros", anami_OuOutros))
        Parametro.Add(New SqlParameter("@anami_AmbRural", anami_AmbRural))
        Parametro.Add(New SqlParameter("@anami_AmbUrbamo", anami_AmbUrbamo))
        Parametro.Add(New SqlParameter("@anami_AmbAcessoRua", anami_AmbAcessoRua))
        Parametro.Add(New SqlParameter("@anami_AmbOutros", anami_AmbOutros))

        Parametro.Add(New SqlParameter("@anami_Contactantes", anami_Contactantes))
        Parametro.Add(New SqlParameter("@anami_ProdToxico", anami_ProdToxico))
        Parametro.Add(New SqlParameter("@anami_AlRacaoSeca", anami_AlRacaoSeca))
        Parametro.Add(New SqlParameter("@anami_AlRacaoUmida", anami_AlRacaoUmida))
        Parametro.Add(New SqlParameter("@anami_AlRacaoPetisco", anami_AlRacaoPetisco))
        Parametro.Add(New SqlParameter("@anami_AlNatCOsso", anami_AlNatCOsso))
        Parametro.Add(New SqlParameter("@anami_AlNatSOsso", anami_AlNatSOsso))
        Parametro.Add(New SqlParameter("@anami_AlNatCozida", anami_AlNatCozida))
        Parametro.Add(New SqlParameter("@anami_Vacina", anami_Vacina))
        Parametro.Add(New SqlParameter("@anami_VacinaData", anami_VacinaData))
        Parametro.Add(New SqlParameter("@anami_VacinaObs", anami_VacinaObs))
        Parametro.Add(New SqlParameter("@anami_Endo", anami_Endo))
        Parametro.Add(New SqlParameter("@anami_EndoData", anami_EndoData))
        Parametro.Add(New SqlParameter("@anami_EndoObs", anami_EndoObs))
        Parametro.Add(New SqlParameter("@anami_Ecto", anami_Ecto))
        Parametro.Add(New SqlParameter("@anami_EctoData", anami_EctoData))
        Parametro.Add(New SqlParameter("@anami_EctoObs", anami_EctoObs))
        Parametro.Add(New SqlParameter("@anami_AlergiaMedic", anami_AlergiaMedic))
        Parametro.Add(New SqlParameter("@anami_UsoMedicacao", anami_UsoMedicacao))
        Parametro.Add(New SqlParameter("@anami_UsoSupl", anami_UsoSupl))
        Parametro.Add(New SqlParameter("@anami_Cirurgias", anami_Cirurgias))
        Parametro.Add(New SqlParameter("@anami_Exames", anami_Exames))
        Parametro.Add(New SqlParameter("@anami_FIV", anami_FIV))
        Parametro.Add(New SqlParameter("@anami_FIVFeLV", anami_FIVFeLV))
        Parametro.Add(New SqlParameter("@anami_PcHidratacao", anami_PcHidratacao))
        Parametro.Add(New SqlParameter("@anami_PcGlicemia", anami_PcGlicemia))
        Parametro.Add(New SqlParameter("@anami_PcMucosa", anami_PcMucosa))
        Parametro.Add(New SqlParameter("@anami_PcPelagem", anami_PcPelagem))
        Parametro.Add(New SqlParameter("@anami_PcFC", anami_PcFC))
        Parametro.Add(New SqlParameter("@anami_PcFR", anami_PcFR))
        Parametro.Add(New SqlParameter("@anami_PcCavOral", anami_PcCavOral))
        Parametro.Add(New SqlParameter("@anami_PcCondAuditivo", anami_PcCondAuditivo))
        Parametro.Add(New SqlParameter("@anami_PcTemp", anami_PcTemp))
        Parametro.Add(New SqlParameter("@anami_PcPressao", anami_PcPressao))
        Parametro.Add(New SqlParameter("@anami_PcLinfonodos", anami_PcLinfonodos))
        Parametro.Add(New SqlParameter("@anami_PcDeambulacao", anami_PcDeambulacao))
        Parametro.Add(New SqlParameter("@anami_PcPropriocepcao", anami_PcPropriocepcao))
        Parametro.Add(New SqlParameter("@anami_PcPalpacao", anami_PcPalpacao))
        Parametro.Add(New SqlParameter("@anami_PcCavNasal", anami_PcCavNasal))
        Parametro.Add(New SqlParameter("@anami_PcOfitalmo", anami_PcOfitalmo))
        Parametro.Add(New SqlParameter("@anami_Conduta", anami_Conduta))
        Parametro.Add(New SqlParameter("@anami_Tratamento", anami_Tratamento))
        Parametro.Add(New SqlParameter("@anami_Diagnostico", anami_Diagnostico))
        Parametro.Add(New SqlParameter("@anami_Prognostico", anami_Prognostico))

    End Function
    Public Function CRUD_Anaminese() As Object
        Dim retorno As Object
        Dim banco As DataAcces
        Try
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Tp", Tp))
            MoveParam()

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Anami_IUD", Parametro)
            anami_ID = banco.id_Increment
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeAnaminese() As Object
        Dim retorno As Boolean = False
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@anami_ID", anami_ID))

            dr = banco.ExecutaStoreProcedureReader("Sp_Anami_Sel", Parametro)

            Do While dr.Read
                anami_ID = dr("anamiID")
                anami_Pet = dr("anamiPet")
                anami_Data = dr("anamiData")
                anami_Hora = dr("anamiHora")
                anami_DoeAnt = dr("anamiDoeAnt")
                anami_DoeAtu = dr("anamiDoeAtu")
                anami_SdVomito = dr("anamiSdVomito")
                anami_SdRegurgitacao = dr("anamiSdRegurgitacao")
                anami_SdDiarreia = dr("anamiSdDiarreia")
                anami_SdApetite = dr("anamiSdApetite")
                anami_SdAgua = dr("anamiSdAgua")
                anami_SdOutros = dr("anamiSdOutros")
                anami_SuUrinaNormal = dr("anamiSuUrinaNormal")
                anami_SuVolume = dr("anamiSuVolume")
                anami_SuDificuldade = dr("anamiSuDificuldade")
                anami_SuSecrecao = dr("anamiSuSecrecao")
                anami_SuOutros = dr("anamiSuOutros")
                anami_ScTosse = dr("anamiScTosse")
                anami_ScCansaco = dr("anamiScCansaco")
                anami_ScSecreNasal = dr("anamiScSecreNasal")
                anami_ScOutros = dr("anamiScOutros")
                anami_SnConvulcao = dr("anamiSnConvulcao")
                anami_SnInclinacao = dr("anamiSnInclinacao")
                anami_SnAtaxia = dr("anamiSnAtaxia")
                anami_SnOutros = dr("anamiSnOutros")
                anami_SlDificuldade = dr("anamiSlDificuldade")
                anami_SlAltPostura = dr("anamiSlAltPostura")
                anami_SlFraturas = dr("anamiSlFraturas")
                anami_SlOutros = dr("anamiSlOutros")
                anami_PPurido = dr("anamiPPurido")
                anami_PEctoparasita = dr("anamiPEctoparasita")
                anami_PQuedaPelo = dr("anamiPQuedaPelo")
                anami_PAlopecia = dr("anamiPAlopecia")
                anami_POutros = dr("anamiPOutros")
                anami_OlSecrecao = dr("anamiOlSecrecao")
                anami_OlDefict = dr("anamiOlDefict")
                anami_OlPrurido = dr("anamiOlPrurido")
                anami_OlOutros = dr("anamiOlOutros")
                anami_OuPurido = dr("anamiOuPurido")
                anami_OuSecrecao = dr("anamiOuSecrecao")
                anami_OuOutros = dr("anamiOuOutros")
                anami_Contactantes = dr("anamiContactantes")
                anami_ProdToxico = dr("anamiProdToxico")
                anami_AlRacaoSeca = dr("anamiAlRacaoSeca")
                anami_AlRacaoUmida = dr("anamiAlRacaoUmida")
                anami_AlRacaoPetisco = dr("anamiAlRacaoPetisco")
                anami_AlNatCOsso = dr("anamiAlNatCOsso")
                anami_AlNatSOsso = dr("anamiAlNatSOsso")
                anami_AlNatCozida = dr("anamiAlNatCozida")
                anami_Vacina = dr("anamiVacina")
                anami_VacinaData = dr("anamiVacinaData")
                anami_VacinaObs = dr("anamiVacinaObs")

                anami_EndoData = dr("anamiEndoData")
                anami_EndoObs = dr("anamiEndoObs")
                anami_Endo = dr("anamiEndo")

                anami_Ecto = dr("anamiEcto")
                anami_EctoData = dr("anamiEctoData")
                anami_EctoObs = dr("anamiEctoObs")

                anami_AlergiaMedic = dr("anamiAlergiaMedic")
                anami_UsoMedicacao = dr("anamiUsoMedicacao")
                anami_UsoSupl = dr("anamiUsoSupl")
                anami_Cirurgias = dr("anamiCirurgias")
                anami_Exames = dr("anamiExames")
                anami_FIV = dr("anamiFIV")
                anami_FIVFeLV = dr("anamiFIVFeLV")
                anami_PcHidratacao = dr("anamiPcHidratacao")
                anami_PcGlicemia = dr("anamiPcGlicemia")
                anami_PcMucosa = dr("anamiPcMucosa")
                anami_PcPelagem = dr("anamiPcPelagem")
                anami_PcFC = dr("anamiPcFC")
                anami_PcFR = dr("anamiPcFR")
                anami_PcCavOral = dr("anamiPcCavOral")
                anami_PcCondAuditivo = dr("anamiPcCondAuditivo")
                anami_PcTemp = dr("anamiPcTemp")
                anami_PcPressao = dr("anamiPcPressao")
                anami_PcLinfonodos = dr("anamiPcLinfonodos")
                anami_PcDeambulacao = dr("anamiPcDeambulacao")
                anami_PcPropriocepcao = dr("anamiPcPropriocepcao")
                anami_PcPalpacao = dr("anamiPcPalpacao")
                anami_PcCavNasal = dr("anamiPcCavNasal")
                anami_PcOfitalmo = dr("anamiPcOfitalmo")
                anami_Conduta = dr("anamiConduta")
                anami_Diagnostico = dr("anamiDiagnostico")
                anami_Prognostico = dr("anamiPrognostico")
                anami_Tratamento = dr("anamiTratamento")

                retorno = True
            Loop
            Return retorno
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaPet(ByVal Id As Integer) As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Animal", Id))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Animal_Sel", Parametro)
            '' preencher as propriedades
            While dr.Read
                Pet_Id = dr("IdAnimal")
                Pet_Nome = dr("AniNome")
                If IsDBNull(dr("AniFoto")) = False Then
                    Pet_Foto = dr("AniFoto")
                Else
                    Pet_Foto = ""
                End If

            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaConsultasPet(ByVal id As Integer)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID", id))

            ' EXCUTA A PROCEDURE

            Tabela = banco.ExecutaDataTable("Sp_Anami_SelPet", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
