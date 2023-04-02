Public Class frmAtualizaBD
   
    Public Sub abrir()
        Dim produto As New Produto()
        Me.Show()
        produto.atualizaTabelaDataBase()
        MsgBox("fim do processo")
        Me.Hide()
    End Sub
End Class