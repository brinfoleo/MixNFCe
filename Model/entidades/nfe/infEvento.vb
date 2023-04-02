Public Class infEvento
    <Xml.Serialization.XmlAttribute()>
    Public Property Id() As String

    Public Property cOrgao() As String
    Public Property tpAmb() As String
    Public Property CNPJ() As String
    Public Property CPF() As String
    Public Property chNFe() As String
    Public Property dhEvento() As String
    Public Property tpEvento() As String
    Public Property nSeqEvento() As String
    Public Property verEvento() As String
    Public Property detEvento() As New detEvento
End Class
