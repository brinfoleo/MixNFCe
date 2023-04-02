Imports System.Xml
Imports System.Text

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim teste As New NFCe()
        'Dim DtMed As med

        teste.versao = "1.10"

        teste.infNFE.Ide.cUF = 43
        teste.infNFE.Ide.cNF = "000001521"
        teste.infNFE.Ide.natOp = "VENDAS DE MERCADORIA PARA TERCEIROS"
        teste.infNFE.Ide.indPag = "1"
        teste.infNFE.Ide.[mod] = "55"
        teste.infNFE.Ide.serie = "1"
        teste.infNFE.Ide.nNF = "65619"
        teste.infNFE.Ide.dhEmi = DateTime.Now.AddDays(-1)
        teste.infNFE.Ide.dSaiEnt = DateTime.Now.AddDays(-1)
        teste.infNFE.Ide.tpNF = 1
        teste.infNFE.Ide.cMunFG = 4314902
        teste.infNFE.Ide.tpImp = 1
        teste.infNFE.Ide.tpEmis = "1"
        teste.infNFE.Ide.tpAmb = 2
        teste.infNFE.Ide.finNFe = "1"
        teste.infNFE.Ide.procEmi = "0"
        teste.infNFE.Ide.verProc = "1.10"

        teste.infNFE.Emit.CNPJ = "14444653000174"
        teste.infNFE.Emit.xNome = "BRINFO"
        teste.infNFE.Emit.xFant = "NOME FANTASIA"
        teste.infNFE.Emit.IE = "88999000"

        Dim _codUF As String = teste.infNFE.Ide.cUF.ToString()
        Dim _dEmi As String = teste.infNFE.Ide.dhEmi.ToString("yyMM")
        Dim _cnpj As String = Funcoes.removeFormatacao(teste.infNFE.Emit.CNPJ)
        Dim _mod As String = teste.infNFE.Ide.[mod]

        Dim _serie As String = String.Format("{0:000}", Int32.Parse(teste.infNFE.Ide.serie))
        Dim _numNF As String = String.Format("{0:000000000}", Int32.Parse(teste.infNFE.Ide.nNF))
        Dim _codigo As String = String.Format("{0:000000000}", Int32.Parse(teste.infNFE.Ide.cNF))
        Dim chaveNF As String = _codUF + _dEmi + _cnpj + _mod + _serie + _numNF + _codigo
        Dim _dv As Integer = Funcoes.modulo11(chaveNF)

        teste.Id = chaveNF + _dv.ToString()
        teste.infNFE.Ide.cDV = _dv.ToString()
        'MessageBox.Show("ID: " + teste.Id.ToString());


        teste.infNFE.Emit.EnderEmit.xLgr = "Rua da Empresa"
        teste.infNFE.Emit.EnderEmit.nro = "1064"
        teste.infNFE.Emit.EnderEmit.xBairro = "Bairro"
        teste.infNFE.Emit.EnderEmit.cMun = 4314902
        teste.infNFE.Emit.EnderEmit.xMun = "Porto Alegre"
        teste.infNFE.Emit.EnderEmit.UF = "RS"
        teste.infNFE.Emit.EnderEmit.CEP = "Cep"
        teste.infNFE.Emit.EnderEmit.cPais = 1058
        teste.infNFE.Emit.EnderEmit.xPais = "BRASIL"
        teste.infNFE.Emit.EnderEmit.fone = "telefone"

        teste.infNFE.Dest.CNPJ = "dada"
        teste.infNFE.Dest.xNome = "hospital"
        teste.infNFE.Dest.EnderDest.xLgr = "rua"
        teste.infNFE.Dest.EnderDest.nro = "6690"
        teste.infNFE.Dest.EnderDest.xBairro = "Bairro"
        teste.infNFE.Dest.EnderDest.cMun = 4314902
        teste.infNFE.Dest.EnderDest.xMun = "Porto Alegre"
        teste.infNFE.Dest.EnderDest.UF = "RS"
        teste.infNFE.Dest.EnderDest.CEP = "90600000"
        teste.infNFE.Dest.EnderDest.cPais = 1058
        teste.infNFE.Dest.EnderDest.xPais = "BRASIL"
        teste.infNFE.Dest.IE = ""

        Dim detalhamento As New det()
        detalhamento.nItem = 1
        detalhamento.Prod.cProd = "prod1"
        detalhamento.Prod.cEAN = ""
        detalhamento.Prod.cEANTrib = ""
        detalhamento.Prod.xProd = "nome do produto"
        detalhamento.Prod.CFOP = "5102"
        detalhamento.Prod.uCom = "UN"
        detalhamento.Prod.qCom = 2
        detalhamento.Prod.vUnCom = 2500
        detalhamento.Prod.vProd = 5000
        detalhamento.Prod.uTrib = "UN"
        detalhamento.Prod.qTrib = 1
        detalhamento.Prod.vUnTrib = 2500

        'DtMed = New med
        'DtMed.nLote = "123656"
        'DtMed.qLote = 1
        'DtMed.dFab = DateTime.Now
        'DtMed.dVal = DateTime.Now
        'DtMed.vPMC = Decimal.Parse(2500)

        'detalhamento.Prod.Med.Add(DtMed)

        'DtMed = New med
        'DtMed.nLote = "551234"
        'DtMed.qLote = 1
        'DtMed.dFab = DateTime.Now
        'DtMed.dVal = DateTime.Now
        'DtMed.vPMC = Decimal.Parse(2500)

        'detalhamento.Prod.Med.Add(DtMed)

        detalhamento.Imposto.Icms = New ICMS()
        detalhamento.Imposto.Icms.Icms00 = New CSOSN102()
        detalhamento.Imposto.Icms.Icms00.csosn = "102"
        detalhamento.Imposto.Icms.Icms00.orig = "0"
        'detalhamento.Imposto.Icms.Icms00.modBC = "0"
        'detalhamento.Imposto.Icms.Icms00.vBC = 0
        'detalhamento.Imposto.Icms.Icms00.pICMS = 0
        'detalhamento.Imposto.Icms.Icms00.vICMS = 0

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

        teste.infNFE.Det.Add(detalhamento)

        detalhamento = New det()
        detalhamento.nItem = 2
        detalhamento.Prod.cProd = "prod2"
        detalhamento.Prod.cEAN = ""
        detalhamento.Prod.cEANTrib = ""
        detalhamento.Prod.xProd = "nome do produto"
        detalhamento.Prod.CFOP = "5102"
        detalhamento.Prod.uCom = "UN"
        detalhamento.Prod.qCom = 2
        detalhamento.Prod.vUnCom = 2500
        detalhamento.Prod.vProd = 5000
        detalhamento.Prod.uTrib = "UN"
        detalhamento.Prod.qTrib = 1
        detalhamento.Prod.vUnTrib = 2500

        'DtMed = New med
        'DtMed.nLote = "123656"
        'DtMed.qLote = 1
        'DtMed.dFab = DateTime.Now
        'DtMed.dVal = DateTime.Now
        'DtMed.vPMC = Decimal.Parse(2500)

        'detalhamento.Prod.Med.Add(DtMed)

        detalhamento.Imposto.Icms = New ICMS()
        detalhamento.Imposto.Icms.Icms00 = New CSOSN102()
        detalhamento.Imposto.Icms.Icms00.csosn = "102"
        detalhamento.Imposto.Icms.Icms00.orig = "0"
        
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

        teste.infNFE.Det.Add(detalhamento)

        teste.infNFE.Total = New total()
        teste.infNFE.Total.IcmsTot = New ICMSTot()
        teste.infNFE.Total.IcmsTot.vBC = 0
        teste.infNFE.Total.IcmsTot.vBCST = 0
        teste.infNFE.Total.IcmsTot.vST = 0
        teste.infNFE.Total.IcmsTot.vProd = 5000
        teste.infNFE.Total.IcmsTot.vFrete = 0
        teste.infNFE.Total.IcmsTot.vSeg = 0
        teste.infNFE.Total.IcmsTot.vDesc = 0
        teste.infNFE.Total.IcmsTot.vII = 0
        teste.infNFE.Total.IcmsTot.vIPI = 0
        teste.infNFE.Total.IcmsTot.vPIS = 0
        teste.infNFE.Total.IcmsTot.vCOFINS = 0
        teste.infNFE.Total.IcmsTot.vOutro = 0
        teste.infNFE.Total.IcmsTot.vNF = 5000

        teste.infNFE.Transp = New transp()
        teste.infNFE.Transp.modFrete = "0"

        Dim cobranca As New cobr()

        Dim DUPLICATA As New dup
        DUPLICATA.dVenc = DateTime.Now.AddDays(+30)
        DUPLICATA.nDup = "6001"
        DUPLICATA.vDup = 2500

        cobranca.Dup.Add(DUPLICATA)


        DUPLICATA = New dup
        DUPLICATA.dVenc = DateTime.Now.AddDays(+60)
        DUPLICATA.nDup = "6001"
        DUPLICATA.vDup = 2500

        cobranca.Dup.Add(DUPLICATA)
        teste.infNFE.Cobr = cobranca

        'Gera o XML
        Dim xmlGerado As XmlDocument = teste.GerarXML()
        'Salva uma cópia do XML não assinado - ATENÇÃO - se você está utilizando Windows Vista/7/Server, salvar na Unidade C pode não ser possível caso o VS2008 não esteja rodando como administrador
        xmlGerado.Save(Application.StartupPath & "\testeXMLNaoAssinado.xml")
        'Seleciona o certificado
        'Dim certificado As X509Certificate2 = CertificadoDigital.SelecionarCertificado("")

        'assina o xml
        'Dim xmlAssinado As XmlDocument = CertificadoDigital.Assinar(xmlGerado, "infNFe", certificado)

        'Valida o XML assinado
        'Dim resultado As String = ValidaXML.ValidarXML(xmlAssinado, "nfe_v1.10.xsd")

        'If resultado.Trim().Length = 0 Then
        ' resultado = "Xml gerado com sucesso, nenhum erro encontrado"
        'End If

        'Opcional - Função para gerar o Lote e deixar o arquivo pronto para ser enviado.
        'teste.GerarLoteNfe(xmlAssinado)

        'Importante:
        'Salvar através do TextWriter evita que o XML saia formatado no arquivo, desta forma o mesmo
        'pode ser rejeitado por alguns estados e/ou não validar nos programas teste
        Using xmltw As New XmlTextWriter("C:\testeXML.xml", New UTF8Encoding(False))
            'xmlAssinado.WriteTo(xmltw)
            xmltw.Close()
        End Using

        'TextBox1.Text = resultado
        TextBox1.Text = "*** FIM do PROCESSO ***"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
    End Sub
End Class