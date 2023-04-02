''' <summary>
''' Grupo com as informações do destinatário da NF-e.
''' </summary>
Public Class dest
    ''' <summary>
    ''' Informar o CNPJ ou o CPF do destinatário, preenchendo os zeros não significativos.
    ''' Não informar o conteúdo da TAG se a operação for realizada com o exterior.
    ''' </summary>
    Public Property CNPJ() As String

    ''' <summary>
    ''' Informar o CNPJ ou o CPF do destinatário, preenchendo os zeros não significativos.
    ''' Não informar o conteúdo da TAG se a operação for realizada com o exterior.
    ''' </summary>
    Public Property CPF() As String

    ''' <summary>
    ''' Razão Social ou nome do destinatário
    ''' </summary>
    Public Property xNome() As String

    ''' <summary>
    ''' Obrigatório, nas operações que se beneficiam de incentivos fiscais existentes nas áreas sob controle
    ''' da SUFRAMA. A omissão da Inscrição SUFRAMA impede o processamento da operação pelo Sistema de
    ''' Mercadoria Nacional da SUFRAMA e a liberação da Declaração de Ingresso, prejudicando a
    ''' comprovação do ingresso/internamento da mercadoria nas áreas sob controle da SUFRAMA.
    ''' </summary>
    Public Property ISUF() As String

    ''' <summary>
    ''' TAG - Endereço do destinatário
    ''' </summary>
    Public Property enderDest() As New enderDest

    ''' <summary>
    ''' TAG - Indicador da IE do Destinatário
    ''' 1=Contribuinte ICMS (informar a IE do destinatário)
    ''' 2=Contribuinte isento de Inscrição no cadastro de Contribuintesdo ICMS;
    ''' 9=Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS.
    ''' Nota 1: No caso de NFC-e informar indIEDest=9 e não informar a tag IE do destinatário;
    ''' Nota 2: No caso de operação com o Exterior informar indIEDest=9 e não informar a tag IE do destinatário;
    ''' Nota 3: No caso de Contribuinte Isento de Inscrição (indIEDest=2), não informar a tag IE do destinatário
    ''' </summary>
    Public Property indIEDest() As String


    ''' <summary>
    ''' Informar a IE quando o destinatário for contribuinto do ICMS. Informar ISENTO quando o
    ''' destinatário for contribuinto do ICMS, mas não estiver obrigado à inscrição no cadastro de
    ''' contribuintes do ICMS. Não informar o conteúdo da TAG se o destinatário não for contribuinte do ICMS.
    ''' Esta tag aceita apenas: . ausência de conteúdo (<IE></IE> ou <IE/>) para destinatários não
    ''' contribuintes do ICMS; . algarismos para destinatários contribuintes do ICMS, sem caracteres de formatação (ponto,
    ''' barra, hífen, etc.); . literal “ISENTO” para destinatários contribuintes do ICMS que são isentos de inscrição no cadastro de
    ''' contribuintes do ICMS;
    ''' </summary>
    Public Property IE() As String

    ''' <summary>
    ''' Preencher com Email do Destinatário.
    ''' </summary>
    Public Property email() As String
End Class