Imports System.Data.SQLite

Public Class FormaPagamentoDAO
    'Conexao ao BD
    'Private cn As New ConnectionFactory
    'Private cmd As New SQLiteCommand


    ''' <summary>
    ''' 'Retorna a forma de pagamento
    ''' </summary>
    ''' <param name="tPag">Tipo de pagamento conforme NT da SEFAZ</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function read(ByVal tPag As String) As FormaPagamento
        Dim fp As New FormaPagamento
        Dim tPg As Integer
        Try
            tPg = tPag

        Catch ex As Exception
            tPg = 0
        End Try
        Select Case tPg
            Case 1
                fp.tPag = 1
                fp.nomepg = "Dinheiro"

            Case 2
                fp.tPag = 2
                fp.nomepg = "Cheque"
            Case 3
                fp.tPag = 3
                fp.nomepg = "Cartao de Credito"
            Case 4
                fp.tPag = 4
                fp.nomepg = "Cartao de Debito"
            Case 5
                fp.tPag = 5
                fp.nomepg = "Credito Loja"
            Case 10
                fp.tPag = 10
                fp.nomepg = "Vale Alimentacao"
            Case 11
                fp.tPag = 11
                fp.nomepg = "Vale Refeicao"
            Case 99
                fp.tPag = 99
                fp.nomepg = "Outros"
            Case Else
                fp.tPag = 99
                fp.nomepg = "Outros"
        End Select

        fp.moeda = fp.nomepg

        '01/12/2015 - Leonardo Aquino
        'Forma de pagamento comentada pois como estamos usando as formas fixas
        'de pagamento informadas no Manual do Usuario NFe 6.0
        '
        'Dim fp As New FormaPagamento
        'Dim myAdap As New SQLiteDataAdapter
        'Dim dataReader As SQLiteDataReader
        'Dim sql As String

        'sql = "SELECT * FROM formapgto WHERE tPag='" & tPag & "'"

        'Try
        '    Dim cnx As New Conexao
        '    Dim cd As New SQLiteCommand()

        '    cnx.Conectar()
        '    cd.Connection = cnx.c
        '    cd.CommandText = sql
        '    cd.ExecuteNonQuery()
        '    dataReader = cd.ExecuteReader

        '    If dataReader.Read Then
        '        fp.id = dataReader.Item("id")
        '        fp.nomepg = dataReader.Item("nomepg").ToString
        '        fp.bandeira = dataReader.Item("bandeira_tef").ToString
        '        fp.tPag = dataReader.Item("tPag").ToString
        '        fp.moeda = dataReader.Item("moeda").ToString
        '        dataReader.Close()
        '        cd.Dispose()
        '        cnx.Desconectar()

        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe FormaPagamentoDAO - read")
        '    Util.log(ex.Message, System.Environment.StackTrace, "FormaPagamentoDAO - read")
        'End Try
        Return fp

    End Function
End Class
