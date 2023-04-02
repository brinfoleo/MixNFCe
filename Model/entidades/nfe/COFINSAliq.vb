''' <summary>
''' TAG do grupo de COFINS tributado pela alíquota
''' CST = 01 ou 02
''' </summary>
Public Class COFINSAliq
    ''' <summary>
    ''' 01 – Operação Tributável (base de cálculo = valor da operação alíquota normal (cumulativo/não cumulativo));
    ''' 02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada));
    ''' </summary>
    Public Property CST() As String

    ''' <summary>
    ''' Valor da Base de Cálculo da COFINS
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Alíquota da COFINS (em percentual)
    ''' </summary>
    Public Property pCOFINS() As String

    ''' <summary>
    ''' Valor do COFINS
    ''' </summary>
    Public Property vCOFINS() As String
End Class