Imports System.Xml
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class cls_NTFeS
    Public Property QtdRps As Integer
    Public Property NTFe_Cliente As Integer
    Public Property NTFe_Paciente As Integer
    Public Property NTFe_NssNro As Integer

    Private Cls_Data As New DataAcces
    Private Materiais As Cls_Materiais
    Private Cliente As New Cls_Cliente
    Private Financeiro As Cls_Financeiro
    Private PAR As List(Of SqlParameter)

    Private xmlPath As String '' = "C:\xml_Ntfe\MyData.xml 
    Public Valor_NTFe As Double = 0
    Public Lote_NtfSe As Integer
    Public valorTotal As Double = 0
    Public Email_Destino As String
    Public NTFe_Fa_Ev As String
    Public NTFe_Fa_Desc As String
    Public NTFe_IT_CNAE As String
    Public NTFe_IT_ALQISS As String
    Private Function ConvDec(ByVal ValorMoeda As String) As String
        Dim PosicaoVirgula As Integer
        ConvDec = Nothing
        PosicaoVirgula = InStr(1, ValorMoeda, ",")
        If PosicaoVirgula > 0 Then
            Mid(ValorMoeda, PosicaoVirgula) = "."
            ConvDec = ValorMoeda
        Else
            ConvDec = ValorMoeda
        End If
    End Function
    Public Function Emitir_NTFSe()
        Dim clsFinan As New Cls_Financeiro
        Dim materiais As New Cls_Materiais
        Dim u As New Utils
        u.Le_Empresa()

        Cliente.BuscaCliente("Sp_Cliente_Sel", NTFe_Cliente)

        Materiais.IT_TIPO = "S"

        Busca_Valor_NotaFiscal()

        If Valor_NTFe <= 0 Then
            MessageBox.Show("ORDEM " & NTFe_NssNro & " SEM VALOR DE SERVIÇO." & vbCr & "EMISSÃO NÃO EFETUADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        Busca_DADOS_NotaFiscal()

        If Cliente.Cl_Cpf = "" Then
            MessageBox.Show("Cadastro incompleto, EMISSÃO NÃO EFETUADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If

        Dim AnoMEs As String
        Dim Dt_y As String
        Dim Dt_M
        Dt_y = Format(Date.Now, "yy")
        Dt_M = Format(Date.Now, "MM")
        AnoMEs = (Format(Dt_y, "00") & Format(Dt_M, "00"))
        AnoMEs = Dt_y & Dt_M

        Dim _emissao, _DtSaidas, nfhora As String
        Dim nfhora1 As DateTime = DateTime.Now
        Dim nfdata1 As DateTime = DateTime.Now

        _emissao = Format(Now, "yyyy-MM-dd")
        _DtSaidas = Format(Now, "yyyy-MM-dd")

        nfhora = FormatDateTime(nfhora1, DateFormat.LongTime)
        '' @@ DADOS PRIMARIOS DA NOTA
        ' banco.NssNro = tx1.Text

        '' @@ DADOS DO CLIENTE
        'Dim CPF_dest_semMas As String = mdVar.Cl_Cpf

        Cliente.Cl_Cpf = Replace(Replace(Replace(Cliente.Cl_Cpf, ".", ""), "-", ""), "/", "")
        Cliente.Cl_CEP = Replace(Replace(Replace(Cliente.Cl_CEP, ".", ""), "-", ""), "/", "")
        Cliente.Cl_Fixo = Replace(Replace(Replace(Replace(Replace(Replace(Cliente.Cl_Fixo, ".", ""), "-", ""), "/", ""), " ", ""), ")", ""), "(", "",)

        Dim chave As String
        chave = u.emp_cgc + Format(NTFe_NssNro, "000000")
        '  banco.GerarDigitoVerificadorNFe(chave)
        chave = chave ' & banco.dg_v

        Dim caminho As String

        caminho = "C:\Unimake\UniNFe\25307914000120\nfse\Envio\" + chave + "-env-loterps.xml"

        'verifica sempre. antes de começar um novo NFE.
        If System.IO.File.Exists(caminho) = True Then 'verifica se existe
            System.IO.File.Delete(caminho) 'existe apaga ...
        End If

        Dim writer As New XmlTextWriter(caminho, System.Text.Encoding.UTF8) 'Instanciou a classe XML com a criação do arquivo arquivo.XML ... o caminho ...

        '(caminho, System.Text.Encoding.UTF8)   
        'writer.WriteStartDocument (True)' Habilitando a gravação no arquivo
        writer.Formatting = Formatting.Indented 'formatando a identação 
        writer.Indentation = 2

        writer.WriteStartDocument() 'inicia o documento escrevendo a lista do conteúdo do arquivo.

        writer.WriteStartElement("EnviarLoteRpsEnvio") 'encontrou uma marca raiz da NFe.
        writer.WriteAttributeString("xmlns", "http://www.betha.com.br/e-nota-contribuinte-ws") 'disse o atributo namespace da tag raiz.
        'writer.WriteAttributeString("versao", "1.00") 'chamou o atributo verão da tag infNFe.

        writer.WriteStartElement("LoteRps")
        writer.WriteAttributeString("xmlns", "")

        '' pega o lote do rps @@@@@@@@@@@@@@
        Dim RETORNO As Integer
        Dim DAccess As DataAcces
        DAccess = New DataAcces

        '''adiciona os parametros
        PAR = New List(Of SqlParameter)
        PAR.Add(New SqlParameter("NtfSe_Data", Now))
        PAR.Add(New SqlParameter("NtfSe_Desc", "NOTA DE SERVICO"))

        'EXECUTA A PROCEDURE
        RETORNO = DAccess.ExecuteStoreProcedureIncremento("Sp_LoteNFSe_Insert", PAR)
        ' RETORNO = DataAccess.ExecutaProcedure_AutoIncre("Sp_Lote_Insert", PAR)
        'Lote_NtfSe = RETORNO

        Lote_NtfSe = RETORNO

        'Nro_Nota_NFTe = RETORNO
        'FECHA A CONEXAO
        DAccess.CloseConn()

        ''fim lote @@@@@@@@@@@@@@@@@@@@@@@@@
        ' Dim u As Utils
        writer.WriteAttributeString("Id", "OS" + Format(NTFe_NssNro, "00000"))
        writer.WriteElementString("NumeroLote", Format(Lote_NtfSe, "00000")) 'primeiro elemento filho da tag raiz.

        writer.WriteElementString("Cnpj", u.emp_cgc)
        writer.WriteElementString("InscricaoMunicipal", Trim(u.emp_im))
        writer.WriteElementString("QuantidadeRps", "1") 'QtdRps)

        '' Loop dos RPS '@@@@@
        Dim r_PS As Integer = 0
        '      For Each Rps In dgNotas.SelectedRows
        r_PS += 1
        '          NssNro = Rps.Cells(0).Value.ToString()

        writer.WriteStartElement("ListaRps")
        writer.WriteAttributeString("xmlns", "")

        writer.WriteStartElement("Rps") 'primeiro elemento filho da tag RPS.

        writer.WriteStartElement("InfRps")

        writer.WriteStartElement("IdentificacaoRps")
        writer.WriteElementString("Numero", Lote_NtfSe)
        writer.WriteElementString("Serie", "1")
        writer.WriteElementString("Tipo", "1")
        writer.WriteEndElement() ''fim IdentificacaoRps

        writer.WriteElementString("DataEmissao", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")) 'Data e hora de emissão do Documento Fiscal ---' Data e hora no formato UTC (Tempo Universal Coordenado): AAAA-MM-DDThh: mm: ssTZD

        writer.WriteElementString("NaturezaOperacao", "1")
        writer.WriteElementString("RegimeEspecialTributacao", "1")
        writer.WriteElementString("OptanteSimplesNacional", "1")
        writer.WriteElementString("IncentivadorCultural", "2")
        writer.WriteElementString("Status", "1")

        writer.WriteStartElement("Servico")

        writer.WriteStartElement("Valores")

        Dim VT As String
        VT = ConvDec(Format(Valor_NTFe, "0.00"))
        Dim VS As String
        Dim V1 As String = "0.00"

        writer.WriteStartElement("ValorServicos") : writer.WriteString(VT) : writer.WriteEndElement() 'total bruto
        writer.WriteStartElement("ValorDeducoes") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("ValorPis") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("ValorCofins") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("ValorInss") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("ValorIr") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("ValorCsll") : writer.WriteString(V1) : writer.WriteEndElement()

        writer.WriteStartElement("IssRetido") : writer.WriteString("2") : writer.WriteEndElement()

        Dim V_ISS As Double
        Dim v_I As String
        V_ISS = (Valor_NTFe * u.emp_iss) / 100
        v_I = ConvDec(Format(V_ISS, "0.00"))

        writer.WriteStartElement("ValorIss") : writer.WriteString(v_I) : writer.WriteEndElement()

        writer.WriteStartElement("OutrasRetencoes") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("BaseCalculo") : writer.WriteString(VT) : writer.WriteEndElement()
        Dim v_al As String
        v_al = ConvDec(Format(u.emp_iss, "0.00"))
        writer.WriteStartElement("Aliquota") : writer.WriteString(v_al) : writer.WriteEndElement()

        writer.WriteStartElement("ValorLiquidoNfse") : writer.WriteString(VT) : writer.WriteEndElement()

        writer.WriteStartElement("ValorIssRetido") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("DescontoCondicionado") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteStartElement("DescontoIncondicionado") : writer.WriteString(V1) : writer.WriteEndElement()
        writer.WriteEndElement() ''fim Valores

        'Busca_DADOS_NotaFiscal()

        writer.WriteStartElement("ItemListaServico") : writer.WriteString("0502") : writer.WriteEndElement()
        writer.WriteStartElement("CodigoCnae") : writer.WriteString(NTFe_IT_CNAE) : writer.WriteEndElement()

        writer.WriteStartElement("Discriminacao") : writer.WriteString(NTFe_Fa_Desc) : writer.WriteEndElement()
        writer.WriteStartElement("CodigoMunicipio") : writer.WriteString(u.emp_codMunIbge) : writer.WriteEndElement()

        writer.WriteEndElement() ''fim Servico

        writer.WriteStartElement("Prestador")
        writer.WriteElementString("Cnpj", u.emp_cgc)
        writer.WriteElementString("InscricaoMunicipal", Trim(u.emp_im))
        writer.WriteEndElement() ''fim Prestador

        writer.WriteStartElement("Tomador")
        writer.WriteStartElement("IdentificacaoTomador")
        writer.WriteStartElement("CpfCnpj")

        '' verificar se juridica ou fisica
        writer.WriteStartElement("Cpf") : writer.WriteString(Cliente.Cl_Cpf) : writer.WriteEndElement()
        writer.WriteEndElement() 'fim CpfCnpj
        writer.WriteEndElement() 'fim identificador
        writer.WriteStartElement("RazaoSocial") : writer.WriteString(Cliente.Cl_Nome) : writer.WriteEndElement()

        writer.WriteStartElement("Endereco")
        writer.WriteStartElement("Endereco") : writer.WriteString(Cliente.Cl_End) : writer.WriteEndElement()
        writer.WriteStartElement("Numero") : writer.WriteString(Cliente.Cl_Nro) : writer.WriteEndElement()
        writer.WriteStartElement("Bairro") : writer.WriteString(Cliente.Cl_Bairro) : writer.WriteEndElement()
        writer.WriteStartElement("CodigoMunicipio") : writer.WriteString(u.emp_codMunIbge) : writer.WriteEndElement()
        writer.WriteStartElement("Uf") : writer.WriteString(Cliente.Cl_Uf) : writer.WriteEndElement()
        writer.WriteStartElement("Cep") : writer.WriteString(Cliente.Cl_CEP) : writer.WriteEndElement()
        writer.WriteEndElement() 'fim ENDERECO

        writer.WriteStartElement("Contato")
        If Trim(Cliente.Cl_Fixo) <> "" Then
            writer.WriteStartElement("Telefone") : writer.WriteString(Cliente.Cl_Fixo) : writer.WriteEndElement()
        End If

        If Trim(Cliente.Cl_Email) <> "" Then
            writer.WriteStartElement("Email") : writer.WriteString(Cliente.Cl_Email) : writer.WriteEndElement()
        End If

        writer.WriteEndElement() 'fim cONTATO

        writer.WriteEndElement() 'fim Tomador

        'writer.WriteStartElement("ConstrucaoCivil")
        'writer.WriteStartElement("CodigoObra") : writer.WriteString(1) : writer.WriteEndElement()
        'writer.WriteStartElement("Art") : writer.WriteString(1) : writer.WriteEndElement()
        'writer.WriteEndElement() 'fim ConstrucaoCivil

        writer.WriteEndElement() 'finaliza InfRps
        writer.WriteEndElement()

        writer.WriteEndElement() 'finaliza Rps
        writer.WriteEndElement() 'finaliza ListaRps
        writer.WriteEndElement() 'finaliza LoteRps
        'writer.WriteEndElement() 'finaliza EnviarLoteRpsEnvio

        writer.Close()
        UpDateNota()
        '     Next

    End Function
    Public Function UpDateNota()
        'Dim retorno As Object
        'comando = New SqlCommand
        'comando.CommandType = CommandType.StoredProcedure
        'comando.CommandText = "Sp_Nota_Up_Finan"
        'comando.Connection = conexao
        'comando.Parameters.AddWithValue("@FI_NSSNRO", mdVar.NssNro)
        'comando.Parameters.AddWithValue("@NOTA", mdVar.Nro_Nota_NFTe)

        'conexao.Open()
        'retorno = comando.ExecuteScalar()
        'conexao.Close()
        'Return retorno

        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim drN As IDataReader
        Dim u As Utils
        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("@FI_NSSNRO", NTFe_NssNro))
        Parametro.Add(New SqlParameter("@NOTA", Lote_NtfSe))
        drN = banco.ExecutaStoreProcedureReader("Sp_Nota_Up_Finan", Parametro)

        Valor_NTFe = 0
        Do While drN.Read
            Valor_NTFe = drN("Total")
            retorno = True
        Loop

    End Function
    Public Function Busca_Valor_NotaFiscal()
        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim drN As IDataReader

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("Nss_Nro", NTFe_NssNro))
        drN = banco.ExecutaStoreProcedureReader("Sp_Ntfse_Total", Parametro)

        Valor_NTFe = 0
        Do While drN.Read
            Valor_NTFe = drN("Total")
            retorno = True
        Loop


    End Function
    Public Function Busca_DADOS_NotaFiscal()

        Dim retorno As Boolean
        Dim Parametro As List(Of SqlParameter)
        Dim banco As New DataAcces
        Dim drN As IDataReader

        Parametro = New List(Of SqlParameter)
        Parametro.Add(New SqlParameter("Nss_Nro", NTFe_NssNro))
        drN = banco.ExecutaStoreProcedureReader("Sp_Ntfse_Itens_FaCli", Parametro)
        '  Dim clsFinan As New Cls_Financeiro
        'Dim materiais As New Cls_Materiais
        'clsFinan.Fa_Desc = ""

        Do While drN.Read

            NTFe_Fa_Ev = drN("FAEV")
            NTFe_Fa_Desc += drN("FADESC") & "; " '& vbCr
            NTFe_IT_CNAE = "7500100" 'dr("ITCNAE")
            NTFe_IT_ALQISS = "2,59" 'dr("ITALQISS")

            retorno = True
        Loop

        NTFe_Fa_Desc = "DESPESAS VETERINARIAS."
        banco.CloseConn()

    End Function

End Class
