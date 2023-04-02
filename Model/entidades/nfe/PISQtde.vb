''' <summary>
''' TAG do grupo de PIS tributado por Qtde
''' CST = 03
''' </summary>
Public Class PISQtde
    ''' <summary>
    ''' 03 - Operação Tributável (base de cálculo = quantidade vendida x alíquota por unidade de produto);
    ''' </summary>
    Public Property CST() As String

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