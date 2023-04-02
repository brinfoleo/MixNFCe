Imports System.IO
Public Class frmMixTouch

    Private Sub frmMixTouch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' CARREGAR A LOGO PADRAO DO SISTEMA E A LOGO CLIENTE
        If File.Exists(Application.StartupPath & "\sysimg") Then
            Me.PC_System.BackgroundImage = Image.FromFile(Application.StartupPath & "\sysimg")
            PC_System.Refresh()
        End If
        '----------------------------------------------------
    End Sub

    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        frmRecebimentoDinheiro.ShowDialog()
    End Sub

    Private Sub cmdClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClientes.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub BackstageViewControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackstageViewControl1.Click
        BackstageViewControl1.Controller.AddClient("LD")

    End Sub
End Class