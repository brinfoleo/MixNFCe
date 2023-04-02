Public Class enderDest
    ''' <summary>
    ''' Logradouro
    ''' </summary>
    Public Property xLgr() As String

    ''' <summary>
    ''' Número
    ''' </summary>
    Public Property nro() As String

    ''' <summary>
    ''' Complemento
    ''' </summary>
    Public Property xCpl() As String

    ''' <summary>
    ''' Bairro
    ''' </summary>
    Public Property xBairro() As String

    ''' <summary>
    ''' Código do municipio, Utilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País).
    ''' Informar ‘9999999 ‘para operações com o exterior.
    ''' </summary>
    Public Property cMun() As String

    ''' <summary>
    ''' Informar ‘EXTERIOR ‘para operações com o exterior.
    ''' </summary>
    Public Property xMun() As String

    ''' <summary>
    ''' Informar ‘EX ‘para operações com o exterior.
    ''' </summary>
    Public Property UF() As String

    ''' <summary>
    ''' Informar os zeros não significativos.
    ''' </summary>
    Public Property CEP() As String

    ''' <summary>
    ''' 1058 - Brasil
    ''' </summary>
    Public Property cPais() As String

    ''' <summary>
    ''' Brasil ou BRASIL
    ''' </summary>
    Public Property xPais() As String

    ''' <summary>
    ''' Preencher com Código DDD + número do telefone.
    ''' </summary>
    Public Property fone() As String
End Class