Public Class Caixa
    Private _id As Integer
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _data As Date
    Public Property data As Date
        Get
            Return _data
        End Get
        Set(ByVal value As Date)
            _data = value
        End Set
    End Property

    Private _usuario As Usuario
    Public Property usuario As Usuario
        Get
            Return _usuario
        End Get
        Set(ByVal value As Usuario)
            _usuario = value
        End Set
    End Property

    Private _codigo As String
    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _valor As Double
    Public Property valor As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property
    Private _descricao As String
    Public Property descricao As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property
    Private _cd As String
    Public Property cd As String
        Get
            Return _cd
        End Get
        Set(ByVal value As String)
            _cd = value
        End Set
    End Property
    Private _documento As String
    Public Property documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
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
