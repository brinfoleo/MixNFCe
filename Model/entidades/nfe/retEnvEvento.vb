<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="retEnvEvento", DataType:="string")>
Public Class retEnvEvento
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property idLote() As String
    Public Property tpAmb() As String
    Public Property verAplic() As String
    Public Property cOrgao() As String
    Public Property cStat() As String
    Public Property xMotivo() As String

    <Xml.Serialization.XmlElement("")>
    Public Property retEvento() As New List(Of retEvento)
End Class
