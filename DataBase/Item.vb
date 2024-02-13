Public Class Item
    Private a_cEAN As String
    Private a_xProd As String
    Private a_cProd As String
    Private a_NCM As String
    Private a_CEST As String
    Private a_CST As String
    Private a_cFOP As String
    Private a_uCom As String
    Private a_qCom As Decimal
    Private a_vUnCom As Double  'Decimal
    Private a_vProd As Double   'Decimal
    Private a_cEANTrib As String
    Private a_uTrib As String
    Private a_qTrib As Decimal
    Private a_vUnTrib As Double  'Decimal
    Private a_vFrete As String
    Private a_vSeg As String
    Private a_vDesc As String
    Private a_vOutro As String
    Private a_InfAdic As String
    Private a_cProdANVISA As String

    Private c_dVenc As String
    Private c_vDupl As Decimal
    Private c_nDup As Decimal

    Private r_nLote As String
    Private r_qLote As String
    Private r_dFab As Date
    Private r_dVal As Date

    Private i_pICMS As Decimal
    Private i_pPIS As Decimal
    Private i_pCOFINS As Decimal

    Public Property cProd() As String
        Get
            Return Me.a_cProd
        End Get
        Set(ByVal value As String)
            Me.a_cProd = value
        End Set
    End Property

    Public Property xProd() As String
        Get
            Return Me.a_xProd
        End Get
        Set(ByVal value As String)
            Me.a_xProd = value
        End Set
    End Property
    Public Sub New()
        Me.cProd = ""
        Me.xProd = ""
    End Sub
    Public Property cEAN() As String
        Get
            Return Me.a_cEAN
        End Get
        Set(ByVal value As String)
            Me.a_cEAN = value
        End Set
    End Property

    Public Property NCM() As String
        Get
            Return Me.a_NCM
        End Get
        Set(ByVal value As String)
            Me.a_NCM = value
        End Set
    End Property

    Public Property CEST() As String
        Get
            Return Me.a_CEST
        End Get
        Set(ByVal value As String)
            Me.a_CEST = value
        End Set
    End Property

    Public Property CFOP() As String
        Get
            Return Me.a_cFOP
        End Get
        Set(ByVal value As String)
            Me.a_cFOP = value
        End Set
    End Property


    Public Property uCom() As String
        Get
            Return Me.a_uCom
        End Get
        Set(ByVal value As String)
            Me.a_uCom = value
        End Set
    End Property


    Public Property qCom() As Decimal
        Get
            Return Me.a_qCom
        End Get
        Set(ByVal value As Decimal)
            Me.a_qCom = value
        End Set
    End Property


    Public Property vUnCom() As Decimal
        Get
            Return Me.a_vUnCom
        End Get
        Set(ByVal value As Decimal)
            Me.a_vUnCom = value
        End Set
    End Property


    Public Property vProd() As Decimal
        Get
            Return Me.a_vProd
        End Get
        Set(ByVal value As Decimal)
            Me.a_vProd = value
        End Set
    End Property


    Public Property cEANTrib() As String
        Get
            Return Me.a_cEANTrib
        End Get
        Set(ByVal value As String)
            Me.a_cEANTrib = value
        End Set
    End Property


    Public Property uTrib() As String
        Get
            Return Me.a_uTrib
        End Get
        Set(ByVal value As String)
            Me.a_uTrib = value
        End Set
    End Property


    Public Property qTrib() As Decimal
        Get
            Return Me.a_qTrib
        End Get
        Set(ByVal value As Decimal)
            Me.a_qTrib = value
        End Set
    End Property


    Public Property vUnTrib() As Decimal
        Get
            Return Me.a_vUnTrib
        End Get
        Set(ByVal value As Decimal)
            Me.a_vUnTrib = value
        End Set
    End Property


    Public Property vnDup() As Decimal
        Get
            Return Me.c_nDup
        End Get
        Set(ByVal value As Decimal)
            Me.c_nDup = value
        End Set
    End Property


    Public Property vDup() As Decimal
        Get
            Return Me.c_vDupl
        End Get
        Set(ByVal value As Decimal)
            Me.c_vDupl = value
        End Set
    End Property

    Public Property vVenc() As Date
        Get
            Return Me.c_dVenc
        End Get
        Set(ByVal value As Date)
            Me.c_dVenc = value
        End Set
    End Property

    Public Property InfAdic() As String
        Get
            Return Me.a_InfAdic
        End Get
        Set(ByVal value As String)
            Me.a_InfAdic = value
        End Set
    End Property
    Public Property nLote() As String
        Get
            Return Me.r_nLote
        End Get
        Set(ByVal value As String)
            Me.r_nLote = value
        End Set
    End Property
    Public Property qLote() As String
        Get
            Return Me.r_qLote
        End Get
        Set(ByVal value As String)
            Me.r_qLote = value
        End Set
    End Property
    Public Property dFab() As Date
        Get
            Return Me.r_dFab
        End Get
        Set(ByVal value As Date)
            Me.r_dFab = value
        End Set
    End Property
    Public Property dVal() As Date
        Get
            Return Me.r_dVal
        End Get
        Set(ByVal value As Date)
            Me.r_dVal = value
        End Set
    End Property
    Public Property vPis() As Decimal
        Get
            Return Me.i_pPIS
        End Get
        Set(ByVal value As Decimal)
            Me.i_pPIS = value
        End Set
    End Property
    Public Property vvICMS() As Decimal
        Get
            Return Me.i_pICMS
        End Get
        Set(ByVal value As Decimal)
            Me.i_pICMS = value
        End Set
    End Property
    Public Property vCOFINS() As Decimal
        Get
            Return Me.i_pCOFINS
        End Get
        Set(ByVal value As Decimal)
            Me.i_pCOFINS = value
        End Set
    End Property
    Public Property vANVISA() As Decimal
        Get
            Return Me.a_cProdANVISA
        End Get
        Set(ByVal value As Decimal)
            Me.a_cProdANVISA = value
        End Set
    End Property
End Class
