
Imports System.Data.SQLite


Public Class FrmPagamento

    Public ds As DataSet
    Public daFormaPgto As SQLiteDataAdapter
    Private vApagar As Double
    Private vendaFinalizada As Boolean = False 'Sinaliza se o pagamento foi efetuado corretamente
    Private cp As Cupom
    Private _Pags As List(Of pag)

    ''' <summary>
    ''' Forma de Pagamento
    ''' 01 - Dinheiro
    ''' 02 - Cheque
    ''' 03 - Cartao Creditito
    ''' 04 - Cartao Debito
    ''' 05 - Credito Loja
    ''' 10 - Vale Alimentacao
    ''' 11 - Vale Refeicao
    ''' 12 - Vale Presente
    ''' 13 - Vale Combustivel
    ''' 99 - Outros
    ''' </summary>
    ''' <remarks></remarks>
    Private fp As Integer


    Private Sub FrmPagamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        ' ESC - Sair do sistema
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            'Close()
            limparTela()
            'F2  - Dinheiro
        ElseIf e.KeyCode = Windows.Forms.Keys.F2 Then
            mudarBotoes(btnF2)
        ElseIf e.KeyCode = Windows.Forms.Keys.F3 Then
            mudarBotoes(btnF3)
        ElseIf e.KeyCode = Windows.Forms.Keys.F4 Then
            mudarBotoes(btnF4)
        ElseIf e.KeyCode = Windows.Forms.Keys.F5 Then
            mudarBotoes(btnF5)
        ElseIf e.KeyCode = Windows.Forms.Keys.F6 Then
            mudarBotoes(btnF6)
        ElseIf e.KeyCode = Windows.Forms.Keys.F7 Then
            mudarBotoes(btnF7)
        ElseIf e.KeyCode = Windows.Forms.Keys.F8 Then
            mudarBotoes(btnF8)
        ElseIf e.KeyCode = Windows.Forms.Keys.F9 Then
            mudarBotoes(btnF9)
        End If
        
    End Sub
    Private Sub cmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    ''' <summary>
    ''' 26/11/2015 - Leonardo Aquino
    ''' Carrega a tela de finalização dos pagamentos
    ''' </summary>
    ''' <param name="cupom">Classe do cupom</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function carregarForm(ByRef cupom As Cupom) As Boolean
        cp = cupom
        Me.vApagar = cp.vCupom
        informarTotais()
        Me.ShowDialog()

        Return vendaFinalizada
    End Function
    ''' <summary>
    ''' 26/11/2015 - Leonardo Aquino
    ''' Finaliza a venda conforme o paramentro passado na string fechaVenda
    ''' </summary>
    ''' <param name="cupom">Classe do cupom </param>
    ''' <param name="fechaVenda">DN - Dinheiro / CC - Cartao Credito / CD - Cartao Debito</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function carregarForm(ByRef cupom As Cupom, ByVal fechaVenda As String) As Boolean
        cp = cupom
        Select Case fechaVenda
            Case "DN" ' Dinheiro
                mudarBotoes(btnF2)
                'incluirPagamento(cp.vCupom)

            Case "CC" ' Cartao Credito
                mudarBotoes(btnF4)
                'incluirPagamento(cp.vCupom)
            Case "CD" 'Cartao debito
                mudarBotoes(btnF5)
                'incluirPagamento(cp.vCupom)
        End Select
        Dim p As New pag
        _Pags = New List(Of pag)
        p.tPag = fp
        p.vPag = cp.vCupom
        _Pags.Add(p)

        fecharVenda()

        'Me.vApagar = cp.vCupom
        Return vendaFinalizada
    End Function
    Private Sub limparTela()
        If dgvRecebimentos.RowCount <> 0 Then
            informarTotais()
            dgvRecebimentos.Rows.Clear()
            txtValorEntrada.Text = ""
            txtvSaldo.Text = txtApagar.Text
            mudarBotoes(btnLimpaForm)

        Else
            Close()
        End If
    End Sub

    Private Sub informarTotais()
        txtTroco.Text = FormatCurrency(0)
        txtPago.Text = FormatCurrency(0)
        txtApagar.Text = FormatCurrency(vApagar)
        txtvSaldo.Text = FormatCurrency(vApagar)
    End Sub

    'Private Sub Listar_Formapgto()

    '    Try
    '        Dim sql As String = ""
    '        sql = "SELECT * FROM formapgto"
    '        Dim cx As New Conexao()
    '        cx.Conectar()
    '        daFormaPgto = New SQLiteDataAdapter(sql, cx.c)
    '        ds = New DataSet

    '        daFormaPgto.Fill(ds, "formapgto")

    '        cboFormaPgto.ValueMember = "tPag"
    '        cboFormaPgto.DisplayMember = "nomepg"
    '        cboFormaPgto.DataSource = ds.Tables("formapgto")
    '        cx.Desconectar()

    '    Catch ex As Exception
    '        MessageBoxPadrao("Banco de dados não encontrado!")
    '        End
    '    End Try

    'End Sub


    'Private Sub FrmPagamento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    '    cboFormaPgto.Focus()
    'End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub




    Private Sub FrmPagamento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Listar_Formapgto()
        dgvRecebimentos.Rows.Clear()
        _Pags = New List(Of pag)
        'limparTela()
        txtValorEntrada.Focus()
    End Sub

    Private Sub cboFormaPgto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Dim v As Double = txtvSaldo.Text
            txtValorEntrada.Text = v
            txtValorEntrada.Focus()
        End If
    End Sub

    Private Sub txtValorEntrada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValorEntrada.KeyDown

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtValorEntrada.Text = "" Then
                txtValorEntrada.Focus()
            Else
                incluirPagamento(txtValorEntrada.Text)
                txtValorEntrada.Focus()
            End If
        End If
    End Sub
    Private Sub incluirPagamento(ByVal vRec As Double)

        'Valor recebido pelo caixa
        'Dim vRec As Double = txtValorEntrada.Text
        'Total ja pago
        Dim vTotPago As Double = calcValorPago()
        'Valor efetiva o pagamento
        Dim vPago As Double

        If fp = 0 Then
            MsgBox("Selecione um tipo de pagamento!", vbInformation, "Aviso")
            txtValorEntrada.Text = ""
            Exit Sub
        End If
        'Valorer a maior somente se for em dinheiro
        'If cboFormaPgto.Text.ToLower <> "dinheiro" Then
        If fp <> 1 Then
            If (vRec + vTotPago) > vApagar Then
                MsgBox("Valor informado acima do saldo devedor. Troco somente se for em dinheiro!", vbExclamation, "Aviso")
                Exit Sub
            End If
        End If


        'Quando o valor pago é igual ou maior que o saldo devedor
        If (vRec + vTotPago) >= vApagar Then
            If (vRec + vTotPago) > vApagar Then
                vPago = vApagar - vTotPago
            Else
                vPago = vRec
            End If

        Else
            vPago = vRec

        End If
        inserirGridValor(vPago)

        Dim vTroco As Double
        Dim vDevedor As Double


        vTroco = (vTotPago + vRec) - vApagar
        If vTroco < 0 Then vTroco = 0
        vDevedor = vApagar - (vTotPago + vRec)
        If vDevedor < 0 Then vDevedor = 0

        'Demonstra nos totalizadores
        txtApagar.Text = FormatCurrency(vApagar)
        txtTroco.Text = FormatCurrency(vTroco)
        txtPago.Text = FormatCurrency(vTotPago + vRec)
        txtvSaldo.Text = FormatCurrency(vDevedor)

        If vDevedor = 0 Then fecharVenda()

        txtValorEntrada.Text = ""

    End Sub
    Private Sub inserirGridValor(ByVal dValor As Double)
        If fp = 0 Then Exit Sub

        'Insere o valor pago ao grid
        Dim v As Double
        With dgvRecebimentos
            For i As Integer = 0 To .Rows.Count - 1
                'Acumula na mesma conficao de pgto os valores lancados
                If .Rows(i).Cells(2).Value = fp Then 'cboFormaPgto.Text Then
                    v = .Rows(i).Cells(1).Value
                    v = dValor + v
                    .Rows(i).Cells(1).Value = FormatCurrency(v)
                    Exit Sub
                End If

            Next
            'Caso nao encontre a informação add valor ao grid
            '.Rows.Add(cboFormaPgto.Text, FormatCurrency(dValor), cboFormaPgto.SelectedValue)
            Dim fpText As String
            Select Case fp
                Case 1 ' 01 - Dinheiro
                    fpText = "Dinheiro"
                Case 2 ' 02 - Cheque
                    fpText = "Cheque"
                Case 3 ' 03 - Cartao Creditito
                    fpText = "Cartão Credito"
                Case 4 ' 04 - Cartao Debito
                    fpText = "Cartão Debito"
                Case 5 ' 05 - Credito Loja
                    fpText = "Credito Loja"
                Case 10 ' 10 - Vale Alimentacao
                    fpText = "Vale Alimentação"
                Case 11 ' 11 - Vale Refeicao
                    fpText = "Vale Refeição"
                Case 12 ' 12 - Vale Presente
                    fpText = "Vale Presente"
                Case 13 ' 13 - Vale Combustivel
                    fpText = "Vale Combustivel"
                Case 99 ' 99 - Outros
                    fpText = "Outros"
                Case Else
                    MsgBox("Condicao não cadastrada")
                    fpText = "[SEM CADASTRO]"
            End Select
            .Rows.Add(fpText, FormatCurrency(dValor), fp)
        End With

    End Sub
    ''' <summary>
    ''' 'Finaliza o processo d pagamento
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub fecharVenda()
        If MsgBox("Deseja finalizar os pagamentos?", vbYesNo + vbInformation, "Fenalização") = vbYes Then
            'Desabilita form pra evitar erros
            'System.Windows.Forms.Application.DoEvents()

            Me.Enabled = False
            'Inclui os pagamentos na NFe
            incluirPgtoNFCe()
            frmGerandoNFCe.loadForm(cp)
            Me.Enabled = True
            vendaFinalizada = True
            Me.Close()


            Exit Sub
        Else
            vendaFinalizada = False
        End If
    End Sub

    Private Function calcValorPago() As Double
        'Retorna o valor ja pago
        Dim i As Integer
        Dim vDevedor As Double
        'Dim parc As pag
        'If _Pags Is Nothing Then
        '    vDevedor = 0
        'Else
        '    For Each parc In _Pags
        '        vDevedor += parc.vPag
        '    Next
        'End If

        



        For i = 0 To dgvRecebimentos.RowCount - 1
            With dgvRecebimentos
                vDevedor += .Rows(i).Cells(1).Value
            End With
        Next
        Return vDevedor
    End Function
    Private Sub incluirPgtoNFCe()
        Dim p As pag
        Dim v As Double
        With dgvRecebimentos
            For i As Integer = 0 To .Rows.Count - 1
                p = New pag
                p.tPag = .Rows(i).Cells(2).Value.ToString.PadLeft(2, "0")
                v = .Rows(i).Cells(1).Value
                p.vPag = v
                _Pags.Add(p)

            Next
        End With

        cp.addPagamento(_Pags)
    End Sub

    Private Sub txtValorEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorEntrada.KeyPress
        e.KeyChar = SoNumeros(txtValorEntrada.Text, e.KeyChar, 2)

    End Sub


    Private Sub txtValorEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorEntrada.TextChanged
        'TextBoxMoeda(txtValorEntrada)
        txtValorEntrada.Text = String.Format("{0:N}", txtValorEntrada.Text)
        txtValorEntrada.SelectionStart = txtValorEntrada.Text.Length
    End Sub


    Private Sub btnF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF2.Click
        mudarBotoes(sender)

    End Sub
    Private Sub mudarBotoes(ByRef btObj As DevExpress.XtraEditors.SimpleButton)
        Dim pgBtn As DevExpress.XtraEditors.SimpleButton
        Dim obj As Object
        For Each obj In Me.Controls
            If TypeOf obj Is DevExpress.XtraEditors.SimpleButton Then
                pgBtn = obj

                If pgBtn.Equals(btObj) Then
                    btObj.Appearance.BackColor = Color.Coral
                    Select Case btObj.Text.ToLower
                        Case "f2-dinheiro"
                            fp = 1
                        Case "f3-cheque"
                            fp = 2
                        Case "f4-cartão de crédito"
                            fp = 3
                        Case "f5-cartão de débito"
                            fp = 4
                        Case "f6-crédito loja"
                            fp = 5
                        Case "f7-vale alimentação"
                            fp = 10
                        Case "f8-vale refeição"
                            fp = 11
                        Case "f9-outros"
                            fp = 99
                        Case Else
                            fp = 0
                    End Select
                Else
                    pgBtn.Appearance.BackColor = Color.RoyalBlue
                End If

            End If

        Next

        txtValorEntrada.Text = ""
        txtValorEntrada.Focus()
    End Sub

    Private Sub btnF3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF3.Click
        mudarBotoes(sender)

    End Sub

    Private Sub FrmPagamento_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        Dim nomeBotao As String
        nomeBotao = sender.name
    End Sub
    Private Sub buttons_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim b As Button = DirectCast(sender, Button)

        MsgBox("Você clicou aqui" & b.Text)
    End Sub


    Private Sub btnF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF4.Click
        mudarBotoes(sender)

    End Sub

    Private Sub btnF5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF5.Click
        mudarBotoes(sender)

    End Sub

    Private Sub btnF9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF9.Click
        mudarBotoes(sender)

    End Sub

    Private Sub btnF7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF7.Click
        mudarBotoes(sender)

    End Sub

    Private Sub btnF8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF8.Click
        mudarBotoes(sender)

    End Sub

    Private Sub btnF6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF6.Click
        mudarBotoes(sender)
    End Sub

    Private Sub btnLimpaForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpaForm.Click
        limparTela()
    End Sub
End Class