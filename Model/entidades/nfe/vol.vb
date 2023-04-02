''' <summary>
''' TAG de grupo Volumes
''' </summary>
Public Class vol
    ''' <summary>
    ''' Quantidade de volumes transportados
    ''' </summary>
    Public Property qVol() As String

    ''' <summary>
    ''' Espécie dos volumes transportados
    ''' </summary>
    Public Property esp() As String

    ''' <summary>
    ''' Marca dos volumes transportados
    ''' </summary>
    Public Property marca() As String

    ''' <summary>
    ''' Numeração dos volumes transportados
    ''' </summary>
    Public Property nVol() As String

    ''' <summary>
    ''' Peso Líquido (em kg)
    ''' </summary>
    Public Property pesoL() As String

    ''' <summary>
    ''' Peso Bruto (em kg)
    ''' </summary>
    Public Property pesoB() As String

    ''' <summary>
    ''' lacres
    ''' </summary>
    <Xml.Serialization.XmlElement("")>
    Public Property lacres() As New List(Of lacres)
End Class