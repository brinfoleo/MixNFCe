Public Class frmMenu

    Private Sub cmdCadastroProduto_Click(sender As System.Object, e As System.EventArgs) Handles cmdCadastroProduto.Click
        frmProduto.ShowDialog()
        'frmProduto.Close()
    End Sub

    Private Sub cmdSair_Click(sender As System.Object, e As System.EventArgs) Handles cmdSair.Click
        frmCaixa.Show()
        Me.Hide()
    End Sub

    Private Sub cmdCliente_Click(sender As System.Object, e As System.EventArgs) Handles cmdCliente.Click
        frmClientes.ShowDialog()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frmAtualizaBD.abrir()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        frmUsuario.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        Dim prod As New Produto
        Dim id As Integer
        id = frmPesquisa.loadForm(prod)
        MsgBox("Id selecionado: " & id)
    End Sub

    Private Sub frmMenu_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmCaixa.Show()
        Me.Hide()
    End Sub

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        frmRelGerencial.ShowDialog()
    End Sub
End Class