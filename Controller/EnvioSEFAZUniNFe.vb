Imports System.Threading
Imports System.Xml
Imports System.IO
''' <summary>
''' Classe que trata o gerenciamento do xml 
''' para envio a SEFAZ usando o UNINFe
''' </summary>
''' <remarks></remarks>
Public Class EnvioSEFAZUniNFe

    'Chave de Acesso
    Private chNFCe As String
    'Pasta que guarda o retorno do XML autorizado

    Private _pXmlAutorizado As String
    'Pasta de envio do UniNFE
    Private _pXmlEnvio As String
    'Codigo usado para gerar QRCode
    Dim csc As String
    'Armazena o objeto da NFCe caso precise gerar nova NFCe
    Public nfce As NFCe

    'Armazena o numero de tentativas e o tempo entre elas para que o
    'sistema cheque o retorno do UniNFe
    Private _nLoop As Integer
    Private _intervaloLoop As Long

    ' ''' <summary>
    ' ''' Cosntrutor
    ' ''' </summary>
    ' ''' <remarks></remarks>
    Public Sub New()
        'Carrega as variaveis locais
        carregarVariaveis()

    End Sub

    ''' <summary>
    ''' Inicia o processo de rastreamento
    ''' do XML
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub executar(ByVal _nfce As NFCe)
        'Recebe a instancia da nfce
        nfce = _nfce

        'pega a instancia da nfce assim como sua chave de acesso
        chNFCe = nfce.Id

        Dim localXML As String


        'Testa se existe a pasta \XML caso contrario a cria
        If Not System.IO.Directory.Exists(Application.StartupPath & "\xml\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\xml\")
        End If

        If nfce.infNFE.ide.mod = "65" Then
            'Envia o XML para o UniNFe
            Util.moveFile(Application.StartupPath & "\xml", _pXmlEnvio, chNFCe & "-nfe.xml")

            localXML = _pXmlAutorizado & "\20" & Mid(chNFCe, 3, 4) & "\" & chNFCe & "-procNFe.xml"

            Dim status As Integer = 0
            'Inicia o loop de validacao da nfce
            For i = 1 To _nLoop
                status = statusNFCe()
                If status = 0 Then ' 0 - Nenhum arquivo encontrado
                    If i = 3 Then 'Fim do teste e nenhum arquivo encontrado
                        gerarXmlContigencia()
                        chNFCe = nfce.Id
                        'localXML = Application.StartupPath & "\xml\" & chNFCe & "-nfe.xml"
                        Exit For
                    End If
                ElseIf status = 1 Then ' 1 - Autorizada com sucesso
                    carregarXmlAutorizado(localXML)
                    Exit For
                ElseIf status = 2 Then ' 2 - Erro na validacao/envio do XML
                    Exit For
                End If
                Thread.Sleep(_intervaloLoop)
            Next
            'printDanfe(localXML)
        End If
        imprimirDanfe(chNFCe)
    End Sub

    Public Function statusNFCe() As Integer
        'Checa a autorizacao da NFCe
        'sendo:
        ' 0 - Nenhum arquivo encontrado
        ' 1 - Autorizada com sucesso
        ' 2 - Erro na validacao/envio do XML
        Dim flag As Integer


        ' MsgBox(_pXmlAutorizado & "\20" & Mid(chNFCe, 3, 4) & "\" & chNFCe & "-procNFe.xml")
        If System.IO.File.Exists(_pXmlAutorizado & "\20" & Mid(chNFCe, 3, 4) & "\" & chNFCe & "-procNFe.xml") Then
            flag = 1 'Autorizado com sucesso

        ElseIf System.IO.File.Exists(_pXmlAutorizado & "\20" & chNFCe & "*.err") Then
            flag = 2 'Erro na validacao/envio do XML
        Else
            flag = 0 'Nenhum arquivo encontrado
        End If

        Return flag
    End Function

    ''' <summary>
    ''' Gera a NFCe em contigencia off line
    ''' com base em NFCe ja existente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub gerarXmlContigencia()

        nfce.infNFE.ide.tpEmis = "9"
        nfce.infNFE.ide.dhEmi = Format(Now, "yyyy-MM-ddTHH:mm:ss") & "-03:00"
        nfce.infNFE.ide.dhCont = nfce.infNFE.ide.dhEmi
        nfce.infNFE.ide.xJust = "ENTRADA EM CONTIGENCIA DEVIDO NÃO HAVER RETORNO DA NFCe PELA SEFAZ"
        Dim gXML As New GeraXML
        gXML.executar(nfce)
        chNFCe = nfce.Id
        


    End Sub

 

    ''' <summary>
    ''' Imprime o DANFe
    ''' </summary>
    ''' <param name="file_xml"></param>
    ''' <remarks></remarks>
    Private Sub printDanfe(ByVal file_xml As String)
        'Caso a NFCe seja em contigencia devera ser impressa em 2 vias
        ' com os dizeres de NFCe em contigencia


        Dim xml As New ImportXML(file_xml)

        'Imprimindo com a classe DANFe_65
        'Dim danfe As New DANFe_65
        'danfe.preview = False
        'danfe.nfce = xml.importXML
        'danfe.csc = csc
        'danfe.Imprimir()

        'Imprimindo com a classe DANFe_65Print
        Dim danfe As New DANFe_65Print
        danfe.imprimir(xml.importXML, csc)





    End Sub
    ''' <summary>
    ''' Imprime com base na chave de acesso
    ''' </summary>
    ''' <param name="chNFe"></param>
    ''' <remarks></remarks>
    Public Sub imprimirDanfe(ByVal chNFe As String)

        Dim localXmlAutorizado As String = _pXmlAutorizado & "\20" & Mid(chNFe, 3, 4) & "\" & chNFe & "-procNFe.xml"
        'Caso nao ache o arquivo assinado pela sefas
        'busca contigencia
        If Not System.IO.File.Exists(localXmlAutorizado) Then
            localXmlAutorizado = Application.StartupPath & "\xml\" & chNFe & "-nfe.xml"
        End If
        printDanfe(localXmlAutorizado)

    End Sub

    ''' <summary>
    ''' Carrega as variaveis de uso na emissao da NFCe
    ''' Metodo em duplicidade, basta buscar pelo codigo
    ''' xmkdytremkp
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub carregarVariaveis()
        Dim folder As String = Application.StartupPath
        Dim localFile As String = folder & "\config.ini"

        _pXmlAutorizado = LeArquivoINI(localFile, "UniNFe", "pXmlAutorizado", folder)
        _pXmlEnvio = LeArquivoINI(localFile, "UniNFe", "pXmlEnvio", folder)
        csc = LeArquivoINI(localFile, "UniNFe", "csc", "")

        _nLoop = LeArquivoINI(localFile, "UniNFe", "checagemLoop", "3")
        _intervaloLoop = LeArquivoINI(localFile, "UniNFe", "checagemTempo", "5000")

    End Sub

    Private Sub carregarXmlAutorizado(file_xml As String)
        Dim serializer As Serialization.XmlSerializer
        Dim doc As XmlDocument = New XmlDocument
        Dim culture As String = My.Application.Culture.Name
        My.Application.ChangeCulture("en-US")


        Dim arquivo As New FileInfo(file_xml)


        Dim SR As New StreamReader(file_xml)
        arquivo = Nothing
        Application.DoEvents()

        doc.Load(file_xml)

        'tipo = doc.FirstChild.NextSibling.Name
        'doc = Nothing

        'If tipo = "enviNFe" Then ' Envio de Lotes de NFe
        Dim nProt As New nfeProc
        serializer = New Serialization.XmlSerializer(nProt.GetType)
        nProt = DirectCast(serializer.Deserialize(SR), nfeProc)
        'ElseIf tipo = "nfeProc" Then ' NFe já processada e com o protocolo (xml de circulação)
        '    object_NFe = New nfeProc
        '    serializer = New Serializat

        'Gravar protocolo do xml no bd
        Dim nfDAO As New NFeDAO
        nfDAO.gravarProtAutorizacao(nProt.protNFe.infProt.chNFe, nProt.protNFe.infProt.nProt, nProt.protNFe.infProt.digVal)
    End Sub

    Public Sub consultaSituacao(ByVal chNFe As String)
        Dim gXML As New GeraXML
        Dim nfeDAO As New NFeDAO
        Dim nf As New NFCe
        nf = nfeDAO.pgNfe(chNFe)

        gXML.GerarXMLConsultaSit(nf)


    End Sub
End Class
