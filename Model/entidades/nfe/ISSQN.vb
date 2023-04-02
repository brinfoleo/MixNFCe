''' <summary>
''' TAG do grupo do ISSQN
''' Informar os campos para cálculo do ISSQN nas NFe conjugadas, onde há a prestação de serviços
''' sujeitos ao ISSQN e fornecimento de peças sujeitas ao ICMS
''' </summary>
Public Class ISSQN
    ''' <summary>
    ''' Valor da Base de Cálculo do ISSQN
    ''' </summary>
    Public Property vBC() As String

    ''' <summary>
    ''' Alíquota do ISSQN
    ''' </summary>
    Public Property vAliq() As String

    ''' <summary>
    ''' Valor do ISSQN
    ''' </summary>
    Public Property vISSQN() As String

    ''' <summary>
    ''' Informar o município de ocorrência do fato gerador do ISSQN. Utilizar
    ''' a Tabela do IBGE (Anexo IV - Tabela de UF, Município e País)
    ''' </summary>
    Public Property cMunFG() As String

    ''' <summary>
    ''' Informar o código da lista de serviços da LC 116/03 em que se
    ''' classifica o serviço.
    ''' </summary>
    Public Property cListServ() As String
End Class