''' <summary>
''' TAG de grupo de Cobrança
''' </summary>
Public Class cobr
    ''' <summary>
    ''' Tag de grupo Fatura
    ''' </summary>
    Public Property fat() As New fat

    ''' <summary>
    ''' TAG de grupo Duplicata
    ''' </summary>
    '''
    <Xml.Serialization.XmlElement("")>
    Public Property dup() As New List(Of dup)
End Class