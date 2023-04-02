Imports System.IO
Imports System.IO.Compression
Imports System.Reflection
Imports System.Xml

Module Util
    
    Public Function cMoeda(ByVal value As Double) As String
        'Retorna uma string com o valor formatado no formato moeda
        Return Format(value, "#,##0.00")
    End Function


    ''' <summary>
    ''' Testa se o programa chamado foi aberto
    ''' </summary>
    ''' <param name="nomeDoPrograma"></param>
    ''' <remarks></remarks>
    Public Function programaAberto(ByVal nomeDoPrograma As String) As Boolean
        Dim activo As Boolean
        Dim myprocesses As Process()
        myprocesses = Process.GetProcessesByName(nomeDoPrograma) 'obter processos com o nome X
        If myprocesses.Length > 0 Then 'se for maior que 0 então existem processos com o nome X
            activo = True 'está a correr
        Else
            activo = False 'não está a correr
        End If
        Return activo
    End Function
    Public Sub TextBoxMoeda(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0

        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = 0 Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            txt.Text = txt.Text.Remove(txt.Text.Length - 1)
        End Try
    End Sub
    Function SoNumeros(ByVal value As String, ByVal caracter As Char, ByVal dec As Integer) As Char
        '03/07/2015- Leonardo Aquino
        'Funcao usada no evento keypress pra aceitar numeros com x casas decimais
        Dim retorno As Char
        Dim KeyAscii As Short = CShort(Asc(caracter))

        'Testa se é um caracter valido
        If InStr("1234567890,", caracter) = 0 Then
            SoNumeros = ""
        Else
            retorno = caracter
        End If

        'Verifica se existe mais de uma virgula
        ' e se esta no tamanho certo as casas decimais
        If caracter = "," And InStr(value, ",") <> 0 Then
            retorno = ""
        ElseIf caracter = "," And dec = 0 Then
            retorno = ""
        ElseIf caracter <> "," And InStr(value, ",") <> 0 Then

            If Len(Mid(value, InStr(value & caracter, ","), value.Length)) > dec Then
                retorno = ""

            End If
        End If

        Select Case KeyAscii
            Case 8
                retorno = Chr(KeyAscii)
            Case 13
                'retorno = ""
            Case 32
                'retorno = ""
        End Select
        Return retorno
    End Function

    Public Function DataAccessParaMysql(ByVal varData As Date) ' 01/01/2000 11:00:00
        Dim varNovaData As String
        'varNovaData = varData
        If IsDate(varData) Then
            varNovaData = "" & Mid(varData, 7, 4) & "/" & Mid(varData, 4, 2) & "/" & Mid(varData, 1, 2) & Mid(varData, 11)
            Return varNovaData
        Else
            Return varData
        End If
    End Function

    Public Function DataMysqlParaAccess(ByVal varData As String)
        Dim varNovaData As String
        'varNovaData = varData
        If Not IsDate(varData) Then
            varNovaData = "" & Mid(varData, 9, 2) & "/" & Mid(varData, 6, 2) & "/" & Mid(varData, 1, 4)
            Return varNovaData
        Else
            varData = "Null"
            Return varData
        End If
    End Function
    Public Sub acesso(ByRef form As Form, ByVal peso As Integer)
        Dim usuTMP As New Usuario
        If usuarioOnLine.peso < peso Then
            usuTMP = frmAutorizaAcesso.formLoad
            If IsNothing(usuTMP) Then
                form.Close()
                Exit Sub
            Else
                If usuTMP.peso < peso Then
                    MsgBox("Infelizmente o usuário não tem acesso a esta seção.", MsgBoxStyle.Exclamation, "Acesso Negado!")
                    form.Close()
                End If
            End If
        End If

    End Sub
    ''' <summary>
    ''' Registro o Log INFORMATIVO do sistema
    ''' </summary>
    ''' <param name="msg">Menagem a ser gravada</param>
    ''' <remarks></remarks>
    Public Sub log(ByVal msg As String)
        Dim msgLog As String
        If Not System.IO.Directory.Exists(Application.StartupPath &
        "\log\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath &
            "\log\")
        End If

        Dim localLogFile As String
        localLogFile = Application.StartupPath &
                "\log\log_" & Format(Date.Today, "yyyyMM") & ".txt"

        'check the file
        Dim fs As FileStream = New FileStream(localLogFile, _
                                              FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(localLogFile, FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        msgLog = "" & DateTime.Now.ToString() & " - " & msg.ToString.Trim
        s1.Write(msgLog.ToString & vbCrLf)
        s1.Close()
        fs1.Close()


    End Sub
    ''' <summary>
    ''' Registra o Log de ERRO do sistema
    ''' </summary>
    ''' <param name="msg">Mensagem a ser gravada exemplo: ex.Message</param>
    ''' <param name="stkTrace">exemplo: System.Environment.StackTrace</param>
    ''' <param name="title">Titulo da Classe e Metodo exemplo: Class.metodo</param>
    ''' <remarks></remarks>
    Public Sub log(ByVal msg As String, _
           ByVal stkTrace As String, ByVal title As String)

        'check and make the directory if necessary; this is set to look in 
        'the application folder, you may wish to place the error log in 
        'another location depending upon the user's role and write access to 
        'different areas of the file system
        If Not System.IO.Directory.Exists(Application.StartupPath &
        "\log\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath &
            "\log\")
        End If

        Dim localLogFile As String
        localLogFile = Application.StartupPath &
                "\log\logE_" & Format(Date.Today, "yyyyMM") & ".txt"

        'check the file
        Dim fs As FileStream = New FileStream(localLogFile, _
                                              FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(localLogFile, FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write("Date/Time: " & DateTime.Now.ToString() & vbCrLf)
        s1.Write("Title: " & title & vbCrLf)
        s1.Write("Message: " & msg & vbCrLf)
        s1.Write("StackTrace: " & stkTrace & vbCrLf)
        s1.Write("================================================================================================" & vbCrLf)
        s1.Close()
        fs1.Close()

        'Injetando a informacao na web para a softhouse
        logWeb(msg)
    End Sub
    Public Function rs(ByVal sCampo As String) As String
        '********************************************************************************
        '*** Criado em   : 09/02/2005
        '*** Objetivo    : Remover Separadores
        '*** Revisado em : 14/07/2011
        '********************************************************************************
        sCampo = Replace(sCampo, ":", String.Empty)
        sCampo = Replace(sCampo, ";", String.Empty)
        sCampo = Replace(sCampo, ",", String.Empty)
        sCampo = Replace(sCampo, ".", String.Empty)
        sCampo = Replace(sCampo, "/", String.Empty)
        sCampo = Replace(sCampo, "-", String.Empty)
        sCampo = Replace(sCampo, " ", String.Empty)
        sCampo = Replace(sCampo, "\", String.Empty)
        rs = sCampo
    End Function
    Public Function rc(ByVal vCampo As String) As String
        '********************************************************************************
        '*** Criado em   : 09/02/2005
        '*** Objetivo    : Remover Caracteres ESPECIAIS
        '*** Revisado em : 14/07/2011
        '********************************************************************************
        Dim i As Integer
        Dim vTem As String
        Dim vRes As String

        vRes = ""

        vCampo = Replace(vCampo, "''", """")

        If Len(i) > 0 Then
            For i = 1 To Len(vCampo)
                vTem = UCase(Mid$(vCampo, i, 1))
                Select Case vTem
                    Case "Á", "À", "Ã", "Â", "Ä"
                        vTem = "A"
                    Case "É", "È", "Ê", "Ë"
                        vTem = "E"
                    Case "Í", "Ì", "Î", "Ï"
                        vTem = "I"
                    Case "Ó", "Ò", "Õ", "Ô", "Ö"
                        vTem = "O"
                    Case "Ú", "Ù", "Û", "Ü"
                        vTem = "U"
                    Case "Ç"
                        vTem = "C"
                        'Case "@"
                        '    vTem = "."
                    Case "º", "°"
                        vTem = ".o"
                    Case "ª"
                        vTem = ".a"
                    Case "'"
                        vTem = "''"
                    Case ";"
                        vTem = ","
                    Case "´"
                        vTem = ""
                End Select
                vRes = vRes + vTem
            Next
        End If
        rc = vRes
    End Function

    ''' <summary>
    ''' Valida CNPJ ou CPF
    ''' </summary>
    ''' <param name="nDoc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function validaCpfCnpj(ByVal nDoc As String) As Boolean
        Dim flag As Boolean

        nDoc = Replace(nDoc, ".", "")
        nDoc = Replace(nDoc, "/", "")
        nDoc = Replace(nDoc, "-", "")
        nDoc = Replace(nDoc, " ", "")
        nDoc = Replace(nDoc, ",", "")

        If nDoc.Trim.Length <= 11 Then
            flag = ValidaCPF(nDoc)

        Else
            flag = ValidaCGC(nDoc)

        End If
        If flag = False Then MessageBoxPadrao("Número de documento inválido!")
        Return flag
    End Function


    Private Function ValidaCPF(ByVal atrCPF As String) As Boolean

        Dim k(11) As Integer
        Dim j As Integer
        Dim r As Integer
        Dim pmrsm As Integer
        Dim str As String = atrCPF

        str = Replace(str, ".", "")
        str = Replace(str, "/", "")
        str = Replace(str, "-", "")
        str = Replace(str, " ", "")
        str = Replace(str, ",", "")

        If Len(str) = 11 Then
            If str = "00000000000" Or str = "11111111111" Or str = "22222222222" Or str = "33333333333" Or str = "44444444444" Or str = "55555555555" Or str = "66666666666" Or str = "77777777777" Or str = "88888888888" Or str = "99999999999" Then
                Return False
            End If
            j = 1
            Do While j <= 10
                k(j) = CInt(Mid(str, j, 1))
                j = j + 1
            Loop
            r = 1
            pmrsm = 0
            j = 9
            Do While j >= 1
                r = r + 1
                pmrsm = pmrsm + r * k(j)
                j = j - 1
            Loop
            k(10) = 11 - (pmrsm Mod 11)
            If k(10) > 9 Then
                k(10) = 0
            End If
            r = 1
            pmrsm = 0
            j = 10
            Do While j >= 2
                r = r + 1
                pmrsm = pmrsm + r * k(j)
                j = j - 1
            Loop
            k(11) = 11 - (pmrsm Mod 11)
            If k(11) > 9 Then
                k(11) = 0
            End If
            If CInt(Mid(str, 10, 1)) = k(10) And CInt(Mid(str, 11, 1)) = k(11) Then
                Return True
            End If
        Else
            Return False
        End If

    End Function

    Private Function ValidaCGC(ByVal atrCPF As String) As Boolean

        Dim sCGCAux As String
        Dim sCGC1 As String
        Dim sCGC2 As String
        Dim sControle As String
        Dim sMult As String
        Dim nSoma As Integer
        Dim nDigito As Integer
        Dim ni As Integer
        Dim nj As Integer

        'sCGCAux = atrCGC
        sCGCAux = atrCPF

        sCGCAux = Replace(sCGCAux, ".", "")
        sCGCAux = Replace(sCGCAux, "/", "")
        sCGCAux = Replace(sCGCAux, "-", "")
        sCGCAux = Replace(sCGCAux, " ", "")
        sCGCAux = Replace(sCGCAux, ",", "")

        If Len(Trim(sCGCAux)) <> 14 Then
            Return False
        End If
        sCGC1 = Mid(sCGCAux, 1, 12)
        sCGC2 = Mid(sCGCAux, 13, 2)
        sMult = "543298765432"
        sControle = ""
        nj = 1
        Do While nj <= 2
            nSoma = 0
            ni = 1
            Do While ni <= 12
                nSoma = nSoma + CInt(Mid(sCGC1, ni, 1)) * CInt(Mid(sMult, ni, 1))
                ni = ni + 1
            Loop
            If nj = 2 Then
                nSoma = nSoma + (2 * nDigito)
            End If
            nDigito = (nSoma * 10) Mod 11
            If nDigito = 10 Then
                nDigito = 0
            End If
            sControle = sControle & Trim(CStr(nDigito))
            sMult = "654329876543"
            nj = nj + 1
        Loop

        If sControle <> sCGC2 Then
            Return False
        Else
            Return True
        End If
    End Function
    ''' <summary>
    ''' Move arquivo
    ''' </summary>
    ''' <param name="origem"></param>
    ''' <param name="destino"></param>
    ''' <param name="arquivo"></param>
    ''' <remarks></remarks>
    Public Sub moveFile(ByVal origem As String, ByVal destino As String, ByVal arquivo As String)
        'Move o arquivo
        '08/07/2015
        If Not System.IO.Directory.Exists(destino) Then
            'MsgBox("Local [" & destino & "] inexistente favor verificar!", MsgBoxStyle.Critical, "Aviso")
            Util.log("Local [" & destino & "] inexistente favor verificar!")

            Exit Sub
        End If
        Try
            File.Copy(origem & "\" & arquivo, destino & "\" & arquivo)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Util.log(ex.Message, System.Environment.StackTrace, "moveFile")
            System.Console.WriteLine(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Deleta o arquivo movendo para a lixeira
    ''' </summary>
    ''' <param name="lFile">String com local(pasta) arquivo</param>
    ''' <param name="nFile">String com nome do arquivo</param>
    ''' <remarks></remarks>
    Public Sub deleteFile(ByVal lFile As String, ByVal nFile As String)
        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(lFile)

        Dim oFileInfoCollection() As FileInfo

        Dim oFileInfo As FileInfo

        Dim i As Integer
        Try
            '### Preenche o FileCollection com um Array de objetos FileInfo

            oFileInfoCollection = DirDiretorio.GetFiles(nFile)

            'System.Console.WriteLine((Mid(localFile.ToString, InStr(localFile, "33"), localFile.Length)) & " - len: " & oFileInfoCollection.Length)



            For i = 0 To oFileInfoCollection.Length - 1

                oFileInfo = oFileInfoCollection.GetValue(i)



                My.Computer.FileSystem.DeleteFile(oFileInfo.FullName, FileIO.UIOption.OnlyErrorDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)

                'My.Computer.FileSystem.DeleteFile(foundFile, _
                '   FileIO.UIOption.AllDialogs, _
                '   FileIO.RecycleOption.DeletePermanently)
            Next
        Catch ex As Exception
            Util.log(ex.Message, System.Environment.StackTrace, "Util.deleteFile")
        End Try
    End Sub

    ''' <summary>
    ''' Testa se o pc esta conectado a internet
    ''' True - Conectado
    ''' False - Sem comunicacao
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function internet() As Boolean
        Dim flag As Boolean

        '*******************************************************
        '1 - Forma de fazer
        'Try
        '    flag = My.Computer.Network.Ping.send("google.com.br")
        'Catch ex As System.Net.NetworkInformation.PingException
        '    flag = False
        'End Try
        'Return flag
        '*******************************************************
        '2 - Segunda forma de fazer
        Dim png As New Net.NetworkInformation.Ping
        Dim pngr As Net.NetworkInformation.PingReply
        Dim result As String
        Try
            pngr = png.Send("www4.fazenda.rj.gov.br")
            result = pngr.RoundtripTime
            flag = True
        Catch ex As Exception
            result = "Failed"
            flag = False
        End Try

        Util.log("Teste de ping: www4.fazenda.rj.gov.br (" & result & ")")
        Return flag
    End Function
    Public Sub logWeb(ByVal msg As String)
        Dim c As New MySql.Data.MySqlClient.MySqlConnection

        Dim sServer As String = "mysql43.pdvcontrol.com.br"
        Dim sDatabase As String = "pdvcontrol36"
        Dim sUsu As String = "pdvcontrol36"
        Dim sSenha As String = "control01"
        Dim sql As String
        Try
            'Conexao ao MySql
            c.ConnectionString = "server=" & sServer & "; database=" & sDatabase & "; Uid=" & sUsu & "; Pwd=" & sSenha '& "; Min Pool Size=0;Max Pool Size = 100; Connection Lifetime =600;Pooling = true; Connection reset = true"

            Dim data As String
            Dim hora As String
            Dim versaoApp As String
            data = Format(Now, "yyyy-MM-dd")
            hora = Format(Now, "HH:mm:ss")
            versaoApp = My.Application.Info.Version.ToString

            sql = "INSERT INTO log_mix (sistema,form,descricao_erro,data,hora "
            sql += ") VALUES ("
            sql += "'MIXPDV (" & versaoApp & ") " & Environment.MachineName & "',"
            sql += "'" & strCNPJ & "',"
            sql += "'" & msg.ToString.Replace("'", "") & "','" & data.ToString & "','" & hora & "')"


            Dim cd As New MySql.Data.MySqlClient.MySqlCommand


            c.Open()
            cd.Connection = c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            'cd.Dispose()
            c.Close()


        Catch myErro As MySql.Data.MySqlClient.MySqlException
            System.Console.WriteLine("Util.logWeb: " & myErro.Message)
            log(myErro.Message, System.Environment.StackTrace, "Util.logWeb")
        End Try
    End Sub
    ''' <summary>
    ''' Faz bkp da base de dados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub backupDB()

        Dim origem As String = Application.StartupPath & "\db"
        Dim destino As String = Application.StartupPath & "\db\bkp"
        Dim arquivo As String = "mixdb2.db"
        Dim nArquivo As String

        nArquivo = "bkp-" & DateTime.Today.ToString("yyyy") & "-" & DateTime.Today.ToString("MM") & "-" & DateTime.Today.ToString("dd") & ".db"

        'Sai caso o bkp do dia ja exista
        If System.IO.File.Exists(destino & "\" & nArquivo) Then
            Exit Sub
        End If

        If Not System.IO.Directory.Exists(destino) Then
            System.IO.Directory.CreateDirectory(destino)
        End If
        Try

            File.Copy(origem & "\" & arquivo, destino & "\" & nArquivo)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Util.log(ex.Message, System.Environment.StackTrace, "Backup")
            System.Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub escreverTXT(ByVal localNomeArquivo As String, ByVal msg As String)
        Dim msgLog As String
        'If Not System.IO.Directory.Exists(Application.StartupPath &
        '"\log\") Then
        '    System.IO.Directory.CreateDirectory(Application.StartupPath &
        '    "\log\")
        'End If

        Dim localLogFile As String
        'localLogFile = Application.StartupPath & "\log\log_" & Format(Date.Today, "yyyyMM") & ".txt"
        localLogFile = localNomeArquivo
        'check the file
        Dim fs As FileStream = New FileStream(localLogFile, _
                                              FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(localLogFile, FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        msgLog = "" & msg.ToString.Trim
        s1.Write(msgLog.ToString & vbCrLf)
        s1.Close()
        fs1.Close()


    End Sub
    ''' <summary>
    ''' Retorna um arayList com as linhas do arquivo
    ''' </summary>
    ''' <param name="localnomearquivo">Local e nome do Arquivo</param>
    ''' <returns>List com as linhas do arquivo</returns>
    ''' <remarks></remarks>
    Public Function lerTXT(ByVal localnomearquivo As String) As List(Of String)
        Dim lista As New List(Of String)
        'Dim fs As New FileStream(localnomearquivo, FileMode.Open) 'OpenOrCreate)
        Dim arq As New StreamReader(localnomearquivo, System.Text.Encoding.Default)

        Dim l As String
        Do
            l = arq.ReadLine
            If Not l Is Nothing Then
                lista.Add(l)
            End If
        Loop Until l Is Nothing

        arq.Close()
        Return lista

    End Function
    ''' <summary>
    ''' Registra em banco de dados na web o uso do sistema
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub notificacaoOnLineDeUso()
        Dim c As New MySql.Data.MySqlClient.MySqlConnection

        Dim sServer As String = "mysql43.pdvcontrol.com.br"
        Dim sDatabase As String = "pdvcontrol36"
        Dim sUsu As String = "pdvcontrol36"
        Dim sSenha As String = "control01"
        Dim sql As String
        Try
            'Conexao ao MySql
            c.ConnectionString = "server=" & sServer & "; database=" & sDatabase & "; Uid=" & sUsu & "; Pwd=" & sSenha '& "; Min Pool Size=0;Max Pool Size = 100; Connection Lifetime =600;Pooling = true; Connection reset = true"

            Dim data As String
            Dim hora As String
            Dim versaoApp As String
            data = Format(Now, "yyyy-MM-dd")
            hora = Format(Now, "HH:mm:ss")
            versaoApp = My.Application.Info.Version.ToString



            'Inserir Informacao
            sql = "INSERT INTO appinfo (sistema,versao,cnpj,data,hora "
            sql += ") VALUES ("
            sql += "'MIXPDV'"
            sql += ",'" & versaoApp & "','" & strCNPJ & "','" & data.ToString & "','" & hora & "')"
            sql += " ON DUPLICATE KEY UPDATE "
            sql += "versao='" & versaoApp & "', data='" & data.ToString & "', hora='" & hora & "'"

            Dim cd As New MySql.Data.MySqlClient.MySqlCommand


            c.Open()
            cd.Connection = c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            'cd.Dispose()
            c.Close()

        Catch myErro As MySql.Data.MySqlClient.MySqlException
            'System.Console.WriteLine("Util.logWeb: " & myErro.Message)
            log(myErro.Message, System.Environment.StackTrace, "notificacaoOnLineDeUso")
        End Try
    End Sub


    Public Sub enviarEmail(ByVal EmailDestino As String, ByVal arqAnexo As String)

        'EmailDestino = "suporte@pdvcontrol.com.br"


        Dim strAssunto As String

        'Define os dados do e-mail
        Dim nomeRemetente As String
        Dim emailRemetente As String
        Dim senha As String

        nomeRemetente = "MixPDV: " + strRazao
        emailRemetente = "suporte@pdvcontrol.com.br"
        senha = "secreto1"

        Dim emailDestinatario As String
        'Dim emailComCopia As String
        'Dim emailComCopiaOculta As String

        emailDestinatario = EmailDestino
        'emailComCopia = "email@comcopia.com.br"
        'emailComCopiaOculta = "email@comcopiaoculta.com.br"


        'Host da porta SMTP
        Dim SMTP As String

        SMTP = "smtp.pdvcontrol.com.br"

        Dim assuntoMensagem As String
        Dim conteudoMensagem As String

        If strAssunto = "" Then
            strAssunto = "Email sem Assunto"
        ElseIf strAssunto = "" Then
            strAssunto = "Email Vazio"
        End If

        assuntoMensagem = strAssunto
        conteudoMensagem = strMensagem


        'Cria objeto com dados do e-mail.
        Dim objEmail As New System.Net.Mail.MailMessage()

        'Define o Campo From e ReplyTo do e-mail.
        objEmail.From = New System.Net.Mail.MailAddress("<" & emailRemetente & ">")
        'objEmail.ReplyTo = New System.Net.Mail.MailAddress("Nome <email@seudominio.com.br>")

        'Define os destinatários do e-mail.
        objEmail.To.Add("<" & emailDestinatario & ">")


        'Anexa Arquivo
        objEmail.Attachments.Add(New System.Net.Mail.Attachment(Application.StartupPath & "\mail\" & arqAnexo))


        'Define a prioridade do e-mail.
        objEmail.Priority = System.Net.Mail.MailPriority.Normal

        'Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
        objEmail.IsBodyHtml = True

        'Define o título do e-mail.
        objEmail.Subject = strAssunto

        'Define o corpo do e-mail.
        objEmail.Body = "<b>" & strMensagem & "</b>"

        'Para evitar problemas com caracteres "estranhos", configuramos o Charset para "ISO-8859-1"
        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")



        'Cria objeto com os dados do SMTP
        Dim objSmtp As New System.Net.Mail.SmtpClient(SMTP, 587)

        'Alocamos o endereço do host para enviar os e-mails  
        objSmtp.Credentials = New System.Net.NetworkCredential(emailRemetente, senha)
        objSmtp.Host = SMTP
        objSmtp.Port = 587

        'Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
        'objEmail.EnableSsl = true;

        'Enviamos o e-mail através do método .send()

        Try
            objSmtp.Send(objEmail)
            'Response.Write("E-mail enviado com sucesso !")
            objEmail.Dispose()
            'File.Delete("c:\gac\" & Replace(Mid(txtcliente.Text, 1, 20), ":", "") & ".doc")
        Catch ex As Exception
            '' Response.Write("Ocorreram problemas no envio do e-mail. Erro = " & ex.Message)
        End Try
        'excluímos o objeto de e-mail da memória
        objEmail.Dispose()
        'anexo.Dispose();
    End Sub
    Public Sub envioXmlContados()
        '
        ' 08/01/2016 - Falta Concluir as funcoes abaixo
        '
        'Leonardo Aquino

        'Dim fOrigem As String
        'Dim fDestino As String
        'Dim fName As String
        'Dim zip As New Zip
        'Dim fConfig As String
        'Dim pXmlAutorizado As String

        ''Le as configuracoes do sistema
        'fConfig = Application.StartupPath & "\config.ini"
        'pXmlAutorizado = LeArquivoINI(fConfig, "UniNFe", "pXmlAutorizado", Application.StartupPath)

        ''Local onde estao os XMLs Autorizados
        'fOrigem = pXmlAutorizado & "\201510\*.*"

        ''Local e nome de destino do arquivo ZIP
        'fName = strCNPJ & "-201510.zip"
        'fDestino = Application.StartupPath & "\zip\" & fName
        ''Compactando o arquivo
        'zip.compactaArquivo(fOrigem, fDestino)

        ''Email de Destino
        'Dim mailD As String = "brinfo.leo@gmail.com"

        ''Enviando email
        'enviarEmail(mailD, fDestino)



    End Sub
End Module
