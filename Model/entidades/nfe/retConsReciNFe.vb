﻿<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="retConsReciNFe", DataType:="string")>
Public Class retConsReciNFe
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property tpAmb() As String
    Public Property verAplic() As String
    Public Property nRec As String
    Public Property cStat() As String
    Public Property xMotivo() As String
    Public Property cUF() As String
    Public Property cMsg() As String
    Public Property xMsg() As String

    <Xml.Serialization.XmlElement("")>
    Public Property protNFe() As New List(Of protNFe)
End Class
