Public Class PISAliq
    ''' <summary>
    ''' Código de situação tributária do PIS
    ''' 01 – Operação Tributável (base de cálculo = valor da operação alíquota normal (cumulativo/não cumulativo));
    ''' 02 - Operação Tributável (base de cálculo = valor da operação(alíquota diferenciada));
    ''' </summary>
    Public Property CST() As String

    ''' <summary>
    ''' Valor da Base de Cálculo do PIS
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Alíquota do PIS (em percentual)
    ''' </summary>
    Public Property pPIS() As String

    ''' <summary>
    ''' Valor do PIS
    ''' </summary>
    Public Property vPIS() As String
End Class