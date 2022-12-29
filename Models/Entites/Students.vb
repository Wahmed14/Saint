Public Class Students
    Private _id As Integer
    Private _last_name As String
    Private _first_name As String
    Private _phone_number As String
    Private _email As String
    Private _birth_date As Date
    Private _gender As String
    Private _faculty_id As Integer
    Private _picture_path As String

    Public Sub New(id As Integer, last_name As String, first_name As String, phone_number As String, email As String, birth_date As Date, gender As String, faculty_id As Integer, picture_path As String)
        Me.Id = id
        Me.Last_name = last_name
        Me.First_name = first_name
        Me.Phone_number = phone_number
        Me.Email = email
        Me.Birth_date = birth_date
        Me.Gender = gender
        Me.Faculty_id = faculty_id
        Me.Picture_path = picture_path
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

    Public Property First_name As String
        Get
            Return _first_name
        End Get
        Set(value As String)
            _first_name = value
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

    Public Property Birth_date As Date
        Get
            Return _birth_date
        End Get
        Set(value As Date)
            _birth_date = value
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

    Public Property Faculty_id As Integer
        Get
            Return _faculty_id
        End Get
        Set(value As Integer)
            _faculty_id = value
        End Set
    End Property

    Public Property Picture_path As String
        Get
            Return _picture_path
        End Get
        Set(value As String)
            _picture_path = value
        End Set
    End Property
End Class
