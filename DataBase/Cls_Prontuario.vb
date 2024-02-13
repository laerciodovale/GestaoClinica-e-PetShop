Imports System.Data.SqlClient
Imports DataBase
Imports DataBase.Utils
Imports System.Windows.Forms
Public Class Cls_Prontuario

    Private Parametro As List(Of SqlParameter)
    'PROPRIEDADES 
    '' VARIAVEIS PARA O RECEITUARIO
    Public Property Rc_Id As Integer
    Public Property Rc_Cli As Integer
    Public Property Rc_Ani As Integer
    Public Property Rc_Dt As Date
    Public Property Rc_Nss As Integer
    Public Property Rc_Farmaco As String
    Public Property Rc_Meio As String
    Public Property Rc_Qtd As String
    Public Property Rc_Via As Integer
    Public Property Rc_Freq As Integer
    Public Property Rc_Dias As Integer
    Public Property Rc_Reco As String
    Public Property Rc_Esp As Boolean
    Public Property Rc_DescFarmaco As String
    Public Property Rc_Func As Integer

    '' VARIAVEIS DA AGENDA
    Public Property Ag_Id As Integer
    Public Property Ag_Data As Date
    Public Property ag_Hora As String
    Public Property ag_Cpf As String
    Public Property ag_idCli As Integer
    Public Property ag_Cliente As String
    Public Property ag_IdPet As Integer
    Public Property ag_NomePet As String
    Public Property ag_Contato As String
    Public Property ag_Email As String
    Public Property ag_Tipo As String
    Public Property ag_Obs As String
    Public Property Bt_Obs As String
    Public Property ag_Funcionario As String
    Public Property ag_St As String
    Public Property ag_Os As Integer
    Public Property ag_Ordem As Integer
    '' VARIAVEIS DA CONSULTA
    Public Property Cons_ID As Integer
    Public Property Cons_Animal As Integer
    Public Property Cons_Data As Date
    Public Property Cons_Hora As DateTime
    Public Property Cons_Tipo As String
    Public Property Cons_Anamnese As String
    Public Property Cons_t As String
    Public Property Cons_Peso As String
    Public Property Cons_RPM As String
    Public Property Cons_BPM As String
    Public Property Cons_PA As String
    Public Property Cons_Histsic As String
    Public Property Cons_Prog As String
    Public Property Cons_Diag As String
    Public Property Cons_DtRet As Date
    '' VARIAVEIS Da VACINA
    Public Property Vc_Id As Integer
    Public Property Vc_Ani As Integer
    Public Property Vc_Tp As String
    Public Property Vc_Dt As Date
    Public Property Vc_Dose As Integer
    Public Property Vc_Data As Date
    Public Property Vc_Item As String
    Public Property Vc_Mes As Integer
    Public Property Vc_Contato As Boolean
    Public Property Vc_Email As Boolean
    Public Property TipoOperacao As String
    Public Property Nome_Like As String
    Public Property Agenda_Vacina As String
    Public Function LeConsultasAni() As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ConsAnimal", Cons_Animal))

            ' EXCUTA A PROCEDURE

            Tabela = banco.ExecutaDataTable("Sp_Consulta_Sel_An", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaAConsulta() As Object

        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@ConsId", Cons_ID))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Consulta_Sel_Id", Parametro)
        '' preencher as propriedades
        Do While dr.Read
            Cons_Animal = dr("ConsAnimal")
            Cons_Data = dr("ConsData")
            Cons_Hora = dr("ConsHora")
            Cons_Tipo = dr("ConsTipo")
            Cons_Anamnese = dr("ConsAnamnese")
            Cons_t = dr("Const")
            Cons_Peso = dr("ConsPeso")
            Cons_RPM = dr("ConsRPM")
            Cons_BPM = dr("ConsBPM")
            Cons_PA = dr("ConsPA")
            Cons_Histsic = dr("ConsHistsic")
            Cons_Prog = dr("ConsProg")
            Cons_Diag = dr("ConsDiag")
            Cons_DtRet = dr("ConsDtRet")
            retorno = True
        Loop
        banco.CloseConn()

    End Function
    Private Sub MoveParametrosDaConsulta()
        '' ADICIONA OS PARAMETROS
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@TipoOperacao", TipoOperacao))
            Parametro.Add(New SqlParameter("@ConsAnimal", Cons_Animal))
            Parametro.Add(New SqlParameter("@ConsData", Cons_Data))
            Parametro.Add(New SqlParameter("@ConsHora", Cons_Hora))
            Parametro.Add(New SqlParameter("@ConsTipo", Cons_Tipo))
            Parametro.Add(New SqlParameter("@ConsAnamnese", Cons_Anamnese))
            Parametro.Add(New SqlParameter("@ConsT", Cons_t))
            Parametro.Add(New SqlParameter("@ConsPeso", Cons_Peso))
            Parametro.Add(New SqlParameter("@ConsRPM", Cons_RPM))
            Parametro.Add(New SqlParameter("@ConsBPM", Cons_BPM))
            Parametro.Add(New SqlParameter("@ConsPA", Cons_PA))
            Parametro.Add(New SqlParameter("@ConsHistsic", Cons_Histsic))
            Parametro.Add(New SqlParameter("@ConsProg", Cons_Prog))
            Parametro.Add(New SqlParameter("@ConsDiag", Cons_Diag))
            Parametro.Add(New SqlParameter("@ConsDtRet", Cons_DtRet))
            Parametro.Add(New SqlParameter("@ConsID", Cons_ID))

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function Insert_Consulta_iud() As Object

        Dim retorno As Boolean
        Dim banco = New DataAcces
        MoveParametrosDaConsulta()

        retorno = banco.ExecuteStoreProcedure("Sp_Consulta_I_U_D", Parametro)
        Cons_ID = banco.id_Increment

        banco.CloseConn()

        Return retorno
    End Function
    Public Function LeReceitaAv() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Ani", Rc_Ani))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Receita_Sel", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaReceita() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Ani", Rc_Ani))
            Parametro.Add(New SqlParameter("@ID_Rec", Rc_Nss))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Receita_NssNro", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeFarmaco(ByVal Procedure As String) As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@NomeLike", Nome_Like))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(Procedure, Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Private Sub MoveParametrosDaReceita()
        '' ADICIONA OS PARAMETROS
        Try
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@TipoOperacao", TipoOperacao))
            Parametro.Add(New SqlParameter("@RcId", Rc_Id))
            'Parametro.Add(New SqlParameter("@RcCli", Rc_Cli))
            Parametro.Add(New SqlParameter("@RcCli", Rc_Cli))
            Parametro.Add(New SqlParameter("@RcAni", Rc_Ani))
            Parametro.Add(New SqlParameter("@RcDt", Now))
            Parametro.Add(New SqlParameter("@RcNss", Rc_Nss))
            Parametro.Add(New SqlParameter("@RcFarmaco", Rc_Farmaco))
            Parametro.Add(New SqlParameter("@RcMeio", Rc_Meio))
            Parametro.Add(New SqlParameter("@RcQtd", Rc_Qtd))
            Parametro.Add(New SqlParameter("@RcVia", Rc_Via))
            Parametro.Add(New SqlParameter("@RcFreq", Rc_Freq))
            Parametro.Add(New SqlParameter("@RcDias", Rc_Dias))
            Parametro.Add(New SqlParameter("@RcReco", Rc_Reco))
            Parametro.Add(New SqlParameter("@RcEsp", Rc_Esp))
            Parametro.Add(New SqlParameter("@RcDescFarmaco", Rc_DescFarmaco))
            Parametro.Add(New SqlParameter("@RcFunc", Rc_Func))

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function I_U_D_Receita()
        Dim retorno As Object
        ' Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Try
            MoveParametrosDaReceita()
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Receita_I_U_D", Parametro)
            Cons_ID = banco.id_Increment
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function InsertVacina() As Object

        Dim retorno As Object
        ' Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Try
            MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@TipoOperacao", TipoOperacao))
            Parametro.Add(New SqlParameter("@VcId", Vc_Id))
            Parametro.Add(New SqlParameter("@VcAni", Vc_Ani))
            Parametro.Add(New SqlParameter("@VcTp", Vc_Tp))
            Parametro.Add(New SqlParameter("@VcDt", Date.Now))
            Parametro.Add(New SqlParameter("@VcDose", Vc_Dose))
            Parametro.Add(New SqlParameter("@VcData", Vc_Data))
            Parametro.Add(New SqlParameter("@VcItem", Vc_Item))
            Parametro.Add(New SqlParameter("@VcMES", Vc_Mes))
            Parametro.Add(New SqlParameter("@VcContato", Vc_Contato))
            Parametro.Add(New SqlParameter("@VcEmail", Vc_Email))

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Vacina_Insert", Parametro)
            Cons_ID = banco.id_Increment
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeGrpVacina() As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Vacina_Grupo", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeVacina(ByVal sp As String, ByVal Pesquisa As Integer) As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@VcAni", Vc_Ani))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(sp, Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeVacinasDoMes() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@VcMes", Vc_Mes))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Vacinas_do_Mes", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function LeAgenda() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Ag_Data", Ag_Data))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Agenda_Sel", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaQtdServico() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Ag_Data", Ag_Data))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Agenda_Count_TP", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaAgenda() As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("ag_Id", Ag_Id))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Agenda_Sel_Id", Parametro)

            '' preencher as propriedades
            Do While dr.Read

                Ag_Data = dr("AgData")
                ag_Hora = dr("AgHora")

                ag_idCli = dr("agidcli")
                ag_Cliente = dr("Agcliente")
                ag_Cpf = dr("agcpf")
                ag_IdPet = dr("AgIdPet")
                ag_NomePet = dr("AgNomePet")
                ag_Contato = dr("Agcontato")
                ag_Email = dr("Agemail")
                ag_Tipo = dr("AgTipo")
                ag_Obs = dr("AgObs")
                ag_Funcionario = dr("AgFuncionario")
                ag_St = dr("AgSt")
                Ag_Id = dr("adId")
                ag_Os = dr("AgOs")

                retorno = True
            Loop

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaAgendaTutor(ByVal Tutor As Integer) As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Dim Retorno As Boolean = True

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Ag_Tutor", Tutor)) ''sem parametros
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Agenda_Sel_AgTutor", Parametro)
            '
            Return Tabela

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Exclui_Agenda() As Object

        Dim retorno As Object
        Dim banco As New DataAcces
        Try
            'MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Ag_ID", Ag_Id))

            retorno = banco.ExecuteStoreProcedure("Sp_Agenda_Del", Parametro)
            Cons_ID = banco.id_Increment
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Insert_Agenda() As Object
        Dim retorno As Object
        Dim banco As New DataAcces
        Try
            'MoveParametrosDaReceita()
            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("Ag_Data", Ag_Data))
            Parametro.Add(New SqlParameter("Ag_Hora", ag_Hora))
            Parametro.Add(New SqlParameter("Ag_IdCli", ag_idCli))
            Parametro.Add(New SqlParameter("Ag_Cpf", ag_Cpf))
            Parametro.Add(New SqlParameter("Ag_Cliente", ag_Cliente))

            Parametro.Add(New SqlParameter("Ag_IdPet", ag_IdPet))
            Parametro.Add(New SqlParameter("ag_NomePet", ag_NomePet))

            Parametro.Add(New SqlParameter("Ag_Contato", ag_Contato))
            Parametro.Add(New SqlParameter("Ag_Email", ag_Email))
            Parametro.Add(New SqlParameter("Ag_Tipo", ag_Tipo))
            Parametro.Add(New SqlParameter("Ag_Obs", ag_Obs))
            Parametro.Add(New SqlParameter("Ag_Funcionario", ag_Funcionario))
            Parametro.Add(New SqlParameter("Ag_St", ag_St))
            Parametro.Add(New SqlParameter("Ag_Os", ag_Os))
            Parametro.Add(New SqlParameter("Ag_Ordem", ag_Ordem))

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Agenda_Insert", Parametro)
            Ag_Id = banco.id_Increment
            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function UpDateAgenda() As Object
        Dim retorno As Object
        Dim banco As New DataAcces
        Try

            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Ag_Id", Ag_Id))
            Parametro.Add(New SqlParameter("Ag_Data", Ag_Data))
            Parametro.Add(New SqlParameter("Ag_Hora", ag_Hora))
            Parametro.Add(New SqlParameter("Ag_Cliente", ag_Cliente))
            Parametro.Add(New SqlParameter("Ag_Contato", ag_Contato))
            Parametro.Add(New SqlParameter("Ag_Email", ag_Email))
            Parametro.Add(New SqlParameter("Ag_Tipo", ag_Tipo))
            Parametro.Add(New SqlParameter("Ag_Obs", ag_Obs))
            Parametro.Add(New SqlParameter("Ag_Funcionario", ag_Funcionario))
            Parametro.Add(New SqlParameter("Ag_St", ag_St))
            Parametro.Add(New SqlParameter("Ag_OS", ag_Os))

            retorno = banco.ExecuteStoreProcedure("Sp_Agenda_UpDate", Parametro)

            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function UpDateObsAgenda() As Object
        Dim retorno As Object
        Dim banco As New DataAcces
        Try

            Parametro = New List(Of SqlParameter)

            Parametro.Add(New SqlParameter("Ag_OS", ag_Os))
            Parametro.Add(New SqlParameter("Ag_Data", Ag_Data))
            Parametro.Add(New SqlParameter("Ag_Obs", ag_Obs))
            Parametro.Add(New SqlParameter("Bt_Obs", Bt_Obs))

            retorno = banco.ExecuteStoreProcedure("Sp_Agenda_UpDate_Obs", Parametro)

            banco.CloseConn()

            Return retorno
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LeTipoAgenda() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            ''sem parametros
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Agenda_Tp", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscaAgendaDupl() As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ag_Data", Ag_Data))
            Parametro.Add(New SqlParameter("@ag_Hora", ag_Hora))
            Parametro.Add(New SqlParameter("@ag_Cliente", ag_idCli))
            Parametro.Add(New SqlParameter("@ag_Pet", ag_IdPet))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Agenda_Dupl", Parametro)

            '' preencher as propriedades
            Do While dr.Read

                Ag_Id = dr("AdId")

            Loop

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LeFunc() As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Dim Retorno As Boolean = True

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            ''sem parametros
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Funcionario_Sel", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function DeletaItemReceita()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim Ds As DataSet
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Rc_Id", Rc_Id))
            ' EXCUTA A PROCEDURE
            Ds = banco.ExecutaStoreProcedureDataSet("Sp_Receita_DaletaItem", Parametro)
            '
            Return Ds
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function DeletaReceitaGeral()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim Ds As DataSet
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Rc_Ani", Rc_Ani))
            Parametro.Add(New SqlParameter("Rc_Nss", Rc_Nss))
            ' EXCUTA A PROCEDURE
            Ds = banco.ExecutaStoreProcedureDataSet("Sp_Receita_DaletaReceita", Parametro)
            '
            Return Ds
            ''FECHA A CONEXAO
            banco.CloseConn()

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LeAniversarios(ByVal Mes As Integer, ByVal Dia As Integer, ByVal Procedure As String) As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Mes", Mes))
            Parametro.Add(New SqlParameter("@Dia", Dia))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable(Procedure, Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Busca_Agenda_da_Vacina(ByVal Pet As Integer) As Object
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Vc_Ani", Pet))

        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Vacinas_Sel_Ag", Parametro)
        Agenda_Vacina = ""
        Do While dr.Read
            Agenda_Vacina += "Tipo : " & dr("vctp") & " Dia : " & dr("vcdata") & " Dose : " & dr("VcDose") & vbCrLf
        Loop
        retorno = True

        banco.CloseConn()
    End Function
    Public Function LeNomePet(ByVal Nome_Pet As String, ByVal IdTutor As Integer) As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Retorno As Object
        Dim dr As IDataReader

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Ani_Nome", Nome_Pet))
            Parametro.Add(New SqlParameter("@Id_Tutor", IdTutor))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Animal_Unico", Parametro)
            '' preencher as propriedades
            While dr.Read
                Rc_Ani = dr("IdAnimal")
                Retorno = dr("IdAnimal")
            End While

            Return Retorno

            ''FECHA A CONEXAO
            banco.CloseConn()

            Return Retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function BuscaPetDoTutor(ByVal Tutor As Integer) As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Ani_Cliente", Tutor))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Animal_Sel_Tutor", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
