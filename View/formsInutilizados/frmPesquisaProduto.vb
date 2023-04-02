Imports System.Data.SQLite

Public Class frmPesquisaProduto

    Private Sub txtNomeProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNomeProduto.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            dgvProdutosEncontrados.Focus()
        End If
    End Sub

    Private Sub txtNomeProduto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomeProduto.TextChanged
        Dim cx As New Conexao()
        Dim daEmpresa As New SQLiteDataAdapter
        Dim sql As String = ""

        sql = ""
        sql += " Select codi, nome, unidade, venda1  from produto "
        sql += "WHERE nome LIKE '%" & Trim(txtNomeProduto.Text) & "%'"

        cx.Conectar()
        daEmpresa = New SQLiteDataAdapter(sql, cx.c)
        Dim ds As DataSet
        ds = New DataSet
        daEmpresa.Fill(ds, "produto")
        dgvProdutosEncontrados.DataSource = ds.Tables("produto")

        If ds.Tables("produto").Rows.Count() <> 0 Then
            FormatarGrid()
        Else
            dgvProdutosEncontrados.DataSource = ""
        End If
        cx.Desconectar()
    End Sub

    Private Sub FormatarGrid()

        dgvProdutosEncontrados.Columns(0).HeaderText = "CÓD.BARRAS"
        dgvProdutosEncontrados.Columns(1).HeaderText = "DESCRIÇÃO"
        dgvProdutosEncontrados.Columns(2).HeaderText = "UN"
        dgvProdutosEncontrados.Columns(3).HeaderText = "VALOR VENDA"

        dgvProdutosEncontrados.Columns(0).Width = 100
        dgvProdutosEncontrados.Columns(1).Width = 520
        dgvProdutosEncontrados.Columns(2).Width = 30
        dgvProdutosEncontrados.Columns(3).Width = 120

        dgvProdutosEncontrados.DefaultCellStyle.Format = "c"

    End Sub

    Private Sub frmPesquisaProduto_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNomeProduto.Focus()
    End Sub

    Private Sub frmPesquisaProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmPesquisaProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNomeProduto.Text = ""
        txtNomeProduto.Focus()
        dgvProdutosEncontrados.DataSource = ""
        dgvProdutosEncontrados.Refresh()
    End Sub

    Private Sub cmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVoltar.Click
        Me.Close()

    End Sub

    Private Sub dgvProdutosEncontrados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvProdutosEncontrados.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvProdutosEncontrados.RowCount = 0 Then Exit Sub
            Dim linha As Integer
            linha = dgvProdutosEncontrados.CurrentRow.Index
            Try
                strCodBarrasGeral = dgvProdutosEncontrados.Rows(linha).Cells(0).Value
                frmCaixa.txtCod.Text = dgvProdutosEncontrados.Rows(linha).Cells(0).Value
            Catch ex As Exception
                MessageBoxPadrao("Item não selecionado.")
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try
            'Para não deixar passar para a próxima linha do DataGrid quando pressionar ENTER
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
            End If

            Close()

        End If
        'Para não deixar passar para a próxima linha do DataGrid quando pressionar ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Close()
        End If
    End Sub


    Private Sub dgvProdutosEncontrados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdutosEncontrados.CellContentClick

    End Sub
End Class