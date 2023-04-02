'Imports System.Data.DataView            'para usar na busca dos dados
'Imports System.Data.SqlClient           'conexao com o banco
'Imports System.Data.OleDb               'conexao com o bancood
'Imports System.Drawing
'Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class frmRelGerencial
    Dim linha As String
    Dim Printer As New Printer
    Dim total As Decimal
    Public Sub FormatarGrid_Pagamentos()
        grdVendasPorFormaDePagamento.Columns(2).HeaderText = "VALOR"
        grdVendasPorFormaDePagamento.Columns(1).HeaderText = "DATA"
        grdVendasPorFormaDePagamento.Columns(0).HeaderText = "FORMA DE PAGAMENTO"
        grdVendasPorFormaDePagamento.Columns(0).Width = "348"
        grdVendasPorFormaDePagamento.ScrollBars = ScrollBars.Both
        grdVendasPorFormaDePagamento.RowHeadersVisible = False
        grdVendasPorFormaDePagamento.ReadOnly = True
    End Sub

    Public Sub FormatarGrid_Vendas()
        grdVendas.Columns(0).HeaderText = "DATA"
        grdVendas.Columns(1).HeaderText = "CÓDIGO"
        grdVendas.Columns(2).HeaderText = "DESCRIÇÃO"
        grdVendas.Columns(3).HeaderText = "VALOR"
        grdVendas.Columns(4).HeaderText = "CD"
        grdVendas.Columns(4).Width = "50"
        grdVendas.Columns(2).Width = "200"
        grdVendas.ScrollBars = ScrollBars.Both
        grdVendas.RowHeadersVisible = False
        grdVendas.ReadOnly = True
    End Sub

    Public Sub FormatarGrid_Situacao()
        dgvSituacaoNFCe.Columns(0).HeaderText = "DATA / HORA"
        dgvSituacaoNFCe.Columns(1).HeaderText = "CHAVE DA NFCe"
        dgvSituacaoNFCe.Columns(2).HeaderText = "VALOR"
        dgvSituacaoNFCe.Columns(0).Width = "145"
        dgvSituacaoNFCe.Columns(1).Width = "325"
        dgvSituacaoNFCe.Columns(2).Width = "85"
        dgvSituacaoNFCe.ScrollBars = ScrollBars.Both
        dgvSituacaoNFCe.RowHeadersVisible = False
        dgvSituacaoNFCe.ReadOnly = True
    End Sub
    Function CompletaZeros(ByVal sPalavra As String, ByVal nTamanho As Integer, Optional ByVal pDirecao As String = "E") As String
        Dim i As Integer
        Dim sTexto As String = Trim(sPalavra)
        Dim nFalta As Integer = nTamanho - Len(sTexto)
        If nFalta > 0 Then
            For i = 1 To nFalta
                If pDirecao = "E" Then
                    sTexto = "0" & sTexto
                Else
                    sTexto = sTexto & "0"
                End If
            Next
        End If
        CompletaZeros = sTexto
    End Function
    Private Sub SaltaLinhas(ByVal Qtd As String)
        Dim i As Integer
        For i = 1 To Qtd
            Printer.Print(" ")
        Next
    End Sub
    Private Sub Divisor(ByVal Tipo As String)
        Select Case Tipo
            Case "Traco"
                Printer.Print("---------------------------------------------------------------------------")
            Case "Estrela"
                Printer.Print("*****************************************************************")
            Case "Tralha"
                Printer.Print("###############################################################")
            Case "Traco Duplo"
                Printer.Print("===========================================================================")
            Case "Linha"
                Printer.Print("___________________________________________________________________________")
        End Select

    End Sub
    Public Function CompletaEspacos(ByVal sPalavra As String, ByVal nTamanho As Integer, Optional ByVal sPos As String = "E") As String
        Dim i As Integer
        Dim sTexto As String = Trim(sPalavra)
        Dim nFalta As Integer = nTamanho - Len(sTexto)
        If nFalta > 0 Then
            For i = 1 To nFalta
                If sPos = "E" Then
                    sTexto = " " & sTexto
                Else
                    sTexto = sTexto & " "
                End If
            Next
        End If
        CompletaEspacos = sTexto
    End Function

    Private Sub frmMovVenda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.cbousuarios.Focus()
        'Me.cbousuarios.Text = frmVenda.Usuario_Conectado.Nome
        'btnListar.PerformClick()
    End Sub

    Private Sub frmRelGerencial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' ESC - Sair do sistema 
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Windows.Forms.Keys.Down Then
            dgvSituacaoNFCe.Focus()
        ElseIf e.KeyCode = Keys.I Then
            btnImprimir.PerformClick()
        ElseIf e.KeyCode = Keys.T Then
            rbT.Checked = True
        ElseIf e.KeyCode = Keys.A Then
            rbA.Checked = True
        ElseIf e.KeyCode = Keys.C Then
            rbC.Checked = True
        ElseIf e.KeyCode = Keys.Z Then
            rbI.Checked = True
        End If
    End Sub

    Private Sub frmMovVenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub frmMovVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Util.acesso(Me, 3)

        TabControl1.TabPages(0).Focus()

        Me.cbousuarios.Focus()
        txtInicial.Text = Now().ToString("dd/MM/yyyy")
        txtFinal.Text = Now().ToString("dd/MM/yyyy")

        'CARREGA USUARIO-----------------------------------------------------------------------------------------
        'Falta incluir a opcao de Todos

        Dim usuDAO As New UsuarioDAO


        cbousuarios.DataSource = usuDAO.listarUsuarios.Tables("myTable")
        cbousuarios.ValueMember = "id"
        cbousuarios.DisplayMember = "usuario"

        '--------------------------------------------------------------------------------------------------------------
        'Limpa o form
        grdVendas.DataSource = Nothing
        grdVendas.Refresh()
        grdVendasPorFormaDePagamento.DataSource = Nothing
        grdVendasPorFormaDePagamento.Refresh()
        'txtTotalVenda2.Text = ""

    End Sub

    Private Sub txtInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtFinal.Focus()
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub btnListar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub cbousuarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbousuarios.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnListar.PerformClick()
        End If
    End Sub

    Private Sub relatorioMeioPgto()
        Dim Data, Fpagamento, Valor As String

        Printer.FontSize = 9
        Printer.FontName = "Times New Roman"
        Divisor("Estrela")
        Printer.Print("        FECHAMENTO DE  " & "" & txtInicial.Text & "  A  " & txtFinal.Text)
        Divisor("Estrela")
        Printer.FontSize = 14
        Printer.FontBold = True
        Printer.Print("  FORMAS   DE   PAGAMENTO")
        Printer.FontBold = False
        Printer.FontSize = 9
        Divisor("Traco")
        Dim v As String


        For Each linha As DataGridViewRow In grdVendasPorFormaDePagamento.Rows
            Dim pcY As String = Printer.CurrentY
            Dim pcX As String = Printer.CurrentX

            Printer.FontSize = 10
            ' FORMATA CAMPOS
            Data = Format(CDate(linha.Cells(1).Value.ToString), "dd/MM/yy")
            Fpagamento = linha.Cells(0).Value.ToString
            Valor = FormatCurrency(linha.Cells(2).Value.ToString())
            ' IMPRIME
            Printer.Print(Data & "-" & Fpagamento)
            v = Valor
            Printer.CurrentY = pcY
            Printer.CurrentX = 4000 - Printer.TextWidth(v)
            Printer.Print(v)
        Next

        Printer.FontSize = 9
        Divisor("Traco")
        Printer.FontBold = True
        Printer.FontSize = 13
        Printer.ScaleX(20)
        v = "TOTAL: " & FormatCurrency(total) '.PadLeft(35, ".")
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.Print(v)

        Printer.FontBold = False
        Printer.FontSize = 8
        Divisor("Traco")
        Printer.Print("Usuario: " & cbousuarios.Text)
        Divisor("Traco")
        SaltaLinhas(4)
        Divisor("Linha")
        Printer.Print("MixPDV Sistemas  " & Now())
        Printer.EndDoc()
    End Sub



    Private Sub relatorioCompleto()
        Dim v As String

        Printer.FontSize = 9
        Printer.FontName = "Times New Roman"
        Divisor("Estrela")
        Printer.Print("      FECHAMENTO DE  " & "" & txtInicial.Text & "  A  " & txtFinal.Text)
        Divisor("Estrela")
        Printer.FontSize = 14
        Printer.FontBold = True
        Printer.Print("    MOVIMENTO   DO   CAIXA")
        Printer.FontBold = False
        Printer.FontSize = 9
        Divisor("Traco")


        For Each linha As DataGridViewRow In grdVendas.Rows
            '06.08.2015
            'Printer.Print(CompletaEspacos(Format(linha.Cells(0).Value, "dd/MM/yy") & " - " & linha.Cells(1).Value.ToString, 10, "E") & "......................  " & FormatCurrency(linha.Cells(2).Value.ToString) & vbCrLf)
            Dim pcY As String = Printer.CurrentY
            Dim pcX As String = Printer.CurrentX

            Printer.Print(CompletaEspacos(Format(CDate(linha.Cells(0).Value), "dd/MM/yyyy") & " - " & linha.Cells(1).Value.ToString.PadLeft(6, "0"), 10, "E") & " - " & IIf(linha.Cells(2).Value.ToString.Length > 20, Mid(linha.Cells(2).Value.ToString, 1, 20), linha.Cells(2).Value.ToString))
            v = FormatNumber(linha.Cells(3).Value.ToString.Replace(".", ",")) & " " & linha.Cells(4).Value.ToString
            Printer.CurrentY = pcY
            Printer.CurrentX = 4000 - Printer.TextWidth(v)
            Printer.Print(v)
        Next

        Divisor("Traco")
        For Each linha As DataGridViewRow In grdVendasPorFormaDePagamento.Rows
            Dim pcY As String = Printer.CurrentY
            Dim pcX As String = Printer.CurrentX
            'Printer.Print(CompletaEspacos(linha.Cells(0).Value.ToString, 10, "D") & "......................  " & FormatCurrency(linha.Cells(2).Value.ToString()) & vbCrLf)
            Printer.Print(CompletaEspacos(Format(CDate(linha.Cells(1).Value.ToString), "dd/MM/yy") & " - " & linha.Cells(0).Value.ToString, 10, "D"))
            v = FormatCurrency(linha.Cells(2).Value.ToString())
            Printer.CurrentY = pcY
            Printer.CurrentX = 4000 - Printer.TextWidth(v)
            Printer.Print(v)
        Next

        Printer.FontSize = 9
        Divisor("Traco")
        Printer.FontBold = True
        Printer.FontSize = 13
        Printer.ScaleX(20)

        v = "TOTAL: " & FormatCurrency(total) 'txtTotalVenda2.Text.PadLeft(35, ".")
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.Print(v)

        Printer.FontBold = False
        Printer.FontSize = 8
        Divisor("Traco")
        Printer.Print("Usuario: " & cbousuarios.Text)
        Divisor("Traco")
        SaltaLinhas(4)
        Divisor("Linha")
        Printer.Print("MixPDV Sistemas  " & Now())
        Printer.EndDoc()

        'Printer.Print("---------------------------------------------------------------------------")
        'Printer.Print(CompletaEspacos("TOTAL: ", 10, "d") & "......................................  " & txtTotalVenda2.Text)
        'Printer.Print("---------------------------------------------------------------------------")
        'Printer.Print("Usuario: " & cbousuarios.Text)
        'Printer.Print("---------------------------------------------------------------------------")
        'Printer.Print(" ")
        'Printer.Print(" ")
        'Printer.Print("MixPDV Sistemas  " & Now())
        'Printer.EndDoc()
    End Sub
    Private Sub relatorioGerencial()
        Dim v As String
        Dim vgTotal As Decimal

        Printer.FontSize = 9
        Printer.FontName = "Times New Roman"
        Divisor("Estrela")
        Printer.Print("      FECHAMENTO DE  " & "" & txtInicial.Text & "  A  " & txtFinal.Text)
        Divisor("Estrela")
        Printer.FontSize = 14
        Printer.FontBold = True
        Printer.Print(" RELATORIO GERENCIAL NFCe")
        Printer.FontBold = False
        Printer.FontSize = 9
        Divisor("Traco")

        'Armazena o status da nota
        'A - Autorizada
        'C - Cancelada
        'I - Inutilizada
        Dim statusNt As String

        Dim nfeDAO As New NFeDAO
        Dim nts As List(Of NFCe)
        Dim pcY As String
        Dim pcX As String
        nts = nfeDAO.listarTodasNFesNoPeriodo(txtInicial.Text, txtFinal.Text)

        For Each nt As NFCe In nts
            If nt.nProtCancelamento <> Nothing Then
                statusNt = "C"
            ElseIf nt.nProtInutilizacao <> Nothing Then
                statusNt = "I"
            ElseIf nt.nProt <> Nothing Then
                statusNt = "A"
            Else
                statusNt = "?"
            End If

            pcY = Printer.CurrentY
            Printer.Print(CompletaEspacos(Format(CDate(nt.infNFE.ide.dhEmi), "dd/MM/yy") & " - " & nt.infNFE.ide.nNF.ToString & " / " & statusNt, 10, "E"))
            v = "R$ " & FormatNumber(nt.infNFE.total.ICMSTot.vNF.ToString.Replace(".", ","))
            Printer.CurrentY = pcY
            Printer.CurrentX = 4000 - Printer.TextWidth(v)
            Printer.Print(v)
            If statusNt = "A" Or statusNt = "?" Then
                vgTotal = vgTotal + nt.infNFE.total.ICMSTot.vNF.ToString.Replace(".", ",")
            End If
        Next

        'Divisor("Traco")
        'For Each linha As DataGridViewRow In grdVendasPorFormaDePagamento.Rows
        '    pcY = Printer.CurrentY
        '    pcX = Printer.CurrentX

        '    Printer.Print(CompletaEspacos(Format(CDate(linha.Cells(1).Value.ToString), "dd/MM/yy") & " - " & linha.Cells(0).Value.ToString, 10, "D"))
        '    v = FormatCurrency(linha.Cells(2).Value.ToString())
        '    Printer.CurrentY = pcY
        '    Printer.CurrentX = 4000 - Printer.TextWidth(v)
        '    Printer.Print(v)
        'Next
        Printer.FontSize = 9
        Divisor("Traco")
        Printer.FontBold = True
        Printer.FontSize = 13
        Printer.ScaleX(20)

        pcY = Printer.CurrentY
        Printer.Print("TOTAL")
        v = FormatCurrency(vgTotal) 'txtTotalVenda2.Text.ToString
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.CurrentY = pcY
        Printer.Print(v)

        Printer.FontBold = False
        Printer.FontSize = 8
        Divisor("Traco")

        Printer.Print(" ")
        Printer.Print("=== ANALISE TOTAL DE NOTAS EMITIDAS ===")
        Printer.Print(" ")

        Dim ntAutorizada As Integer
        ntAutorizada = nfeDAO.totalNotasAutorizadas(txtInicial.Text, txtFinal.Text)
        Dim ntCancelada As Integer
        ntCancelada = nfeDAO.totalNotasCanceladas(txtInicial.Text, txtFinal.Text)
        Dim ntInutilizada As Integer
        ntInutilizada = nfeDAO.totalNotasInutilizadas(txtInicial.Text, txtFinal.Text)
        Dim ntTotal As Integer
        ntTotal = ntAutorizada + ntCancelada + ntInutilizada

        pcY = Printer.CurrentY
        Printer.Print("Autorizadas (A)")
        v = ntAutorizada.ToString.PadLeft(6, "0")
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.CurrentY = pcY
        Printer.Print(v)

        pcY = Printer.CurrentY
        Printer.Print("Canceladas (C)")
        v = ntCancelada.ToString.PadLeft(6, "0")
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.CurrentY = pcY
        Printer.Print(v)

        pcY = Printer.CurrentY
        Printer.Print("Inutilizadas (I)")
        v = ntInutilizada.ToString.PadLeft(6, "0")
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.CurrentY = pcY
        Printer.Print(v)

        pcY = Printer.CurrentY
        Printer.Print(" ")
        v = "------------------"
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.CurrentY = pcY
        Printer.Print(v)

        pcY = Printer.CurrentY
        Printer.Print("Totalizando")
        v = ntTotal.ToString.PadLeft(6, "0")
        Printer.CurrentX = 4000 - Printer.TextWidth(v)
        Printer.CurrentY = pcY
        Printer.Print(v)




        Divisor("Traco")
        Printer.Print("Usuario: " & cbousuarios.Text)
        Divisor("Traco")
        Printer.Print(" ")
        Printer.Print(" ")
        Printer.Print("MixPDV Sistemas  " & Now())
        Printer.EndDoc()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If TabControl1.SelectedIndex = 0 Then
            If MsgBox("Deseja imprimir relatório completo?", vbYesNo + MsgBoxStyle.Information, "") = vbYes Then
                relatorioCompleto()
            Else
                relatorioMeioPgto()
            End If
        Else
            relatorioGerencial()
        End If
    End Sub
    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        'If TabControl1.SelectedIndex = 0 Then
        fechamentoCaixa()
        ' Else
        situacaoNFCe()
        'End If

    End Sub
    Private Sub situacaoNFCe()

        Dim nfeDAO As New NFeDAO
        Dim ds As DataSet

        ds = nfeDAO.listarSituacaoNFCes(txtInicial.Text, txtFinal.Text)

        dgvSituacaoNFCe.DataSource = Nothing
        dgvSituacaoNFCe.DataSource = ds.Tables("myTable")
        dgvSituacaoNFCe.Columns(0).DataPropertyName = "data"
        dgvSituacaoNFCe.Columns(1).DataPropertyName = "chave"
        dgvSituacaoNFCe.Columns(2).DataPropertyName = "valor"
        dgvSituacaoNFCe.Columns("valor").DefaultCellStyle.Format = "c"

        ' VOU AGUARDAR VOCA CONCLUIR PARA EU ACERTAR MELHOR ESSE LAYOUT OK, NAO CONSEGUI PENSAR EM UMA FORMA MELHOR AINDA.
        lblStatusQtd.Text = "AUTORIZADAS(" & nfeDAO.totalNotasAutorizadas(txtInicial.Text, txtFinal.Text) & ")= R$ 999,999,99 " & _
             "|CANCELADAS (" & nfeDAO.totalNotasCanceladas(txtInicial.Text, txtFinal.Text) & ")= R$ 999,999,99 " & _
             "|INUTI. (" & nfeDAO.totalNotasInutilizadas(txtInicial.Text, txtFinal.Text) & ")= R$ 999,999,99 "

        FormatarGrid_Situacao()


        'dgvSituacaoNFCe.Refresh()   
    End Sub
    Private Sub fechamentoCaixa()
        Dim cxDAO As New CaixaDAO
        'Dim nfeDAO1 As New NFeDAO
        'Listar Resumo de vendas

        With grdVendas
            '.DataSource = nfeDAO1.listarResumoNotas(cbousuarios.SelectedValue, txtInicial.Value, txtFinal.Value).Tables("myTable")
            .DataSource = cxDAO.listarMovimentoCaixa(txtInicial.Text, txtFinal.Text).Tables("myTable")
            .Columns.Remove("operadorID")
            '.Columns(0).DataPropertyName = "data"
            '.Columns.Remove("nProt")
            '.Columns.Remove("nProtCancelamento")
            '.Columns.Remove("nProtInutilizacao")
            .Columns("valor").DefaultCellStyle.Format = "c"

            FormatarGrid_Vendas()
        End With


        'Listar resumo de Pagamentos 
        With grdVendasPorFormaDePagamento
            .DataSource = cxDAO.listarResumoPgto(cbousuarios.SelectedValue, txtInicial.Value, txtFinal.Value).Tables("myTable")
            .Columns.Remove("operadorID")

            .Columns("valor").DefaultCellStyle.Format = "c"
            FormatarGrid_Pagamentos()
        End With



        Try

            total = 0

            'For Each linha As DataGridViewRow In grdVendasPorFormaDePagamento.Rows
            '    If linha.Cells(0).Value = "Sangria" Then
            '        total = total - Convert.ToDecimal(linha.Cells(1).Value)
            '    ElseIf (linha.Cells(0).Value = "Desconto Troca") Then
            '        total = total
            '    Else
            '        total = total + Convert.ToDecimal(linha.Cells(2).Value)
            '    End If
            For Each linha As DataGridViewRow In grdVendas.Rows
                'If linha.Cells(4).Value = "D" Then
                '    total = total - Convert.ToDecimal(linha.Cells(3).Value)
                'ElseIf (linha.Cells(4).Value = "C") Then
                '    total = total + Convert.ToDecimal(linha.Cells(3).Value)
                'Else
                total = total + Convert.ToDecimal(linha.Cells(3).Value)
                'End If
            Next

            'Dim TotalSangria As Decimal
            'Dim TotalSuprimento As Decimal
            '
            '       TotalSangria = GetTotalSangria(cbousuarios.Text, txtInicial.Text, txtFinal.Text)
            '       TotalSuprimento = GetTotalSuprimento(cbousuarios.Text, txtInicial.Text, txtFinal.Text)

            ''txtSangria.Text = "Total Sangria: R$ " + Format(TotalSangria, "#,##0.00")
            ''txtSuprimento.Text = "Total Suprimento: R$ " + Format(TotalSuprimento, "#,##0.00")
            'txtTotalVenda2.Text = "R$  " + Format(total, "#,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
    End Sub
    Private Sub cmdFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFechar.Click
        Me.Close()
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub dgvSituacaoNFCe_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSituacaoNFCe.CellContentClick

    End Sub
    Private Sub imprimirCupom(ByVal strChaveNFc As String)
        Try
            Dim nfDAO As New NFeDAO
            Dim nfce As New NFCe
            Dim eSefaz As New EnvioSEFAZUniNFe
            eSefaz.imprimirDanfe(strChaveNFc)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvSituacaoNFCe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSituacaoNFCe.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Para não deixar passar para a próxima linha do DataGrid quando pressionar ENTER
            e.SuppressKeyPress = True
            If dgvSituacaoNFCe.RowCount = 0 Then Exit Sub

            Try
                imprimirCupom(dgvSituacaoNFCe.CurrentRow.Cells(1).Value)

            Catch ex As Exception
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try

        End If
    End Sub

    Private Sub cbousuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbousuarios.SelectedIndexChanged

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.TabPages(1).Focus() Then
            lblObsImpressao.Visible = True
        Else
            lblObsImpressao.Visible = False
        End If
    End Sub
End Class