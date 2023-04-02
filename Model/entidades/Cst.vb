Public Class CST
    Private _crt As Integer
    Public Property crt As Integer
        Get
            Return _crt
        End Get
        Set(ByVal value As Integer)
            _crt = value
        End Set
    End Property

    Private _origem As Integer
    Public Property origem As Integer
        Get
            Return _origem
        End Get
        Set(ByVal value As Integer)
            _origem = value
        End Set
    End Property
    Private _cst As Integer
    Public Property cst As Integer
        Get
            Return _cst
        End Get
        Set(ByVal value As Integer)
            _cst = value
        End Set
    End Property
    Private _descricao As String
    Public ReadOnly Property descricao As String
        Get
            Return _descricao
        End Get
    End Property

End Class
