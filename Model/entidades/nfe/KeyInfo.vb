Public Class KeyInfo
    <Xml.Serialization.XmlAttribute()>
    Public Property Id() As String

    Public Property X509Data() As New X509Data
End Class

