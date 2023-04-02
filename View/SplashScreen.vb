Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblStatus.Text = "Caregando Configurações."
        lblStatus.Refresh()
        Esperar(1000)

        If strAmbiente = 2 Then
            lblStatus.Text = "Ambiente de Homologação."
        Else
            lblStatus.Text = "Ambiente de Produção."
        End If
        lblStatus.Refresh()
        Esperar(1000)


        lblStatus.Text = "Conexão com a internet."
        lblStatus.Refresh()
        If Util.internet = False Then
            MsgBox("Favor verificar sua conexão!", MsgBoxStyle.Exclamation, "Internet")
        End If
        Esperar(2000)


        lblStatus.Text = "Executando backup."

        lblStatus.Refresh()
        Util.backupDB()
        Esperar(1000)

        'Testa e inicia o UNINFe caso esteja off line
        lblStatus.Text = "Iniciando UniNFe"
        lblStatus.Refresh()
        If Util.programaAberto("uninfe") = False Then
            If System.IO.File.Exists("C:\Unimake\UniNFe\uninfe.exe") Then
                Shell("C:\Unimake\UniNFe\uninfe.exe")
            Else
                Util.log("UniNFe nao localizado em C:\Unimake\UniNFe\uninfe.exe")
            End If
        End If

        'lblStatus.Text = "Verificando IBPT/NCM na Web."
        'lblStatus.Refresh()
        'Esperar(2000)

        lblStatus.Text = "Analisando parametros"
        lblStatus.Refresh()
        Esperar(1000)
        Util.notificacaoOnLineDeUso()

        Util.envioXmlContados()
    End Sub
End Class
