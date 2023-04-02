Imports System.Data.SQLite

Public Class CfopDAO
    'Conexao ao BD
    'Private cn As New ConnectionFactory
    'Private cmd As New SQLiteCommand

    Private _crt As Integer
    Public Sub New(ByVal crt As Integer)
        _crt = crt
    End Sub
    Public Function listarCfop() As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory

        'MySQL
        'sql = "SELECT *,concat(codigo , ' - ' , descricao) AS conjugada FROM tabela "
        'SQLite
        sql = "SELECT *,(codigo || ' - ' || descricao) AS conjugada FROM tabela "
        sql += "WHERE crt=" & _crt & " AND tabela='cfop' "
        sql += "ORDER BY codigo"
        Try
            'myAdap = New SQLiteDataAdapter(sql, cn.getConnection)
            'myAdap.Fill(dataSet, "myTable")
            Dim cnx As New Conexao

            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cstDAO - listarCfop")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
        'cn.getConnection.Close()
    End Function
End Class
