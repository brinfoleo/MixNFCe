Imports MySql.Data.MySqlClient

Public Class frmConsultaProduto

    Private Sub txtCodProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProduto.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtCodProduto.Text = "" Then
                txtCodProduto.Focus()
                Exit Sub
            End If

            Try
                lblNaocadastrado.Visible = False
                ExisteBarra(txtCodProduto.Text)
                txtCodProduto.Text = ""
                txtCodProduto.Focus()
            Catch ex As Exception
                lblNaocadastrado.Visible = True
                txtCodProduto.Focus()
                txtCodProduto.Text = ""
                lblPrecoVenda.Text = ""
                lblDescricao.Text = ""
                Return
            End Try
        ElseIf e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()

        End If
    End Sub
    Private Sub ExisteBarra(ByVal cod_barra As String)

        If cod_barra.Length = 0 Then
            txtCodProduto.Focus()
            Throw New Exception("Preencha o Código Barra !")
        End If
        Dim cx As New Conexao()
        Dim sql As String
        sql = ""
        sql += " Select codi, nome, unidade, venda1  from produto "
        sql += " Where codi = '" + cod_barra + "'"
        cx.Conectar()
        Dim cdm As New MySqlCommand
        cdm.Connection = cx.c
        cdm.CommandText = sql
        Dim dr As MySqlDataReader = cdm.ExecuteReader
        If dr.Read Then
            lblDescricao.Text = dr.Item("nome")
            lblPrecoVenda.Text = FormatCurrency(dr.Item("venda1"))
        Else
            cdm.Dispose()
            dr.Dispose()
            dr.Close()
            cx.Desconectar()
        End If
        cdm.Dispose()
        dr.Dispose()
        dr.Close()
        cx.Desconectar()
    End Sub

    Private Sub frmConsultaProduto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDescricao.Text = ""
        lblNaocadastrado.Visible = False
        lblPrecoVenda.Text = ""
    End Sub
End Class