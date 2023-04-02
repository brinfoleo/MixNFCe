''' <summary>
''' TAG de grupo de Retenção do ICMS do transporte
'''
''' Informar o valor do ICMS do serviço de transporte retido.
''' </summary>
Public Class retTransp
    ''' <summary>
    ''' Valor do Serviço
    ''' </summary>
    Public Property vServ() As String

    ''' <summary>
    ''' BC da Retenção do ICMS
    ''' </summary>
    Public Property vBCRet() As String

    ''' <summary>
    ''' Alíquota da Retenção
    ''' </summary>
    Public Property pICMSRet() As String

    ''' <summary>
    ''' Valor do ICMS Retido
    ''' </summary>
    Public Property vICMSRet() As String

    ''' <summary>
    ''' CFOP
    ''' </summary>
    Public Property CFOP() As String

    ''' <summary>
    ''' Código do município de ocorrência do fato gerador do ICMS do transporte
    '''
    ''' Informar o município de ocorrência do fato gerador do ICMS do transporte.
    ''' Utilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País)
    ''' </summary>
    Public Property cMunFG() As String
End Class