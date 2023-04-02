''' <summary>
''' Informar apenas um dos grupos O07 ou O08 com base valor atribuído ao campo O09 – CST do
''' IPI
''' </summary>
Public Class IPITrib
    ''' <summary>
    ''' 00-Entrada com recuperação de crédito
    ''' 49-Outras entradas
    ''' 50-Saída tributada
    ''' 99-Outras saídas
    ''' </summary>
    Public Property CST() As String

    ''' <summary>
    ''' Campo 010
    '''
    ''' Informar os campos O10 e O14 caso o cálculo do IPI seja por
    ''' alíquota ou os campos O11 e O12 caso o cálculo do IPI seja valor por
    ''' unidade.
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Campo 011
    '''
    ''' Informar os campos O10 e O14 caso o cálculo do IPI seja por
    ''' alíquota ou os campos O11 e O12 caso o cálculo do IPI seja valor por
    ''' unidade.
    ''' </summary>
    Public Property qUnid() As String

    ''' <summary>
    ''' Campo 012
    '''
    ''' Informar os campos O10 e O14 caso o cálculo do IPI seja por
    ''' alíquota ou os campos O11 e O12 caso o cálculo do IPI seja valor por
    ''' unidade.
    ''' </summary>
    Public Property vUnid() As String

    ''' <summary>
    ''' Campo 013
    '''
    ''' Informar os campos O10 e O14 caso o cálculo do IPI seja por
    ''' alíquota ou os campos O11 e O12 caso o cálculo do IPI seja valor por
    ''' unidade.
    ''' </summary>
    Public Property pIPI() As String

    ''' <summary>
    ''' Valor do IPI
    ''' </summary>
    Public Property vIPI() As String
End Class