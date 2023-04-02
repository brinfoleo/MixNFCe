''' <summary>
''' Tag da Declaração de Importação
''' </summary>
Public Class DI
    ''' <summary>
    ''' Número do Documento de Importação DI/DSI/DA (DI/DSI/DA)
    ''' </summary>
    Public Property nDI() As String

    ''' <summary>
    ''' Data de Registro da DI/DSI/DA
    ''' Formato “AAAA-MM-DD”
    ''' </summary>
    Public Property dDI() As String

    ''' <summary>
    ''' Local de desembaraço
    ''' </summary>
    Public Property xLocDesemb() As String

    ''' <summary>
    ''' Sigla da UF onde ocorreu o Desembaraço Aduaneiro
    ''' </summary>
    Public Property UFDesemb() As String

    ''' <summary>
    ''' Data do Desembaraço Aduaneiro
    ''' </summary>
    Public Property dDesemb() As String

    ''' <summary>
    ''' Código do exportador, usado nos sistemas internos de informação do emitente da NF-e
    ''' </summary>
    Public Property cExportador() As String

    ''' <summary>
    ''' Adições
    ''' </summary>
    <Xml.Serialization.XmlElement("")>
    Public Property adi() As New List(Of adi)
End Class