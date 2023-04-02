''' <summary>
''' Informar apenas quando se tratar de medicamentos, permite múltiplas ocorrências (ilimitado)
''' </summary>
Public Class med
    ''' <summary>
    ''' Número do Lote do medicamento
    ''' </summary>
    Public Property nLote() As String

    ''' <summary>
    ''' Quantidade de produto no Lote do medicamento
    ''' </summary>
    Public Property qLote() As String

    ''' <summary>
    ''' Data de fabricação
    ''' </summary>
    Public Property dFab() As String

    ''' <summary>
    ''' Data de validade
    ''' </summary>
    Public Property dVal() As String

    ''' <summary>
    ''' Preço máximo consumidor
    ''' </summary>
    Public Property vPMC() As String
End Class