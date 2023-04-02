﻿<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="retConsSitNFe", DataType:="string")>
Public Class retConsSitNFe
    <Xml.Serialization.XmlAttribute()>
    Public Property versao() As String

    Public Property tpAmb() As String
    Public Property verAplic() As String
    Public Property cStat() As String
    Public Property xMotivo() As String
    Public Property cUF() As String
    Public Property dhRecbto As String
    Public Property chNFe() As String

    <Xml.Serialization.XmlElement("")>
    Public Property protNFe() As New List(Of protNFe)

    <Xml.Serialization.XmlElement("")>
    Public Property procEventoNFe() As New List(Of procEvento)
End Class