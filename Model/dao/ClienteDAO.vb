Imports System.Data.SQLite

Public Class ClienteDAO
    'Conexao ao BD
   


    Public Function save(ByVal cli As Cliente) As Boolean

        If cli.id = 0 Then
            save = create(cli)
        Else
            save = update(cli)
        End If
    End Function
    Private Function create(ByVal cli As Cliente) As Boolean
        Dim sql As String

        sql = "INSERT INTO clientes " & _
            "(bloqueio, dtCadastro,xNome, cnpj, xLgr, nro, xCpl, xBairro,cMun,xMun,uf,cep,cpais,xpais,fone,email,obs ) " & _
            "VALUES (" & IIf(cli.bloqueado = True, "1", "0") & ",'" & cli.dtCadastro & "','" & cli.xNome & "','" & _
            cli.cnpj & "','" & cli.xLgr & "','" & _
            cli.nro & "','" & cli.xCpl & "','" & cli.xBairro & "','" & cli.cMun & "','" & _
            cli.xMun & "','" & cli.uf & "','" & cli.cep & "','" & cli.cPais & "','" & _
            cli.xPais & "','" & cli.fone & "','" & cli.email & "','" & _
            cli.obs & "')"
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            'cn.getConnection.Close()

            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cnx.Desconectar()

            create = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClienteDAO - create")
            Util.log(ex.Message, System.Environment.StackTrace, "")
            create = False
        End Try

    End Function

    Public Function read(ByVal id As Integer) As Cliente
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader
        Dim cli As New Cliente
        sql = "SELECT * FROM clientes " & _
              "WHERE id=" & id
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand
            'cmd = cn.getCommand(sql)
            'dataReader = cmd.ExecuteReader
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader


            If dataReader.Read Then
                cli.id = id
                cli.xNome = dataReader.Item("xNome").ToString
                cli.cnpj = dataReader.Item("cnpj").ToString
                cli.xLgr = dataReader.Item("xlgr").ToString
                cli.nro = dataReader.Item("nro").ToString
                cli.xCpl = dataReader.Item("xcpl").ToString
                cli.xBairro = dataReader.Item("xbairro").ToString
                cli.cMun = dataReader.Item("cMun").ToString
                cli.xMun = dataReader.Item("xMun").ToString
                cli.uf = dataReader.Item("uf").ToString
                cli.cep = dataReader.Item("cep").ToString
                cli.cPais = dataReader.Item("cpais").ToString
                cli.xPais = dataReader.Item("xpais").ToString
                cli.fone = dataReader.Item("fone").ToString
                cli.email = dataReader.Item("email").ToString
                cli.obs = dataReader.Item("obs").ToString
                cli.dtCadastro = dataReader.Item("dtCadastro").ToString
                cli.bloqueado = IIf(IsDBNull(dataReader.Item("bloqueio")), False, dataReader("bloqueio"))
                dataReader.Close()

            End If
            'cn.getConnection.Close()
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe ClienteDAO")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return cli
    End Function
    Private Function update(ByVal cli As Cliente) As Boolean
        Dim sql As String

        sql = "UPDATE clientes " & _
                "SET xNome='" & cli.xNome & "',cnpj='" & cli.cnpj & "',xLgr='" & cli.xLgr & "',nro='" & _
                cli.nro & "',xCpl='" & cli.xCpl & "',xBairro='" & cli.xBairro & "',cmun='" & cli.cMun & "',xmun='" & _
                cli.xMun & "',uf='" & cli.uf & "',cep='" & cli.cep & "',cpais='" & cli.cPais & "',xpais='" & _
                cli.xPais & "',fone='" & cli.fone & "',email='" & cli.email & "', obs=' " & cli.obs & _
                "', dtCadastro='" & cli.dtCadastro & "', bloqueio=" & IIf(cli.bloqueado = True, 1, 0) & " " & _
                "WHERE id=" & cli.id


        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            'cn.getConnection.Close()
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cnx.Desconectar()
            update = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe ClienteDAO - update")
            Util.log(ex.Message, System.Environment.StackTrace, "")
            update = False
        End Try

    End Function
    Public Sub delete(ByVal id As Integer)
        Dim sql As String

        sql = "DELETE FROM clientes " & _
              "WHERE id=" & id
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            'cn.getConnection.Close()

            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            cd.Dispose()
            cnx.Desconectar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

    End Sub

    Public Function listarClientes() As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand

        sql = "SELECT * FROM clientes " & _
              "ORDER BY cliente"
        Try
            Dim cnx As New Conexao
            'Dim cd As New SQLiteCommand()

            cnx.Conectar()
            'cd.Connection = cnx.c
            'cd.CommandText = sql
            'cd.ExecuteNonQuery()
            'cd.Dispose()


            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe cliente")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
        'cn.getConnection.Close()
    End Function

    Public Function listar(ByVal campo As String, ByVal sTexto As String) As DataSet
        'campo = nome da coluna de pesquisa
        'sTexto = texto que sera buscado na tabela
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        Dim selectField As String = "id, xNome AS Nome,fone"

        If campo.Trim = "" Then
            campo = "nome"
        End If

        If sTexto.Trim = "" Then
            sql = "SELECT " & selectField & " FROM clientes "
        Else
            'substitui o nome da pesquisa pela coluna visto q o mysql nao aceita alias
            campo = campo.Replace("nome", "xNome")

            sql = "SELECT " & selectField & " FROM clientes " & _
                  "WHERE " & campo & " LIKE '%" & sTexto & "%' "

        End If
        Try
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe ClienteDAO - listar")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
        'cn.getConnection.Close()
    End Function
    Public Sub atualizaTabelaDataBase()

        'sql = "ALTER TABLE produto ADD pis DECIMAL(10,3) DEFAULT NULL"
        'sql = "ALTER TABLE produto ADD cofins DECIMAL(10,3) DEFAULT NULL"
        'sql = "UPDATE produto SET icms = 0"

    End Sub

End Class
