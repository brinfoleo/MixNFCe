''' <summary>
''' Grupo com as informações do emitente da NF-e
''' </summary>
Public Class emit
    ''' <summary>
    ''' Informar o CNPJ do emitente. Em se tratando de emissão de NF-e avulsa pelo Fisco, as informações
    ''' do remente serão informadas neste grupo. O CNPJ ou CPF deverão ser informados com os zeros não
    ''' significativos.
    ''' </summary>
    Public Property CNPJ() As String

    ''' <summary>
    ''' Informar o CNPJ do emitente. Em se tratando de emissão de NF-e avulsa pelo Fisco, as informações
    ''' do remente serão informadas neste grupo. O CNPJ ou CPF deverão ser informados com os zeros não
    ''' significativos.
    ''' </summary>
    Public Property CPF() As String

    ''' <summary>
    ''' Razão social ou nome do emitente
    ''' </summary>
    Public Property xNome() As String

    ''' <summary>
    ''' Nome fantasia
    ''' </summary>
    Public Property xFant() As String

    ''' <summary>
    ''' TAG de grupo do Endereço do emitente
    ''' </summary>
    Public Property enderEmit() As New enderEmit

    ''' <summary>
    ''' Campo de informação obrigatória nos casos de emissão própria (procEmi = 0, 2 ou 3).
    ''' A IE deve ser informada apenas com algarismos para destinatários contribuintes do ICMS, sem
    ''' caracteres de formatação (ponto,barra, hífen, etc.);
    ''' O literal “ISENTO” deve ser informado apenas para contribuintes do ICMS que são isentos de inscrição no cadastro de
    ''' contribuintes do ICMS e estejam emitindo NF-e avulsa;
    ''' </summary>
    Public Property IE() As String

    ''' <summary>
    ''' Informar a IE do ST da UF de destino da mercadoria, quando houver a retenção do ICMS ST para a UF de destino.
    ''' </summary>
    Public Property IEST() As String

    ''' <summary>
    ''' Este campo deve ser informado, quando ocorrer a emissão de NF-e conjugada, com prestação de
    ''' serviços sujeitos ao ISSQN e fornecimento de peças sujeitos ao ICMS.
    ''' </summary>
    Public Property IM() As String

    ''' <summary>
    ''' Este campo deve ser informado quando o campo IM (C19) for informado.
    ''' </summary>
    Public Property CNAE() As String

    ''' <summary>
    '''Este campo será obrigatoriamente preenchidocom:
    '''1 – Simples Nacional;
    '''2 – Simples Nacional – excesso
    '''de sublimite de receita bruta;
    '''3 – Regime Normal. (v2.0).
    ''' </summary>
    Public Property CRT() As String
End Class