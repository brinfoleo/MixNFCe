Imports MySql.Data.MySqlClient
Public Class frmClientes
    'FORM PARA CADASTRO DE CLIENTES - EDUARDO SILVA 21/10/2014
    Public Sub IncluirCliente()

        Dim sql As String = ""
        Dim cx As New Conexao()
        Dim cd As New MySqlCommand()

        Dim bloqueado As Integer
        Dim auxcpfcnpj As String
        txtData_cadastro.Text = Date.Now
        bloqueado = chkBloqueado.Checked

        If rdbfis.Checked = True Then
            auxcpfcnpj = txtCpf.Text
        Else
            auxcpfcnpj = txtCnpj.Text
        End If



        Try
            sql += " insert into clientes (nome, endereco, cep, cpf, rg, telefone, celular, email, data_cadastro, lim_debito, debito, bloqueado, numero,complemento,bairro,cidade,estado,cod_mun,cnpj, obs)"
            sql += " values ('" & txtNome.Text & "','" + txtEndereco.Text + "','" + txtCep.Text + "','" + txtCpf.Text + "','" + txtRg.Text + "','" + txtTelefone.Text + "','" + txtCelular.Text + "','" + txtEmail.Text + "','" + DataAccessParaMysql(txtData_cadastro.Text) + "'," + Replace(txtLim_debito.Text, ".", ",") + "," + Replace(txtDebito.Text, ",", ".") + "," + CStr(bloqueado) + ",'" + txtNumero.Text + "','" + txtCompl.Text
            sql += "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "','" + txtCodmun.Text + "','" + Replace(Replace(Replace(txtCnpj.Text, ".", ""), "/", ""), "-", "") + "','" + txtObs.Text + "')"
            cx.Conectar()
            cd.Connection = cx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cx.Desconectar()

        Catch ex As Exception
            cx.Desconectar()
        End Try


    End Sub

    Public Sub AlterarCliente()

        Dim sql As String = ""
        Dim cx As New Conexao()
        Dim cd As New MySqlCommand()

        Dim bloqueado As Integer
        Dim auxcpfcnpj As String
        txtData_cadastro.Text = Date.Now
        bloqueado = chkBloqueado.Checked

        If rdbfis.Checked = True Then
            auxcpfcnpj = txtCpf.Text
        Else
            auxcpfcnpj = txtCnpj.Text
        End If

        Try
            sql = ""
            sql += " Update clientes "
            sql += " set nome = '" + txtNome.Text + "', "
            sql += " endereco = '" + txtEndereco.Text + "', "
            sql += " cep = '" + txtCep.Text + "', "
            sql += " numero = '" + txtNumero.Text + "', "
            sql += " complemento = '" + txtCompl.Text + "', "
            sql += " bairro = '" + txtBairro.Text + "', "
            sql += " cidade = '" + txtCidade.Text + "', "
            sql += " estado = '" + txtEstado.Text + "', "
            sql += " cod_mun  = '" + txtCodmun.Text + "', "
            sql += " cnpj = '" + Replace(Replace(Replace(txtCnpj.Text, ".", ""), "/", ""), "-", "") + "', "
            sql += " cpf = '" + txtCpf.Text + "', "
            sql += " rg = '" + txtRg.Text + "', "
            sql += " telefone = '" + txtTelefone.Text + "', "
            sql += " celular = '" + txtCelular.Text + "', "
            sql += " email = '" + txtEmail.Text + "', "
            sql += " lim_debito = " + Replace(Replace(txtLim_debito.Text, ".", ""), ",", ".") + ", "
            sql += " debito = " + Replace(Replace(txtDebito.Text, ".", ""), ",", ".") + ", "
            sql += " bloqueado = " + CStr(bloqueado) + ","
            sql += " obs = '" + txtObs.Text + "' "
            sql += " where codigo = " + CStr(txtCodigo.Text)

            cx.Conectar()
            cd.Connection = cx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cx.Desconectar()

        Catch ex As Exception
            cx.Desconectar()
        End Try
    End Sub
    
    Private Sub LimparCampos()
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
        txtCpf.Text = ""
        txtRg.Text = ""
        txtTelefone.Text = ""
        txtCelular.Text = ""
        txtEmail.Text = ""
        txtLim_debito.Text = "0,00"
        txtDebito.Text = "0,00"
        txtValor.Text = "0,00"
        txtData_cadastro.Text = ""
        chkBloqueado.Checked = False
        txtDescricao.Text = ""
        txtResponsavel.Text = ""
        txtDt_inicial.Text = ""
        txtDt_final.Text = ""
        txtDt_venc.Text = ""
        txtDt_pag.Text = ""
        txtObs.Text = ""
        Rdbtodos.Checked = True
        DgvDebito.DataSource = ""
        DgvDebito.Refresh()
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
            Return Nothing
        End Try
    End Function
    Private Sub cmdGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGravar.Click
        If StatusGravacao = "A" Then
            If txtCodigo.Text.Length <> 0 Then
                Dim result = MessageBox.Show("Confirma Atualização", "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = MsgBoxResult.Yes Then
                    AlterarCliente()
                End If
            End If
        Else
            If StatusGravacao = "I" Then
                IncluirCliente()
            End If
        End If

        LimparCampos()
    End Sub
    Private Sub cmdLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpar.Click
        LimparCampos()
    End Sub

    Private Sub cmdPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        frmPesquisaCliente.ShowDialog()
    End Sub

    Private Sub cmdBuscaCep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscaCep.Click
        BuscaCep(txtCep.Text)
    End Sub
End Class
