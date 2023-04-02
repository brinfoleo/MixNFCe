<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="enviNFe", DataType:="string")>
Public Class enviNFe
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property idLote() As String

    <Xml.Serialization.XmlElement("")>
    Public Property NFe() As New List(Of NFe)
End Class
