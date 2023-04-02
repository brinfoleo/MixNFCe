Public Class frmGerandoNFCe
    Private cp As New Cupom


    Private Sub frmGerandoNFCe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        position()
        lstMsg.Items.Add("Gerando xml")

        'Checa a madalidade de envio de NFCe
        If modalidadeNT = 0 Then
            cp.nfce.infNFE.ide.[mod] = "65"

        ElseIf modalidadeNT = 1 Then
            If MsgBox("Deseja emitir Documento Fiscal (NFCe)?", MsgBoxStyle.YesNo, "Emissão de documento Fiscal") = MsgBoxResult.Yes Then
                cp.nfce.infNFE.ide.[mod] = "65"
            Else
                cp.nfce.infNFE.ide.[mod] = "P"
            End If
        ElseIf modalidadeNT = 2 Then
            cp.nfce.infNFE.ide.[mod] = "P"
        End If




        Dim gXML As New GeraXML
        gXML.executar(cp.nfce)
        lstMsg.Items.Add("NFCe gerada")




        'Envia XML Gerado a SEFAZ
        Dim esu As New EnvioSEFAZUniNFe()
        esu.executar(cp.nfce)
        
        Me.Close()
    End Sub
    Public Sub loadForm(ByVal cpm As Cupom)
        cp = cpm
        lstMsg.Items.Clear()
        Me.ShowDialog()

    End Sub
    Private Sub position()
        Me.Left = ((Screen.PrimaryScreen.WorkingArea.Width - Me.Width))
        Me.Top = ((Screen.PrimaryScreen.WorkingArea.Height - Me.Height))
        Me.Refresh()
    End Sub
End Class