Public Class ide
    ''' <summary>
    ''' Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE de código de unidades da
    ''' federação (Anexo IV - Tabela de UF, Município e País)
    ''' </summary>
    Public Property cUF() As String

    ''' <summary>
    ''' Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para
    ''' cada NF-e para evitar acessos indevidos da NF-e.
    ''' </summary>
    Public Property cNF() As String

    ''' <summary>
    ''' Informar a natureza da operação de que decorrer a saída ou a entrada, tais como: venda, compra,
    ''' transferência, devolução, importação, consignação, remessa (para fins de demonstração, de
    ''' industrialização ou outra), conforme previsto na alínea 'i', inciso I, art. 19
    ''' do CONVÊNIO S/Nº, de 15 de dezembro de 1970
    ''' </summary>
    Public Property natOp() As String

    ''' <summary>
    ''' 0 – pagamento à vista;
    ''' 1 – pagamento à prazo;
    ''' 2 - outros.
    ''' </summary>
    Public Property indPag() As String

    ''' <summary>
    ''' Utilizar o código 55 para identificação da NF-e, emitida em substituição ao modelo 1 ou 1A.
    ''' </summary>
    Public Property [mod]() As String

    ''' <summary>
    ''' Série do Documento Fiscal, informar 0 (zero) para série única.
    ''' </summary>
    Public Property serie() As String

    ''' <summary>
    ''' Número do Documento Fiscal.
    ''' </summary>
    Public Property nNF() As String

    ''' <summary>
    ''' Data de emissão do documento fiscal, Formato “AAAA-MM-DD”
    ''' </summary>
    Public Property dhEmi() As String

    ''' <summary>
    ''' Data de saída ou da entrada da mercadoria/produto, Formato “AAAA-MM-DD”
    ''' </summary>
    Public Property dSaiEnt() As String

    ''' <summary>
    ''' Hora de Saída ou da Entrada da Mercadoria/Produto Formato “HH:MM:SS” (v.2.0)
    ''' </summary>
    ''' 
    Public Property hSaiEnt() As String

    ''' <summary>
    ''' 0-entrada / 1-saída
    ''' </summary>
    Public Property tpNF() As String


    ''' <summary>
    ''' Identificador do Destinatario
    ''' 0 - Operacao interna
    ''' 1 - Operacao interestadual
    ''' 2 - Operacao com exterior
    ''' </summary>
    ''' <remarks></remarks>
    Public Property idDest As String

    ''' <summary>
    ''' Informar o município de ocorrência do fato gerador do ICMS. Utilizar a
    ''' Tabela do IBGE (Anexo IV - Tabela de UF, Município e País).
    ''' </summary>
    Public Property cMunFG() As String

    ''' <summary>
    ''' TAG Notas fiscais referenciadas.
    ''' </summary>
    ''' 
    <Xml.Serialization.XmlElement("")>
    Public Property NFRef() As New List(Of NFref)

    ''' <summary>
    ''' Formato do DANFe
    ''' 
    ''' 0=Sem geração de DANFE;
    ''' 1=DANFE normal, Retrato;
    ''' 2=DANFE normal, Paisagem;
    ''' 3=DANFE Simplificado;
    ''' 4=DANFE NFC-e;
    ''' 5=DANFE NFC-e em mensagem eletrônica.
    ''' </summary>
    Public Property tpImp() As String

    ''' <summary>
    ''' 1 – Normal – emissão normal;
    ''' 2 – Contingência FS – emissão em contingência com impressão do DANFE em Formulário de Segurança;
    ''' 3 – Contingência SCAN – emissão em contingência no Sistema de Contingência do Ambiente Nacional – SCAN;
    ''' 4 – Contingência DPEC - emissão em contingência com envio da Declaração Prévia de Emissão em Contingência – DPEC;
    ''' 5 – Contingência FS-DA - emissão em contingência com impressão do DANFE em Formulário de Segurança para Impressão de
    ''' Documento Auxiliar de Documento Fiscal Eletrônico (FS-DA).
    ''' </summary>
    Public Property tpEmis() As String

    ''' <summary>
    ''' Informar o DV da Chave de Acesso da NF-e, o DV será calculado com a aplicação do algoritmo módulo 11
    ''' (base 2,9) da Chave de Acesso. (vide item 5 do Manual de Integração)
    ''' </summary>
    Public Property cDV() As String

    ''' <summary>
    ''' 1-Produção/ 2-Homologação
    ''' </summary>
    Public Property tpAmb() As String

    ''' <summary>
    ''' 1- NF-e normal/ 2-NF-e complementar / 3 – NF-e de ajuste
    ''' </summary>
    Public Property finNFe() As String



    ''' <summary>
    ''' 0 - Normal/ 1 - consumidor Final
    ''' </summary>
    Public Property indFinal() As String
    
    ''' <summary>
    ''' 0 - Nao se aplica (NF complementar / ajuste)
    ''' 1 - Operacao presencial
    ''' 2 - Operacao nao presencial, pela internet
    ''' 3 - Operacao nao presencial, teleatendimento
    ''' 4 - NFC-e em operacao com entrega a domicilio
    ''' 9 - Operacao nao presencial, outros
    ''' </summary>
    Public Property indPres() As String

    ''' <summary>
    ''' Identificador do processo de emissão da NF-e: 0 - emissão de NF-e com aplicativo do contribuinte;
    ''' 1 - emissão de NF-e avulsa pelo Fisco;
    ''' 2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco;
    ''' 3- emissão NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.
    ''' </summary>
    Public Property procEmi() As String




    ''' <summary>
    ''' Identificador da versão do processo de emissão (informar a versão do aplicativo emissor de NF-e).
    ''' </summary>
    Public Property verProc() As String


    ''' <summary>
    ''' Data e hora de entrada em contigencia.
    ''' </summary>
    Public Property dhCont() As String
    ''' <summary>
    ''' Justificativa da entrada em contigencia.
    ''' </summary>
    Public Property xJust() As String
End Class