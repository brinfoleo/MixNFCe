''' <summary>
''' TAG do grupo de COFINS Substituição Tributária
''' </summary>
Public Class COFINSST
    ''' <summary>
    ''' Informar campos para cálculo do COFINS Substituição Tributária em percentual (T02 e T03) ou campos
    ''' para COFINS em valor (T04 e T05).
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Alíquota da COFINS (em percentual)
    ''' </summary>
    Public Property pCOFINS() As String

    ''' <summary>
    ''' Quantidade Vendida
    ''' </summary>
    Public Property qBCProd() As String

    ''' <summary>
    ''' Alíquota da COFINS (em reais)
    ''' </summary>
    Public Property vAliqProd() As String

    ''' <summary>
    ''' Valor da COFINS
    ''' </summary>
    Public Property vCOFINS() As String
End Class