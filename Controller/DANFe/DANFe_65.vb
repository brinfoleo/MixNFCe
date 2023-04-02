Imports System.Drawing.Printing
Imports MessagingToolkit.QRCode.Codec
Imports System.Security.Cryptography

Public Class DANFe_65
    'Declaração das fontes
    Private Font12_B As New Font("Times New Roman", 12, FontStyle.Bold)
    Private Font12 As New Font("Times New Roman", 12, FontStyle.Regular)
    Private Font6 As New Font("Times New Roman", 6, FontStyle.Regular)
    Private Font6_Courier As New Font("Courier New", 6, FontStyle.Regular)
    Private Font6_B As New Font("Times New Roman", 6, FontStyle.Bold)
    Private Font5 As New Font("Times New Roman", 5, FontStyle.Regular)
    Private Font5_B As New Font("Courier New", 5, FontStyle.Bold)
    Private Font12_S As New Font("Times New Roman", 12, FontStyle.Underline)
    Private Font8 As New Font("Times New Roman", 8, FontStyle.Regular)
    Private Font7 As New Font("Times New Roman", 7, FontStyle.Regular)
    Private Font10 As New Font("Times New Roman", 10, FontStyle.Regular)
    Private Font10_B As New Font("Times New Roman", 10, FontStyle.Bold)
    Private Font10_S As New Font("Times New Roman", 10, FontStyle.Underline)
    Private Font8_B As New Font("Times New Roman", 8, FontStyle.Bold)
    'Declaracao da nfce
    Private _nfce As New NFe
    'String com a CSC sendo as 6 primeiras posicoes o id e restante codigo
    Private _csc As String
    'Visualizr ou imprimir direto o documento
    Private visualizar As Boolean = False
    Public Property nfce As NFe
        Get
            Return _nfce
        End Get
        Set(ByVal value As NFe)
            _nfce = value
        End Set
    End Property

    
    Public Property preview() As Boolean
        Get
            Return visualizar
        End Get
        Set(ByVal value As Boolean)
            visualizar = value
        End Set
    End Property
    Public Property csc As String
        Get
            Return _csc
        End Get
        Set(ByVal value As String)
            _csc = value
        End Set
    End Property
    Public Sub Imprimir()

        Dim Prv_Visualizador As New PrintPreviewDialog
        Dim Doc_VisualizarDanfe As New PrintDocument
        Dim Prn_Dialogo As New PrintDialog


        'ASSOCIA OS EVENTOS DE IMPRESSÃO COM MINHAS FUNÇÕES
        'AddHandler Doc_VisualizarDanfe.BeginPrint, AddressOf InicioImpressao
        AddHandler Doc_VisualizarDanfe.PrintPage, AddressOf montarDanfe

        Prv_Visualizador.FormBorderStyle = FormBorderStyle.Fixed3D
        Prv_Visualizador.WindowState = FormWindowState.Maximized


        'Coloca a folha na vertical
        Doc_VisualizarDanfe.DefaultPageSettings.Landscape = False

        'Não esta dimencionando o tamanho do papel
        'Doc_VisualizarDanfe.DefaultPageSettings.PaperSize.Height = "200"


        Doc_VisualizarDanfe.OriginAtMargins = False

        'Numero de copias
        If _nfce.infNFe.ide.tpEmis = 9 Then
            'Em contigencia obrigatoria impressao de 2 vias
            Doc_VisualizarDanfe.PrinterSettings.Copies = 2
        Else
            Doc_VisualizarDanfe.PrinterSettings.Copies = 1
        End If

        'AS MARGENS PRECISAM SER AJUSTADAS PARA QUE A IMPRESSÃO INICIAL TENHA 5 MILIMETROS
        'Doc_VisualizarDanfe.DefaultPageSettings.Margins = New Printing.Margins(11, 11, 11, 11)

        Prv_Visualizador.Document = Doc_VisualizarDanfe
        'MsgBox(_nfce.Signature.Id)
        'Visuzaliza a tela (preview)


        If visualizar Then
            Prv_Visualizador.ShowDialog()
        Else

            Prv_Visualizador.Document.Print()

        End If
        'Fecha a funcao
        Prv_Visualizador.Close()
        Prv_Visualizador.Dispose()



    End Sub


    Private Sub montarDanfe(ByVal sender As Object, ByVal Gra_Saida As System.Drawing.Printing.PrintPageEventArgs)

        Dim ln As Integer = 5

        Dim pen As New Pen(Brushes.Black, 0.3)
        Gra_Saida.Graphics.PageUnit = GraphicsUnit.Millimeter


        'Registro I
        ln += 3 : Gra_Saida.Graphics.DrawString(_nfce.infNFe.emit.xNome, Font8_B, Brushes.Black, 2, ln)
        ln += 3 : Gra_Saida.Graphics.DrawString("CNPJ: " & _nfce.infNFe.emit.CNPJ & "  I.E.: " & _nfce.infNFe.emit.IE, Font8, Brushes.Black, 2, ln)

        Dim endereco As String
        endereco = _nfce.infNFe.emit.enderEmit.xLgr & " " & _
                   _nfce.infNFe.emit.enderEmit.nro & " " & _
                   _nfce.infNFe.emit.enderEmit.xCpl & " " & _
                   _nfce.infNFe.emit.enderEmit.xBairro
        ln += 3 : Gra_Saida.Graphics.DrawString("End.: " & endereco, Font8, Brushes.Black, 2, ln)

        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 4 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

        'Registro II
        ln += 2 : Gra_Saida.Graphics.DrawString("DANFE NFC-e - Documento Auxiliar", Font10_B, Brushes.Black, 10, ln)
        ln += 5 : Gra_Saida.Graphics.DrawString("da Nota Fiscal de Consumidor Eletrônica", Font10_B, Brushes.Black, 7, ln)

        ln += 4 : Gra_Saida.Graphics.DrawString("Não permite aproveitamento de crédito", Font10, Brushes.Black, 10, ln)
        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 5 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

        'registro III

        Dim strFormat As New StringFormat
        strFormat.Alignment = StringAlignment.Far
        strFormat.LineAlignment = StringAlignment.Far

        For Each p As det In _nfce.infNFe.det
            ln += 4 : Gra_Saida.Graphics.DrawString(p.nItem.ToString.PadLeft(3, "0") & "  " & _
                                          p.prod.xProd, _
                                          Font8, Brushes.Black, 2, ln)


            ln += 4 : Gra_Saida.Graphics.DrawString(p.prod.uCom & "  " & _
                                        FormatNumber(p.prod.qCom) & " x " & _
                                        FormatNumber(p.prod.vUnCom), _
                                        Font8, Brushes.Black, 8, ln)


            Gra_Saida.Graphics.DrawString(FormatNumber(p.prod.vProd), Font8, Brushes.Black, New RectangleF(42, ln - 12, 30, Font10.Height), strFormat)
        Next
        
        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

        'Registro IV
        ln += 3 : Gra_Saida.Graphics.DrawString("Qtd. Total de Itens: ", Font10, Brushes.Black, 2, ln)                       '|AQUI ERA 45, COLOQUEI PARA 42 PORQUE O VALOR TOTAL ESTAVA CORTANTO, FIZ ISSO EM TUDO AONDE ESTAVA 45-EDUARDO SILVA 04/03/2015
        Gra_Saida.Graphics.DrawString(_nfce.infNFe.det.Count.ToString.PadLeft(5, "0"), Font10, Brushes.Black, New RectangleF(42, ln - 11, 30, Font10.Height), strFormat)

        ln += 4 : Gra_Saida.Graphics.DrawString("Valor Total: ", Font12_B, Brushes.Black, 2, ln)
        Gra_Saida.Graphics.DrawString(FormatNumber(_nfce.infNFe.total.ICMSTot.vNF.ToString.Replace(".", ".")), Font12_B, Brushes.Black, New RectangleF(42, ln - 13, 30, Font12_B.Height), strFormat)

        ln += 5 : Gra_Saida.Graphics.DrawString("FORMA PAGAMENTO", Font8, Brushes.Black, 2, ln)
        For Each p As pag In _nfce.infNFe.pag
            ln += 3 : Gra_Saida.Graphics.DrawString(pgNomeTipoPagamento(p.tPag), Font8, Brushes.Black, 2, ln)
            Gra_Saida.Graphics.DrawString(FormatNumber(p.vPag.ToString.Replace(".", ",")), Font8, Brushes.Black, New RectangleF(42, ln - 11, 30, Font8.Height), strFormat)
        Next

        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

        'Registro V
        ln += 3 : Gra_Saida.Graphics.DrawString("Informação dos Tributos Totais Incidentes", Font8, Brushes.Black, 2, ln)
        ln += 3 : Gra_Saida.Graphics.DrawString("       (Lei Federal 12.741/2012)", Font8, Brushes.Black, 2, ln)
        Gra_Saida.Graphics.DrawString(FormatCurrency(_nfce.infNFe.total.ICMSTot.vTotTrib.ToString.Replace(".", ",")), Font8, Brushes.Black, New RectangleF(42, ln - 11, 30, Font8.Height), strFormat)
        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)
  
        'REGISTRO VI
        ln += 3 : Gra_Saida.Graphics.DrawString("Número: " & _nfce.infNFe.ide.nNF.ToString.PadLeft(6, "0") & " Série: " & _nfce.infNFe.ide.serie & " Emissão: " & Mid(_nfce.infNFe.ide.dhEmi, 1, _nfce.infNFe.ide.dhEmi.Length - 6), Font8, Brushes.Black, 3, ln)
        ln += 4 : Gra_Saida.Graphics.DrawString("Consulte pela chave de acesso em ", Font8, Brushes.Black, 15, ln)
        ln += 3 : Gra_Saida.Graphics.DrawString("http://nfce.fazenda.rj.gov.br/consulta", Font8, Brushes.Black, 13, ln)
        ln += 5 : Gra_Saida.Graphics.DrawString("CHAVE DE ACESSO", Font10, Brushes.Black, 20, ln)
        ln += 5 : Gra_Saida.Graphics.DrawString(Mid(_nfce.infNFe.Id, 4, _nfce.infNFe.Id.Length), Font8_B, Brushes.Black, 5, ln)

        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

        'Registro VII - Dados do Comprador
        If IsNothing(_nfce.infNFe.dest) Then
            ln += 3 : Gra_Saida.Graphics.DrawString("VENDA AO CONSUMIDOR", Font8, Brushes.Black, 15, ln)
        Else
            Dim cliDoc As String
            cliDoc = IIf(_nfce.infNFe.dest.CNPJ = Nothing, _nfce.infNFe.dest.CPF, _nfce.infNFe.dest.CNPJ)
            ln += 3 : Gra_Saida.Graphics.DrawString(cliDoc, Font6, Brushes.Black, 5, ln)
            ln += 3 : Gra_Saida.Graphics.DrawString(_nfce.infNFe.dest.xNome, Font6, Brushes.Black, 5, ln)
        End If
        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

        'Registro VII
        ln += 3 : Gra_Saida.Graphics.DrawString("Consulta via leitor de QR Code", Font8, Brushes.Black, 17, ln)

        'Imprime o QRCode
        ln += 4 : Gra_Saida.Graphics.DrawImage(qrCode, 20, ln, 30, 30)

        'Protocolo de autorizacao
        'tpEmis=9 : NFCe Gerado em contigencia
        If _nfce.infNFe.ide.tpEmis = 9 Then
            ln += 33 : Gra_Saida.Graphics.DrawString("EMITIDA EM CONTINGENCIA", Font8, Brushes.Black, 17, ln)
        Else
            ln += 33 : Gra_Saida.Graphics.DrawString("Protocolo de Autorização: " & _nfce.protNFe.infProt.nProt, Font8, Brushes.Black, 10, ln)
        End If

        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)
        'RegistrO Va
        Try
            ln += 3 : Gra_Saida.Graphics.DrawString(_nfce.infNFe.infAdic.infCpl, Font8, Brushes.Black, 2, ln)
        Catch
        End Try
        'Linha, onde: Xi,Yi,Xf,Yf
        ln += 6 : Gra_Saida.Graphics.DrawLine(pen, 2, ln, 74, ln)

       

    End Sub
    Private Function qrCode() As Bitmap


        Dim strDadosQRCode As String 'Armazena o texto sera impresso no qrCode
        Dim q As New QRCodeEncoder
        Dim qb As Bitmap

        'Identificador CSC/Token (6 digitod)
        'Dim idCSC As String = "000002"
        Dim idCSC As String = Mid(_csc, 1, 6)
        'CSC - Codigo de seguranca do contribuinte
        Dim cldToken As String = Mid(_csc, 7, _csc.Length)
        Try


            'chNFe 
            strDadosQRCode = "chNFe=" & Right(_nfce.infNFe.Id, 44)

            'aVersao 
            strDadosQRCode += "&nVersao=" & "100" 'q.QRCodeVersion.ToString
            'tpamb 
            strDadosQRCode += "&tpAmb=" & _nfce.infNFe.ide.tpAmb
            'cnpjDest 
            Dim sDoc As String
            If Not IsNothing(_nfce.infNFe.dest) Then
                If _nfce.infNFe.dest.CNPJ <> Nothing Then
                    sDoc = _nfce.infNFe.dest.CNPJ
                ElseIf _nfce.infNFe.dest.CPF <> Nothing Then
                    sDoc = _nfce.infNFe.dest.CPF
                Else
                    sDoc = ""

                End If
            Else
                sDoc = ""
            End If

            strDadosQRCode += "&cDest=" & sDoc
            'dhemi 
            strDadosQRCode += "&dhEmi=" & convertHexadecimal(_nfce.infNFe.ide.dhEmi)
            'vNF '
            strDadosQRCode += "&vNF=" & _nfce.infNFe.total.ICMSTot.vNF
            'vICMS 
            strDadosQRCode += "&vICMS=" & _nfce.infNFe.total.ICMSTot.vICMS
            'digVal 
            If Not IsNothing(_nfce.protNFe.infProt.digVal) Then
                strDadosQRCode += "&digVal=" & convertHexadecimal(_nfce.protNFe.infProt.digVal)
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
    Private Function pgNomeTipoPagamento(tPag As Integer) As String
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
End Class