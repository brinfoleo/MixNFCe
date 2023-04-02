Public Class ICMS20
    ''' <summary>
    ''' Origem da mercadoria:
    ''' 0 - Nacional, exceto as indicadas nos Códigos 3 a 5;
    ''' 1 - Estrangeira - Importação Direta, exceto a indicada no Código 6;
    ''' 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no Código 7;
    ''' 3 - Nacional, Mercadoria ou bem com conteúdo de Importação superior a 40% (Quarenta por Cento);
    ''' 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam o Decreto-Lei Nº 288/67, e as Leis Nºs 8.248/91, 8.387/91, 10.176/01 e 11.484/07;
    ''' 5 - Nacional, Mercadoria ou bem com conteúdo de Importação inferior ou igual a 40% (Quarenta por Cento);
    ''' 6 - Estrangeira - Importação Direta, sem similar Nacional, constante em lista de resolução CAMEX e gas natural;
    ''' 7 - Estrangeira - Adquirida no mercado interno, sem similar Nacional, constante em lista de resolução CAMEX e gas natural.
    ''' </summary>
    Public Property orig() As String

    ''' <summary>
    ''' Tributação do ICMS: 20 - Com redução de base de cálculo
    ''' </summary>
    Public Property CST() As String

    ''' <summary>
    ''' 0 - Margem Valor Agregado (%);
    ''' 1 - Pauta (Valor);
    ''' 2 - Preço Tabelado Máx. (valor);
    ''' 3 - valor da operação.
    ''' </summary>
    Public Property modBC() As String

    ''' <summary>
    ''' Percentual da Redução de BC do ICMS
    ''' </summary>
    Public Property pRedBC() As String

    ''' <summary>
    ''' Valor da base de calculo do imposto
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Aliquota do imposto
    ''' </summary>
    Public Property pICMS() As String

    ''' <summary>
    ''' Valor do ICMS
    ''' </summary>
    Public Property vICMS() As String
 End Class
