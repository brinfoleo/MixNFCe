Public Class infNFe
    <Xml.Serialization.XmlAttribute()>
    Public Property Id() As String

    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property ide() As New ide
    Public Property emit() As New emit
    Public Property avulsa() As avulsa
    Public Property dest() As dest
    Public Property retirada() As retirada
    Public Property entrega() As entrega


    <Xml.Serialization.XmlElement("")>
    Public Property det() As New List(Of det)

    <Xml.Serialization.XmlElement("")>
    Public Property pag() As New List(Of pag)


    Public Property total() As total
    Public Property transp() As transp
    Public Property cobr() As cobr

    Public Property infAdic() As infAdic



End Class

