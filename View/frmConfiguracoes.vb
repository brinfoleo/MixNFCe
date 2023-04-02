Imports System.Management
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Security
Public Class frmConfiguracoes
    'FORM DE CONFIGURACOES DO SISTEMA - EDUARDO SILVA 20/10/2014
    Private Sub cmdVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVoltar.Click
        Me.Close()
    End Sub

    Function BuscaCep(ByVal cep As String) As Hashtable 'FUNÇÃO PARA PEGAR CEP NO BANCO DE DADOS DOS CORREIOS VIA WEB - EDUARDO SILVA 20/10/2014
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
                        Case "2"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("tipo", 2)
                        Case Else
                            ht.Add("tipo", 0)
                            ToolTip1.Show("CEP não encontrado, Verifique.", txtCEP, 2000)
                            Exit Select
                    End Select

                    'Preenche os campos 
                    txtEndereco.Text = ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim() & " " & _
                    ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim()

                    txtBairro.Text = ds.Tables(0).Rows(0).Item("bairro").ToString().Trim()
                    txtCidade.Text = ds.Tables(0).Rows(0).Item("cidade").ToString().Trim()
                    cbUF.Text = ds.Tables(0).Rows(0).Item("uf").ToString().Trim()
                    txtNumero.Focus()
                End If
            End If
            Return ht
        Catch ex As Exception
            MessageBoxPadrao("Banco de dados não encontrado, Verifique seu acesso a Internet")
            Util.log(ex.Message, System.Environment.StackTrace, "")
            Return Nothing
        End Try
    End Function

    Private Sub cmdConsultaCEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaCEP.Click
        BuscaCep(txtCEP.Text) 'FAZ A PESQUISA DO ENDERECO ATRAVÉS DO CEP NO BANCO DE DAOS DOS CORREIOS - EDUARDO SILVA 20/10/2014
    End Sub

    Private Sub GravaParametrosINI() 'GRAVAR TODOS OS PARAMETROS NO ARQUIVO INI - EDUARDO SILVA 20/10/2014
        'Dim localPath As String

        localPath = Application.StartupPath

        ' DADOS001
        WritePrivateProfileString("DADOS001", "CNPJ", txtCNPJ.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "RAZAO", txtRAZAO.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "LOJA", cbLOJA.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "PDV", cbPDV.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "FANTASIA", txtFantasia.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "CRT", cbCRT.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "IE", txtIE.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "IM", txtIM.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "TEL1", txtTEL1.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "TEL2", txtTEL2.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "LOGO", txtCaminhoLogo.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "DIGBALANCA", cbDigitosBalanca.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS001", "LAYOUT", cboLayout.Text, localPath & "\Config.ini")



        ' DADOS002
        WritePrivateProfileString("DADOS002", "CEP", txtCEP.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "END", txtEndereco.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "NUMERO", txtNumero.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "COMPLEMENTO", txtComplemento.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "BAIRRO", txtBairro.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "CIDADE", txtCidade.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "UF", cbUF.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "EMAIL", txtemailCadastro.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS002", "CONTATO", txtContatoEmpresa.Text, localPath & "\Config.ini")
        ' DADOS003
        WritePrivateProfileString("DADOS003", "MENSAGEM", txtMensagemCupom.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS003", "AMBIENTE", txtAmbiente.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS003", "IBGECIDADE", txtIBGECidade.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS003", "IBGEESTADO", txtIBGEEstado.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOS003", "CNAE", txtCNAE.Text, localPath & "\Config.ini")
        'CONFIGURAÇÕES BANCO MYSQL
        WritePrivateProfileString("DADOSMYSQL", "SERVIDOR", txtEndMYSQL.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOSMYSQL", "BANCO", txtBancoMYSQL.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOSMYSQL", "USUARIO", txtUsuarioMysql.Text, localPath & "\Config.ini")
        WritePrivateProfileString("DADOSMYSQL", "SENHA", txtSenhaMYSQL.Text, localPath & "\Config.ini")

        '-----------------------
        'Configuracoes NFCe
        If cboModalidade.Text.ToLower = "nfce" Then
            modalidadeNT = 0
        ElseIf cboModalidade.Text.ToLower = "pedido/nfce" Then
            modalidadeNT = 1
        ElseIf cboModalidade.Text.ToLower = "pedido" Then
            modalidadeNT = 2
        Else
            modalidadeNT = 0
        End If

        WritePrivateProfileString("NOTA", "MODALIDADE", modalidadeNT, localPath & "\Config.ini")



    End Sub

    Private Sub cmdGravar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGravar.Click
        GravaParametrosINI()
        InicializacaoSistemas()
        MessageBoxPadrao("Dados Gravados com Sucesso!")
        LimparCamposConfig()
        Me.Close()
    End Sub
    Private Sub LimparCamposConfig()
        'DADOS001------------------------ PREENCHER A TELA DE CONFIGURACOES - EDUARDO SILVA 20/10/2014
        txtCNPJ.Text = ""
        txtRAZAO.Text = ""
        cbLOJA.Text = ""
        cbPDV.Text = ""
        txtFantasia.Text = ""
        cbCRT.Text = ""
        txtIE.Text = ""
        txtIM.Text = ""
        txtTEL1.Text = ""
        txtTEL2.Text = ""
        'DADOS002-------------------------
        txtCEP.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cbUF.Text = ""
        txtemailCadastro.Text = ""
        txtContatoEmail.Text = ""
        'DADOS003-------------------------
        txtMensagemCupom.Text = ""
        txtAmbiente.Text = ""
        txtIBGECidade.Text = ""
        txtIBGEEstado.Text = ""
        txtCNAE.Text = ""
        '---------------------------------
    End Sub
    Private Sub frmConfiguracoes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Util.acesso(Me, 2)

        'DADOS001------------------------ PREENCHER A TELA DE CONFIGURACOES - EDUARDO SILVA 20/10/2014
        txtCNPJ.Text = strCNPJ
        txtRAZAO.Text = strRazao
        cbLOJA.Text = strLoja
        cbPDV.Text = strPDV
        txtFantasia.Text = strFantasia
        cbCRT.Text = strCRT
        txtIE.Text = strIE
        txtIM.Text = strIM
        txtTEL1.Text = strTel1
        txtTEL2.Text = strTel2
        txtCaminhoLogo.Text = strLogo
        If File.Exists(strLogo) Then
            Me.PC_Logo.Image = Image.FromFile(strLogo)
            Me.PC_Logo.Refresh()
        End If
        cbDigitosBalanca.Text = strDigBalanca
        cboLayout.Text = strLayoutCupom
        'DADOS002-------------------------
        txtCEP.Text = strCEP
        txtEndereco.Text = strEnd
        txtNumero.Text = strNunero
        txtComplemento.Text = strComplemento
        txtBairro.Text = strBairro
        txtCidade.Text = strCidade
        cbUF.Text = strUF
        txtemailCadastro.Text = strEmail
        txtContatoEmail.Text = strContato
        'DADOS003-------------------------
        txtMensagemCupom.Text = strMensagem
        txtAmbiente.Text = strAmbiente
        txtIBGECidade.Text = strIBGECidade
        txtIBGEEstado.Text = strIBGEEstado
        txtCNAE.Text = strCNAE
        'CONFIGURACAO BANCO DE DADOS MYSQL
        txtEndMYSQL.Text = strEndMysql
        txtUsuarioMysql.Text = strUsuarioMysql
        txtSenhaMYSQL.Text = strSenhaMysql
        txtBancoMYSQL.Text = strBancoMysql
        '---------------------------------
        If modalidadeNT = 0 Then
            cboModalidade.Text = "NFCe"
        ElseIf modalidadeNT = 1 Then
            cboModalidade.Text = "Pedido/NFCe"
        ElseIf modalidadeNT = 2 Then
            cboModalidade.Text = "Pedido"
        Else
            cboModalidade.Text = "NFCe"
        End If

    End Sub

    Private Sub cmdFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFolder.Click
        'define as propriedades do controle
        ofd1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
        Dim dr As DialogResult = Me.ofd1.ShowDialog()
        If dr = System.Windows.Forms.DialogResult.OK Then
            ' Le os arquivos selecionados
            For Each arquivo As [String] In ofd1.FileNames
                txtCaminhoLogo.Text = ""
                txtCaminhoLogo.Text += arquivo
                Me.PC_Logo.Image = Image.FromFile(Me.txtCaminhoLogo.Text)
                Me.PC_Logo.Refresh()
                Try
                    ' Aqui fica o que deve ser executado com os arquivos selecionados
                Catch ex As SecurityException
                    ' O usuário  não possui permissão para ler arquivos
                    MessageBox.Show((("Erro de segurança Contate o administrador de segurança da rede." & vbLf & vbLf & "Mensagem : ") + ex.Message & vbLf & vbLf & "Detalhes (enviar ao suporte):" & vbLf & vbLf) + ex.StackTrace)
                    Util.log(ex.Message, System.Environment.StackTrace, "")
                Catch ex As Exception
                    ' Não pode carregar o arquivo (problemas de permissão)
                    MessageBox.Show(("Não é possível exibir a imagem : " & arquivo.Substring(arquivo.LastIndexOf("\"c))))
                    Util.log(ex.Message, System.Environment.StackTrace, "")
                End Try
            Next
        End If
    End Sub
    Private Sub cmbConfigBalanca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConfigBalanca.Click
        ConfiguraBalanca(0, Me.Handle)
    End Sub

    Private Sub cmdAtivacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtivacao.Click
        frmAtivacao.ShowDialog()
    End Sub
End Class