Imports System.Text
'########################################################################################################################
'# COMUNICAÇÃO COM BALANÇAS DE CHECK-OUT FEITA ATRAVÉS DA DLL PCSCALE.DLL | EDUARDO SILVA - 03/07/2015
'########################################################################################################################
Module Filizola
    'Declaração das funções
    Public Declare Function ConfiguraBalanca Lib "PcScale.dll" (ByVal balanca As Integer, ByVal Handle As Long) As Boolean
    Public Declare Function InicializaLeitura Lib "PcScale.dll" (ByVal balanca As Integer) As Boolean
    Public Declare Function ObtemInformacao Lib "PcScale.dll" (ByVal balanca As Integer, ByVal campo As Integer) As Double
    Public Declare Function FinalizaLeitura Lib "PcScale.dll" (ByVal balanca As Integer) As Boolean
    Public Declare Function EnviaPrecoCS Lib "PcScale.dll" (ByVal balanca As Integer, ByVal preco As Double) As Boolean
    Public Declare Sub ExibeMsgErro Lib "PcScale.dll" (ByVal Handle As Long)

    Public Function RetornaStatus(ByRef sMensagem As String) As Integer

        Dim ret As Double
        Dim buffer_info As String

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

        ret = ObtemInformacao(0, 0) 'AQUI NO CAMPO RET = (2.0) E COMPARANDO COM O EXEMPLO ESTA (2) SOMENTE

        Select Case ret
            Case -1
                sMensagem = "O número da balança deve estar entre 0 e 7."
            Case 0
                sMensagem = "Erro de leitura da balança."
            Case 1
                sMensagem = "Peso oscilando."
            Case 2
                sMensagem = "Peso estável." 'ESTA CAINDO CERTINHO COMO NO EXEMPLO
            Case 3
                sMensagem = "Balança fora de range (sobrecarga/alívio de plataforma)"
            Case 4
                sMensagem = "Licença de software não encontrada."
        End Select


    End Function
End Module
