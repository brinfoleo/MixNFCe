Public Class frmPedidos

    Private _obj As Object
    Private _id As Integer
    Private _campo As String = ""

    Private Sub txtCriterio_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCriterio.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            cancelar()
        End If
    End Sub

    Private Sub txtCriterio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCriterio.TextChanged
        carregaGrade()
    End Sub
    Public Function loadForm() As Integer

        carregaGrade()
        Me.ShowDialog()
        Return _id
    End Function
    Private Sub carregaGrade()
        Dim nfeDAO As New NFeDAO

        dgvResultado.DataSource = nfeDAO.listarPedidosNoPeriodo(txtInicial.Value, txtFinal.Value).Tables("myTable")
        dgvResultado.Refresh()
        '_obj.listarProdutos(_campo, txtCriterio.Text).Tables("myTable")
        ' FormatarGridPesquisa()
    End Sub

    Private Sub pegarCelulaId()
        'Pega o Id do registro e fecha o form
        Try
            _id = dgvResultado.CurrentRow.Cells(0).Value
        Catch ex As Exception
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

    End Sub
    Private Sub aplicar()
        Me.Text = _id
        Me.Hide()
    End Sub

    Private Sub cancelar()
        _id = 0
        Me.Hide()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancelar()
    End Sub

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        aplicar()
    End Sub

    Private Sub frmPesquisa_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCriterio.Focus()
    End Sub
    Private Sub frmPesquisa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' ESC - Sair do sistema 
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            cancelar()
        ElseIf e.KeyCode = Windows.Forms.Keys.Down Then
            dgvResultado.Focus()
        End If
    End Sub

    Private Sub frmPesquisa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            SendKeys.SendWait("{TAB}")
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub frmPesquisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvResultado.DataSource = ""
        dgvResultado.Refresh()
        txtCriterio.Text = ""
    End Sub

    Private Sub dgvResultado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvResultado.CellContentClick

    End Sub

    Private Sub dgvResultado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvResultado.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Para não deixar passar para a próxima linha do DataGrid quando pressionar ENTER
            e.SuppressKeyPress = True
            If dgvResultado.RowCount = 0 Then Exit Sub

            Try
                frmCaixa.txtCod.Text = dgvResultado.CurrentRow.Cells(1).Value
                frmCaixa.VendeItem()
                Me.Hide()

            Catch ex As Exception
                Util.log(ex.Message, System.Environment.StackTrace, "")
                'MessageBox.Show("Item não selecionado", "PDVControl ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Close()

        End If
    End Sub
    Public Sub FormatarGridPesquisa()
        'dgvResultado.Columns(0).HeaderText = "ID"
        'dgvResultado.Columns(0).Width = 60
        dgvResultado.Columns(0).Visible = False

        dgvResultado.Columns(1).HeaderText = "CÓD.BARRAS"
        dgvResultado.Columns(1).Width = 160

        dgvResultado.Columns(2).HeaderText = "NOME"
        dgvResultado.Columns(2).Width = 665

        dgvResultado.Columns(3).HeaderText = "UN"
        dgvResultado.Columns(3).Width = 50

        dgvResultado.Columns(4).HeaderText = "VENDA"
        dgvResultado.Columns(4).Width = 110
        dgvResultado.Columns(4).DefaultCellStyle.Format = "n"

        dgvResultado.RowHeadersVisible = False
        dgvResultado.ReadOnly = True

    End Sub

    Private Sub btnListar_Click(sender As System.Object, e As System.EventArgs) Handles btnListar.Click
        carregaGrade()
    End Sub
End Class