Imports System.Management
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAtivacao

    Private Sub frmAtivacao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If strStatusAtivacao = "BLOQUEADO" Then
            MessageBox.Show("Código de Ativação não informado." & vbCrLf & "O sistema será fechado!", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End If
    End Sub
    Private Sub frmAtivacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRazao.Text = strRazao
        lblCnpj.Text = strCNPJ
    End Sub

    Private Sub cmdValidarAtivacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValidarAtivacao.Click
        If txtserial.Text = "" Then
            MessageBox.Show("O Sistema expirou seu período de uso." & vbCrLf & "Informe o código!", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtserial.Focus()
            Exit Sub
        End If
        sGravaSerial = "S"
        If ValidaChaveAcesso(strCnpjAtivacao, strUltimaAtivacao, "", "", "") Then
            If strStatusAtivacao = "LIBERADO" Then
                Util.logWeb("Sistema liberado por código de ativação.")
                Me.Close()
            Else
                MessageBox.Show("O código Inválido.", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                strStatusAtivacao = "BLOQUEADO"
                txtserial.Text = ""
                txtserial.Focus()
            End If
        Else
            MessageBox.Show("O código Inválido.", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub btCodigoOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCodigoOnline.Click

        MessageBox.Show("Ops!!! Em Desenvolvimento!", "Gerenciamento de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub

        'Dim conn As New MySqlConnection
        'Dim myCommand As New MySqlCommand
        'Dim myAdapter As New MySqlDataAdapter
        'Dim myData As New DataTable
        'Dim SQL As String

        ''Conectando Banco de Dados ----------------------------------
        'conn = New MySqlConnection
        'conn.ConnectionString = "server=mysql01.SERVIDOR.com.br ;user id=USUARIO;password=SENHA;database=BANCO"

        'SQL = "SELECT * FROM `clientes` WHERE `cpfcgc`='" & strCNPJ & "'"

        'Try
        '    conn.Open()
        '    Try
        '        myCommand.Connection = conn
        '        myCommand.CommandText = SQL
        '        myAdapter.SelectCommand = myCommand
        '        myAdapter.Fill(myData)
        '    Catch myerro As MySqlException
        '        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
        '    End Try

        '    Dim var_codigo_online As String
        '    Dim sMensagem As String
        '    If myData.Rows.Count = 0 Then
        '        MessageBox.Show("Ops!!! Algo errado, verifique se o usuário está cadastrado no servidor da  MIXPDV", "Gerenciamento de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        '    var_codigo_online = myData.Rows(0).Item("chave_acesso2").ToString()
        '    sMensagem = myData.Rows(0).Item("mensagem").ToString()
        '    Me.txtserial.Text = var_codigo_online
        '    conn.Close()

        'Catch myerro As MySqlException
        '    MessageBox.Show("Erro ao conectar o servidor, Verifique sua conexão com a internet.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Finally
        '    conn.Dispose()
        'End Try

    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub
End Class