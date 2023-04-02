Imports System.Data.SQLite
Imports System.Net

Public Class frmLogin
    Public ds As DataSet
    Public valSenha As Integer = 0
    Public daUsuarios As SQLiteDataAdapter
    Private Sub ListarUsuarios()
        Try
            Dim sql As String = ""
            sql += " Select id,usuario,senha from usuario"
            sql += " Order by usuario "
            Dim cx As New Conexao()
            cx.Conectar()
            daUsuarios = New SQLiteDataAdapter(sql, cx.c)
            ds = New DataSet

            daUsuarios.Fill(ds, "usuario")
            cbUsuarios.ValueMember = "id"
            cbUsuarios.DisplayMember = "usuario"
            cbUsuarios.DataSource = ds.Tables("usuario")
            cx.Desconectar()
        Catch ex As Exception
            MessageBoxPadrao("Banco de dados não encontrado!" & ex.Message)
            Util.log(ex.Message, System.Environment.StackTrace, "")
            End
        End Try

    End Sub

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cbUsuarios.Focus()

    End Sub
    Private Sub VerificarSenha() 'Eduardo Silva '23/10/2014
        Dim count As Integer = 0
        Dim dr As DataRow
        For Each dr In ds.Tables("Usuario").Rows
            If dr("id") = cbUsuarios.SelectedValue Then
                If dr("senha") = txtSenha.Text Then
                    valsenha = 1
                End If
            End If
        Next
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            End
        End If
    End Sub
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obter o endereço IP:
        Dim IPHI As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
        Dim IPA As IPAddress = IPHI.AddressList.GetValue(1)

        InicializacaoSistemas() 'CARREGA TODOS OS PARAMETROS DO SISTEMA - EDUARDO SILVA 20/10/2014
        ListarUsuarios()
        tsPC.Text = Mid(Environment.MachineName, 1, 11)
        tsIP.Text = "IP: " & IPA.ToString

        With My.Application.Info.Version
            tsVersao.Text = "Version " & .Major & "." & .Minor & " (Build " & .Build & "." & .Revision & ")"
        End With

        cbUsuarios.Text = GetSetting("MixPDV", "Config", "Login", "") ' CAPTURA O ULTIMO USUARIO LOGADO


      


        cbUsuarios.Focus()
        cbUsuarios.SelectAll()
    End Sub
    Private Sub VerificaPermissao()
        'Eduardo silva 23/10/2014

        Dim cx As New Conexao()

        Dim sql As String
        sql = ""
        sql += " Select id, usuario, senha, cargo from usuario "
        sql += " where usuario = '" & strUsuarioLogado & "' "
        cx.Conectar()
        Dim cdm As New SQLiteCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As SQLiteDataReader = cdm.ExecuteReader
        If dr.Read Then
            strTipoAcesso = dr.Item("cargo") 'se tipo igual a True acesso total, se igual a False acesso restrito somente a venda.
            'Seta os dados do usuario

            Dim usuDAO As New UsuarioDAO

            usuarioOnLine = usuDAO.read(dr.Item("id"))

            'usuarioOnLine.id = dr.Item("id")
            'usuarioOnLine.nome = dr.Item("usuario")
            'usuarioOnLine.senha = dr.Item("senha")
            'usuarioOnLine.cargo = dr.Item("cargo")

        End If
        cx.Desconectar()
    End Sub

    Private Sub Entrar()
        VerificarSenha()
        If valsenha = 1 Then
            txtSenha.Text = ""
            strUsuarioLogado = cbUsuarios.Text
            VerificaPermissao()

            SaveSetting("MixNFc", "Config", "Login", cbUsuarios.Text)
            'AtribuiAcesso()


            Me.Hide()
            'If strTipoAcesso = True Then
            frmCaixa.lblAcesso.Text = "| Tipo de Acesso: " & usuarioOnLine.cargo & " |"
            'Else
            '   frmCaixa.lblAcesso.Text = "| Tipo de Acesso: " & "Caixa |"
            'End If
            frmCaixa.lblUsuario.Text = "| Usuário: " & strUsuarioLogado
            frmCaixa.ShowDialog()

        Else
            MessageBoxPadrao("Login ou Senha inválidos")
            txtSenha.Text = ""
        End If
    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Entrar()
        End If
    End Sub

    Private Sub cmdEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntrar.Click
        Entrar()
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        End
    End Sub
    Private Sub cbUsuarios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbUsuarios.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txtSenha.Focus()
        End If
    End Sub

   
End Class