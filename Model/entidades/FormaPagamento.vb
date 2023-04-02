Public Class FormaPagamento
    Private _id As Integer
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private _nomepg As String
    Public Property nomepg As String
        Get
            Return _nomepg
        End Get
        Set(value As String)
            _nomepg = value
        End Set
    End Property
    Private _bandeita_tef As String
    Public Property bandeira As String
        Get
            Return _bandeita_tef
        End Get
        Set(value As String)
            _bandeita_tef = value

        End Set
    End Property
    Private _tPag As String
    Public Property tPag As String
        Get
            Return _tPag
        End Get
        Set(value As String)
            _tPag = value
        End Set
    End Property
    Private _moeda As String
    Public Property moeda As String
        Get
            Return _moeda

        End Get
        Set(value As String)
            _moeda = value
        End Set
    End Property
End Class
