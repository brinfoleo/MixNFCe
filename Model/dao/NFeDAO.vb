Imports System.Data.SQLite

Public Class NFeDAO
    'Conexao ao BD
    'Private cn As ConnectionFactory
    'Private cmd As SQLiteCommand
    Private _nfe As NFCe

    Public Sub New()
        'cn = New ConnectionFactory
        'cmd = New SQLiteCommand
    End Sub
    Public Sub salvar(ByVal objNFe As NFCe)
        _nfe = objNFe
        create()
    End Sub
    Private Function create() As Boolean
        gravarNFe()
        gravarPagamentos()
        gravarItens()
        baixarEstoque()
        Return True
    End Function

    Private Sub gravarNFe()
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "INSERT INTO nfce "
        sql += "(dthr,usuid, versao, ide_tpEmis,"
        'ide
        sql += "ide_mod, ide_serie, ide_nNF, ide_dhEmi,"
        sql += "ide_tpAmb, ide_finNFe,"
        sql += "ide_cUF, ide_cNF,"
        sql += "ide_natOp, ide_indPag,"
        sql += "ide_tpNF, ide_idDest,"
        sql += "ide_cMunFG, ide_tpImp,"
        sql += "ide_cDV, ide_indFinal,"
        sql += "ide_indPres, ide_procEmi,"
        sql += "ide_verProc, ide_dhCont,"
        sql += "ide_xJust,idnfe,"


        'Emitente
        sql += "emit_CNPJ,"
        sql += "emit_xNome,emit_xFant,"
        sql += "emit_xLgr,emit_nro,"
        sql += "emit_xCpl,emit_Bairro,"
        sql += "emit_cMun,emit_xMun,"
        sql += "emit_UF,emit_CEP,"
        sql += "emit_cPais,emit_xPais,"
        sql += "emit_fone,emit_IE,"
        sql += "emit_IEST,emit_IM,"
        sql += "emit_CNAE,emit_CRT,"


        'Destinatario
        If Not IsNothing(_nfe.infNFE.dest) Then
            'sql += "dest_pessoa,"
            sql += "dest_CNPJ,"
            sql += "dest_xNome,dest_xFant,"
            sql += "dest_xLgr,dest_nro,"
            sql += "dest_xCpl,dest_Bairro,"
            sql += "dest_cMun,dest_xMun,"
            sql += "dest_UF,dest_CEP,"
            sql += "dest_cPais,dest_xPais,"
            sql += "dest_fone,dest_IE,"
            sql += "dest_ISUF,dest_email,"

        End If

        'Totais
        sql += "total_vBC,total_vICMS,"
        sql += "total_vBCST,total_vICMSST,"
        sql += "total_vProd,total_vFrete,"
        sql += "total_vSeg,total_vDesc,"
        sql += "total_vIPI,total_vPIS,"
        sql += "total_vCOFINS,total_vOutro,"
        sql += "total_vNF,infAdic_infCpl,"
        sql += "digVal"

        sql += ") VALUES ("
        sql += "'" & Format(Today, "yyyy-MM-dd") & "'"
        sql += ",'" & usuarioOnLine.id & "'"
        sql += ",'" & _nfe.versao & "','" & _nfe.infNFE.ide.tpEmis & "'"
        'ide
        sql += ",'" & _nfe.infNFE.ide.mod & "','" & _nfe.infNFE.ide.serie & "'"
        sql += ",'" & _nfe.infNFE.ide.nNF & "','" & _nfe.infNFE.ide.dhEmi & "'"
        sql += ",'" & _nfe.infNFE.ide.tpAmb & "','" & _nfe.infNFE.ide.finNFe & "'"
        sql += ",'" & _nfe.infNFE.ide.cUF & "','" & _nfe.infNFE.ide.cNF & "'"
        sql += ",'" & _nfe.infNFE.ide.natOp & "','" & _nfe.infNFE.ide.indPag & "'"
        sql += ",'" & _nfe.infNFE.ide.tpNF & "','" & _nfe.infNFE.ide.idDest & "'"
        sql += ",'" & _nfe.infNFE.ide.cMunFG & "','" & _nfe.infNFE.ide.tpImp & "'"
        sql += ",'" & _nfe.infNFE.ide.cDV & "','" & _nfe.infNFE.ide.indFinal & "'"
        sql += ",'" & _nfe.infNFE.ide.indPres & "','" & _nfe.infNFE.ide.procEmi & "'"
        sql += ",'" & _nfe.infNFE.ide.verProc & "','" & _nfe.infNFE.ide.dhCont & "'"
        sql += ",'" & _nfe.infNFE.ide.xJust & "','" & _nfe.Id & "'"

        'Emitente
        sql += ",'" & _nfe.infNFE.emit.CNPJ & "'"
        sql += ",'" & _nfe.infNFE.emit.xNome & "','" & _nfe.infNFE.emit.xFant & "'"
        sql += ",'" & _nfe.infNFE.emit.enderEmit.xLgr & "','" & _nfe.infNFE.emit.enderEmit.nro & "'"
        sql += ",'" & _nfe.infNFE.emit.enderEmit.xCpl & "','" & _nfe.infNFE.emit.enderEmit.xBairro & "'"
        sql += ",'" & _nfe.infNFE.emit.enderEmit.cMun & "','" & _nfe.infNFE.emit.enderEmit.xMun & "'"
        sql += ",'" & _nfe.infNFE.emit.enderEmit.UF & "','" & _nfe.infNFE.emit.enderEmit.CEP & "'"
        sql += ",'" & _nfe.infNFE.emit.enderEmit.cPais & "','" & _nfe.infNFE.emit.enderEmit.xPais & "'"
        sql += ",'" & _nfe.infNFE.emit.enderEmit.fone & "','" & _nfe.infNFE.emit.IE & "'"
        sql += ",'" & _nfe.infNFE.emit.IEST & "','" & _nfe.infNFE.emit.IM & "'"
        sql += ",'" & _nfe.infNFE.emit.CNAE & "','" & _nfe.infNFE.emit.CRT & "'"

        'Destinatario
        If Not IsNothing(_nfe.infNFE.dest) Then
            'sql += "dest_pessoa,"
            If Not IsNothing(_nfe.infNFE.dest.CPF) Then
                sql += ",'" & _nfe.infNFE.dest.CPF.ToString.Trim & "'"
            Else
                sql += ",'" & _nfe.infNFE.dest.CNPJ.ToString.Trim & "'"
            End If
            sql += ",'" & _nfe.infNFE.dest.xNome & "',''"
            sql += ",'" & _nfe.infNFE.dest.enderDest.xLgr & "','" & _nfe.infNFE.dest.enderDest.nro & "'"
            sql += ",'" & _nfe.infNFE.dest.enderDest.xCpl & "','" & _nfe.infNFE.dest.enderDest.xBairro & "'"
            sql += ",'" & _nfe.infNFE.dest.enderDest.cMun & "','" & _nfe.infNFE.dest.enderDest.xMun & "'"
            sql += ",'" & _nfe.infNFE.dest.enderDest.UF & "','" & _nfe.infNFE.dest.enderDest.CEP & "'"
            sql += ",'" & _nfe.infNFE.dest.enderDest.cPais & "','" & _nfe.infNFE.dest.enderDest.xPais & "'"
            sql += ",'" & _nfe.infNFE.dest.enderDest.fone & "','" & _nfe.infNFE.dest.IE & "'"
            sql += ",'" & _nfe.infNFE.dest.ISUF & "','" & _nfe.infNFE.dest.email & "'"

        End If

        'Totais
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vBC).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vICMS).Trim & "'"
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vBCST).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vST).Trim & "'"
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vProd).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vFrete).Trim & "'"
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vSeg).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vDesc).Trim & "'"
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vIPI).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vPIS).Trim & "'"
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vCOFINS).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vOutro).Trim & "'"
        sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vNF).Trim & "','" & _nfe.infNFE.infAdic.ToString.Trim & "'"
        sql += ",'" & _nfe.digVal & "'"

        sql += ")"


            '        CREATE TABLE "nfce" (
            '	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
            '	`Id_Empresa`	TEXT,
            '	`DtHr`	TEXT,
            '	`nProt`	TEXT,
            '	`versao`	TEXT,
            '	`IdNFe`	TEXT,
            '	`ide_cUF`	TEXT,
            '	`ide_cNF`	TEXT,
            '	`ide_natOp`	TEXT,
            '	`ide_indPag`	TEXT,
            '	`ide_mod`	TEXT,
            '	`ide_serie`	TEXT,
            '	`ide_nNF`	TEXT,
            '	`ide_dhEmi`	TEXT,
            '	`ide_dSaiEnt`	TEXT,
            '	`ide_hSaiEnt`	TEXT,
            '	`ide_tpNF`	TEXT,
            '	`ide_cMunFG`	TEXT,
            '	`ide_refNFe`	TEXT,
            '	`ide_tpImp`	TEXT,
            '	`ide_tpEmis`	TEXT,
            '	`ide_cDV`	TEXT,
            '	`ide_tpAmb`	TEXT,
            '	`ide_finNFe`	TEXT,
            '	`ide_procEmi`	TEXT,
            '	`ide_verProc`	TEXT,
            '	`emit_CNPJ`	TEXT,
            '	`emit_xNome`	TEXT,
            '	`emit_xFant`	TEXT,
            '	`emit_xLgr`	TEXT,
            '	`emit_nro`	TEXT,
            '	`emit_xCpl`	TEXT,
            '	`emit_Bairro`	TEXT,
            '	`emit_cMun`	TEXT,
            '	`emit_xMun`	TEXT,
            '	`emit_UF`	TEXT,
            '	`emit_CEP`	TEXT,
            '	`emit_cPais`	TEXT,
            '	`emit_xPais`	TEXT,
            '	`emit_fone`	TEXT,
            '	`emit_IE`	TEXT,
            '	`emit_IEST`	TEXT,
            '	`emit_IM`	TEXT,
            '	`emit_CNAE`	TEXT,
            '	`emit_CRT`	TEXT,
            '	`dest_pessoa`	TEXT,
            '	`dest_CNPJ`	TEXT,
            '	`dest_xNome`	TEXT,
            '	`dest_xFant`	TEXT,
            '	`dest_xLgr`	TEXT,
            '	`dest_nro`	TEXT,
            '	`dest_xCpl`	TEXT,
            '	`dest_Bairro`	TEXT,
            '	`dest_cMun`	TEXT,
            '	`dest_xMun`	TEXT,
            '	`dest_UF`	TEXT,
            '	`dest_CEP`	TEXT,
            '	`dest_cPais`	TEXT,
            '	`dest_xPais`	TEXT,
            '	`dest_fone`	TEXT,
            '	`dest_IE`	TEXT,
            '	`dest_ISUF`	TEXT,
            '	`dest_email`	TEXT,
            '	`infAdic_infCpl`	TEXT,
            '	`transp_modFrete`	TEXT,
            '	`transp_CNPJ`	TEXT,
            '	`transp_xNome`	TEXT,
            '	`transp_IE`	TEXT,
            '	`transp_xEnder`	TEXT,
            '	`transp_xMun`	TEXT,
            '	`transp_UF`	TEXT,
            '	`transp_qVol`	TEXT,
            '	`transp_esp`	TEXT,
            '	`transp_marca`	TEXT,
            '	`transp_nVol`	TEXT,
            '	`transp_pesoL`	TEXT,
            '	`transp_pesoB`	TEXT,
            '	`total_vBC`	TEXT,
            '	`total_vICMS`	TEXT,
            '	`total_vBCST`	TEXT,
            '	`total_vICMSST`	TEXT,
            '	`total_vProd`	TEXT,
            '	`total_vFrete`	TEXT,
            '	`total_vSeg`	TEXT,
            '	`total_vDesc`	TEXT,
            '	`total_vIPI`	TEXT,
            '	`total_vPIS`	TEXT,
            '	`total_vCOFINS`	TEXT,
            '	`total_vOutro`	TEXT,
            '	`total_vNF`	TEXT,
            '	`ger_Vendedor`	TEXT,
            '	`UsuID`	TEXT,
            '	`MovEstoque`	TEXT,
            '	`MovFinanceiro`	TEXT,
            '	`NFDevolucao`	TEXT,
            '	`MovFisco`	TEXT,
            '	`total_vCredICMSSN`	TEXT,
            '	`retICMSST`	TEXT,
            '	`emit_id`	TEXT,
            '	`dest_idDest`	TEXT,
            '	`ide_idDest`	TEXT,
            '	`ide_indFinal`	TEXT,
            '	`ide_indPres`	TEXT,
            '	`ide_dhCont`	TEXT,
            '	`ide_xJust`	TEXT
            ')


            Try
                Dim cnx As New Conexao
                Dim cd As New SQLiteCommand()

                cnx.Conectar()
                cd.Connection = cnx.c
                cd.CommandText = sql
                cd.ExecuteNonQuery()
                cd.Dispose()
                cnx.Desconectar()


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - gravarNFe")
            Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try
            'cn.getConnection.Close()
    End Sub
    Private Sub gravarItens()
        Dim sql As String
        'gravar os pagamento
        For Each p As det In _nfe.infNFE.Det

            '          CREATE TABLE `nfce_itens` (
            '`Id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
            '`Id_Empresa` TEXT,
            '`DtHr` TEXT,
            '`IdNFe` TEXT,

            '`ICMS_origem` TEXT,
            '`ICMS_CST` TEXT,
            '`ICMS_modBC` TEXT,
            '`ICMS_pRedBC` TEXT,
            '`ICMS_vBC` TEXT,
            '`ICMS_pICMS` TEXT,
            '`ICMS_vICMS` TEXT,
            '`ICMS_modBCST` TEXT,
            '`ICMS_pMVAST` TEXT,
            '`ICMS_pRedBCST` TEXT,
            '`ICMS_vBCST` TEXT,
            '`ICMS_pICMSST` TEXT,
            '`ICMS_vICMSST` TEXT,

            '`IPI_cEnq` TEXT,
            '`IPI_CST` TEXT,
            '`IPI_vBC` TEXT,
            '`IPI_pIPI` TEXT,
            '`IPI_vIPI` TEXT,

            '`PIS_CST` TEXT,
            '`PIS_vBC` TEXT,
            '`PIS_pPIS` TEXT,
            '`PIS_vPIS` TEXT,

            '`COFINS_CST` TEXT,
            '`COFINS_vBC` TEXT,
            '`COFINS_pCOFINS` TEXT,
            '`COFINS_vCOFINS` TEXT,

            '`Estoque_Unid` TEXT,
            '`Estoque_Qtd` TEXT,
            '`Estoque_vUnit` TEXT,
            '`dest_UF` TEXT,
            '`IdReg` TEXT,
            '`dest_CEP` TEXT,
            '`UsuID` TEXT,
            '`dest_cMun` TEXT,
            '`dest_Bairro` TEXT,

            '`ICMS_MotDesICMS` TEXT,
            '`ICMS_vBCSTRet` TEXT,
            '`ICMS_vICMSSTRet` TEXT,
            '`ICMS_pBCOP` TEXT,
            '`ICMS_UFST` TEXT,
            '`ICMS_ICMSST` TEXT,
            '`ICMS_vBCSTDest` TEXT,
            '`ICMS_vICMSSTDes` TEXT,
            '`ICMS_CSOSN` TEXT,
            '`ICMS_pCredSN` TEXT,
            '`ICMS_vCredICMSSN` TEXT,



            sql = "INSERT INTO nfce_itens ("
            '`det_IdProduto` TEXT,
            sql += "idnfe,"
            sql += "det_cProd, det_cEAN,"
            sql += "det_xProd,det_ncm,det_cfop,"
            sql += "det_uCom,det_qCom,det_vUnCom,"
            sql += "det_vProd,"

            sql += "det_EXTIPI,det_cEANTrib,"
            sql += "det_uTrib,det_qTrib,"
            sql += "det_vUnTrib,det_vFrete,"
            sql += "det_vSeg,det_vDesc,"
            sql += "det_vOutro,det_indTot"
            'sql += "det_xPed,det_nItemPed"



            sql += ") VALUES ("

            sql += "'" & _nfe.Id & "'"
            sql += ",'" & p.prod.cProd & "','" & p.prod.cEAN & "'"
            sql += ",'" & p.prod.xProd & "','" & p.prod.NCM & "','" & p.prod.CFOP & "'"
            sql += ",'" & p.prod.vUnCom & "'," & Str(p.prod.qCom) & "," & Str(p.prod.vUnCom) & ""
            sql += "," & Str(p.prod.vProd) & ""
            sql += ",'" & p.prod.EXTIPI & "','" & p.prod.cEANTrib & "'"
            sql += ",'" & p.prod.uTrib & "','" & p.prod.qTrib & "'"
            sql += ",'" & p.prod.vUnTrib & "','" & p.prod.vFrete & "'"
            sql += ",'" & p.prod.vSeg & "','" & p.prod.vDesc & "'"
            sql += ",'" & p.prod.vOutro & "','" & p.prod.indTot & "'"
            'sql += "'" & p.prod.xPed & "','" & p.prod.nItemPed & "',"
            
            sql += ")"
            Try

                Dim cx As New Conexao
                Dim cd As New SQLiteCommand()

                cx.Conectar()
                cd.Connection = cx.c
                cd.CommandText = sql
                cd.ExecuteNonQuery()
                cd.Dispose()
                cx.Desconectar()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - Itens")
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try
        Next
    End Sub
    Private Sub gravarPagamentos()
        Dim sql As String

        'gravar os pagamento
        For Each p As Pag In _nfe.infNFE.pag
            Sql = "INSERT INTO nfepagamentos "
            sql += "(dataMov,ide_nNF, ide_dhEmi,infNFe_id, infNFe_vNF,pag_tPag,pag_vPag) "
            sql += "VALUES ("
            sql += "'" & Format(Today, "yyyy-MM-dd") & "'"
            sql += ",'" & _nfe.infNFE.Ide.nNF & "',"
            Sql += "'" & _nfe.infNFE.Ide.dhEmi & "',"
            Sql += "'" & _nfe.Id & "',"
            Sql += "" & Str(_nfe.infNFE.Total.IcmsTot.vNF) & ","
            Sql += "'" & p.tPag & "',"
            sql += "" & Str(p.vPag) & ")"
            Try
                'cmd = cn.getCommand(sql)
                'cmd.ExecuteNonQuery()

                Dim cx As New Conexao
                Dim cd As New SQLiteCommand()

                cx.Conectar()
                cd.Connection = cx.c
                cd.CommandText = sql
                cd.ExecuteNonQuery()
                cd.Dispose()
                cx.Desconectar()


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - gravarPagamento")
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try
            gravaCaixa(p.tPag, p.vPag)
        Next
        'cn.getConnection.Close()
    End Sub
    ''' <summary>
    ''' Grava no caixa NFCe emitida
    ''' </summary>
    ''' <param name="tPag"></param>
    ''' <param name="valor"></param>
    ''' <remarks></remarks>
    Private Sub gravaCaixa(ByVal tPag As String, ByVal valor As Double)
        Dim cx As New Caixa
        Dim cxDAO As New CaixaDAO
        Dim fp As New FormaPagamento
        Dim fpDAO As New FormaPagamentoDAO
        fp = fpDAO.read(tPag)

        cx.codigo = IIf(_nfe.infNFE.ide.mod = "P", "P", "") & _nfe.infNFE.ide.nNF
        cx.data = Today 'DateTime.Now.Date
        cx.usuario = usuarioOnLine
        cx.valor = valor
        If _nfe.infNFE.Dest Is Nothing Then
            cx.descricao = "CONSUMIDOR"
        Else
            cx.descricao = _nfe.infNFE.Dest.xNome
        End If

        cx.documento = "NFCe: " & _nfe.infNFE.Ide.nNF & " (" & _nfe.Id & ")"
        cx.cd = "C"
        cx.moeda = fp.moeda
        cxDAO.save(cx)

        'Nota Fiscal gerada em contingencia
        'Estornar valor anterior
        If _nfe.infNFE.ide.tpEmis = "9" Then
            cx.codigo = ""
            cx.documento = "Ref. cancelamento de NFCe: " & _nfe.infNFE.ide.nNF - 1
            cx.descricao = "Estorno"
            cx.cd = "D"
            cx.valor = "-" & cx.valor
            cxDAO.save(cx)
        End If
    End Sub
    Public Function ultimanNF(ideVersao As String, ideMod As String, ideSerie As String, ideTpAmb As String) As Integer
        Dim sSql As String
        Dim dataReader As SQLiteDataReader
        Dim serie As Integer
        Dim uNT As Integer = 0
        serie = strPDV
        sSql = "SELECT * FROM nfce "
        sSql += "WHERE versao='" & ideVersao & "' AND ide_mod='" & ideMod & "' AND "
        sSql += "ide_serie = '" & ideSerie & "' AND "
        sSql += "ide_tpAmb = '" & ideTpAmb & "' "
        sSql += " ORDER BY ide_nNF DESC"
        Try

            '************************
            Dim cx As New Conexao
            Dim cd As New SQLiteCommand()

            cx.Conectar()
            cd.Connection = cx.c
            cd.CommandText = sSql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader


            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand

            'cmd = cn.getCommand(sSql)
            'dataReader = cmd.ExecuteReader

            If dataReader.Read Then

                uNT = dataReader.Item("ide_nNF").ToString
                dataReader.Close()
            End If
            cd.Dispose()
            cx.Desconectar()
            'cn.getConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Modulo NFeDAO - ultima nf")
            Util.log(ex.Message, System.Environment.StackTrace, "")

            Return LeArquivoINI(Application.StartupPath & "\config.ini", "UniNFe", "NFCeInicial", 0)
            'Finally
            'dataReader.Close()
        End Try
        Return uNt
    End Function
    Public Sub baixarEstoque()
        Dim estProd As New Produto

        Dim p As prod
        For Each d As det In _nfe.infNFE.Det
            p = d.Prod
            estProd.id = p.cProd
            estProd.read()
            estProd.baixarEstoque(p.qCom)

        Next

    End Sub
    ''' <summary>
    ''' Pega a instancia da nfce pelo numero do documento (nNF)
    ''' </summary>
    ''' <param name="nNF">Numero da Nota Fiscal</param>
    ''' <param name="modalidade">65 - NFCe ou P - Pedido</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function pgNfe(ByVal nNF As Integer, ByVal modalidade As String) As NFCe
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader
        Dim nfce As New NFCe
        Dim usuDAO As New UsuarioDAO
        sql = "SELECT * FROM nfce "
        sql += "WHERE ide_nNF=" & nNF
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_mod = '" & modalidade & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"

        Try
           
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader

            If dataReader.Read Then
                nfce = popularNFCe(dataReader)
                
                Return nfce
            End If
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe NFeDAO - pgnNF")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            dataReader.Close()
        End Try

    End Function

    ''' <summary>
    ''' Pega a instancia da nfce pelo numero do documento (chNFe)
    ''' </summary>
    ''' <param name="chNFe"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function pgNfe(ByVal chNFe As String) As NFCe
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader
        Dim nfce As New NFCe
        Dim usuDAO As New UsuarioDAO

        sql = "SELECT * FROM nfce "
        sql += "WHERE idNFe='" & chNFe & "' AND "
        sql += "ide_serie = '" & nfeSerie & "' AND "
        sql += "ide_tpAmb = '" & strAmbiente & "' "
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand

            'cmd = cn.getCommand(sql)
            'dataReader = cmd.ExecuteReader
            'cn.getConnection.Close()
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader

            If dataReader.Read Then
                nfce = popularNFCe(dataReader)
                
                Return nfce
            End If
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe NFeDAO - pgnNF")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            dataReader.Close()
        End Try

    End Function
    Private Sub montatabela()

    End Sub

    Public Sub gravarProtAutorizacao(chNFe As String, nProtAutorizacao As String, digVal As String)
        'Grava protocolo de autorizacao da nfce
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "UPDATE nfce SET nProt='" & nProtAutorizacao & "', digval='" & digVal & "' WHERE idNFe='" & chNFe & "'"


        Try
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cnx.Desconectar()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - gravarProtAutorizacao")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        'cn.getConnection.Close()
    End Sub
    Public Sub gravarProtInutilizacao(ByVal objNFCe As NFCe, ByVal infInut As infInut)
        'Grava protocolo de inutilizacao do numero
        Dim sql As String

        sql = "UPDATE nfce " & _
             "SET nProtInutilizacao='" & infInut.nProt & "' " & _
             "WHERE idNFe='" & objNFCe.infNFE.Id & "'"


        Try
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cnx.Desconectar()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - gravarProtAutorizacao")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        'cn.getConnection.Close()
    End Sub
    Public Sub gravarProtCancelamento(ByVal objNFCe As NFCe, ByVal nProtCancelamento As String)
        'Grava protocolo de inutilizacao do numero
        Dim sql As String

        sql = "UPDATE nfce " & _
             "SET nProtCancelamento='" & nProtCancelamento & "' " & _
             "WHERE idNFe='" & objNFCe.infNFE.Id & "'"


        Try
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cnx.Desconectar()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - gravarProtAutorizacao")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        'cn.getConnection.Close()
    End Sub
    ''' <summary>
    ''' Retorna um List com todas as NFCe que
    ''' não possuem:
    ''' Protocolo de Autorizacao
    ''' Protocolo de Cancelamento
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarNFeSemRegistroSEFAZ() As List(Of NFCe)
        Dim nt As NFCe

        Dim nfces As New List(Of NFCe)
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand

        sql = "SELECT IdNFe, ide_serie, ide_tpAmb, nProt, nProtCancelamento, nProtInutilizacao FROM nfce"
        sql += " WHERE nProt IS NULL"
        sql += " AND nProtCancelamento IS NULL"
        sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY id"


        'sql += "WHERE idNFe='" & chNFe & "' AND "
        Try
            Dim cnx As New Conexao
            'Dim cd As New SQLiteCommand()

            cnx.Conectar()
            'cd.Connection = cnx.c
            'cd.CommandText = sql
            'cd.ExecuteNonQuery()
            'cd.Dispose()


            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()

            Dim dr As DataRow
            For Each dr In dataSet.Tables("myTable").Rows
                nt = New NFCe
                nt = pgNfe(dr("IdNFe").ToString)
                If Not IsNothing(nt) Then
                    nfces.Add(nt)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cliente")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

        Return nfces
    End Function
    ''' <summary>
    ''' Retorna um List com todas as NFCe.
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarTodasNFesNoPeriodo(dtIni As Date, dtFin As Date) As List(Of NFCe)
        Dim nt As NFCe

        Dim nfces As New List(Of NFCe)
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand

        sql = "SELECT * FROM nfce"
        sql += " WHERE" 'nProt IS NULL"
        sql += " DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        'sql += " AND nProtCancelamento IS NULL"
        'sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_mod = '65'"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF"


        'sql += "WHERE idNFe='" & chNFe & "' AND "
        Try
            Dim cnx As New Conexao
            'Dim cd As New SQLiteCommand()

            cnx.Conectar()
            'cd.Connection = cnx.c
            'cd.CommandText = sql
            'cd.ExecuteNonQuery()
            'cd.Dispose()


            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()

            Dim dr As DataRow
            For Each dr In dataSet.Tables("myTable").Rows
                nt = New NFCe
                nt = pgNfe(dr("IdNFe").ToString)
                If Not IsNothing(nt) Then
                    nfces.Add(nt)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cliente")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

        Return nfces
    End Function


    ''' <summary>
    ''' Retorna um List com todas as NFCe.
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarSituacaoNFCes(dtIni As Date, dtFin As Date) As DataSet



        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet

        sql = "SELECT strftime('%d/%m/%Y | %H:%M:%S', ide_dhemi) as data, idnfe as chave, CAST(total_vNF as real) as valor "
        sql += " FROM nfce"
        sql += " WHERE" 'nProt IS NULL"
        sql += " DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        'sql += " AND nProtCancelamento IS NULL"
        'sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF"


        Try
            Dim cnx As New Conexao

            cnx.Conectar()

            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cliente")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
    End Function

    ''' <summary>
    ''' Retorna um DataSet com os pedidos
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listarPedidosNoPeriodo(dtIni As Date, dtFin As Date) As DataSet
        'Dim nt As NFCe

        'Dim nfces As New List(Of NFCe)
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand

        sql = "SELECT * FROM nfce"
        sql += " WHERE" 'nProt IS NULL"
        sql += " DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        'sql += " AND nProtCancelamento IS NULL"
        'sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_mod = 'P'"
        'sql += " AND ide_serie = '" & nfeSerie & "'"
        'sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF"


        'sql += "WHERE idNFe='" & chNFe & "' AND "
        Try
            Dim cnx As New Conexao
            'Dim cd As New SQLiteCommand()

            cnx.Conectar()
            'cd.Connection = cnx.c
            'cd.CommandText = sql
            'cd.ExecuteNonQuery()
            'cd.Dispose()


            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
            Return dataSet
            '    Dim dr As DataRow
            '    For Each dr In dataSet.Tables("myTable").Rows
            '        nt = New NFCe
            '        nt = pgNfe(dr("IdNFe").ToString)
            '        If Not IsNothing(nt) Then
            '            nfces.Add(nt)
            '        End If
            '    Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cliente")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

        'Return nfces
    End Function


    Private Function popularNFCe(ByVal dr As SQLiteDataReader) As NFCe
        Dim nf As New NFCe
        Try
            nf.Id = dr.Item("idNFe").ToString
            nf.nProt = dr.Item("nProt").ToString
            nf.nProtCancelamento = dr.Item("nProtCancelamento").ToString
            nf.nProtInutilizacao = dr.Item("nProtInutilizacao").ToString
            nf.versao = dr.Item("versao").ToString
            nf.xJust = dr.Item("ide_xJust").ToString

            nf.infNFE.Id = dr.Item("idNFe").ToString
            'ide
            nf.infNFE.ide.mod = dr.Item("ide_mod").ToString
            nf.infNFE.ide.serie = dr.Item("ide_serie").ToString
            nf.infNFE.ide.nNF = dr.Item("ide_nNF").ToString
            nf.infNFE.ide.tpAmb = dr.Item("ide_tpAmb").ToString
            nf.infNFE.ide.dhEmi = dr.Item("ide_dhEmi").ToString
            nf.infNFE.ide.finNFe = dr.Item("ide_finNFe").ToString
            nf.infNFE.ide.cUF = dr.Item("ide_cUF").ToString
            nf.infNFE.ide.cNF = dr.Item("ide_cNF").ToString
            nf.infNFE.ide.natOp = dr.Item("ide_natOp").ToString
            nf.infNFE.ide.indPag = dr.Item("ide_indPag").ToString
            nf.infNFE.ide.tpNF = dr.Item("ide_tpNF").ToString
            nf.infNFE.ide.idDest = dr.Item("ide_idDest").ToString
            nf.infNFE.ide.cMunFG = dr.Item("ide_cMunFG").ToString
            nf.infNFE.ide.tpImp = dr.Item("ide_tpImp").ToString
            nf.infNFE.ide.tpEmis = dr.Item("ide_tpEmis").ToString
            nf.infNFE.ide.cDV = dr.Item("ide_cDV").ToString
            nf.infNFE.ide.indFinal = dr.Item("ide_indFinal").ToString
            nf.infNFE.ide.indPres = dr.Item("ide_indPres").ToString
            nf.infNFE.ide.verProc = dr.Item("ide_verProc").ToString
            nf.infNFE.ide.dhCont = dr.Item("ide_dhCont").ToString
            nf.infNFE.ide.xJust = dr.Item("ide_xJust").ToString

            'Emitente
            nf.infNFE.emit.CNPJ = dr.Item("emit_CNPJ").ToString
            'Emitente

            nf.infNFE.emit.xNome = dr.Item("emit_xNome").ToString
            nf.infNFE.emit.xFant = dr.Item("emit_xFant").ToString
            nf.infNFE.emit.enderEmit.xLgr = dr.Item("emit_xLgr").ToString
            nf.infNFE.emit.enderEmit.nro = dr.Item("emit_nro").ToString
            nf.infNFE.emit.enderEmit.xCpl = dr.Item("emit_xCpl").ToString
            nf.infNFE.emit.enderEmit.xBairro = dr.Item("emit_Bairro").ToString
            nf.infNFE.emit.enderEmit.cMun = dr.Item("emit_cMun").ToString
            nf.infNFE.emit.enderEmit.xMun = dr.Item("emit_xMun").ToString
            nf.infNFE.emit.enderEmit.UF = dr.Item("emit_UF").ToString
            nf.infNFE.emit.enderEmit.CEP = dr.Item("emit_CEP").ToString
            nf.infNFE.emit.enderEmit.cPais = dr.Item("emit_cPais").ToString
            nf.infNFE.emit.enderEmit.xPais = dr.Item("emit_xPais").ToString
            nf.infNFE.emit.enderEmit.fone = dr.Item("emit_fone").ToString
            nf.infNFE.emit.IE = dr.Item("emit_IE").ToString
            nf.infNFE.emit.IEST = dr.Item("emit_IEST").ToString
            nf.infNFE.emit.IM = dr.Item("emit_IM").ToString
            nf.infNFE.emit.CNAE = dr.Item("emit_CNAE").ToString
            nf.infNFE.emit.CRT = dr.Item("emit_CRT").ToString


            ''Destinatario
            'If Not IsNothing(_nfe.infNFE.dest) Then
            '    'sql += "dest_pessoa,"
            '    sql += "dest_CNPJ,"
            '    sql += "dest_xNome,dest_xFant,"
            '    sql += "dest_xLgr,dest_nro,"
            '    sql += "dest_xCpl,dest_Bairro,"
            '    sql += "dest_cMun,dest_xMun,"
            '    sql += "dest_UF,dest_CEP,"
            '    sql += "dest_cPais,dest_xPais,"
            '    sql += "dest_fone,dest_IE,"
            '    sql += "dest_ISUF,dest_email,"

            'End If

            ''Totais
            nf.infNFE.total.ICMSTot.vBC = IIf(dr.Item("total_vBC").ToString = Nothing, 0, dr.Item("total_vBC").ToString)
            nf.infNFE.total.ICMSTot.vICMS = dr.Item("total_vICMS").ToString
            nf.infNFE.total.ICMSTot.vBCST = dr.Item("total_vBCST").ToString
            'nf.infNFE.total.ICMSTot. = dr.Item("total_vICMSST").ToString
            nf.infNFE.total.ICMSTot.vProd = IIf(dr.Item("total_vProd").ToString = Nothing, 0, dr.Item("total_vProd").ToString)
            nf.infNFE.total.ICMSTot.vFrete = dr.Item("total_vFrete").ToString
            nf.infNFE.total.ICMSTot.vSeg = dr.Item("total_vSeg").ToString
            nf.infNFE.total.ICMSTot.vDesc = dr.Item("total_vDesc").ToString
            nf.infNFE.total.ICMSTot.vIPI = dr.Item("total_vIPI").ToString
            nf.infNFE.total.ICMSTot.vPIS = dr.Item("total_vPIS").ToString
            nf.infNFE.total.ICMSTot.vCOFINS = dr.Item("total_vCOFINS").ToString
            nf.infNFE.total.ICMSTot.vOutro = dr.Item("total_vOutro").ToString
            nf.infNFE.total.ICMSTot.vNF = dr.Item("total_vNF").ToString.Replace(".", ",")
            nf.infNFE.infAdic = New infAdic

            nf.infNFE.infAdic.infCpl = dr.Item("infAdic_infCpl").ToString
            nf.digVal = dr.Item("digVal").ToString

            '**************************************************************************
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - popularNFCe")
            Util.log(ex.Message, System.Environment.StackTrace, "NFeDAO - popularNFCe")
            nf = Nothing
        End Try

        Return nf
    End Function
    Public Function listarResumoNotas(ByVal operador As Integer, ByVal dtIni As Date, ByVal dtFin As Date) As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet

        sql = "SELECT DtHr AS Data,usuID AS OperadorID,ide_nNF AS Nota ,total_vNF as valor, nProt, nProtCancelamento, nProtInutilizacao FROM nfce"
        sql += " WHERE operadorID= " & operador
        sql += " AND DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        sql += " AND nProt IS NOT NULL"
        sql += " AND nProtCancelamento IS NULL"
        sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF ASC"

        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand

            'myAdap = New SQLiteDataAdapter(sql, cn.getConnection)
            'myAdap.Fill(dataSet, "myTable")
            'cn.getConnection.Close()
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe NFeDAO - listarResumoNotas")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
    End Function
    Public Function totalNotasAutorizadas(ByVal dtIni As Date, ByVal dtFin As Date) As Integer
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        Dim retorno As Integer
        sql = "SELECT DtHr AS Data,usuID AS OperadorID,ide_nNF AS Nota ,total_vNF as valor, nProt, nProtCancelamento, nProtInutilizacao FROM nfce"
        sql += " WHERE" 'operadorID= " & operador
        sql += " DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        sql += " AND nProt IS NOT NULL"
        sql += " AND nProtCancelamento IS NULL"
        sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF ASC"

        Try
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
            retorno = dataSet.Tables("myTable").Rows.Count

        Catch ex As Exception
            retorno = 0
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe NFeDAO - totalNotasAutorizadas")
            Util.log(ex.Message, System.Environment.StackTrace, "Classe NFeDAO - totalNotasAutorizadas")

        End Try
        Return retorno
    End Function
    Public Function totalNotasCanceladas(ByVal dtIni As Date, ByVal dtFin As Date) As Integer
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        Dim retorno As Integer
        sql = "SELECT DtHr AS Data,usuID AS OperadorID,ide_nNF AS Nota ,total_vNF as valor, nProt, nProtCancelamento, nProtInutilizacao FROM nfce"
        sql += " WHERE" 'operadorID= " & operador
        sql += " DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        'sql += " AND nProt IS NOT NULL"
        sql += " AND nProtCancelamento IS NOT NULL"
        'sql += " AND nProtInutilizacao IS NULL"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF ASC"

        Try
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
            retorno = dataSet.Tables("myTable").Rows.Count

        Catch ex As Exception
            retorno = 0
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe NFeDAO - totalNotasCanceladas")
            Util.log(ex.Message, System.Environment.StackTrace, "Classe NFeDAO - totalNotasCanceladas")

        End Try
        Return retorno
    End Function
    Public Function totalNotasInutilizadas(ByVal dtIni As Date, ByVal dtFin As Date) As Integer
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        Dim retorno As Integer
        sql = "SELECT DtHr AS Data,usuID AS OperadorID,ide_nNF AS Nota ,total_vNF as valor, nProt, nProtCancelamento, nProtInutilizacao FROM nfce"
        sql += " WHERE" 'operadorID= " & operador
        sql += " DtHr BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        'sql += " AND nProt IS NOT NULL"
        'sql += " AND nProtCancelamento IS NOT NULL"
        sql += " AND nProtInutilizacao IS NOT NULL"
        sql += " AND ide_serie = '" & nfeSerie & "'"
        sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY ide_nNF ASC"

        Try
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
            retorno = dataSet.Tables("myTable").Rows.Count

        Catch ex As Exception
            retorno = 0
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe NFeDAO - totalNotasInutilizadas")
            Util.log(ex.Message, System.Environment.StackTrace, "Classe NFeDAO - totalNotasInutilizadas")

        End Try
        Return retorno
    End Function
End Class
