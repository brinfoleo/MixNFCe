''' <summary>
''' Classe para consultar a situacao da NFCe
''' e dependendo do caso INUTILIZAR o numero
''' ou CANCELAR a nota
''' </summary>
''' <remarks></remarks>
Public Class SefazSituacaoNFCe

    
    'Pasta que guarda o retorno do XML autorizado
    Private _pXmlAutorizado As String
    'Pasta de envio do UniNFE
    Private _pXmlEnvio As String
    'Pasta de retorno do UNINFe
    Private _pXmlRetorno As String

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
    Public Sub executar()

        System.Console.WriteLine(Now() & " -  Iniciando processo em SefazSituacaoNFCe")
        Dim nfDAO As New NFeDAO

        Dim nfce As New NFCe


        'Cosnulta e gera um lista de Notas sem autorizacao da sefaz
        'Dim nfDAO As New NFeDAO
        Dim lst As New List(Of NFCe)
        Dim retStatus As Integer
        Dim operacao As String

        'Carrega a List de notas com falta de protocolo
        lst = nfDAO.listarNFeSemRegistroSEFAZ


        For Each nt As NFCe In lst
            operacao = "sit"
            gerarConsSitSefaz(nt)

            For i = 1 To 5
                
                retStatus = retornoConsulta(nt, operacao)

                If retStatus = 0 Then 'Nao existe arquivo na pasta
                    'Pausa para aguardo
                    System.Threading.Thread.Sleep(2000)

                ElseIf retStatus = -1 Then 'Arquivo com erro
                    Util.log(nt.Id & " - Erro: (" & retStatus & ")")
                    Util.logWeb(nt.Id & " - Erro: (" & retStatus & ")")
                    Exit For

                ElseIf retStatus = 100 Then 'Arquivo autorizado pela SEFAZ

                    If nt.infNFE.ide.tpEmis = "9" Then
                        'nota em contingencia
                        'gravando protocolo de autorizacao
                        nfDAO.gravarProtAutorizacao(nt.Id, nt.nProt, nt.digVal)
                        Util.log(nt.Id & " - Nota em contingencia autorizada [" & nt.nProt & "]")
                        Exit For
                    Else
                        'nota normal
                        Util.log(nt.Id & " - Solicitacao de Cancelamento")
                        operacao = "can"
                        cancelarNFCe(nt)

                    End If
                ElseIf retStatus = 101 Then 'Cancelamento de nfe homologado
                    'gravando protocolo de autorizacao e de cancelamento
                    nfDAO.gravarProtAutorizacao(nt.Id, nt.nProt, nt.digVal)
                    nfDAO.gravarProtCancelamento(nt, nt.nProtCancelamento)

                ElseIf retStatus = 563 Then 'Numero de Nota Inutilizado
                    Util.log(nt.Id & " - (563) Numero de Nota Inutilizado")
                    Exit For
                ElseIf retStatus = 613 Then 'Chave de acesso diferente da existente BD
                    Util.log(nt.Id & " - 613 - chNFe diferente BD" & IIf(nt.infNFE.ide.tpEmis = "9", "(contingencia)", ""))
                    Util.logWeb(nt.Id & " - 613 - chNFe diferente BD" & IIf(nt.infNFE.ide.tpEmis = "9", "(contingencia)", ""))
                    Exit For
                ElseIf retStatus = 217 Then 'Nao consta na base de dados da sefaz
                    If nt.infNFE.ide.tpEmis = "9" Then
                        'Reeviar
                        operacao = "sit"
                        Util.moveFile(Application.StartupPath & "\xml", _pXmlEnvio, nt.Id & "-nfe.xml")
                        Util.log(nt.Id & " - Reenvio nota em contingencia ")
                        Util.logWeb(nt.Id & " - Reenvio nota em contingencia ")
                        Exit For
                    Else
                        Util.log(nt.Id & " - Solicitacao de Inutilizacao")
                        operacao = "inu"
                        inutilizaNFCe(nt)
                    End If

                ElseIf retStatus = 501 Then 'Nota nao pode ser cancelada devido ter expirado o prazo
                    'Gravar protocolo de autorizacao
                    nfDAO.gravarProtAutorizacao(nt.Id, nt.nProt, nt.digVal)

                    Exit For

                Else 'Qualquer outro retorno pula para a proxima nota
                    Util.log(nt.Id & " - (" & retStatus & ") Retorno inesperado ")
                    Util.logWeb(nt.Id & " - (" & retStatus & ") Retorno inesperado ")
                    Exit For
                End If

            Next
            'Util.log(nt.Id & " - Status NFe: " & retStatus)
            'System.Console.WriteLine(Now() & " -  " & nt.Id & "  status: " & retStatus)
        Next

        System.Console.WriteLine(Now() & " -  Finalizando processo em SefazSituacaoNFCe")
        '135 - Evento registrado e vinculado a NF-e

    End Sub
    ''' <summary>
    ''' Cancela NFCe automaticamente
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <remarks></remarks>
    Private Sub cancelarNFCe(ByVal nt As NFCe)
        Dim gXML As New GeraXML
        Dim nFile As String
        nt.xJust = "NFCe cancelada devido a falha na recepcao do protocolo de autorizacao"
        nFile = gXML.GerarXMLCancelamento(nt)
        moverUninfe(nFile)

        'Registrando as ocorrencias
        Dim msgLog As String = nt.Id & " - Envio de CANCELAMENTO"
        log(msgLog)
        logWeb(msgLog)
    End Sub
    ''' <summary>
    ''' Inutiliza numero da  NFCe
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <remarks></remarks>
    Private Sub inutilizaNFCe(ByVal nt As NFCe)
        Dim nFile As String
        Dim gXML As New GeraXML
        nt.NumNf_Ini = nt.infNFE.ide.nNF
        nt.NumNf_Fin = nt.infNFE.ide.nNF
        nt.ano = nt.infNFE.ide.dhEmi.ToString.Substring(2, 2)
        nt.xJust = "NFCe inutilizada devido a falha na recepcao do protocolo de autorizacao"
        nFile = gXML.GerarXMLInutilizacao(nt)
        moverUninfe(nFile)

        'Registrando as ocorrencias
        Dim msgLog As String = nt.Id & " - Envio de Inutilizacao"
        log(msgLog)
        logWeb(msgLog)

    End Sub
    ''' <summary>
    ''' Gera o arquivo que consulta a situacao do XML
    ''' junto a SEFAZ
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <remarks></remarks>
    Private Sub gerarConsSitSefaz(nt As NFCe)
        Dim nArqXML As String
        Dim sitNFCe As New consSitNFe
        sitNFCe.chNFe = nt.Id
        sitNFCe.tpAmb = nt.infNFE.ide.tpAmb
        sitNFCe.versao = nt.versao
        sitNFCe.xServ = "CONSULTA"
        Dim gXML As New GeraXML
        nArqXML = gXML.GerarXMLConsultaSit(nt)

        'Limpar o historico de consultas anteriores
        limpaHistoricoRetornoUninfe(nt.Id)

        'Move para o uninfe
        moverUninfe(nArqXML)
    End Sub
    Private Function retornoConsulta(ByRef nt As NFCe, operacao As String) As Integer
        ' Dim nfile As String = nt.Id & "-sit.*"
        ' Dim fileNames = My.Computer.FileSystem.GetFiles(
        '_pXmlRetorno, FileIO.SearchOption.SearchTopLevelOnly, nfile)
        ' If fileNames.Count > 0 Then
        '     MsgBox("Existe")
        ' End If

        'Limpar o historico de consultas anteriores
        'limpaHistoricoRetornoUninfe(nt.Id)

        Dim flag As Integer = 0
        If operacao = "inu" Then
            If System.IO.File.Exists(_pXmlRetorno & "\" & nt.Id & "-inu.xml") Then
                flag = retInutNFe(nt)
            ElseIf System.IO.File.Exists(_pXmlRetorno & "\" & nt.Id & "-inu.err") Then
                flag = -1
            End If
        End If
        If operacao = "can" Then
            If System.IO.File.Exists(_pXmlRetorno & "\" & nt.Id & "-ret-env-canc.xml") Then
                flag = retCancNFe(nt)
            ElseIf System.IO.File.Exists(_pXmlRetorno & "\" & nt.Id & "-ret-env-canc.err") Then
                flag = -1
            End If
        End If
        If operacao = "sit" Then
            If System.IO.File.Exists(_pXmlRetorno & "\" & nt.Id & "-sit.xml") Then
                flag = retConsSitNFe(nt)
            ElseIf System.IO.File.Exists(_pXmlRetorno & "\" & nt.Id & "-sit.err") Then
                flag = -1
            End If
        End If
        
        Return flag
    End Function
    ''' <summary>
    ''' Retorno de consulta situacao da nfe
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function retConsSitNFe(ByRef nt As NFCe) As Integer

        Dim localXML As String = _pXmlRetorno & "\" & nt.Id & "-sit.xml"
        Dim localXMLerr As String = _pXmlRetorno & "\" & nt.Id & "-sit.err"

        If System.IO.File.Exists(localXMLerr) Then
            Return -1
            Exit Function
        ElseIf Not System.IO.File.Exists(localXML) Then
            Return 0
            Exit Function
        End If


        Dim iXML As New ImportXML(localXML)
        Dim tipo As String = "retConsSitNFe"
        Dim obj As New Object
        iXML.Deserializar_NFe(localXML, obj, tipo)
        Dim retStatus As Integer 'Retorna o status da nfce

        'Avaliar se a nf existe e esta valida
        Dim retSit As New retConsSitNFe
        If obj.Equals(Nothing) Then
            retStatus = 0
        Else
            Try
                retSit = obj
                retStatus = retSit.cStat
                'If retStatus = "100" Then
                'Carrega o protocolo de autrizacao na instancia


                nt.nProt = retSit.protNFe.Item(0).infProt.nProt
            
                nt.nProtCancelamento = retSit.procEventoNFe.Item(0).retEvento.infEvento.nProt
            Catch
            End Try

        End If

        Return retStatus
    End Function
    ''' <summary>
    ''' Retorna a situacao caso a Inutilizacao tenha sido efetuada
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function retInutNFe(ByRef nt As NFCe) As Integer
        Dim localXML As String = _pXmlRetorno & "\" & nt.Id & "-inu.xml"
        Dim localXMLerr As String = _pXmlRetorno & "\" & nt.Id & "-inu.err"

        If System.IO.File.Exists(localXMLerr) Then
            Return -1
            Exit Function
        ElseIf Not System.IO.File.Exists(localXML) Then
            Return 0
            Exit Function
        End If


        Dim iXML As New ImportXML(localXML)
        Dim tipo As String = "retInutNFe"
        Dim obj As New Object
        iXML.Deserializar_NFe(localXML, obj, tipo)
        Dim retStatus As Integer 'Retorna o status da nfce

        'Avaliar se a nf existe e esta valida
        Dim retSit As New retInutNFe  ' retConsSitNFe
        If obj.Equals(Nothing) Then
            retStatus = 0
        Else
            retSit = obj
            retStatus = retSit.infInut.cStat
            If retStatus = "563" Then
                'nt.nProt = retSit.infInut.nProt
                Dim nfDAO As New NFeDAO
                nfDAO.gravarProtInutilizacao(nt, retSit.infInut)
                'Registrando as ocorrencias
                Dim msgLog As String = nt.Id & " - Inutilizacao: " & "[" & retSit.infInut.nProt & "]"
                log(msgLog)
                logWeb(msgLog)
                System.Console.WriteLine("Inutilizacao: " & nt.Id & "[" & retSit.infInut.nProt & "]")
            End If
            End If

            Return retStatus
    End Function

    ''' <summary>
    ''' Retorna a situacao caso a CANCELAMENTO tenha sido efetuada
    ''' </summary>
    ''' <param name="nt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function retCancNFe(ByRef nt As NFCe) As Integer
        Dim localXML As String = _pXmlRetorno & "\" & nt.Id & "-ret-env-canc.xml"
        Dim localXMLerr As String = _pXmlRetorno & "\" & nt.Id & "-ret-env-canc.err"

        If System.IO.File.Exists(localXMLerr) Then
            Return -1
            Exit Function
        ElseIf Not System.IO.File.Exists(localXML) Then
            Return 0
            Exit Function
        End If


        Dim iXML As New ImportXML(localXML)
        Dim tipo As String = ""
        Dim obj As New Object
        iXML.Deserializar_NFe(localXML, obj, tipo)
        Dim retStatus As Integer 'Retorna o status da nfce

        'Avaliar se a nf existe e esta valida
        Dim retSit As New retEnvEvento
        If obj.Equals(Nothing) Then
            retStatus = 0
        Else
            retSit = obj
            retStatus = retSit.retEvento.Item(0).infEvento.cStat
            'If retStatus = "501" Then 'NF com prazo para cancelamento expirado
            'nt.nProt = retSit.
            'Dim nfDAO As New NFeDAO
            ' nfDAO.gravarProtInutilizacao(nt, retSit.infInut)
            'System.Console.WriteLine("Inutilizacao: " & nt.Id & "[" & retSit.infInut.nProt & "]")
            'End If
            'Registrando as ocorrencias
            Dim msgLog As String = nt.Id & " - Cancelamento: " & "[" & retStatus & "]"
            log(msgLog)
            logWeb(msgLog)
            System.Console.WriteLine("Cancelamento: " & nt.Id & "[" & retStatus & "]")
        End If

        Return retStatus
    End Function

    ''' <summary>
    ''' Move o arquivo para o uninfe
    ''' </summary>
    ''' <param name="nfile"></param>
    ''' <remarks></remarks>
    Private Sub moverUninfe(nFile As String)
        Util.moveFile(Application.StartupPath & "\xml", _pXmlEnvio, nFile)
    End Sub
    ''' <summary>
    ''' Limpa o historico de retorno da pasta do
    ''' uninfe.
    ''' </summary>
    ''' <param name="chNFe">Chave de acesso</param>
    ''' <remarks></remarks>
    Private Sub limpaHistoricoRetornoUninfe(ByVal chNFe As String)

        'Util.moveFile(Application.StartupPath & "\xml", _pXmlEnvio, nFile)
        'Deleta enviando o arquivo para a lixeira
        Util.deleteFile(_pXmlRetorno, chNFe & "*.*")

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
        'csc = LeArquivoINI(localFile, "UniNFe", "csc", "")
        _pXmlRetorno = LeArquivoINI(localFile, "UniNFe", "pXmlRetorno", folder)

        _nLoop = LeArquivoINI(localFile, "UniNFe", "checagemLoop", "3")
        _intervaloLoop = LeArquivoINI(localFile, "UniNFe", "checagemTempo", "5000")

    End Sub
End Class
