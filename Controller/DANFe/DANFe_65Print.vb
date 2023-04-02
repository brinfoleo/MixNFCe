Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports MessagingToolkit.QRCode.Codec

Public Class DANFe_65Print

    Private p As New Printer

    Public Sub imprimir(ByVal nt As NFe, ByVal csc As String)
        If nt.infNFe.ide.mod = "65" Then
            If nt.infNFe.ide.tpEmis = 9 Then
                If strLayoutCupom = "Normal" Then
                    iDANFe(nt, csc)
                    iDANFe(nt, csc)
                Else
                    iDANFeCompacto(nt, csc)
                    iDANFeCompacto(nt, csc)
                End If
            Else
                If strLayoutCupom = "Normal" Then
                    iDANFe(nt, csc)
                Else
                    iDANFeCompacto(nt, csc)
                End If

            End If
        Else
            iPedidoCompacto(nt, csc)
        End If
    End Sub
    Private Sub iDANFe(ByVal nt As NFe, ByVal csc As String)
        Dim linha As New String("-", 80)
        Dim y As String
        'Fonte e tamanho de fonte padrao
        Dim nFont As String = "Microsoft Sans Serif"
        Dim tFont As Integer = 8
        p.FontName = nFont
        p.FontSize = tFont

        'Registro I
        pOut(" ")
        pOut(nt.infNFe.emit.xNome)
        pOut("CNPJ: " & nt.infNFe.emit.CNPJ & "  I.E.: " & nt.infNFe.emit.IE)
        Dim endereco As String
        endereco = nt.infNFe.emit.enderEmit.xLgr & " " & _
                   nt.infNFe.emit.enderEmit.nro & " " & _
                   nt.infNFe.emit.enderEmit.xCpl & " " & _
                   nt.infNFe.emit.enderEmit.xBairro
        pOut("End.: " & endereco)

        'Linha, onde: Xi,Yi,Xf,Yf
        pOut(linha)
        'Registro II
        p.FontSize = 10
        p.FontBold = True
        pOut("   DANFE NFC-e - Documento Auxiliar")
        pOut("da Nota Fiscal de Consumidor Eletrônica")
        pOut("  Não permite aproveitamento de crédito")

        p.FontSize = tFont
        p.FontBold = False


        'registro III

        'Dim strFormat As New StringFormat
        'strFormat.Alignment = StringAlignment.Far
        'strFormat.LineAlignment = StringAlignment.Far
        pOut(linha)
        pOut("Item                 Descricao")
        pOut("unidade    Qtd. x Vl. Unit                                       Vl.Total")
        pOut(linha)
        For Each d As det In nt.infNFe.det
            pOut(d.nItem.ToString.PadLeft(3, "0") & "  " & d.prod.xProd)
            y = p.CurrentY
            pOut(d.prod.uCom & "    " & FormatNumber(d.prod.qCom) & "  x  " & _
                                        FormatNumber(d.prod.vUnCom), 400)
            pOut(FormatNumber(d.prod.vProd), (3800 - p.TextWidth(d.prod.vProd)), y)
        Next
        pOut(linha)

        'Registro IV
        Dim qtdI As String
        y = p.CurrentY
        qtdI = nt.infNFe.det.Count.ToString.PadLeft(5, "0")
        pOut("Qtd. Total de Itens: ")
        pOut(qtdI, (4000 - p.TextWidth(qtdI)), y)

        pOut(" ")

        Dim vt As String
        p.FontSize = 14
        p.FontBold = True
        vt = FormatNumber(nt.infNFe.total.ICMSTot.vNF.ToString.Replace(".", "."))
        y = p.CurrentY
        pOut("Valor Total: ")
        pOut(vt, (4000 - p.TextWidth(vt)), y)

        p.FontSize = tFont
        p.FontBold = False

        pOut(" ")
        pOut("FORMA PAGAMENTO")
        Dim vFP As String
        For Each pg As pag In nt.infNFe.pag
            y = p.CurrentY
            pOut(pgNomeTipoPagamento(pg.tPag))
            vFP = FormatNumber(pg.vPag.ToString.Replace(".", ","))
            pOut(vFP, (4000 - p.TextWidth(vFP)), y)
        Next
        pOut(linha)
        'Registro V
        pOut("      Informação dos Tributos Totais Incidentes")
        pOut("             (Lei Federal 12.741/2012)  " & FormatCurrency((nt.infNFe.total.ICMSTot.vNF * 35.75 / 100).ToString.Replace(".", ",")))

        pOut(linha)

        'REGISTRO VI
        p.FontSize = 6
        pOut("     Número: " & nt.infNFe.ide.nNF.ToString.PadLeft(6, "0") & " Série: " & nt.infNFe.ide.serie & " Emissão: " & Mid(nt.infNFe.ide.dhEmi, 1, nt.infNFe.ide.dhEmi.Length - 6).Replace("T", " "))


        p.FontSize = tFont
        pOut("         Consulte pela chave de acesso em ")
        pOut("       http://nfce.fazenda.rj.gov.br/consulta")
        pOut(" ")
        pOut("                       CHAVE DE ACESSO")
        pOut(Mid(nt.infNFe.Id, 4, nt.infNFe.Id.Length))


        pOut(linha)

        'Registro VII - Dados do Comprador
        If IsNothing(nt.infNFe.dest) Then
            pOut("               VENDA AO CONSUMIDOR")
        Else
            Dim cliDoc As String
            cliDoc = IIf(nt.infNFe.dest.CNPJ = Nothing, nt.infNFe.dest.CPF, nt.infNFe.dest.CNPJ)
            p.FontSize = 6
            pOut(cliDoc)
            pOut(nt.infNFe.dest.xNome)

        End If

        p.FontSize = tFont

        pOut(linha)

        'Registro VII
        pOut("Consulta via leitor de QR Code", 950)
        pOut(" ")

        Dim iimg As Bitmap
        ' Dim y As String

        iimg = qrCode(nt, csc)
        'Imprime o QRCode

        p.PaintPicture(iimg, 1150, p.CurrentY, 2000, 2000)
        'pImage.Graphics.DrawImage(iimg, 30, 30) ', 20, 30, 30, 30)
        'pOut(qrCode(nt, csc)) 

        'Protocolo de autorizacao
        'tpEmis=9 : NFCe Gerado em contigencia

        If nt.infNFe.ide.tpEmis = 9 Then
            pOut("EMITIDA EM CONTINGENCIA", , p.CurrentY + 2200)
        Else
            pOut("EMITIDA NORMALMENTE", , p.CurrentY + 2200)
        End If

        Try
            pOut("Protocolo de Autorização: " & nt.protNFe.infProt.nProt)
        Catch
            pOut("Protocolo de Autorização: ")
        End Try

        pOut(linha)

        'Registro V
        Try
            pOut(nt.infNFe.infAdic.infCpl)
        Catch
        End Try

        pOut(linha)

        p.EndDoc()
    End Sub

    Private Sub iDANFeCompacto(ByVal nt As NFe, ByVal csc As String)
        Dim linha As New String("-", 90)
        Dim y As String
        Dim t As String
        'Fonte e tamanho de fonte padrao
        Dim nFont As String = "Times New Roman"
        Dim tFont As Integer = 7
        p.FontName = nFont
        p.FontSize = tFont

        'Registro I
        p.FontBold = True
        p.FontSize = 13
        pOut("                        NFCe")
        p.FontSize = 13
        p.FontSize = 8
        pOut(linha)
        pOut(nt.infNFe.emit.xNome)
        p.FontBold = False
        p.FontSize = 7
        pOut("CNPJ: " & nt.infNFe.emit.CNPJ & "  I.E.: " & nt.infNFe.emit.IE)
        Dim endereco As String
        endereco = nt.infNFe.emit.enderEmit.xLgr & " " & _
                   nt.infNFe.emit.enderEmit.nro & " " & _
                   nt.infNFe.emit.enderEmit.xCpl & " " & _
                   nt.infNFe.emit.enderEmit.xBairro
        pOut("End.: " & endereco)

        'Linha, onde: Xi,Yi,Xf,Yf
        pOut(linha)
        'Registro II
        pOut("   DANFE NFC-e - Documento Auxiliar da Nota Fiscal de Consumidor Eletrônica")
        'pOut("")
        p.FontBold = True
        pOut("                       Não permite aproveitamento de crédito")
        p.FontBold = False

        pOut(linha)
        p.FontBold = True
        pOut("ITEM  DESCRICAO            UN    QTD.   VL.UN              TOTAL")
        p.FontBold = False
        pOut(linha)
        For Each d As det In nt.infNFe.det
            y = p.CurrentY
            pOut(d.nItem.ToString.PadLeft(3, "0") & " " & Mid(d.prod.xProd, 1, 15))

            t = d.prod.uCom.ToUpper
            pOut(t, (1900 - p.TextWidth(t)), y)

            pOut(FormatNumber(d.prod.qCom) & "  x  " & "R$" & FormatNumber(d.prod.vUnCom), 2100, y)



            t = "R$" & FormatNumber(d.prod.vProd)
            pOut(t, (4000 - p.TextWidth(t)), y)


        Next
        pOut(linha)

        'Registro IV
        Dim qtdI As String
        y = p.CurrentY
        qtdI = nt.infNFe.det.Count.ToString.PadLeft(5, "0")
        pOut("Qtd. Total de Itens: ")
        pOut(qtdI, (4000 - p.TextWidth(qtdI)), y)

        pOut(linha)


        p.FontSize = 11
        p.FontBold = True
        t = "R$ " & FormatNumber(nt.infNFe.total.ICMSTot.vNF.ToString.Replace(".", "."))
        y = p.CurrentY
        pOut("Valor Total: ")
        pOut(t, (4000 - p.TextWidth(t)), y)
        p.FontSize = tFont
        p.FontBold = False

        pOut(linha)

        pOut("FORMA PAGAMENTO")

        For Each pg As pag In nt.infNFe.pag
            y = p.CurrentY
            pOut(pgNomeTipoPagamento(pg.tPag))
            t = "R$ " & FormatNumber(pg.vPag.ToString.Replace(".", ","))
            pOut(t, (4000 - p.TextWidth(t)), y)
        Next
        pOut(linha)
        'Registro V
        pOut("Inf. dos Trib. Totais Incidentes (Lei Federal 12.741/2012)  " & FormatCurrency((nt.infNFe.total.ICMSTot.vNF * 35.75 / 100).ToString.Replace(".", ",")))

        pOut(linha)

        'REGISTRO VI

        p.FontSize = 8
        pOut("Número: " & nt.infNFe.ide.nNF.ToString.PadLeft(6, "0") & " Série: " & nt.infNFe.ide.serie & " Emissão: " & Mid(nt.infNFe.ide.dhEmi, 1, nt.infNFe.ide.dhEmi.Length - 6).Replace("T", " "))
        p.FontSize = tFont
        pOut(linha)
        pOut("Consulte pela chave de acesso em  http://nfce.fazenda.rj.gov.br/consulta")

        pOut("CHAVE DE ACESSO")
        pOut(Mid(nt.infNFe.Id, 4, nt.infNFe.Id.Length))

        pOut(linha)

        'Registro VII - Dados do Comprador
        If IsNothing(nt.infNFe.dest) Then
            pOut("VENDA AO CONSUMIDOR", 960)
        Else
            Dim cliDoc As String
            cliDoc = IIf(nt.infNFe.dest.CNPJ = Nothing, nt.infNFe.dest.CPF, nt.infNFe.dest.CNPJ)
            p.FontSize = 6
            pOut(cliDoc)
            pOut(nt.infNFe.dest.xNome)

        End If

        p.FontSize = tFont

        pOut(linha)

        'Registro VII
        pOut("Consulta via leitor de QR Code", 960)
        pOut(" ")

        Dim iimg As Bitmap
        ' Dim y As String

        iimg = qrCode(nt, csc)
        'Imprime o QRCode

        p.PaintPicture(iimg, 1150, p.CurrentY, 2000, 2000)
        'pImage.Graphics.DrawImage(iimg, 30, 30) ', 20, 30, 30, 30)
        'pOut(qrCode(nt, csc)) 

        'Protocolo de autorizacao
        'tpEmis=9 : NFCe Gerado em contigencia

        If nt.infNFe.ide.tpEmis = 9 Then
            pOut("EMITIDA EM CONTINGENCIA", , p.CurrentY + 2200)
        Else
            pOut("EMITIDA NORMALMENTE", , p.CurrentY + 2200)
        End If

        Try
            pOut("Protocolo de Autorização: " & nt.protNFe.infProt.nProt)
        Catch
            pOut("Protocolo de Autorização: ")
        End Try

        pOut(linha)

        'Registro V
        Try
            pOut(nt.infNFe.infAdic.infCpl)
        Catch
        End Try

        pOut(linha)

        p.EndDoc()
    End Sub



    Private Sub iPedidoCompacto(ByVal nt As NFe, ByVal csc As String)
        Dim linha As New String("-", 90)
        Dim y As String
        Dim t As String
        'Fonte e tamanho de fonte padrao
        Dim nFont As String = "Times New Roman"
        Dim tFont As Integer = 7
        p.FontName = nFont
        p.FontSize = tFont

        'Registro I
        p.FontBold = True
        p.FontSize = 13
        pOut("                        PEDIDO")
        p.FontSize = 13
        p.FontSize = 8
        pOut(linha)
        pOut(nt.infNFe.emit.xNome)
        p.FontBold = False
        p.FontSize = 7
        pOut("CNPJ: " & nt.infNFe.emit.CNPJ & "  I.E.: " & nt.infNFe.emit.IE)
        Dim endereco As String
        endereco = nt.infNFe.emit.enderEmit.xLgr & " " & _
                   nt.infNFe.emit.enderEmit.nro & " " & _
                   nt.infNFe.emit.enderEmit.xCpl & " " & _
                   nt.infNFe.emit.enderEmit.xBairro
        pOut("End.: " & endereco)

        'Linha, onde: Xi,Yi,Xf,Yf
        pOut(linha)
        'Registro II
        'pOut("   DANFE NFC-e - Documento Auxiliar da Nota Fiscal de Consumidor Eletrônica")
        'pOut("")
        'p.FontBold = True
        'pOut("                       Não permite aproveitamento de crédito")
        'p.FontBold = False

        'pOut(linha)
        p.FontBold = True
        pOut("ITEM  DESCRICAO            UN    QTD.   VL.UN              TOTAL")
        p.FontBold = False
        pOut(linha)
        For Each d As det In nt.infNFe.det
            y = p.CurrentY
            pOut(d.nItem.ToString.PadLeft(3, "0") & " " & Mid(d.prod.xProd, 1, 15))

            t = d.prod.uCom.ToUpper
            pOut(t, (1900 - p.TextWidth(t)), y)

            pOut(FormatNumber(d.prod.qCom) & "  x  " & "R$" & FormatNumber(d.prod.vUnCom), 2100, y)



            t = "R$" & FormatNumber(d.prod.vProd)
            pOut(t, (4000 - p.TextWidth(t)), y)


        Next
        pOut(linha)

        'Registro IV
        Dim qtdI As String
        y = p.CurrentY
        qtdI = nt.infNFe.det.Count.ToString.PadLeft(5, "0")
        pOut("Qtd. Total de Itens: ")
        pOut(qtdI, (4000 - p.TextWidth(qtdI)), y)

        pOut(linha)


        p.FontSize = 11
        p.FontBold = True
        t = "R$ " & FormatNumber(nt.infNFe.total.ICMSTot.vNF.ToString.Replace(".", "."))
        y = p.CurrentY
        pOut("Valor Total: ")
        pOut(t, (4000 - p.TextWidth(t)), y)
        p.FontSize = tFont
        p.FontBold = False

        pOut(linha)

        pOut("FORMA PAGAMENTO")

        For Each pg As pag In nt.infNFe.pag
            y = p.CurrentY
            pOut(pgNomeTipoPagamento(pg.tPag))
            t = "R$ " & FormatNumber(pg.vPag.ToString.Replace(".", ","))
            pOut(t, (4000 - p.TextWidth(t)), y)
        Next
        pOut(linha)
        'Registro V
        'pOut("Inf. dos Trib. Totais Incidentes (Lei Federal 12.741/2012)  " & FormatCurrency((nt.infNFe.total.ICMSTot.vNF * 35.75 / 100).ToString.Replace(".", ",")))

        '        pOut(linha)

        'REGISTRO VI

        p.FontSize = 8
        pOut("    Número: " & "P" & nt.infNFe.ide.nNF.ToString & "      " & " Emissão: " & Mid(nt.infNFe.ide.dhEmi, 1, nt.infNFe.ide.dhEmi.Length - 6).Replace("T", " "))
        p.FontSize = tFont
        'pOut(linha)
        'pOut("Consulte pela chave de acesso em  http://nfce.fazenda.rj.gov.br/consulta")

        'pOut("CHAVE DE ACESSO")
        'pOut(Mid(nt.infNFe.Id, 4, nt.infNFe.Id.Length))

        pOut(linha)

        'Registro VII - Dados do Comprador
        If IsNothing(nt.infNFe.dest) Then
            pOut("VENDA AO CONSUMIDOR", 960)
        Else
            Dim cliDoc As String
            cliDoc = IIf(nt.infNFe.dest.CNPJ = Nothing, nt.infNFe.dest.CPF, nt.infNFe.dest.CNPJ)
            p.FontSize = 6
            pOut(cliDoc)
            pOut(nt.infNFe.dest.xNome)

        End If

        p.FontSize = tFont

        pOut(linha)

        'Registro VII
        'pOut("Consulta via leitor de QR Code", 960)
        'pOut(" ")

        'Dim iimg As Bitmap
        ' Dim y As String

        'iimg = qrCode(nt, csc)
        'Imprime o QRCode

        'p.PaintPicture(iimg, 1150, p.CurrentY, 2000, 2000)
        'pImage.Graphics.DrawImage(iimg, 30, 30) ', 20, 30, 30, 30)
        'pOut(qrCode(nt, csc)) 

        'Protocolo de autorizacao
        'tpEmis=9 : NFCe Gerado em contigencia

        'If nt.infNFe.ide.tpEmis = 9 Then
        'pOut("EMITIDA EM CONTINGENCIA", , p.CurrentY + 2200)
        'Else
        'pOut("EMITIDA NORMALMENTE", , p.CurrentY + 2200)
        'End If

        'Try
        '    pOut("Protocolo de Autorização: " & nt.protNFe.infProt.nProt)
        'Catch
        '    pOut("Protocolo de Autorização: ")
        'End Try

        'pOut(linha)

        'Registro V
        'Try
        '    pOut(nt.infNFe.infAdic.infCpl)
        'Catch
        'End Try

        'pOut(linha)

        p.EndDoc()
    End Sub


    Private Function qrCode(ByVal nt As NFe, ByVal csc As String) As Bitmap



        Dim strDadosQRCode As String 'Armazena o texto sera impresso no qrCode
        Dim q As New QRCodeEncoder
        Dim qb As Bitmap

        'Identificador CSC/Token (6 digitod)
        'Dim idCSC As String = "000002"
        Dim idCSC As String = Mid(csc, 1, 6)
        'CSC - Codigo de seguranca do contribuinte
        Dim cldToken As String = Mid(csc, 7, csc.Length)
        Try


            'chNFe 
            strDadosQRCode = "chNFe=" & Right(nt.infNFE.Id, 44)

            'aVersao 
            strDadosQRCode += "&nVersao=" & "100" 'q.QRCodeVersion.ToString
            'tpamb 
            strDadosQRCode += "&tpAmb=" & nt.infNFE.ide.tpAmb
            'cnpjDest 
            Dim sDoc As String
            If Not IsNothing(nt.infNFE.dest) Then
                If nt.infNFE.dest.CNPJ <> Nothing Then
                    sDoc = nt.infNFE.dest.CNPJ
                ElseIf nt.infNFE.dest.CPF <> Nothing Then
                    sDoc = nt.infNFE.dest.CPF
                Else
                    sDoc = ""

                End If
            Else
                sDoc = ""
            End If

            strDadosQRCode += "&cDest=" & sDoc
            'dhemi 
            strDadosQRCode += "&dhEmi=" & convertHexadecimal(nt.infNFE.ide.dhEmi)
            'vNF '
            strDadosQRCode += "&vNF=" & nt.infNFE.total.ICMSTot.vNF
            'vICMS 
            strDadosQRCode += "&vICMS=" & nt.infNFE.total.ICMSTot.vICMS
            'digVal 
            If Not IsNothing(nt.protNFe.infProt.digVal) Then
                strDadosQRCode += "&digVal=" & convertHexadecimal(nt.protNFe.infProt.digVal)
            Else
                strDadosQRCode += "&digVal=" & ""
            End If
            'Identificador CSC/Token (6 digitod)
            strDadosQRCode += "&cldToken=" & idCSC

            'CSC - Codigo de seguranca do contribuinte
            'Dim cldToken As String = "7C0D848C79C4D35D7CD7133BA78FB2BFUL89"


            'Aplicar o algoritimo SHA-1
            strDadosQRCode += "&cHashQRCode=" & getSHA1Hash(strDadosQRCode & cldToken)
            strDadosQRCode = "http://www4.fazenda.rj.gov.br/consultaNFCe/QRCode?" & strDadosQRCode

            'strDadosQRCode += "CSC=" & "72qQa+b0taoQO9fAJwfdlXuqQv8="
            'cHashQRCode

            'strDadosQRCode += q.GetHashCode
        Catch ex As Exception
            MsgBox("Erro ao gerar qrCode" & vbCrLf & "Mensagem: " & ex.Message, MsgBoxStyle.Information, "qrCode")
        End Try
        qb = q.Encode(strDadosQRCode)
        Return qb
    End Function
    Private Function convertHexadecimal(ByVal sText As String) As String

        Dim sHex As String
        For i As Integer = 0 To sText.Length - 1
            sHex += Asc(sText.Substring(i, 1)).ToString("x")
        Next
        'MsgBox(sText & vbCrLf & vHex)
        Return sHex
    End Function

    Function getSHA1Hash(ByVal strToHash As String) As String

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function
    Private Function pgNomeTipoPagamento(ByVal tPag As Integer) As String
        If tPag = 1 Then
            Return "DINHEIRO"
        ElseIf tPag = 2 Then
            Return "CHEQUE"
        ElseIf tPag = 3 Then
            Return "CARTAO DE CREDITO"
        ElseIf tPag = 4 Then
            Return "CARTAO DE DEBITO"
        ElseIf tPag = 5 Then
            Return "CREDITO LOJA"
        ElseIf tPag = 10 Then
            Return "VALE ALIMENTACAO"
        ElseIf tPag = 11 Then
            Return "VALE REFEICAO"
        ElseIf tPag = 12 Then
            Return "VALE PRESENTE"
        ElseIf tPag = 13 Then
            Return "VALE COMBUSTIVEL"
        Else
            Return "OUTROS"
        End If
    End Function
    ''' <summary>
    ''' Imprime um texto nas coordenadas ou no local 
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <remarks></remarks>
    Private Sub pOut(ByVal txt As String, Optional ByVal x As String = "", Optional ByVal y As String = "")
        If Not x.Trim = "" Then
            p.CurrentX = Val(x) + 50
        Else
            p.CurrentX = Val(50)
        End If
        If Not y.Trim = "" Then
            p.CurrentY = Val(y)
        End If

        p.Print(txt)
    End Sub

End Class
