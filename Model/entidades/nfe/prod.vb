''' <summary>
''' TAG de grupo do detalhamento de Produtos e Serviços da NF-e
''' </summary>
''' 

Public Class prod
    ''' <summary>
    ''' Código de produto ou serviço
    ''' Preencher com CFOP, caso se trate de itens não relacionados com mercadorias/produto e que o
    ''' contribuinte não possua codificação própria.
    ''' Formato ”CFOP9999”
    ''' </summary>
    Public Property cProd() As String

    ''' <summary>
    ''' GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
    '''
    ''' Preencher com o código GTIN-8, GTIN-12, GTIN-13 ou GTIN-14
    ''' (antigos códigos EAN, UPC e DUN-14), não informar o conteúdo da TAG em caso de o produto não
    ''' possuir este código.
    ''' </summary>
    Public Property cEAN() As String

    ''' <summary>
    ''' Descrição do produto ou serviço
    ''' </summary>
    Public Property xProd() As String

    ''' <summary>
    ''' Preencher de acordo com a Tabela de Capítulos da NCM. Em caso deserviço, não incluir a TAG.
    ''' </summary>
    Public Property NCM() As String

    ''' <summary>
    ''' Preencher de acordo com o código EX da TIPI. Em caso de serviço,não incluir a TAG
    ''' </summary>
    Public Property EXTIPI() As String

    ''' <summary>
    ''' Gênero do produto ou serviço. Preencher de acordo com a Tabela de Capítulos da NCM. Em caso de serviço, não incluir a TAG.
    ''' </summary>
    Public Property genero() As String

    ''' <summary>
    ''' Utilizar Tabela de CFOP.
    ''' </summary>
    Public Property CFOP() As String

    ''' <summary>
    ''' Informar a unidade de comercialização do produto.
    ''' </summary>
    Public Property uCom() As String

    ''' <summary>
    ''' Informar a quantidade de comercialização do produto
    ''' </summary>
    Public Property qCom() As Double 'String

    ''' <summary>
    ''' Informar o valor unitário de comercialização do produto
    ''' </summary>
    Public Property vUnCom() As Double 'String

    ''' <summary>
    ''' Valor Total Bruto dos Produtos ou Serviços
    ''' </summary>
    Public Property vProd() As Double 'As String

    ''' <summary>
    ''' GTIN (Global Trade Item Number) da unidade tributável,antigo código EAN ou código de barras
    '''
    ''' Preencher com o código GTIN-8, GTIN-12, GTIN-13 ou GTIN-14 (antigos códigos EAN, UPC e DUN-14) da unidade tributável do
    ''' produto, não informar o conteúdo da TAG em caso de o produto não possuir este código.
    ''' </summary>
    Public Property cEANTrib() As String

    ''' <summary>
    ''' Unidade Tributável
    ''' </summary>
    Public Property uTrib() As String

    ''' <summary>
    ''' Quantidade Tributável
    ''' </summary>
    Public Property qTrib() As Double 'String

    ''' <summary>
    ''' Valor Unitário de tributação
    '''
    ''' Informar o valor unitário de tributação do produto
    ''' </summary>
    Public Property vUnTrib() As Double 'String

    ''' <summary>
    ''' Valor total do frete
    ''' </summary>
    ''' 
    Public Property vFrete() As String

    ''' <summary>
    ''' Valor total do seguro
    ''' </summary>
    ''' 
    Public Property vSeg() As String

    ''' <summary>
    ''' Valor do desconto
    ''' </summary>
    Public Property vDesc() As String

    ''' <summary>
    ''' Valor outros V2.0
    ''' </summary>
    Public Property vOutro() As String

    ''' <summary>
    ''' Este campo deverá ser preenchido com:
    '''0 – o valor do item (vProd) não compõe o valor total da NF-e (vProd)
    '''1 – o valor do item (vProd) compõe o valor total da NF-e (vProd) (v2.0)
    ''' </summary>
    Public Property indTot() As String



    Public Property DI() As DI
    Public Property veicProd() As veicProd

    <Xml.Serialization.XmlElement("")>
    Public Property med() As New List(Of med)

    Public Property arma() As arma
    Public Property comb() As comb
End Class