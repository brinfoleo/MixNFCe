Imports System.Data.SQLite

Public Class frmAutorizaAcesso
    Public ds As DataSet
    Public daUsuarios As SQLiteDataAdapter
    Private bAutorizado As Boolean = False
    Private _usu As Usuario
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
            MessageBoxPadrao("Banco de dados não encontrado!")
            Util.log(ex.Message, System.Environment.StackTrace, "")
            End
        End Try

    End Sub
    Public Function formLoad() As Usuario

        limparCampos()
        Me.ShowDialog()

        Return _usu
    End Function
    Private Sub limparCampos()
        txtSenha.Text = ""
    End Sub
    Private Sub frmAutorizaAcesso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(450, 300)
        pcbAberto.Visible = False
        pcbFechado.Visible = True
        ListarUsuarios()
    End Sub
    Public Sub VerificaPermissao() 'Eduardo silva 23/10/2014

        Dim cx As New Conexao()
        Dim sql As String
        sql = ""
        sql += " Select id, usuario, senha, cargo FROM usuario "
        sql += " where senha = '" & txtSenha.Text & "' "
        cx.Conectar()
        Dim cdm As New SQLiteCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As SQLiteDataReader = cdm.ExecuteReader
        If dr.Read Then
            lblMsg.Visible = False
            Dim uDAO As New UsuarioDAO
            _usu = New Usuario
            _usu = uDAO.read(dr.Item("id"))
            Me.Close()
            'strTipoAcesso = dr.Item("cargo") 'se tipo igual a True acesso total, se igual a False acesso restrito somente a venda.

            'If strTipoAcesso = True Then
            ' ' strAcessoPermitido = "LIBERADO"
            ' bAutorizado = True
            ' pcbAberto.Visible = True
            ' pcbFechado.Visible = False
            ' pcbAberto.Refresh()
            ' Esperar(1000)
            ' Me.Hide()
            'Else
            'bAutorizado = False
            'Dim i As Integer
            'For i = 0 To 10
            ' Esperar(50)
            ' Me.Location = New Point(450, 299)
            ' Me.Location = New Point(450, 303)
            ' Next
            ' Me.Location = New Point(450, 300)
            ' txtSenha.Text = ""
            ' txtSenha.Focus()
            'End If
            'Else
            'bAutorizado = False
            'Dim i As Integer
            'For i = 0 To 10
            ' Esperar(50)
            ' Me.Location = New Point(450, 299)
            ' Me.Location = New Point(450, 303)
            ' Next
            ' Me.Location = New Point(450, 300)
            ' txtSenha.Text = ""
            ' txtSenha.Focus()
        Else
            lblMsg.Text = "Login/Senha invalida..."
            lblMsg.Visible = True
        End If
        cx.Desconectar()
    End Sub
    Public Function Liberar() As Boolean

        Liberar = False
        If strTipoAcesso = True Then
            Liberar = True
            bAutorizado = Liberar
        Else
            'txtUsuario.Text = String.Empty
            txtSenha.Text = String.Empty
            Try
                Me.ShowDialog()

            Catch ex As Exception
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try

            Liberar = bAutorizado
        End If

    End Function
    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            _usu = Nothing
            bAutorizado = False
            Me.Hide()
        End If
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtSenha.Text = "" Then
                cbUsuarios.Focus()
            Else
                VerificaPermissao()
            End If
        End If
    End Sub

    Private Sub cbUsuarios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbUsuarios.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            bAutorizado = False
            Me.Hide()
        End If

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txtSenha.Focus()
            txtSenha.Text = ""
        End If
    End Sub
    Public Function validarAcesso() As Boolean
        Me.ShowDialog()
        Return bAutorizado
    End Function

    Private Sub txtSenha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSenha.TextChanged

    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class