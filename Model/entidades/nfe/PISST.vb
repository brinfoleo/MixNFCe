''' <summary>
''' TAG do grupo de PIS Substituição Tributária
''' </summary>
Public Class PISST
    ''' <summary>
    ''' Informar campos para cálculo do PIS em percentual (R02 e R03) ou campos para PIS em valor (R04 e R05).
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Alíquota do PIS (em percentual)
    ''' </summary>
    Public Property pPIS() As String

    ''' <summary>
    ''' Quantidade Vendida
    ''' </summary>
    Public Property qBCProd() As String

    ''' <summary>
    ''' Alíquota do PIS (em reais)
    ''' </summary>
    Public Property vAliqProd() As String

    ''' <summary>
    ''' Valor do PIS
    ''' </summary>
    Public Property vPIS() As String
End Class
