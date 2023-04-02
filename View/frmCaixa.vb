Imports System.Data.SQLite
Imports System.IO


Public Class frmCaixa
    Dim sTamanho As Integer
    Dim slocation As Integer = 518
    Dim strStatusCupom As String = "Fechado"
    Dim strItem As Integer

    'Variaveis usadas no metodo analiseNotasPendentes 
    Dim thread As Threading.Thread
    Dim ultimaAnalise As DateTime

    Private cupom As Cupom
    Private Sub frmCaixa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        
        ' ESC - Sair do sistema
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            If lblCaixalivre.Text <> "CAIXA LIVRE" Then
                'strStatusCupom = "Fechado"
                Exit Sub
            End If
            Dim result = MessageBox.Show("Gostaria de sair do sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = MsgBoxResult.Yes Then
                End
            End If
            'space - Pesquisa item para venda
        ElseIf e.KeyCode = Windows.Forms.Keys.Space Then
            Dim p As New Produto
            Dim idProd As Integer
            idProd = frmPesquisa.loadForm(p)

            ' F1 - Ajuda
        ElseIf e.KeyCode = Windows.Forms.Keys.F1 Then
            'MsgBox("Ajuda")
            frmSobre.ShowDialog()
            
            'F2 - cancelar item
        ElseIf e.KeyCode = Windows.Forms.Keys.F2 Then
            cancelarItem()


            ' F3 - Cancelar cupom
        ElseIf e.KeyCode = Windows.Forms.Keys.F3 Then
            cancelarNota()
            ' F4 - Reimprime Cupom
        ElseIf e.KeyCode = Windows.Forms.Keys.F4 Then
            imprimirCupom()

            ' F5 - Finalizar venda DINHEIRO
        ElseIf e.KeyCode = Windows.Forms.Keys.F5 Then
            pagamento("DN")
            ' F6 - Finalizar venda CARTAO CREDITO
        ElseIf e.KeyCode = Windows.Forms.Keys.F6 Then
            pagamento("CC")
            ' F7 - ' F6 - Finalizar venda CARTAO DEBITO
        ElseIf e.KeyCode = Windows.Forms.Keys.F7 Then
            pagamento("CD")

            ' F8 - Outras opcoes
        ElseIf e.KeyCode = Windows.Forms.Keys.F8 Then
            pagamento()
            'frmMenuPrincipal.ShowDialog()

            'F9 - Consulta Preco
        ElseIf e.KeyCode = Windows.Forms.Keys.F9 Then
            frmConsultaProduto.ShowDialog()

            'F10 - Sangria/Suprimento
        ElseIf e.KeyCode = Windows.Forms.Keys.F10 Then
            frmSangriaSuprimento.ShowDialog()
            'F12 - Sangria/Suprimento
        ElseIf e.KeyCode = Windows.Forms.Keys.F12 Then
            frmMenuPrincipal.ShowDialog()

        End If
        ' 23/11/2015 - Menu antigo
        '    ' F1 - Ajuda
        'ElseIf e.KeyCode = Windows.Forms.Keys.F1 Then
        '    'MsgBox("Ajuda")
        '    frmSobre.ShowDialog()

        '    ' F2 - Finalizar venda
        'ElseIf e.KeyCode = Windows.Forms.Keys.F2 Then
        '    If cupom.vCupom = 0 Then Exit Sub
        '    If FrmPagamento.carregarForm(cupom) = True Then
        '        CaixaLivre()
        '    End If

        '    'F3 - cancelar item
        'ElseIf e.KeyCode = Windows.Forms.Keys.F3 Then
        '    cancelarItem()


        '    ' F4 - Cancelar cupom
        'ElseIf e.KeyCode = Windows.Forms.Keys.F4 Then
        '    cancelarNota()


        '    'F5 - Caregar comanda
        'ElseIf e.KeyCode = Windows.Forms.Keys.F5 Then

        '    emitirCupomTXT()

        '    'F6 - Consulta
        'ElseIf e.KeyCode = Windows.Forms.Keys.F6 Then
        '    frmConsultaProduto.ShowDialog()

        '    'F7 - Sangria/Suprimento
        'ElseIf e.KeyCode = Windows.Forms.Keys.F7 Then

        '    frmSangriaSuprimento.ShowDialog()

        '    'F8 - Cliente
        'ElseIf e.KeyCode = Windows.Forms.Keys.F8 Then
        '    AbriClientes()

        '    ' F9 - Reimprime Cupom
        'ElseIf e.KeyCode = Windows.Forms.Keys.F9 Then
        '    imprimirCupom()

        '    ' F10 - Menu
        'ElseIf e.KeyCode = Windows.Forms.Keys.F10 Then
        '    'frmMenuAtalhos.Show()
        '    frmMenuPrincipal.ShowDialog()
        '    ' F11 - Listar pedidos
        'ElseIf e.KeyCode = Windows.Forms.Keys.F11 Then
        '    frmPedidos.loadForm()
        '    ' F12 - VENDA RAPIDA
        'ElseIf e.KeyCode = Windows.Forms.Keys.F12 Then
        '    frmVendaRapida.ShowDialog()
        '    'P - Busca peso da balanca
        'ElseIf UCase(e.KeyCode) = Windows.Forms.Keys.P Then
        '    txtCod.Text = ""
        '    frmBalanca.ShowDialog()

    End Sub
    Public Sub AbriClientes()
        Dim cli As New Cliente
        cli = frmClientes.loadForm
        If IsNothing(cli) Then
            lblCliente.Visible = False
            cupom.removerDestinatario()
        Else
            cupom.addDestinatario(cli)
            lblCliente.Text = "Destinatário:  " & cupom.destinatario.xNome  'Cupom.nfce.infNFE.Dest.xNome
            lblCliente.Visible = True
        End If
    End Sub

    Private Sub frmCaixa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'VERIFICA ATIVAÇÃO DO SISTEMA
        strCnpjAtivacao = strCNPJ
        strStatusAtivacao = "BLOQUEADO"
        If Len(strCnpjAtivacao) < 14 Then
            strCnpjAtivacao = Mid(strCnpjAtivacao, 10, 5)
        Else
            strCnpjAtivacao = Mid(strCnpjAtivacao, 13, 7)
        End If
        DataHoje = Date.Now.ToString()
        DataHoje = Mid(DataHoje, 1, 10)

        If strCNPJ = "" Then
            MessageBox.Show("CNPJ não encontrado." & vbCrLf & "INFORME AO SUPORTE TÉCNICO!", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ValidaChaveAcesso(strCnpjAtivacao, strUltimaAtivacao, "", "", "") Then
            strStatusAtivacao = "LIBERADO"
        Else
            Util.logWeb("Sistema Expirou")
            MessageBox.Show("O Sistema expirou seu período de uso." & vbCrLf & "Informe o código!", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmAtivacao.ShowDialog()
        End If
        '-----------------------------

        ' CARREGAR A LOGO PADRAO DO SISTEMA E A LOGO CLIENTE
        If File.Exists(Application.StartupPath & "\sysimg") Then
            Me.PC_System.BackgroundImage = Image.FromFile(Application.StartupPath & "\sysimg")
            PC_System.Refresh()
        End If
        If File.Exists(strLogo) Then
            Me.PC_Loja.BackgroundImage = Image.FromFile(strLogo)
            Me.PC_Loja.BackgroundImageLayout = ImageLayout.Stretch
            Me.PC_Loja.Refresh()
        End If
        '----------------------------------------------------

        CarregaBarraStatus()  'CARREGA TODOS OS PARAMETROS DO SISTEMA - EDUARDO SILVA 20/10/2014
        txtCod.Focus()
        CaixaLivre()
        'Checa pendencias nas notas fiscais
        'contidas na base de dados
        analiseNotasPendentes()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PreencheTela()
        'VendeItem()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CaixaLivre()
    End Sub
    Private Sub PreencheTela()
        Dim strDateCupom As Date = DateTime.Now
        If strStatusCupom = "Fechado" Then
            sTamanho = sTamanho + 133
            slocation = slocation - 133
            pnCupom.Location = New Point(15, slocation)
            pnCupom.Height = sTamanho
            lblCaixalivre.Text = ""
            strStatusCupom = "Aberto"
            'MONTA CABEÇALHO CUPOM TELA - EDUARDO SILVA  20/10/2014
            lblCupomLinha1.Text = strRazao
            lblCupomLinha2.Text = "CNPJ:" & strCNPJ & "     " & "I.E.: " & strIE
            lblCupomLinha3.Text = "End:" & strEnd & "-" & strBairro & "-" & strCidade & "-" & strUF
            lblCupomLinha4.Text = "Date:" & strDateCupom.ToString("dd/MM/yyyy") & " Hora:" & strDateCupom.ToString("HH:mm:ss")
            '-------------------------
            tmrRelogio.Enabled = False
            lbldescricaoSuperior.Text = ""
        ElseIf sTamanho < 314 Then
            sTamanho = sTamanho + 23
            slocation = slocation - 23
            pnCupom.Location = New Point(15, slocation)
            pnCupom.Height = sTamanho
        End If

        lbldescricaoSuperior.Text = cupom.item(cupom.countItens - 1).xProd

        addLinhaFitaTela(strItem, cupom.item(cupom.countItens - 1).cEAN, _
                             cupom.item(cupom.countItens - 1).xProd, _
                             cupom.item(cupom.countItens - 1).qCom, _
                             cupom.item(cupom.countItens - 1).uCom, _
                             cupom.item(cupom.countItens - 1).vUnCom, _
                             cupom.item(cupom.countItens - 1).vProd)




        txtQtd.Text = "1"
        '------------------------------------------------
        txtCod.Text = ""
        txtCod.Focus()

    End Sub
    Public Sub VendeItem()
        Dim prod As New Produto
        Dim qtd As Double
        Dim dTotalPesado As Decimal

        'SE FOR CODIGO DE BALANÇA ETIQUETADORA####################################### EDUARDO SILVA 03/07/2015
        If ((txtCod.Text.Substring(0, 1) = "2")) And (txtCod.Text.Length() = 13) Then
            dTotalPesado = Convert.ToDecimal(txtCod.Text.Substring(7, 3) + "," + txtCod.Text.Substring(10, 2))
            txtCod.Text = txtCod.Text.Substring(1, strDigBalanca)
            prod = pgProdutoEstoque(txtCod.Text)
            ' FAZ A VERIFICAÇÃO DE CODIGO VALIDO E PRECO MAIOR QUE ZERO---------------------------------------
            If checarProdutoCadastrado(prod.codigoBarras) = False Then Exit Sub
            If checarValorVenda(prod.precoVenda) = False Then Exit Sub
            '--------------------------------------------------------------------------------------------------
            txtQtd.Text = FormatNumber(dTotalPesado / prod.precoVenda, 3)
        Else
            prod = pgProdutoEstoque(txtCod.Text)
            ' FAZ A VERIFICAÇÃO DE CODIGO VALIDO E PRECO MAIOR QUE ZERO----------------------------------------
            If checarProdutoCadastrado(prod.codigoBarras) = False Then Exit Sub
            If checarValorVenda(prod.precoVenda) = False Then Exit Sub
            '---------------------------------------------------------------------------------------------------
        End If


        '##########################################################################################
        '2/cod prod(6)/preco total
        'Se for código de etiqueta de balança
        'If ((txtCodProduto.Text.Substring(0, 1) = "2")) And (txtCodProduto.Text.Length() = 13)  Then
        '    TotalItem = Convert.ToDecimal(txtCodProduto.Text.Substring(7, 3) + "," + txtCodProduto.Text.Substring(10, 2))
        '    txtQtdProduto.Text = FormatNumber(TotalItem / Produto.Preco, 3)
        '    TotalAlterado = TotalItem
        'Else
        '    TotalItem = Truncar(Produto.Preco * CDbl(Replace(txtQtdProduto.Text, ".", ",")), 2)
        '    TotalAlterado = Truncar((vValorAlterado * CDbl(Replace(txtQtdProduto.Text, ".", ","))), 2)
        'End If
        '##########################################################################################


        prod = pgProdutoEstoque(txtCod.Text)


        'Checa se o valor de venda é valido
        'If checarValorVenda(prod.precoVenda) = False Then Exit Sub


        strItem = strItem + 1
        Dim tmpQtd As String
        tmpQtd = txtQtd.Text
        qtd = Convert.ToDouble(tmpQtd)

        cupom.addItem(prod, qtd)
        PreencheTela()



    End Sub
    Private Sub VerificaPermissao() 'Eduardo silva 23/10/2014

        Dim cx As New Conexao()
        Dim sql As String
        sql = ""
        sql += " Select id, usuario, senha, cargo from usuario "
        sql += " where usuario = '" & strUsuarioLogado & "' "
        cx.Conectar()
        Dim cdm As New SQLiteCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As SQLiteDataReader = cdm.ExecuteReader
        If dr.Read Then
            strTipoAcesso = dr.Item("cargo") 'se tipo igual a True acesso total, se igual a False acesso restrito somente a venda.
        End If
        cx.Desconectar()
    End Sub
    Private Function pgProdutoEstoque(ByVal cod_barra As String) As Produto
        Dim p As New Produto
        'p.codigoBarras = cod_barra
        p.pesqProdutoCodBarr(cod_barra)

        Return p
        'If cod_barra.Length = 0 Then
        '    txtCod.Focus()
        '    Throw New Exception("Preencha o Código Barra !")
        'End If
        'Dim cx As New Conexao()
        'Dim sql As String
        'sql = ""
        'sql += " Select id, codi, nome, unidade, venda1  from produto "
        'sql += " Where codi = '" + cod_barra + "'"
        'cx.Conectar()
        'Dim cdm As New SQLiteCommand
        'cdm.Connection = cx.c
        'cdm.CommandText = sql
        'Dim dr As SQLiteDataReader = cdm.ExecuteReader
        'If dr.Read Then
        '    idItem = dr.Item("id")
        '    strCodBarra = dr.Item("codi")
        '    strDescricao = dr.Item("nome")
        '    strTipoUn = dr.Item("unidade")
        '    strValorUn = dr.Item("venda1").ToString.Replace(".", ",")
        'Else
        '    idItem = 0
        '    cdm.Dispose()
        '    dr.Dispose()
        '    dr.Close()
        '    cx.Desconectar()
        '    Throw New Exception("Código Barra não Cadastrado ! " + cod_barra)
        'End If
        'cdm.Dispose()
        'dr.Dispose()
        'dr.Close()
        'cx.Desconectar()

    End Function
    Public Sub CarregaBarraStatus()
        'CARREGAR BARRA DE STATUS - EDUARDO SILVA 20/10/2014
        bsCNPJ.Text = "CNPJ:" & strCNPJ
        bsRazao.Text = "|EMPRESA: " & strRazao
        bsLoja.Text = "|LOJA: " & strLoja
        bsPDV.Text = "|PDV:" & strPDV
        bsAtivacao.Text = "|CHAVE:" & sChave
        bsExpira.Text = "|EXPIRA:" & sExpira
        lblVersao.Text = "Versão:" + My.Application.Info.Version.ToString
        '---------------------------------------------------
    End Sub
    Public Sub CaixaLivre() 'DEIXA O CAIXA EM ESTADO INICIAL PARA PRÓXIMA VENDA - EDUARDO SILVA 20/10/2014
        cupom = New Cupom
        sTamanho = 20
        pnCupom.Height = sTamanho
        slocation = 500
        pnCupom.Location = New Point(15, slocation)
        lblCaixalivre.Text = "CAIXA LIVRE"
        strStatusCupom = "Fechado"
        dgvProdutos.Rows.Clear()
        dgvProdutos.Refresh()
        tmrRelogio.Enabled = True
        strItem = 0
        txtQtd.Text = "1"
        lblSubTotal.Text = "R$ 0,00"
        lblTotalGeral.Text = "R$ 0,00"
        lblValorUnitario.Text = "R$ 0,00"
        'lbldescricaoSuperior.Text = ""
        lblCliente.Visible = False
        txtCod.Focus()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmConfiguracoes.ShowDialog()
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub tmrRelogio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRelogio.Tick
        Dim strHora As Date = DateTime.Now
        lbldescricaoSuperior.Text = "Data: " & strHora.ToString("dd/MM/yyyy") & "   Hora: " & strHora.ToString("HH:mm:ss")
        analiseNotasPendentes()
    End Sub

    Private Sub cmdFinalizadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFormaPgto.ShowDialog()
    End Sub

    Private Sub cmdCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmClientes.ShowDialog()
    End Sub

    Private Sub txtCod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod.KeyDown

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtCod.Text = "" Then
                txtQtd.Focus()
                Exit Sub
            End If

            txtCod.Text = txtCod.Text.ToUpper


            Try
                '    'pgProdutoEstoque(txtCod.Text)
                '    'PreencheTela()
                VendeItem()
                '    'txtCod.Text = ""
                '    'txtCod.Focus()
            Catch ex As Exception
                'frmNaoCadastrado.ShowDialog()
                'pnNaoCadastrado.Visible = True
                'lblNaoCadastrado.Text = "PRODUTO NÃO CADASTRADO"
                'pnNaoCadastrado.Focus()
                Util.log(ex.Message, System.Environment.StackTrace, "")
                txtQtd.Text = "1"
                txtCod.Text = ""
                lbldescricaoSuperior.Text = ""
                txtCod.Focus()
                Return
            End Try
        End If
    End Sub

    Private Sub txtQtd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtd.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtQtd.Text = "" Then
                txtQtd.Text = "1"
            End If
            txtCod.Focus()
        End If
    End Sub
    Private Sub cancelarNota()
        If strStatusCupom.ToLower = "fechado" Then
            frmCancelamentoNFCe.ShowDialog()
        Else
            CaixaLivre()
        End If
    End Sub
    Private Sub cancelarItem()
        Dim ic As Integer

        Try
            'Caso nao haja itens nao executa o codigo
            If cupom.countItens <= 0 Then Exit Sub

            ic = InputBox("Digite o código do item a ser cancelado", "Cancelamento de item")

            If cupom.countItens > 0 Then
                Dim itemExcluido As New prod
                Try

                    itemExcluido = cupom.item(ic - 1)
                Catch
                End Try

                'Exclui o Item
                If cupom.removerItem(ic) = True Then

                    addLinhaFitaTela("#", "###", "ITEM " & ic.ToString.PadLeft(3, "0") & " CANCELADO    ", itemExcluido.qCom, itemExcluido.uCom, itemExcluido.vUnCom, itemExcluido.vProd)

                    'lblTotalGeral.Text = FormatCurrency(cupom.nfce.infNFE.Total.IcmsTot.vNF)
                    'If sTamanho < 310 Then
                    '    sTamanho = sTamanho + 23
                    '    slocation = slocation - 23
                    '    pnCupom.Location = New Point(15, slocation)
                    '    pnCupom.Height = sTamanho
                    'End If

                End If

            End If

        Catch ex As Exception
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
    End Sub

    Private Function checarValorVenda(ByVal vlUnit As Double) As Boolean
        Dim continuar As Boolean = False
        If vlUnit <= 0 Then
            frmNaoCadastrado.lblMensagem.Text = "PRODUTO SEM VALOR DE VENDA"
            frmNaoCadastrado.ShowDialog()
            txtCod.Text = ""
            'MsgBox("ITEM BLOQUEADO" & vbCrLf & _
            '     "Item com valor de venda inferior ou igual a zero! Favor notificar!", _
            '    MsgBoxStyle.Information, "Aviso")
            continuar = False
        Else

            continuar = True
        End If

        Return continuar
    End Function

    Private Function checarProdutoCadastrado(ByVal CodProd As String) As Boolean
        Dim continuar As Boolean = False
        If CodProd = "" Then
            frmNaoCadastrado.lblMensagem.Text = "PRODUTO NÃO CADASTRADO"
            frmNaoCadastrado.ShowDialog()
            txtCod.Text = ""
            continuar = False
        Else

            continuar = True
        End If

        Return continuar
    End Function

    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress
        e.KeyChar = SoNumeros(txtCod.Text, e.KeyChar, 0)
    End Sub

    Private Sub txtCod_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCod.MouseLeave

    End Sub

    Private Sub txtCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod.TextChanged

    End Sub

    Private Sub txtQtd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtd.KeyPress
        e.KeyChar = SoNumeros(txtQtd.Text, e.KeyChar, 3)

    End Sub

    Private Sub addLinhaFitaTela(ByVal item As String, _
                                 ByVal codBarr As String, _
                                 ByVal descricao As String, _
                                 ByVal qtd As String, _
                                 ByVal unid As String, _
                                 ByVal vUnit As String, _
                                 ByVal vTotal As String)
        'Adiciona uma linha a lista da tela

        If dgvProdutos.Rows.Count > 0 Then 'IR PARA O FINAL DA LINHA DO GRID - EDUARDO SILVA 20/10/2014
            Dim sCount As String = dgvProdutos.RowCount - 1
            dgvProdutos.CurrentCell = dgvProdutos.Rows(sCount).Cells(0)
        End If


        dgvProdutos.Rows.Add(item, codBarr, _
                             descricao, _
                             qtd, _
                             unid, _
                             FormatCurrency(vUnit), _
                             FormatCurrency(vTotal))

        If item.Trim.ToLower = "#" Then
            If sTamanho < 310 Then
                sTamanho = sTamanho + 23
                slocation = slocation - 23
                pnCupom.Location = New Point(15, slocation)
                pnCupom.Height = sTamanho
            End If
            '06.11.15 - Removido colocar o cancelamento em vermelho (NAO DEU CERTO)
            'dgvProdutos.Rows(dgvProdutos.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
        End If



        If cupom.countItens = 0 Then
            lblValorUnitario.Text = FormatCurrency(0)
            lblSubTotal.Text = FormatCurrency(0)
            lblTotalGeral.Text = FormatCurrency(0)
        Else
            lblValorUnitario.Text = FormatCurrency(cupom.item(cupom.countItens - 1).vUnCom) 'FormatCurrency(Cupom.nfce.infNFE.Det(Cupom.countItens - 1).Prod.vUnCom)
            lblSubTotal.Text = FormatCurrency(cupom.item(cupom.countItens - 1).vProd) 'FormatCurrency(Cupom.nfce.infNFE.Det(Cupom.countItens - 1).Prod.vProd)
            lblTotalGeral.Text = FormatCurrency(cupom.vCupom) 'FormatCurrency(Cupom.nfce.infNFE.Total.IcmsTot.vNF)
        End If


    End Sub

    Private Sub imprimirCupom()
        Dim numCupom As String
        Dim modelo As String

        Try
            numCupom = InputBox("Digite: " & vbCrLf & " Número da nota fiscal " & vbCrLf & "         ou" & vbCrLf & "<P> seguido do número do pedido", "Impressão")

            'Caso nao digite nada sai da sub
            If numCupom.Trim = "" Then Exit Sub

            Dim nfDAO As New NFeDAO
            Dim nfce As New NFCe
            Dim eSefaz As New EnvioSEFAZUniNFe


            If numCupom.ToString.ToUpper.Contains("P") Then
                numCupom = numCupom.ToString.ToUpper.Replace("P", "")
                modelo = "P"
            Else
                modelo = "65"
            End If
            nfce = nfDAO.pgNfe(numCupom, modelo)
            eSefaz.imprimirDanfe(nfce.Id)

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        'Try
        '    Dim Mytext As String = String.Format("{0:N3}", Double.Parse(txtQtd.Text))
        '    txtQtd.Text = Mytext
        'Catch ex As Exception
        '    txtQtd.Text = "0,000"
        '    Dim Mytext As String = String.Format("{0:N3}", Double.Parse(txtQtd.Text))
        '    txtQtd.Text = Mytext
        'End Try
    End Sub
    ''' <summary>
    ''' 
    ''' 31/08/2015 - Leonardo Aquino
    ''' 
    ''' Inicia uma Thread para analise e conclusao
    ''' de notas em aberto na base de dados
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub analiseNotasPendentes()



        'Checa se a thread ja finalizou o processo
        Try
            If thread.IsAlive Then
                'Nao terminou
                Exit Sub
            Else
                'Terminou
                bsCNPJ.Text = "CNPJ:  " & strCNPJ
            End If
        Catch ex As Exception
            'thread ainda nao instanciada
        End Try

        'Analisa se a ultima analise foi a 30 minutos
        Dim difDate As Integer = DateDiff(DateInterval.Minute, ultimaAnalise, Now())
        'MsgBox(ultimaAnalise & vbCrLf & difDate)
        If difDate >= 30 Then
            ultimaAnalise = Now
            ultimaAnalise = ultimaAnalise.AddMinutes(30)
        Else
            Exit Sub
        End If


        'Checa se o caixa esta em funcionamento 
        'Em caso positivo ira abandonar o processo
        'evitando lentidao e sobrecarga no sistema
        If strStatusCupom.ToLower = "aberto" Then
            Exit Sub
        End If

        'Checa se o pc esta com internet
        If Util.internet = False Then
            Exit Sub
        End If

        'Checa se existe notas em aberto
        Dim nfeDAO As New NFeDAO
        Dim notas As New List(Of NFCe)
        notas = nfeDAO.listarNFeSemRegistroSEFAZ()
        If notas.Count <= 0 Then
            bsCNPJ.Text = "CNPJ:  " & strCNPJ
            Exit Sub
        Else

            bsCNPJ.Text = "Analisando Notas Pendentes..."
            'Instancia a classe responsavel pela
            'e execucao dos processos
            Dim sitNFCe As New SefazSituacaoNFCe

            'Inicia a Thread
            thread = New Threading.Thread(AddressOf sitNFCe.executar)
            thread.Start()

        End If


    End Sub

    Private Sub emitirCupomTXT()
        Dim ln As List(Of String)
        If Not File.Exists(Application.StartupPath & "\cupom.txt") Then Exit Sub
        ln = Util.lerTXT(Application.StartupPath & "\cupom.txt")
        For Each l As String In ln
            Dim i As String() = l.Split("|")
            txtQtd.Text = i(1)
            txtCod.Text = ""
            txtCod.Text = i(0)
            VendeItem()
        Next

    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        pagamento("DN")
    End Sub
    Private Sub pagamento(Optional ByVal formaDePagamento As String = "")
        If cupom.vCupom = 0 Then Exit Sub

        If formaDePagamento.Trim <> "" Then
            If FrmPagamento.carregarForm(cupom, formaDePagamento.ToUpper) = True Then
                CaixaLivre()
            End If
        Else
            If FrmPagamento.carregarForm(cupom) = True Then
                CaixaLivre()
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        pagamento("CC")
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        pagamento("CD")
    End Sub
End Class
