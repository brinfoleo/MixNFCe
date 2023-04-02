Imports System.IO
Imports System.Xml

Public Class ImportXML
    Private xml_file As String
    Public Sub New(ByVal localDoXml As String)
        xml_file = localDoXml
    End Sub
    Public Function importXML() As Object

        Dim nf As NFe
        Dim object_NFe As New Object
        Dim tipo As String = Nothing
        Dim protocolo As String = Nothing
        Dim dhRecbto As String = Nothing

        If xml_file IsNot Nothing Then
            Deserializar_NFe(xml_file, object_NFe, tipo)
            If object_NFe IsNot Nothing Then
                If tipo = "enviNFe" Then ' Lotes de NFes
                    For Each nf In object_NFe.NFe
                        'If sender Is ImprimirDanfeRetrato_Button Then
                        'DanfeRetrato.VisualizarImpressao(nf, protocolo, dhRecbto, path_img & "Logo.jpg", False)
                        'Else
                        'DanfePaisagem.VisualizarImpressao(nf, protocolo, dhRecbto, path_img & "Logo.jpg", False)
                        'End If
                    Next
                ElseIf tipo = "nfeProc" Then ' ' NFe já processada e com o protocolo
                    nf = object_NFe.NFe
                    nf.protNFe = object_NFe.protNFe
                    protocolo = object_NFe.protNFe.infProt.nProt
                    dhRecbto = Date.Parse(object_NFe.protNFe.infProt.dhRecbto).ToString("dd/MM/yyyy HH:mm")
                    'If sender Is ImprimirDanfeRetrato_Button Then
                    'DanfeRetrato.VisualizarImpressao(nf, protocolo, dhRecbto, path_img & "Logo.jpg", True)
                    'Else
                    'DanfePaisagem.VisualizarImpressao(nf, protocolo, dhRecbto, path_img & "Logo.jpg", True)
                    'End If
                ElseIf tipo = "NFe" Then ' NFe

                    nf = object_NFe
                    'If sender Is ImprimirDanfeRetrato_Button Then
                    'DanfeRetrato.VisualizarImpressao(nf, protocolo, dhRecbto, path_img & "Logo.jpg", True)
                    'Else
                    'DanfePaisagem.VisualizarImpressao(nf, protocolo, dhRecbto, path_img & "Logo.jpg", True)
                    'End If
                End If
            End If
        End If
        Return nf
    End Function


    Public Sub Deserializar_NFe(ByVal file_xml As String, ByRef object_NFe As Object, ByRef tipo As String)
        Dim serializer As Serialization.XmlSerializer
        Dim doc As XmlDocument = New XmlDocument
        Dim culture As String = My.Application.Culture.Name
        My.Application.ChangeCulture("en-US")

        Try
            Dim arquivo As New FileInfo(file_xml)

            If arquivo.Exists Then
                Dim SR As New StreamReader(file_xml)
                arquivo = Nothing
                Application.DoEvents()

                doc.Load(file_xml)
                'Leo - 19/08/2015
                'Alterado pois nao achava o nome do retorno da consulta "retConsSitNFe
                If IsNothing(doc.FirstChild.NextSibling) Then
                    tipo = doc.FirstChild.Name
                Else
                    tipo = doc.FirstChild.NextSibling.Name
                End If

                '

                doc = Nothing

                If tipo = "enviNFe" Then ' Envio de Lotes de NFe
                    object_NFe = New enviNFe
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), enviNFe)
                ElseIf tipo = "nfeProc" Then ' NFe já processada e com o protocolo (xml de circulação)
                    object_NFe = New nfeProc
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), nfeProc)
                ElseIf tipo = "NFe" Then ' NFe
                    object_NFe = New NFe
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), NFe)
                ElseIf tipo = "retConsReciNFe" Then '  Retorno da consulta de processamento do lote de NF-e
                    object_NFe = New retConsReciNFe
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retConsReciNFe)
                ElseIf tipo = "retEnviNFe" Then ' Retorno do envio de lote de NFe
                    object_NFe = New retEnviNFe
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retEnviNFe)
                ElseIf tipo = "retEvento" Then ' Retorno do envio do Evento
                    object_NFe = New retEvento
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retEvento)
                ElseIf tipo = "retEnvEvento" Then ' Retorno do envio de lote de Evento
                    object_NFe = New retEnvEvento
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retEnvEvento)
                ElseIf tipo = "retConsSitNFe" Then ' Retorno da consulta da situação da NFe
                    object_NFe = New retConsSitNFe
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retConsSitNFe)
                ElseIf tipo = "retConsStatServ" Then ' Retorno da consulta do status do WebService
                    object_NFe = New retConsStatServ
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retConsStatServ)
                ElseIf tipo = "retInutNFe" Then ' Retorno da consulta do status de Inutilizacao
                    object_NFe = New retInutNFe
                    serializer = New Serialization.XmlSerializer(object_NFe.GetType)
                    object_NFe = DirectCast(serializer.Deserialize(SR), retInutNFe)
                Else
                    MessageBox.Show("Não foi encontrada nenhuma TAG com informações referentes à NFe", " Deserializar_NFe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                SR.Close()
            Else
                MessageBox.Show("Arquivo " & file_xml & " não encontrado.", " Deserializar_NFe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha detectada ao processar Leitura do xml" & vbCrLf & ex.Message, " Deserializar_NFe", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        My.Application.ChangeCulture(culture)
    End Sub

    Private Function NFe() As Object
        Throw New NotImplementedException
    End Function

End Class
