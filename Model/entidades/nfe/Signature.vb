Public Class Signature
    <Xml.Serialization.XmlAttribute()>
    Public Property Id() As String

    Public Property SignedInfo() As New SignedInfo
    Public Property SignatureValue() As String
    Public Property KeyInfo() As KeyInfo
End Class

