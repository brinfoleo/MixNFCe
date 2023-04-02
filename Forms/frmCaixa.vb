Imports MySql.Data.MySqlClient

Public Class frmCaixa
    Dim sTamanho As Integer
    Dim slocation As Integer = 518
    Dim strStatusCupom As String = "Fechado"
    Dim strItem As Integer
    Dim strCodBarra, strDescricao, strTipoUn As String
    Dim strValorUn As Double

    Private Sub frmCaixa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            If pnNaoCadastrado.Visible = True Then
                pnNaoCadastrado.Visible = False
                lblNaoCadastrado.Focus()
                txtCod.Focus()
                Exit Sub
            End If
            Dim result = MessageBox.Show("Gostaria de sair do sistema?", "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = MsgBoxResult.Yes Then
                End
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F1 Then
            FrmPagamento.txtTotalVenda.Text = lblTotalGeral.Text
            FrmPagamento.ShowDialog()
        ElseIf e.KeyCode = Windows.Forms.Keys.F4 Then
            frmClientes.ShowDialog()
        ElseIf e.KeyCode = Windows.Forms.Keys.F9 Then
            If strStatusCupom = "Fechado" Then
                MessageBoxPadrao("Não existe cupom aberto para ser cancelado!")
                Exit Sub
            End If
            If strTipoAcesso = True Then
                CaixaLivre()
            Else
                If Not frmAutorizaAcesso.Liberar Then
                    Exit Sub
                End If
                CaixaLivre()
                strTipoAcesso = False
            End If
        ElseIf e.KeyCode = Windows.Forms.Keys.F10 Then
            Me.Hide()
            frmMenu.ShowDialog()


        ElseIf e.KeyCode = Windows.Forms.Keys.F11 Then
            frmConsultaProduto.ShowDialog()
        ElseIf e.KeyCode = Windows.Forms.Keys.Space Then
            frmPesquisaCliente.txtNome.Focus()
            frmPesquisaProduto.ShowDialog()
        End If
    End Sub

    Private Sub frmCaixa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CarregaBarraStatus() 'CARREGA TODOS OS PARAMETROS DO SISTEMA - EDUARDO SILVA 20/10/2014
        txtCod.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PreencheTela()
        VendeItem()
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
            lblCupomLinha2.Text = "CNPJ: " & strCNPJ & "     " & "I.E.: " & strIE
            lblCupomLinha3.Text = "End: " & strEnd & "-" & strBairro & "-" & strCidade & "-" & strUF
            lblCupomLinha4.Text = "N.Cupom: " & "99999999" & " Date: " & strDateCupom.ToString("dd/MM/yyyy") & " Hora:" & strDateCupom.ToString("HH:mm:ss")
            '-------------------------
            tmrRelogio.Enabled = False
            lbldescricaoSuperior.Text = ""
        ElseIf sTamanho < 310 Then
            sTamanho = sTamanho + 23
            slocation = slocation - 23
            pnCupom.Location = New Point(15, slocation)
            pnCupom.Height = sTamanho
        End If
        If dgvProdutos.Rows.Count > 0 Then 'IR PARA O FINAL DA LINHA DO GRID - EDUARDO SILVA 20/10/2014
            Dim sCount As String = dgvProdutos.RowCount - 1
            dgvProdutos.CurrentCell = dgvProdutos.Rows(sCount).Cells(0)
        End If
    End Sub
    Private Sub VendeItem()
        Dim strValorTotal As Double
        Dim strTotalGeral As Double
        Dim strSubSotal As Double
        strValorTotal = strValorUn * txtQtd.Text
        lblValorUnitario.Text = FormatCurrency(strValorUn)
        lblSubTotal.Text = strValorUn * txtQtd.Text
        lblSubTotal.Text = FormatCurrency(lblSubTotal.Text)

        strTotalGeral = lblTotalGeral.Text
        strSubSotal = lblSubTotal.Text
        strTotalGeral = strTotalGeral + strSubSotal
        lblTotalGeral.Text = FormatCurrency(strTotalGeral)
        lbldescricaoSuperior.Text = strDescricao
        'INCLUIR ITEM E SOMA - EDUARDO SILVA 20/10/2014
        strItem = strItem + 1

        dgvProdutos.Rows.Add(strItem, strCodBarra, strDescricao, txtQtd.Text, strTipoUn, Format(strValorUn, "Standard"), Format(strValorTotal, "Standard"))

        txtQtd.Text = "1"
        '------------------------------------------------
    End Sub
    Private Sub VerificaPermissao() 'Eduardo silva 23/10/2014

        Dim cx As New Conexao()
        Dim sql As String
        sql = ""
        sql += " Select id, usuario, senha, supervisor from usuario "
        sql += " where usuario = '" & strUsuarioLogado & "' "
        cx.Conectar()
        Dim cdm As New MySqlCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As MySqlDataReader = cdm.ExecuteReader
        If dr.Read Then
            strTipoAcesso = dr.Item("supervisor") 'se tipo igual a True acesso total, se igual a False acesso restrito somente a venda.
        End If
        cx.Desconectar()
    End Sub
    Private Sub ExisteBarra(ByVal cod_barra As String)

        If cod_barra.Length = 0 Then
            txtCod.Focus()
            Throw New Exception("Preencha o Código Barra !")
        End If
        Dim cx As New Conexao()
        Dim sql As String
        sql = ""
        sql += " Select codi, nome, unidade, venda1  from produto "
        sql += " Where codi = '" + cod_barra + "'"
        cx.Conectar()
        Dim cdm As New MySqlCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As MySqlDataReader = cdm.ExecuteReader
        If dr.Read Then
            strCodBarra = dr.Item("codi")
            strDescricao = dr.Item("nome")
            strTipoUn = dr.Item("unidade")
            strValorUn = dr.Item("venda1")
        Else
            cdm.Dispose()
            dr.Dispose()
            dr.Close()
            cx.Desconectar()
            Throw New Exception("Código Barra não Cadastrado ! " + cod_barra)
        End If
        cdm.Dispose()
        dr.Dispose()
        dr.Close()
        cx.Desconectar()
    End Sub
    Private Sub CarregaBarraStatus()
        'CARREGAR BARRA DE STATUS - EDUARDO SILVA 20/10/2014
        bsCNPJ.Text = "CNPJ:  " & strCNPJ
        bsRazao.Text = "| EMPRESA: " & strRazao
        bsLoja.Text = "| LOJA: " & strLoja
        bsPDV.Text = "| PDV:" & strPDV
        bsAtivacao.Text = "| ATIVAÇÃO: 0000000000"
        bsExpira.Text = "| EXPIRA: 10/10/2015"
        '---------------------------------------------------
    End Sub
    Public Sub CaixaLivre() 'DEIXA O CAIXA EM ESTADO INICIAL PARA PRÓXIMA VENDA - EDUARDO SILVA 20/10/2014
        sTamanho = 20
        pnCupom.Height = sTamanho
        slocation = 500
        pnCupom.Location = New Point(15, slocation)
        lblCaixalivre.Text = "CAIXA LIVRE"
        strStatusCupom = "Fechado"
        dgvProdutos.Rows.Clear()
        dgvProdutos.Refresh()
        'tmrRelogio.Enabled = True
        strItem = 0
        lblSubTotal.Text = "R$ 0,00"
        lblTotalGeral.Text = "R$ 0,00"
        lblValorUnitario.Text = "R$ 0,00"
        'lbldescricaoSuperior.Text = ""
        txtCod.Focus()
    End Sub
    Private Sub gpMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gpMenu.MouseMove
        gpMenu.Location = New Point(0, 0)
    End Sub

    Private Sub frmCaixa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        gpMenu.Location = New Point(0, -95)
        txtCod.Focus()
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        frmConfiguracoes.ShowDialog()
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        End
    End Sub

    Private Sub tmrRelogio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRelogio.Tick
        Dim strHora As Date = DateTime.Now
        lbldescricaoSuperior.Text = "Data: " & strHora.ToString("dd/MM/yyyy") & "   Hora: " & strHora.ToString("HH:mm:ss")
    End Sub

    Private Sub cmdFinalizadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinalizadores.Click
        frmFormaPgto.ShowDialog()
    End Sub

    Private Sub cmdCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCliente.Click
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
                ExisteBarra(txtCod.Text)
                PreencheTela()
                VendeItem()
                txtCod.Text = ""
                txtCod.Focus()
            Catch ex As Exception
                pnNaoCadastrado.Visible = True
                lblNaoCadastrado.Text = "PRODUTO NÃO CADASTRADO"
                pnNaoCadastrado.Focus()
                txtQtd.Text = "1"
                txtCod.Text = ""
                lbldescricaoSuperior.Text = ""
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
End Class
