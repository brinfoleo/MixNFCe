Public Class frmCancelamentoNFCe
    Private Sub frmCancelamentoNFCe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Refresh()
        Util.acesso(Me, 2)
        txtNumNFCe.Text = ""
        txtMotivo.Text = "Cliente desistiu da compra."
    End Sub

    Private Sub cmdGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGravar.Click
        Dim nfeDAO As New NFeDAO
        Dim nfce As NFCe
        nfce = nfeDAO.pgNfe(txtNumNFCe.Text.Trim)
        If IsNothing(nfce) Then
            MsgBox("Nota Fiscal não encontrada. Ação cancelada!", vbInformation, "Cancelamento")
        Else
            MsgBox("NFCe: " & nfce.Id & "CANCELADA - FALTA TERMINA FUNCAO", vbExclamation, "Cancelamento")
            Me.Close()
        End If
        frmCaixa.CaixaLivre()
        Me.Close()
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub
End Class