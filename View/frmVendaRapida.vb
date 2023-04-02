Public Class frmVendaRapida
    Dim iModoEdicao As Integer '0 Desativado - 1 Ativado
    Private Function checarProdutoCadastrado(ByVal CodProd As String) As Boolean
        Dim continuar As Boolean = False
        If CodProd = "" Then
            MessageBoxPadrao("OPS, Produto não cadastrado!")
            continuar = False
        Else

            continuar = True
        End If

        Return continuar
    End Function
    Public Sub InicializarBotoes()
        On Error Resume Next ' CASO A IMAGEM NAO ESTEJA MAIS NO LOCAL INDICADO.
        Dim iContador As Integer = 0
        Dim strBotao, strNome, strCaminhoImagem As String
        Dim ibt As New Object
        For count = 0 To 65
            iContador = iContador + 1
            strBotao = "bt" & iContador
            strNome = LeArquivoINI(localPath & "\Config.ini", "BOTOES", strBotao & "NOME", "NULL")

            'If incluido para que o sistema nao execute as tarefas abaixo sem
            'necessidade, deixando o processo mais lento
            If strNome.ToString.ToLower <> "null" Then
                strCaminhoImagem = LeArquivoINI(localPath & "\Config.ini", "BOTOES", strBotao & "IMG", "")
                ibt = Me.Controls.Item(strBotao)
                ibt.text = strNome
                ibt.Image = Image.FromFile(strCaminhoImagem)
            End If
        Next count

    End Sub
    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click, bt2.Click, bt3.Click, _
        bt4.Click, bt5.Click, bt6.Click, bt7.Click, bt8.Click, bt9.Click, bt10.Click, _
        bt11.Click, bt12.Click, bt13.Click, bt14.Click, bt15.Click, bt16.Click, bt17.Click, bt18.Click, bt19.Click, bt20.Click, bt21.Click, bt22.Click, bt23.Click, bt24.Click, _
        bt25.Click, bt26.Click, bt27.Click, bt28.Click, bt29.Click, bt30.Click, bt31.Click, bt32.Click, bt33.Click, bt34.Click, bt35.Click, bt36.Click, bt37.Click, bt38.Click, _
        bt39.Click, bt40.Click, bt41.Click, bt42.Click, bt43.Click, bt44.Click, bt45.Click, bt46.Click, bt47.Click, bt48.Click, bt49.Click, bt50.Click, bt51.Click, bt52.Click, _
         bt53.Click, bt54.Click, bt55.Click, bt56.Click, bt57.Click, bt58.Click, bt59.Click, bt61.Click, bt62.Click, _
        bt63.Click, bt64.Click, bt65.Click

        Dim prod As New Produto
        Dim strCodigo, strNome As String

        If iModoEdicao = 1 Then
            frmConfigurarBotao.lblBotaoAtual.Text = DirectCast(sender, DevExpress.XtraEditors.SimpleButton).Name
            frmConfigurarBotao.lblBotaoAtual.Refresh()
            frmConfigurarBotao.ShowDialog()
        Else
            strCodigo = LeArquivoINI(localPath & "\Config.ini", "BOTOES", DirectCast(sender, DevExpress.XtraEditors.SimpleButton).Name & "CODIGO", "")
            strNome = LeArquivoINI(localPath & "\Config.ini", "BOTOES", DirectCast(sender, DevExpress.XtraEditors.SimpleButton).Name & "NOME", "")

            If strCodigo = "" Then
                'MessageBoxPadrao("OPS, Botão não configurado, Verifique!")
                Exit Sub
            End If

            'VERIFICA SE O CÓDIGO ESTÁ CADASTRADO NO SISTEMA
            prod = pgProdutoEstoque(strCodigo)
            If checarProdutoCadastrado(prod.codigoBarras) = False Then Exit Sub
            '------------------------------------------------

            'MANDA O ITEM PARA O PDV
            frmCaixa.txtCod.Text = strCodigo
            frmCaixa.VendeItem()
            lblvalortotal.Text = frmCaixa.lblTotalGeral.Text
            'Me.Text = "MIXPDV - VENDA RÁPIDA  || TOTAL: " & frmCaixa.lblTotalGeral.Text & " ||"
            '-------------------------------------------------

            'ABRIR TARJA INFORMANDO ITEM ADICIONADO
            lblItemPN.Text = strCodigo & "-" & strNome
            lblItemPN.Refresh()
            pnExibirItem.Visible = True
            pnExibirItem.Refresh()
            Esperar(400)
            pnExibirItem.Visible = False
            pnExibirItem.Refresh()
            '--------------------------------------------------

            dgListarItens.Rows.Add(strCodigo, strNome, "")


        End If


    End Sub

    Private Function pgProdutoEstoque(ByVal cod_barra As String) As Produto
        Dim p As New Produto
        'p.codigoBarras = cod_barra
        p.pesqProdutoCodBarr(cod_barra)
        Return p
    End Function
    Private Sub bt72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfigurar.Click

        If iModoEdicao = 0 Then
            Dim result = MessageBox.Show("Gostaria de configurar os botões?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = MsgBoxResult.Yes Then
                btConfigurar.Text = "CONCLUIR"
                btConfigurar.ImageIndex = 1
                btConfigurar.Image = ImageList1.Images(1)
                btConfigurar.Refresh()
                iModoEdicao = 1
                Me.BackColor = Color.Maroon
                Me.Text = "MIXPDV - VENDA RÁPIDA -> (MODO EDIÇÃO)"
            Else
                MessageBoxPadrao("Configuração Cancelada.")
                Exit Sub
            End If
        Else
            MessageBoxPadrao("Alteração Concluida.")
            btConfigurar.Text = "CONFIGURAR"
            iModoEdicao = 0
            btConfigurar.ImageList = "0"
            btConfigurar.Image = ImageList1.Images(0)
            btConfigurar.Refresh()
            Me.BackColor = Color.DimGray
            Me.Text = "MIXPDV - VENDA RÁPIDA"

        End If
    End Sub

    Private Sub frmVendaRapida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmVendaRapida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "MIXPDV - VENDA RÁPIDA TOTAL: " & frmCaixa.lblTotalGeral.Text
        btConfigurar.Text = "CONFIGURAR"
        btConfigurar.Refresh()
        iModoEdicao = 0
        btConfigurar.Image = ImageList1.Images(0)

        'INICIALIZAR BOTOES
        InicializarBotoes()
    End Sub

   
End Class