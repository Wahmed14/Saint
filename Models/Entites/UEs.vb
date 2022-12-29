Public Class UEs
    Private _id As Integer
    Private _libelle As String
    Private _semester As Integer
    Private _faculty_id As Integer

    Public Sub New(id As Integer, libelle As String, semester As Integer, faculty_id As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Semester = semester
        Me.Faculty_id = faculty_id
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Libelle As String
        Get
            Return _libelle
        End Get
        Set(value As String)
            _libelle = value
        End Set
    End Property

    Public Property Semester As Integer
        Get
            Return _semester
        End Get
        Set(value As Integer)
            _semester = value
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
End Class
