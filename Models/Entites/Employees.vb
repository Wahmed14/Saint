Public Class Employees

    Private _id As Integer
    Private _last_name As String
    Private _first__name As String
    Private _phone_number As String
    Private _email As String
    Private _graduation As String
    Private _gender As String
    Private _function_field As String

    Public Sub New(id As Integer, last_name As String, first__name As String, phone_number As String, email As String, graduation As String, gender As String, function_field As String)
        Me.Id = id
        Me.Last_name = last_name
        Me.First__name = first__name
        Me.Phone_number = phone_number
        Me.Email = email
        Me.Graduation = graduation
        Me.Gender = gender
        Me.Function_field = function_field
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Last_name As String
        Get
            Return _last_name
        End Get
        Set(value As String)
            _last_name = value
        End Set
    End Property

    Public Property First__name As String
        Get
            Return _first__name
        End Get
        Set(value As String)
            _first__name = value
        End Set
    End Property

    Public Property Phone_number As String
        Get
            Return _phone_number
        End Get
        Set(value As String)
            _phone_number = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Graduation As String
        Get
            Return _graduation
        End Get
        Set(value As String)
            _graduation = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
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

End Class
