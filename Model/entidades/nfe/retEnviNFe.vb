<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="retEnviNFe", DataType:="string")>
Public Class retEnviNFe
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property tpAmb() As String
    Public Property verAplic() As String
    Public Property cStat() As String
    Public Property xMotivo() As String
    Public Property cUF() As String
    Public Property dhRecbto() As String
    Public Property infRec() As New infRec
End Class
