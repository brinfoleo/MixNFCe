Imports System.Data.SQLite

Public Class IbptDAO

    Public Function listarIbpt() As DataSet
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        
        sql = "SELECT * FROM ncm_ibpt "
        sql += "ORDER BY codigo"
        Try
            
            Dim cnx As New Conexao

            cnx.Conectar()
            myAdap = New SQLiteDataAdapter(sql, cnx.c)
            myAdap.Fill(dataSet, "myTable")
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe IbptDAO - listarIBPT")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try
        Return dataSet
        'cn.getConnection.Close()
    End Function
    ''' <summary>
    ''' Pega a instancia da nfce pelo numero do documento (nNF)
    ''' </summary>
    ''' <param name="nNF"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function pgIbpt(ByVal ncm As String) As Ibpt
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader
        Dim ibpt As New Ibpt
        Dim usuDAO As New UsuarioDAO
        sql = "SELECT * FROM ncm_ibpt "
        sql += "WHERE codigo='" & ncm & "'"

        Try
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader

            If dataReader.Read Then
                ibpt.id = dataReader("id").ToString
                ibpt.codigo = dataReader("codigo").ToString
                ibpt.ex = dataReader("ex").ToString
                ibpt.tipo = dataReader("tipo").ToString
                ibpt.descricao = dataReader("descricao").ToString
                ibpt.nacionalFederal = dataReader("nacionalfederal").ToString.Replace(".", ",")
                ibpt.importadosFederal = dataReader("importadosfederal").ToString.Replace(".", ",")
                ibpt.estadual = dataReader("estadual").ToString.Replace(".", ",")
                ibpt.municipal = dataReader("municipal").ToString.Replace(".", ",")
                ibpt.versao = dataReader("versao").ToString

            End If
            cd.Dispose()
            cnx.Desconectar()
            Return ibpt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe IbptDAO - pgIbpt")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            'dataReader.Close()
        End Try

    End Function
End Class
