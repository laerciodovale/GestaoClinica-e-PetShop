Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.Data.SqlClient

Public Class Utils
    Public Property Id_Cliente As Integer
    Public Property Id_Paciente As Integer
    Public Property Id_Nss_Nro As Integer
    Public Property Usuario As String
    Public Property AutUsuario As Integer
    ''' Dados da empresa
    Public emp_id As Integer
    Public emp_cgc As String
    Public emp_ie As String
    Public emp_im As String
    Public emp_razao As String
    Public emp_fanta As String
    Public emp_end As String
    Public emp_nro As String
    Public emp_compl As String
    Public emp_bairro As String
    Public emp_cidade As String
    Public emp_codMunIbge As String
    Public emp_uf As String
    Public emp_ufIbge As Integer
    Public emp_cep As String
    Public emp_fone As String
    Public emp_http As String
    Public emp_email As String
    Public emp_xml As String
    Public emp_iss As Double
    Public emp_Logo As String
    Public emp_Caminho As String
    Public DadosEmpresa As String
    '' usuario
    Public usr_User As String
    Public usr_Senha As String
    Public usr_Nome As String
    Public usr_Aut As Integer
    Public usr_Nivel As Integer
    Public usr_Ativo As Boolean
    Public Property usr_CodFol As Integer
    Public Us_Id As Integer
    Public us_Modulo As Integer
    Public T_O As String
    Private Par As List(Of SqlParameter)



    '''Trata mensagem de erro
    Public Shared Sub TrataErro(ByVal mensagem As String, ByVal ex As Exception)
        MessageBox.Show(mensagem & vbNewLine & "Erro: " & vbNewLine &
                        ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    ''' <summary>
    ''' Transforma imagem para base 64
    ''' </summary>
    ''' <param name="caminho">Caminho da imagem a ser transformada</param>
    ''' <returns></returns>
    Public Shared Function ArquivoParaBase64(ByVal caminho As String)
        Try
            'LER O ARQUIVO PARA BYTES
            Dim arquivoByte As Byte() = File.ReadAllBytes(caminho)
            'transforma em base 64
            Dim arquivoBase64 As String = Convert.ToBase64String(arquivoByte)
            Return arquivoBase64
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Function AbrirArquivoBase64(ByVal Base64 As String) As Image
        Try
            If Len(Trim(Base64)) > 0 Then
                'transforma o texto base64 em byte (campo da base de dados para image)
                Dim arquivoByte() As Byte = Convert.FromBase64String(Base64)

                'transforma o byte em strem e depois em imagem
                Dim ms As MemoryStream = New MemoryStream(arquivoByte)
                Dim imagem As Image

                imagem = Image.FromStream(ms)

                Return imagem
            End If
        Catch ex As Exception
            Throw ex

        End Try

    End Function
    ''' <summary>
    ''' 'busca um cep
    ''' 
    ''' </summary>
    ''' <param name="cep"></param>
    ''' <returns></returns>
    Public Shared Function PesquisaCEP(ByVal cep As String) As Cls_BuscaCEP
        Dim strEnd As String = String.Format("https://viacep.com.br/ws/{0}/json/", cep)
        Dim result As Cls_BuscaCEP
        Try
            Dim wc As New WebClient
            wc.Encoding = Encoding.UTF8
            Dim strJson As String = wc.DownloadString(strEnd)
            result = JsonConvert.DeserializeObject(Of Cls_BuscaCEP)(strJson)

            Return result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaUsuario(ByVal NomeProcedure As String, ByVal Parametro As List(Of SqlParameter))
        ' Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Retorno As Boolean = True
        Dim dr As IDataReader
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            '    Parametro = List(Of SqlParameter)
            ' Parametro.Add(New SqlParameter("@USUARIO", usuario))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader(NomeProcedure, Parametro)
            '' preencher as propriedades
            usr_User = ""
            Do While dr.Read
                usr_User = dr("usuario")
                usr_Aut = dr("usAut")
                usr_Nivel = dr("usNivel")
                usr_CodFol = dr("usCodFol")
                usr_Ativo = dr("usAtiv")
                Retorno = True
            Loop

            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception

        End Try
    End Function
    Public Function InsertNssNro() As Object

        Dim retorno As Object
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@id_Dt", Now))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_NssNro_Insert", Parametro)
            Id_Nss_Nro = banco.id_Increment
            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Le_Empresa()

        Dim retorno As Boolean = False
        Dim par As List(Of SqlParameter)
        Dim banco_Ex As New DataAcces
        Dim dr As IDataReader

        par = New List(Of SqlParameter)
        par.Add(New SqlParameter("@emp_id", 1))
        dr = banco_Ex.ExecutaStoreProcedureReader("Sp_Empresa_Sel", par)
        'PREENCHE
        Do While dr.Read
            emp_id = dr("empid")
            emp_cgc = dr("empcgc")
            emp_ie = dr("empie")
            emp_im = dr("empim")
            emp_razao = dr("emprazao")
            emp_fanta = dr("empfanta")
            emp_end = dr("empend")
            emp_nro = dr("empnro")
            emp_compl = dr("empcompl")
            emp_bairro = dr("empbairro")
            emp_cidade = dr("empcidade")
            emp_codMunIbge = dr("empcodmun")
            emp_uf = dr("empuf")
            emp_ufIbge = dr("empufibge")
            emp_cep = dr("empcep")
            emp_fone = dr("empfone")
            emp_email = dr("empemail")
            emp_xml = dr("empxml")
            emp_iss = dr("empiss")
            emp_Logo = dr("emplogo")
            emp_Caminho = dr("empcaminho")
            retorno = True
        Loop

        banco_Ex.CloseConn()
        DadosEmpresa = ""
        Centraliza(Trim(emp_fanta))

        If Len(emp_cgc) = 14 Then
            emp_cgc = Convert.ToUInt64(emp_cgc).ToString("00\.000\.000\/0000\-00")
        Else
            emp_cgc = Convert.ToUInt64(emp_cgc).ToString("000\.000\.000\-00")
        End If

        Centraliza(Trim(emp_cgc))

        Centraliza(Trim(Trim(emp_end) & "," & Trim(emp_nro) & " " & Trim(emp_compl)))
        Centraliza(Trim(Trim(emp_bairro) & " - " & Trim(emp_cidade) & " - " & Trim(emp_uf)))
        Centraliza(Trim("CEP: " & Trim(emp_cep)))
        Centraliza(Trim("Fone : " & emp_fone))

    End Function
    Private Sub Centraliza(ByVal valor As String)
        Dim t1 As Integer
        Dim t2 As Integer
        Dim t3 As Integer = 46

        t1 = (t3 - valor.Length) / 2
        t2 = (valor.Length)

        Dim sb As New System.Text.StringBuilder(valor)

        For x = 0 To t1
            If sb.Length <= t3 Then
                sb.Insert(x, " ")
                sb.Insert(sb.Length, " ")
            End If
        Next

        DadosEmpresa = DadosEmpresa & sb.ToString & vbCrLf

    End Sub
    Public Function BuscaCliente(ByVal Idcli As Integer) As Object

        Dim cli As New Cls_Cliente
        cli.BuscaCliente("Sp_Cliente_Sel", Idcli)

    End Function
    Private Function Par_Emp()
        Par.Add(New SqlParameter("@TP", T_O))
        Par.Add(New SqlParameter("@EMP_id", emp_id))
        Par.Add(New SqlParameter("@emp_cgc", emp_cgc))
        Par.Add(New SqlParameter("@EMP_ie", emp_ie))
        Par.Add(New SqlParameter("@EMP_im", emp_im))
        Par.Add(New SqlParameter("@EMP_razao", emp_razao))
        Par.Add(New SqlParameter("@EMP_fanta", emp_fanta))
        Par.Add(New SqlParameter("@EMP_end", emp_end))
        Par.Add(New SqlParameter("@EMP_nro", emp_nro))
        Par.Add(New SqlParameter("@EMP_compl", emp_compl))
        Par.Add(New SqlParameter("@EMP_bairro", emp_bairro))
        Par.Add(New SqlParameter("@EMP_cidade", emp_cidade))
        Par.Add(New SqlParameter("@EMP_codMunIbge", emp_codMunIbge))
        Par.Add(New SqlParameter("@EMP_uf", emp_uf))
        Par.Add(New SqlParameter("@EMP_ufIbge", emp_ufIbge))
        Par.Add(New SqlParameter("@EMP_cep", emp_cep))
        Par.Add(New SqlParameter("@EMP_fone", emp_fone))
        Par.Add(New SqlParameter("@EMP_email", emp_email))
        Par.Add(New SqlParameter("@EMP_http", emp_http))
        Par.Add(New SqlParameter("@EMP_xml", emp_xml))
        Par.Add(New SqlParameter("@EMP_iss", emp_iss))
        Par.Add(New SqlParameter("@EMP_Logo", emp_Logo))
        Par.Add(New SqlParameter("@EMP_CAminho", emp_Caminho))

    End Function
    Public Function Contratante() As Object

        Dim retorno As Object
        Dim banco As DataAcces
        Try
            banco = New DataAcces
            Par = New List(Of SqlParameter)

            Par_Emp()

            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Emp_IU", Par)
            emp_id = banco.id_Increment

            banco.CloseConn()
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
