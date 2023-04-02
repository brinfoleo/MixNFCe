Public Class NFCe
    Public Sub New()
        infNFE.Total = New total
        infNFE.Total.IcmsTot = New ICMSTot()
    End Sub
    Private _infNFE As New infNFE
    Public ReadOnly Property infNFE() As infNFE
        Get
            Return _infNFE
        End Get
    End Property

    Private _versao As String
    Public Property versao() As String
        Get
            Return _versao
        End Get
        Set(ByVal value As String)
            _versao = value
        End Set
    End Property

    Private _Id As String
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    ''' <summary>
    ''' Utilizado na geração de XML para consulta de recibo
    ''' </summary>
    Private _nRec As String
    Public Property nRec() As String
        Get
            Return _nRec
        End Get
        Set(ByVal value As String)
            _nRec = value
        End Set
    End Property
    ''' <summary>
    ''' Informar o número do Protocolo de Autorização da NF-e a ser Cancelada.
    ''' 1 posição (1 – Secretaria de Fazenda Estadual
    ''' 2 – Receita Federal); 2 posições para código da UF;
    ''' 2 posições ano;
    ''' 10 seqüencial no ano
    ''' </summary>
    Private _nProt As String
    Public Property nProt() As String
        Get
            Return _nProt
        End Get
        Set(ByVal value As String)
            _nProt = value
        End Set
    End Property
    Private _xJust As String
    Public Property xJust() As String
        Get
            Return _xJust
        End Get
        Set(ByVal value As String)
            _xJust = value
        End Set
    End Property
    Private _ano As String
    Public Property ano() As String
        Get
            Return _ano
        End Get
        Set(ByVal value As String)
            _ano = value
        End Set
    End Property
    Private _NumNf_Ini As Integer
    Public Property NumNf_Ini() As Integer
        Get
            Return _NumNf_Ini
        End Get
        Set(ByVal value As Integer)
            _NumNf_Ini = value
        End Set
    End Property
    Private _NumNf_Fin As Integer
    Public Property NumNf_Fin() As Integer
        Get
            Return _NumNf_Fin
        End Get
        Set(ByVal value As Integer)
            _NumNf_Fin = value
        End Set
    End Property
    Public Property nProtCancelamento As String
    Public Property nProtInutilizacao As String
    Public Property digVal As String

End Class
