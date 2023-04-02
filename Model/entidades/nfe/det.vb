''' <summary>
''' H01
''' </summary>
Public Class det
    <Xml.Serialization.XmlAttribute()>
    Public Property nItem() As String
    Public Property prod() As New prod
    Public Property imposto() As New imposto

    ''' <summary>
    ''' Informações adicionais do produto
    ''' Norma referenciada, informações complementares, etc...
    ''' </summary>
    Public Property infAdProd() As String
End Class