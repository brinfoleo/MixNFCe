Imports MySql.Data.MySqlClient

'FORM PARA CADASTRO DE CLIENTES - EDUARDO SILVA 21/10/2014
Public Class frmFormaPgto
    Public da As MySqlDataAdapter

    Public Sub IncluirFormapgto()
        If txtBandeiraTEF.Text = "" Then
            txtBandeiraTEF.Text = "SEM TEF"
        End If

        Dim sql As String = ""
        Dim cx As New Conexao()
        Dim cd As New MySqlCommand()

        Try
            sql += " insert into formapgto (nomepg,bandeira_tef)"
            sql += " values ('" & txtNomePgto.Text & "', '" & txtBandeiraTEF.Text & "')"
            cx.Conectar()
            cd.Connection = cx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cx.Desconectar()
            txtBandeiraTEF.Text = ""
            txtNomePgto.Text = ""
            txtNomePgto.Focus()
        Catch ex As Exception
            cx.Desconectar()
        End Try


    End Sub
    Private Sub ApagarPgto(ByVal nome As String)
        Dim sql As String = ""

        sql += " Delete from formapgto "
        sql += " where nomepg = '" + nome + "'"
        Dim cx As New Conexao()
        cx.Conectar()
        Dim cd As New MySqlCommand()
        cd.Connection = cx.c
        cd.CommandText = sql
        Try
            cd.ExecuteNonQuery()
        Catch ex As Exception
            cx.Desconectar()
        End Try
        cx.Desconectar()
        ListarFormaPGto()
    End Sub
    Public Sub FormatarGrid()

        'TAMANHO
        dgvPagamentos.Columns(0).Width = 220
        dgvPagamentos.Columns(1).Width = 200
        'LABEL
        dgvPagamentos.Columns(0).HeaderText = "FORMA DE PGTO"
        dgvPagamentos.Columns(1).HeaderText = "BANDEIRA TEF"

    End Sub
    Private Sub ExluiFormaPgto()
        Dim strNomePgto As String
        strNomePgto = dgvPagamentos.CurrentRow.Cells(0).Value
        If strNomePgto <> "" Then
            Dim result = MessageBox.Show("Confirma Exclusão da forma de pagamento: " & strNomePgto, "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ' mensagem padrao
            If result = MsgBoxResult.Yes Then
                ApagarPgto(strNomePgto)
                txtBandeiraTEF.Text = ""
                txtNomePgto.Text = ""
                txtNomePgto.Focus()
            End If
        End If
    End Sub
    Private Sub ListarFormaPGto()
        Dim sql As String = ""
        Dim cx As New Conexao()

        Try
            sql = ""
            sql = "SELECT * FROM `formapgto`"
            cx.Conectar()
            da = New MySqlDataAdapter(sql, cx.c)
            Dim ds As DataSet
            ds = New DataSet
            da.Fill(ds, "formapgto")
            If ds.Tables("formapgto").Rows.Count() <> 0 Then
                dgvPagamentos.DataSource = ds.Tables("formapgto")
                dgvPagamentos.Refresh()
                FormatarGrid()
            Else
                dgvPagamentos.DataSource = ""
                dgvPagamentos.Refresh()
            End If

            cx.Desconectar()

        Catch ex As Exception
            MessageBoxPadrao(ex.Message)

            cx.Desconectar()

        End Try

    End Sub

    Private Sub cmdIncluirForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIncluirForma.Click
        IncluirFormapgto()
        ListarFormaPGto()
    End Sub

    Private Sub frmFormaPgto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarFormaPGto()
    End Sub

    Private Sub cmdExluirForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExluirForma.Click
        ExluiFormaPgto()
    End Sub
End Class