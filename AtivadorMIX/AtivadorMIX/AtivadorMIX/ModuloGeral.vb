Module ModuloGeral

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
        If flag = False Then MessageBoxPadrao("CNPJ inválido!")
        Return flag
    End Function
    Public Sub MessageBoxPadrao(ByVal Mensagem As String) ' MENSAGEM PADRAO EDUARDO SILVA 21/10/2014
        MessageBox.Show(Mensagem, "MixPDV - Sistemas Integrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
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
End Module
