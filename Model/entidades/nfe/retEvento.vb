<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="retEvento", DataType:="string")>
Public Class retEvento
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    '<Xml.Serialization.XmlElement("infEvento")>
    Public Property infEvento As New infEvento2
    Public Property Signature() As New Signature
End Class
