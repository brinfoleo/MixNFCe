Public Class frmProduto
    Private produto As New Produto
    Private campo As String


    Private Sub cmdGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGravar.Click



        produto.id = IIf(txtId.Text.Trim = "", 0, txtId.Text)
        produto.descricao = txtDescricao.Text
        produto.fabricante = txtFabricante.Text
        produto.ncm = txtNCM.Text
        produto.codigoBarras = txtCodigoBarras.Text
        produto.unidade = txtUnidade.Text
        produto.quantidade = IIf(txtQuantidade.Text.Trim = "", 0, txtQuantidade.Text)
        produto.cofins = IIf(txtCOFINS.Text.Trim = "", 0, txtCOFINS.Text)
        produto.pis = IIf(txtPIS.Text.Trim = "", 0, txtPIS.Text)
        produto.icms = IIf(txtICMS.Text.Trim = "", 0, txtICMS.Text)
        produto.origem = cboOrigem.SelectedValue
        produto.cst = cboCST.SelectedValue
        produto.cfop = cboCFOP.SelectedValue
        produto.ncm = txtNCM.Text
        produto.precoCusto = Convert.ToDouble(IIf(txtCusto.Text.Trim = "", 0, txtCusto.Text))
        produto.precoVenda = Convert.ToDouble(IIf(txtVenda.Text.Trim = "", 0, txtVenda.Text))
        If produto.save() = True Then
            MsgBox("Registro atualizado com sucesso!")
            limparForm()
            carregarGrid()
        End If

    End Sub

    Private Sub frmProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmProduto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub frmProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Util.acesso(Me, 3)
        carregarGrid()
        carregarOrigem()
    End Sub
    Public Sub FormatarGrid_Produtos()


        dgvProdutos.Columns(0).Visible = False
        'dgvProdutos.Columns(0).HeaderText = "CÓDIGO"
        dgvProdutos.Columns(1).HeaderText = "CÓDIGO"
        dgvProdutos.Columns(1).Width = "100"

        dgvProdutos.Columns(2).HeaderText = "DESCRIÇÃO"
        dgvProdutos.Columns(2).Width = "295"

        dgvProdutos.Columns(3).HeaderText = "UN"
        dgvProdutos.Columns(3).Width = "30"

        dgvProdutos.Columns(4).HeaderText = "PREÇO"
        dgvProdutos.Columns(4).Width = "80"
        dgvProdutos.Columns(4).DefaultCellStyle.Format = "n"


        dgvProdutos.Columns(0).Width = "120"



        dgvProdutos.ScrollBars = ScrollBars.Both
        dgvProdutos.RowHeadersVisible = False
        dgvProdutos.ReadOnly = True
    End Sub
    Private Sub carregarGrid()
        Dim produto As New Produto
        If txtPesquisa.Text.Trim = "" Then

            dgvProdutos.DataSource = produto.listarProdutos("", "").Tables("myTable")
            FormatarGrid_Produtos()

        Else
            dgvProdutos.DataSource = produto.listarProdutos(campo, txtPesquisa.Text.Trim).Tables("myTable")
        End If

    End Sub

    Private Sub carregarOrigem()
        Dim orig As New CstDAO(1)
        cboOrigem.DataSource = orig.listarOrigens.Tables("myTable")
        cboOrigem.ValueMember = "codigo"
        cboOrigem.DisplayMember = "conjugada"

        cboCST.DataSource = orig.listarCSOSNs.Tables("myTable")
        cboCST.ValueMember = "codigo"
        cboCST.DisplayMember = "conjugada"

        Dim cfop As New CfopDAO(1)
        cboCFOP.DataSource = cfop.listarCfop.Tables("myTable")
        cboCFOP.ValueMember = "codigo"
        cboCFOP.DisplayMember = "conjugada"

    End Sub


    Private Sub cmdLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpar.Click
        limparForm()
    End Sub




    Private Sub limparForm()
        produto.id = 0
        txtId.Text = ""
        txtDescricao.Text = ""
        txtCodigoBarras.Text = ""
        txtFabricante.Text = ""
        txtUnidade.Text = ""
        txtQuantidade.Text = ""
        txtNCM.Text = ""
        cboOrigem.Text = ""
        cboCST.Text = ""
        cboCFOP.Text = ""
        txtPIS.Text = ""
        txtCOFINS.Text = ""
        txtICMS.Text = ""
        txtCusto.Text = ""
        txtVenda.Text = ""
    End Sub

    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        If produto.id = 0 Then
            MsgBox("Selecione um registro.")
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do registro: " + vbCrLf + produto.descricao, vbYesNo) = vbYes Then
            produto.delete()
            produto.id = 0
            limparForm()
        End If
    End Sub
    Private Sub dgvProdutos_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        campo = dgvProdutos.Columns(e.ColumnIndex).HeaderText
    End Sub

    Private Sub txtVenda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVenda.TextChanged
        Util.TextBoxMoeda(txtVenda)
    End Sub
    Private Sub txtCusto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusto.TextChanged
        Util.TextBoxMoeda(txtCusto)
    End Sub

    Private Sub dgvProdutos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdutos.CellDoubleClick
        Dim id As Integer

        limparForm()

        id = dgvProdutos.CurrentRow.Cells(0).Value
        produto.id = id
        produto.read()
        txtId.Text = produto.id
        txtDescricao.Text = produto.descricao
        txtCodigoBarras.Text = produto.codigoBarras
        txtFabricante.Text = produto.fabricante
        txtUnidade.Text = produto.unidade
        txtQuantidade.Text = produto.quantidade
        txtNCM.Text = produto.ncm
        cboOrigem.SelectedValue = produto.origem
        cboCST.SelectedValue = IIf(produto.cst.Trim = "", 0, produto.cst.Trim)
        cboCFOP.SelectedValue = IIf(produto.cfop.Trim = "", 0, produto.cfop.Trim)
        txtPIS.Text = produto.pis
        txtCOFINS.Text = produto.cofins
        txtICMS.Text = produto.icms
        txtCusto.Text = cMoeda(produto.precoCusto)
        txtVenda.Text = cMoeda(produto.precoVenda)
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub txtPesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        carregarGrid()
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Hide()
    End Sub


    Private Sub txtNCM_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNCM.KeyPress
        e.KeyChar = SoNumeros(txtNCM.Text, e.KeyChar, 0)
    End Sub

End Class