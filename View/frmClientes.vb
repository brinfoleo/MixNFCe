Imports System.Data.SQLite
Public Class frmClientes

    Private campo As String = ""
    Private id As Integer
    'FORM PARA CADASTRO DE CLIENTES - EDUARDO SILVA 21/10/2014
    'Alterado em JANEIRO/2015 - Leonardo Aquino

    Public Sub IncluirCliente()

        Dim sql As String = ""
        Dim cx As New Conexao()
        Dim cd As New SQLiteCommand()

        Dim bloqueado As Integer
        'Dim auxcpfcnpj As String
        txtData_cadastro.Text = Date.Now
        bloqueado = chkBloqueado.Checked

        'If rdbfis.Checked = True Then
        ' auxcpfcnpj = txtCpf.Text
        ' Else
        ' auxcpfcnpj = txtCnpj.Text
        ' End If



        Try
            'sql += " INSERT INTO cliente (xNome, xLgr, cep, cpf, rg, telefone, celular, email, data_cadastro, lim_debito, debito, bloqueado, numero,complemento,bairro,cidade,estado,cod_mun,cnpj, obs)"
            'sql += " values ('" & txtNome.Text & "','" + txtEndereco.Text + "','" + txtCep.Text + "','" + txtCpf.Text + "','" + txtRg.Text + "','" + txtTelefone.Text + "','" + txtCelular.Text + "','" + txtEmail.Text + "','" + DataAccessParaMysql(txtData_cadastro.Text) + "'," + CStr(bloqueado) + ",'" + txtNumero.Text + "','" + txtCompl.Text
            'sql += "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "','" + txtCodmun.Text + "','" + Replace(Replace(Replace(txtCnpj.Text, ".", ""), "/", ""), "-", "") + "','" + txtObs.Text + "')"
            'cx.Conectar()
            'cd.Connection = cx.c
            'cd.CommandText = sql
            'cd.ExecuteNonQuery()
            'cx.Desconectar()
            'Carrega o objeto com os dados
            Dim cli As New Cliente

            cli.cnpj = txtCnpj.Text
            cli.xNome = txtNome.Text
            cli.xLgr = txtEndereco.Text
            cli.nro = txtNumero.Text
            cli.xBairro = txtBairro.Text
            cli.xMun = txtCidade.Text
            cli.cMun = txtCodmun.Text
            cli.uf = txtEstado.Text
            cli.cep = txtCep.Text
            cli.email = txtEmail.Text
            cli.obs = txtObs.Text
            cli.bloqueado = chkBloqueado.Checked
            cli.dtCadastro = txtData_cadastro.Text

            'Chama a DAO para gravar na tabela
            Dim cliDAO As New ClienteDAO
            cliDAO.save(cli)

        Catch ex As Exception
            'cx.Desconectar()
            MsgBox(ex.Message)
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try


    End Sub

    Public Sub AlterarCliente()

        Dim sql As String = ""
        Dim cx As New Conexao()
        Dim cd As New SQLiteCommand()

        Dim bloqueado As Integer
        'Dim auxcpfcnpj As String
        txtData_cadastro.Text = Date.Now
        bloqueado = chkBloqueado.Checked

        'If rdbfis.Checked = True Then
        ' auxcpfcnpj = txtCpf.Text
        'Else
        'auxcpfcnpj = txtCnpj.Text
        'End If

        Try
            'sql = ""
            'sql += " Update clientes "
            'sql += " set nome = '" + txtNome.Text + "', "
            'sql += " endereco = '" + txtEndereco.Text + "', "
            'sql += " cep = '" + txtCep.Text + "', "
            'sql += " numero = '" + txtNumero.Text + "', "
            'sql += " complemento = '" + txtCompl.Text + "', "
            'sql += " bairro = '" + txtBairro.Text + "', "
            'sql += " cidade = '" + txtCidade.Text + "', "
            'sql += " estado = '" + txtEstado.Text + "', "
            'sql += " cod_mun  = '" + txtCodmun.Text + "', "
            'sql += " cnpj = '" + Replace(Replace(Replace(txtCnpj.Text, ".", ""), "/", ""), "-", "") + "', "
            'sql += " cpf = '" + txtCpf.Text + "', "
            'sql += " rg = '" + txtRg.Text + "', "
            'sql += " telefone = '" + txtTelefone.Text + "', "
            'sql += " celular = '" + txtCelular.Text + "', "
            'sql += " email = '" + txtEmail.Text + "', "
            'sql += " lim_debito = " + Replace(Replace(txtLim_debito.Text, ".", ""), ",", ".") + ", "
            ''sql += " debito = " + Replace(Replace(txtDebito.Text, ".", ""), ",", ".") + ", "
            'sql += " bloqueado = " + CStr(bloqueado) + ","
            'sql += " obs = '" + txtObs.Text + "' "
            'sql += " where codigo = " + CStr(txtCodigo.Text)

            'cx.Conectar()
            'cd.Connection = cx.c
            'cd.CommandText = sql
            'cd.ExecuteNonQuery()
            'cx.Desconectar()



            'Carrega o objeto com os dados
            Dim cli As New Cliente
            cli.id = txtCodigo.Text
            cli.cnpj = txtCnpj.Text
            cli.xNome = txtNome.Text
            cli.xLgr = txtEndereco.Text
            cli.nro = txtNumero.Text
            cli.xBairro = txtBairro.Text
            cli.xMun = txtCidade.Text
            cli.cMun = txtCodmun.Text
            cli.uf = txtEstado.Text
            cli.cep = txtCep.Text
            cli.email = txtEmail.Text
            cli.obs = txtObs.Text
            cli.dtCadastro = txtData_cadastro.Text
            cli.bloqueado = chkBloqueado.Checked
            'Chama a DAO para gravar na tabela
            Dim cliDAO As New ClienteDAO
            cliDAO.save(cli)
        Catch ex As Exception
            'cx.Desconectar()
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
    End Sub

    Private Sub LimparCampos()
        id = 0
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCep.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        txtCodmun.Text = ""
        txtCnpj.Text = ""
        'txtCpf.Text = ""
        'txtRg.Text = ""
        txtTelefone.Text = ""
        'txtCelular.Text = ""
        txtEmail.Text = ""
        'txtLim_debito.Text = "0,00"
        'txtDebito.Text = "0,00"
        'txtValor.Text = "0,00"
        txtData_cadastro.Text = DateTime.Now.AddDays(0)
        chkBloqueado.Checked = False
        'txtDescricao.Text = ""
        'txtResponsavel.Text = ""
        'txtDt_inicial.Text = ""
        'txtDt_final.Text = ""
        'txtDt_venc.Text = ""
        'txtDt_pag.Text = ""
        txtObs.Text = ""
        'Rdbtodos.Checked = True
        'DgvDebito.DataSource = ""
        'DgvDebito.Refresh()
        StatusGravacao = "I"
    End Sub

    Function BuscaCep(ByVal cep As String) As Hashtable
        Dim ds As DataSet
        Dim _resultado As String
        Dim ht As System.Collections.Hashtable
        Try
            ds = New DataSet()
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml")
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    _resultado = ds.Tables(0).Rows(0).Item("resultado").ToString()
                    ht = New Hashtable
                    Select Case _resultado
                        Case "1"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                            ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim())
                            ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                            ht.Add("tipo", 1)
                            'Preenche os campos 
                            txtEndereco.Text = ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim() & "-" & ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim()
                            txtBairro.Text = ds.Tables(0).Rows(0).Item("bairro").ToString().Trim()
                            txtCidade.Text = ds.Tables(0).Rows(0).Item("cidade").ToString().Trim()
                            txtEstado.Text = ds.Tables(0).Rows(0).Item("uf").ToString().Trim()
                        Case "2"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("tipo", 2)
                            'Preenche campos
                            txtCidade.Text = ds.Tables(0).Rows(0).Item("cidade").ToString().Trim()
                            txtEstado.Text = ds.Tables(0).Rows(0).Item("uf").ToString().Trim()
                        Case Else
                            ht.Add("tipo", 0)

                            MessageBox.Show("CEP não encontrado.", "Ei! - Busca CEP Online", MessageBoxButtons.OK, MessageBoxIcon.Information) ' mensagem padrao

                    End Select

                End If
            End If
            Return ht
        Catch ex As Exception
            MessageBox.Show("Banco de dados não encontrado. Verifique seu acesso a Internet", "Ei! - Busca CEP Online", MessageBoxButtons.OK, MessageBoxIcon.Information) ' mensagem padrao
            Util.log(ex.Message, System.Environment.StackTrace, "")
            Return Nothing
        End Try
    End Function
    Private Sub cmdGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGravar.Click

        If Util.validaCpfCnpj(txtCnpj.Text.Trim) = False Then
            Exit Sub
        End If

        'If StatusGravacao = "A" Then
        If id <> 0 Then
            StatusGravacao = "A"
            If txtCodigo.Text.Length <> 0 Then
                Dim result = MessageBox.Show("Confirma Atualização", "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = MsgBoxResult.Yes Then
                    AlterarCliente()
                End If
            End If
        Else
            'If StatusGravacao = "I" Then
            If id = 0 Then
                StatusGravacao = "I"
                IncluirCliente()
            End If
        End If

        LimparCampos()
        carregarGrid()
    End Sub
    Private Sub cmdLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpar.Click
        LimparCampos()
    End Sub

    Private Sub cmdBuscaCep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscaCep.Click
        BuscaCep(txtCep.Text)
    End Sub

    Private Sub frmClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' ESC - Sair do sistema 
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            id = 0
            Me.Hide()
        End If
    End Sub
    Public Function loadForm() As Cliente
        Dim cliDAO As New ClienteDAO
        Dim cli As Cliente
        cmdAplicar.Visible = True
        carregarGrid()
        Me.ShowDialog()
        If id <> 0 Then
            cli = New Cliente
            cli = cliDAO.read(id)
        End If
        Return cli

    End Function

    Private Sub carregarGrid()
        Dim cliDAO As New ClienteDAO
        If txtPesquisa.Text.Trim = "" Then
            dgvLista.DataSource = cliDAO.listar("", "").Tables("myTable")
        Else
            dgvLista.DataSource = cliDAO.listar(campo, txtPesquisa.Text.Trim).Tables("myTable")
        End If

    End Sub

    Private Sub dgvLista_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        campo = dgvLista.Columns(e.ColumnIndex).HeaderText
    End Sub
    Private Sub txtPesquisa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 40 Then
            dgvLista.Focus()
        End If
    End Sub

    Private Sub cmdAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAplicar.Click
        Me.Hide()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Util.acesso(Me, 2)
        txtPesquisa.Focus()
    End Sub

    Private Sub txtPesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        carregarGrid()
    End Sub
    Private Sub dgvLista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub dgvLista_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista.CellContentDoubleClick

    End Sub

    Private Sub dgvLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista.CellDoubleClick
        Dim cli As New Cliente
        Dim cliDAO As New ClienteDAO

        LimparCampos()

        id = dgvLista.CurrentRow.Cells(0).Value
        cli = cliDAO.read(id)

        txtCodigo.Text = cli.id
        txtNome.Text = cli.xNome
        txtEndereco.Text = cli.xLgr
        txtCep.Text = cli.cep
        txtNumero.Text = cli.nro
        txtCompl.Text = cli.xCpl
        txtBairro.Text = cli.xBairro
        txtCidade.Text = cli.xMun
        txtEstado.Text = cli.uf
        txtCodmun.Text = cli.cMun
        txtCnpj.Text = cli.cnpj
        txtTelefone.Text = cli.fone
        txtEmail.Text = cli.email
        txtData_cadastro.Text = cli.dtCadastro
        chkBloqueado.Checked = cli.bloqueado
        txtObs.Text = cli.obs
        StatusGravacao = ""
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub dgvLista_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista.CellEnter

    End Sub

    Private Sub txtCnpj_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCnpj.LostFocus
        If txtCnpj.Text.Trim <> "" Then
            Util.validaCpfCnpj(txtCnpj.Text.Trim)
        End If
    End Sub

    Private Sub txtCnpj_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCnpj.MaskInputRejected

    End Sub
End Class
