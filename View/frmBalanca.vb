
Public Class frmBalanca

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim ret As Double

        'a função ObtemInformacao é uma função da dll e ela retorna o valor
        'do campo desejado sendo:
        ' 0 = Status
        ' 1 = Peso bruto
        ' 2 = tara
        ' 3 = liquido
        ' 4 = Contador
        ' 5 = Codigo
        ' 6 = Valor unitário
        ' 7 = Valor Total
        ' 8 = Número de casas decimais

        Try
            InicializaLeitura(0)
            ret = ObtemInformacao(0, 0)
        Catch ex As Exception
            Util.log(ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MixPDV")
            Exit Sub
        End Try
        If pcImg.Visible = True Then pcImg.Visible = False Else pcImg.Visible = True

        Select Case ret

            Case -1
                lblStatus.Text = "O número da balança deve estar entre 0 e 7."
                lblStatus.ForeColor = Color.Red
            Case 0
                lblStatus.Text = "Erro de leitura."
                lblStatus.ForeColor = Color.Red
            Case 1
                lblStatus.Text = "Peso oscilando."
                lblStatus.ForeColor = Color.Red
            Case 2
                lblStatus.Text = "Peso estável."
                lblStatus.ForeColor = Color.Green
                frmCaixa.txtQtd.Text = lblBruto.Text
                Timer1.Stop()
                Close()
                frmCaixa.txtCod.Text = ""
            Case 3
                lblStatus.Text = "Sobrecarga" '"Balança fora de range (sobrecarga/alívio de plataforma)"
                lblStatus.ForeColor = Color.Red
            Case 4
                lblStatus.Text = "Licença de software não encontrada."
                lblStatus.ForeColor = Color.Red
            Case -99999.0
                lblStatus.Text = "Balança não conectada"
                lblStatus.ForeColor = Color.Red
        End Select

        If ret = 1 Or ret = 2 Then
            'vamos construir uma mascara para caso seja necessário formatar o peso
            'com as casas decimais.
            Dim mascara As String
            Dim Aux As Double

            mascara = ".0"
            For Aux = 1 To ObtemInformacao(0, 8)
                mascara = mascara + "0"
            Next Aux

            lblBruto.Text = Format(ObtemInformacao(0, 1), mascara) / 1000

            'lblBruto.Text = Left(mascara, 2) & "," & Mid(mascara, 3)

            'btConfirmar.Focus()

            If lblBruto.Text = "0" Then
                lblStatus.Text = "Sem Peso."
                lblStatus.ForeColor = Color.Red
                lblBruto.Text = "---"
                'btConfirmar.Focus()
            End If

        Else
            Call LimpaDados()
        End If

    End Sub
    Private Sub LimpaDados()
        lblBruto.Text = "----"
    End Sub

    Private Sub frmBalanca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Timer1.Stop()
            Close()
        ElseIf e.KeyChar = ChrW(Keys.Enter) Then

            If lblStatus.Text = "Peso estável." Then
                frmCaixa.txtQtd.Text = lblBruto.Text
                Timer1.Stop()
                Close()
                frmCaixa.txtCod.Text = ""
            Else
                MessageBoxPadrao("OPS!, Erro ao pegar peso.")
                Timer1.Stop()
                Me.Close()

            End If

        End If
    End Sub

    Private Sub frmBalanca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hide()
    End Sub

End Class