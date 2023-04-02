
Imports MySql.Data.MySqlClient

Public Class FrmPagamento

    Public ds As DataSet
    Public daFormaPgto As MySqlDataAdapter

    Private Sub cmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Listar_Formapgto()

        Try
            Dim sql As String = ""
            sql = ""
            sql = "SELECT * FROM `formapgto`"
            Dim cx As New Conexao()
            cx.Conectar()
            daFormaPgto = New MySqlDataAdapter(sql, cx.c)
            ds = New DataSet

            daFormaPgto.Fill(ds, "formapgto")
            cboFormaPgto.ValueMember = "nomepg"
            cboFormaPgto.DisplayMember = "nomepg"
            cboFormaPgto.DataSource = ds.Tables("formapgto")
            cx.Desconectar()
        Catch ex As Exception
            MessageBoxPadrao("Banco de dados não encontrado!")
            End
        End Try

    End Sub
    

    Private Sub FrmPagamento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cboFormaPgto.Focus()
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmPagamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmPagamento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Listar_Formapgto()
        dgvRecebimentos.Rows.Clear()
        txtValorEntrada.Text = ""
        txtSaldo.Text = txtTotalVenda.Text

    End Sub

    Private Sub cboFormaPgto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFormaPgto.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            txtValorEntrada.Focus()
        End If
    End Sub

    Private Sub txtValorEntrada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValorEntrada.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then

            If txtValorEntrada.Text = "" Then
                cboFormaPgto.Focus()
            Else
                dgvRecebimentos.Rows.Add(cboFormaPgto.Text, FormatCurrency(txtValorEntrada.Text))

            End If
        End If
    End Sub

    Private Sub txtValorEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorEntrada.TextChanged

    End Sub
End Class