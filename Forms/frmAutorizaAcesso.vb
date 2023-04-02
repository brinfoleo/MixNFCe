Imports MySql.Data.MySqlClient

Public Class frmAutorizaAcesso
    Public ds As DataSet
    Public daUsuarios As MySqlDataAdapter
    Private bAutorizado As Boolean = False
    Private Sub ListarUsuarios()
        Try
            Dim sql As String = ""
            sql += " Select id,usuario,senha from usuario"
            sql += " Order by usuario "
            Dim cx As New Conexao()
            cx.Conectar()
            daUsuarios = New MySqlDataAdapter(sql, cx.c)
            ds = New DataSet

            daUsuarios.Fill(ds, "usuario")
            cbUsuarios.ValueMember = "id"
            cbUsuarios.DisplayMember = "usuario"
            cbUsuarios.DataSource = ds.Tables("usuario")
            cx.Desconectar()
        Catch ex As Exception
            MessageBoxPadrao("Banco de dados não encontrado!")
            End
        End Try

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
        sql += " Select id, usuario, senha, supervisor from usuario "
        sql += " where senha = '" & txtSenha.Text & "' "
        cx.Conectar()
        Dim cdm As New MySqlCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As MySqlDataReader = cdm.ExecuteReader
        If dr.Read Then
            strTipoAcesso = dr.Item("supervisor") 'se tipo igual a True acesso total, se igual a False acesso restrito somente a venda.

            If strTipoAcesso = True Then
                ' strAcessoPermitido = "LIBERADO"
                bAutorizado = True
                pcbAberto.Visible = True
                pcbFechado.Visible = False
                pcbAberto.Refresh()
                Esperar(1000)
                Me.Hide()
            Else
                bAutorizado = False
                Dim i As Integer
                For i = 0 To 10
                    Esperar(50)
                    Me.Location = New Point(450, 299)
                    Me.Location = New Point(450, 303)
                Next
                Me.Location = New Point(450, 300)
                txtSenha.Text = ""
                txtSenha.Focus()
            End If
        Else
            bAutorizado = False
            Dim i As Integer
            For i = 0 To 10
                Esperar(50)
                Me.Location = New Point(450, 299)
                Me.Location = New Point(450, 303)
            Next
            Me.Location = New Point(450, 300)
            txtSenha.Text = ""
            txtSenha.Focus()
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

            End Try

            Liberar = bAutorizado
        End If

    End Function
    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtSenha.Text = "" Then
                cbUsuarios.Focus()
            Else
                VerificaPermissao()
            End If
        End If
    End Sub

    Private Sub cbUsuarios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbUsuarios.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txtSenha.Focus()
            txtSenha.Text = ""
        End If
    End Sub

    Private Sub txtSenha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSenha.TextChanged

    End Sub
End Class