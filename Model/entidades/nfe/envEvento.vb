<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="envEvento", DataType:="string")>
Public Class envEvento
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property idLote() As String

    <Xml.Serialization.XmlElement()>
    Public Property evento() As New List(Of evento)
End Class
