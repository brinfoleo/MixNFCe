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
        Dim cn As New ConnectionFactory
        Dim cmd As New SQLiteCommand

        'sql = "DELETE from nfce"
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
        sql += "total_vNF,infAdic_infCpl"

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

        Try
            cmd = cn.getCommand(sql)
            cmd.ExecuteNonQuery()

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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "NFeDAO - gravarNFe")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        cn.getConnection.Close()


            'Totais
            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vBC).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vICMS).Trim & "'"
            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vBCST).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vST).Trim & "'"
            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vProd).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vFrete).Trim & "'"
            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vSeg).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vDesc).Trim & "'"
            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vIPI).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vPIS).Trim & "'"
            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vCOFINS).Trim & "','" & Str(_nfe.infNFE.total.ICMSTot.vOutro).Trim & "'"


            sql += ",'" & Str(_nfe.infNFE.total.ICMSTot.vNF).Trim & "','" & _nfe.infNFE.infAdic.ToString.Trim & "'"

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
            Sql += "" & p.vPag & ")"
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
    Private Sub gravaCaixa(ByVal tPag As String, ByVal valor As Double)
        Dim cx As New Caixa
        Dim cxDAO As New CaixaDAO
        Dim fp As New FormaPagamento
        Dim fpDAO As New FormaPagamentoDAO
        fp = fpDAO.read(tPag)

        cx.codigo = "nfce"
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
    ''' <param name="nNF"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function pgNfe(ByVal nNF As Integer) As nfce
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader
        Dim nfce As NFCe
        Dim usuDAO As New UsuarioDAO
        sql = "SELECT * FROM nfce " & _
              "WHERE ide_nnf=" & nNF
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
                nfce.Id = dataReader.Item("infNFe_id").ToString
                'cx.data = dataReader.Item("dataMov").ToString
                'cx.codigo = dataReader.Item("codigo").ToString
                'cx.valor = dataReader.Item("valor")
                'cx.usuario = usuDAO.read(dataReader.Item("operadorID").ToString)
                'cx.codigo = dataReader.Item("descricao").ToString
                'cx.codigo = dataReader.Item("cd").ToString
                'cx.documento = dataReader.Item("documento").ToString
                'cx.moeda = dataReader.Item("moeda").ToString
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
        sql = "SELECT * FROM nfce " & _
              "WHERE idNFe='" & chNFe & "'"
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
                nfce.Id = dataReader.Item("idNFe").ToString
                nfce.infNFE.Id = dataReader.Item("idNFe").ToString
                nfce.infNFE.ide.nNF = dataReader.Item("ide_nNF").ToString
                nfce.nProt = dataReader.Item("nProt").ToString
                nfce.infNFE.ide.tpAmb = dataReader.Item("ide_tpAmb").ToString
                nfce.versao = dataReader.Item("versao").ToString

                '*********************************************************
                ' FALTA COLETAR
                'sql += "(dthr,usuid, versao, ide_tpEmis,"
                ''ide
                'sql += "ide_mod, ide_serie, ide_nNF, ide_dhEmi,"
                'sql += "ide_tpAmb, ide_finNFe,"
                'sql += "ide_cUF, ide_cNF,"
                'sql += "ide_natOp, ide_indPag,"
                'sql += "ide_tpNF, ide_idDest,"
                'sql += "ide_cMunFG, ide_tpImp,"
                'sql += "ide_cDV, ide_indFinal,"
                'sql += "ide_indPres, ide_procEmi,"
                'sql += "ide_verProc, ide_dhCont,"
                'sql += "ide_xJust,idnfe,"

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
                'sql += "total_vBC,total_vICMS,"
                'sql += "total_vBCST,total_vICMSST,"
                'sql += "total_vProd,total_vFrete,"
                'sql += "total_vSeg,total_vDesc,"
                'sql += "total_vIPI,total_vPIS,"
                'sql += "total_vCOFINS,total_vOutro,"
                'sql += "total_vNF,infAdic_infCpl"



                '**************************************************************************

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

    Public Sub gravarProtAutorizacao(ByVal objNFCe As nfeProc)
        'Grava protocolo de autorizacao da nfce
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "UPDATE nfce " & _
             "SET nProt='" & objNFCe.protNFe.infProt.nProt & "' " & _
             "WHERE idNFe='" & Mid(objNFCe.NFe.infNFe.Id, 4, objNFCe.NFe.infNFe.Id.ToString.Length) & "'"


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



End Class
