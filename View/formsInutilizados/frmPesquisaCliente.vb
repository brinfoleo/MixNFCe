Imports System.Data.SQLite

Public Class frmPesquisaCliente

    Private Sub frmPesquisaCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cliDAO As New ClienteDAO

        DgvCliente.DataSource = ""
        DgvCliente.Refresh()
        txtNome.Focus()
        txtNome.Text = ""
        txtTelefone.Text = ""
    End Sub

    Private Sub cmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVoltar.Click
        Me.Close()
    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        Dim cx As New Conexao()
        Dim daEmpresa As New SQLiteDataAdapter
        Dim sql As String = ""
        'sql = "SELECT codigo, nome, endereco, cep, numero, complemento, bairro, cidade, estado, cod_mun, cnpj, cpf, rg, telefone, celular, email, date_format(data_cadastro,'%d/%m/%Y') as data_cadastro, lim_debito, debito, bloqueado, obs  "
        sql = "SELECT * "
        sql += "FROM clientes WHERE xNome LIKE '%" & Trim(txtNome.Text) & "%'"
        cx.Conectar()
        daEmpresa = New SQLiteDataAdapter(sql, cx.c)
        Dim ds As DataSet
        ds = New DataSet
        daEmpresa.Fill(ds, "clientes")
        DgvCliente.DataSource = ds.Tables("clientes")
        cx.Desconectar()
    End Sub

    Private Sub txtTelefone_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefone.TextChanged
        Dim cx As New Conexao()
        Dim daEmpresa As New SQLiteDataAdapter
        Dim myData As New DataTable
        Dim sql As String = ""
        sql = "SELECT codigo, nome, endereco, cep, numero, complemento, bairro, cidade, estado, cod_mun, cnpj, cpf, rg, telefone, celular, email, date_format(data_cadastro,'%d/%m/%Y') as data_cadastro, lim_debito, debito, bloqueado, obs  "
        sql += "FROM clientes WHERE telefone LIKE '%" & Trim(txtTelefone.Text) & "%'"
        cx.Conectar()
        daEmpresa = New SQLiteDataAdapter(sql, cx.c)
        Dim ds As DataSet
        ds = New DataSet
        daEmpresa.Fill(ds, "clientes")
        DgvCliente.DataSource = ds.Tables("clientes")

        If DgvCliente.RowCount = 0 Then 'SEGUNDA OPCAO DE BUSCA, SEGUNDO CELULAR.
            LocalizaCelular()
        End If
        cx.Desconectar()
    End Sub
    Private Sub LocalizaCelular() 'LOCALIZA CELULAR
        Dim cx As New Conexao()
        Dim daEmpresa As New SQLiteDataAdapter
        Dim myData As New DataTable
        Dim sql As String = ""
        sql = "SELECT codigo, nome, endereco, cep, numero, complemento, bairro, cidade, estado, cod_mun, cnpj, cpf, rg, telefone, celular, email, date_format(data_cadastro,'%d/%m/%Y') as data_cadastro, lim_debito, debito, bloqueado, obs  "
        sql += "FROM clientes WHERE celular LIKE '%" & Trim(txtTelefone.Text) & "%'"
        cx.Conectar()
        daEmpresa = New SQLiteDataAdapter(sql, cx.c)
        Dim ds As DataSet
        ds = New DataSet
        daEmpresa.Fill(ds, "clientes")
        DgvCliente.DataSource = ds.Tables("clientes")
        cx.Desconectar()
    End Sub

    Private Sub DgvCliente_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCliente.CellEnter


        'Dim x As Double
        Dim auxcpfcnpj As String
        'frmClientes.txtCodigo.Text = DgvCliente.Rows(e.RowIndex).Cells("codigo").Value
        'frmClientes.txtNome.Text = DgvCliente.Rows(e.RowIndex).Cells("nome").Value
        'frmClientes.txtEndereco.Text = DgvCliente.Rows(e.RowIndex).Cells("endereco").Value
        'frmClientes.txtCep.Text = DgvCliente.Rows(e.RowIndex).Cells("cep").Value
        'frmClientes.txtNumero.Text = DgvCliente.Rows(e.RowIndex).Cells("numero").Value
        'frmClientes.txtCompl.Text = DgvCliente.Rows(e.RowIndex).Cells("complemento").Value
        'frmClientes.txtBairro.Text = DgvCliente.Rows(e.RowIndex).Cells("bairro").Value
        'frmClientes.txtCidade.Text = DgvCliente.Rows(e.RowIndex).Cells("cidade").Value
        'frmClientes.txtEstado.Text = DgvCliente.Rows(e.RowIndex).Cells("estado").Value
        'frmClientes.txtCodmun.Text = DgvCliente.Rows(e.RowIndex).Cells("cod_mun").Value
        'frmClientes.txtCnpj.Text = DgvCliente.Rows(e.RowIndex).Cells("cnpj").Value
        'frmClientes.txtCpf.Text = DgvCliente.Rows(e.RowIndex).Cells("cpf").Value
        'frmClientes.txtRg.Text = DgvCliente.Rows(e.RowIndex).Cells("rg").Value
        'frmClientes.txtTelefone.Text = DgvCliente.Rows(e.RowIndex).Cells("telefone").Value
        'frmClientes.txtCelular.Text = DgvCliente.Rows(e.RowIndex).Cells("celular").Value
        'frmClientes.txtEmail.Text = DgvCliente.Rows(e.RowIndex).Cells("email").Value
        'frmClientes.txtData_cadastro.Text = DgvCliente.Rows(e.RowIndex).Cells("data_cadastro").Value
        'frmClientes.txtObs.Text = DgvCliente.Rows(e.RowIndex).Cells("obs").Value
        'x = CDbl(DgvCliente.Rows(e.RowIndex).Cells("lim_debito").Value)
        'frmClientes.txtLim_debito.Text = Format(x, "#,##0.00")
        'x = CDbl(DgvCliente.Rows(e.RowIndex).Cells("debito").Value)
        'frmClientes.txtDebito.Text = Format(x, "#,##0.00")
        'If DgvCliente.Rows(e.RowIndex).Cells("bloqueado").Value = 0 Then
        'frmClientes.chkBloqueado.Checked = False
        'Else
        'frmClientes.chkBloqueado.Checked = True
        'End If
        auxcpfcnpj = DgvCliente.Rows(e.RowIndex).Cells("cnpj").Value
        auxcpfcnpj = auxcpfcnpj.Replace(" ", "")
        auxcpfcnpj = auxcpfcnpj.Replace(".", "")
        auxcpfcnpj = auxcpfcnpj.Replace("-", "")
        auxcpfcnpj = auxcpfcnpj.Replace("/", "")
        If auxcpfcnpj = "" Then
            frmClientes.txtCnpj.Text = ""
            'frmClientes.rdbfis.Checked = True
        Else
            'frmClientes.txtCpf.Text = ""
            'frmClientes.rdbjud.Checked = True
        End If

        'STATUS GRAVACAO
        StatusGravacao = "A"


    End Sub

    Private Sub DgvCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCliente.KeyDown
        'Para não deixar passar para a próxima linha do DataGrid quando pressionar ENTER
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Close()
        End If
    End Sub

End Class