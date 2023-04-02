Imports System.Xml
Imports System.Text

Public Class Cupom
    Private _nfce As NFCe
    Private _itemId As Integer = 0
    Private nomeTXT As String
    
    Public Sub New()
        _nfce = New NFCe
        iniciarNFCe()
        iniciaCupomTXT()

    End Sub
    Public ReadOnly Property nfce As NFCe
        Get
            Return Me._nfce
        End Get
    End Property

    Private Sub iniciarNFCe()
       

        nfce.versao = "4.00"
        nfce.infNFE.Ide.cUF = strIBGEEstado

        nfce.infNFE.Ide.natOp = "VENDAS"
        nfce.infNFE.ide.indPag = "2"

        'If modalidadeNT = 0 Then
        '    nfce.infNFE.ide.[mod] = "65"
        'ElseIf modalidadeNT = 1 Then
        nfce.infNFE.ide.[mod] = ""
        'ElseIf modalidadeNT = 2 Then
        '    nfce.infNFE.ide.[mod] = "P"
        'End If




        nfce.infNFE.ide.serie = nfeSerie

        nfce.infNFE.ide.tpEmis = "1"
        nfce.infNFE.ide.tpAmb = strAmbiente '1 - Producao / 2 - homologacao


        'nfce.infNFE.Ide.dhEmi = Format(Now, "yyyy-MM-ddTHH:mm:ss") & "-03:00"
        'nfce.infNFE.Ide.dSaiEnt = nfce.infNFE.Ide.dhEmi
        nfce.infNFE.ide.tpNF = 1
        nfce.infNFE.ide.idDest = "1"
        nfce.infNFE.ide.cMunFG = strIBGEEstado + strIBGECidade
        nfce.infNFE.ide.tpImp = 4

        nfce.infNFE.ide.finNFe = "1"
        nfce.infNFE.ide.indFinal = "1"
        nfce.infNFE.ide.indPres = "1"
        nfce.infNFE.ide.procEmi = "0"
        nfce.infNFE.ide.verProc = My.Application.Info.Version.ToString

        nfce.infNFE.emit.CNPJ = strCNPJ
        nfce.infNFE.emit.xNome = strRazao
        nfce.infNFE.emit.xFant = strFantasia
        nfce.infNFE.emit.IE = strIE
        'Modificar CRT pelas modalidades existentes
        'Para isso o cadastro do emissor deve ser mexido
        nfce.infNFE.emit.CRT = IIf(strCRT = "SIMPLES", 1, 3)

        nfce.infNFE.emit.enderEmit.xLgr = strEnd
        nfce.infNFE.emit.enderEmit.nro = strNunero
        nfce.infNFE.emit.enderEmit.xBairro = strBairro
        nfce.infNFE.emit.enderEmit.cMun = strIBGEEstado + strIBGECidade
        nfce.infNFE.emit.enderEmit.xMun = strCidade
        nfce.infNFE.emit.enderEmit.UF = strUF
        nfce.infNFE.emit.enderEmit.CEP = Util.rs(strCEP)
        nfce.infNFE.emit.enderEmit.cPais = 1058
        nfce.infNFE.emit.enderEmit.xPais = "BRASIL"
        nfce.infNFE.emit.enderEmit.fone = Util.rs(strTel1)

        nfce.infNFE.transp = New transp()
        'modFrete: 9 - sem frete
        nfce.infNFE.transp.modFrete = "9"
        nfce.infNFE.infAdic = New infAdic
        nfce.infNFE.infAdic.infCpl = strMensagem

    End Sub

    Public Function vCupom() As String
        Return _nfce.infNFE.Total.IcmsTot.vNF()
    End Function

    Public Sub addDestinatario(ByVal cli As Cliente)
        Dim d As New dest

        If cli.cnpj.Trim.Length > 11 Then
            d.CNPJ = cli.cnpj
        Else
            d.CPF = cli.cnpj
        End If
        If _nfce.infNFE.ide.tpAmb = 2 Then
            d.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"
        Else
            d.xNome = cli.xNome
        End If


        d.EnderDest.xLgr = cli.xLgr
        d.EnderDest.nro = cli.nro
        d.EnderDest.xBairro = cli.xBairro
        d.EnderDest.cMun = cli.cMun
        d.EnderDest.xMun = cli.xMun
        d.EnderDest.UF = cli.uf
        d.enderDest.CEP = Util.rs(cli.cep)
        d.EnderDest.cPais = 1058
        d.enderDest.xPais = "BRASIL"
        d.indIEDest = 9
        d.IE = ""


        _nfce.infNFE.Dest = d


    End Sub
    Public Sub removerDestinatario()
        _nfce.infNFE.Dest = Nothing
    End Sub
    Public Function destinatario() As dest
        Return _nfce.infNFE.Dest
    End Function
    ''' <summary>
    ''' Remove o item da lista pelo pelo numero do item da fita
    ''' </summary>
    ''' <param name="nItem">Numero sequencial do item</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function removerItem(ByVal nItem As Integer) As Boolean

        Dim d As det
        'Varre todos os itens 
        For Each detalhe As det In _nfce.infNFE.Det
            If detalhe.nItem = nItem Then
                d = detalhe
                Exit For
            End If
        Next

        If IsNothing(d) Then
            MsgBox("Item inexistente ou ja excluido")
            Return False

        Else
            _nfce.infNFE.Det.Remove(d)
            calculaTotalNFCe()
            Return True
        End If


    End Function
    Public Sub addItem(prod As Produto, qtd As Double)
        Dim detalhamento As New det()

        _itemId += 1

        detalhamento.nItem = _itemId
        detalhamento.Prod.cProd = prod.id
        If prod.codigoBarras.Length < 8 Then
            detalhamento.prod.cEAN = ""
            detalhamento.prod.cEANTrib = ""
        Else
            detalhamento.Prod.cEAN = prod.codigoBarras
            detalhamento.Prod.cEANTrib = prod.codigoBarras
        End If
        detalhamento.Prod.NCM = prod.ncm
        detalhamento.Prod.xProd = prod.descricao
        detalhamento.Prod.CFOP = prod.cfop
        detalhamento.Prod.uCom = prod.unidade
        detalhamento.Prod.qCom = qtd
        detalhamento.Prod.vUnCom = prod.precoVenda


        detalhamento.prod.vProd = qtd * prod.precoVenda

        ' detalhamento.prod.vProd = detalhamento.prod.vProd


        detalhamento.Prod.uTrib = prod.unidade
        detalhamento.Prod.qTrib = qtd
        detalhamento.Prod.vUnTrib = prod.precoVenda

        'detalhamento.Prod.vDesc = 0
        'detalhamento.Prod.vFrete = 0
        'detalhamento.Prod.vSeg = 0
        detalhamento.Prod.indTot = "1"


        detalhamento.Imposto.Icms = New ICMS()
        detalhamento.imposto.ICMS.ICMSSN102 = New ICMSSN102()
        detalhamento.imposto.ICMS.ICMSSN102.CSOSN = "102"
        detalhamento.imposto.ICMS.ICMSSN102.orig = "0"


        detalhamento.Imposto.Pis = New PIS()
        detalhamento.Imposto.Pis.PisAliq = New PISAliq()
        detalhamento.Imposto.Pis.PisAliq.CST = "01"
        detalhamento.Imposto.Pis.PisAliq.vBC = 0
        detalhamento.Imposto.Pis.PisAliq.pPIS = 0
        detalhamento.Imposto.Pis.PisAliq.vPIS = 0


        detalhamento.Imposto.Cofins = New COFINS()
        detalhamento.Imposto.Cofins.CofinsAliq = New COFINSAliq()
        detalhamento.Imposto.Cofins.CofinsAliq.CST = "01"
        detalhamento.Imposto.Cofins.CofinsAliq.vBC = 0
        detalhamento.Imposto.Cofins.CofinsAliq.pCOFINS = 0
        detalhamento.Imposto.Cofins.CofinsAliq.vCOFINS = 0

        _nfce.infNFE.Det.Add(detalhamento)

        calculaTotalNFCe()

        'Adicionar item ao txt
        Dim txt As String
        txt = prod.id & "|" & qtd & "|" & prod.precoVenda
        Util.escreverTXT(nomeTXT, txt)
    End Sub
    Public Function countItens() As Integer
        Return _nfce.infNFE.Det.Count
    End Function
    'Private Function pgValorIbpt(p As prod) As Double

    '    Dim vlTrib As Double
    '    Dim ibpt As New Ibpt
    '    Dim ibptDAO As New IbptDAO


    '    ibpt = ibptDAO.pgIbpt(p.NCM)

    '    vlTrib = ibpt.nacionalFederal * p.vProd / 100

    '    vlTrib = System.Math.Round(vlTrib, 2)
    '    Return vlTrib

    'End Function
    Private Sub calculaTotalNFCe()

        Dim vProd As Double = 0
        'Dim vTotTrib As Double = 0

        'Varre todos os itens e soma na variavel vProd
        For Each detalhe As det In _nfce.infNFE.Det
            vProd += detalhe.prod.vProd
            'vTotTrib += pgValorIbpt(detalhe.prod)
        Next
        '************************************************************************
        'Calcular os totais da NFCe

        _nfce.infNFE.Total.IcmsTot.vBC = 0
        _nfce.infNFE.total.ICMSTot.vBCST = 0
        _nfce.infNFE.total.ICMSTot.vICMS = 0
        _nfce.infNFE.total.ICMSTot.vICMSDeson = 0

        _nfce.infNFE.Total.IcmsTot.vST = 0

        _nfce.infNFE.Total.IcmsTot.vProd = vProd

        _nfce.infNFE.Total.IcmsTot.vFrete = 0
        _nfce.infNFE.Total.IcmsTot.vSeg = 0
        _nfce.infNFE.Total.IcmsTot.vDesc = 0
        _nfce.infNFE.Total.IcmsTot.vII = 0
        _nfce.infNFE.Total.IcmsTot.vIPI = 0
        _nfce.infNFE.Total.IcmsTot.vPIS = 0
        _nfce.infNFE.Total.IcmsTot.vCOFINS = 0
        _nfce.infNFE.Total.IcmsTot.vOutro = 0

        '_nfce.infNFE.total.ICMSTot.vTotTrib = vTotTrib

        _nfce.infNFE.total.ICMSTot.vNF = vProd
    End Sub
    Public Sub addPagamento(ByVal pags As List(Of pag))
        'Dim cobranca As New cobr()

        'Dim DUPLICATA As New dup
        'DUPLICATA.dVenc = DateTime.Now.AddDays(+30)
        'DUPLICATA.nDup = "6001"
        'DUPLICATA.vDup = 2500
        '
        'cobranca.pag.Add(pag)


        'DUPLICATA = New dup
        'DUPLICATA.dVenc = DateTime.Now.AddDays(+60)
        'DUPLICATA.nDup = "6001"
        'DUPLICATA.vDup = 2500
        '
        'cobranca.Dup.Add(DUPLICATA)
        '_nfce.infNFE.Cobr = cobranca
        _nfce.infNFE.pag = pags

    End Sub

    Public Function item(id As Integer) As prod
        Return _nfce.infNFE.Det(id).Prod
    End Function
    ''' <summary>
    ''' Gera o nome pra gravar o txt
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub iniciaCupomTXT()
        nomeTXT = Application.StartupPath & "\" & Util.rs(Now()) & ".txt"
    End Sub
End Class
