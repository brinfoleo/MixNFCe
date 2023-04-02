Public Class frmMenu

    Private Sub cmdCadastroProduto_Click(sender As System.Object, e As System.EventArgs) Handles cmdCadastroProduto.Click
        frmProduto.ShowDialog()

    End Sub

    Private Sub cmdSair_Click(sender As System.Object, e As System.EventArgs) Handles cmdSair.Click
        frmCaixa.Show()
        Me.Hide()
    End Sub

    Private Sub cmdCliente_Click(sender As System.Object, e As System.EventArgs) Handles cmdCliente.Click
        frmClientes.ShowDialog()

    End Sub
End Class