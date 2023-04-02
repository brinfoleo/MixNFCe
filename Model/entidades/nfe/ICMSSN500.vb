Public Class ICMSSN500
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
    ''' CSOSN=500
    ''' </summary>
    Public Property CSOSN() As String

    ''' <summary>
    ''' Valor da BC do ICMS ST retido
    ''' </summary>
    Public Property vBCSTRet() As String

    ''' <summary>
    ''' Valor do ICMS ST retido
    ''' </summary>
    Public Property vICMSSTRet() As String
End Class
