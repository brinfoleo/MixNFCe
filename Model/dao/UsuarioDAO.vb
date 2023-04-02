Imports System.Data.SQLite

Public Class UsuarioDAO
    'Conexao ao BD
    'Private cn As New ConnectionFactory
    'Private cmd As New SQLiteCommand


    Public Function save(ByVal usuario As Usuario) As Boolean

        If usuario.id = 0 Then
            save = create(usuario)
        Else
            save = update(usuario)
        End If
    End Function
    Private Function create(ByVal usuario As Usuario) As Boolean
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "INSERT INTO usuario " & _
            "(usuario, cargo,senha) " & _
            "VALUES ('" & usuario.nome & "','" & usuario.cargo & "','" & usuario.senha & "')"
        Try
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
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
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Util.log(ex.Message, System.Environment.StackTrace, "")
            create = False
        End Try
        'cn.getConnection.Close()
    End Function

    Public Function read(ByVal id As Integer) As Usuario
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader
        Dim usu As New Usuario
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "SELECT * FROM usuario " & _
              "WHERE id=" & id
        Try
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
                Try
                    usu.id = id
                    usu.nome = dataReader("usuario").ToString
                    usu.cargo = dataReader("cargo").ToString
                    usu.senha = dataReader("senha").ToString


                    Return usu
                Catch ex As Exception
                    MsgBox("Erro ao recuperar dados do usuario." & vbCrLf & ex.Message)
                    Util.log(ex.Message, System.Environment.StackTrace, "")
                End Try
            End If
            dataReader.Close()
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Usuario")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            'cn.getConnection.Close()
            'dataReader.Close()
        End Try

        'dataReader.Close()
    End Function
    Private Function update(ByVal usu As Usuario) As Boolean
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "UPDATE usuario " & _
            "SET usuario='" & usu.nome & "', cargo='" & usu.cargo & "', senha='" & usu.senha & "' " & _
            "WHERE id=" & usu.id
        Try
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
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
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Util.log(ex.Message, System.Environment.StackTrace, "")
            update = False
        End Try
        'cn.getConnection.Close()
    End Function
    Public Sub delete(ByVal id As Integer)
        Dim sql As String
        'Dim cn As New ConnectionFactory
        'Dim cmd As New SQLiteCommand
        sql = "DELETE FROM usuario " & _
              "WHERE id=" & id
        Try
            'cmd = cn.getCommand(sql)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
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
        'cn.getConnection.Close()
    End Sub

    Public Function listarUsuarios() As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory

        sql = "SELECT * FROM usuario " & _
              "ORDER BY usuario"
        Try
            'myAdap = New SQLiteDataAdapter(sql, cn.getConnection)
            'myAdap.Fill(dataSet, "myTable")
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Usuario")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

        Return dataSet
        'cn.getConnection.Close()
    End Function
    Public Function listarUsuariosEspecificos(ByVal sTexto As String) As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        'Dim cn As New ConnectionFactory

        If sTexto.Trim = "" Then
            sql = "SELECT * FROM usuario " & _
                  "ORDER BY usuario"
        Else
            sql = "SELECT * FROM usuario " & _
                  "WHERE usuario LIKE '%" & sTexto & "%' " & _
                  "ORDER BY usuario"

        End If
        Try
            'myAdap = New SQLiteDataAdapter(sql, cn.getConnection)
            'myAdap.Fill(dataSet, "myTable")
            Dim cnx As New Conexao
            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Usuario")
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
