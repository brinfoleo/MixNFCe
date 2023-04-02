Public Class Cliente
    Private _id As String
    Public Property id As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property


    Private _cnpj As String
    Public Property cnpj As String
        Get
            Return _cnpj
        End Get
        Set(ByVal value As String)
            _cnpj = value
        End Set
    End Property

    Private _xNome As String
    Public Property xNome As String
        Get
            Return _xNome
        End Get
        Set(ByVal value As String)
            _xNome = value
        End Set
    End Property

    Private _xLgr As String
    Public Property xLgr As String
        Get
            Return _xLgr
        End Get
        Set(ByVal value As String)
            _xLgr = value
        End Set
    End Property

    Private _nro As String
    Public Property nro As String
        Get
            Return _nro
        End Get
        Set(ByVal value As String)
            _nro = value
        End Set
    End Property

    Private _xCpl As String
    Public Property xCpl As String
        Get
            Return _xCpl
        End Get
        Set(ByVal value As String)
            _xCpl = value
        End Set
    End Property

    Private _xBairro As String
    Public Property xBairro As String
        Get
            Return _xBairro
        End Get
        Set(ByVal value As String)
            _xBairro = value
        End Set
    End Property

    Private _cMun As String
    Public Property cMun As String
        Get
            Return _cMun
        End Get
        Set(ByVal value As String)
            _cMun = value
        End Set
    End Property

    Private _xMun As String
    Public Property xMun As String
        Get
            Return _xMun
        End Get
        Set(ByVal value As String)
            _xMun = value
        End Set
    End Property

    Private _uf As String
    Public Property uf As String
        Get
            Return _uf
        End Get
        Set(ByVal value As String)
            _uf = value
        End Set
    End Property

    Private _cep As String
    Public Property cep As String
        Get
            Return _cep
        End Get
        Set(ByVal value As String)
            _cep = value
        End Set
    End Property

    Private _cPais As String
    Public Property cPais As String
        Get
            Return _cPais
        End Get
        Set(ByVal value As String)
            _cPais = value
        End Set
    End Property

    Private _xPais As String
    Public Property xPais As String
        Get
            Return _xPais
        End Get
        Set(ByVal value As String)
            _xPais = value
        End Set
    End Property

    Private _fone As String
    Public Property fone As String
        Get
            Return _fone
        End Get
        Set(ByVal value As String)
            _fone = value
        End Set
    End Property


    Private _email As String
    Public Property email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _obs As String
    Public Property obs As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property
    Private _dtCadastro As String
    Public Property dtCadastro As String
        Get
            Return _dtCadastro
        End Get
        Set(ByVal value As String)
            _dtCadastro = value
        End Set
    End Property

    Private _bloqueado As Boolean
    Public Property bloqueado As Boolean
        Get
            Return _bloqueado
        End Get
        Set(ByVal value As Boolean)
            _bloqueado = value
        End Set
    End Property
End Class
