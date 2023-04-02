Public Class frmSangriaSuprimento

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        cancelar()
    End Sub
    Private Sub cbOperacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbOperacao.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txtValor.Focus()
        End If

    End Sub

    Private Sub frmSangriaSuprimento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cbOperacao.Focus()
    End Sub

    Private Sub txtValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyDown
        'If e.KeyCode = Windows.Forms.Keys.Enter Then
        '    MessageBoxPadrao("Em Desenvolvimento!")
        '    Me.Hide()
        'End If
    End Sub

    Private Sub cmdContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContinuar.Click
        Dim cx As New Caixa
        Dim cxDAO As New CaixaDAO
        cx.documento = Format(Now, "HHmmss")
        cx.codigo = 0 'cbOperacao.Text
        cx.descricao = cbOperacao.Text
        cx.data = Today
        cx.moeda = cbOperacao.Text.Trim  '"Dinheiro"
        cx.valor = IIf(cbOperacao.Text = "SUPRIMENTO", txtValor.Text, "-" & txtValor.Text)
        cx.cd = IIf(cbOperacao.Text = "SUPRIMENTO", "C", "D")
        cx.usuario = usuarioOnLine

        cxDAO.save(cx)
        cancelar()

    End Sub
    Private Sub cancelar()
        Me.Hide()
    End Sub
    
End Class