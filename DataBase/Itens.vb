Imports Materiais
Public Class Itens
    Private a_Itens As Collection
    Private a_Boletos As Collection

    Private a_Lista As Object
    Private a_Item As Item
    Private a_Odoc As Object

    Public Property Itens() As Object
        Get
            Return Me.a_Itens
        End Get
        Set(ByVal value As Object)

            a_Itens.Add(value)

        End Set
    End Property

    Public Property Lista() As Object
        Get
            Lista = Me.a_Itens
        End Get
        Set(ByVal value)

        End Set
    End Property
    Public Sub New()
        a_Odoc = CreateObject("Microsoft.XMLDOM")
        a_Odoc.async = False
    End Sub
    Private Function ConvDec(ByVal ValorMoeda As String) As String
        Dim PosicaoVirgula As Integer
        ConvDec = Nothing
        PosicaoVirgula = InStr(1, ValorMoeda, ".")
        If PosicaoVirgula > 0 Then
            Mid(ValorMoeda, PosicaoVirgula) = ","
            ConvDec = ValorMoeda
        Else
            ConvDec = ValorMoeda
        End If
    End Function
    Public Function fncCaminho_XML(ByVal Caminho As String) As Object
        Dim I As Integer
        Dim qtdProd As Integer

        a_Itens = New Collection
        a_Odoc.Load(Caminho)
        qtdProd = a_Odoc.GetElementsByTagName("nfeProc/NFe/infNFe/det").length

        For I = 0 To qtdProd - 1 'Varrendo todos os itens

            a_Item = New Item
            a_Item.cProd = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/cProd").Item(0).Text
            a_Item.xProd = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/xProd").Item(0).Text
            a_Item.cEAN = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/cEAN").Item(0).Text

            If IsNumeric(a_Item.cEAN) = True Then
                a_Item.cProd = a_Item.cEAN
            End If

            a_Item.NCM = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/NCM").Item(0).Text

            Try
                a_Item.CEST = a_Odoc.SelectNodes(“nfeProc/NFe/infNFe/det”).Item(I).SelectNodes(“prod/CEST”).Item(0).Text
            Catch ex As Exception
                a_Item.CEST = ""
            End Try

            a_Item.CFOP = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/CFOP").Item(0).Text

            'a_Item.uCom = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/uCom").Item(0).Text
            a_Item.uCom = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/uCom").Item(0).Text

            Dim q As String
            Dim q2 As Double
            'a_Item.qCom = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/qCom").Item(0).Text

            q = ConvDec(a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/qCom").Item(0).Text)
            q2 = q
            a_Item.qCom = Format(q2, "0.00")

            q = ConvDec(a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/vUnCom").Item(0).Text)
            q2 = q
            a_Item.vUnCom = Format(q2, "0.000") 'a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/vUnCom").Item(0).Text / 100

            'a_Item.vProd = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/vProd").Item(0).Text / 100
            q = ConvDec(a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/vProd").Item(0).Text)
            q2 = q
            a_Item.vProd = Format(q2, "0.00")

            a_Item.cEANTrib = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/cEANTrib").Item(0).Text
            a_Item.uTrib = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/uTrib").Item(0).Text

            'a_Item.qTrib = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/qTrib").Item(0).Text
            q = ConvDec(a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/qTrib").Item(0).Text)
            q2 = q
            a_Item.qTrib = Format(q2, "0.000")
            ' a_Item.vUnTrib = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/vUnTrib").Item(0).Text '/ 100
            q = ConvDec(a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/vUnTrib").Item(0).Text)
            q2 = q
            a_Item.vUnTrib = Format(q2, "0.000")

            Dim lote As Integer
            lote = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det/prod/rastro").length
            If lote > 0 Then

                If a_Item.CEST <> "2004400" And a_Item.CEST <> "" Then
                    a_Item.nLote = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/rastro/nLote").Item(0).Text
                    a_Item.qLote = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/rastro/qLote").Item(0).Text
                    a_Item.dFab = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/rastro/dFab").Item(0).Text
                    a_Item.dVal = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/rastro/dVal").Item(0).Text
                End If

            End If

            'PRODUTO FARMACEUTICO
            Try
                a_Item.vANVISA = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("prod/med/cProdANVISA").Item(0).Text
            Catch ex As Exception
                If a_Item.vANVISA <> 0 Then
                    a_Item.vANVISA = " "
                Else
                    a_Item.vANVISA = 0
                End If

            End Try

            ''IMPOSTOS
            'a_Item.vvICMS = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("imposto/ICMS/ICMS00/pICMS").Item(0).Text / 100
            'a_Item.vPis = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("imposto/PIS/PISOutr/pPIS").Item(0).Text / 100
            'a_Item.vCOFINS = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/det").Item(I).SelectNodes("imposto/COFINS/COFINSOutr/pCOFINS").Item(0).Text / 100

            a_Itens.Add(a_Item)

        Next


        fncCaminho_XML = a_Itens
        a_Itens = Nothing

    End Function
    Public Function fncCobranca_XML(ByVal Caminho As String) As Object
        Dim I As Integer
        Dim qtdDupl As Integer
        a_Boletos = New Collection
        a_Odoc.Load(Caminho)

        '' cobranca
        qtdDupl = a_Odoc.GetElementsByTagName("nfeProc/NFe/infNFe/cobr/dup").length
        If qtdDupl > 0 Then

            'frmImportXMLntfe.lblFatura.Text = a_Odoc.GetElementsByTagName("nfeProc/NFe/infNFe/cobr/fat/nFat").Item(0).Text

            For I = 0 To qtdDupl - 1 'Varrendo todas as duplicatas

                a_Item = New Item
                a_Item.vnDup = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/cobr/dup").Item(I).SelectNodes("nDup").Item(0).Text
                a_Item.vVenc = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/cobr/dup").Item(I).SelectNodes("dVenc").Item(0).Text
                a_Item.vDup = a_Odoc.SelectNodes("nfeProc/NFe/infNFe/cobr/dup").Item(I).SelectNodes("vDup").Item(0).Text / 100

                a_Boletos.Add(a_Item)

            Next
            fncCobranca_XML = a_Boletos
            a_Boletos = Nothing
        End If

    End Function

End Class

