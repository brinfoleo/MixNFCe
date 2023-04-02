''' <summary>
''' TAG de grupo de Valores Totais referentes ao ICMS
''' </summary>
Public Class ICMSTot
    ''' <summary>
    ''' Base de Cálculo do ICMS
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Valor Total do ICMS
    ''' </summary>
    Public Property vICMS() As String


    ''' <summary>
    ''' Valor Total do ICMS desonerado
    ''' </summary>
    Public Property vICMSDeson() As String

    ''' <summary>
    ''' Base de Cálculo do ICMS ST
    ''' </summary>
    Public Property vBCST() As String

    ''' <summary>
    ''' Valor Total do ICMS ST
    ''' </summary>
    Public Property vST() As String

    ''' <summary>
    ''' Valor Total dos produtos e serviços
    ''' </summary>
    Public Property vProd() As Double 'String

    ''' <summary>
    ''' Valor Total do Frete
    ''' </summary>
    Public Property vFrete() As String

    ''' <summary>
    ''' Valor Total do Seguro
    ''' </summary>
    Public Property vSeg() As String

    ''' <summary>
    ''' Valor Total do Desconto
    ''' </summary>
    Public Property vDesc() As String

    ''' <summary>
    ''' Valor Total do II
    ''' </summary>
    Public Property vII() As String

    ''' <summary>
    ''' Valor Total do IPI
    ''' </summary>
    Public Property vIPI() As String

    ''' <summary>
    ''' Valor Total do PIS
    ''' </summary>
    Public Property vPIS() As String

    ''' <summary>
    ''' Valor total do COFINS
    ''' </summary>
    Public Property vCOFINS() As String

    ''' <summary>
    ''' Outras Despesas acessórias
    ''' </summary>

    Public Property vOutro() As String

    ''' <summary>
    ''' Valor total da NFE
    ''' </summary>
    Public Property vNF() As Double

    ''' <summary>
    ''' Valor aproximado do total dos tributos federais, estaduais e municipais
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property vTotTrib As Double

End Class