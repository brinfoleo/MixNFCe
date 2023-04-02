Public Class CIDE
    Private _qBCProd As String
    Public Property qBCProd() As String
        Get
            Return _qBCProd
        End Get
        Set(ByVal value As String)
            _qBCProd = value
        End Set
    End Property
    Private _vAliqProd As String
    Public Property vAliqProd() As String
        Get
            Return _vAliqProd
        End Get
        Set(ByVal value As String)
            _vAliqProd = value
        End Set
    End Property
    Private _vCIDE As String
    Public Property vCIDE() As String
        Get
            Return _vCIDE
        End Get
        Set(ByVal value As String)
            _vCIDE = value
        End Set
    End Property
End Class