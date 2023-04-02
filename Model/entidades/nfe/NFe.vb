<Xml.Serialization.XmlRoot(Namespace:="http://www.portalfiscal.inf.br/nfe", ElementName:="NFe", DataType:="string")>
Public Class NFe
    Public Property infNFe() As New infNFe
    Public Property protNFe() As New protNFe

    '<Xml.Serialization.XmlElement(Namespace:="http://www.w3.org/2000/09/xmldsig#")>
    'Public Property Signature() As New Signature

    Function itens() As Object
        Throw New NotImplementedException
    End Function

End Class
