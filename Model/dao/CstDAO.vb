Imports System.Data.SQLite

Public Class CstDAO
    'Conexao ao BD
    'Private cn As New ConnectionFactory
    'Private cmd As New SQLiteCommand

    Private _crt As Integer
    Public Sub New(ByVal crt As Integer)
        _crt = crt
    End Sub
    Public Function listarOrigens() As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory

        'sql = "SELECT *,concat(codigo , ' - ' , descricao) AS conjugada FROM tabela "
        sql = "SELECT *, (codigo || ' - ' || descricao) AS conjugada FROM tabela "
        sql += "WHERE crt=" & _crt & " AND tabela='origem' "
        sql += "ORDER BY codigo"
        Try
            Dim cnx As New Conexao

            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cstDAO - listarOrigens")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet

    End Function
    Public Function listarCSOSNs() As DataSet

        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory

        'Mysql
        'sql = "SELECT *,concat(codigo , ' - ' , descricao) AS conjugada FROM tabela "
        'SQLite
        sql = "SELECT *,(codigo || ' - ' || descricao) AS conjugada FROM tabela "
        sql += "WHERE crt=" & _crt & " AND tabela='csosn' "
        sql += "ORDER BY codigo"
        Try
            Dim cnx As New Conexao

            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cstDAO - listarCSOSNs")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet

    End Function
End Class
