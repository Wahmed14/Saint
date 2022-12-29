Public Class Faculties
    Private _id As Integer
    Private _libelle As String
    Private _sigle As String
    Private _institute_id As Integer

    Public Sub New(id As Integer, libelle As String, sigle As String, institute_id As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Sigle = sigle
        Me.Institutes_id = institute_id
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

    Public Property Sigle As String
        Get
            Return _sigle
        End Get
        Set(value As String)
            _sigle = value
        End Set
    End Property

    Public Property Institutes_id As Integer
        Get
            Return _institute_id
        End Get
        Set(value As Integer)
            _institute_id = value
        End Set
    End Property
End Class
