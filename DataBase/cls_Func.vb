Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Public Class cls_Func
    Private dr As IDataReader

    Public Rc_Id As Integer
    Public Fu_Id As Integer
    Public Fu_Nome As String
    Public Fu_Rg As String
    Public Fu_Cpf As String
    Public Fu_Funcao As Integer
    Public Fu_End As String
    Public Fu_Nro As String
    Public Fu_Compl As String
    Public Fu_Cidade As String

    Public Fu_Bairro As String
    Public Fu_Cel As String
    Public Fu_Fixo As String
    Public Fu_UF As String
    Public Fu_CEP As String
    Public Fu_InAtivo As Boolean
    Public Fu_RgProf As String
    Public Fu_Foto As String
    Public Fu_DtNas As String
    Public Check As Integer
    Private Sub MoveDados()
        Fu_Id = dr("FuId")
        Fu_Nome = dr("FuNome")
        Fu_Rg = dr("FuRg")
        Fu_Cpf = dr("FuCpf")
        Fu_Funcao = dr("FuFuncao")
        Fu_RgProf = dr("FuRgProf")
        Fu_End = dr("FuEnd")
        Fu_Nro = dr("FuNro")
        Fu_Compl = dr("FuCompl")
        Fu_Cidade = dr("FuCidade")
        Fu_Bairro = dr("FuBairro")

        If Fu_UF = Nothing Then
            Fu_UF = "MT"
        Else
            Fu_UF = dr("FuUF")
        End If

        Fu_CEP = dr("FuCEP")
        Fu_Cel = dr("FuCel")
        Fu_Fixo = dr("FuFixo")
        Fu_InAtivo = dr("FuAtivo")

        Fu_DtNas = dr("fudtnas")
        Fu_Foto = dr("fufoto")

    End Sub
    Public Function Le_Funcionario(ByVal cpf As String)
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces

        Try
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("Fu_Cpf", cpf))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Func_Sel_CPF", Parametro)
            '' preencher as propriedades
            Fu_Id = 0
            Do While dr.Read

                MoveDados()

                retorno = True
            Loop

            banco.CloseConn()
        Catch
        End Try

    End Function
    Public Function Le_Funcionario_ID(ByVal id As String)
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces

        Try
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID", id))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Func_Sel_ID", Parametro)
            '' preencher as propriedades
            Fu_Id = 0
            Do While dr.Read

                MoveDados()

                retorno = True
            Loop

            banco.CloseConn()
        Catch

        End Try

    End Function
    Public Function Le_Ckeckd(ByVal procedure As String,
                                            ByVal parametros As List(Of SqlParameter)) As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        'Dim dr As IDataReader

        'dr = comando.ExecuteReader
        Parametro = New List(Of SqlParameter)
        dr = banco.ExecutaStoreProcedureReader(procedure, Parametro)
        Check = 0
        Do While dr.Read

            Check = 1
            retorno = True

        Loop

        banco.CloseConn()
        Return retorno
    End Function

    Public Function UpFotoFunc() As Object

        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("Fu_Id", Fu_Id))
        Parametro.Add(New SqlParameter("Fu_Foto", Fu_Foto))
        retorno = banco.ExecuteStoreProcedure("Sp_Func_Up_Foto", Parametro)
        Return retorno
        banco.CloseConn()

    End Function
    Public Function LeFuncEstetica() As Object
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
            Tabela = banco.ExecutaDataTable("Sp_Func_Sel_Estetica", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
