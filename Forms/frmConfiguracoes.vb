Imports System.Management
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
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

            Return Nothing
        End Try
    End Function

    Private Sub cmdConsultaCEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaCEP.Click
        BuscaCep(txtCEP.Text) 'FAZ A PESQUISA DO ENDERECO ATRAVÉS DO CEP NO BANCO DE DAOS DOS CORREIOS - EDUARDO SILVA 20/10/2014
    End Sub

    Private Sub GravaParametrosINI() 'GRAVAR TODOS OS PARAMETROS NO ARQUIVO INI - EDUARDO SILVA 20/10/2014

        ' DADOS001
        WritePrivateProfileString("DADOS001", "CNPJ", txtCNPJ.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "RAZAO", txtRAZAO.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "LOJA", cbLOJA.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "PDV", cbPDV.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "FANTASIA", txtFantasia.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "CRT", cbCRT.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "IE", txtIE.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "IM", txtIM.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "TEL1", txtTEL1.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS001", "TEL2", txtTEL2.Text, "C:\MixNFCe\Config.ini")
        ' DADOS002
        WritePrivateProfileString("DADOS002", "CEP", txtCEP.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "END", txtEndereco.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "NUMERO", txtNumero.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "COMPLEMENTO", txtComplemento.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "BAIRRO", txtBairro.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "CIDADE", txtCidade.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "UF", cbUF.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "EMAIL", txtemailCadastro.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS002", "CONTATO", txtContatoEmpresa.Text, "C:\MixNFCe\Config.ini")
        ' DADOS003
        WritePrivateProfileString("DADOS003", "MENSAGEM", txtMensagemCupom.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS003", "IBGECIDADE", txtIBGECidade.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS003", "IBGEESTADO", txtIBGEEstado.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOS003", "CNAE", txtCNAE.Text, "C:\MixNFCe\Config.ini")
        'CONFIGURAÇÕES BANCO MYSQL
        WritePrivateProfileString("DADOSMYSQL", "SERVIDOR", txtEndMYSQL.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOSMYSQL", "BANCO", txtBancoMYSQL.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOSMYSQL", "USUARIO", txtUsuarioMysql.Text, "C:\MixNFCe\Config.ini")
        WritePrivateProfileString("DADOSMYSQL", "SENHA", txtSenhaMYSQL.Text, "C:\MixNFCe\Config.ini")
        '-----------------------


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
        txtIBGECidade.Text = ""
        txtIBGEEstado.Text = ""
        txtCNAE.Text = ""
        '---------------------------------
    End Sub
    Private Sub frmConfiguracoes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        txtIBGECidade.Text = strIBGECidade
        txtIBGEEstado.Text = strIBGEEstado
        txtCNAE.Text = strCNAE
        'CONFIGURACAO BANCO DE DADOS MYSQL
        txtEndMYSQL.Text = strEndMysql
        txtUsuarioMysql.Text = strUsuarioMysql
        txtSenhaMYSQL.Text = strSenhaMysql
        txtBancoMYSQL.Text = strBancoMysql
        '---------------------------------
    End Sub
End Class