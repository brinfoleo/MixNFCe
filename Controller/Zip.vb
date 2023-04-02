
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Public Class Zip
    Dim streamFonte As FileStream
    Dim streamDestino As FileStream
    Dim streamCompactado As GZipStream
    Dim streamDescompactado As GZipStream
    Public Sub compactaArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String)
        Try
            ' ----- Descompacta a string compactada previamente.
            '       primeiro , cria a enetra do arquivo stream
            streamFonte = New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)

            ' ----- Cria a saida do arquivo stream
            streamDestino = New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

            ' ----- Os bytes serão processados por um compressor de streams
            streamCompactado = New GZipStream(streamDestino, CompressionMode.Compress, True)

            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer
            Do
                bytesLidos = streamFonte.Read(buffer, 0, tamanhoBloco)
                If (bytesLidos = 0) Then Exit Do
                streamCompactado.Write(buffer, 0, bytesLidos)
            Loop
            ' ----- Fecha todos os streams
            streamFonte.Close()
            streamCompactado.Close()
            streamDestino.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            '' ----- Fecha todos os streams
            'streamFonte.Close()
            'streamCompactado.Close()
            'streamDestino.Close()
        End Try
    End Sub

    Public Sub descompactaArquivo(ByVal arquivoOrigem As String, ByVal arquivoDestino As String)
        ' ----- Compacata o contéudo do arquivo e
        '       guarda o resultado em um novo arquivo
        Try
            streamFonte = New FileStream(arquivoOrigem, FileMode.Open, FileAccess.Read)
            streamDestino = New FileStream(arquivoDestino, FileMode.Create, FileAccess.Write)

            ' ----- Os bytes serão processados através de um decompressor de stream
            streamDescompactado = New GZipStream(streamFonte, CompressionMode.Decompress, True)

            ' ----- Processa os bytes de um arquivo para outro
            Const tamanhoBloco As Integer = 4096
            Dim buffer(tamanhoBloco) As Byte
            Dim bytesLidos As Integer
            Do
                bytesLidos = streamDescompactado.Read(buffer, 0, tamanhoBloco)
                If (bytesLidos = 0) Then Exit Do
                streamDestino.Write(buffer, 0, bytesLidos)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' ----- Fecha todos os arquivos
            streamFonte.Close()
            streamDescompactado.Close()
            streamDestino.Close()
        End Try
    End Sub


End Class


