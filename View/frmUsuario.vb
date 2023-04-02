Public Class frmUsuario
    Private usuario As New Usuario


    Private Sub cmdGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGravar.Click
        Dim usuDAO As New UsuarioDAO

        usuario.id = txtId.Text
        usuario.nome = txtNome.Text
        usuario.cargo = cboCargo.Text
        If usuDAO.save(usuario) = True Then
            MsgBox("Registro atualizado com sucesso")
            limparForm()
            carregarGrid()
        End If

    End Sub

    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Util.acesso(Me, 3)
        carregarGrid()
        carregarcombo()
    End Sub
    Private Sub carregarGrid()
        Dim usuDAO As New UsuarioDAO
        If txtPesquisa.Text.Trim = "" Then
            dgvProdutos.DataSource = usuDAO.listarUsuarios.Tables("myTable")
        Else
            dgvProdutos.DataSource = usuDAO.listarUsuariosEspecificos(txtPesquisa.Text).Tables("myTable")
        End If
        dgvProdutos.Columns.Remove("senha")

       
    End Sub

    Private Sub cmdLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpar.Click
        limparForm()
    End Sub

    Private Sub dgvProdutos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

  


    Private Sub limparForm()
        usuario.id = 0
        txtId.Text = ""
        txtNome.Text = ""
        cboCargo.Text = ""

    End Sub

    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim usuDAO As New UsuarioDAO
        If usuario.id = 0 Then
            MsgBox("Selecione um registro.")
            Exit Sub
        End If
        If MsgBox("Confirma a exclusão do registro: " + vbCrLf + usuario.nome, vbYesNo) = vbYes Then

            usuDAO.delete(usuario.id)
            usuario.id = 0
            limparForm()
        End If
    End Sub

   

    Private Sub dgvProdutos_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdutos.CellEnter
        Dim id As Integer
        Dim usuDAO As New UsuarioDAO
        limparForm()

        id = dgvProdutos.CurrentRow.Cells(0).Value
        usuario.id = id
        usuario = usuDAO.read(id)
        txtId.Text = id
        txtNome.Text = usuario.nome
        cboCargo.Text = usuario.cargo

    End Sub

    Private Sub txtPesquisa_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        carregarGrid()

    End Sub

    Private Sub carregarcombo()
        
        With cboCargo
            .Items.Add("Caixa")
            .Items.Add("Fiscal")
            .Items.Add("Supervisor")

        End With
    End Sub

  
    Private Sub dgvProdutos_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProdutos.CellContentClick

    End Sub
End Class