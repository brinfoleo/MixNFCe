Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Globalization
''' <summary>
''' Classe que gera a NFCe
''' </summary>
''' 
Public Class GeraXML
    Private nfce As NFCe
   

    Public Sub executar(ByVal cpNFCe As NFCe)

        'pega a instancia da nfce
        nfce = cpNFCe
        nfce.infNFE.ide.dhEmi = Format(Now, "yyyy-MM-ddTHH:mm:ss") & "-03:00"
        gerarChaveAcesso()

        gerarXMLArquivo()
        gravarNFCeBaseDeDados()


    End Sub
    Private Sub gravarNFCeBaseDeDados()
        'Salva a NFCe na base de dados
        Dim n As New NFeDAO
        n.salvar(nfce)
    End Sub
    Private Sub gerarChaveAcesso()
        'Funcao responsavel por gerar a chave de acesso e outros componentes da chave

        Dim cNF As String
        'cNF = Right(strPDV, 2) & FormatDateTime(DateTime.Now, DateFormat.LongTime).Replace(":", "")
        cNF = Right(strPDV, 2) & Format(DateTime.Now, "HHmmss")
        cNF = cNF.PadLeft(8, "0")


        nfce.infNFE.Ide.cNF = cNF
        

        'Pega ultima nNF e acrescenta +1
        Dim NFeDAO As New NFeDAO
        Dim ultnNF As Integer
        Dim nNF As String

        ultnNF = NFeDAO.ultimanNF(nfce.versao, nfce.infNFE.Ide.[mod], nfce.infNFE.Ide.serie, strAmbiente)
        nNF = ultnNF + 1

        nfce.infNFE.ide.nNF = nNF


        'CHAVE DE ACESSO
        Dim _codUF As String = nfce.infNFE.Ide.cUF.ToString()
        Dim _dEmi As String = Format(Today, "yyMM") 'nfce.infNFE.Ide.dhEmi.ToString("yyMM")
        Dim _cnpj As String = Funcoes.removeFormatacao(nfce.infNFE.Emit.CNPJ)
        Dim _mod As String = IIf(nfce.infNFE.ide.[mod] = "P", "00", nfce.infNFE.ide.[mod])
        Dim _tpEmis As String = nfce.infNFE.ide.tpEmis

        Dim _serie As String = String.Format("{0:000}", Int32.Parse(nfce.infNFE.Ide.serie))
        Dim _numNF As String = String.Format("{0:000000000}", Int32.Parse(nfce.infNFE.Ide.nNF))
        Dim _codigo As String = String.Format("{0:00000000}", Int32.Parse(nfce.infNFE.ide.cNF))
        Dim chaveNF As String = _codUF + _dEmi + _cnpj + _mod + _serie + _numNF + _tpEmis + _codigo
        Dim _dv As Integer = Funcoes.modulo11(chaveNF)

        nfce.Id = chaveNF + _dv.ToString()
        nfce.infNFE.Ide.cDV = _dv.ToString()
    End Sub
    Private Sub gerarXMLArquivo()
        'Transforma a intancia da NFCe em Arquivo XML
        Dim xmlGerado As XmlDocument = GerarXML()
        'Salva uma copia do XML não assinado 
        xmlGerado.Save(Application.StartupPath & "\xml\" & nfce.Id & "-nfe.xml")

    End Sub
   

    'FUNÇÃO QUE POR RECURSIVIDADE PREENCHE ESCREVE OS DADOS DO XML
    Private Sub objetoParaXML(ByVal xmlWriter As XmlWriter, ByVal objeto As Object, ByVal ignorarDeclaracaoElemento As Boolean)
        If objeto Is Nothing Then
            Exit Sub
        End If

        Dim tipoObjeto As Type
        tipoObjeto = objeto.[GetType]()
        Dim propriedades As PropertyInfo()
        propriedades = tipoObjeto.GetProperties()

        'VERIFICA SE É UM CAMPO DO TIPO LIST
        'SE FOR ADICIONA NOVO ELEMENTE
        If Not ignorarDeclaracaoElemento And tipoObjeto.Name <> "List`1" Then
            xmlWriter.WriteStartElement(tipoObjeto.Name)
        End If

        'SE FORM UMA LISTA CHAMA FUNÇÃO NOVAMENTE PARA PREENCHER ELEMENTOS DA LISTA
        If tipoObjeto.Name = "List`1" Then
            If objeto.ToString.Contains("dup") Then
                For Each Ddup As dup In objeto
                    objetoParaXML(xmlWriter, Ddup, False)
                    Continue For
                Next
                'Else
                'For Each Dmed As med In objeto
                'objetoParaXML(xmlWriter, Dmed, False)
                'Continue For
                'Next
            End If
            Exit Sub
        End If

        'VERIFICA CAMPOS E ADICIONA TAGS E ELEMENTOS XML
        For Each propriedade As PropertyInfo In propriedades

            If Funcoes.novaTag(propriedade) AndAlso Not (propriedade.GetValue(objeto, Nothing) Is Nothing) Then
                objetoParaXML(xmlWriter, propriedade.GetValue(objeto, Nothing), False)
                Continue For
            End If

            Dim obj As Object() = propriedade.GetCustomAttributes(False)
            Funcoes.gravarElemento(xmlWriter, propriedade.Name, propriedade.GetValue(objeto, Nothing), obj)
        Next
        If Not ignorarDeclaracaoElemento Then
            xmlWriter.WriteEndElement()
        End If
    End Sub

    Private Function GerarXML() As XmlDocument
        Dim configXML As New XmlWriterSettings()
        configXML.Indent = True
        configXML.IndentChars = ""
        configXML.NewLineOnAttributes = False
        configXML.OmitXmlDeclaration = False

        Dim xmlSaida As Stream = New MemoryStream()

        Dim oXmlGravar As XmlWriter = XmlWriter.Create(xmlSaida, configXML)

        oXmlGravar.WriteStartDocument()
        oXmlGravar.WriteStartElement("NFe", "http://www.portalfiscal.inf.br/nfe")
        'abre nfe
        oXmlGravar.WriteStartElement("infNFe")
        'oXmlGravar.WriteAttributeString("xmlns", "xsi", Nothing, "http://www.w3.org/2001/XMLSchema-instance")
        oXmlGravar.WriteAttributeString("Id", "NFe" & nfce.Id.ToString())
        oXmlGravar.WriteAttributeString("versao", nfce.versao.ToString())

        Dim tipoObjeto As Type
        tipoObjeto = nfce.infNFE.Ide.[GetType]()
        Dim propriedades As PropertyInfo()
        propriedades = tipoObjeto.GetProperties()

        objetoParaXML(oXmlGravar, nfce.infNFE.Ide, False)
        objetoParaXML(oXmlGravar, nfce.infNFE.Emit, False)
        objetoParaXML(oXmlGravar, nfce.infNFE.Dest, False)


        For Each detalhe As det In nfce.infNFE.Det
            oXmlGravar.WriteStartElement("det")
            oXmlGravar.WriteAttributeString("nItem", detalhe.nItem.ToString())

            objetoParaXML(oXmlGravar, detalhe.Prod, False)

            oXmlGravar.WriteStartElement("imposto")
            objetoParaXML(oXmlGravar, detalhe.Imposto.Icms, False)
            'objetoParaXML(oXmlGravar, detalhe.Imposto.Ii, False)
            'objetoParaXML(oXmlGravar, detalhe.Imposto.Ipi, False)
            objetoParaXML(oXmlGravar, detalhe.Imposto.Pis, False)
            objetoParaXML(oXmlGravar, detalhe.Imposto.Cofins, False)

            'fecha TAG imposto...
            oXmlGravar.WriteEndElement()

            'fecha TAG det...
            oXmlGravar.WriteEndElement()
        Next

        objetoParaXML(oXmlGravar, nfce.infNFE.Total, False)
        objetoParaXML(oXmlGravar, nfce.infNFE.Transp, False)
        objetoParaXML(oXmlGravar, nfce.infNFE.Cobr, False)

        If nfce.infNFE.Cobr IsNot Nothing Then
            oXmlGravar.WriteStartElement("cobr")
            For Each duplicata As dup In nfce.infNFE.Cobr.Dup
                objetoParaXML(oXmlGravar, duplicata, False)
            Next

            'fecha tag cobr
            oXmlGravar.WriteEndElement()
        End If


        If nfce.infNFE.pag IsNot Nothing Then
            'oXmlGravar.WriteStartElement("pag")

            For Each pag As Pag In nfce.infNFE.pag
                objetoParaXML(oXmlGravar, pag, False)
            Next
            'fecha tag pag
            'oXmlGravar.WriteEndElement()
        End If

        objetoParaXML(oXmlGravar, nfce.infNFE.InfAdic, False)

        oXmlGravar.WriteEndElement()
        'fecha infNFe
        oXmlGravar.WriteEndElement()
        'fecha NFe
        oXmlGravar.Flush()
        xmlSaida.Flush()
        xmlSaida.Position = 0

        Dim documento As New XmlDocument()
        documento.Load(xmlSaida)

        'documento.Save("c:\\testeXML.xml");

        oXmlGravar.Close()

        Return documento
    End Function

    Public Function GerarXMLCancelamento(ByVal nt As NFCe) As String 'As XmlDocument
        '28/08/2015 - Leo
        ' Nao funcionou pois na tag evento nao conseguiu add os dados do www e a versao
        'Dim ee As New envEvento
        'Dim env As New evento
        'Dim idLote As String = "1"
        'Dim nSeqEvento As String = "1"
        'ee.versao = "1.00"
        'ee.IdLote = idLote.ToString.PadLeft(15, "0")

        'env.infEvento.Id = "ID" & "110111" & nt.Id & nSeqEvento.ToString.PadLeft(2, "0")
        'env.infEvento.cOrgao = nt.infNFE.ide.cUF
        'env.infEvento.tpAmb = nt.infNFE.ide.tpAmb
        'env.infEvento.CNPJ = nt.infNFE.emit.CNPJ
        'env.infEvento.chNFe = nt.Id
        'env.infEvento.dhEvento = Format(Now, "yyyy-MM-ddTHH:mm:ss") & "-03:00"
        'env.infEvento.tpEvento = "110111"
        'env.infEvento.nSeqEvento = nSeqEvento
        'env.infEvento.verEvento = ee.versao
        ''HP17 env.infEvento.detEvento.
        'env.infEvento.detEvento.versao = ee.versao
        'env.infEvento.detEvento.descEvento = "Cancelamento"
        'env.infEvento.detEvento.nProt = nt.nProt
        'env.infEvento.detEvento.xJust = nt.xJust
        'ee.evento.Add(env)
        'Dim doc As New XmlDocument
        'doc = Serializar(ee)
        'doc.Save(Application.StartupPath & "\xml\" & nt.Id & "-env-canc.xml")
        'Return nt.Id & "-env-canc.xml"


        Dim configXML As New XmlWriterSettings()
        configXML.Indent = True
        configXML.IndentChars = ""
        configXML.NewLineOnAttributes = False
        configXML.OmitXmlDeclaration = False

        Dim idLote As String = "1"
        Dim nSeqEvento As String = "1"
        Dim vSchelma As String = "1.00"



        Dim xmlSaida As Stream = New MemoryStream()

        Dim oXmlGravar As XmlWriter = XmlWriter.Create(xmlSaida, configXML)
        'Atribui a variavel global a Nota fical recebida
        nfce = nt

        oXmlGravar.WriteStartDocument()
        oXmlGravar.WriteStartElement("envEvento", "http://www.portalfiscal.inf.br/nfe")
        'oXmlGravar.WriteAttributeString("xmlns", "xsi", Nothing, "http://www.w3.org/2001/XMLSchema-instance")
        oXmlGravar.WriteAttributeString("versao", vSchelma)

        oXmlGravar.WriteElementString("idLote", idLote.ToString.PadLeft(15, "0"))

        'Evento
        oXmlGravar.WriteStartElement("evento", "http://www.portalfiscal.inf.br/nfe")
        oXmlGravar.WriteAttributeString("versao", vSchelma)


        oXmlGravar.WriteStartElement("infEvento")
        oXmlGravar.WriteAttributeString("Id", "ID" & "110111" & nt.Id & nSeqEvento.ToString.PadLeft(2, "0"))

        oXmlGravar.WriteElementString("cOrgao", nt.infNFE.ide.cUF)
        oXmlGravar.WriteElementString("tpAmb", nfce.infNFE.ide.tpAmb.ToString())
        oXmlGravar.WriteElementString("CNPJ", nfce.infNFE.emit.CNPJ)
        oXmlGravar.WriteElementString("chNFe", nfce.Id)
        oXmlGravar.WriteElementString("dhEvento", Format(Now, "yyyy-MM-ddTHH:mm:ss") & "-03:00")
        oXmlGravar.WriteElementString("tpEvento", "110111")
        oXmlGravar.WriteElementString("nSeqEvento", nSeqEvento)
        oXmlGravar.WriteElementString("verEvento", vSchelma)

        ''HP17 env.infEvento.detEvento.

        oXmlGravar.WriteStartElement("detEvento")
        oXmlGravar.WriteAttributeString("versao", vSchelma)


        oXmlGravar.WriteElementString("descEvento", "Cancelamento")
        oXmlGravar.WriteElementString("nProt", nfce.nProt)
        oXmlGravar.WriteElementString("xJust", nfce.xJust)
        oXmlGravar.WriteEndElement()

        oXmlGravar.WriteEndElement()


        oXmlGravar.WriteEndElement()
        'Fecha elemento infCanc
        oXmlGravar.WriteEndElement()
        'Fecha elemento cancNFe
        oXmlGravar.Flush()
        xmlSaida.Flush()
        xmlSaida.Position = 0

        Dim documento As New XmlDocument()
        documento.Load(xmlSaida)
        oXmlGravar.Close()
        documento.Save(Application.StartupPath & "\xml\" & nfce.Id & "-env-canc.xml")
        'Return documento
        Return nfce.Id & "-env-canc.xml"
    End Function

    Public Function GerarXMLInutilizacao(ByVal nt As NFCe) As String 'XmlDocument
        Dim configXML As New XmlWriterSettings()
        configXML.Indent = True
        configXML.IndentChars = ""
        configXML.NewLineOnAttributes = False
        configXML.OmitXmlDeclaration = False

        Dim xmlSaida As Stream = New MemoryStream()

        Dim oXmlGravar As XmlWriter = XmlWriter.Create(xmlSaida, configXML)
        'Atribui a variavel global a nova nfce
        nfce = nt
        oXmlGravar.WriteStartDocument()
        oXmlGravar.WriteStartElement("inutNFe", "http://www.portalfiscal.inf.br/nfe")
        'oXmlGravar.WriteAttributeString("xmlns", "xsi", Nothing, "http://www.w3.org/2001/XMLSchema-instance")
        oXmlGravar.WriteAttributeString("versao", nfce.versao.ToString())
        oXmlGravar.WriteStartElement("infInut")
        Dim chID As String
        'Gera o ID de inutilizacao
        Dim _codUF As String = nfce.infNFE.ide.cUF.ToString()
        Dim _ano As String = nfce.ano.ToString
        Dim _cnpj As String = Funcoes.removeFormatacao(nfce.infNFE.emit.CNPJ)
        Dim _mod As String = nfce.infNFE.ide.[mod]

        Dim _serie As String = String.Format("{0:000}", Int32.Parse(nfce.infNFE.ide.serie))
        Dim _numNFIni As String = String.Format("{0:000000000}", nfce.NumNf_Ini)
        Dim _numNFFin As String = String.Format("{0:000000000}", nfce.NumNf_Fin)

        
        'nfce.Id = _codUF + _cnpj + _mod + _serie + _numNFIni + _numNFFin
        chID = _codUF + _ano + _cnpj + _mod + _serie + _numNFIni + _numNFFin



        oXmlGravar.WriteAttributeString("Id", "ID" & chID)

        oXmlGravar.WriteElementString("tpAmb", nfce.infNFE.ide.tpAmb.ToString())
        oXmlGravar.WriteElementString("xServ", "INUTILIZAR")
        oXmlGravar.WriteElementString("cUF", nfce.infNFE.ide.cUF.ToString())
        oXmlGravar.WriteElementString("ano", nfce.ano)
        oXmlGravar.WriteElementString("CNPJ", nfce.infNFE.emit.CNPJ)
        oXmlGravar.WriteElementString("mod", nfce.infNFE.ide.[mod])
        oXmlGravar.WriteElementString("serie", nfce.infNFE.ide.serie)
        oXmlGravar.WriteElementString("nNFIni", nfce.NumNf_Ini.ToString())
        oXmlGravar.WriteElementString("nNFFin", nfce.NumNf_Fin.ToString())
        oXmlGravar.WriteElementString("xJust", nfce.xJust)

        oXmlGravar.WriteEndElement()
        'Fecha Tag infInut
        oXmlGravar.WriteEndElement()
        'Fecha Tag inutNFe
        oXmlGravar.Flush()
        xmlSaida.Flush()
        xmlSaida.Position = 0

        Dim documento As New XmlDocument()
        documento.Load(xmlSaida)
        oXmlGravar.Close()
        documento.Save(Application.StartupPath & "\xml\" & nfce.Id & "-ped-inu.xml")
        'Return documento
        Return nfce.Id & "-ped-inu.xml"
    End Function
    ''' <summary>
    ''' Gera o XML de para consultar situacao da NFe na SEFAZ
    ''' e retorna o nome do arq xml
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GerarXMLConsultaSit(ByVal nf As NFCe) As String

        Dim consSitNFCe As New consSitNFe
        Dim doc As New XmlDocument

        consSitNFCe.chNFe = nf.Id
        consSitNFCe.tpAmb = nf.infNFE.ide.tpAmb
        consSitNFCe.versao = nf.versao
        consSitNFCe.xServ = "CONSULTAR"
        doc = Serializar(consSitNFCe)

        doc.Save(Application.StartupPath & "\xml\" & nf.Id & "-ped-sit.xml")
        Return nf.Id & "-ped-sit.xml"
    End Function
    Private Function Serializar(ByVal objectToSerialize As Object) As XmlDocument
        Dim serializer As Serialization.XmlSerializer
        Dim ns As New Serialization.XmlSerializerNamespaces
        Dim mStream As Stream = New MemoryStream()
        Dim writer As XmlWriter
        Dim doc As New XmlDocument

        ns.Add("", "http://www.portalfiscal.inf.br/nfe")

        writer = XmlWriter.Create(mStream)
        serializer = New Serialization.XmlSerializer(objectToSerialize.GetType)
        serializer.Serialize(writer, objectToSerialize, ns)
        writer.Flush()
        mStream.Flush()
        mStream.Position = 0

        doc.Load(mStream)
        Return doc
    End Function
End Class