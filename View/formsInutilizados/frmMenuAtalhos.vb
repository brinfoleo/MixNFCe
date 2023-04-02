Public Class frmMenuAtalhos

    Private Sub frmMenuAtalhos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCodigo.Focus()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text = "01" Then
            frmCaixa.AbriClientes()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "02" Then
            frmFormaPgto.ShowDialog()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "03" Then
            frmProduto.ShowDialog()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "04" Then
            frmUsuario.ShowDialog()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "05" Then
            Dim p As New Produto
            Dim idProd As Integer
            idProd = frmPesquisa.loadForm(p)
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "06" Then
            frmRelGerencial.ShowDialog()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "07" Then
            frmAtualizaBD.abrir()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "08" Then
            frmConfiguracoes.ShowDialog()
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "09" Then
            Me.Hide()
            frmSangriaSuprimento.ShowDialog()
            'MessageBoxPadrao("Em Desenvolvimento!")
            txtCodigo.Text = ""
        ElseIf txtCodigo.Text = "10" Then
            Me.Hide()
            txtCodigo.Text = ""

        End If

    End Sub

    Private Sub frmMenuAtalhos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCodigo.Text = ""
    End Sub
End Class