Imports System.Data.SQLite

Public Class Usuario
    


    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nome As String
    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    
    Private _cargo As String
    Public Property cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property

    Private _senha As String
    Public Property senha As String
        Get
            Return _senha
        End Get
        Set(ByVal value As String)
            _senha = value
        End Set
    End Property
    ''' <summary>
    ''' peso - o inteiro para saber o nivel de privilegio do usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private _peso As Integer
    Public ReadOnly Property peso As Integer
        Get
            Try
                If _cargo.ToLower = "caixa" Then
                    Return 1
                ElseIf _cargo.ToLower = "fiscal" Then
                    Return 2
                ElseIf _cargo.ToLower = "supervisor" Then
                    Return 3
                Else
                    Return 0
                End If

                
            Catch ex As Exception
                Return 0
                Util.log(ex.Message, System.Environment.StackTrace, "")
            End Try

            
            
        End Get
    End Property
    
End Class
