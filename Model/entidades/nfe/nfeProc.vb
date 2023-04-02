<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="nfeProc", DataType:="string")>
Public Class nfeProc
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property NFe() As New NFe
    Public Property protNFe() As New protNFe
End Class
