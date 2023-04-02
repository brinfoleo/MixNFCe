Public Class detEvento
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property descEvento() As String
    ' Cancelamento
    Public Property nProt() As String
    Public Property xJust() As String
    ' Carta de correção
    Public Property xCorrecao() As String
    Public Property xCondUso() As String
End Class
