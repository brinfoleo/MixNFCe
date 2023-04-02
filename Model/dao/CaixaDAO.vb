Imports System.Data.SQLite
Public Class CaixaDAO
    'Conexao ao BD
    'Private cn As New ConnectionFactory
    'Private cmd As New SQLiteCommand


    Public Function save(ByVal cx As Caixa) As Boolean

        save = create(cx)

    End Function
    Private Function create(ByVal cx As Caixa) As Boolean
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand

        sql = "INSERT INTO caixa " & _
            "(dataMov,operadorID,codigo, valor,descricao,cd,documento,moeda) "
        sql += "VALUES ("
        sql += "'" & Format(cx.data, "yyyy-MM-dd") & "'"
        sql += ",'" & cx.usuario.id & "'"
        sql += ",'" & cx.codigo & "'"
        sql += "," & Str(cx.valor) & ""
        sql += ",'" & cx.descricao & "'"
        sql += ",'" & cx.cd & "'"
        sql += ",'" & cx.documento & "'"
        sql += ",'" & cx.moeda & "'"
        sql += ")"
        Try
            Dim cxs As New Conexao
            Dim cd As New SQLiteCommand()

            cxs.Conectar()
            cd.Connection = cxs.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cxs.Desconectar()
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()


            create = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe CaixaDAO - create")
            create = False
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        'cn.getConnection.Close()
    End Function

    Public Function read(ByVal id As Integer) As Caixa
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader  'SQLiteDataReader
        Dim cx As New Caixa
        Dim usuDAO As New UsuarioDAO
        sql = "SELECT * FROM caixa " & _
              "WHERE id=" & id
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand
            'cmd = cn.getCommand(sql)

            'dataReader = cmd.ExecuteReader

            '**********
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader



            If dataReader.Read Then
                cx.id = id
                cx.data = dataReader.Item("dataMov").ToString
                cx.codigo = dataReader.Item("codigo").ToString
                cx.valor = dataReader.Item("valor")
                cx.usuario = usuDAO.read(dataReader.Item("operadorID").ToString)
                cx.codigo = dataReader.Item("descricao").ToString
                cx.codigo = dataReader.Item("cd").ToString
                cx.documento = dataReader.Item("documento").ToString
                cx.moeda = dataReader.Item("moeda").ToString
                Return cx
            End If
            'cn.getConnection.Close()
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe CaixaDAO - read")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            dataReader.Close()
        End Try

    End Function
    Public Function listarResumoPgto(ByVal operador As Integer, ByVal dtIni As Date, ByVal dtFin As Date) As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter 'SQLiteDataAdapter
        Dim dataSet As New DataSet

        sql = "SELECT moeda,  strftime('%d/%m/%Y', datamov) as data, SUM(valor) AS valor, operadorID FROM caixa"
        sql += " WHERE operadorID= " & operador
        'sql += " AND cd='C'"
        sql += " AND dataMov BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        sql += " GROUP BY moeda, dataMov"
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand
            'myAdap = New SQLiteDataAdapter(sql, cn.getConnection)
            'myAdap.Fill(dataSet, "myTable")
            'cn.getConnection.Close()
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe CaixaDAO")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
    End Function
    Public Function listarMovimentoCaixa(ByVal dtIni As Date, ByVal dtFin As Date) As DataSet



        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet

        sql = "SELECT  strftime('%d/%m/%Y', datamov) as data, codigo, descricao,CAST(valor as real) as valor, cd, operadorID "
        sql += " FROM caixa"
        sql += " WHERE" 'nProt IS NULL"
        sql += " dataMov BETWEEN ('" & Format(dtIni, "yyyy-MM-dd") & "') AND ('" & Format(dtFin, "yyyy-MM-dd") & "')"
        'sql += " AND ide_serie = '" & nfeSerie & "'"
        'sql += " AND ide_tpAmb = '" & strAmbiente & "'"
        sql += " ORDER BY moeda, id"



        Try
            Dim cnx As New Conexao

            cnx.Conectar()

            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cliente")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
    End Function
End Class
