Imports System.Data.SQLite

Public Class ConnectionFactory
    'Private c As New SQLiteConnection()
    Private c As New SQLiteConnection
    Public Sub New()
        'SQLite
        Dim localdb As String
        Dim sConnectionString As String

        localdb = Application.StartupPath.ToString & "\db\mixdbX.db"

        'sConnectionString = "Data Source=" & localdb & ";Version=3;New=True;Compress=True;"
        sConnectionString = "Data Source=" & localdb & ";Version=3;"

        Try
            c.ConnectionString = sConnectionString
            c.Open()

        Catch ex As SQLiteException

            MsgBox("Classe ConnectionFactory: Erro de leitura no banco de dados." & vbCrLf & _
                   "Verifique sua Conexão!" & vbCrLf & _
                   "Mensagem: " & ex.Message, _
                   MsgBoxStyle.Critical, "Erro de conexão")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

        'MySQL
        'c.ConnectionString = "server=" & strEndMysql & "; database=" & strBancoMysql & "; Uid=" & strUsuarioMysql & "; Pwd=" & strSenhaMysql & "; Min Pool Size=0;Max Pool Size = 100; Connection Lifetime =600;Pooling = true; Connection reset = true"
        'Try
        '    c.Open()
        'Catch myerro As MySqlException
        '    MsgBox("Classe ConnectionFactory: Erro de leitura no banco de dados." & vbCrLf & "Verifique sua Conexão!" & vbCrLf & "Mensagem: " & myerro.Message, MsgBoxStyle.Critical, "Erro de conexão")
        'End Try
    End Sub
    Public Function getConnection() As SQLiteConnection

        Return Me.c
    End Function


    Public Function getCommand(ByVal sql As String) As SQLiteCommand
        Dim mySqlCmd As New SQLiteCommand()

        Try

            mySqlCmd.Connection = c
            'mySqlCmd = c.CreateCommand
            mySqlCmd.CommandText = sql
            'mySqlCmd.ExecuteNonQuery()
            'Me.c.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return mySqlCmd

    End Function
    'Public Sub executeNonQuery(sql As String)
    '    'cmd = c.getCommand(Sql)
    '    'cmd.ExecuteNonQuery()
    '    Dim mySqlCmd As New SQLiteCommand()

    '    Try

    '        mySqlCmd.Connection = c
    '        mySqlCmd.CommandText = sql
    '        mySqlCmd.ExecuteNonQuery()
    '        Me.c.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ConnectionFactory - executeNonQuery")
    '        Util.log(ex.Message, System.Environment.StackTrace, "")
    '    End Try
    '
    ' End Sub


End Class
