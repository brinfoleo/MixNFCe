Imports System.Data.SQLite
''' <summary>
''' Gerenciamento dos Produtos do estoque
''' </summary>
''' 
Public Class Produto
    '* RJ, 13.01.2015 - Leonardo Aquino
    '* Classe criada para gerenciamento da base de dados do Produto
    

    Public Sub New()
        'Construtor
    End Sub

    Private _id As Integer
    Private _codigoBarras As String
    Private _descricao As String
    Private _fabricante As String
    Private _unidade As String
    Private _quantidade As Long
    Private _ncm As String
    Private _origem As Integer
    Private _cst As String
    Private _icms As Double
    Private _pis As Double
    Private _cofins As Double
    Private _precoCusto As Double
    Private _precoVenda As Double 
    Private _cfop As String
    'Conexao ao BD
    'Private cn As New ConnectionFactory
    'Private cmd As New SQLiteCommand

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property codigoBarras() As String
        Get
            Return _codigoBarras
        End Get
        Set(ByVal value As String)
            _codigoBarras = value
        End Set
    End Property

    Public Property precoVenda() As Double
        Get
            Return _precoVenda
        End Get
        Set(ByVal value As Double)
            _precoVenda = value
        End Set
    End Property

    Public Property precoCusto() As Double
        Get
            Return _precoCusto
        End Get
        Set(ByVal value As Double)
            _precoCusto = value
        End Set
    End Property

    Public Property cofins() As Long
        Get
            Return _cofins
        End Get
        Set(ByVal value As Long)
            _cofins = value
        End Set
    End Property

    Public Property pis() As Long
        Get
            Return _pis
        End Get
        Set(ByVal value As Long)
            _pis = value
        End Set
    End Property

    Public Property icms() As Long
        Get
            Return _icms
        End Get
        Set(ByVal value As Long)
            _icms = value
        End Set
    End Property

    Public Property origem As Integer
        Get
            Return _origem
        End Get
        Set(ByVal value As Integer)
            _origem = value
        End Set
    End Property

    Public Property cst() As String
        Get
            Return _cst
        End Get
        Set(ByVal value As String)
            _cst = value
        End Set
    End Property

    Public Property ncm() As String
        Get
            Return _ncm
        End Get
        Set(ByVal value As String)
            _ncm = value
        End Set
    End Property

    Public Property quantidade() As Long
        Get
            Return _quantidade
        End Get
        Set(ByVal value As Long)
            _quantidade = value
        End Set
    End Property

    Public Property unidade() As String
        Get
            Return _unidade
        End Get
        Set(ByVal value As String)
            _unidade = value
        End Set
    End Property

    Public Property fabricante() As String
        Get
            Return _fabricante
        End Get
        Set(ByVal value As String)
            _fabricante = value
        End Set
    End Property

    Public Property descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property

    Public Property cfop As String
        Get
            Return _cfop
        End Get
        Set(value As String)
            _cfop = value
        End Set
    End Property

    ''' <summary>
    ''' Valida se o NCM consta na base de dados
    ''' </summary>
    ''' <param name="ncm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function validaNCM(ByVal ncm) As Boolean
        Dim sql As String
        Dim result As Boolean = False

        Dim cnx As New Conexao
        Dim myAdap As SQLiteDataAdapter
        Dim DataSet As New DataSet
        sql = "SELECT * FROM ncm_ibpt WHERE codigo='" & ncm & "'"

        cnx.Conectar()

        myAdap = New SQLiteDataAdapter(sql, cnx.c)
        myAdap.Fill(DataSet, "myTable")
        cnx.Desconectar()

        If DataSet.Tables("myTable").Rows.Count >= 1 Then
            result = True
        Else
            result = False
        End If


        Return result

    End Function
    Public Function save() As Boolean
        If validarProduto() = False Then
            save = False
            Exit Function
        End If
        If Me._id = 0 Then
            save = create()
        Else
            save = update()
        End If
    End Function
    Private Function validarProduto() As Boolean
        'Checa se existe outro produto com o mesmo codigo de barras
        Dim pTst As New Produto

        pTst.id = 0
        pTst.pesqProdutoCodBarr(_codigoBarras)
        If pTst.id <> 0 And pTst.id <> _id Then
            MsgBox("Código de barras já cadastrado, favor verificar!" & vbCrLf & "Operação cancelada.", vbInformation, "Aviso")
            Return False
            Exit Function
        End If

        'Valida o NCM do produto
        If validaNCM(_ncm) = False Then
            MsgBox("NCM Invalido, favor verificar!" & vbCrLf & "Operação cancelada.", vbInformation, "Aviso")
            Return False
            Exit Function
        End If
        'Valida preco de venda
        If _precoVenda = 0 Then
            MsgBox("Preço de venda deve ser diferente de ZERO!" & vbCrLf & "Operação cancelada.", vbInformation, "Aviso")
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function create() As Boolean
        Dim sql As String

        sql = "INSERT INTO produto " & _
            "(codi, nome, fabricante, unidade, saldo, ncm, cst, icms, pis, cofins, custo, venda1,origem_produto,cfop) " & _
            "VALUES ('" & _codigoBarras & "','" & _descricao & "','" & _fabricante & "','" & _unidade & "','" & _quantidade & "','" & _ncm & "','" & _cst & "'," & _
                   _icms & "," & _pis & "," & _cofins & "," & Str(_precoCusto) & "," & Str(_precoVenda) & ",'" & _origem & "','" & _cfop & "')"
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
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Util.log(ex.Message, System.Environment.StackTrace, "")
            create = False
        End Try

    End Function

    Public Sub read()
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader

        sql = "SELECT * FROM produto " & _
              "WHERE id=" & _id
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
                Me._codigoBarras = dataReader("codi").ToString
                Me._descricao = dataReader("nome").ToString
                Me._fabricante = dataReader("fabricante").ToString
                Me._unidade = dataReader("unidade").ToString
                Me._quantidade = dataReader("saldo")
                Me._ncm = dataReader("ncm").ToString
                Me.origem = dataReader("origem_produto")
                Me._cst = dataReader("cst").ToString
                Me._icms = dataReader("icms")
                'Me._cfop = IIf(IsDBNull(dataReader("cfop")), "", dataReader("cfop"))
                Me._cfop = IIf(IsDBNull(dataReader("cfop")), "", "5102")
                ' Me._pis = IIf(IsDBNull(dataReader("pis")), 0.0, dataReader("pis"))
                Me._pis = IIf(IsDBNull(dataReader("pis")), "", "0.0")
                'Me._cofins = IIf(IsDBNull(dataReader("cofins")), 0, dataReader("cofins"))
                Me._cofins = IIf(IsDBNull(dataReader("cofins")), 0, 0)
                'Me._precoCusto = IIf(IsDBNull(dataReader("custo")), 0, dataReader("custo"))
                'Me._precoCusto = IIf(IsDBNull(dataReader("custo")), 0, 0).ToString.Replace(".", ",")
                Me._precoCusto = CDbl(IIf(IsDBNull(dataReader("custo")), 0, dataReader("custo")).ToString.Replace(".", ","))
                Me._precoVenda = CDbl(IIf(IsDBNull(dataReader("venda1")), 0, dataReader("venda1")).ToString.Replace(".", ","))
            End If
            dataReader.Close()
            'cn.getConnection.Close()
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Produto - read")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            '
        End Try

    End Sub
    Public Sub pesqProdutoCodBarr(ByVal codBarr As String)
        Dim sql As String
        Dim myAdap As New SQLiteDataAdapter
        Dim dataReader As SQLiteDataReader

        sql = "SELECT * FROM produto " & _
              "WHERE codi='" & codBarr & "'"
        Try
           
            Dim cnx As New Conexao
            Dim cd As New SQLiteCommand()

            cnx.Conectar()
            cd.Connection = cnx.c
            cd.CommandText = sql
            cd.ExecuteNonQuery()
            dataReader = cd.ExecuteReader

            If dataReader.Read Then
                Me._id = dataReader("id").ToString
                read()
            End If
            dataReader.Close()
            'cn.getConnection.Close()
            cd.Dispose()
            cnx.Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Produto - pesqProdutoCodBarr")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        Finally
            '
        End Try

    End Sub

    Private Function update() As Boolean
        Dim sql As String

        sql = "UPDATE produto "
        sql += "SET codi='" & _codigoBarras & "', nome='" & _descricao & "', fabricante='" & _fabricante
        sql += "', unidade='" & _unidade & "', saldo='" & _quantidade & "', ncm='" & _ncm & "', cst='" & _cst & "',"
        sql += "icms=" & _icms & ", pis=" & Str(_pis) & ", cofins=" & _cofins & ", custo=" & Str(_precoCusto)
        sql += ", venda1=" & Str(_precoVenda) & ", origem_produto='" & _origem & "', cfop='" & _cfop & "'"
        sql += " WHERE id=" & _id

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Produto - update")
            Util.log(ex.Message, System.Environment.StackTrace, "")
            update = False
        End Try

    End Function
    Public Sub delete()
        Dim sql As String

        sql = "DELETE FROM produto " & _
              "WHERE id=" & _id
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Produto - delete")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

    End Sub



    Public Function listarProdutos(ByVal campo As String, ByVal sTexto As String) As DataSet
        'campo = nome da coluna de pesquisa
        'sTexto = texto que sera buscado na tabela
        Dim sql As String
        Dim myAdap As SQLiteDataAdapter
        Dim dataSet As New DataSet
        Dim selectField As String = "id, codi AS EAN, nome AS descricao, unidade, ROUND(venda1,2) AS preco"


        If campo = Nothing Then
            campo = "nome"
        End If

        If sTexto.Trim = "" Then
            sql = "SELECT " & selectField & " FROM produto "
        Else

            'substitui o nome da pesquisa pela coluna visto q o mysql nao aceita alias
            campo = campo.Replace("descricao", "nome")
            campo = campo.Replace("preco", "venda1")
            campo = campo.Replace("EAN", "codi")
            sql = "SELECT " & selectField & " FROM produto " & _
                  "WHERE " & campo & " LIKE '%" & sTexto & "%' "

        End If
        Try
            'Dim cn As New ConnectionFactory
            'Dim cmd As New SQLiteCommand

            Dim cxs As New Conexao
            Dim cd As New SQLiteCommand()

            cxs.Conectar()
            cd.Connection = cxs.c
            cd.CommandText = sql
            'cd.ExecuteNonQuery()



            myAdap = New SQLiteDataAdapter(sql, cxs.c)
            'myAdap = New SQLiteDataAdapter(sql, cn.getConnection)
            myAdap.Fill(dataSet, "myTable")
            'cn.getConnection.Close()


            cd.Dispose()
            cxs.Desconectar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Produto - listarProdutos")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

        Return dataSet
    End Function
    ''' <summary>
    '''  Baixa a quantidade informada no estoque
    ''' </summary>
    ''' <param name="qtd"></param>
    ''' <remarks></remarks>
    Public Sub baixarEstoque(ByVal qtd As Double)
        Dim sql As String
        Dim saldo As Double
        If qtd = origem Then Exit Sub
        saldo = _quantidade - qtd

        sql = "UPDATE produto "
        sql += "SET saldo='" & saldo & "' "
        sql += "WHERE id=" & _id

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Classe Produto - Baixa de estoque")
            Util.log(ex.Message, System.Environment.StackTrace, "")
        End Try

    End Sub

    Public Sub atualizaTabelaDataBase()

        'sql = "ALTER TABLE produto ADD pis DECIMAL(10,3) DEFAULT NULL"
        'sql = "ALTER TABLE produto ADD cofins DECIMAL(10,3) DEFAULT NULL"
        'sql = "UPDATE produto SET icms = 0"


    End Sub
End Class
