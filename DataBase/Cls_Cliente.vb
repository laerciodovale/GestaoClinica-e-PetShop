Imports System.Data.SqlClient
Imports DataBase
Imports DataBase.Utils
Imports System.Windows.Forms

Public Class Cls_Cliente
#Region "propriedades"
    Public Property ClId As Integer
    Public Property ClNome As String
    Public Property ClContato As String
    Public Property ClEnd As String
    Public Property ClNro As String
    Public Property ClBairro As String
    Public Property ClCidade As String
    Public Property ClUf As String
    Public Property ClCEP As String
    Public Property ClCel As String
    Public Property ClFixo As String
    Public Property ClEmail As String
    Public Property ClDtNas As Date
    Public Property ClRG As String
    Public Property ClCpf As String
    Public Property ClDtCad As Date
    Public Property ClCompl As String
    Public Property ClFoto As String

#End Region
#Region "PROPRIEDADES"
    '' CADASTRO DO CLIENTE
    Public Property Cl_Id As Integer
    Public Property Cl_Nome As String
    Public Property Cl_Contato As String
    Public Property Cl_End As String
    Public Property Cl_Nro As String
    Public Property Cl_Bairro As String
    Public Property Cl_Cidade As String
    Public Property Cl_Uf As String
    Public Property Cl_CEP As String
    Public Property Cl_Cel As String
    Public Property Cl_Fixo As String
    Public Property Cl_Email As String
    Public Property Cl_DtNas As Date
    Public Property Cl_RG As String
    Public Property Cl_Cpf As String
    Public Property Cl_DtCad As Date
    Public Property Cl_Compl As String
    Public Property Cl_Foto As String 'nvarchar(MAX)
    Public Property Cl_FJ As Byte

    '''CADASTRO DO ANIMAL
    '''
    Public Property Id_Animal As Integer
    Public Property Ani_Nome As String
    Public Property Ani_Cliente As Integer
    Public Property Ani_Especie As Integer
    Public Property Ani_Raca As String
    Public Property Ani_Porte As String
    Public Property Ani_Cor As String
    Public Property Ani_Pelo As String
    Public Property Ani_Sexo As String
    Public Property Ani_DtNas As Date
    Public Property Ani_Alergias As Integer
    Public Property Ani_Vivo As Boolean
    Public Property Ani_Agressico As Boolean
    Public Property Ani_Pedigree As String
    Public Property Ani_Chip As String
    Public Property Ani_Obs As String
    Public Property Ani_DtCad As Date
    Public Property Ani_Conv As Double
    Public Property Ani_Foto As String 'nvarchar(MAX)
    Public Property Ani_Castrado As Boolean
    '' RECEITA
    Public Property Rc_Id As Integer
    Public Property Rc_Cli As Integer
    Public Property Rc_Ani As Integer
    Public Property Rc_Dt As Date
    Public Property Rc_Nss As Integer
    Public Property Rc_Farmaco As String
    Public Property Rc_Meio As String
    Public Property Rc_Qtd As String
    Public Property Rc_Via As Decimal
    Public Property Rc_Freq As Decimal
    Public Property Rc_Dias As Decimal
    Public Property Rc_Reco As String
    Public Property Rc_Esp As Boolean
    Public Property Rc_DescFarmaco As String
    ''' 
    Public Property Sexo As String
    Public Property Tipo_Operacao As String
    Public Property CtaReg As Integer
    Public Property Transf_NssNro As Integer
#End Region
#Region "CONSTANTES"
    Public Const Fisico As Char = "F"
    Public Const Juridico As Char = "J"
    Public LinhaTLV(500, 13) As String

#End Region
#Region "METODOS"
    ''' <summary>
    ''' ADICIONA UM NOVO REGISTRO
    ''' </summary>
    ''' <returns>TRUE = CLIENTE ADICIONADO</returns>

#End Region
#Region "GRAVA registro"

    Public Function GravaCliente() As Boolean
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Try
            'VERIRICA DADOS

            If Cl_Id.ToString.Length = 0 Then
                Throw New Exception("Registro sem ID")
            End If

            If Cl_Cpf.ToString.Length = 0 Then
                Throw New Exception("Informe o CPF|CNPJ")
            End If
            If Cl_Nome.ToString.Length = 0 Then
                Throw New Exception("Informe a propriedade ClNome")
            End If
            If Cl_Fixo.ToString.Length = 0 Then
                Throw New Exception("Informe um Celular|Telefone de contato")
            End If

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@TipoOperacao", Tipo_Operacao))
            Parametro.Add(New SqlParameter("@ID_cliente", Cl_Id))
            Parametro.Add(New SqlParameter("@Cl_Nome", Cl_Nome))
            Parametro.Add(New SqlParameter("@Cl_Contato", Cl_Contato))
            Parametro.Add(New SqlParameter("@Cl_End", Cl_End))
            Parametro.Add(New SqlParameter("@Cl_Nro", Cl_Nro))
            Parametro.Add(New SqlParameter("@Cl_Bairro", Cl_Bairro))
            Parametro.Add(New SqlParameter("@Cl_Cidade", Cl_Cidade))
            Parametro.Add(New SqlParameter("@Cl_Uf", Cl_Uf))
            Parametro.Add(New SqlParameter("@Cl_CEP", Cl_CEP))
            Parametro.Add(New SqlParameter("@Cl_Cel", Cl_Cel))
            Parametro.Add(New SqlParameter("@Cl_Fixo", Cl_Fixo))
            Parametro.Add(New SqlParameter("@Cl_Email", Cl_Email))
            Parametro.Add(New SqlParameter("@Cl_DtNas", Cl_DtNas))
            Parametro.Add(New SqlParameter("@Cl_RG", Cl_RG))
            Parametro.Add(New SqlParameter("@Cl_Cpf", Cl_Cpf))
            Parametro.Add(New SqlParameter("@Cl_Compl", Cl_Compl))
            Parametro.Add(New SqlParameter("@Cl_Foto", Cl_Foto))
            Parametro.Add(New SqlParameter("@Cl_FJ", Cl_FJ))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Cliente_I_U", Parametro)
            Cl_Id = banco.id_Increment
            banco.CloseConn()

            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GravaPaciente() As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Try
            'VERIRICA DADOS
            If Ani_Nome.Length = 0 Then
                Throw New Exception("Informe o Nome do paciente")
            End If
            'If Id_Animal = 0 Then
            '    Throw New Exception("Informe o ID do paciente")
            'End If
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@TipoOperacao", Tipo_Operacao))
            Parametro.Add(New SqlParameter("@ID_Animal", Id_Animal))
            Parametro.Add(New SqlParameter("@Ani_Nome", Ani_Nome))
            Parametro.Add(New SqlParameter("@Ani_Cliente", Ani_Cliente))
            Parametro.Add(New SqlParameter("@Ani_Espécie", Ani_Especie))
            Parametro.Add(New SqlParameter("@Ani_Raca", Ani_Raca))
            Parametro.Add(New SqlParameter("@Ani_Porte", Ani_Porte))
            Parametro.Add(New SqlParameter("@Ani_Cor", Ani_Cor))
            Parametro.Add(New SqlParameter("@Ani_Pelo", Ani_Pelo))
            Parametro.Add(New SqlParameter("@Ani_Sexo", Ani_Sexo))
            Parametro.Add(New SqlParameter("@Ani_DtNas", Ani_DtNas))
            Parametro.Add(New SqlParameter("@Ani_Alergias", Ani_Alergias))
            Parametro.Add(New SqlParameter("@Ani_Vivo", Ani_Vivo))
            Parametro.Add(New SqlParameter("@Ani_Agressico", Ani_Agressico))
            Parametro.Add(New SqlParameter("@Ani_Pedigree", Ani_Pedigree))
            Parametro.Add(New SqlParameter("@Ani_Chip", Ani_Chip))
            Parametro.Add(New SqlParameter("@Ani_Obs", Ani_Obs))
            ' Parametro.Add(New SqlParameter("@Ani_DtCad", Ani_DtCad))
            Parametro.Add(New SqlParameter("@Ani_Conv", Ani_Conv))
            Parametro.Add(New SqlParameter("@Ani_Foto", Ani_Foto))
            Parametro.Add(New SqlParameter("@Ani_Castrado", Ani_Castrado))

            ' EXCUTA A PROCEDURE
            retorno = banco.ExecuteStoreProcedureIncremento("Sp_Animal_I_U", Parametro)
            Id_Animal = banco.id_Increment
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaPaciente() As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        Try
            'VERIRICA DADOS

            If Id_Animal = 0 Then
                Throw New Exception("Informe o ID do paciente")
            End If
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Animal", Id_Animal))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Animal_Sel", Parametro)

            '' preencher as propriedades
            While dr.Read
                Id_Animal = dr("IdAnimal")
                Ani_Nome = dr("AniNome")
                Ani_Cliente = dr("AniCliente")
                Ani_Especie = dr("AniEspécie")
                Ani_Raca = dr("AniRaca")
                Ani_Porte = dr("AniPorte")
                Ani_Cor = dr("AniCor")
                Ani_Pelo = dr("AniPelo")
                Ani_Sexo = dr("AniSexo")
                Ani_DtNas = dr("AniDtNas")
                ' Ani_Alergias = dr("AniAlergias")
                Ani_Vivo = dr("AniVivo")
                Ani_Agressico = dr("AniAgressico")
                Ani_Pedigree = dr("AniPedigree")
                Ani_Chip = dr("AniChip")
                Ani_Obs = dr("AniObs")
                Ani_DtCad = dr("AniDtCad")
                Ani_Conv = dr("AniConv")
                'Ani_Foto = ""
                If IsDBNull(dr("AniFoto")) = False Then
                    Ani_Foto = dr("AniFoto")
                End If
                Ani_Castrado = dr("AniCastrado")
            End While

            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaCliente(ByVal NomeProcedure As String, ByVal id As Integer) As Boolean
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        Try
            'VERIRICA DADOS
            'If Cl_Id = 0 Then
            '    Throw New Exception("Registro sem ID")
            'End If

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_cliente", id))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader(NomeProcedure, Parametro)

            '' preencher as propriedades
            While dr.Read
                Cl_Id = dr("ClId")
                Cl_Nome = dr("ClNome")
                Cl_Contato = dr("ClContato")
                Cl_End = dr("ClEnd")
                Cl_Nro = dr("ClNro")
                Cl_Bairro = dr("ClBairro")
                Cl_Cidade = dr("ClCidade")
                Cl_Uf = dr("ClUf")
                Cl_CEP = dr("ClCEP")
                Cl_Cel = dr("ClCel")
                Cl_Fixo = dr("ClFixo")
                Cl_Email = dr("ClEmail")
                Cl_DtNas = dr("ClDtNas")
                Cl_RG = dr("ClRG")
                Cl_Cpf = dr("ClCpf")
                Cl_DtCad = dr("ClDtCad")
                Cl_Compl = dr("ClCompl")

                If IsDBNull(dr("ClFoto")) = False Then
                    Cl_Foto = dr("ClFoto")
                Else
                    Cl_Foto = " "
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
    Public Function BuscaCPF(ByVal CPF As String) As Boolean
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            CPF = Replace(CPF, ".", "")
            CPF = Replace(CPF, "/", "")
            CPF = Replace(CPF, "-", "")
            Parametro.Add(New SqlParameter("@Cl_CPF", CPF))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Cliente_CPF", Parametro)

            '' preencher as propriedades
            While dr.Read
                Cl_Id = dr("ClId")
                Cl_Nome = dr("ClNome")
                Cl_Contato = dr("ClContato")
                Cl_End = dr("ClEnd")
                Cl_Nro = dr("ClNro")
                Cl_Bairro = dr("ClBairro")
                Cl_Cidade = dr("ClCidade")
                Cl_Uf = dr("ClUf")
                Cl_CEP = dr("ClCEP")
                Cl_Cel = dr("ClCel")
                Cl_Fixo = dr("ClFixo")
                Cl_Email = dr("ClEmail")
                Cl_DtNas = dr("ClDtNas")
                Cl_RG = dr("ClRG")
                Cl_Cpf = dr("ClCpf")
                Cl_DtCad = dr("ClDtCad")
                Cl_Compl = dr("ClCompl")

                If IsDBNull(dr("ClFoto")) = False Then
                    Cl_Foto = dr("ClFoto")
                Else
                    Cl_Foto = " "
                End If
                retorno = True
            End While
            ''FECHA A CONEXAO
            banco.CloseConn()
            ''
            Return retorno

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConfereCPF() As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader
        '' INSTANCIAR A CLASSE DO BANCO
        banco = New DataAcces
        '' ADICIONA OS PARAMETROS
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@CPF", Cl_Cpf))
        ' EXCUTA A PROCEDURE
        dr = banco.ExecutaStoreProcedureReader("Sp_Cliente_CPF", Parametro)
        '' preencher as propriedades
        CtaReg = 0
        Do While dr.Read
            Cl_Id = dr("ClId")
            Cl_Nome = dr("ClNome")
            Cl_Contato = dr("ClContato")
            Cl_End = dr("ClEnd")
            Cl_Nro = dr("ClNro")
            Cl_Bairro = dr("ClBairro")
            Cl_Cidade = dr("ClCidade")
            Cl_Uf = dr("ClUf")
            Cl_CEP = dr("ClCEP")
            Cl_Cel = dr("ClCel")
            Cl_Fixo = dr("ClFixo")
            Cl_Email = dr("ClEmail")
            Cl_DtNas = dr("ClDtNas")
            Cl_RG = dr("ClRG")
            Cl_Cpf = dr("ClCpf")
            Cl_DtCad = dr("ClDtCad")
            Cl_Compl = dr("ClCompl")

            Cl_Foto = ""
            If IsDBNull(dr("ClFoto")) = False Then
                Cl_Foto = dr("ClFoto")
            End If

            CtaReg += 1
            retorno = True
        Loop

        ''FECHA A CONEXAO
        banco.CloseConn()

    End Function

    Public Function BuscaTreeListView() As DataTable
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        Try

            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Cli", Cl_Id))

            ' EXCUTA A PROCEDURE
            retorno = False
            dr = banco.ExecutaStoreProcedureReader("Sp_Lista_Finan_Sint_Analitic", Parametro)

            CtaReg = 0

            Do While dr.Read
                LinhaTLV(CtaReg, 0) = CtaReg
                Dim d As String
                d = Mid(dr("fidtvcto"), 1, 10)
                LinhaTLV(CtaReg, 1) = d
                LinhaTLV(CtaReg, 2) = dr("idanimal")
                LinhaTLV(CtaReg, 3) = dr("aninome")
                LinhaTLV(CtaReg, 4) = dr("finssnro")
                LinhaTLV(CtaReg, 5) = Format(dr("fivlr"), "0.00")
                LinhaTLV(CtaReg, 6) = Format(dr("fivlrpgto"), "0.00")
                LinhaTLV(CtaReg, 7) = dr("fidtpgto")
                LinhaTLV(CtaReg, 8) = dr("faev")
                LinhaTLV(CtaReg, 9) = dr("faDesc")
                LinhaTLV(CtaReg, 10) = Format(dr("favlru"), "0.00")
                LinhaTLV(CtaReg, 11) = dr("FAQTD")
                LinhaTLV(CtaReg, 12) = Format(dr("favlr"), "0.00")

                CtaReg += 1
                retorno = True
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ''FECHA A CONEXAO
        banco.CloseConn()

    End Function
    Public Function BuscaAgDoCli(ByVal IdCliente As Integer)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Ag_Cli", IdCliente))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Agenda_Do_Cliente", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscaFinCliAberto(ByVal IdCliente As Integer)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Cli", IdCliente))

            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_FinS_Cli_Aberto", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscaNome(ByVal tipo As String, ByVal nome As String)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Tabela As DataTable
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Tipo", tipo))
            Parametro.Add(New SqlParameter("@NomeLike", nome))
            ' EXCUTA A PROCEDURE
            Tabela = banco.ExecutaDataTable("Sp_Busca_Lk", Parametro)
            '
            Return Tabela
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscaDados(ByVal NomeProcedure As String, ByVal CPF As String)
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Retorno As Boolean = True
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@CPF", CPF))

            ' EXCUTA A PROCEDURE
            Retorno = banco.ExecuteStoreProcedure(NomeProcedure, Parametro)
            '
            Return Retorno
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Preenche_Combo(ByVal Procedure As String)

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        Parametro = New List(Of SqlParameter)
        ' Parametro.Add(New SqlParameter("@Tipo", TipoPesq))

        dt = banco.ExecutaDataTable(Procedure, Parametro)

        Return dt
    End Function
    Public Function Preenche_Combo_Animal(ByVal Procedure As String, ByVal Especie As Integer)

        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dt As New DataTable
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Especie", Especie))

        dt = banco.ExecutaDataTable(Procedure, Parametro)

        Return dt
    End Function
    Public Function UpFotoCliente() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Retorno As Boolean = True
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("ID_cliente", Cl_Id))
            Parametro.Add(New SqlParameter("ClFoto", Cl_Foto))
            ' EXCUTA A PROCEDURE
            Retorno = banco.ExecuteStoreProcedure("Sp_Cliente_Up_Foto", Parametro)
            '
            Return retorno
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function UpFotoPACIENTE() As Object

        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim Retorno As Boolean = True
        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Animal", Id_Animal))
            Parametro.Add(New SqlParameter("@AniFoto", Ani_Foto))
            ' EXCUTA A PROCEDURE
            Retorno = banco.ExecuteStoreProcedure("Sp_Animal_Up_Foto", Parametro)
            '
            Return Retorno
            ''FECHA A CONEXAO
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region "Receita"

    Public Function LeReceita(ByVal id As Integer) As Boolean
        Dim retorno As Boolean = False
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@ID_Rec", id))
            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Receita_NssNro", Parametro)
            '' preencher as propriedades
            Do While dr.Read
                Rc_Id = dr("RcId")
                Rc_Cli = dr("RcCli")
                Rc_Ani = dr("RcAni")
                Rc_Dt = dr("RcDt")
                Rc_Nss = dr("RcNss")
                Rc_Farmaco = dr("RcFarmaco")
                Rc_Meio = dr("RcMeio")
                Rc_Qtd = dr("RcQtd")
                Rc_Via = dr("RcVia")
                Rc_Freq = dr("RcFreq")
                Rc_Dias = dr("RcDias")
                Rc_Reco = dr("RcReco")
                Rc_Esp = dr("RcEsp")
                Rc_DescFarmaco = dr("RcDescFarmaco")

                retorno = True
            Loop
            banco.CloseConn()
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function LeSaldoDev(ByVal id As Integer) As Object

        Dim retorno As Double
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim dr As IDataReader

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@Id_Cli", id))

        dr = banco.ExecutaStoreProcedureReader("Sp_FinS_Cli_SaldoDev", Parametro)

        Do While dr.Read
            retorno = dr("Saldo")
        Loop

        Return retorno
        banco.CloseConn()

    End Function

    Public Function LeTutorDoPet(ByVal Pet As Integer) As Boolean
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As DataAcces
        Dim dr As IDataReader

        Try
            '' INSTANCIAR A CLASSE DO BANCO
            banco = New DataAcces
            '' ADICIONA OS PARAMETROS
            Parametro = New List(Of SqlParameter)
            Parametro.Add(New SqlParameter("@Pet", Pet))

            ' EXCUTA A PROCEDURE
            dr = banco.ExecutaStoreProcedureReader("Sp_Tutor_Ani_Sel", Parametro)

            '' preencher as propriedades
            While dr.Read
                Cl_Id = dr("ClId")
                Cl_Nome = dr("ClNome")
                Ani_Nome = dr("AniNome")
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




End Class
