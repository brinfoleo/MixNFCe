Public Class frmMenuPrincipal

    Private Sub cmdConfig_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdConfig.ItemClick
        frmConfiguracoes.ShowDialog()
    End Sub

    Private Sub cmdAtualizaBanco_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdAtualizaBanco.ItemClick
        frmAtualizaBD.ShowDialog()
    End Sub

    Private Sub cmdCadProdutos_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdCadProdutos.ItemClick
        frmProduto.ShowDialog()
    End Sub

    Private Sub cmdFechamentoCaixa_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdFechamentoCaixa.ItemClick
        frmRelGerencial.ShowDialog()
    End Sub

    Private Sub cmdLocalizarProdutos_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdLocalizarProdutos.ItemClick

    End Sub

    Private Sub cmdrecebimentos_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdrecebimentos.ItemClick
        frmFormaPgto.ShowDialog()
    End Sub

    Private Sub cmdVoltarPDV_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdVoltarPDV.ItemClick
        Me.Hide()
    End Sub

    Private Sub cmdSair_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdSair.ItemClick
        End
    End Sub

    Private Sub cmdClientes_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdClientes.ItemClick
        frmClientes.ShowDialog()
    End Sub

    Private Sub cmdUsuarios_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdUsuarios.ItemClick
        frmUsuario.ShowDialog()
    End Sub

    Private Sub cmdSangriaSuprimento_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles cmdSangriaSuprimento.ItemClick
        frmSangriaSuprimento.ShowDialog()
    End Sub
End Class