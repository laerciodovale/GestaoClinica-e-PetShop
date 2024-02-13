Imports System.Data.SqlClient
Imports DataBase.Utils
Public Class DataAcces
#Region "Variaveis do Banco de Dados"
    Private conn As SqlConnection
    Private conexao As SqlConnection
    Private command As SqlCommand
    Private dr As SqlDataReader
    Private da As SqlDataAdapter
#End Region
    Public id_Increment As Integer

#Region "Construto"

    Sub New()
        conn = New SqlConnection("Server=Srv;Database=CadVet;User Id=sa;Password=nunsey;")
        ''''conn = New SqlConnection("Server=SrvMyPets;Database=CadVet;Trusted_Connection=True;")
        '''' conn = New SqlConnection("Provider=SQLNCLI11;Server=SrvMyPets;Database=CadVet;Trusted_Connection=yes;")
        conn = New SqlConnection("Server=SrvMyPets;Database=CadVet;Uid=sa;Pwd=nunsey;")

        conn.Open()

    End Sub
    Private Sub Conexao2()
        conexao = New SqlConnection("Server=Srv;Database=CadVet;User Id=sa;Password=nunsey;")
        conexao = New SqlConnection("Server=SrvMyPets;Database=CadVet;Uid=sa;Pwd=nunsey;")

        conexao.Open()
    End Sub
#End Region
#Region "Funcoes"

    Public Sub CloseConn()
        Try
            If Not IsNothing(conn) Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' EXECUTA UMA PROCEDURE E RETORNA UM DATAREADER
    ''' </summary>
    ''' <param name="procedure">Nome da procedure</param>
    ''' <param name="parametros">lista de parametros</param>
    ''' <returns>DATAREADER COM O RESULTADO DA CONSULTA</returns>
    Public Function ExecutaStoreProcedureReader(ByVal procedure As String,
                                                ByVal parametros As List(Of SqlParameter)) As IDataReader
        Dim retornoReader As IDataReader

        Try
            'Preparando comando para executar uma procedure
            command = New SqlCommand
            command = conn.CreateCommand
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = procedure
            command.Parameters.Clear()

            ''adicionar os parametros
            For Each Par As SqlParameter In parametros
                command.Parameters.Add(Par)
            Next

            ''Executa o comando
            retornoReader = command.ExecuteReader
            Return retornoReader

        Catch ex As Exception
            Throw ex
        Finally
            command = Nothing
        End Try
    End Function
    ''' <summary>
    ''' FUNCAO PARA EXECUTAR COMANDOS (INSERT, UPDATE, DELETE).
    ''' </summary>
    ''' <param name="procedure">nOME DA PROCEDURE</param>
    ''' <param name="parametros">LISTA DE PARAMETROS</param>
    ''' <returns>RETORNA UM BOOLEM</returns>
    Public Function ExecuteStoreProcedure(ByVal procedure As String,
                                          ByVal parametros As List(Of SqlParameter)) As Boolean
        Dim retorno As Boolean = False
        Try
            'Preparando comando para executar uma procedure
            command = New SqlCommand
            command = conn.CreateCommand
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = procedure
            command.Parameters.Clear()
            ''adicionar os parametros
            For Each Par As SqlParameter In parametros
                command.Parameters.Add(Par)
            Next
            ''Executa o comando
            retorno = command.ExecuteNonQuery

            Return retorno

        Catch ex As Exception
            Throw ex
        Finally
            command = Nothing
        End Try
    End Function
    Public Function ExecuteStoreProcedureIncremento(ByVal procedure As String,
                                          ByVal parametros As List(Of SqlParameter)) As Object
        Dim retorno As Object
        Try
            'Preparando comando para executar uma procedure
            command = New SqlCommand
            command = conn.CreateCommand
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = procedure
            command.Parameters.Clear()
            ''adicionar os parametros
            For Each Par As SqlParameter In parametros
                command.Parameters.Add(Par)
            Next
            ''Executa o comando
            id_Increment = 1
            retorno = command.ExecuteScalar()

            If retorno = Nothing Then
                retorno = 1
            Else
                id_Increment = retorno
            End If

            Return retorno

        Catch ex As Exception
            Throw ex
        Finally
            command = Nothing
        End Try
    End Function

    ''' <summary>
    ''' FUNCAO PARA EXECUTAR UMA CONSULTA E RETORNAR UM DATASET
    ''' </summary>
    ''' <param name="procedure">NOME DA PROCEDURE</param>
    ''' <param name="parametros">LISTA DE PARAMETROS</param>
    ''' <returns>DATASET COM O RESULTADO DA CONSULTA</returns>
    Public Function ExecutaStoreProcedureDataSet(ByVal procedure As String,
                                          ByVal parametros As List(Of SqlParameter)) As DataSet
        Dim retornoDataSet As New DataSet

        Try
            'Preparando comando para executar uma procedure
            command = New SqlCommand
            command = conn.CreateCommand
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = procedure
            command.Parameters.Clear()

            ''adicionar os parametros
            For Each Par As SqlParameter In parametros
                command.Parameters.Add(Par)
            Next

            ''Executa o comando
            da = New SqlDataAdapter(command)
            da.Fill(retornoDataSet)

            Return retornoDataSet

        Catch ex As Exception
            Throw ex
        Finally
            command = Nothing
        End Try
    End Function
    ''' <summary>
    ''' 'retorna um datatable da consulta
    ''' </summary>
    ''' <param name="procedure"></param>
    ''' <param name="parametros"></param>
    ''' <returns></returns>
    Public Function ExecutaDataTable(ByVal procedure As String,
                                            ByVal parametros As List(Of SqlParameter)) As DataTable
        Dim tb As New DataTable
        Try
            ''Preparando comando para executar uma procedure
            command = New SqlCommand
            command = conn.CreateCommand
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = procedure
            command.Parameters.Clear()

            ''adicionar os parametros
            For Each Par As SqlParameter In parametros
                command.Parameters.Add(Par)
            Next
            ''Executa o comando
            da = New SqlDataAdapter(command)
            da.Fill(tb)
            Return tb

        Catch ex As Exception
            Throw ex
        Finally
            command = Nothing
        End Try
    End Function
    Public Function RecalculoCx()

        Exit Function


        Dim Sql As String
        Dim Mv_Seq As Integer
        Dim Mv_SldAn As Double
        Dim Mv_SldAt As Double
        Dim retorno As Object
        Dim ret As Object

        'Sql = "SELECT  min(mvseq) as mvseq from caixamov where MVData = " & Chr(39) & dt_Base & Chr(39) & ""

        'comando.CommandText = Sql
        'comando = New SqlCommand(Sql, conexao)
        'conexao.Close()
        'conexao.Open()
        'dr = comando.ExecuteReader

        'retorno = False
        'Do While dr.Read
        '    Mv_Seq = dr("mvseq")
        '    retorno = True
        'Loop

        'conexao.Close()

        'Sql = "SELECT  * from caixamov where mvseq >= " & Mv_Seq & " order by mvseq asc "
        Sql = "SELECT  * from caixamov  order by mvseq asc "
        command = New SqlCommand
        command = conn.CreateCommand
        command.CommandText = Sql
        command.Parameters.Clear()
        ' command = New SqlCommand(Sql, conn)

        dr = command.ExecuteReader

        retorno = False
        Mv_SldAn = 0
        Mv_SldAt = 0
        'conexaoS = New SqlConnection("Server=162.241.2.67:3306;Database=cvmype23_cadvet;Uid=cvmype23_sa;Pwd=nunsey;")
        'conexaoS.Open()
        Conexao2()
        Dim comm As New SqlCommand
        Do While dr.Read

            Mv_Seq = dr("mvseq")

            Mv_SldAn = Mv_SldAt
            Mv_SldAt = Format(Mv_SldAt + (dr("MVE") + dr("MVs")), "0.00")

            comm = New SqlCommand
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "Sp_Caixa_Sld"
            comm.Connection = conexao
            comm.Parameters.AddWithValue("Mv_Seq", Mv_Seq)
            comm.Parameters.AddWithValue("Mv_SldAn", Mv_SldAn)
            comm.Parameters.AddWithValue("Mv_SldAt", Mv_SldAt)

            ret = comm.ExecuteNonQuery()

            retorno = True
            ' conexao.Close()
        Loop

        conexao.Close()
        conn.Close()

    End Function
#End Region
End Class
