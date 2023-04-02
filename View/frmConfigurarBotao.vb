Imports System.Management
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Security
Public Class frmConfigurarBotao
    Public strBotaoAtual As String


    Private Sub txtNome_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.EditValueChanged
        btEditado.Text = txtNome.Text
        btEditado.Refresh()
    End Sub

    Private Sub cmdGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGravar.Click
        'localPath = Application.StartupPath

        WritePrivateProfileString("BOTOES", lblBotaoAtual.Text & "CODIGO", txtCodigo.Text, localPath & "\Config.ini")
        WritePrivateProfileString("BOTOES", lblBotaoAtual.Text & "NOME", txtNome.Text, localPath & "\Config.ini")
        WritePrivateProfileString("BOTOES", lblBotaoAtual.Text & "IMG", txtCaminhoIMG.Text, localPath & "\Config.ini")
        frmVendaRapida.InicializarBotoes()
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'define as propriedades do controle
        ofd1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        If dr = System.Windows.Forms.DialogResult.OK Then
            ' Le os arquivos selecionados
            For Each arquivo As [String] In ofd1.FileNames
                txtCaminhoIMG.Text = ""
                txtCaminhoIMG.Text += arquivo
                btEditado.Image = Image.FromFile(Me.txtCaminhoIMG.Text)
                btEditado.Refresh()
                Try
                    ' Aqui fica o que deve ser executado com os arquivos selecionados
                Catch ex As SecurityException
                    ' O usuário  não possui permissão para ler arquivos
                    MessageBox.Show((("Erro de segurança Contate o administrador de segurança da rede." & vbLf & vbLf & "Mensagem : ") + ex.Message & vbLf & vbLf & "Detalhes (enviar ao suporte):" & vbLf & vbLf) + ex.StackTrace)
                    Util.log(ex.Message, System.Environment.StackTrace, "")
                Catch ex As Exception
                    ' Não pode carregar o arquivo (problemas de permissão)
                    MessageBox.Show(("Não é possível exibir a imagem : " & arquivo.Substring(arquivo.LastIndexOf("\"c))))
                    Util.log(ex.Message, System.Environment.StackTrace, "")
                End Try
            Next
        End If
    End Sub
End Class