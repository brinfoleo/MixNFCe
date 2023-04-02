''' <summary>
''' TAG de grupo transportador
''' </summary>
Public Class transporta
    ''' <summary>
    ''' CNPJ
    ''' Informar o CNPJ do Transportador, preenchendo os zeros não significativos.
    ''' </summary>
    Public Property CNPJ() As String

    ''' <summary>
    ''' CNPJ
    ''' Informar o CPF do Transportador, preenchendo os zeros não significativos.
    ''' </summary>
    Public Property CPF() As String

    ''' <summary>
    ''' Razão social ou nome
    ''' </summary>
    Public Property xNome() As String

    ''' <summary>
    ''' Inscrição estadual
    ''' </summary>
    Public Property IE() As String

    ''' <summary>
    ''' Endereço completo
    ''' </summary>
    Public Property xEnder() As String

    ''' <summary>
    ''' Nome do municipio
    ''' </summary>
    Public Property xMun() As String

    ''' <summary>
    ''' Sigla da UF
    ''' </summary>
    Public Property UF() As String
End Class
