''' <summary>
''' Grupo com as informações das NF referenciadas Idem a informação da TAG anterior, referenciando
''' uma Nota Fiscal modelo 1/1A normal (a NF referenciada não é uma NF-e).
''' </summary>
Public Class refNF
    ''' <summary>
    ''' Utilizar a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País)
    ''' </summary>
    Public Property cUF() As String

    ''' <summary>
    ''' AAMM da emissão da NF
    ''' </summary>
    Public Property AAMM() As String

    ''' <summary>
    ''' Informar o CNPJ do emitente da NF
    ''' </summary>
    Public Property CNPJ() As String

    ''' <summary>
    ''' Informar o código do modelo do Documento fiscal: 01 – modelo 01
    ''' </summary>
    Public Property [mod]() As String

    ''' <summary>
    ''' Informar a série do documento fiscal (informar zero se inexistente).
    ''' </summary>
    Public Property serie() As String

    ''' <summary>
    ''' 1 – 999999999
    ''' </summary>
    Public Property nNF() As String
End Class
