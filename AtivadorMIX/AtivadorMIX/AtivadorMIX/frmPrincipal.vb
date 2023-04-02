Imports Criptografia

Public Class frmPrincipal
    Private _DataAtual As Date = New Date(Now().Year, Now().Month, Now().Day)
    Private Sub cmdGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGerar.Click
        On Error GoTo Erro
        If txtCnpj.Text = "" Then
            MessageBox.Show("Localize o cliente antes de gerar o código.", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If ModuloGeral.validaCpfCnpj(txtCnpj.Text.Trim) = False Then
            Exit Sub
        End If

        '---
        'Dim cripto As New clsCriptografia
        Dim Dias As String
        Dim DataValidade As Date = Date.MinValue

        DataValidade = txtDataExpiracao.Text
        Dias = DateDiff(DateInterval.Day, _DataAtual, DataValidade)
        'GERAR CHAVE 2
        Dim sCnpjChave2 As String

        sCnpjChave2 = txtCnpj.Text
        sCnpjChave2 = Replace(sCnpjChave2, ".", "")
        sCnpjChave2 = Replace(sCnpjChave2, "-", "")
        sCnpjChave2 = Replace(sCnpjChave2, "/", "")
        If Len(sCnpjChave2) < 14 Then
            sCnpjChave2 = Mid(sCnpjChave2, 10, 5)
        Else
            sCnpjChave2 = Mid(sCnpjChave2, 13, 7)
        End If


        Dim A1 As String = sCnpjChave2
        Dim B1 As String = CDate(txtDataExpiracao.Text).ToString("yyyyMMdd")

        Dim chave As ULong = Convert.ToUInt64(A1) * Convert.ToUInt64(B1) * 3972849

        txtChave2.Text = CStr(chave)

        lblbloqueio.Text = "Bloqueio programado para " + Dias + " Dias."

        Dim Result As DialogResult
        Exit Sub

Erro:
        txtChave2.Text = "ERRO - Verifique se os valores de chave e data limite da licença estão corretos"
        MsgBox(Err.Description)

        '-------------------------------------------FIM

    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click
        MessageBox.Show("EU FALEI DEPOIS. 'VIADINHO CURIOSO.' Heheheheheeh", "KKKKKKKKKKKK", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
