Public Class SignedInfo
    <Xml.Serialization.XmlAttribute()>
    Public Property Id() As String

    Public Property CanonicalizationMethod() As New CanonicalizationMethod
    Public Property SignatureMethod() As New SignatureMethod
    Public Property Reference() As Reference
End Class

