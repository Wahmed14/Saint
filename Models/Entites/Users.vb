Public Class Users
    Private _id As Integer
    Private _username As String
    Private _function_field As String
    Private _password_field As String

    Public Sub New(id As Integer, username As String, function_field As String, password_field As String)
        Me.Id = id
        Me.Username = username
        Me.Function_field = function_field
        Me.Password_field = password_field
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Function_field As String
        Get
            Return _function_field
        End Get
        Set(value As String)
            _function_field = value
        End Set
    End Property

    Public Property Password_field As String
        Get
            Return _password_field
        End Get
        Set(value As String)
            _password_field = value
        End Set
    End Property
End Class
