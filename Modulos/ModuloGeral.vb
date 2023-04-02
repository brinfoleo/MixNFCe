Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.SQLite

Module ModuloGeral

    Public usuarioOnLine As New Usuario
    Public localPath As String


    Public Function DataAccessParaMysql(ByVal varData As Date) ' 01/01/2000 11:00:00


        Dim varNovaData As String
        ' varNovaData = varData
        If IsDate(varData) Then
            varNovaData = "" & Mid(varData, 7, 4) & "/" & Mid(varData, 4, 2) & "/" & Mid(varData, 1, 2) & Mid(varData, 11)
            Return varNovaData
        Else
            Return varData
        End If
    End Function
    Public Sub Esperar(ByVal Milesegundos As Double)
        Dim TempoInicial As DateTime
        Dim TempoFinal As DateTime
        Dim DiferencaTempo As TimeSpan
        Dim Diferenca As Double

        TempoInicial = Now
        Do
            TempoFinal = Now
            DiferencaTempo = TempoFinal.Subtract(TempoInicial)
            Diferenca = DiferencaTempo.TotalMilliseconds

        Loop While Diferenca < Milesegundos

    End Sub
    Public Sub MessageBoxPadrao(ByVal Mensagem As String) ' MENSAGEM PADRAO EDUARDO SILVA 21/10/2014
        MessageBox.Show(Mensagem, "MixPDV - Sistemas Integrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'DECLARACAO DE VARIAVEIS ------------------------------------------------------------------------------------------------
    Public strCNPJ, strRazao, strLoja, strPDV, strFantasia, strCRT, strIE, strIM, strTel1, strTel2, strLogo, strDigBalanca, strLayoutCupom As String 'DADOS 001
    Public strCEP, strEnd, strNunero, strComplemento, strBairro, strCidade, strUF, strEmail, strContato As String 'DADOS 002
    Public strMensagem, strAmbiente, strIBGEEstado, strIBGECidade, strCNAE As String 'DADOS 003
    Public strEndMysql, strBancoMysql, strUsuarioMysql, strSenhaMysql, strCodBarrasGeral As String 'CONFIGURAÇÕES MYSQL
    Public StatusGravacao As String = "I" 'STRING PARA DIZER SE É UMA INCLUSAO OU UMA ALTERACAO DE REGISTRO, A=ALTERACAO , I = INCLUSAO
    Public strUsuarioLogado, strTipoAcesso As String
    Public nfeSerie As Integer

    'REFERENTE A ATIVAÇÃO---------------------------------
    Public sGravaSerial As String = "N"
    Public dias As Integer
    Public DataExpira, DataHoje As Date
    Public strStatusAtivacao, strCnpjAtivacao, sChave, sExpira, strUltimaAtivacao As String
    '------------------------------------------------------
    'Sistema de emissao da Nota fiscal
    Public modalidadeNT As Integer

    '------------------------------------------------------------------------------------------------------------------------

    'FUNCAO PARA PEGAR E GRAVAR O ARQUIVO INI - EDUARDO SILVA 20/10/2014
    Public Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    '--------------------------------------------------------------------

    Public Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return string_builder.ToString()
    End Function
    '---------------------------------------------------------------------
    Public Sub InicializacaoSistemas() 'TODOS OS PARAMETROS INICIALIZAVEIS COM O SISTEMA COLOCAR AQUI DENTRO - EDUARDO SILVA 20/10/2014
        'Dim localPath As String

        localPath = Application.StartupPath


        ' DADOS001-----------------------------------------------------------------------------------
        strCNPJ = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "CNPJ", "CNPJ")
        strRazao = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "RAZAO", "RAZAO")
        strLoja = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "LOJA", "000")
        strPDV = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "PDV", "000")
        strFantasia = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "FANTASIA", "FANTASIA")
        strCRT = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "CRT", "CRT")
        strIE = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "IE", "000000")
        strIM = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "IM", "000000")
        strTel1 = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "TEL1", "000000")
        strTel2 = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "TEL2", "000000")
        strLogo = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "LOGO", "")
        If File.Exists(strLogo) Then
            frmCaixa.PC_Loja.BackgroundImage = Image.FromFile(strLogo)
            frmCaixa.PC_Loja.BackgroundImageLayout = ImageLayout.Stretch
            frmCaixa.PC_Loja.Refresh()
        End If
        strDigBalanca = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "DIGBALANCA", "6")
        strLayoutCupom = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "LAYOUT", "Compacto")



        ' RFERENTE A ATIVACAO DO SISTEMA
        sExpira = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "Expira_Dia", "Data de Expiracao")
        sChave = LeArquivoINI(localPath & "\Config.ini", "DADOS001", "Chave", "")

        ' DADOS002------------------------------------------------------------------------------------
        strCEP = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "CEP", "000000")
        strEnd = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "END", "RAZAO")
        strNunero = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "NUMERO", "000000")
        strComplemento = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "COMPLEMENTO", "COMPLEMENTO")
        strBairro = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "BAIRRO", "BAIRRO")
        strCidade = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "CIDADE", "CIDADE")
        strUF = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "UF", "UF")
        strEmail = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "EMAIL", "EMAIL")
        strContato = LeArquivoINI(localPath & "\Config.ini", "DADOS002", "CONTATO", "CONTATO")
        ' DADOS003-------------------------------------------------------------------------------------
        strMensagem = LeArquivoINI(localPath & "\Config.ini", "DADOS003", "MENSAGEM", "MENSAGEM")
        strAmbiente = LeArquivoINI(localPath & "\Config.ini", "DADOS003", "AMBIENTE", "0000")
        strIBGECidade = LeArquivoINI(localPath & "\Config.ini", "DADOS003", "IBGECIDADE", "0000")
        strIBGEEstado = LeArquivoINI(localPath & "\Config.ini", "DADOS003", "IBGEESTADO", "0000")
        strCNAE = LeArquivoINI(localPath & "\Config.ini", "DADOS003", "CNAE", "0000")
        'CONFIGURACAO MYSQL----------------------------------------------------------------------------
        strEndMysql = LeArquivoINI(localPath & "\Config.ini", "DADOSMYSQL", "SERVIDOR", "0.0.0.0")
        strBancoMysql = LeArquivoINI(localPath & "\Config.ini", "DADOSMYSQL", "BANCO", "MixBanco")
        strUsuarioMysql = LeArquivoINI(localPath & "\Config.ini", "DADOSMYSQL", "USUARIO", "root")
        strSenhaMysql = LeArquivoINI(localPath & "\Config.ini", "DADOSMYSQL", "SENHA", "")

        '24/07/2015 - Leo
        'Caso o sistema esteja em homologacao a serie sera modificada para 100
        '1 - Producao
        '2 - Homologacao
        If strAmbiente = 1 Then
            nfeSerie = strPDV
        Else
            'MessageBoxPadrao("Sistema em ambiente de Homologação" & vbCrLf & "Série alterada para '100' por padrão.")
            nfeSerie = "100"
        End If

        '26/09/2015 - Leo
        'Sistema de emissao de NFCe
        ' Caso nao seja emitida NFCe sera emitido coomanda de pedido
        ' 0 - Emite NFCe direto
        ' 1 - Pergunta se deseja imprimir NFCe
        ' 2 - Nao emite documento fiscal
        modalidadeNT = LeArquivoINI(localPath & "\Config.ini", "NOTA", "MODALIDADE", "0")

    End Sub

    Public Function VerificaExpiraSistema()

        Dim result As String

        If dias < 10 And dias >= 1 Then
            strStatusAtivacao = "LIBERADO"

            result = MessageBox.Show("Atenção, sua licença expira em " & dias & " Dias, Deseja ativar agora?", "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ' mensagem padrao
            If result = MsgBoxResult.Yes Then
                frmAtivacao.ShowDialog()
            End If

            Exit Function

        ElseIf dias > 10 Then 'SISTEMA ESTA LIBERADO MAIS DE 10 DIAS
            strStatusAtivacao = "LIBERADO"
            Exit Function

        ElseIf dias = 1 Then
            strStatusAtivacao = "LIBERADO"
            result = MessageBox.Show("Atenção, sua licença expira em " & dias & " Dias." & vbCrLf & "Deseja ativar agora?", "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ' mensagem padrao
            If result = MsgBoxResult.Yes Then
                frmAtivacao.ShowDialog()
            End If

            Exit Function

        ElseIf dias = 0 Then
            strStatusAtivacao = "LIBERADO"
            result = MessageBox.Show("Atenção, sua licença expira em " & dias & " Dias." & vbCrLf & "Deseja ativar agora?", "Ei!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ' mensagem padrao
            If result = MsgBoxResult.Yes Then
                frmAtivacao.ShowDialog()
            End If

            Exit Function

        ElseIf dias < 0 Then
            Try
                WritePrivateProfileString("DADOS001", "Chave", "", localPath & "\Config.ini")

                strStatusAtivacao = "BLOQUEADO"
                MessageBox.Show("O Sistema expirou seu período de uso." & vbCrLf & "Informe o código!", "Ei!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmAtivacao.ShowDialog()
            Catch ex As Exception

            End Try
        End If

    End Function
    Public Function ValidaChaveAcesso(ByVal txtFabricacao As String, ByVal txtAtivacao As String, ByVal txtFabricacaoC As String, ByVal txtGTC As String, ByVal caminho As String) As Boolean
        Dim fluxoTexto As IO.StreamWriter
        Dim chave As ULong

        If sGravaSerial = "S" Then
            txtAtivacao = frmAtivacao.txtserial.Text
            chave = frmAtivacao.txtserial.Text
        Else
            txtAtivacao = sChave
            If sChave = "" Or IsNumeric(sChave) = False Then
                txtAtivacao = "99998888777889"
            End If
        End If

        Dim contLinha As Integer = 0

        Dim A1 As String = txtFabricacao
        Dim At As ULong = Convert.ToUInt64(txtAtivacao)
        Dim B1 As ULong

        B1 = At / (Convert.ToUInt64(A1) * 3972849)
        chave = Convert.ToUInt64(A1) * Convert.ToUInt64(B1) * 3972849

        If chave = Convert.ToUInt64(txtAtivacao) Then

            Dim sDataValidade As String = CStr(B1)

            sDataValidade = Mid(sDataValidade, 7, 2) & "/" & Mid(sDataValidade, 5, 2) & "/" & Mid(sDataValidade, 1, 4)

            'Dim Validade As String = DadosCripto.clsCrypto(sDataValidade, True)
            DataExpira = sDataValidade
            dias = DateDiff(DateInterval.Day, DataHoje, DataExpira)

            WritePrivateProfileString("DADOS001", "Expira_Dia", DataExpira, localPath & "\Config.ini")
            WritePrivateProfileString("DADOS001", "Chave", txtAtivacao, localPath & "\Config.ini")

            If sGravaSerial = "N" Then
                VerificaExpiraSistema()
            End If

            If dias < 0 Then
                strStatusAtivacao = "BLOQUEADO"
            Else
                strStatusAtivacao = "LIBERADO"
            End If
            sChave = txtAtivacao
            frmCaixa.CarregaBarraStatus()

            Return True

        Else
            strStatusAtivacao = "BLOQUEADO"
        End If

    End Function

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If

        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        'If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function

    Public Sub limparform(ByVal controlP As Control)

        Dim ctl As Control

        For Each ctl In controlP.Controls

            If TypeOf ctl Is TextBox Then

                DirectCast(ctl, TextBox).Text = String.Empty

            ElseIf ctl.Controls.Count > 0 Then

                limparform(ctl)

            End If

        Next

    End Sub
    Public Class Conexao


        Public c As New SQLiteConnection()
        Public Status As String

        Public Sub Conectar()
            'Dim cn As New ConnectionFactory
            'c = cn.getConnection

            Dim myCommand As New SQLiteCommand
            Dim myAdapter As New SQLiteDataAdapter
            Dim myData As New DataTable
            Dim ds As New DataSet

            '****************************************************
            Dim localdb As String = Application.StartupPath.ToString & "\db\mixdb2.db"
            Dim sConnectionString As String = "Data Source=" & localdb & ";Version=3;New=True;Compress=True;"
            'Dim sConnectionString As String = "Data Source=" & localdb & ";Version=3;"

            'c.ConnectionString = sConnectionString
            'c.Open()
            '****************************************************

            c.ConnectionString = sConnectionString '"server=" & strEndMysql & "; database=" & strBancoMysql & "; Uid=" & strUsuarioMysql & "; Pwd=" & strSenhaMysql & "; Min Pool Size=0;Max Pool Size = 100; Connection Lifetime =600;Pooling = true; Connection reset = true"

            Try
                c.Open()
                Status = "Status : Conexao aberta"

            Catch ex As SQLiteException  'MySqlException
                MsgBox("Erro de leitura no banco de dados." & vbCrLf & _
                       "Verifique sua Conexão com a Internet!", _
                       MsgBoxStyle.Critical, ">>>>" & ex.Message & "<<<<")
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try




        End Sub

        Public Sub Desconectar()
            Try
                'c.Dispose()
                c.Close()
                c = Nothing
            Catch ex As SQLiteException 'MySqlException
                c.Dispose()
                c.Close()

                c = Nothing
                MsgBox("Erro de leitura no banco de dados : " & ex.Message)
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try
            Status = "Status : Conexao Fechada"
        End Sub


    End Class

End Module
