''' <summary>
''' CST = 03
''' </summary>
Public Class COFINSQtde
    ''' <summary>
    ''' 03 - Operação Tributável (base de cálculo = quantidade vendida x alíquota por unidade de produto);
    ''' </summary>
    Public Property CST() As String

    ''' <summary>
    ''' Quantidade Vendida
    ''' </summary>
    Public Property qBCProd() As String

    ''' <summary>
    ''' Aliquota do COFINS (em Reais)
    ''' </summary>
    Public Property vAliqProd() As String

    ''' <summary>
    ''' Valor do COFINS
    ''' </summary>
    Public Property vCOFINS() As String
End Class