Public Class entrega
    Public Property CNPJ() As String
    Public Property CPF() As String
    Public Property xLgr() As String
    Public Property nro() As String
    Public Property xCpl() As String
    Public Property xBairro() As String
    ''' <summary>
    ''' Utilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País). Informar ‘9999999 ‘para operações
    ''' com o exterior.
    ''' </summary>
    Public Property cMun() As String
    Public Property xMun() As String
    Public Property UF() As String
End Class