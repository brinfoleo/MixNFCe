
''' <summary>
''' Grupo com as informações das NF/NF-e referenciadas
''' Utilizar esta TAG para referenciar uma Nota Fiscal Eletrônica emitida
''' anteriormente, vinculada a NF-e atual.
''' Esta informação será utilizada nas hipóteses previstas na legislação.
''' (Ex.: Devolução de Mercadorias, Substituição de NF cancelada, Complementação de NF, etc.).
''' </summary>
Public Class NFref
    Public Property refNFe() As String
    Public Property refNF() As refNF
    'Public Property refNFP() As refNFP
    Public Property refECF() As refECF
End Class
