''' <summary>
''' TAG de grupo de retenções de tributos
'''
''' Exemplos de atos normativos que definem obrigatoriedade da retenção de contribuições:
''' a) IRPJ/CSLL/PIS/COFINS - Fonte - Recebimentos de Órgãos Públicos Federais
''' Lei nº 9.430, de 27 de dezembro de 1996, art. 64 Lei nº 10.833/2003, art. 34
''' como normas infra-legais, temos como exemplo:
''' Instrução Normativa SRF nº 480/2004 e Instrução Normativa nº 539, de 25/04/2005.
''' b) Retenção do Imposto de Renda pelas Fontes Pagadoras REMUNERAÇÃO DE SERVIÇOS
''' PROFISSIONAIS PRESTADOS POR PESSOA JURÍDICA LEI Nº 7.450/85, ART. 52
''' c) IRPJ, CSLL, COFINS e PIS - Serviços Prestados por Pessoas Jurídicas - Retenção na Fonte
''' Lei nº 10.833 de 29.12.2003, arts. 30, 31, 32, 35 e 36
''' </summary>
Public Class retTrib
    ''' <summary>
    ''' Valor Retido de PIS
    ''' </summary>
    Public Property vRetPIS() As String

    ''' <summary>
    ''' Valor Retido de COFINS
    ''' </summary>
    Public Property vRetCOFINS() As String

    ''' <summary>
    ''' Valor Retido de CSLL
    ''' </summary>
    Public Property vRetCSSL() As String

    ''' <summary>
    ''' Base de Cálculo do IRRF
    ''' </summary>
    Public Property vBCIRRF() As String

    ''' <summary>
    ''' Valor Retido do IRRF
    ''' </summary>
    Public Property vIRRF() As String

    ''' <summary>
    ''' Base de Cálculo da Retenção da Previdência Social
    ''' </summary>
    Public Property vBCRetPrev() As String

    ''' <summary>
    ''' Valor da Retenção da Previdência Social
    ''' </summary>
    Public Property vRetPrev() As String
End Class