Imports System.Data.SqlClient
Imports DataBase
Imports DataBase.Utils
Imports System.Windows.Forms
Public Class Cls_Prestador

    Public Property prest_Id As Integer
    Public Property prest_Func As Integer
    ''Public Property prest_CPF As String
    Public Property prest_Nome As String
    Public Property prest_End As String
    Public Property prest_Nro As String
    Public Property prest_Compl As String
    Public Property prest_Bairro As String
    Public Property prest_Cidade As String
    Public Property prest_Uf As String
    Public Property prest_CEP As String
    Public Property prest_Fone As String
    Public Property prest_DOC As String
    Public Property prest_TpCarro As String
    Public Property prest_Placa As String
    Public Property prest_Email As String
    Public Property prest_Foto As String
    Public Property T_O As String
    Public Function UpFotoPrest() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Retorno As Boolean = True
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@T_O", "I"))

            Parametro.Add(New SqlParameter("@prest_id", prest_Id))
            Parametro.Add(New SqlParameter("@prest_Foto", prest_Foto))
            ' EXCUTA A PROCEDURE
            Retorno = banco.ExecuteStoreProcedure("Sp_Prestador_Up_Foto", Parametro)
            '
            Return Retorno
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GravaPrestador() As Boolean
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Try

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@T_O", T_O))
            Parametro.Add(New SqlParameter("@prestId", prest_Id))
            Parametro.Add(New SqlParameter("@prestFunc", prest_Func))
            Parametro.Add(New SqlParameter("@prestNome", prest_Nome))
            Parametro.Add(New SqlParameter("@prestEnd", prest_End))
            Parametro.Add(New SqlParameter("@prestNro", prest_Nro))
            Parametro.Add(New SqlParameter("@prestBairro", prest_Bairro))
            Parametro.Add(New SqlParameter("@prestCidade", prest_Cidade))
            Parametro.Add(New SqlParameter("@prestUF", prest_Uf))
            Parametro.Add(New SqlParameter("@prestCEP", prest_CEP))
            Parametro.Add(New SqlParameter("@prestFone", prest_Fone))
            Parametro.Add(New SqlParameter("@prestDoc", prest_DOC))
            Parametro.Add(New SqlParameter("@prestEMail", prest_Email))
            Parametro.Add(New SqlParameter("@prestTpCarro", prest_TpCarro))
            Parametro.Add(New SqlParameter("@prestPlaca", prest_Placa))
            Parametro.Add(New SqlParameter("@prestFoto", prest_Foto))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Prestador_I_U", Parametro)
            prest_Id = banco.id_Increment
            banco.CloseConn()

            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaFuncao()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            ''Parametro.Add(New SqlParameter("@Tipo", 2))

            Tabela = banco.ExecutaDataTable("Sp_Funcao_Prestador", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaPrestadores()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            ''Parametro.Add(New SqlParameter("@Tipo", 2))

            Tabela = banco.ExecutaDataTable("Sp_Prestador_Sel", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaPrestadorID()
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Dim retorno As Boolean
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@ID", prest_Id))

        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Prestador_Sel_ID", Parametro)
        Try
            '' preencher as propriedades
            prest_Id = 0
            While dr.Read
                prest_Id = dr("prestId")
                prest_Func = dr("prestFunc")
                prest_Nome = dr("prestNome")
                prest_End = dr("prestEnd")
                prest_Nro = dr("prestNro")
                prest_Bairro = dr("prestBairro")
                prest_Cidade = dr("prestCidade")
                prest_Uf = dr("prestUF")
                prest_CEP = dr("prestCEP")
                prest_Fone = dr("prestFone")
                prest_DOC = dr("prestDoc")
                prest_Email = dr("prestEMail")
                prest_TpCarro = dr("prestTpCarro")
                prest_Placa = dr("prestPlaca")

                If IsDBNull(dr("prestFoto")) = False Then
                    prest_Foto = dr("prestFoto")
                Else
                    prest_Foto = ""
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
End Class
